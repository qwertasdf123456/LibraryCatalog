using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryCatalog
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridView1;
        private Button addBookButton;
        private Button removeBookButton;
        private ComboBox categoryFilterComboBox;
        private ComboBox statusFilterComboBox;
        private PictureBox bookPictureBox;
        private LinkLabel instructionsLinkLabel;
        private TextBox searchTextBox;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            addBookButton = new Button();
            removeBookButton = new Button();
            categoryFilterComboBox = new ComboBox();
            statusFilterComboBox = new ComboBox();
            bookPictureBox = new PictureBox();
            instructionsLinkLabel = new LinkLabel();
            searchTextBox = new TextBox();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookPictureBox).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.SandyBrown;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.SandyBrown;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(591, 307);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
            // 
            // addBookButton
            // 
            addBookButton.Location = new Point(12, 354);
            addBookButton.Name = "addBookButton";
            addBookButton.Size = new Size(75, 23);
            addBookButton.TabIndex = 1;
            addBookButton.Text = "Add Book";
            addBookButton.UseVisualStyleBackColor = true;
            addBookButton.Click += AddBookButton_Click;
            // 
            // removeBookButton
            // 
            removeBookButton.Location = new Point(93, 354);
            removeBookButton.Name = "removeBookButton";
            removeBookButton.Size = new Size(75, 23);
            removeBookButton.TabIndex = 2;
            removeBookButton.Text = "Remove Book";
            removeBookButton.UseVisualStyleBackColor = true;
            removeBookButton.Click += RemoveBookButton_Click;
            // 
            // categoryFilterComboBox
            // 
            categoryFilterComboBox.BackColor = Color.SandyBrown;
            categoryFilterComboBox.ForeColor = SystemColors.WindowText;
            categoryFilterComboBox.FormattingEnabled = true;
            categoryFilterComboBox.Items.AddRange(new object[] { "All Categories", "Fiction", "Non-Fiction", "Science", "Biography" });
            categoryFilterComboBox.Location = new Point(168, 9);
            categoryFilterComboBox.Name = "categoryFilterComboBox";
            categoryFilterComboBox.Size = new Size(121, 23);
            categoryFilterComboBox.TabIndex = 3;
            categoryFilterComboBox.Text = "All Categories";
            categoryFilterComboBox.SelectedIndexChanged += CategoryFilterComboBox_SelectedIndexChanged;
            // 
            // statusFilterComboBox
            // 
            statusFilterComboBox.BackColor = Color.SandyBrown;
            statusFilterComboBox.ForeColor = SystemColors.WindowText;
            statusFilterComboBox.FormattingEnabled = true;
            statusFilterComboBox.Items.AddRange(new object[] { "All Statuses", "Read", "Unread", "In Progress" });
            statusFilterComboBox.Location = new Point(295, 9);
            statusFilterComboBox.Name = "statusFilterComboBox";
            statusFilterComboBox.Size = new Size(121, 23);
            statusFilterComboBox.TabIndex = 4;
            statusFilterComboBox.Text = "All Statuses";
            statusFilterComboBox.SelectedIndexChanged += StatusFilterComboBox_SelectedIndexChanged;
            // 
            // bookPictureBox
            // 
            bookPictureBox.BackColor = Color.SandyBrown;
            bookPictureBox.Location = new Point(624, 41);
            bookPictureBox.Name = "bookPictureBox";
            bookPictureBox.Size = new Size(200, 307);
            bookPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            bookPictureBox.TabIndex = 5;
            bookPictureBox.TabStop = false;
            // 
            // instructionsLinkLabel
            // 
            instructionsLinkLabel.ActiveLinkColor = Color.OrangeRed;
            instructionsLinkLabel.AutoSize = true;
            instructionsLinkLabel.LinkColor = Color.SaddleBrown;
            instructionsLinkLabel.Location = new Point(677, 362);
            instructionsLinkLabel.Name = "instructionsLinkLabel";
            instructionsLinkLabel.Size = new Size(98, 15);
            instructionsLinkLabel.TabIndex = 6;
            instructionsLinkLabel.TabStop = true;
            instructionsLinkLabel.Text = "Read Instructions";
            instructionsLinkLabel.LinkClicked += InstructionsLinkLabel_LinkClicked;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(12, 9);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Search";
            searchTextBox.Size = new Size(150, 23);
            searchTextBox.TabIndex = 7;
            searchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.SaddleBrown;
            linkLabel1.Location = new Point(781, 362);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(43, 15);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Github";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            BackColor = Color.PeachPuff;
            ClientSize = new Size(842, 389);
            Controls.Add(linkLabel1);
            Controls.Add(bookPictureBox);
            Controls.Add(statusFilterComboBox);
            Controls.Add(categoryFilterComboBox);
            Controls.Add(removeBookButton);
            Controls.Add(addBookButton);
            Controls.Add(dataGridView1);
            Controls.Add(instructionsLinkLabel);
            Controls.Add(searchTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Library Catalog";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var dataGridView = sender as DataGridView;
                var row = dataGridView.Rows[e.RowIndex];

                // Set the background color for the selected row to match the color scheme
                if (row.Selected)
                {
                    e.CellStyle.BackColor = Color.SandyBrown;
                    e.CellStyle.ForeColor = SystemColors.WindowText;
                }
                else
                {
                    e.CellStyle.BackColor = dataGridView.DefaultCellStyle.BackColor;
                    e.CellStyle.ForeColor = dataGridView.DefaultCellStyle.ForeColor;
                }
            }
        }

        private LinkLabel linkLabel1;
    }
}
