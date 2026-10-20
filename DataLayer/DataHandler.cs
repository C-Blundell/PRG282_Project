using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAOBAB_RIDGE_PROJECT_2781.DataAccessLayer
{
    class DataHandler
    {
        public List<string> CreateSummary(string path, string summaryPath)
        {
            

            // Validates that the file exists
            if (!File.Exists(path))
            {
                MessageBox.Show("The animals.txt file could not be found.");
                return null;
            }

            var animalDetails = new List<string>();
            DateTime generatedTime = File.GetCreationTime(path);
            int aniCount = 0;
            decimal totalAge = 0;
            decimal totalRecoveryScore = 0;

            int criticalCount = 0;
            int seriousCount = 0;
            int stableCount = 0;
            int recoveringCount = 0;
            int releaseReadyCount = 0;

            using (var sr = new StreamReader(path))
            {
                string line;
                // Looping through the animals.txt
                while ((line = sr.ReadLine()) != null)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 7)
                    {
                        aniCount++; // FIXED: Incrementing animal count!

                        if (int.TryParse(parts[3], out int age))
                        {
                            totalAge += age;
                        }

                        if (int.TryParse(parts[4], out int recoveryScore))
                        {
                            totalRecoveryScore += recoveryScore;
                        }

                        switch (parts[5].Trim())
                        {
                            case "Critical":
                                criticalCount++;
                                break;
                            case "Serious":
                                seriousCount++;
                                break;
                            case "Stable":
                                stableCount++;
                                break;
                            case "Recovering":
                                recoveringCount++;
                                break;
                            case "Release-Ready":
                                releaseReadyCount++;
                                break;
                            default:
                                MessageBox.Show($"{parts[5]} is not a valid animal status.");
                                break;
                        }
                    }
                }
            }

            // Safe division check
            decimal aniAveAge = 0;
            decimal aniAveRecoveryScore = 0;

            if (aniCount > 0)
            {
                aniAveAge = totalAge / aniCount;
                aniAveRecoveryScore = totalRecoveryScore / aniCount;
            }

            // Populate list to return to Form1
            animalDetails.Add(generatedTime.ToString());
            animalDetails.Add(aniCount.ToString());
            animalDetails.Add(aniAveAge.ToString("F2"));
            animalDetails.Add(aniAveRecoveryScore.ToString("F2"));
            animalDetails.Add(criticalCount.ToString());
            animalDetails.Add(seriousCount.ToString());
            animalDetails.Add(stableCount.ToString());
            animalDetails.Add(recoveringCount.ToString());
            animalDetails.Add(releaseReadyCount.ToString());

            // Writing out the report file
            using (var sw = new StreamWriter(summaryPath))
            {
                sw.WriteLine("BAOBAB RIDGE WILDLIFE REHABILITATION CENTRE");
                sw.WriteLine("ANIMAL SUMMARY REPORT");
                sw.WriteLine($"Generated:  {generatedTime}");
                sw.WriteLine("---------------------------------------------");
                sw.WriteLine($"Total animals:               {aniCount}");
                sw.WriteLine($"Average age (years):         {aniAveAge:F2}");
                sw.WriteLine($"Average recovery score:      {aniAveRecoveryScore:F2}");
                sw.WriteLine("---------------------------------------------");
                sw.WriteLine("Animals per status: ");
                sw.WriteLine($"   Critical:        {criticalCount}");
                sw.WriteLine($"   Serious:         {seriousCount}");
                sw.WriteLine($"   Stable:          {stableCount}");
                sw.WriteLine($"   Recovering:      {recoveringCount}");
                sw.WriteLine($"   Release-Ready:   {releaseReadyCount}");
            }

            return animalDetails;
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

        public DataTable LoadAnimals()
        {
            string path = "animals.txt";
            var table = new DataTable();

            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Columns.Add("Species");
            table.Columns.Add("Age", typeof(int));
            table.Columns.Add("Recovery Score", typeof(int));
            table.Columns.Add("Status");
            table.Columns.Add("Housing");

            if (!File.Exists(path))
                return table;

            foreach (string line in File.ReadAllLines(path))
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] p = line.Split('|')
                                 .Select(x => x.Trim())
                                 .ToArray();

                if (p.Length != 7)
                    continue;

                if (int.TryParse(p[3], out int age) &&
                    int.TryParse(p[4], out int score))
                {
                    table.Rows.Add(
                        p[0], p[1], p[2],
                        age, score, p[5], p[6]
                    );
                }
            }

            return table;
        }
    }
}