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
    public partial class FirearmPurchaseItemEntry : Form
    {
        WebCam webcam;
        int id;
        private MainScreen ms;
        private int custId;
        DataClassesPOSDBDataContext dc = new DataClassesPOSDBDataContext();

        public FirearmPurchaseItemEntry(MainScreen ms, int id)
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
            //Need to save to file location specified in database SystemSettings PictureLocation "P(purchase number)F(item number on purchase).jpg"
            Helper.SaveImageCapture(pictureBox1.Image);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Cancel - Do not save data on ItemEntry
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Purchase p = new Purchase();
            //p.PurchaseType = "firearm";
            //p.CustomerID = id;
            //dc.Purchases.InsertOnSubmit(p);
            //dc.SubmitChanges();

            //PurchaseFirearm pf = new PurchaseFirearm();
            //pf.Type = comboBox2.Text;
            //pf.Make = textBox2.Text;
            //pf.Action = comboBox5.Text;
            //pf.Model = textBox7.Text;
            //pf.Caliber = textBox3.Text;
            //pf.Importer = textBox6.Text;
            //pf.SerialNumber = textBox4.Text;
            //pf.Finish = comboBox1.Text;
            //pf.Description = textBox1.Text;
            //pf.ItemNotes = textBox5.Text;
            //pf.AmountLoaned = Convert.ToInt32(textBox8.Text);
            //pf.PurchaseID = p.PurchaseID;

            //dc.PurchaseFirearms.InsertOnSubmit(pf);
            //dc.SubmitChanges();

            ms.dataGridViewF.Rows.Add(1);
            int Row = ms.dataGridViewF.Rows.Count - 1;

            ms.dataGridViewF.Rows[Row].Cells[0].Value = comboBox2.Text;
            ms.dataGridViewF.Rows[Row].Cells[1].Value = textBox2.Text;
            ms.dataGridViewF.Rows[Row].Cells[2].Value = comboBox5.Text;
            ms.dataGridViewF.Rows[Row].Cells[3].Value = textBox7.Text;
            ms.dataGridViewF.Rows[Row].Cells[4].Value = textBox3.Text;
            ms.dataGridViewF.Rows[Row].Cells[5].Value = textBox6.Text;
            ms.dataGridViewF.Rows[Row].Cells[6].Value = textBox4.Text;
            ms.dataGridViewF.Rows[Row].Cells[7].Value = comboBox1.Text;
            ms.dataGridViewF.Rows[Row].Cells[8].Value = textBox1.Text;
            ms.dataGridViewF.Rows[Row].Cells[9].Value = textBox5.Text;
            ms.dataGridViewF.Rows[Row].Cells[10].Value = Convert.ToInt32(textBox8.Text);

            ms.textBox13.Text = (Convert.ToInt32(ms.textBox13.Text) + Convert.ToInt32(textBox8.Text)).ToString();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox7.Text != "")
            {
                var max = (from x in dc.PurchaseFirearms
                           where x.Model.Equals(textBox7.Text)
                           select x.AmountLoaned).Max();
                label13.Text = "$" + max;

                var average = (from x in dc.PurchaseFirearms
                               where x.Model.Equals(textBox7.Text)
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
                var result = (from x in dc.PurchaseFirearms
                              where x.SerialNumber.Equals(textBox4.Text)
                              select x).FirstOrDefault();
                comboBox2.Text = result.Type;
                textBox2.Text = result.Make;
                comboBox5.Text = result.Action;
                textBox7.Text = result.Model;
                textBox3.Text = result.Caliber;
                textBox6.Text = result.Importer;
                comboBox1.Text = result.Finish;
                textBox1.Text = result.Description;
                textBox5.Text = result.ItemNotes;
                textBox8.Text = result.AmountLoaned.ToString();

                //Find and list in seperate form/windows all loans associated with current Serial number. Display Loan Number/Customer Name/Description/Date/Loan amount.
                //Automatically populate AutomotiveLoanItemEntry if an item is selected from this form
            }
        }
    }
}
