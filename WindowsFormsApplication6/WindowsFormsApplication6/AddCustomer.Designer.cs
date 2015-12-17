namespace WindowsFormsApplication6
{
    partial class AddCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.C_CustomerAddedDate = new System.Windows.Forms.DateTimePicker();
            this.C_DOB = new System.Windows.Forms.DateTimePicker();
            this.C_IDExpiration = new System.Windows.Forms.DateTimePicker();
            this.C_State = new System.Windows.Forms.ComboBox();
            this.label82 = new System.Windows.Forms.Label();
            this.C_LastName = new System.Windows.Forms.TextBox();
            this.C_Zip = new System.Windows.Forms.MaskedTextBox();
            this.C_HomePhone = new System.Windows.Forms.MaskedTextBox();
            this.C_Cell = new System.Windows.Forms.MaskedTextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.C_Notes = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.C_Eyes = new System.Windows.Forms.ComboBox();
            this.C_Hair = new System.Windows.Forms.ComboBox();
            this.C_Race = new System.Windows.Forms.ComboBox();
            this.C_Sex = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.C_Weight = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.C_Age = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.C_CellTexting = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.C_EmailAddress = new System.Windows.Forms.TextBox();
            this.C_Height = new System.Windows.Forms.TextBox();
            this.C_IDNumber = new System.Windows.Forms.TextBox();
            this.C_City = new System.Windows.Forms.TextBox();
            this.C_StreetAddress = new System.Windows.Forms.TextBox();
            this.C_FirstName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.TEB_Btn = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // C_CustomerAddedDate
            // 
            this.C_CustomerAddedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_CustomerAddedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.C_CustomerAddedDate.Location = new System.Drawing.Point(359, 425);
            this.C_CustomerAddedDate.Name = "C_CustomerAddedDate";
            this.C_CustomerAddedDate.Size = new System.Drawing.Size(119, 21);
            this.C_CustomerAddedDate.TabIndex = 21;
            // 
            // C_DOB
            // 
            this.C_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.C_DOB.Location = new System.Drawing.Point(129, 295);
            this.C_DOB.Name = "C_DOB";
            this.C_DOB.Size = new System.Drawing.Size(104, 21);
            this.C_DOB.TabIndex = 12;
            this.C_DOB.ValueChanged += new System.EventHandler(this.C_DOB_ValueChanged);
            // 
            // C_IDExpiration
            // 
            this.C_IDExpiration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_IDExpiration.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.C_IDExpiration.Location = new System.Drawing.Point(17, 295);
            this.C_IDExpiration.Name = "C_IDExpiration";
            this.C_IDExpiration.Size = new System.Drawing.Size(104, 21);
            this.C_IDExpiration.TabIndex = 11;
            // 
            // C_State
            // 
            this.C_State.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_State.FormattingEnabled = true;
            this.C_State.Items.AddRange(new object[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.C_State.Location = new System.Drawing.Point(253, 147);
            this.C_State.Name = "C_State";
            this.C_State.Size = new System.Drawing.Size(114, 23);
            this.C_State.TabIndex = 5;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label82.Location = new System.Drawing.Point(250, 10);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(67, 15);
            this.label82.TabIndex = 111;
            this.label82.Text = "First Name";
            // 
            // C_LastName
            // 
            this.C_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_LastName.Location = new System.Drawing.Point(17, 29);
            this.C_LastName.Name = "C_LastName";
            this.C_LastName.Size = new System.Drawing.Size(228, 21);
            this.C_LastName.TabIndex = 1;
            // 
            // C_Zip
            // 
            this.C_Zip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_Zip.Location = new System.Drawing.Point(374, 147);
            this.C_Zip.Mask = "00000";
            this.C_Zip.Name = "C_Zip";
            this.C_Zip.PromptChar = ' ';
            this.C_Zip.Size = new System.Drawing.Size(104, 21);
            this.C_Zip.TabIndex = 6;
            this.C_Zip.ValidatingType = typeof(int);
            // 
            // C_HomePhone
            // 
            this.C_HomePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_HomePhone.Location = new System.Drawing.Point(178, 210);
            this.C_HomePhone.Mask = "(999) 000-0000";
            this.C_HomePhone.Name = "C_HomePhone";
            this.C_HomePhone.PromptChar = ' ';
            this.C_HomePhone.Size = new System.Drawing.Size(153, 21);
            this.C_HomePhone.TabIndex = 9;
            // 
            // C_Cell
            // 
            this.C_Cell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_Cell.Location = new System.Drawing.Point(17, 210);
            this.C_Cell.Mask = "(999) 000-0000";
            this.C_Cell.Name = "C_Cell";
            this.C_Cell.PromptChar = ' ';
            this.C_Cell.Size = new System.Drawing.Size(153, 21);
            this.C_Cell.TabIndex = 7;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(14, 466);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(95, 15);
            this.label35.TabIndex = 110;
            this.label35.Text = "Customer Notes";
            // 
            // C_Notes
            // 
            this.C_Notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_Notes.Location = new System.Drawing.Point(17, 487);
            this.C_Notes.Multiline = true;
            this.C_Notes.Name = "C_Notes";
            this.C_Notes.Size = new System.Drawing.Size(461, 168);
            this.C_Notes.TabIndex = 22;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(356, 406);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(98, 15);
            this.label19.TabIndex = 109;
            this.label19.Text = "Customer Added";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(14, 406);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 15);
            this.label18.TabIndex = 108;
            this.label18.Text = "Email Address";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(365, 345);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 15);
            this.label17.TabIndex = 107;
            this.label17.Text = "Eyes";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(245, 345);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 15);
            this.label16.TabIndex = 106;
            this.label16.Text = "Hair";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(126, 345);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 15);
            this.label15.TabIndex = 105;
            this.label15.Text = "Race";
            // 
            // C_Eyes
            // 
            this.C_Eyes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_Eyes.FormattingEnabled = true;
            this.C_Eyes.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Brown",
            "Green",
            "Grey",
            "Hazel"});
            this.C_Eyes.Location = new System.Drawing.Point(369, 363);
            this.C_Eyes.Name = "C_Eyes";
            this.C_Eyes.Size = new System.Drawing.Size(110, 23);
            this.C_Eyes.TabIndex = 19;
            // 
            // C_Hair
            // 
            this.C_Hair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_Hair.FormattingEnabled = true;
            this.C_Hair.Items.AddRange(new object[] {
            "Black",
            "Blonde",
            "Brown",
            "Grey",
            "Red",
            "Strawberry",
            "White"});
            this.C_Hair.Location = new System.Drawing.Point(248, 363);
            this.C_Hair.Name = "C_Hair";
            this.C_Hair.Size = new System.Drawing.Size(112, 23);
            this.C_Hair.TabIndex = 18;
            // 
            // C_Race
            // 
            this.C_Race.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_Race.FormattingEnabled = true;
            this.C_Race.Items.AddRange(new object[] {
            "White",
            "Black",
            "Asian",
            "Indian",
            "Hispanic"});
            this.C_Race.Location = new System.Drawing.Point(129, 363);
            this.C_Race.Name = "C_Race";
            this.C_Race.Size = new System.Drawing.Size(111, 23);
            this.C_Race.TabIndex = 17;
            // 
            // C_Sex
            // 
            this.C_Sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_Sex.FormattingEnabled = true;
            this.C_Sex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.C_Sex.Location = new System.Drawing.Point(17, 363);
            this.C_Sex.Name = "C_Sex";
            this.C_Sex.Size = new System.Drawing.Size(104, 23);
            this.C_Sex.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(14, 345);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 15);
            this.label14.TabIndex = 104;
            this.label14.Text = "Sex";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(400, 275);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 15);
            this.label13.TabIndex = 103;
            this.label13.Text = "Weight";
            // 
            // C_Weight
            // 
            this.C_Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_Weight.Location = new System.Drawing.Point(404, 295);
            this.C_Weight.Name = "C_Weight";
            this.C_Weight.Size = new System.Drawing.Size(75, 21);
            this.C_Weight.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(241, 275);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 15);
            this.label12.TabIndex = 102;
            this.label12.Text = "Age";
            // 
            // C_Age
            // 
            this.C_Age.Enabled = false;
            this.C_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_Age.Location = new System.Drawing.Point(245, 295);
            this.C_Age.Name = "C_Age";
            this.C_Age.Size = new System.Drawing.Size(68, 21);
            this.C_Age.TabIndex = 13;
            this.C_Age.TextChanged += new System.EventHandler(this.C_Age_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(317, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 15);
            this.label11.TabIndex = 100;
            this.label11.Text = "Height";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(124, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 15);
            this.label10.TabIndex = 99;
            this.label10.Text = "Birthday";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 15);
            this.label9.TabIndex = 98;
            this.label9.Text = "Expiration";
            // 
            // C_CellTexting
            // 
            this.C_CellTexting.AutoSize = true;
            this.C_CellTexting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_CellTexting.Location = new System.Drawing.Point(17, 240);
            this.C_CellTexting.Name = "C_CellTexting";
            this.C_CellTexting.Size = new System.Drawing.Size(73, 19);
            this.C_CellTexting.TabIndex = 8;
            this.C_CellTexting.Text = "Texting?";
            this.C_CellTexting.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(175, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 15);
            this.label8.TabIndex = 95;
            this.label8.Text = "Home Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(371, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 15);
            this.label7.TabIndex = 93;
            this.label7.Text = "Zip";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(250, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 90;
            this.label6.Text = "State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(336, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 86;
            this.label5.Text = "ID Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 84;
            this.label4.Text = "Cellular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 82;
            this.label3.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 81;
            this.label2.Text = "Street Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 79;
            this.label1.Text = "Last Name";
            // 
            // C_EmailAddress
            // 
            this.C_EmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_EmailAddress.Location = new System.Drawing.Point(17, 425);
            this.C_EmailAddress.Name = "C_EmailAddress";
            this.C_EmailAddress.Size = new System.Drawing.Size(334, 21);
            this.C_EmailAddress.TabIndex = 20;
            // 
            // C_Height
            // 
            this.C_Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_Height.Location = new System.Drawing.Point(321, 295);
            this.C_Height.Name = "C_Height";
            this.C_Height.Size = new System.Drawing.Size(75, 21);
            this.C_Height.TabIndex = 14;
            // 
            // C_IDNumber
            // 
            this.C_IDNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_IDNumber.Location = new System.Drawing.Point(339, 210);
            this.C_IDNumber.Name = "C_IDNumber";
            this.C_IDNumber.Size = new System.Drawing.Size(139, 21);
            this.C_IDNumber.TabIndex = 10;
            // 
            // C_City
            // 
            this.C_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_City.Location = new System.Drawing.Point(17, 147);
            this.C_City.Name = "C_City";
            this.C_City.Size = new System.Drawing.Size(223, 21);
            this.C_City.TabIndex = 4;
            // 
            // C_StreetAddress
            // 
            this.C_StreetAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_StreetAddress.Location = new System.Drawing.Point(17, 87);
            this.C_StreetAddress.Name = "C_StreetAddress";
            this.C_StreetAddress.Size = new System.Drawing.Size(461, 21);
            this.C_StreetAddress.TabIndex = 3;
            // 
            // C_FirstName
            // 
            this.C_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_FirstName.Location = new System.Drawing.Point(253, 29);
            this.C_FirstName.Name = "C_FirstName";
            this.C_FirstName.Size = new System.Drawing.Size(226, 21);
            this.C_FirstName.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(486, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 230);
            this.pictureBox1.TabIndex = 112;
            this.pictureBox1.TabStop = false;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(573, 250);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(195, 42);
            this.button9.TabIndex = 23;
            this.button9.Text = "Take New Picture";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCustomer.Location = new System.Drawing.Point(573, 612);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(195, 42);
            this.buttonAddCustomer.TabIndex = 24;
            this.buttonAddCustomer.Text = "Save Customer";
            this.buttonAddCustomer.UseVisualStyleBackColor = true;
            this.buttonAddCustomer.Click += new System.EventHandler(this.buttonAddCustomer_Click);
            // 
            // TEB_Btn
            // 
            this.TEB_Btn.AutoSize = true;
            this.TEB_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEB_Btn.Location = new System.Drawing.Point(486, 302);
            this.TEB_Btn.Name = "TEB_Btn";
            this.TEB_Btn.Size = new System.Drawing.Size(144, 19);
            this.TEB_Btn.TabIndex = 113;
            this.TEB_Btn.Text = "Tax Exempt Business";
            this.TEB_Btn.UseVisualStyleBackColor = true;
            this.TEB_Btn.CheckedChanged += new System.EventHandler(this.TEB_Btn_CheckedChanged);
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 670);
            this.Controls.Add(this.TEB_Btn);
            this.Controls.Add(this.buttonAddCustomer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.C_CustomerAddedDate);
            this.Controls.Add(this.C_DOB);
            this.Controls.Add(this.C_IDExpiration);
            this.Controls.Add(this.C_State);
            this.Controls.Add(this.label82);
            this.Controls.Add(this.C_LastName);
            this.Controls.Add(this.C_Zip);
            this.Controls.Add(this.C_HomePhone);
            this.Controls.Add(this.C_Cell);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.C_Notes);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.C_Eyes);
            this.Controls.Add(this.C_Hair);
            this.Controls.Add(this.C_Race);
            this.Controls.Add(this.C_Sex);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.C_Weight);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.C_Age);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.C_CellTexting);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.C_EmailAddress);
            this.Controls.Add(this.C_Height);
            this.Controls.Add(this.C_IDNumber);
            this.Controls.Add(this.C_City);
            this.Controls.Add(this.C_StreetAddress);
            this.Controls.Add(this.C_FirstName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker C_CustomerAddedDate;
        private System.Windows.Forms.DateTimePicker C_DOB;
        private System.Windows.Forms.DateTimePicker C_IDExpiration;
        private System.Windows.Forms.ComboBox C_State;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.TextBox C_LastName;
        private System.Windows.Forms.MaskedTextBox C_Zip;
        private System.Windows.Forms.MaskedTextBox C_HomePhone;
        private System.Windows.Forms.MaskedTextBox C_Cell;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox C_Notes;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox C_Eyes;
        private System.Windows.Forms.ComboBox C_Hair;
        private System.Windows.Forms.ComboBox C_Race;
        private System.Windows.Forms.ComboBox C_Sex;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox C_Weight;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox C_Age;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox C_CellTexting;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox C_EmailAddress;
        private System.Windows.Forms.TextBox C_Height;
        private System.Windows.Forms.TextBox C_IDNumber;
        private System.Windows.Forms.TextBox C_City;
        private System.Windows.Forms.TextBox C_StreetAddress;
        private System.Windows.Forms.TextBox C_FirstName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.CheckBox TEB_Btn;
    }
}