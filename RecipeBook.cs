using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RecipeGenius
{
    public class RecipeBook
    {
        public string ErrorLoggs { get; } = "C:\\Visual studio projekt\\Windowsforms projekt\\Onsdag-Fredag\\RecipeGenius\\RecipeGenius\\FelLogg.txt";
        public string RecipieFile { get; } = "C:\\Visual studio projekt\\Windowsforms projekt\\Onsdag-Fredag\\RecipeGenius\\RecipeGenius\\RecipeList.txt";
        public string AdminLoggIn { get; } = "C:\\Visual studio projekt\\Windowsforms projekt\\Onsdag-Fredag\\RecipeGenius\\RecipeGenius\\Admin.txt";
        public List<string[]> AllRecipies { get; set; } = new List<string[]>();


        public void LogErrorToFile(string errorMessage)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(ErrorLoggs, true))
                {
                    writer.WriteLine($"{DateTime.Now}: {errorMessage}");
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that may occur while writing to the log file.
                MessageBox.Show("An error occurred while writing to the log file: " + ex.Message);
            }
        }
        public List<string[]> LoadRecipiesData()
        {
            List<string[]> data = new List<string[]>();
            int i = 0;
            if (File.Exists(RecipieFile))
            {

                using (TextFieldParser parser = new TextFieldParser(RecipieFile))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(","); // Assuming your CSV uses comma as a delimiter

                    while (!parser.EndOfData)
                    {
                        string[] fields = parser.ReadFields();
                        i++;
                        if (fields.Length == 6)
                        {
                            // Add the valid user data to the 'data' list.
                            data.Add(fields); // Adding arrays to the data list. 
                        }
                        else
                        {
                            LogErrorToFile($"Wrong number of fields in {RecipieFile} on row {i}");
                        }
                    }
                }
            }
            else
            {
                LogErrorToFile($"The recepie data file was not found {RecipieFile}");
            }
            AllRecipies = data;
            return data;
        }
        public void SaveRecipieData()
        {
            if (AllRecipies.Count() != 0)
            {
                List<string> recipies = new List<string>();

                foreach (string[] user in AllRecipies)
                {
                    string userString = "";
                    // Join the parts of the user array into a single string to display in the ListBox.
                    for (int i = 0; i < 4; i++)
                    {
                        userString += user[i] + ",";
                    }
                    userString += '"' + user[4] + '"' + ',';
                    userString += '"' + user[5] + '"';

                    recipies.Add(userString);
                }
                File.WriteAllLines(this.RecipieFile, recipies);
            }
            else
            {
                LogErrorToFile("No data to process.");
            }
        }
    }
}
