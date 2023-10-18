namespace RecipeGenius
{
    partial class AboutUs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUs));
            label1 = new Label();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Heavy", 20.1F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 37);
            label1.Name = "label1";
            label1.Size = new Size(725, 85);
            label1.TabIndex = 0;
            label1.Text = "International Food AB";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Heavy", 20.1F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(35, 168);
            label2.Name = "label2";
            label2.Size = new Size(315, 85);
            label2.TabIndex = 1;
            label2.Text = "About us";
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.BackColor = Color.Olive;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox1.Location = new Point(35, 313);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1362, 542);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom;
            textBox1.BackColor = Color.Olive;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 8.1F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(35, 923);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1362, 36);
            textBox1.TabIndex = 3;
            textBox1.Text = "This application was build by Lucas, Mona, Henrik, Alamgir, Meenaksi and Khalid.\r\n";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // AboutUs
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Olive;
            ClientSize = new Size(1460, 1005);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AboutUs";
            Text = "AboutUs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
    }
}