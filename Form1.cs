using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;

namespace RecipeGenius
{
    public partial class Form1 : Form
    {


        RecipeBook recipeBook = new RecipeBook();
        private List<string[]> userDataList;

        private UserDataManager userDataManager;

        public Form1()
        {
            InitializeComponent();
            userDataManager = new UserDataManager();
            userDataList = recipeBook.LoadRecipiesData();
            PopulateListBox();
        }

        private void PopulateListBox()
        {
            // Clear any existing items in the ListBox.
            listBox1.Items.Clear();

            // Loop through the userDataList and add each element to the ListBox.
            if (userDataList.Count > 0)
            {
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
            else
            {
                Reg.Text = ($"An error occurred while loading data:");

            }
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            // Get the text entered in the "UserName" and "UserPassword" textboxes.
            string enteredUserName = UserName.Text;
            string enteredPassword = UserPassword.Text;



            if (userDataManager.CheckUserCredentials(enteredUserName, enteredPassword))
            {
                AdminNewForm adminNewForm = new AdminNewForm();
                adminNewForm.Show();
                this.Hide();
            }
            else
            {
                Reg.Text = "Incorrect username or password. Please try again.";
            }

        }

        private void aboutUsOpen_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.Show();
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.listBox1.SelectedItem != null)
            {
                RecipeShow recipeShow = new RecipeShow();

                recipeShow.PopulateRecipe(this.listBox1.SelectedItem.ToString());

                recipeShow.Show();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchRecipes searchRecipes = new SearchRecipes();

            searchRecipes.Search(searchTextBox.Text);

            Reg.Text = "";
            // Loop through the userDataList and add each element to the ListBox.
            if (searchRecipes.Items.Count() > 0)
            {
                listBox1.Items.Clear();
                foreach (string[] user in searchRecipes.Items)
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
            else if (searchTextBox.Text.Length == 0)
            {
                PopulateListBox();
            }
            else
            {
                Reg.Text = ($"We didn´t find a recipe with that title or category");
            }
            searchTextBox.Clear();
        }
    }
}