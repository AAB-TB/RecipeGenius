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
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 45;
            listBox1.Location = new Point(115, 210);
            listBox1.Margin = new Padding(4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(978, 499);
            listBox1.TabIndex = 0;
            // 
            // UserName
            // 
            UserName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            UserName.Location = new Point(131, 54);
            UserName.Margin = new Padding(4);
            UserName.Name = "UserName";
            UserName.Size = new Size(383, 44);
            UserName.TabIndex = 1;
            // 
            // UserPassword
            // 
            UserPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            UserPassword.Location = new Point(558, 54);
            UserPassword.Margin = new Padding(4);
            UserPassword.Name = "UserPassword";
            UserPassword.PasswordChar = '*';
            UserPassword.Size = new Size(383, 44);
            UserPassword.TabIndex = 2;
            // 
            // SignInBtn
            // 
            SignInBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            SignInBtn.Location = new Point(1041, 54);
            SignInBtn.Margin = new Padding(4);
            SignInBtn.Name = "SignInBtn";
            SignInBtn.Size = new Size(141, 49);
            SignInBtn.TabIndex = 3;
            SignInBtn.Text = "Log in";
            SignInBtn.UseVisualStyleBackColor = true;
            SignInBtn.Click += SignInBtn_Click;
            // 
            // Reg
            // 
            Reg.AutoSize = true;
            Reg.Location = new Point(198, 139);
            Reg.Margin = new Padding(4, 0, 4, 0);
            Reg.Name = "Reg";
            Reg.Size = new Size(0, 25);
            Reg.TabIndex = 4;
            // 
            // aboutUsOpen
            // 
            aboutUsOpen.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            aboutUsOpen.Location = new Point(1120, 210);
            aboutUsOpen.Margin = new Padding(4);
            aboutUsOpen.Name = "aboutUsOpen";
            aboutUsOpen.Size = new Size(141, 49);
            aboutUsOpen.TabIndex = 5;
            aboutUsOpen.Text = "About Us";
            aboutUsOpen.UseVisualStyleBackColor = true;
            aboutUsOpen.Click += aboutUsOpen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1301, 770);
            Controls.Add(aboutUsOpen);
            Controls.Add(Reg);
            Controls.Add(SignInBtn);
            Controls.Add(UserPassword);
            Controls.Add(UserName);
            Controls.Add(listBox1);
            Margin = new Padding(4);
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
    }
}