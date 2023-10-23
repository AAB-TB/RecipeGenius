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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
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
            button1 = new Button();
            button2 = new Button();
            textBox4 = new TextBox();
            button3 = new Button();
            RecipeListImage = new ImageList(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(57, 32);
            label1.Name = "label1";
            label1.Size = new Size(126, 28);
            label1.TabIndex = 0;
            label1.Text = "RecipeTittle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(697, 32);
            label2.Name = "label2";
            label2.Size = new Size(150, 28);
            label2.TabIndex = 1;
            label2.Text = "NoOf Servings";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(57, 135);
            label3.Name = "label3";
            label3.Size = new Size(122, 28);
            label3.TabIndex = 2;
            label3.Text = "RecipeTime";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(60, 240);
            label4.Name = "label4";
            label4.Size = new Size(119, 28);
            label4.TabIndex = 3;
            label4.Text = "Ingredients";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(57, 490);
            label5.Name = "label5";
            label5.Size = new Size(121, 28);
            label5.TabIndex = 4;
            label5.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(1064, 35);
            label6.Name = "label6";
            label6.Size = new Size(0, 28);
            label6.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(215, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(378, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(215, 139);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(378, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(853, 36);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(710, 128);
            label7.Name = "label7";
            label7.Size = new Size(98, 28);
            label7.TabIndex = 9;
            label7.Text = "Category";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(57, 322);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(519, 120);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(57, 535);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(519, 120);
            richTextBox2.TabIndex = 11;
            richTextBox2.Text = "";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(710, 336);
            button1.Name = "button1";
            button1.Size = new Size(155, 71);
            button1.TabIndex = 14;
            button1.Text = "Add Recipe";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(942, 336);
            button2.Name = "button2";
            button2.Size = new Size(178, 71);
            button2.TabIndex = 15;
            button2.Text = "Update Recipe";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(853, 128);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 16;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(1238, 336);
            button3.Name = "button3";
            button3.Size = new Size(148, 71);
            button3.TabIndex = 17;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // RecipeListImage
            // 
            RecipeListImage.ColorDepth = ColorDepth.Depth8Bit;
            RecipeListImage.ImageStream = (ImageListStreamer)resources.GetObject("RecipeListImage.ImageStream");
            RecipeListImage.TransparentColor = Color.Transparent;
            RecipeListImage.Images.SetKeyName(0, "apelsindessert.jpg");
            RecipeListImage.Images.SetKeyName(1, "bananquesedilla_med_nutella_och_hackade_jordnotter.jpg");
            RecipeListImage.Images.SetKeyName(2, "crème_brûlée.jpg");
            RecipeListImage.Images.SetKeyName(3, "falafelsallad.jpg");
            RecipeListImage.Images.SetKeyName(4, "Fisk.Laxiugn.jpg");
            RecipeListImage.Images.SetKeyName(5, "Fisk.PaneradFisk.jpg");
            RecipeListImage.Images.SetKeyName(6, "Fisk.Torskiugn.jpg");
            RecipeListImage.Images.SetKeyName(7, "glassborg.jpg");
            RecipeListImage.Images.SetKeyName(8, "Kött.Biffstroganoff.jpg");
            RecipeListImage.Images.SetKeyName(9, "Kött.Köttbullar.jpg");
            RecipeListImage.Images.SetKeyName(10, "Kött.KöttoBea.jpg");
            RecipeListImage.Images.SetKeyName(11, "Kött.Lamstek.jpg");
            RecipeListImage.Images.SetKeyName(12, "Kött.Renskav.jpg");
            RecipeListImage.Images.SetKeyName(13, "krabbsallad_(salada_de_carangue).jpg");
            RecipeListImage.Images.SetKeyName(14, "omelett_med_salladslok_och_sesam.jpg");
            RecipeListImage.Images.SetKeyName(15, "pannacotta.jpg");
            RecipeListImage.Images.SetKeyName(16, "sotpotatissallad_”sweet_garage_potato_salad”.jpg");
            RecipeListImage.Images.SetKeyName(17, "spansk_potatissallad.jpg");
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Olive;
            ClientSize = new Size(1478, 718);
            Controls.Add(button3);
            Controls.Add(textBox4);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
        private TextBox textBox4;
        private Button button3;
        private ImageList RecipeListImage;
    }
}