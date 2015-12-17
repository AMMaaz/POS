using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        DataClassesPOSDBDataContext dc = new DataClassesPOSDBDataContext();

        private void button9_Click(object sender, EventArgs e)
        {
            TakeNewCustomerPicture newTakeNewCustomerPictureForm = new TakeNewCustomerPicture();
            newTakeNewCustomerPictureForm.Show();
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            if (TEB_Btn.Checked == true)
            {
                if (C_LastName.Text != "" && C_FirstName.Text != "" && C_StreetAddress.Text != "" && C_City.Text != "" && C_State.Text != "" && C_Zip.Text != "" && C_IDNumber.Text != "" && C_EmailAddress.Text != "")
                {
                    Customer c = new Customer();
                    c.FName = C_FirstName.Text;
                    c.LName = C_LastName.Text;
                    var result = (from x in dc.Customers
                                 where x.FName.Equals(C_FirstName.Text) && x.LName.Equals(C_LastName.Text)
                                 select x).ToList();
                    c.Suffix = (result.Count + 1).ToString();
                    c.Address = C_StreetAddress.Text;
                    c.City = C_City.Text;
                    c.State = C_State.Text;
                    c.Zip = C_Zip.Text;
                    c.ID_Number = C_IDNumber.Text;
                    c.ID_Expiration = Convert.ToDateTime(C_IDExpiration.Value.ToShortDateString());
                    c.Email_Address = C_EmailAddress.Text;
                    dc.Customers.InsertOnSubmit(c);
                    dc.SubmitChanges();
                    //pic box rahta hy

                    MessageBox.Show("Customer Added");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Fill all Fields in Form");
                }
            }
            else
            {
                if (C_LastName.Text != "" && C_FirstName.Text != "" && C_StreetAddress.Text != "" && C_City.Text != "" && C_State.Text != "" && C_Zip.Text != "" && C_IDNumber.Text != "" && C_EmailAddress.Text != "" && C_Sex.Text != "" && C_Race.Text != "" && C_Height.Text != "" && C_Weight.Text != "" && C_Hair.Text != "" && C_Eyes.Text != "" && C_Cell.Text != "")
                {
                    Customer c = new Customer();
                    c.FName = C_FirstName.Text;
                    c.LName = C_LastName.Text;
                    var result = (from x in dc.Customers
                                  where x.FName.Equals(C_FirstName.Text) && x.LName.Equals(C_LastName.Text)
                                  select x).ToList();
                    c.Suffix = (result.Count + 1).ToString();
                    c.Address = C_StreetAddress.Text;
                    c.City = C_City.Text;
                    c.State = C_State.Text;
                    c.Zip = C_Zip.Text;
                    c.ID_Number = C_IDNumber.Text;
                    c.ID_Expiration = Convert.ToDateTime(C_IDExpiration.Value.ToShortDateString());
                    c.DOB = Convert.ToDateTime(C_DOB.Value.ToShortDateString());
                    c.Sex = C_Sex.Text;
                    c.Race = C_Race.Text;
                    c.Height = C_Height.Text;
                    c.Weight = C_Weight.Text;
                    c.Hair = C_Hair.Text;
                    c.Eye_Color = C_Eyes.Text;
                    c.Cell = C_Cell.Text;
                    //date cell was updated add karna hy
                    c.Cell_Texting = C_CellTexting.Checked.ToString();
                    c.Home_Phone = C_HomePhone.Text;
                    c.Email_Address = C_EmailAddress.Text;
                    c.Customer_Added_Date = Convert.ToDateTime(C_CustomerAddedDate.Value.ToShortDateString());
                    //c.note = C_Notes.Text;
                    dc.Customers.InsertOnSubmit(c);
                    dc.SubmitChanges();
                    //pic box database main add karna hy
                    MessageBox.Show("Customer Added");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Fill all Fields in Form");
                }
            }
        }

        private void TEB_Btn_CheckedChanged(object sender, EventArgs e)
        {
            if (TEB_Btn.Checked == true)
            {
                C_Cell.Enabled = false;
                C_CellTexting.Enabled = false;
                C_Sex.Enabled = false;
                C_DOB.Enabled = false;
                C_Race.Enabled = false;
                C_Hair.Enabled = false;
                C_Height.Enabled = false;
                C_Weight.Enabled = false;
                C_Eyes.Enabled = false;
                C_HomePhone.Enabled = false;
                C_Notes.Enabled = false;
                C_CustomerAddedDate.Enabled = false;
            }
            else
            {
                C_Cell.Enabled = !false;
                C_CellTexting.Enabled = !false;
                C_Sex.Enabled = !false;
                C_DOB.Enabled = !false;
                C_Race.Enabled = !false;
                C_Hair.Enabled = !false;
                C_Height.Enabled = !false;
                C_Weight.Enabled = !false;
                C_Eyes.Enabled = !false;
                C_HomePhone.Enabled = !false;
                C_Notes.Enabled = !false;
                C_CustomerAddedDate.Enabled = !false;
            }
        }

        private void C_DOB_ValueChanged(object sender, EventArgs e)
        {
            if(C_DOB.Value > DateTime.Now)
            {
                C_DOB.Value = DateTime.Now;
            }
            var dateSpan = DateTimeSpan.CompareDates(C_DOB.Value, DateTime.Now.Date);
            C_Age.Text = dateSpan.Years.ToString();
            
        }

        private void C_Age_TextChanged(object sender, EventArgs e)
        {
            if(C_Age.Text!= "")
            {
                if(Convert.ToInt32(C_Age.Text) < 18)
                {
                    MessageBox.Show("Age is less than 18");
                    C_Age.Text = "";
                }
            }
        }
    }
}
