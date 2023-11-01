using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RecipeGenius
{
    public partial class RecipeShow : Form
    {FilePaths filePaths = new FilePaths();

        List<string[]> AllRecepie = new List<string[]>();
        public string Title { get; set; }
        public RecipeShow()
        {
            InitializeComponent();
            AllRecepie = filePaths.LoadCsvData();
            

        }

        public void PopulateRecipe(string title)
        {
            try
            {
                // Clear any existing items in the ListBox.
                TitelLabel.Text = "";
                richTextBox1.Clear();
                richTextBox2.Clear();
                CookingTimeLabel.Text = "";

                Title = title;
                var recipeShow = AllRecepie.Where(arr => arr.Length > 5 && arr[0].Equals(Title)).FirstOrDefault();
                //var RecipeShow = AllRecepie.FirstOrDefault(arr => arr.Length > 5 && arr[0].Equals(Title, StringComparison.OrdinalIgnoreCase));

                if (Title != null && recipeShow != null)
                {
                    // Add the first element of the user array to the ListBox.

                    TitelLabel.Text = recipeShow[0];
                    CookingTimeLabel.Text = recipeShow[1];
                    richTextBox2.Text = recipeShow[4];
                    richTextBox1.Text = recipeShow[5];
                }
                else
                {

                }
            }
            catch (Exception ex)
            {

                filePaths.LogErrorToFile(ex.Message);
            }
                 

        }
    }
}
