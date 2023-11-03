namespace RecipeGenius
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            UserName = new TextBox();
            UserPassword = new TextBox();
            SignInBtn = new Button();
            Reg = new Label();
            aboutUsOpen = new Button();
            searchTextBox = new TextBox();
            searchButton = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 72;
            listBox1.Location = new Point(55, 527);
            listBox1.Margin = new Padding(6, 6, 6, 6);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(2856, 868);
            listBox1.TabIndex = 0;
            listBox1.MouseDoubleClick += listBox1_MouseDoubleClick;
            // 
            // UserName
            // 
            UserName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            UserName.Location = new Point(223, 88);
            UserName.Margin = new Padding(6, 6, 6, 6);
            UserName.Name = "UserName";
            UserName.PlaceholderText = "Enter Username";
            UserName.Size = new Size(648, 69);
            UserName.TabIndex = 1;
            // 
            // UserPassword
            // 
            UserPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            UserPassword.Location = new Point(950, 88);
            UserPassword.Margin = new Padding(6, 6, 6, 6);
            UserPassword.Name = "UserPassword";
            UserPassword.PasswordChar = '*';
            UserPassword.PlaceholderText = "Enter Password";
            UserPassword.Size = new Size(648, 69);
            UserPassword.TabIndex = 2;
            // 
            // SignInBtn
            // 
            SignInBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            SignInBtn.Location = new Point(2420, 25);
            SignInBtn.Margin = new Padding(6, 6, 6, 6);
            SignInBtn.Name = "SignInBtn";
            SignInBtn.Size = new Size(495, 256);
            SignInBtn.TabIndex = 3;
            SignInBtn.Text = "Log in";
            SignInBtn.UseVisualStyleBackColor = true;
            SignInBtn.Click += SignInBtn_Click;
            // 
            // Reg
            // 
            Reg.AutoSize = true;
            Reg.Location = new Point(338, 228);
            Reg.Margin = new Padding(6, 0, 6, 0);
            Reg.Name = "Reg";
            Reg.Size = new Size(0, 41);
            Reg.TabIndex = 4;
            // 
            // aboutUsOpen
            // 
            aboutUsOpen.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            aboutUsOpen.Location = new Point(2420, 293);
            aboutUsOpen.Margin = new Padding(6, 6, 6, 6);
            aboutUsOpen.Name = "aboutUsOpen";
            aboutUsOpen.Size = new Size(495, 221);
            aboutUsOpen.TabIndex = 5;
            aboutUsOpen.Text = "About Us";
            aboutUsOpen.UseVisualStyleBackColor = true;
            aboutUsOpen.Click += aboutUsOpen_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(589, 361);
            searchTextBox.Margin = new Padding(6, 8, 6, 8);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(803, 47);
            searchTextBox.TabIndex = 6;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(1441, 297);
            searchButton.Margin = new Padding(6, 8, 6, 8);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(355, 135);
            searchButton.TabIndex = 7;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(3015, 1572);
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
            Controls.Add(aboutUsOpen);
            Controls.Add(Reg);
            Controls.Add(SignInBtn);
            Controls.Add(UserPassword);
            Controls.Add(UserName);
            Controls.Add(listBox1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox UserName;
        private TextBox UserPassword;
        private Button SignInBtn;
        private Label Reg;
        private Button aboutUsOpen;
        private TextBox searchTextBox;
        private Button searchButton;
    }
}