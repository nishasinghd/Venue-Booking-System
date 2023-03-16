using System.Windows;

namespace assignmentOne
{
    public partial class Form1 : Form
    {
        Venu venu = new Venu();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetCapicityStatus();
        }
        #region Button Actions
        private void btnBook_Click(object sender, EventArgs e)
        {
            var bookingUserSelction = GetUserSelection();
            var validateUserSelection = ValidateUserSelection(bookingUserSelction.Name, bookingUserSelction.SeatNumber);
            if (validateUserSelection)
            {
                lblNotif.Text = "";// clear previous messages
                bool spotAvailable = venu.CheckSeatAvailable(bookingUserSelction.SeatNumber);
                bool spaceAvailable = venu.CheckBookingAvailable();
                lblNotif.Text += !spotAvailable ? "Chosen seat is already taken" : !spaceAvailable ? "No space available" : "";
                if (!spotAvailable)
                {
                    // if spot was occupied,display and suggest to try other seat
                    lblNotif.Text = "Chosen seat is already taken";
                    if (spaceAvailable)
                        lblNotif.Text += "Other space is available, change ROW & Seat#";
                }
                else
                {
                    var booking = venu.GetBookingBySeatNumber(bookingUserSelction.SeatNumber);
                    // If book space is available then book and change the color and break the loop
                    if (booking.Available)
                    {
                        lblNotif.Text = $"{bookingUserSelction.Name} was booked in seat {bookingUserSelction.SeatNumber}";
                        //the space is available, book it
                        venu.UpdateBooking(booking, bookingUserSelction.Name, false);
                        UpdateSeatColor(bookingUserSelction.SeatNumber, false);
                    }

                    if (!spaceAvailable)
                    {
                        venu.AddToWaitingList(bookingUserSelction);
                        lblNotif.Text = "No space was available, user has been added to waiting list";

                    }
                }
            }
            GetCapicityStatus();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //3a.Choose the seat row &number to be canceled.
            var bookingUserSelction = GetUserSelection();
            if (!string.IsNullOrEmpty(bookingUserSelction.SeatNumber))
            {
                var checkSeatOccupied = venu.CheckSeatOccupied(bookingUserSelction.SeatNumber);
                if (checkSeatOccupied)
                {
                    // prompt the confirmation before clearing in array
                    var confirmResult = ConfirmationCancelBooking("Are you sure to cancel this booking?");
                    if (confirmResult == DialogResult.Yes)
                    {
                        // If 'Yes', then cancel
                        UpdateSeatColor($"{bookingUserSelction.SeatNumber}", true);
                        venu.CancelSeatBooking(bookingUserSelction.SeatNumber);
                        lblNotif.Text = $"{bookingUserSelction.SeatNumber} booking was cancelled. ";
                        // rebook from waiting list
                        bool isBookedFromWaitingList = venu.WaitingListBooking(bookingUserSelction.SeatNumber);
                        if (isBookedFromWaitingList)
                        {
                            lblNotif.Text += $"{bookingUserSelction.SeatNumber} booking was rebooked from waiting list";
                            UpdateSeatColor($"{bookingUserSelction.SeatNumber}", false);
                        }
                    }
                    else
                    {
                        // If 'No', do nothing
                    }

                }
                else
                {
                    lblNotif.Text = $"{bookingUserSelction.SeatNumber} was not booked. Nothing to cancel.";
                }
            }
            else
            {
                lblNotif.Text = $"Select row and column to cancel the booking.";
            }
            GetCapicityStatus();
        }
        private void btnCancelAll_Click(object sender, EventArgs e)
        {
            var confirmResult = ConfirmationCancelBooking("Are you sure to cancel all bookings?");
            if (confirmResult == DialogResult.Yes)
            {
                for (int i = 0; i < venu.BookingList.Count; i++)
                {
                    if (venu.BookingList[i] != null)
                    {
                        string seatNumber = venu.BookingList[i].SeatNumber;
                        // Update seat color
                        UpdateSeatColor(seatNumber, true);
                        //Update booking in list
                        venu.UpdateBooking(i, "", true);
                        // rebook from waiting list
                        bool isBookedFromWaitingList = venu.WaitingListBooking(seatNumber);
                        if (isBookedFromWaitingList)
                        {
                            lblNotif.Text += $"{seatNumber} booking was rebooked from waiting list";
                            UpdateSeatColor($"{seatNumber}", false);
                        }
                    }
                }
                lblNotif.Text = "All Seats are available";
            }
            GetCapicityStatus();
        }
        private void btnFillAll_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            if (string.IsNullOrEmpty(name))
            {
                lblNotif.Text = $"{(string.IsNullOrEmpty(name) ? "Name is missing." : "")}";
            }
            else
            {
                for (int i = 0; i < venu.BookingList.Count; i++)
                {
                    if (venu.BookingList[i].Available)
                    {
                        /// Update seat color
                        UpdateSeatColor(venu.BookingList[i].SeatNumber, false);
                        //Update booking in list
                        venu.UpdateBooking(i, name, false);
                    }
                }
                lblNotif.Text = "All seats were booked.";
            }
        }
        private void btnAddWait_Click(object sender, EventArgs e)
        {
            var bookingUserSelction = GetUserSelection();
            var validateUserSelection = !string.IsNullOrEmpty(bookingUserSelction.Name);// ValidateUserSelection(bookingUserSelction.Name, bookingUserSelction.SeatNumber);

            if (validateUserSelection)
            {
                bool spaceAvailable = venu.CheckBookingAvailable();
                //2d: d.	If seats are available, “add to waiting list” button will not do anything, except showing a message “Seats are available”.
                if (spaceAvailable)
                {
                    lblNotif.Text = "Seats are available";
                }
                else //2C c.	If no seats are available, “Book” and “Add to waiting list” buttons will add the person to the waiting list.
                {
                    
                    //BookingList.Where(x => x.SeatNumber == rowSelected + numberSelected).FirstOrDefault();
                    venu.AddToWaitingList(bookingUserSelction);
                    lblNotif.Text = $"No space was available, Customer {bookingUserSelction.Name} has been added to waiting list";



                }
            }
            else
            {
                lblNotif.Text = "Enter the name of customer";
            }
            GetCapicityStatus();
        }

        #endregion

        private DialogResult ConfirmationCancelBooking(string message)
        {
            var confirmResult = MessageBox.Show(message,"Confirm Delete!!",MessageBoxButtons.YesNo);
            return confirmResult;

        }
        #region Seats Mouse hover        
        private void btnSeat_Mousehover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            var text = (sender as Button).Text;
            Control name = (sender as Control);
            var booking = venu.GetBookingBySeatNumber(text);
            if (booking.Available)
                tip.SetToolTip(name, $"Available for booking");
            else
                tip.SetToolTip(name, $"Booked by customer: {booking.Name}");
        }
        #endregion

        private void ResetWaitingListVisual()
        {
            rTxtBWaitingLst.Text = "";
            foreach (var item in venu.WaitingList)
            {
                rTxtBWaitingLst.Text += $"{item}\n";
            }
        }
        private void GetCapicityStatus()
        {
            int seatsAvailable = 0;
            int waitingList = venu.WaitingList.Count;
            for (int i = 0; i < venu.BookingList.Count; i++)
            {
                if (venu.BookingList[i].Available)
                    seatsAvailable++;
            }
            float capacity = (seatsAvailable * 100 / venu.BookingList.Count);
            lblCapacityInfo.Text = $"Total capacity: {venu.BookingList.Count}, Seats Available {seatsAvailable} (i.e at {capacity}% capacity.";
            lblCapacityInfo.Text += $"{(waitingList > 0 ? $"# on the waiting list: {waitingList}." : "no one is on the wait list.")}";
            ResetWaitingListVisual();

        }
        private Booking GetUserSelection()
        {
            string name = txtName.Text;
            string rowSelected = lstBoxRows.GetItemText(lstBoxRows.SelectedItem);
            string numberSelected = lstBoxCol.GetItemText(lstBoxCol.SelectedItem);
            return new Booking(name, rowSelected + numberSelected);
        }
        private bool ValidateUserSelection(string name, string seatNumber)
        {
            // Check the Name, Row & Col is selected
            // Do Validation 4 a, b
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(seatNumber))
            {
                lblNotif.Text = $"{(string.IsNullOrEmpty(name) ? "Name is missing." : "")}";
                lblNotif.Text += $"{(string.IsNullOrEmpty(seatNumber)? "The row or seat is not selected." : "")}";
                return false; // No booking further
            }
            else
                return true;
        }
        
        /// <summary>
        /// Clear or book the selected seat. true to Book(red) and false to vacant(green)
        /// </summary>
        /// <param name="selectedRowCol"></param>
        /// <param name="available"></param>
        private void UpdateSeatColor(string selectedRowCol, bool available)
        {
            string textBox = "btn" + selectedRowCol;
            Button btn = Controls.Find(textBox, true).FirstOrDefault() as Button;
            if (btn != null)
            {
                if (available)
                    btn.BackColor = Color.Lime;
                else
                    btn.BackColor = Color.Red;
            }
        }
    }
}