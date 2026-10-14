using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAOBAB_RIDGE_PROJECT_2781.DataAccessLayer;

namespace BAOBAB_RIDGE_PROJECT_2781
{
    public partial class Form1 : Form
    {
        DataHandler dh = new DataHandler();
        public Form1()
        {
           
            InitializeComponent();
        }

        private void summaryBtn_Click(object sender, EventArgs e)
        {
            dh.CreateSummary();
            MessageBox.Show("Summary Has be generated");

        }
    }
}
