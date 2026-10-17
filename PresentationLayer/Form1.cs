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

using BAOBAB_RIDGE_PROJECT_2781.BussinessLogicLayer;


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

        private void AddAnimals_Click(object sender, EventArgs e)
        {
            AddAnimal add = new AddAnimal(txtID.Text, txtName.Text, txtSpecies.Text, txtAge.Text, txtStatus.Text);
            int validate = add.validateInput();
            switch (validate)
            {
                case 0:
                    add.Add();
                    MessageBox.Show("Animal added successfully.");
                    break;
                case 1:
                    txtID.Focus();
                    break;
                case 2:
                    txtName.Focus();
                    break;
                case 3:
                    txtSpecies.Focus();
                    break;
                case 4:
                    txtAge.Focus();
                    break;
                case 5:
                    txtStatus.Focus();
                    break;
                default:
                    MessageBox.Show("An unknown error occurred.");
                    break;
            }
        }
    }
}
