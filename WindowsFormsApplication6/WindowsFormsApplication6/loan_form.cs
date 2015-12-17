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
    public partial class loan_form : Form
    {
        int custId = 0;
        public loan_form(int cid)
        {
            custId = cid;
            InitializeComponent();
           
        }

        DataClassesPOSDBDataContext dc = new DataClassesPOSDBDataContext();

        private void button1_Click(object sender, EventArgs e)
        {
            GeneralLoanItemEntry newGeneralLoanItemEntryForm = new GeneralLoanItemEntry(custId);
            newGeneralLoanItemEntryForm.lf = this;
            newGeneralLoanItemEntryForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            JewelryLoanItemEntry newJewelryLoanItemEntryForm = new JewelryLoanItemEntry(this, custId);
            newJewelryLoanItemEntryForm.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FirearmLoanItemEntry newFirearmLoanItemEntryForm = new FirearmLoanItemEntry(this, custId);
            newFirearmLoanItemEntryForm.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AutomotiveLoanItemEntry newAutomotiveLoanItemEntryForm = new AutomotiveLoanItemEntry(this, custId);
            newAutomotiveLoanItemEntryForm.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loan/Loans Added");
            //print ticket
        }

        private void loan_form_Load(object sender, EventArgs e)
        {
            var res = (from x in dc.Customers
                       where x.CustomerID.Equals(custId)
                       select x).FirstOrDefault();
            label1.Text = res.LName + " " + res.FName;
        }

      
        

        private void dataGridView2_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int sum = 0;
            int count = 0;
            for(int  i = 0; i<dataGridView2.Rows.Count; i++)
            {
                count++;
                sum += Convert.ToInt32(dataGridView2.Rows[i].Cells["LoanAmount"].Value);
            }
            L_CurrentLoan.Text = sum.ToString();
        }

        private void L_RequestedLoan_TextChanged(object sender, EventArgs e)
        {
            if (L_RequestedLoan.Text != "" && L_CurrentLoan.Text != "")
            {
                L_Difference.Text = (Convert.ToInt32(L_RequestedLoan.Text) - Convert.ToInt32(L_CurrentLoan.Text)).ToString();

            }

        }

        private void L_CurrentLoan_TextChanged(object sender, EventArgs e)
        {
            if (L_RequestedLoan.Text != "" && L_CurrentLoan.Text != "")
            {
                L_Difference.Text = (Convert.ToInt32(L_RequestedLoan.Text) - Convert.ToInt32(L_CurrentLoan.Text)).ToString();

            }
        }
    }
}
