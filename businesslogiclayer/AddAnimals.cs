using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace BAOBAB_RIDGE_PROJECT_2781.BussinessLogicLayer
{
    internal class AddAnimal
    {
        private string name, species, ID, age, recovery;


        public AddAnimal(string ID, string name, string species, string age, string recovery)
        {
            this.ID = ID;
            this.name = name;
            this.species = species;
            this.age = age;
            this.recovery = recovery;
        }
        public void Add()
        {
            // Call the ClassifyAnimal method to get the status and housing based on the recovery score
            string status;
            string houseing;

            ClassifyAnimal(int.Parse(recovery), out status, out houseing);
            FileStream fs = new FileStream("animals.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(ID + "|" + name + "|" + species + "|" + age + "|" + recovery + "|" + status + "|" + houseing);
            Console.WriteLine("Animal added successfully.");
            sw.Close();
            fs.Close();
        }
        //out is the output values of the method, which will be assigned to the variables passed in as arguments when the method is called.
        //shared method with update
        public static void ClassifyAnimal(int score, out string status, out string houseing)
        {
            if (score >= 0 && score <= 19)
            {
                status = "Critical";
                houseing = "Intensive Care Unit";
            }
            else if (score <= 39)
            {
                status = "Serious";
                houseing = "High-Dependency Ward";
            }
            else if (score <= 59)
            {
                status = "Stable";
                houseing = "Recovery Ward";
            }
            else if (score <= 79)
            {
                status = "Recovering";
                houseing = "Outdoor Enclosure";
            }
            else
            {
                status = "Release-Ready";
                houseing = "Pre-Release Camp";
            }
        }
        public bool IsUniqueID(string animalID)
        {
            animalID = animalID.ToUpper();

            if (!File.Exists("Animals.txt"))
                return true;

            string[] lines = File.ReadAllLines("Animals.txt");

            foreach (string line in lines)
            {
                string[] fields = line.Split('|');

                if (fields[0].ToUpper() == animalID)
                {
                    return false;
                }
            }

            return true;
        }
        public int validateInput()
        {
            string animalId = ID.Trim().ToUpper();

            // Animal ID format
            if (!Regex.IsMatch(animalId, @"^WR-\d{4}$"))
            {
                MessageBox.Show("Animal ID must be in the format WR-0000.");
                //txtID.Focus();
                return 1;
            }

            // Animal ID uniqueness
            if (!IsUniqueID(animalId))
            {
                MessageBox.Show("Animal ID already exists.");
                //txtID.Focus();
                return 1;
            }

            // Name validation
            if (name.Length < 1 || name.Length > 30)
            {
                MessageBox.Show("Name must be between 1 and 30 characters.");
                //txtName.Focus();
                return 2;
            }

            if (name.Contains('|'))
            {
                MessageBox.Show("Name may not contain '|'.");
                //txtName.Focus();
                return 2;
            }

            // Species validation
            if (species.Length < 1 || species.Length > 30)
            {
                MessageBox.Show("Species must be between 1 and 30 characters.");
                //txtSpecies.Focus();
                return 3;
            }

            if (species.Contains('|'))
            {
                MessageBox.Show("Species may not contain '|'.");
                //txtSpecies.Focus();
                return 3;
            }

            // Age validation
            if (!int.TryParse(age, out int ageValue))
            {
                MessageBox.Show("Age must be a whole number between 0 and 100.");
                //txtAge.Focus();
                return 4;
            }

            if (ageValue < 0 || ageValue > 100)
            {
                MessageBox.Show("Age must be a whole number between 0 and 100.");
                //txtAge.Focus();
                return 4;
            }

            // Recovery Score validation
            if (!int.TryParse(recovery, out int recoveryValue))
            {
                MessageBox.Show("Recovery Score must be a whole number between 0 and 100.");
                //txtRecovery.Focus();
                return 5;
            }

            if (recoveryValue < 0 || recoveryValue > 100)
            {
                MessageBox.Show("Recovery Score must be a whole number between 0 and 100.");
                //txtRecovery.Focus();
                return 5;
            }

            return 0;

        }




    }
}

