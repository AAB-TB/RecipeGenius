namespace RecipeGenius
{
    partial class RecipeShow
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
            groupBox1 = new GroupBox();
            richTextBox2 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            TitelLabel = new Label();
            label1 = new Label();
            CookingTimeLabel = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.Wheat;
            groupBox1.Controls.Add(richTextBox2);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(-4, 363);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1489, 682);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // richTextBox2
            // 
            richTextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            richTextBox2.Location = new Point(861, 105);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(606, 566);
            richTextBox2.TabIndex = 3;
            richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.Location = new Point(31, 105);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(814, 566);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 14.1F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(861, 40);
            label3.Name = "label3";
            label3.Size = new Size(270, 62);
            label3.TabIndex = 1;
            label3.Text = "Ingrediens";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 14.1F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(31, 40);
            label2.Name = "label2";
            label2.Size = new Size(303, 62);
            label2.TabIndex = 0;
            label2.Text = "Instructions";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Location = new Point(1050, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(413, 345);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // TitelLabel
            // 
            TitelLabel.Anchor = AnchorStyles.Top;
            TitelLabel.AutoSize = true;
            TitelLabel.Font = new Font("Microsoft YaHei UI", 20.1F, FontStyle.Bold, GraphicsUnit.Point);
            TitelLabel.Location = new Point(552, 39);
            TitelLabel.Name = "TitelLabel";
            TitelLabel.Size = new Size(187, 90);
            TitelLabel.TabIndex = 2;
            TitelLabel.Text = "Titel";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(27, 316);
            label1.Name = "label1";
            label1.Size = new Size(232, 41);
            label1.TabIndex = 3;
            label1.Text = "Cooking Time:";
            // 
            // CookingTimeLabel
            // 
            CookingTimeLabel.AutoSize = true;
            CookingTimeLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CookingTimeLabel.Location = new Point(303, 316);
            CookingTimeLabel.Name = "CookingTimeLabel";
            CookingTimeLabel.Size = new Size(120, 41);
            CookingTimeLabel.TabIndex = 4;
            CookingTimeLabel.Text = "45 min";
            // 
            // RecipeShow
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Olive;
            ClientSize = new Size(1485, 1046);
            Controls.Add(CookingTimeLabel);
            Controls.Add(label1);
            Controls.Add(TitelLabel);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Name = "RecipeShow";
            Text = "RecipeShow";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label TitelLabel;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label CookingTimeLabel;
    }
}