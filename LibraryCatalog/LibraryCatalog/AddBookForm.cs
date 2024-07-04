namespace LibraryCatalog
{
    public partial class AddBookForm : Form
    {
        private Form1 mainForm;

        public AddBookForm(Form1 form)
        {
            InitializeComponent();
            mainForm = form;

            statusComboBox.SelectedIndex = 1; // Unread
        }

        private void BrowseImageButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePathTextBox.Text = openFileDialog.FileName;
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(titleTextBox.Text) ||
                string.IsNullOrWhiteSpace(authorTextBox.Text) ||
                categoryComboBox.SelectedIndex == -1 ||
                titleTextBox.Text.StartsWith(" ") || // Проверяем, что текст не начинается с пробела
                authorTextBox.Text.StartsWith(" ")) // Проверяем, что текст не начинается с пробела
            {
                MessageBox.Show("Please fill in all required fields (Title, Author, Category) correctly and ensure they do not start or consist only of spaces.", "Incomplete or Incorrect Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var book = new Book
            {
                Title = titleTextBox.Text,
                Author = authorTextBox.Text,
                Category = categoryComboBox.Text,
                Status = statusComboBox.Text,
                ImagePath = imagePathTextBox.Text
            };

            mainForm.AddBook(book);
            this.Close();
        }
    }
}