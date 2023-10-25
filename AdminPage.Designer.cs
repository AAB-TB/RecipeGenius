namespace RecipeGenius
{
    partial class AdminPage
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
            searchButton = new Button();
            textBox1 = new TextBox();
            addButton = new Button();
            redigeraButton = new Button();
            raderaButton = new Button();
            aboutUsButton = new Button();
            dataGridView1 = new DataGridView();
            Title = new DataGridViewTextBoxColumn();
            category = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // searchButton
            // 
            searchButton.Font = new Font("Segoe Script", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            searchButton.Location = new Point(70, 65);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(94, 44);
            searchButton.TabIndex = 0;
            searchButton.Text = "Sök";
            searchButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe Script", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(170, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(783, 44);
            textBox1.TabIndex = 1;
            // 
            // addButton
            // 
            addButton.Font = new Font("Segoe Script", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            addButton.Location = new Point(959, 115);
            addButton.Name = "addButton";
            addButton.Size = new Size(171, 70);
            addButton.TabIndex = 3;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            // 
            // redigeraButton
            // 
            redigeraButton.Font = new Font("Segoe Script", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            redigeraButton.Location = new Point(959, 191);
            redigeraButton.Name = "redigeraButton";
            redigeraButton.Size = new Size(171, 70);
            redigeraButton.TabIndex = 4;
            redigeraButton.Text = "Redigera";
            redigeraButton.UseVisualStyleBackColor = true;
            // 
            // raderaButton
            // 
            raderaButton.Font = new Font("Segoe Script", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            raderaButton.Location = new Point(959, 267);
            raderaButton.Name = "raderaButton";
            raderaButton.Size = new Size(171, 70);
            raderaButton.TabIndex = 5;
            raderaButton.Text = "Radera";
            raderaButton.UseVisualStyleBackColor = true;
            // 
            // aboutUsButton
            // 
            aboutUsButton.Font = new Font("Segoe Script", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            aboutUsButton.Location = new Point(959, 432);
            aboutUsButton.Name = "aboutUsButton";
            aboutUsButton.Size = new Size(171, 70);
            aboutUsButton.TabIndex = 6;
            aboutUsButton.Text = "About Us";
            aboutUsButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Title, category });
            dataGridView1.Location = new Point(70, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(883, 387);
            dataGridView1.TabIndex = 7;
            // 
            // Title
            // 
            Title.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Title.HeaderText = "Title";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            // 
            // category
            // 
            category.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            category.HeaderText = "Category";
            category.MinimumWidth = 6;
            category.Name = "category";
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 576);
            Controls.Add(dataGridView1);
            Controls.Add(aboutUsButton);
            Controls.Add(raderaButton);
            Controls.Add(redigeraButton);
            Controls.Add(addButton);
            Controls.Add(textBox1);
            Controls.Add(searchButton);
            Name = "AdminPage";
            Text = "AdminPage";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button searchButton;
        private TextBox textBox1;
        private Button addButton;
        private Button redigeraButton;
        private Button raderaButton;
        private Button aboutUsButton;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn category;
    }
}