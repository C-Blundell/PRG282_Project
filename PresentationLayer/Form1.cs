using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
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
            this.Load += Form1_Load;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAnimals();
        }
        //Doesn't this belong to the DataHandler class? 
        private void LoadAnimals()
        {
            string path = "animals.txt";

            if (!File.Exists(path))
            {
                dataGridView1.DataSource = null;
                return;
            }

            var table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Columns.Add("Species");
            table.Columns.Add("Age", typeof(int));
            table.Columns.Add("Recovery Score", typeof(int));
            table.Columns.Add("Status");
            table.Columns.Add("Housing");

            foreach (string line in File.ReadAllLines(path))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] p = line.Split('|').Select(x => x.Trim()).ToArray();
                if (p.Length != 7) continue;

                if (int.TryParse(p[3], out int age) && int.TryParse(p[4], out int score))
                    table.Rows.Add(p[0], p[1], p[2], age, score, p[5], p[6]);
            }

            dataGridView1.DataSource = table;
        }
        //Event that creates a summary
        private void summaryBtn_Click(object sender, EventArgs e)
        {
            dh.CreateSummary();
            MessageBox.Show("Summary has be generated");

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
                    LoadAnimals();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
        }
    }
}
