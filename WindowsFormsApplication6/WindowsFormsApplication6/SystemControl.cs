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
    public partial class SystemControl : Form
    {
        public SystemControl()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Exit form without saving
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Save Data and update loan_form
            this.Close();
        }
    }
}
