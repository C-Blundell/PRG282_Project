using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BAOBAB_RIDGE_PROJECT_2781.BussinessLogicLayer
{
    internal class UpdateAnimal
    {
        private string name, species, ID, age, recovery;

        public UpdateAnimal(string ID, string name, string species, string age, string recovery)
        {
            this.ID = ID;
            this.name = name;
            this.species = species;
            this.age = age;
            this.recovery = recovery;
        }

        public static string[] Find(string animalID)
        {
            animalID = animalID.Trim().ToUpper();

            if (animalID.Length == 0 || !File.Exists("animals.txt"))
                return null;

            foreach (string line in File.ReadAllLines("animals.txt"))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] fields = line.Split('|');

                if (fields.Length == 7 && fields[0].Trim().ToUpper() == animalID)
                {
                    return fields;
                }
            }

            return null;
        }

        public int validateInput()
        {
            if (name.Length < 1 || name.Length > 30)
            {
                MessageBox.Show("Name must be between 1 and 30 characters.");
                return 2;
            }

            if (name.Contains('|'))
            {
                MessageBox.Show("Name may not contain '|'.");
                return 2;
            }

            if (species.Length < 1 || species.Length > 30)
            {
                MessageBox.Show("Species must be between 1 and 30 characters.");
                return 3;
            }

            if (species.Contains('|'))
            {
                MessageBox.Show("Species may not contain '|'.");
                return 3;
            }

            if (!int.TryParse(age, out int ageValue) || ageValue < 0 || ageValue > 100)
            {
                MessageBox.Show("Age must be a whole number between 0 and 100.");
                return 4;
            }

            if (!int.TryParse(recovery, out int recoveryValue) || recoveryValue < 0 || recoveryValue > 100)
            {
                MessageBox.Show("Recovery Score must be a whole number between 0 and 100.");
                return 5;
            }

            return 0;
        }

        public bool Save()
        {
            if (!File.Exists("animals.txt"))
            {
                MessageBox.Show("Animal ID not found.");
                return false;
            }

            string status;
            string houseing;
            AddAnimal.ClassifyAnimal(int.Parse(recovery), out status, out houseing);

            string[] lines = File.ReadAllLines("animals.txt");
            string target = ID.Trim().ToUpper();
            bool found = false;

            for (int i = 0; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i])) continue;

                string[] fields = lines[i].Split('|');

                if (fields.Length == 7 && fields[0].Trim().ToUpper() == target)
                {
                    lines[i] = fields[0] + "|" + name + "|" + species + "|" + int.Parse(age) + "|" + int.Parse(recovery) + "|" + status + "|" + houseing;
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show("Animal ID not found.");
                return false;
            }

            File.WriteAllLines("animals.txt", lines);
            return true;
        }
    }
}