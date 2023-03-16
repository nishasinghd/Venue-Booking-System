using System.Windows.Forms;

namespace assignmentOne
{
    public class Venu
    {
        public List<string> WaitingList { get; set; } = new List<string>();
        public List<Booking> BookingList { get; set; } = new List<Booking> {
            new Booking("", "A1", true),
            new Booking("", "A2", true),
            new Booking("", "A3", true),
            new Booking("", "A4", true),
            new Booking("", "B1", true),
            new Booking("", "B2", true),
            new Booking("", "B3", true),
            new Booking("", "B4", true),
            new Booking("", "C1", true),
            new Booking("", "C2", true),
            new Booking("", "C3", true),
            new Booking("", "C4", true)
        };
        public Venu()
        {

        }

        /// <summary>
        /// Check booking by seat number
        /// </summary>
        /// <param name="seatNumber"></param>
        /// <returns></returns>
        public Booking GetBookingBySeatNumber(string seatNumber)
        {
            foreach (var x in BookingList)
            {
                if (x.SeatNumber == seatNumber)
                    return x;
            }
            return null;
        }
        /// <summary>
        /// Any seat is available
        /// </summary>
        /// <returns></returns>
        public bool CheckBookingAvailable()
        {
            foreach(var x in BookingList)
            {
                if (x.Available)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Check seat is available
        /// </summary>
        /// <param name="seatNumber"></param>
        /// <returns></returns>
        public bool CheckSeatAvailable(string seatNumber)
        {
            var booking = GetBookingBySeatNumber(seatNumber);
            return booking.Available;
        }

        /// <summary>
        /// Check seat is occupied
        /// </summary>
        /// <param name="seatNumber"></param>
        /// <returns></returns>
        public bool CheckSeatOccupied(string seatNumber)
        {
            return !CheckSeatAvailable(seatNumber);
        }
        /// <summary>
        /// Cancel Seat Booking
        /// </summary>
        /// <param name="rowSelected"></param>
        /// <param name="numberSelected"></param>
        public void CancelSeatBooking(string seatNumber)
        {
            var booking = BookingList.Where(x => x.SeatNumber == seatNumber).FirstOrDefault();
            if (booking != null){               
                //Update booking in list
                booking.Name = "";
                booking.Available = true;
            }
        }

        public void UpdateBooking(int bookingIndex, string name, bool available)
        {
            //Update booking in list
            BookingList[bookingIndex].Name = name;
            BookingList[bookingIndex].Available = available;

        }
        public void UpdateBooking(Booking booking, string name, bool available)
        {
            //Update booking in list
            booking.Name = name;
            booking.Available = available;
        }

        public void AddToWaitingList(Booking booking)
        {
            // if no space was available,display and add to waiting list
            WaitingList.Add(booking.Name);
        }

        public bool WaitingListBooking(string seatNumber)
        {
            if (WaitingList.Count > 0)
            {
                for(int i = 0; i < WaitingList.Count; i++)
                {
                    var waitingListName = WaitingList[i];
                    if (!string.IsNullOrEmpty(waitingListName))
                    {
                        var booking = GetBookingBySeatNumber(seatNumber);
                        booking.Name = waitingListName;
                        booking.Available = false;
                        WaitingList.Remove(waitingListName);
                        return true;
                    }
                    
                }
                
            }
            return false;
        }
    }
}
