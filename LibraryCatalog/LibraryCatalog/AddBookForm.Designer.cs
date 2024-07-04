namespace LibraryCatalog
{
    partial class AddBookForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.TextBox imagePathTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button browseImageButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            titleTextBox = new TextBox();
            authorTextBox = new TextBox();
            categoryComboBox = new ComboBox();
            statusComboBox = new ComboBox();
            imagePathTextBox = new TextBox();
            saveButton = new Button();
            browseImageButton = new Button();
            SuspendLayout();
            // 
            // titleTextBox
            // 
            titleTextBox.BackColor = Color.SandyBrown;
            titleTextBox.Location = new Point(12, 12);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.PlaceholderText = "Title (*)";
            titleTextBox.Size = new Size(260, 23);
            titleTextBox.TabIndex = 0;
            // 
            // authorTextBox
            // 
            authorTextBox.BackColor = Color.SandyBrown;
            authorTextBox.Location = new Point(12, 38);
            authorTextBox.Name = "authorTextBox";
            authorTextBox.PlaceholderText = "Author (*)";
            authorTextBox.Size = new Size(260, 23);
            authorTextBox.TabIndex = 1;
            // 
            // categoryComboBox
            // 
            categoryComboBox.BackColor = Color.SandyBrown;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Items.AddRange(new object[] { "Fiction", "Non-Fiction", "Science", "Biography" });
            categoryComboBox.Location = new Point(12, 64);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(260, 23);
            categoryComboBox.TabIndex = 2;
            categoryComboBox.Text = "Category (*)";
            // 
            // statusComboBox
            // 
            statusComboBox.BackColor = Color.SandyBrown;
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Items.AddRange(new object[] { "Read", "Unread", "In Progress" });
            statusComboBox.Location = new Point(12, 91);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(260, 23);
            statusComboBox.TabIndex = 3;
            statusComboBox.Text = "Status";
            // 
            // imagePathTextBox
            // 
            imagePathTextBox.BackColor = Color.SandyBrown;
            imagePathTextBox.Location = new Point(12, 118);
            imagePathTextBox.Name = "imagePathTextBox";
            imagePathTextBox.PlaceholderText = "Image Path";
            imagePathTextBox.Size = new Size(179, 23);
            imagePathTextBox.TabIndex = 4;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(197, 144);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 6;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveButton_Click;
            // 
            // browseImageButton
            // 
            browseImageButton.Location = new Point(197, 117);
            browseImageButton.Name = "browseImageButton";
            browseImageButton.Size = new Size(75, 23);
            browseImageButton.TabIndex = 5;
            browseImageButton.Text = "Browse...";
            browseImageButton.UseVisualStyleBackColor = true;
            browseImageButton.Click += BrowseImageButton_Click;
            // 
            // AddBookForm
            // 
            BackColor = Color.PeachPuff;
            ClientSize = new Size(284, 179);
            Controls.Add(saveButton);
            Controls.Add(browseImageButton);
            Controls.Add(imagePathTextBox);
            Controls.Add(statusComboBox);
            Controls.Add(categoryComboBox);
            Controls.Add(authorTextBox);
            Controls.Add(titleTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AddBookForm";
            Text = "Add Book";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
