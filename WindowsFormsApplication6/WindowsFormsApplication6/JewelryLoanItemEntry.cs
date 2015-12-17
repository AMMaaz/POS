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
    public partial class JewelryLoanItemEntry : Form
    {
        WebCam webcam;
        DataClassesPOSDBDataContext dc = new DataClassesPOSDBDataContext();
        public loan_form lf;
        int custId = 0;

        public JewelryLoanItemEntry(loan_form lf, int cid)
        {
            InitializeComponent();
            this.lf = lf;
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
            //Need to save to file location specified in database SystemSettings PictureLocation "L(loan number)J(item number on loan).jpg"
            //Helper.SaveImageCapture(pictureBox1.Image);
            //pictureBox1.Save("c:\image.jpg", ImageFormatConverter.);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Exit form without saving
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loan l = new Loan();
            l.LoanType = "jewelry";
            l.CustomerID = custId;
            dc.Loans.InsertOnSubmit(l);
            dc.SubmitChanges();

            LoanJewelry j = new LoanJewelry();
            j.Type = comboBoxType.Text;
            j.Metal = comboBoxMetal.Text;
            j.Size = textBoxSize.Text;
            j.Style = comboBoxStyle.Text;
            j.Sex = comboBoxSex.Text;
            j.StoneType = comboBoxStoneType.Text;
            j.Purity = comboBoxPurity.Text;
            j.StonesNumber = textBoxNumberStones.Text;
            j.Weight = textBoxWeight.Text;
            j.AddtionalInfo = textBoxAdditionInfo.Text;
            j.Description = textBoxDescription.Text;
            j.ItemNotes = textBoxItemNotes.Text;
            j.AmountLoaned = Convert.ToInt32(textBoxAmountLoaned.Text);
            j.LoanID = l.LoanID;
            dc.LoanJewelries.InsertOnSubmit(j);
            dc.SubmitChanges();

            lf.dataGridView2.Rows.Add("Jewerly", comboBoxType.Text, textBoxDescription.Text, "", textBoxAmountLoaned.Text);

            this.Close();
        }

        private void JewelryLoanItemEntry_Load(object sender, EventArgs e)
        {
            //cahnge labels for gold from system control 
            //need table in database
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
