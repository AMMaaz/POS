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
    public partial class GeneralPurchaseItemEntry : Form
    {
        WebCam webcam;
        int id;
        MainScreen ms;
        DataClassesPOSDBDataContext dc = new DataClassesPOSDBDataContext();
        public GeneralPurchaseItemEntry(MainScreen ms, int id)
        {
            InitializeComponent();
            webcam = new WebCam();
            webcam.InitializeWebCam(ref pictureBox1);
            this.id = id;
            this.ms = ms;
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
            Purchase p = new Purchase();
            p.PurchaseType = "general";
            p.CustomerID = id;
            dc.Purchases.InsertOnSubmit(p);
            dc.SubmitChanges();

            PurchaseGeneral g = new PurchaseGeneral();
            g.Category = comboBox2.Text;
            g.SubCategory = comboBox1.Text;
            g.Make = textBox2.Text;
            g.Model = textBox3.Text;
            g.Description = textBox1.Text;
            g.SerialNumber = textBox4.Text;
            g.ItemNotes = textBox5.Text;
            g.AmountLoaned = Convert.ToInt32(textBox6.Text);
            g.PurchaseID = p.PurchaseID;
            //picture
            dc.PurchaseGenerals.InsertOnSubmit(g);
            dc.SubmitChanges();


            ms.dataGridView3.Rows.Add(1);
            int Row = ms.dataGridView3.Rows.Count - 1;
            //this does not have type
            ms.dataGridView3.Rows[Row].Cells[0].Value = "";
            ms.dataGridView3.Rows[Row].Cells[1].Value = comboBox2.Text;
            ms.dataGridView3.Rows[Row].Cells[2].Value = textBox2.Text;
            ms.dataGridView3.Rows[Row].Cells[3].Value = textBox3.Text;
            ms.dataGridView3.Rows[Row].Cells[4].Value = textBox1.Text;
            //expected resale pta karni hy
            ms.dataGridView3.Rows[Row].Cells[5].Value = "";
            ms.dataGridView3.Rows[Row].Cells[6].Value = textBox6.Text;

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                var max = (from x in dc.PurchaseGenerals
                           where x.Model.Equals(textBox3.Text)
                           select x.AmountLoaned).Max();
                label13.Text = "$" + max;

                var average = (from x in dc.PurchaseGenerals
                               where x.Model.Equals(textBox3.Text)
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

            if (textBox4.Text != "")
            {
                var result = (from x in dc.PurchaseGenerals
                              where x.SerialNumber.Equals(textBox4.Text)
                              select x).FirstOrDefault();
                comboBox2.Text = result.Category;
                comboBox1.Text = result.SubCategory;
                textBox2.Text = result.Make;
                textBox3.Text = result.Model;
                textBox1.Text = result.Description;
                textBox5.Text = result.ItemNotes;
                textBox6.Text = result.AmountLoaned.ToString();

                //Find and list in seperate form/windows all loans associated with current Serial number. Display Loan Number/Customer Name/Description/Date/Loan amount.
                //Automatically populate AutomotiveLoanItemEntry if an item is selected from this form
            }
        }
    }
}
