using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeGenius
{
    public class FilePaths
    {
        public string ErrorLoggs { get; } = "C:\\Visual studio projekt\\Windowsforms projekt\\Onsdag-Fredag\\RecipeGenius\\FelLogg.txt";
        public string RecipieList { get; } = "C:\\Visual studio projekt\\Windowsforms projekt\\Onsdag-Fredag\\RecipeGenius\\RecipieList.txt";


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
    }
}
