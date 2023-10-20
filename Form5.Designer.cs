namespace RecipeGenius
{
    partial class Form5
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label7 = new Label();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 32);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 0;
            label1.Text = "RecipeTittle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(697, 32);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 1;
            label2.Text = "NoOf Servings";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 135);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 2;
            label3.Text = "RecipeTime";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 483);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 3;
            label4.Text = "Ingredients";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(847, 483);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 4;
            label5.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1064, 35);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 5;
            label6.Text = "Image";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(215, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(378, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(215, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(378, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(830, 28);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(710, 128);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 9;
            label7.Text = "Category";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(847, 536);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(468, 120);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(74, 536);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(519, 120);
            richTextBox2.TabIndex = 11;
            richTextBox2.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1180, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 131);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Meat", "Fish", "Soup", "Salad", "Dessert" });
            comboBox1.Location = new Point(830, 132);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 28);
            comboBox1.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(420, 315);
            button1.Name = "button1";
            button1.Size = new Size(155, 71);
            button1.TabIndex = 14;
            button1.Text = "Add Recipe";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(777, 305);
            button2.Name = "button2";
            button2.Size = new Size(131, 71);
            button2.TabIndex = 15;
            button2.Text = "Update Recipe";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 718);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label7;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
    }
}