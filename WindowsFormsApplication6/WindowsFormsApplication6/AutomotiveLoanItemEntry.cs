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
    public partial class AutomotiveLoanItemEntry : Form
    {
        WebCam webcam;
        DataClassesPOSDBDataContext dc = new DataClassesPOSDBDataContext();
        public loan_form lf;
        int custId = 0;

        public AutomotiveLoanItemEntry(loan_form lf, int cid)
        {
            this.lf = lf;
            custId = cid;
            InitializeComponent();
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
            //Need to save to file location specified in database SystemSettings PictureLocation "L(loan number)A(item number on loan).jpg"
            Helper.SaveImageCapture(pictureBox1.Image);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Exit form without saving
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loan l = new Loan();
            l.LoanType = "automotive";
            l.CustomerID = custId;
            dc.Loans.InsertOnSubmit(l);
            dc.SubmitChanges();

            LoanAutomotive a = new LoanAutomotive();
            a.Year = textBoxYear.Text;
            a.TypeOfAutomobile = comboBoxTypeAutomobile.Text;
            a.Make = textBoxManufacturer.Text;
            a.BodyType = textBoxBodyType.Text;
            a.Model = textBoxModel.Text;
            a.PlateTag = textBoxPlateTagNumber.Text;
            a.VINSerialNumber = textBoxVINSerialNumber.Text;
            a.Color = textBoxColor.Text;
            a.Description = textBoxDescription.Text;
            a.ItemNotes = textBoxItemNotes.Text;
            a.AmountLoaned = Convert.ToInt32(textBoxAmountLoaned.Text);
            a.LoanID = l.LoanID;
            dc.LoanAutomotives.InsertOnSubmit(a);
            dc.SubmitChanges();


            lf.dataGridView2.Rows.Add("Automotive", textBoxManufacturer.Text, textBoxDescription.Text, "", textBoxAmountLoaned.Text);
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxModel.Text != "")
            {
                var max = (from x in dc.LoanAutomotives
                             where x.Model.Equals(textBoxModel.Text)
                             select x.AmountLoaned).Max();
                label13.Text = "$" + max;

                var average = (from x in dc.LoanAutomotives
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
            if (textBoxVINSerialNumber.Text != "")
            {
                var result = (from x in dc.LoanAutomotives
                              where x.VINSerialNumber.Equals(textBoxVINSerialNumber.Text)
                              select x).FirstOrDefault();
                textBoxYear.Text = result.Year;
                comboBoxTypeAutomobile.Text = result.TypeOfAutomobile;
                textBoxManufacturer.Text = result.Make;
                textBoxBodyType.Text = result.BodyType;
                textBoxModel.Text = result.Model;
                textBoxPlateTagNumber.Text = result.PlateTag;
                textBoxColor.Text = result.Color;
                textBoxDescription.Text = result.Description;
                textBoxItemNotes.Text = result.ItemNotes;
                textBoxAmountLoaned.Text = result.AmountLoaned.ToString(); ;

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
