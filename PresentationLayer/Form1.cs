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

        //loads animal from text file when animal id is put in
        private void Seach_Click(object sender, EventArgs e)
        {
            string[] record = UpdateAnimal.Find(txtSearch.Text);

            if (record == null)
            {
                MessageBox.Show("Animal ID not found.");
                txtSearch.Focus();
                return;
            }

            EnterEditmode(record);

        }

        //Commits changes to text file
        private void saveChanges_Click(object sender, EventArgs e)
        {
            UpdateAnimal upd = new UpdateAnimal(txtID.Text, txtName.Text, txtSpecies.Text, txtAge.Text, txtStatus.Text);
            int validate = upd.validateInput();
            switch (validate)
            {
                case 0:
                    if (upd.Save())
                    {
                        MessageBox.Show("Animal updated successfully.");
                        LoadAnimals();
                        ExitEditMode();
                    }
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

        //leaves edit mode
        private void clear_Click(object sender, EventArgs e)
        {
            ExitEditMode();
        }

        private void LoadRow(int rowIndex)
        {
            string[] record = UpdateAnimal.Find(Convert.ToString(dataGridView1.Rows[rowIndex].Cells[0].Value));

            if (record == null)
            {
                MessageBox.Show("Animal ID not found.");
                return;
            }

            EnterEditmode(record);
        }

        //Makes the data editable, disables add button
        private void EnterEditmode(string[] record)
        {
            txtID.Text = record[0].Trim();
            txtName.Text = record[1].Trim();
            txtSpecies.Text = record[2].Trim();
            txtAge.Text = record[3].Trim();
            txtStatus.Text = record[4].Trim();
            txtID.ReadOnly = true;
            AddAnimals.Enabled = false;
            saveChanges.Enabled = true;
        }

        //Clears data in textboxes and enables add button while disabling save changes button
        private void ExitEditMode()
        {
            txtID.Clear();
            txtName.Clear();
            txtSpecies.Clear();
            txtAge.Clear();
            txtStatus.Clear();
            txtSearch.Clear();
            txtID.ReadOnly = false;
            AddAnimals.Enabled = true;
            saveChanges.Enabled = false;
            txtID.Focus();
        }
        
        //loads edit mode when clicking datagridview
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            LoadRow(e.RowIndex);
        }
    }
}
