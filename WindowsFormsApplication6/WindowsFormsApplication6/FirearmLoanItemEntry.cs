using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormCharpWebCam;

namespace WindowsFormsApplication6
{
    public partial class FirearmLoanItemEntry : Form
    {
        WebCam webcam;
        DataClassesPOSDBDataContext dc = new DataClassesPOSDBDataContext();
        public loan_form lf;
        int custId = 0;

        public FirearmLoanItemEntry(loan_form lf, int cid)
        {
            InitializeComponent();
            custId = cid;
            this.lf = lf;
            webcam = new WebCam();
            webcam.InitializeWebCam(ref pictureBox1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            webcam.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webcam.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Need to save to file location specified in database SystemSettings PictureLocation "L(loan number)F(item number on loan).jpg"
            Helper.SaveImageCapture(pictureBox1.Image);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Cancel - Do not save data on ItemEntry
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loan l = new Loan();
            l.LoanType = "firearm";
            l.CustomerID = custId;
            dc.Loans.InsertOnSubmit(l);
            dc.SubmitChanges();

            LoanFirearm f = new LoanFirearm();
            f.Type = comboBoxType.Text;
            f.Make = textBoxMake.Text;
            f.Action = comboBoxAction.Text;
            f.Model = textBoxModel.Text;
            f.Caliber = textBoxCaliber.Text;
            f.Importer = textBoxImporter.Text;
            f.SerialNumber = textBoxSerialNumber.Text;
            f.Finish = comboBoxFinish.Text;
            f.Description = textBoxDescription.Text;
            f.ItemNotes = textBoxItemNotes.Text;
            f.AmountLoaned = Convert.ToInt32(textBoxAmountLoaned.Text);
            f.LoanID = l.LoanID;

            dc.LoanFirearms.InsertOnSubmit(f);
            dc.SubmitChanges();

           

            lf.dataGridView2.Rows.Add("Firearm", comboBoxType.Text, textBoxDescription.Text, "", textBoxAmountLoaned.Text);

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxModel.Text != "")
            {
                var max = (from x in dc.LoanFirearms
                           where x.Model.Equals(textBoxModel.Text)
                           select x.AmountLoaned).Max();
                label13.Text = "$" + max;

                var average = (from x in dc.LoanFirearms
                               where x.Model.Equals(textBoxModel.Text)
                               select x.AmountLoaned).Average();
                label16.Text = "$" + average;
                //need sale/purchase table

                //Need to calculate multiple statistics
                //Highest - Find highest sold price in item Model
                //Average - Find average selling price in item Model
                //Lowest - Find lowest sold item $$ from item Model
                //Find Quantity for sale with same item Model
                //Find Highest loan price on item Model
                //Find Average loan price on item Model
                //Find Quantity of current item Model in loan
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBoxSerialNumber.Text != "")
            {
                var result = (from x in dc.LoanFirearms
                              where x.SerialNumber.Equals(textBoxSerialNumber.Text)
                              select x).FirstOrDefault();
                comboBoxType.Text = result.Type;
                textBoxMake.Text = result.Make;
                comboBoxAction.Text = result.Action;
                textBoxModel.Text = result.Model;
                textBoxCaliber.Text = result.Caliber;
                textBoxImporter.Text = result.Importer;
                comboBoxFinish.Text = result.Finish;
                textBoxDescription.Text = result.Description;
                textBoxItemNotes.Text = result.ItemNotes;
                textBoxAmountLoaned.Text = result.AmountLoaned.ToString();

                //Find and list in seperate form/windows all loans associated with current Serial number. Display Loan Number/Customer Name/Description/Date/Loan amount.
                //Automatically populate AutomotiveLoanItemEntry if an item is selected from this form
            }
        }

        private void textBoxAmountLoaned_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

    }
}
