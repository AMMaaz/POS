﻿using System;
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
    public partial class AutomotivePurchaseItemEntry : Form
    {
        WebCam webcam;
        int id;
        MainScreen ms;
        DataClassesPOSDBDataContext dc = new DataClassesPOSDBDataContext();

        public AutomotivePurchaseItemEntry(MainScreen ms, int id)
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
            //Purchase p = new Purchase();
            //p.PurchaseType = "automotive";
            //p.CustomerID = id;
            //dc.Purchases.InsertOnSubmit(p);
            //dc.SubmitChanges();

            //PurchaseAutomotive pa = new PurchaseAutomotive();
            //pa.Year = textBox9.Text;
            //pa.TypeOfAutomobile = comboBox2.Text;
            //pa.Make = textBox10.Text;
            //pa.BodyType = textBox7.Text;
            //pa.Model = textBox3.Text;
            //pa.PlateTag = textBox6.Text;
            //pa.VINSerialNumber = textBox4.Text;
            //pa.Color = textBox2.Text;
            //pa.Description = textBox1.Text;
            //pa.ItemNotes = textBox5.Text;
            //pa.AmountLoaned = Convert.ToInt32(textBox8.Text);
            //pa.PurchaseID = p.PurchaseID;
            //dc.PurchaseAutomotives.InsertOnSubmit(pa);
            //dc.SubmitChanges();

            ms.dataGridViewA.Rows.Add(1);
            int Row = ms.dataGridViewA.Rows.Count - 1;
            ms.dataGridViewA.Rows[Row].Cells[0].Value = textBox9.Text;
            ms.dataGridViewA.Rows[Row].Cells[1].Value = comboBox2.Text;
            ms.dataGridViewA.Rows[Row].Cells[2].Value = textBox10.Text;
            ms.dataGridViewA.Rows[Row].Cells[3].Value = textBox7.Text;
            ms.dataGridViewA.Rows[Row].Cells[4].Value = textBox3.Text;
            ms.dataGridViewA.Rows[Row].Cells[5].Value = textBox6.Text;
            ms.dataGridViewA.Rows[Row].Cells[6].Value = textBox4.Text;
            ms.dataGridViewA.Rows[Row].Cells[7].Value = textBox2.Text;
            ms.dataGridViewA.Rows[Row].Cells[8].Value = textBox1.Text;
            ms.dataGridViewA.Rows[Row].Cells[9].Value = textBox5.Text;
            ms.dataGridViewA.Rows[Row].Cells[10].Value = Convert.ToInt32(textBox8.Text);

            ms.textBox13.Text = (Convert.ToInt32(ms.textBox13.Text) + Convert.ToInt32(textBox8.Text)).ToString();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                var max = (from x in dc.PurchaseAutomotives
                           where x.Model.Equals(textBox3.Text)
                           select x.AmountLoaned).Max();
                label13.Text = "$" + max;

                var average = (from x in dc.PurchaseAutomotives
                               where x.Model.Equals(textBox3.Text)
                               select x.AmountLoaned).Average();
                label16.Text = "$" + average;
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
            //Find and list in seperate form/windows all loans associated with current Serial number. Display Loan Number/Customer Name/Description/Date/Loan amount.
            //Automatically populate AutomotiveLoanItemEntry if an item is selected from this form
        }
    }
}
