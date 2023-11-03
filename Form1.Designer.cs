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
            listBox1.ItemHeight = 37;
            listBox1.Location = new Point(26, 257);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1346, 448);
            listBox1.TabIndex = 0;
            listBox1.MouseDoubleClick += listBox1_MouseDoubleClick;
            // 
            // UserName
            // 
            UserName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            UserName.Location = new Point(105, 43);
            UserName.Name = "UserName";
            UserName.Size = new Size(307, 38);
            UserName.TabIndex = 1;
            // 
            // UserPassword
            // 
            UserPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            UserPassword.Location = new Point(447, 43);
            UserPassword.Name = "UserPassword";
            UserPassword.PasswordChar = '*';
            UserPassword.Size = new Size(307, 38);
            UserPassword.TabIndex = 2;
            // 
            // SignInBtn
            // 
            SignInBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            SignInBtn.Location = new Point(1139, 12);
            SignInBtn.Name = "SignInBtn";
            SignInBtn.Size = new Size(233, 125);
            SignInBtn.TabIndex = 3;
            SignInBtn.Text = "Log in";
            SignInBtn.UseVisualStyleBackColor = true;
            SignInBtn.Click += SignInBtn_Click;
            // 
            // Reg
            // 
            Reg.AutoSize = true;
            Reg.Location = new Point(159, 111);
            Reg.Name = "Reg";
            Reg.Size = new Size(0, 20);
            Reg.TabIndex = 4;
            // 
            // aboutUsOpen
            // 
            aboutUsOpen.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            aboutUsOpen.Location = new Point(1139, 143);
            aboutUsOpen.Name = "aboutUsOpen";
            aboutUsOpen.Size = new Size(233, 108);
            aboutUsOpen.TabIndex = 5;
            aboutUsOpen.Text = "About Us";
            aboutUsOpen.UseVisualStyleBackColor = true;
            aboutUsOpen.Click += aboutUsOpen_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(277, 176);
            searchTextBox.Margin = new Padding(3, 4, 3, 4);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(380, 27);
            searchTextBox.TabIndex = 6;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(678, 145);
            searchButton.Margin = new Padding(3, 4, 3, 4);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(167, 66);
            searchButton.TabIndex = 7;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1419, 767);
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
            Controls.Add(aboutUsOpen);
            Controls.Add(Reg);
            Controls.Add(SignInBtn);
            Controls.Add(UserPassword);
            Controls.Add(UserName);
            Controls.Add(listBox1);
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