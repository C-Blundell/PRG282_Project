using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BAOBAB_RIDGE_PROJECT_2781.DataAccessLayer
{
    class DataHandler
    {
        
        public void CreateSummary()
        {
            string path = "animals.txt";
            string summaryPath = "summary.txt";
            

            //Validates that the files exists and creates a report
            if (File.Exists(path))
            {
                //Add the varaibles to be created in the report
                DateTime generatedTime = File.GetCreationTime(path);
                int aniCount=0;
                decimal totalAge = 0;
                decimal aniAveAge=0;
                decimal totalRecoveryScore = 0;
                decimal aniAveRecoveryScore=0;
                int criticalCount=0;
                int seriouslCount=0;
                int stableCount=0;
                int recoveringCount=0;
                int releaseReadyCount=0;
                using (var sr= new StreamReader(path))
                {
                    string line;
                    //looping through the animals.txt
                    while ((line=sr.ReadLine())!=null)
                    {
                        var parts = line.Split('|');
                        if (parts.Length==7)
                        {

                            try
                            {
                                if (int.TryParse(parts[3], out int age))
                                {
                                    totalAge += age;
                                }
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message);
                            }
                            try
                            {
                                if (int.TryParse(parts[4], out int RecoveryScore))
                                {
                                    totalRecoveryScore += RecoveryScore;

                                }
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message);
                            }
                            
                            
                            switch (parts[5])
                            {
                                case "Critical":
                                    criticalCount++;
                                    break;
                                case "Serious":
                                    seriouslCount++;
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
                                    MessageBox.Show($"{parts[5]} is not an animal's Status");
                                    break;
                            }


                        }


                    }
                }
                aniAveAge = totalAge / aniCount;
                aniAveRecoveryScore= totalRecoveryScore / aniCount;
                //Writing out the report
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
                    sw.WriteLine($"   Serious:         {seriouslCount}");
                    sw.WriteLine($"   Stable:          {stableCount}");
                    sw.WriteLine($"   Recovering:      {recoveringCount}");
                    sw.WriteLine($"   Release-Ready:   {releaseReadyCount}");
                }
            }

        }
    }
}
