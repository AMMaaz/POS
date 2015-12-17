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
    public struct DateTimeSpan
    {
        private readonly int years;
        private readonly int months;
        private readonly int days;
        private readonly int hours;
        private readonly int minutes;
        private readonly int seconds;
        private readonly int milliseconds;

        public DateTimeSpan(int years, int months, int days, int hours, int minutes, int seconds, int milliseconds)
        {
            this.years = years;
            this.months = months;
            this.days = days;
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
            this.milliseconds = milliseconds;
        }

        public int Years { get { return years; } }
        public int Months { get { return months; } }
        public int Days { get { return days; } }
        public int Hours { get { return hours; } }
        public int Minutes { get { return minutes; } }
        public int Seconds { get { return seconds; } }
        public int Milliseconds { get { return milliseconds; } }

        enum Phase { Years, Months, Days, Done }

        public static DateTimeSpan CompareDates(DateTime date1, DateTime date2)
        {
            if (date2 < date1)
            {
                var sub = date1;
                date1 = date2;
                date2 = sub;
            }

            DateTime current = date1;
            int years = 0;
            int months = 0;
            int days = 0;

            Phase phase = Phase.Years;
            DateTimeSpan span = new DateTimeSpan();

            while (phase != Phase.Done)
            {
                switch (phase)
                {
                    case Phase.Years:
                        if (current.AddYears(years + 1) > date2)
                        {
                            phase = Phase.Months;
                            current = current.AddYears(years);
                        }
                        else
                        {
                            years++;
                        }
                        break;
                    case Phase.Months:
                        if (current.AddMonths(months + 1) > date2)
                        {
                            phase = Phase.Days;
                            current = current.AddMonths(months);
                        }
                        else
                        {
                            months++;
                        }
                        break;
                    case Phase.Days:
                        if (current.AddDays(days + 1) > date2)
                        {
                            current = current.AddDays(days);
                            var timespan = date2 - current;
                            span = new DateTimeSpan(years, months, days, timespan.Hours, timespan.Minutes, timespan.Seconds, timespan.Milliseconds);
                            phase = Phase.Done;
                        }
                        else
                        {
                            days++;
                        }
                        break;
                }
            }

            return span;
        }
    }

    public partial class MainScreen : Form
    {
        bool ViewCustomerCheck = false;
        WebCam webcam;
        DataClassesPOSDBDataContext db = new DataClassesPOSDBDataContext();
        int custId = 0;
        bool SaveSuccess = false;
        int searchindex = 0;
        public MainScreen()
        {
            InitializeComponent();
            webcam = new WebCam();
            webcam.InitializeWebCam(ref pictureBox1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TakeNewCustomerPicture newTakeNewCustomerPictureForm = new TakeNewCustomerPicture();
            newTakeNewCustomerPictureForm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            loan_form newForm = new loan_form(custId);
            newForm.ShowDialog();
        }

        //Save new customer to database.
        private void SaveCustomer(){
            try{
                if (TEB_Btn.Checked == true)
                {
                    if (C_LastName.Text != "" && C_FirstName.Text != "" && C_StreetAddress.Text != "" && C_City.Text != "" && C_State.Text != "" && C_Zip.Text != "" && C_IDNumber.Text != "" && C_EmailAddress.Text != "")
                    {
                        var result = (from x in db.Customers
                                      where x.CustomerID.Equals(custId)
                                      select x).FirstOrDefault();
                        result.FName = C_FirstName.Text;
                        result.LName = C_LastName.Text;
                        result.Address = C_StreetAddress.Text;
                        result.City = C_City.Text;
                        result.State = C_State.Text;
                        result.Zip = C_Zip.Text;
                        result.ID_Number = C_IDNumber.Text;
                        result.ID_Expiration = Convert.ToDateTime(C_IDExpiration.Value.ToShortDateString());
                        result.Email_Address = C_EmailAddress.Text;
                        db.SubmitChanges();
                        //pic box rahta hy

                        MessageBox.Show("Customer Info Updated");
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
                        var result = (from x in db.Customers
                                      where x.CustomerID.Equals(custId)
                                      select x).FirstOrDefault();
                        result.FName = C_FirstName.Text;
                        result.LName = C_LastName.Text;
                        result.Address = C_StreetAddress.Text;
                        result.City = C_City.Text;
                        result.State = C_State.Text;
                        result.Zip = C_Zip.Text;
                        result.ID_Number = C_IDNumber.Text;
                        result.ID_Expiration = Convert.ToDateTime(C_IDExpiration.Value.ToShortDateString());
                        result.DOB = Convert.ToDateTime(C_DOB.Value.ToShortDateString());
                        result.Sex = C_Sex.Text;
                        result.Race = C_Race.Text;
                        result.Height = C_Height.Text;
                        result.Weight = C_Weight.Text;
                        result.Hair = C_Hair.Text;
                        result.Eye_Color = C_Eyes.Text;
                        result.Cell = C_Cell.Text;
                        //date cell was updated add karna hy
                        result.Cell_Texting = C_CellTexting.Checked.ToString();
                        result.Home_Phone = C_HomePhone.Text;
                        result.Email_Address = C_EmailAddress.Text;
                        result.Customer_Added_Date = Convert.ToDateTime(C_CustomerAddedDate.Value.ToShortDateString());
                        //c.note = C_Notes.Text;
                        db.SubmitChanges();
                        //pic box database main add karna hy
                        MessageBox.Show("Customer Info Updated");
                    }
                    else
                    {
                        MessageBox.Show("Fill all Fields in Form");
                    }
                }
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }


        //Save new record.
        private void C_SaveCustomer_Click(object sender, EventArgs e)
        {
            SaveCustomer();
            if (SaveSuccess == true)
            {
                tabControlMainMenu.SelectedIndex = 2;
                label52.Text = C_LastName.Text + " " + C_FirstName.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SystemControl newSystemControlForm = new SystemControl();
            newSystemControlForm.ShowDialog();
        }

        //Display user names on main screen load.
        private void MainScreen_Load(object sender, EventArgs e)
        {
            var result = (from x in db.Customers where x.LName!=""
                          select new
                          {
                              x.LName,
                              x.CustomerID
                          }).ToList();
            Searched_Results.DataSource = result;
            Searched_Results.DisplayMember = "LName";
            Searched_Results.ValueMember = "Id";
            Searched_Results.Text = "";
        }


        //Display user in combo box.
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMainMenu.SelectedIndex == 0)
            {
                Search_By.SelectedIndex = 0;
                var result = (from x in db.Customers where x.LName !=""
                              select new
                              {
                                  x.LName,
                                  x.CustomerID
                              }).Distinct().ToList();
                Searched_Results.DataSource = result;
                Searched_Results.DisplayMember = "LName";
            }

            if (tabControlMainMenu.SelectedIndex == 1){
                
            }
        }
        //Select result on pressing Enter
        private void Searched_Results_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter) {
                ViewCustomerCheck = true;
                tabControlMainMenu.SelectedIndex = 1;
            }
        }

        private void Search_By_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Last Name
            if (Search_By.SelectedIndex == 0) {
                var result = (from x in db.Customers where x.LName !=""
                              select new
                              {
                                  x.LName,
                                  x.CustomerID
                              }).Distinct().ToList();

                Searched_Results.DataSource = result;
                Searched_Results.DisplayMember = "LName";
                searchindex = 1;
            }
            //First Name
            if (Search_By.SelectedIndex == 1)
            {
                var result = (from x in db.Customers where x.FName !=""
                              select new
                              {
                                  x.FName,
                                  x.CustomerID
                              }).Distinct().ToList();

                Searched_Results.DataSource = result;
                Searched_Results.DisplayMember = "FName";
                searchindex = 2;
            }

            //Phone
            if (Search_By.SelectedIndex == 2) {
                var result = (from x in db.Customers where x.Cell !=""
                              select new
                              {
                                  x.Cell
                              }).Distinct().ToList();
                Searched_Results.DataSource = result;
                Searched_Results.DisplayMember = "Cell";
                searchindex = 3;
            }

            //Email
            if (Search_By.SelectedIndex == 3) {
                var result = (from x in db.Customers where x.Email_Address!=""
                              select new
                              {
                                  x.Email_Address
                              }).Distinct().ToList();
                Searched_Results.DataSource = result;
                Searched_Results.DisplayMember = "Email_Address";
                searchindex = 4;
            }
            //Customer Number
            if (Search_By.SelectedIndex == 4) {
                var result = (from x in db.Customers
                              select new
                              {
                                  x.CustomerID
                              }).Distinct().ToList();
                Searched_Results.DataSource = result;
                Searched_Results.DisplayMember = "Id";
                searchindex = 5;
            }
        }

        private void Customer_Search_Btn_Click(object sender, EventArgs e)
        {
            if (Search_By.Text == "" || Search_By.Text == "Last Name")
            {
            dataGridViewSearchedCustomers.DataSource = (from x in db.Customers
                                                        where x.LName.Equals(Searched_Results.Text)
                                                        select x).ToList();
            }
            else if (Search_By.Text == "First Name")
            {
                dataGridViewSearchedCustomers.DataSource = (from x in db.Customers
                                                            where x.FName.Equals(Searched_Results.Text)
                                                            select x).ToList();
            }
            else if (Search_By.Text == "Phone Number")
            {
                dataGridViewSearchedCustomers.DataSource = (from x in db.Customers
                                                            where x.Home_Phone.Equals(Searched_Results.Text)
                                                            select x).ToList();
            }
            else if (Search_By.Text == "Email Address")
            {
                dataGridViewSearchedCustomers.DataSource = (from x in db.Customers
                                                            where x.Email_Address.Equals(Searched_Results.Text)
                                                            select x).ToList();
            }
            else if (Search_By.Text == "Customer Number")
            {
                dataGridViewSearchedCustomers.DataSource = (from x in db.Customers
                                                            where x.CustomerID.Equals(Searched_Results.Text)
                                                            select x).ToList();
            }
            dataGridViewSearchedCustomers.Columns[0].Visible = false;
            dataGridViewSearchedCustomers.Columns[23].Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var result = (from x in db.Customers
                          where x.CustomerID == Convert.ToInt32(dataGridViewSearchedCustomers.SelectedRows[0].Cells[0].Value)
                          select x).FirstOrDefault();

            custId = result.CustomerID;
            C_FirstName.Text = result.FName;
            C_LastName.Text = result.LName;
            C_StreetAddress.Text = result.Address;
            C_State.Text = result.State;
            C_Zip.Text = result.Zip;
            C_IDNumber.Text = result.ID_Number;
            C_IDExpiration.Value = Convert.ToDateTime(result.ID_Expiration);
            if (result.DOB != null)
                C_DOB.Value = Convert.ToDateTime(result.DOB);
            C_Sex.Text = result.Sex;
            C_Race.Text = result.Race;
            C_Height.Text = result.Height;
            C_Weight.Text = result.Weight;
            C_Hair.Text = result.Hair;
            C_Eyes.Text = result.Eye_Color;
            C_Cell.Text = result.Cell;
            C_CellTexting.Text = result.Cell_Texting;
            C_HomePhone.Text = result.Home_Phone;
            C_EmailAddress.Text = result.Email_Address;
            if (result.Customer_Added_Date != null)
                C_CustomerAddedDate.Value = Convert.ToDateTime(result.Customer_Added_Date);

            var loans = from x in db.Loans
                        where x.CustomerID.Equals(result.CustomerID)
                        select new
                        {
                            x.LoanID,
                            //x.DueDate
                            x.LoanType,
                            //x.
                        };
            
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;

            foreach (var l in loans)
            {
                dataGridView2.Rows.Add(1);
                dataGridView1.Rows.Add(1);
                int row = dataGridView2.Rows.Count - 1;

                if (l.LoanType == "general")
                {
                    var loan = (from x in db.Generals
                                  where x.LoanID.Equals(l.LoanID)
                                  select new
                                  {
                                      x.LoanID,
                                      //x.duedate,
                                      x.Description,
                                      x.AmountLoaned
                                      //x.monthlycharges,
                                      //x.tatalcharges,
                                      //x.toalredeemtoday,
                                      //x.paymeny
                                  }).FirstOrDefault();
                    dataGridView2.Rows[row].Cells[0].Value = loan.LoanID;
                    dataGridView2.Rows[row].Cells[2].Value = loan.Description;
                    dataGridView2.Rows[row].Cells[3].Value = loan.AmountLoaned;
                    dataGridView1.Rows[row].Cells[0].Value = loan.LoanID;
                    dataGridView1.Rows[row].Cells[2].Value = loan.Description;
                    dataGridView1.Rows[row].Cells[3].Value = loan.AmountLoaned;
                }
                else if (l.LoanType == "jewelry")
                {
                    var loan = (from x in db.Jewelries
                                   where x.LoanID.Equals(l.LoanID)
                                   select new
                                   {
                                       x.LoanID,
                                       //x.duedate,
                                       x.Description,
                                       x.AmountLoaned
                                       //x.monthlycharges,
                                       //x.tatalcharges,
                                       //x.toalredeemtoday,
                                       //x.paymeny
                                   }).FirstOrDefault();
                    dataGridView2.Rows[row].Cells[0].Value = loan.LoanID;
                    dataGridView2.Rows[row].Cells[2].Value = loan.Description;
                    dataGridView2.Rows[row].Cells[3].Value = loan.AmountLoaned;
                    dataGridView1.Rows[row].Cells[0].Value = loan.LoanID;
                    dataGridView1.Rows[row].Cells[2].Value = loan.Description;
                    dataGridView1.Rows[row].Cells[3].Value = loan.AmountLoaned;
                }
                else if (l.LoanType == "firearm")
                {
                    var loan = (from x in db.Firearms
                                   where x.LoanID.Equals(l.LoanID)
                                   select new
                                   {
                                       x.LoanID,
                                       //x.duedate,
                                       x.Description,
                                       x.AmountLoaned
                                       //x.monthlycharges,
                                       //x.tatalcharges,
                                       //x.toalredeemtoday,
                                       //x.paymeny
                                   }).FirstOrDefault();
                    dataGridView2.Rows[row].Cells[0].Value = loan.LoanID;
                    dataGridView2.Rows[row].Cells[2].Value = loan.Description;
                    dataGridView2.Rows[row].Cells[3].Value = loan.AmountLoaned;
                    dataGridView1.Rows[row].Cells[0].Value = loan.LoanID;
                    dataGridView1.Rows[row].Cells[2].Value = loan.Description;
                    dataGridView1.Rows[row].Cells[3].Value = loan.AmountLoaned;
                }
                else if (l.LoanType == "automotive")
                {
                    var loan = (from x in db.Automotives
                                   where x.LoanID.Equals(l.LoanID)
                                   select new
                                   {
                                       x.LoanID,
                                       //x.duedate,
                                       x.Description,
                                       x.AmountLoaned
                                       //x.monthlycharges,
                                       //x.tatalcharges,
                                       //x.toalredeemtoday,
                                       //x.paymeny
                                   }).FirstOrDefault();
                    dataGridView2.Rows[row].Cells[0].Value = loan.LoanID;
                    dataGridView2.Rows[row].Cells[2].Value = loan.Description;
                    dataGridView2.Rows[row].Cells[3].Value = loan.AmountLoaned;
                    dataGridView1.Rows[row].Cells[0].Value = loan.LoanID;
                    dataGridView1.Rows[row].Cells[2].Value = loan.Description;
                    dataGridView1.Rows[row].Cells[3].Value = loan.AmountLoaned;
                }
            }

            tabControlMainMenu.SelectedIndex = 1;
            label52.Text = result.LName + " " + result.FName;
            label59.Text = result.LName + " " + result.FName;
            label76.Text = result.LName + " " + result.FName;
            label77.Text = result.LName + " " + result.FName;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer ac = new AddCustomer();
            ac.ShowDialog();

            //var result = (from x in db.Customers
            //              select x).Last();

            //custId = result.CustomerID;
            //C_FirstName.Text = result.FName;
            //C_LastName.Text = result.LName;
            //C_StreetAddress.Text = result.Address;
            //C_State.Text = result.State;
            //C_Zip.Text = result.Zip;
            //C_IDNumber.Text = result.ID_Number;
            //C_IDExpiration.Value = Convert.ToDateTime(result.ID_Expiration);
            //C_DOB.Value = Convert.ToDateTime(result.DOB);
            //C_Sex.Text = result.Sex;
            //C_Race.Text = result.Race;
            //C_Height.Text = result.Height;
            //C_Weight.Text = result.Weight;
            //C_Hair.Text = result.Hair;
            //C_Eyes.Text = result.Eye_Color;
            //C_Cell.Text = result.Cell;
            //C_CellTexting.Text = result.Cell_Texting;
            //C_HomePhone.Text = result.Home_Phone;
            //C_EmailAddress.Text = result.Email_Address;
            //C_CustomerAddedDate.Value = Convert.ToDateTime(result.Customer_Added_Date);

            //var loans = from x in db.Loans
            //            where x.CustomerID.Equals(result.CustomerID)
            //            select new
            //            {
            //                x.LoanID,
            //                //x.DueDate
            //                x.LoanType,
            //                //x.
            //            };

            //dataGridView1.DataSource = null;
            //dataGridView2.DataSource = null;

            //foreach (var l in loans)
            //{
            //    dataGridView2.Rows.Add(1);
            //    dataGridView1.Rows.Add(1);
            //    int row = dataGridView2.Rows.Count - 1;

            //    if (l.LoanType == "general")
            //    {
            //        var loan = (from x in db.Generals
            //                    where x.LoanID.Equals(l.LoanID)
            //                    select new
            //                    {
            //                        x.LoanID,
            //                        //x.duedate,
            //                        x.Description,
            //                        x.AmountLoaned
            //                        //x.monthlycharges,
            //                        //x.tatalcharges,
            //                        //x.toalredeemtoday,
            //                        //x.paymeny
            //                    }).FirstOrDefault();
            //        dataGridView2.Rows[row].Cells[0].Value = loan.LoanID;
            //        dataGridView2.Rows[row].Cells[2].Value = loan.Description;
            //        dataGridView2.Rows[row].Cells[3].Value = loan.AmountLoaned;
            //        dataGridView1.Rows[row].Cells[0].Value = loan.LoanID;
            //        dataGridView1.Rows[row].Cells[2].Value = loan.Description;
            //        dataGridView1.Rows[row].Cells[3].Value = loan.AmountLoaned;
            //    }
            //    else if (l.LoanType == "jewelry")
            //    {
            //        var loan = (from x in db.Jewelries
            //                    where x.LoanID.Equals(l.LoanID)
            //                    select new
            //                    {
            //                        x.LoanID,
            //                        //x.duedate,
            //                        x.Description,
            //                        x.AmountLoaned
            //                        //x.monthlycharges,
            //                        //x.tatalcharges,
            //                        //x.toalredeemtoday,
            //                        //x.paymeny
            //                    }).FirstOrDefault();
            //        dataGridView2.Rows[row].Cells[0].Value = loan.LoanID;
            //        dataGridView2.Rows[row].Cells[2].Value = loan.Description;
            //        dataGridView2.Rows[row].Cells[3].Value = loan.AmountLoaned;
            //        dataGridView1.Rows[row].Cells[0].Value = loan.LoanID;
            //        dataGridView1.Rows[row].Cells[2].Value = loan.Description;
            //        dataGridView1.Rows[row].Cells[3].Value = loan.AmountLoaned;
            //    }
            //    else if (l.LoanType == "firearm")
            //    {
            //        var loan = (from x in db.Firearms
            //                    where x.LoanID.Equals(l.LoanID)
            //                    select new
            //                    {
            //                        x.LoanID,
            //                        //x.duedate,
            //                        x.Description,
            //                        x.AmountLoaned
            //                        //x.monthlycharges,
            //                        //x.tatalcharges,
            //                        //x.toalredeemtoday,
            //                        //x.paymeny
            //                    }).FirstOrDefault();
            //        dataGridView2.Rows[row].Cells[0].Value = loan.LoanID;
            //        dataGridView2.Rows[row].Cells[2].Value = loan.Description;
            //        dataGridView2.Rows[row].Cells[3].Value = loan.AmountLoaned;
            //        dataGridView1.Rows[row].Cells[0].Value = loan.LoanID;
            //        dataGridView1.Rows[row].Cells[2].Value = loan.Description;
            //        dataGridView1.Rows[row].Cells[3].Value = loan.AmountLoaned;
            //    }
            //    else if (l.LoanType == "automotive")
            //    {
            //        var loan = (from x in db.Automotives
            //                    where x.LoanID.Equals(l.LoanID)
            //                    select new
            //                    {
            //                        x.LoanID,
            //                        //x.duedate,
            //                        x.Description,
            //                        x.AmountLoaned
            //                        //x.monthlycharges,
            //                        //x.tatalcharges,
            //                        //x.toalredeemtoday,
            //                        //x.paymeny
            //                    }).FirstOrDefault();
            //        dataGridView2.Rows[row].Cells[0].Value = loan.LoanID;
            //        dataGridView2.Rows[row].Cells[2].Value = loan.Description;
            //        dataGridView2.Rows[row].Cells[3].Value = loan.AmountLoaned;
            //        dataGridView1.Rows[row].Cells[0].Value = loan.LoanID;
            //        dataGridView1.Rows[row].Cells[2].Value = loan.Description;
            //        dataGridView1.Rows[row].Cells[3].Value = loan.AmountLoaned;
            //    }
            //}

            //tabControlMainMenu.SelectedIndex = 1;
            //label52.Text = result.LName + " " + result.FName;
            //label59.Text = result.LName + " " + result.FName;
            //label76.Text = result.LName + " " + result.FName;
            //label77.Text = result.LName + " " + result.FName;

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
            var dateSpan = DateTimeSpan.CompareDates(C_DOB.Value, dateTimePicker1.Value);
            C_Age.Text = dateSpan.Years.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            GeneralPurchaseItemEntry gpie = new GeneralPurchaseItemEntry();
            gpie.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            JewelryPurchaseItemEntry jpie = new JewelryPurchaseItemEntry();
            jpie.ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            FirearmPurchaseItemEntry fpie = new FirearmPurchaseItemEntry();
            fpie.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            AutomotivePurchaseItemEntry apie = new AutomotivePurchaseItemEntry();
            apie.ShowDialog();
        }
    }
}
