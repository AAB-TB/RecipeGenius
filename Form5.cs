using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeGenius
{
    public partial class Form5 : Form
    {
        string recipeFile = "C:\\Users\\Meenakshi\\OneDrive\\Desktop\\RecipeGenius\\bin\\Debug\\net7.0-windows\\" + "RecipeList.txt";
        public List<AddRecipe> recipeList = new List<AddRecipe>();

        public Form5()
        {
            InitializeComponent();
        }

        private void SaveRecipeToFile()
        {
            File.AppendAllLines(recipeFile, recipeList.Select(recipeList => recipeList.ToCsv()));
            // File.WriteAllLines(recipeFile, recipeList.Select(recipeList => recipeList.ToCsv()));

        }
        public class AddRecipe
        {
            public string RecipeTitle { get; set; }
            public string RecipeTime { get; set; }
            public string NumberOfServing { get; set; }
            public string Category { get; set; }
            public string Ingredients { get; set; }
            public string Description { get; set; }

            public static AddRecipe FromCsv(string csvLine)
            {
                string[] values = csvLine.Split(',');
                if (values.Length != 6)
                {
                    MessageBox.Show("Invalid CSV format");
                }

                return new AddRecipe
                {
                    RecipeTitle = values[0],
                    RecipeTime = values[1],
                    NumberOfServing = values[2],
                    Category = values[3],
                    Ingredients = values[4],
                    Description = values[5]
                };

            }
            public string ToCsv()
            {
                return $"{RecipeTitle},{RecipeTime},{NumberOfServing},{Category},{Ingredients},{Description}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newRecipe = new AddRecipe
            {

                RecipeTitle = textBox1.Text,
                RecipeTime = textBox2.Text,
                NumberOfServing = textBox3.Text,
                Category = textBox4.Text,
                Ingredients = richTextBox1.Text,
                Description = richTextBox2.Text
            };

            recipeList.Add(newRecipe);
            SaveRecipeToFile();
            ClearTextBoxes();

            MessageBox.Show("Content added successfully.");

        }

        private void ClearTextBoxes()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            richTextBox1.Clear();
            richTextBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string TextLineToUpdate = textBox1.Text + "," + textBox4.Text;

            var recipeToUpdate = recipeList.FirstOrDefault(r => r.RecipeTitle + "," + r.Category == TextLineToUpdate);



            if (recipeToUpdate != null)
            {

                recipeToUpdate.RecipeTime = textBox2.Text;
                recipeToUpdate.NumberOfServing = textBox3.Text;
                recipeToUpdate.Ingredients = richTextBox1.Text;
                recipeToUpdate.Description = richTextBox2.Text;


                SaveRecipeToFile();
                ClearTextBoxes();
                MessageBox.Show("Recipe Updated successfully.");
            }
            else
            {
                MessageBox.Show("Provide Recipe not found. Please check");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string TextLineToDelete = textBox1.Text + "," + textBox4.Text;
            var recipeToDelete = recipeList.FirstOrDefault(r => r.RecipeTitle + "," + r.Category == TextLineToDelete);

            if (recipeToDelete != null)
            {
                recipeList.Remove(recipeToDelete);
                SaveRecipeToFile();

                ClearTextBoxes();
                MessageBox.Show("Recipe Deleted successfully.");
            }
            else
            {
                MessageBox.Show("Recipe not found. Please check");
            }
        }


    }
}