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
    public partial class JewelryPurchaseItemEntry : Form
    {
        WebCam webcam;
        int id;
        MainScreen ms;
        DataClassesPOSDBDataContext dc = new DataClassesPOSDBDataContext();

        public JewelryPurchaseItemEntry(MainScreen ms, int id)
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
            //Need to save to file location specified in database SystemSettings PictureLocation "P(purchase number)J(item number on Purchase).jpg"
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
            //Purchase p = new Purchase();
            //p.PurchaseType = "jewelry";
            //p.CustomerID = id;
            //dc.Purchases.InsertOnSubmit(p);
            //dc.SubmitChanges();

            //PurchaseJewelry j = new PurchaseJewelry();
            //j.Type = comboBox2.Text;
            //j.Metal = comboBox4.Text;
            //j.Size = textBox8.Text;
            //j.Style = comboBox5.Text;
            //j.Sex = comboBox3.Text;
            //j.StoneType = comboBox6.Text;
            //j.Purity = comboBox1.Text;
            //j.StonesNumber = textBox2.Text;
            //j.Weight = textBox6.Text;
            //j.AddtionalInfo = textBox3.Text;
            //j.Description = textBox1.Text;
            //j.ItemNotes = textBox5.Text;
            //j.AmountLoaned = Convert.ToInt32(textBox4.Text);
            //j.PurchaseID = p.PurchaseID;
            //dc.PurchaseJewelries.InsertOnSubmit(j);
            //dc.SubmitChanges();

            ms.dataGridViewJ.Rows.Add(1);
            int Row = ms.dataGridViewJ.Rows.Count - 1;
            ms.dataGridViewJ.Rows[Row].Cells[0].Value = comboBox2.Text;
            ms.dataGridViewJ.Rows[Row].Cells[1].Value = textBox1.Text;
            ms.dataGridViewJ.Rows[Row].Cells[2].Value = textBox5.Text;
            //expected resale
            ms.dataGridViewJ.Rows[Row].Cells[3].Value = "";
            ms.dataGridViewJ.Rows[Row].Cells[4].Value = Convert.ToInt32(textBox4.Text);
            ms.dataGridViewJ.Rows[Row].Cells[5].Value = comboBox4.Text;
            ms.dataGridViewJ.Rows[Row].Cells[6].Value = textBox8.Text;
            ms.dataGridViewJ.Rows[Row].Cells[7].Value = comboBox5.Text;
            ms.dataGridViewJ.Rows[Row].Cells[8].Value = comboBox3.Text;
            ms.dataGridViewJ.Rows[Row].Cells[9].Value = comboBox6.Text;
            ms.dataGridViewJ.Rows[Row].Cells[10].Value = comboBox1.Text;
            ms.dataGridViewJ.Rows[Row].Cells[11].Value = textBox2.Text;
            ms.dataGridViewJ.Rows[Row].Cells[12].Value = textBox6.Text;
            ms.dataGridViewJ.Rows[Row].Cells[13].Value = textBox3.Text;

            ms.textBox13.Text = (Convert.ToInt32(ms.textBox13.Text) + Convert.ToInt32(textBox4.Text)).ToString();
            this.Close();
        }

        private void JewelryPurchaseItemEntry_Load(object sender, EventArgs e)
        {

        }
    }
}
