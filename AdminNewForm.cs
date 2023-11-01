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
        string recipeFile = "C:\\Jensen Azure programering\\Fixaskiten\\RecipeGenius\\Recipelist.txt";

        public List<AddRecipe> recipeList = new List<AddRecipe>();
        AddRecipe addRecipe = new AddRecipe();
        public AdminNewForm()
        {
            InitializeComponent();
            LoadCsvData(recipeFile);

        }

        int indexRow;
        public void LoadCsvData(string recipeFile)
        {
            if (File.Exists(recipeFile))
            {
                dataGridView1.Rows.Clear();
                using (TextFieldParser parser = new TextFieldParser(recipeFile))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(","); // Assuming your CSV uses comma as a delimiter

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


        public void SaveRecipeToFile()
        {
            File.AppendAllLines(recipeFile, recipeList.Select(recipeList => recipeList.ToCsv()));
        }
        //**************************ADD BUTTON***********************************************************     
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

            // Search for and filter the data based on the specified column and search term.
            List<string> filteredData = SearchByColumnValue(searchTerm, columnToSearch);

            // Display the filtered data in the DataGridView.
            DisplayFilteredData(filteredData);

        }
        //*************************************UPDATE BUTTON*************************************************

        private void button4_Click(object sender, EventArgs e)
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
                MessageBox.Show("Updated");

                ClearTextBoxes();
            }


        }
        //***************************************DELETE BUTTON********************************************************
        private void button5_Click(object sender, EventArgs e)
        {
            indexRow = dataGridView1.CurrentCell.RowIndex;
            if (indexRow >= 0 && indexRow < dataGridView1.Rows.Count)
            {
                DeleteRowFromCsv(indexRow, recipeFile);

                dataGridView1.Rows.RemoveAt(indexRow);

                ClearTextBoxes();
                MessageBox.Show("Content deleted successfully.");

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

            return lines;
        }

        // Function to write a List<string> to a CSV file
        public void WriteCsvFile(string recipeFile, List<string> data)
        {
            using (StreamWriter writer = new StreamWriter(recipeFile))
            {
                foreach (var line in data)
                {
                    writer.WriteLine(line);
                }
            }
        }

        // Function to count double quotes in a string
        public int CountDoubleQuotes(string text)
        {
            return text.Split('"').Length - 1;
        }

        // Function to delete a line by its index
        public void DeleteRowFromCsv(int rowIndex, string recipeFile)
        {
            List<string> data = ReadCsvFile(recipeFile);

            if (rowIndex >= 0 && rowIndex < data.Count)
            {
                data.RemoveAt(rowIndex); // Remove the desired row
                WriteCsvFile(recipeFile, data); // Write the updated data back to the CSV file
            }
        }

        public void UpdateCsvData(int rowIndex)
        {
            List<string> data = ReadCsvFile(recipeFile);
            if (rowIndex >= 0 && rowIndex < data.Count)
            {
                List<string> updatedRow = new List<string>
                   {
                    textBox1.Text,
                    textBox2.Text,
                    textBox3.Text,
                    textBox4.Text,
                    '"' + richTextBox1.Text + '"',
                    '"' + richTextBox2.Text + '"'
                   };

                data[rowIndex] = string.Join(",", updatedRow);
            }
            File.WriteAllLines(recipeFile, data);
        }

        private List<string> SearchByColumnValue(string searchTerm, int columnToSearch)
        {
            List<string> data = ReadCsvFile(recipeFile);
            List<string> filteredData = new List<string>();

            foreach (string row in data)
            {
                string[] columns = row.Split(',');

                if (columns.Length > columnToSearch && columns[columnToSearch] == searchTerm)
                {
                    filteredData.Add(row);
                }
            }

            return filteredData;
        }

        // Function to display the filtered data in the DataGridView
        private void DisplayFilteredData(List<string> filteredData)
        {
            dataGridView1.Rows.Clear();

            foreach (string row in filteredData)
            {
                string[] columns = row.Split(',');
                dataGridView1.Rows.Add(columns);
            }
        }




    }
}

