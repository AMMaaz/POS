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
            Purchase p = new Purchase();
            p.PurchaseType = "jewelry";
            p.CustomerID = id;
            dc.Purchases.InsertOnSubmit(p);
            dc.SubmitChanges();

            PurchaseJewelry j = new PurchaseJewelry();
            j.Type = comboBox2.Text;
            j.Metal = comboBox4.Text;
            j.Size = textBox8.Text;
            j.Style = comboBox5.Text;
            j.Sex = comboBox3.Text;
            j.StoneType = comboBox6.Text;
            j.Purity = comboBox1.Text;
            j.StonesNumber = textBox2.Text;
            j.Weight = textBox6.Text;
            j.AddtionalInfo = textBox3.Text;
            j.Description = textBox1.Text;
            j.ItemNotes = textBox5.Text;
            j.AmountLoaned = Convert.ToInt32(textBox4.Text);
            j.PurchaseID = p.PurchaseID;
            dc.PurchaseJewelries.InsertOnSubmit(j);
            dc.SubmitChanges();

            ms.dataGridView3.Rows.Add(1);
            int Row = ms.dataGridView3.Rows.Count - 1;
            ms.dataGridView3.Rows[Row].Cells[0].Value = comboBox2.Text;
            //this does not have catagory
            ms.dataGridView3.Rows[Row].Cells[1].Value = "";
            //this also doesn't have make
            ms.dataGridView3.Rows[Row].Cells[2].Value = "";
            //also no model
            ms.dataGridView3.Rows[Row].Cells[3].Value = "";
            //yes description 
            ms.dataGridView3.Rows[Row].Cells[4].Value = textBox1.Text;
            //expected resale pta karni hy
            ms.dataGridView3.Rows[Row].Cells[5].Value = "";
            ms.dataGridView3.Rows[Row].Cells[6].Value = textBox4.Text;

            this.Close();
        }

        private void JewelryPurchaseItemEntry_Load(object sender, EventArgs e)
        {

        }
    }
}
