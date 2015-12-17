namespace WindowsFormsApplication6
{
    partial class loan_form
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.L_RequestedLoan = new System.Windows.Forms.MaskedTextBox();
            this.L_CurrentLoan = new System.Windows.Forms.MaskedTextBox();
            this.L_Difference = new System.Windows.Forms.MaskedTextBox();
            this.LoanType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpectedResale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoanAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoanType,
            this.ProductName,
            this.Description,
            this.ExpectedResale,
            this.LoanAmount});
            this.dataGridView2.Location = new System.Drawing.Point(12, 325);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1165, 341);
            this.dataGridView2.TabIndex = 74;
            this.dataGridView2.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView2_RowsAdded);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 77);
            this.button1.TabIndex = 75;
            this.button1.Text = "General";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(284, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 77);
            this.button2.TabIndex = 76;
            this.button2.Text = "Firearm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(148, 120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 77);
            this.button3.TabIndex = 77;
            this.button3.Text = "Jewelry";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(420, 120);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 77);
            this.button4.TabIndex = 78;
            this.button4.Text = "Automotive";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1050, 228);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 77);
            this.button5.TabIndex = 79;
            this.button5.Text = "Finish\r\nPrint Ticket";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 39);
            this.label1.TabIndex = 80;
            this.label1.Text = "Customer (Last, First)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(979, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 157);
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 24);
            this.label2.TabIndex = 85;
            this.label2.Text = "Dollars Requested";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 24);
            this.label3.TabIndex = 86;
            this.label3.Text = "Current Loan Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 87;
            this.label4.Text = "Difference";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(925, 12);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(20, 24);
            this.label38.TabIndex = 101;
            this.label38.Text = "0";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(925, 41);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(20, 24);
            this.label39.TabIndex = 100;
            this.label39.Text = "0";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(925, 71);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(20, 24);
            this.label40.TabIndex = 99;
            this.label40.Text = "0";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(925, 100);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(20, 24);
            this.label41.TabIndex = 98;
            this.label41.Text = "0";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(925, 130);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(20, 24);
            this.label42.TabIndex = 97;
            this.label42.Text = "0";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(890, 159);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(55, 24);
            this.label43.TabIndex = 96;
            this.label43.Text = "$0.00";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(845, 189);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(100, 24);
            this.label44.TabIndex = 95;
            this.label44.Text = "01/01/2016";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(680, 12);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(114, 24);
            this.label45.TabIndex = 94;
            this.label45.Text = "Open Loans";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(680, 41);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(103, 24);
            this.label46.TabIndex = 93;
            this.label46.Text = "Paid Loans";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(680, 71);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(119, 24);
            this.label47.TabIndex = 92;
            this.label47.Text = "Pulled Loans";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(680, 100);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(181, 24);
            this.label48.TabIndex = 91;
            this.label48.Text = "Extension Payments";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(680, 130);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(196, 24);
            this.label49.TabIndex = 90;
            this.label49.Text = "Police Confenscations";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(680, 159);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(176, 24);
            this.label50.TabIndex = 89;
            this.label50.Text = "Total Open Loan $$";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(680, 189);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(136, 24);
            this.label51.TabIndex = 88;
            this.label51.Text = "Next Loan Due";
            // 
            // L_RequestedLoan
            // 
            this.L_RequestedLoan.Location = new System.Drawing.Point(29, 276);
            this.L_RequestedLoan.Mask = "0000000000000000000";
            this.L_RequestedLoan.Name = "L_RequestedLoan";
            this.L_RequestedLoan.PromptChar = ' ';
            this.L_RequestedLoan.Size = new System.Drawing.Size(160, 29);
            this.L_RequestedLoan.TabIndex = 102;
            this.L_RequestedLoan.Text = "0";
            this.L_RequestedLoan.TextChanged += new System.EventHandler(this.L_RequestedLoan_TextChanged);
            // 
            // L_CurrentLoan
            // 
            this.L_CurrentLoan.Location = new System.Drawing.Point(209, 276);
            this.L_CurrentLoan.Mask = "00000000000000000000";
            this.L_CurrentLoan.Name = "L_CurrentLoan";
            this.L_CurrentLoan.PromptChar = ' ';
            this.L_CurrentLoan.Size = new System.Drawing.Size(160, 29);
            this.L_CurrentLoan.TabIndex = 103;
            this.L_CurrentLoan.Text = "0";
            this.L_CurrentLoan.TextChanged += new System.EventHandler(this.L_CurrentLoan_TextChanged);
            // 
            // L_Difference
            // 
            this.L_Difference.Location = new System.Drawing.Point(390, 276);
            this.L_Difference.Mask = "000000000000000000";
            this.L_Difference.Name = "L_Difference";
            this.L_Difference.PromptChar = ' ';
            this.L_Difference.Size = new System.Drawing.Size(160, 29);
            this.L_Difference.TabIndex = 104;
            this.L_Difference.Text = "0";
            // 
            // LoanType
            // 
            this.LoanType.HeaderText = "Loan Type";
            this.LoanType.MaxInputLength = 10;
            this.LoanType.Name = "LoanType";
            this.LoanType.ReadOnly = true;
            this.LoanType.Width = 150;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.MaxInputLength = 7;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 200;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MaxInputLength = 50;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 350;
            // 
            // ExpectedResale
            // 
            this.ExpectedResale.HeaderText = "Expected Resale";
            this.ExpectedResale.MaxInputLength = 9;
            this.ExpectedResale.Name = "ExpectedResale";
            this.ExpectedResale.ReadOnly = true;
            this.ExpectedResale.Width = 200;
            // 
            // LoanAmount
            // 
            this.LoanAmount.HeaderText = "Loan Amount";
            this.LoanAmount.MaxInputLength = 9;
            this.LoanAmount.Name = "LoanAmount";
            this.LoanAmount.ReadOnly = true;
            this.LoanAmount.Width = 200;
            // 
            // loan_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 678);
            this.Controls.Add(this.L_Difference);
            this.Controls.Add(this.L_CurrentLoan);
            this.Controls.Add(this.L_RequestedLoan);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.label48);
            this.Controls.Add(this.label49);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.label51);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "loan_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loan_form";
            this.Load += new System.EventHandler(this.loan_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.MaskedTextBox L_RequestedLoan;
        private System.Windows.Forms.MaskedTextBox L_CurrentLoan;
        private System.Windows.Forms.MaskedTextBox L_Difference;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpectedResale;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanAmount;
    }
}