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
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 37;
            listBox1.Location = new Point(92, 168);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(828, 411);
            listBox1.TabIndex = 0;
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
            UserPassword.Location = new Point(446, 43);
            UserPassword.Name = "UserPassword";
            UserPassword.PasswordChar = '*';
            UserPassword.Size = new Size(307, 38);
            UserPassword.TabIndex = 2;
            // 
            // SignInBtn
            // 
            SignInBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            SignInBtn.Location = new Point(833, 43);
            SignInBtn.Name = "SignInBtn";
            SignInBtn.Size = new Size(113, 39);
            SignInBtn.TabIndex = 3;
            SignInBtn.Text = "Log in";
            SignInBtn.UseVisualStyleBackColor = true;
            SignInBtn.Click += SignInBtn_Click;
            // 
            // Reg
            // 
            Reg.AutoSize = true;
            Reg.Location = new Point(158, 111);
            Reg.Name = "Reg";
            Reg.Size = new Size(0, 20);
            Reg.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1041, 616);
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
    }
}