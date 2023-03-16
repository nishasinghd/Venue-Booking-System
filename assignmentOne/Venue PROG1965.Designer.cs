namespace assignmentOne
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCapacityInfo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnC4 = new System.Windows.Forms.Button();
            this.btnC3 = new System.Windows.Forms.Button();
            this.btnC2 = new System.Windows.Forms.Button();
            this.btnC1 = new System.Windows.Forms.Button();
            this.btnB4 = new System.Windows.Forms.Button();
            this.btnB3 = new System.Windows.Forms.Button();
            this.btnB2 = new System.Windows.Forms.Button();
            this.btnB1 = new System.Windows.Forms.Button();
            this.btnA4 = new System.Windows.Forms.Button();
            this.btnA3 = new System.Windows.Forms.Button();
            this.btnA2 = new System.Windows.Forms.Button();
            this.btnA1 = new System.Windows.Forms.Button();
            this.lblRows = new System.Windows.Forms.Label();
            this.lblColumns = new System.Windows.Forms.Label();
            this.lstBoxRows = new System.Windows.Forms.ListBox();
            this.lstBoxCol = new System.Windows.Forms.ListBox();
            this.lblCusName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddWait = new System.Windows.Forms.Button();
            this.btnFillAll = new System.Windows.Forms.Button();
            this.btnCancelAll = new System.Windows.Forms.Button();
            this.lblNotif = new System.Windows.Forms.Label();
            this.rTxtBWaitingLst = new System.Windows.Forms.RichTextBox();
            this.lblWaitingList = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCapacityInfo
            // 
            this.lblCapacityInfo.AutoSize = true;
            this.lblCapacityInfo.Location = new System.Drawing.Point(43, 9);
            this.lblCapacityInfo.Name = "lblCapacityInfo";
            this.lblCapacityInfo.Size = new System.Drawing.Size(88, 15);
            this.lblCapacityInfo.TabIndex = 0;
            this.lblCapacityInfo.Text = "Capacity Status";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnC4);
            this.groupBox1.Controls.Add(this.btnC3);
            this.groupBox1.Controls.Add(this.btnC2);
            this.groupBox1.Controls.Add(this.btnC1);
            this.groupBox1.Controls.Add(this.btnB4);
            this.groupBox1.Controls.Add(this.btnB3);
            this.groupBox1.Controls.Add(this.btnB2);
            this.groupBox1.Controls.Add(this.btnB1);
            this.groupBox1.Controls.Add(this.btnA4);
            this.groupBox1.Controls.Add(this.btnA3);
            this.groupBox1.Controls.Add(this.btnA2);
            this.groupBox1.Controls.Add(this.btnA1);
            this.groupBox1.Location = new System.Drawing.Point(43, 74);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(240, 194);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venue:";
            // 
            // btnC4
            // 
            this.btnC4.BackColor = System.Drawing.Color.Lime;
            this.btnC4.Location = new System.Drawing.Point(176, 138);
            this.btnC4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnC4.Name = "btnC4";
            this.btnC4.Size = new System.Drawing.Size(38, 34);
            this.btnC4.TabIndex = 1;
            this.btnC4.Text = "C4";
            this.btnC4.UseVisualStyleBackColor = false;
            this.btnC4.MouseHover += new System.EventHandler(this.btnSeat_Mousehover);
            // 
            // btnC3
            // 
            this.btnC3.BackColor = System.Drawing.Color.Lime;
            this.btnC3.Location = new System.Drawing.Point(122, 138);
            this.btnC3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnC3.Name = "btnC3";
            this.btnC3.Size = new System.Drawing.Size(38, 34);
            this.btnC3.TabIndex = 1;
            this.btnC3.Text = "C3";
            this.btnC3.UseVisualStyleBackColor = false;
            this.btnC3.MouseHover += new System.EventHandler(this.btnSeat_Mousehover);
            // 
            // btnC2
            // 
            this.btnC2.BackColor = System.Drawing.Color.Lime;
            this.btnC2.Location = new System.Drawing.Point(72, 138);
            this.btnC2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnC2.Name = "btnC2";
            this.btnC2.Size = new System.Drawing.Size(38, 34);
            this.btnC2.TabIndex = 1;
            this.btnC2.Text = "C2";
            this.btnC2.UseVisualStyleBackColor = false;
            this.btnC2.MouseHover += new System.EventHandler(this.btnSeat_Mousehover);
            // 
            // btnC1
            // 
            this.btnC1.BackColor = System.Drawing.Color.Lime;
            this.btnC1.Location = new System.Drawing.Point(17, 138);
            this.btnC1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnC1.Name = "btnC1";
            this.btnC1.Size = new System.Drawing.Size(38, 34);
            this.btnC1.TabIndex = 1;
            this.btnC1.Text = "C1";
            this.btnC1.UseVisualStyleBackColor = false;
            this.btnC1.MouseHover += new System.EventHandler(this.btnSeat_Mousehover);
            // 
            // btnB4
            // 
            this.btnB4.BackColor = System.Drawing.Color.Lime;
            this.btnB4.Location = new System.Drawing.Point(176, 80);
            this.btnB4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnB4.Name = "btnB4";
            this.btnB4.Size = new System.Drawing.Size(38, 34);
            this.btnB4.TabIndex = 1;
            this.btnB4.Text = "B4";
            this.btnB4.UseVisualStyleBackColor = false;
            this.btnB4.MouseHover += new System.EventHandler(this.btnSeat_Mousehover);
            // 
            // btnB3
            // 
            this.btnB3.BackColor = System.Drawing.Color.Lime;
            this.btnB3.Location = new System.Drawing.Point(122, 80);
            this.btnB3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnB3.Name = "btnB3";
            this.btnB3.Size = new System.Drawing.Size(38, 34);
            this.btnB3.TabIndex = 1;
            this.btnB3.Text = "B3";
            this.btnB3.UseVisualStyleBackColor = false;
            this.btnB3.MouseHover += new System.EventHandler(this.btnSeat_Mousehover);
            // 
            // btnB2
            // 
            this.btnB2.BackColor = System.Drawing.Color.Lime;
            this.btnB2.Location = new System.Drawing.Point(72, 80);
            this.btnB2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnB2.Name = "btnB2";
            this.btnB2.Size = new System.Drawing.Size(38, 34);
            this.btnB2.TabIndex = 1;
            this.btnB2.Text = "B2";
            this.btnB2.UseVisualStyleBackColor = false;
            this.btnB2.MouseHover += new System.EventHandler(this.btnSeat_Mousehover);
            // 
            // btnB1
            // 
            this.btnB1.BackColor = System.Drawing.Color.Lime;
            this.btnB1.Location = new System.Drawing.Point(17, 80);
            this.btnB1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnB1.Name = "btnB1";
            this.btnB1.Size = new System.Drawing.Size(38, 34);
            this.btnB1.TabIndex = 1;
            this.btnB1.Text = "B1";
            this.btnB1.UseVisualStyleBackColor = false;
            this.btnB1.MouseHover += new System.EventHandler(this.btnSeat_Mousehover);
            // 
            // btnA4
            // 
            this.btnA4.BackColor = System.Drawing.Color.Lime;
            this.btnA4.Location = new System.Drawing.Point(176, 28);
            this.btnA4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnA4.Name = "btnA4";
            this.btnA4.Size = new System.Drawing.Size(38, 32);
            this.btnA4.TabIndex = 0;
            this.btnA4.Text = "A4";
            this.btnA4.UseVisualStyleBackColor = false;
            this.btnA4.MouseHover += new System.EventHandler(this.btnSeat_Mousehover);
            // 
            // btnA3
            // 
            this.btnA3.BackColor = System.Drawing.Color.Lime;
            this.btnA3.Location = new System.Drawing.Point(122, 28);
            this.btnA3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnA3.Name = "btnA3";
            this.btnA3.Size = new System.Drawing.Size(38, 32);
            this.btnA3.TabIndex = 0;
            this.btnA3.Text = "A3";
            this.btnA3.UseVisualStyleBackColor = false;
            this.btnA3.MouseHover += new System.EventHandler(this.btnSeat_Mousehover);
            // 
            // btnA2
            // 
            this.btnA2.BackColor = System.Drawing.Color.Lime;
            this.btnA2.Location = new System.Drawing.Point(72, 28);
            this.btnA2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnA2.Name = "btnA2";
            this.btnA2.Size = new System.Drawing.Size(38, 32);
            this.btnA2.TabIndex = 0;
            this.btnA2.Text = "A2";
            this.btnA2.UseVisualStyleBackColor = false;
            this.btnA2.MouseHover += new System.EventHandler(this.btnSeat_Mousehover);
            // 
            // btnA1
            // 
            this.btnA1.BackColor = System.Drawing.Color.Lime;
            this.btnA1.Location = new System.Drawing.Point(17, 28);
            this.btnA1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnA1.Name = "btnA1";
            this.btnA1.Size = new System.Drawing.Size(38, 32);
            this.btnA1.TabIndex = 0;
            this.btnA1.Text = "A1";
            this.btnA1.UseVisualStyleBackColor = false;
            this.btnA1.MouseHover += new System.EventHandler(this.btnSeat_Mousehover);
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(379, 57);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(38, 15);
            this.lblRows.TabIndex = 2;
            this.lblRows.Text = "Rows:";
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Location = new System.Drawing.Point(531, 57);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(58, 15);
            this.lblColumns.TabIndex = 2;
            this.lblColumns.Text = "Columns:";           
            // 
            // lstBoxRows
            // 
            this.lstBoxRows.FormattingEnabled = true;
            this.lstBoxRows.ItemHeight = 15;
            this.lstBoxRows.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.lstBoxRows.Location = new System.Drawing.Point(379, 74);
            this.lstBoxRows.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstBoxRows.Name = "lstBoxRows";
            this.lstBoxRows.Size = new System.Drawing.Size(107, 109);
            this.lstBoxRows.TabIndex = 3;
            // 
            // lstBoxCol
            // 
            this.lstBoxCol.FormattingEnabled = true;
            this.lstBoxCol.ItemHeight = 15;
            this.lstBoxCol.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.lstBoxCol.Location = new System.Drawing.Point(531, 74);
            this.lstBoxCol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstBoxCol.Name = "lstBoxCol";
            this.lstBoxCol.Size = new System.Drawing.Size(107, 109);
            this.lstBoxCol.TabIndex = 3;
            // 
            // lblCusName
            // 
            this.lblCusName.AutoSize = true;
            this.lblCusName.Location = new System.Drawing.Point(379, 202);
            this.lblCusName.Name = "lblCusName";
            this.lblCusName.Size = new System.Drawing.Size(97, 15);
            this.lblCusName.TabIndex = 4;
            this.lblCusName.Text = "Customer Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(379, 226);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(246, 23);
            this.txtName.TabIndex = 5;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(382, 272);
            this.btnBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(63, 22);
            this.btnBook.TabIndex = 6;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(451, 272);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(63, 22);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddWait
            // 
            this.btnAddWait.Location = new System.Drawing.Point(519, 272);
            this.btnAddWait.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddWait.Name = "btnAddWait";
            this.btnAddWait.Size = new System.Drawing.Size(119, 22);
            this.btnAddWait.TabIndex = 6;
            this.btnAddWait.Text = "Add to waitlist";
            this.btnAddWait.UseVisualStyleBackColor = true;
            this.btnAddWait.Click += new System.EventHandler(this.btnAddWait_Click);
            // 
            // btnFillAll
            // 
            this.btnFillAll.Location = new System.Drawing.Point(382, 314);
            this.btnFillAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFillAll.Name = "btnFillAll";
            this.btnFillAll.Size = new System.Drawing.Size(119, 22);
            this.btnFillAll.TabIndex = 6;
            this.btnFillAll.Text = "Fill all seats";
            this.btnFillAll.UseVisualStyleBackColor = true;
            this.btnFillAll.Click += new System.EventHandler(this.btnFillAll_Click);
            // 
            // btnCancelAll
            // 
            this.btnCancelAll.Location = new System.Drawing.Point(519, 314);
            this.btnCancelAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelAll.Name = "btnCancelAll";
            this.btnCancelAll.Size = new System.Drawing.Size(119, 22);
            this.btnCancelAll.TabIndex = 6;
            this.btnCancelAll.Text = "Cancel all bookings";
            this.btnCancelAll.UseVisualStyleBackColor = true;
            this.btnCancelAll.Click += new System.EventHandler(this.btnCancelAll_Click);
            // 
            // lblNotif
            // 
            this.lblNotif.AutoSize = true;
            this.lblNotif.Location = new System.Drawing.Point(43, 358);
            this.lblNotif.Name = "lblNotif";
            this.lblNotif.Size = new System.Drawing.Size(70, 15);
            this.lblNotif.TabIndex = 7;
            this.lblNotif.Text = "Notification";
            // 
            // rTxtBWaitingLst
            // 
            this.rTxtBWaitingLst.Location = new System.Drawing.Point(34, 424);
            this.rTxtBWaitingLst.Name = "rTxtBWaitingLst";
            this.rTxtBWaitingLst.Size = new System.Drawing.Size(148, 96);
            this.rTxtBWaitingLst.TabIndex = 8;
            this.rTxtBWaitingLst.Text = "";
            // 
            // lblWaitingList
            // 
            this.lblWaitingList.AutoSize = true;
            this.lblWaitingList.Location = new System.Drawing.Point(36, 403);
            this.lblWaitingList.Name = "lblWaitingList";
            this.lblWaitingList.Size = new System.Drawing.Size(110, 15);
            this.lblWaitingList.TabIndex = 9;
            this.lblWaitingList.Text = "Waiting List Queue:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 542);
            this.Controls.Add(this.lblWaitingList);
            this.Controls.Add(this.rTxtBWaitingLst);
            this.Controls.Add(this.lblNotif);
            this.Controls.Add(this.btnCancelAll);
            this.Controls.Add(this.btnFillAll);
            this.Controls.Add(this.btnAddWait);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCusName);
            this.Controls.Add(this.lstBoxCol);
            this.Controls.Add(this.lstBoxRows);
            this.Controls.Add(this.lblColumns);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCapacityInfo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCapacityInfo;
        private GroupBox groupBox1;
        private Label lblRows;
        private Label lblColumns;
        private ListBox lstBoxRows;
        private ListBox lstBoxCol;
        private Label lblCusName;
        private TextBox txtName;
        private Button btnBook;
        private Button btnCancel;
        private Button btnAddWait;
        private Button btnFillAll;
        private Button btnCancelAll;
        private Label lblNotif;
        private Button btnC4;
        private Button btnC3;
        private Button btnC2;
        private Button btnC1;
        private Button btnB4;
        private Button btnB3;
        private Button btnB2;
        private Button btnB1;
        private Button btnA4;
        private Button btnA3;
        private Button btnA2;
        private Button btnA1;
        private RichTextBox rTxtBWaitingLst;
        private Label lblWaitingList;
    }
}