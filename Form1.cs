using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;

namespace RecipeGenius
{
    public partial class Form1 : Form
    {
        private List<string[]> userDataList;
        private List<string[]> displayedUserData;
        private List<int> searchResultsIndices;
        FilePaths filePaths = new FilePaths();
        public Form1()
        {
            InitializeComponent();
            userDataList = LoadUserData();
            PopulateListBox();
        }
        private List<string[]> LoadUserData()
        {
            string filePath = filePaths.RecipieList;
            List<string[]> data = new List<string[]>();

            try
            {
                // Use a StreamReader to read data from the specified file.
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;

                    // Read each line of the file.
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Split the line into parts using a comma as the delimiter.
                        string[] parts = line.Split(',');// creating an array name parts which will have six elements

                        // Check if the line has exactly 6 parts, which indicates a valid user record.
                        if (parts.Length == 6)
                        {
                            // Add the valid user data to the 'data' list.
                            data.Add(parts); // Adding arrays to the data list. 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Reg.Text = ($"An error occurred while loading data: {ex.Message}");
                filePaths.LogErrorToFile(ex.Message);

            }

            return data;
        }
        private void PopulateListBox()
        {
            // Clear any existing items in the ListBox.
            listBox1.Items.Clear();

            // Loop through the userDataList and add each element to the ListBox.
            foreach (string[] user in userDataList)
            {
                // Join the parts of the user array into a single string to display in the ListBox.
                string userString = string.Join(", ", user);

                if (user.Length > 0)
                {
                    // Add the first element of the user array to the ListBox.
                    listBox1.Items.Add(user[0]);
                }
            }
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            // Get the text entered in the "UserName" and "UserPassword" textboxes.
            string enteredUserName = UserName.Text;
            string enteredPassword = UserPassword.Text;

            // Check if either of the textboxes is empty.
            if (string.IsNullOrEmpty(enteredUserName) || string.IsNullOrEmpty(enteredPassword))
            {
                // Display an error message if either field is empty.
                Reg.Text = "Please enter both username and password.";
            }
            else
            {

                // Call the CheckCredentials method to verify the entered username and password.
                if (CheckCredentials(enteredUserName, enteredPassword))
                {
                    // If the credentials are correct, create a new instance of Form3 and show it.
                    AdminNewForm adminNewForm = new AdminNewForm();
                    adminNewForm.Show();
                    // Hide the current form (Form1).
                    this.Hide();
                }
                else
                {
                    // If the credentials are incorrect, display an error message in the "Reg" label.
                    Reg.Text = "Incorrect username or password. Please try again.";
                }
            }

        }
        private bool CheckCredentials(string enteredUserName, string enteredPassword)
        {
            // Specify the path to the file that stores the admin credentials.
            string filePath = @"C:\Jensen Azure programering\Fixaskiten\RecipeGenius\Admin.txt";

            try
            {
                // Use a StreamReader to read the file line by line.
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;

                    // Iterate through each line in the file.
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Split the line into parts based on the ',' delimiter.
                        string[] parts = line.Split(',');

                        // Check if the line has exactly 2 parts (username and password) and they match the entered credentials.
                        if (parts.Length == 2 && parts[0] == enteredUserName && parts[1] == enteredPassword)
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // If an error occurs while reading the file, display an error message in the "Reg" label.
                Reg.Text = ($"An error occurred: {ex.Message}");
                
                filePaths.LogErrorToFile(ex.Message);
            }
            // If no valid credentials are found or an error occurred, return false.
            return false;
        }
        

        
    }
}