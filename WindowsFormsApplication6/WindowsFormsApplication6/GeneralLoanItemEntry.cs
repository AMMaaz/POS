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
    public partial class GeneralLoanItemEntry : Form
    {
        WebCam webcam;
        DataClassesPOSDBDataContext dc = new DataClassesPOSDBDataContext();
        public loan_form lf;
        int custId = 0;

        public GeneralLoanItemEntry(int cid)
        {
            InitializeComponent();
            custId = cid;
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
            //Need to save to file location specified in database SystemSettings PictureLocation "L(loan number)G(item number on loan).jpg"
            Helper.SaveImageCapture(pictureBox1.Image);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Exit form without saving
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Loan l = new Loan();
            l.LoanType = "general";
            l.CustomerID = custId;
            dc.Loans.InsertOnSubmit(l);
            dc.SubmitChanges();

            LoanGeneral g = new LoanGeneral();
            g.Category = comboBoxCategory.Text;
            g.SubCategory = comboBoxSubCategory.Text;
            g.Make = textBoxMake.Text;
            g.Model = textBoxModel.Text;
            g.Description = textBoxDescription.Text;
            g.SerialNumber = textBoxSerialNumber.Text;
            g.ItemNotes = textBoxItemNotes.Text;
            g.AmountLoaned = Convert.ToInt32(textBoxAmountLoadned.Text);
            g.LoanID = l.LoanID;
            //picture
            dc.LoanGenerals.InsertOnSubmit(g);
            dc.SubmitChanges();


            lf.dataGridView2.Rows.Add("General", comboBoxCategory.Text, textBoxDescription.Text,"", textBoxAmountLoadned.Text);
           
            
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxModel.Text != "")
            {
                var max = (from x in dc.LoanGenerals
                           where x.Model.Equals(textBoxModel.Text)
                           select x.AmountLoaned).Max();
                label13.Text = "$" + max;

                var average = (from x in dc.LoanGenerals
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
                var result = (from x in dc.LoanGenerals
                              where x.SerialNumber.Equals(textBoxSerialNumber.Text)
                              select x).FirstOrDefault();
                comboBoxCategory.Text = result.Category;
                comboBoxSubCategory.Text = result.SubCategory;
                textBoxMake.Text = result.Make;
                textBoxModel.Text = result.Model;
                textBoxDescription.Text = result.Description;
                textBoxItemNotes.Text = result.ItemNotes;
                textBoxAmountLoadned.Text = result.AmountLoaned.ToString();

                //Find and list in seperate form/windows all loans associated with current Serial number. Display Loan Number/Customer Name/Description/Date/Loan amount.
                //Automatically populate AutomotiveLoanItemEntry if an item is selected from this form
            }
        }

        private void textBoxAmountLoadned_KeyPress(object sender, KeyPressEventArgs e)
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
