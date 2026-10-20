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

        }


        //Doesn't this belong to the DataHandler class? 
        private void LoadAnimals()
        {
            dataGridView1.DataSource = dh.LoadAnimals();
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            LoadRow(e.RowIndex);
        }

        public bool DeleteAnimal(string animalID)
        {
            string path = "animals.txt";

            if (!File.Exists(path))
            {
                return false;
            }

            string[] lines = File.ReadAllLines(path);

            List<string> remainingAnimals = new List<string>();

            bool deleted = false;

            foreach (string line in lines)
            {
                string[] fields = line.Split('|');

                if (fields.Length == 7 &&
                    fields[0].Trim().Equals(animalID, StringComparison.OrdinalIgnoreCase))
                {
                    deleted = true;
                }
                else
                {
                    remainingAnimals.Add(line);
                }
            }

            if (deleted)
            {
                File.WriteAllLines(path, remainingAnimals);
            }

            return deleted;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LoadAnimals();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an animal to delete.");
                return;
            }

            string animalID = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();

            if (string.IsNullOrWhiteSpace(animalID))
            {
                MessageBox.Show("The selected animal has no valid ID.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete animal " + animalID + "?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                bool deleted = dh.DeleteAnimal(animalID);

                if (deleted)
                {
                    MessageBox.Show("Animal deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Animal could not be found.");
                }

                LoadAnimals();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting animal: " + ex.Message);
            }
        }
    }
}
