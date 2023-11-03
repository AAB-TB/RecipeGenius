using Microsoft.VisualBasic.FileIO;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace RecipeGenius
{
    public partial class AdminNewForm : Form
    {
        RecipeBook recipeBook = new RecipeBook();

        List<string[]> Recipies = new List<string[]>();

        public string RecipieKey { get; set; }

        public List<AddRecipe> recipeList = new List<AddRecipe>();

        AddRecipe addRecipe = new AddRecipe();
        public AdminNewForm()
        {
            InitializeComponent();
            LoadCsvData(recipeBook.RecipieFile);
            Recipies = recipeBook.LoadRecipiesData();
        }

        int indexRow;
        public void LoadCsvData(string recipeFile)
        {
            try
            {
                if (File.Exists(recipeFile))
                {
                    dataGridView1.Rows.Clear();
                    using (TextFieldParser parser = new TextFieldParser(recipeFile))
                    {
                        parser.TextFieldType = FieldType.Delimited;
                        parser.SetDelimiters(","); // Assuming your CSV uses a comma as a delimiter

                        while (!parser.EndOfData)
                        {
                            string[] fields = parser.ReadFields();
                            dataGridView1.Rows.Add(fields);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("File not found.");
                }
            }
            catch (Exception ex)
            {
                recipeBook.LogErrorToFile(ex.Message);
            }
        }


        public void SaveRecipeToFile(string file)
        {
            File.AppendAllLines(file, recipeList.Select(recipeList => recipeList.ToCsv()));
        }
        //**************************ADD BUTTON***********************************************************     
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string titleCheck = textBox1.Text;
                var checkTitel = Recipies.Where(arr => arr[0].Equals(titleCheck.Trim(), StringComparison.CurrentCultureIgnoreCase));

                if (checkTitel.Count() == 0)
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
                    SaveRecipeToFile(recipeBook.RecipieFile);
                    ClearTextBoxes();
                    Recipies = recipeBook.LoadRecipiesData();
                    LoadCsvData(recipeBook.RecipieFile);
                    MessageBox.Show("Content added successfully.");
                }
                else
                {
                    recipeBook.LogErrorToFile("Recipe title already exists, user has to change the title for the new recipe.");
                    MessageBox.Show("Recipe title already exists, Change the title.");
                }
            }
            catch (Exception ex)
            {
                recipeBook.LogErrorToFile(ex.Message);
            }
        }

        public void ClearTextBoxes()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            richTextBox1.Clear();
            richTextBox2.Clear();
        }
        //*******************************SEARCH BUTTON**************************************************************
        private void button2_Click(object sender, EventArgs e)
        {

            // Specify the column to search (e.g., column 1 for the second column).
            int columnToSearch = 0;

            // Get the search term from a text box (replace with your control).
            string searchTerm = textSearch.Text;

            // Looking for title or Category
            var recipieFound = Recipies.Where(arr => arr[3].Equals(searchTerm.Trim(), StringComparison.CurrentCultureIgnoreCase)
            || arr[0].Equals(searchTerm.Trim(), StringComparison.CurrentCultureIgnoreCase));

            // Search for and filter the data based on the specified column and search term.
            List<string[]> filteredData = recipieFound.ToList();

            // Display the filtered data in the DataGridView.
            DisplayFilteredData(filteredData);
            textSearch.Clear();

        }
        //*************************************UPDATE BUTTON*************************************************

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (indexRow >= 0 && indexRow < dataGridView1.Rows.Count)
                {
                    DataGridViewRow newDataRow = dataGridView1.Rows[indexRow];
                    newDataRow.Cells[0].Value = textBox1.Text;
                    newDataRow.Cells[1].Value = textBox2.Text;
                    newDataRow.Cells[2].Value = textBox3.Text;
                    newDataRow.Cells[3].Value = textBox4.Text;
                    newDataRow.Cells[4].Value = richTextBox1.Text;
                    newDataRow.Cells[5].Value = richTextBox2.Text;

                    UpdateCsvData(indexRow);
                    LoadCsvData(recipeBook.RecipieFile);
                   
                    ClearTextBoxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                recipeBook.LogErrorToFile(ex.Message);
            }
        }
        //***************************************DELETE BUTTON********************************************************
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                var recipieToDelete = Recipies.Where(arr => arr[0].Equals(RecipieKey)).FirstOrDefault();
                Recipies.Remove(recipieToDelete);

                recipeBook.AllRecipies = Recipies;

                recipeBook.SaveRecipieData();

                LoadCsvData(recipeBook.RecipieFile);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                richTextBox1.Clear();
                richTextBox2.Clear();
            }
            catch (Exception ex)
            {
                recipeBook.LogErrorToFile(ex.Message);
            }
        }
        //**********************************DATA GRID VIEW*****************************************************
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            if (indexRow >= 0 && indexRow < dataGridView1.Rows.Count)
            {

                DataGridViewRow selectedRow = dataGridView1.Rows[indexRow];

                // Populate the text boxes with the data from the selected row
                textBox1.Text = selectedRow.Cells[0].Value.ToString(); // Assuming the first column is RecipeTitle
                textBox2.Text = selectedRow.Cells[1].Value.ToString();
                textBox3.Text = selectedRow.Cells[2].Value.ToString();
                textBox4.Text = selectedRow.Cells[3].Value.ToString(); // Assuming the second column is RecipeTime
                richTextBox1.Text = selectedRow.Cells[4].Value.ToString();
                richTextBox2.Text = selectedRow.Cells[5].Value.ToString();
                // Populate other text boxes with data as needed

                RecipieKey = textBox1.Text;
            }
            else
            {
                ClearTextBoxes();
            }
        }
        //***************************************METHODS******************************************************
        public List<string> ReadCsvFile(string recipeFile)
        {
            List<string> lines = new List<string>();

            try
            {
                using (StreamReader reader = new StreamReader(recipeFile))
                {
                    string line = string.Empty;
                    while (!reader.EndOfStream)
                    {
                        string currentLine = reader.ReadLine();

                        if (string.IsNullOrEmpty(line))
                        {
                            line = currentLine;
                        }
                        else
                        {
                            // Check if the line has an even number of double quotes
                            if (CountDoubleQuotes(line) % 2 == 1)
                            {
                                line += Environment.NewLine + currentLine;
                            }
                            else
                            {
                                lines.Add(line);
                                line = currentLine;
                            }
                        }
                    }

                    // Add the last line
                    if (!string.IsNullOrEmpty(line))
                    {
                        lines.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                recipeBook.LogErrorToFile(ex.Message);
            }

            return lines;
        }

        // Function to count double quotes in a string
        public int CountDoubleQuotes(string text)
        {
            return text.Split('"').Length - 1;
        }

        // Function to delete a line by its index
        public void DeleteRowFromCsv(int rowIndex, string recipeFile)
        {
            var recipieToModify = Recipies.Where(arr => arr[0].Equals(RecipieKey)).FirstOrDefault();
            Recipies.Remove(recipieToModify);
            recipeBook.AllRecipies = Recipies;
            recipeBook.SaveRecipieData();
        }

        public void UpdateCsvData(int rowIndex)
        {
            try
            {
                var recipieToModify = Recipies.Where(arr => arr[0].Equals(RecipieKey)).FirstOrDefault();
                if (recipieToModify != null)
                {
                    recipieToModify[0] = textBox1.Text;
                    recipieToModify[1] = textBox2.Text;
                    recipieToModify[2] = textBox3.Text;
                    recipieToModify[3] = textBox4.Text;
                    recipieToModify[4] = richTextBox1.Text;
                    recipieToModify[5] = richTextBox2.Text;

                    recipeBook.AllRecipies = Recipies;
                    recipeBook.SaveRecipieData();
                }
                else
                {
                    recipeBook.LogErrorToFile($"Recipe key '{RecipieKey}' could not be found in '{recipeBook.RecipieFile}'.");
                }
            }
            catch (Exception ex)
            {
                recipeBook.LogErrorToFile(ex.Message);
            }
        }




        // Function to display the filtered data in the DataGridView
        private void DisplayFilteredData(List<string[]> filteredData)
        {
            dataGridView1.Rows.Clear();

            foreach (string[] row in filteredData)
            {
                dataGridView1.Rows.Add(row);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();

        }
    }
}

