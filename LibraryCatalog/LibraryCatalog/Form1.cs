using Newtonsoft.Json;
using System.Diagnostics;

namespace LibraryCatalog
{
    public partial class Form1 : Form
    {
        private List<Book> books = new List<Book>();
        private string filePath = "books.json";

        public Form1()
        {
            InitializeComponent();
            LoadData();
            SetupDataGridView();

            if (books.Count > 0)
            {
                dataGridView1.DataSource = books;
            }
            else
            {
                dataGridView1.DataSource = new List<Book>();
            }
        }

        private void SetupDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;

            // Title
            DataGridViewTextBoxColumn titleColumn = new DataGridViewTextBoxColumn();
            titleColumn.ReadOnly = true;
            titleColumn.DataPropertyName = "Title";
            titleColumn.HeaderText = "Title";
            titleColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(titleColumn);

            // Author
            DataGridViewTextBoxColumn authorColumn = new DataGridViewTextBoxColumn();
            authorColumn.DataPropertyName = "Author";
            authorColumn.HeaderText = "Author";
            authorColumn.ReadOnly = true;
            authorColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(authorColumn);

            // Category
            DataGridViewTextBoxColumn categoryColumn = new DataGridViewTextBoxColumn();
            categoryColumn.DataPropertyName = "Category";
            categoryColumn.HeaderText = "Category";
            categoryColumn.ReadOnly = true;
            categoryColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(categoryColumn);

            // Combobox status 
            DataGridViewComboBoxColumn statusColumn = new DataGridViewComboBoxColumn();
            statusColumn.DataPropertyName = "Status";
            statusColumn.HeaderText = "Status";
            statusColumn.Items.AddRange("Read", "Unread", "In Progress");
            statusColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(statusColumn);

            // ImagePath
            DataGridViewTextBoxColumn imagePathColumn = new DataGridViewTextBoxColumn();
            imagePathColumn.DataPropertyName = "ImagePath";
            imagePathColumn.HeaderText = "Image Path";
            imagePathColumn.ReadOnly = true;
            imagePathColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(imagePathColumn);

            // autosave status
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;

            // display picture
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void LoadData()
        {
            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                try { books = JsonConvert.DeserializeObject<List<Book>>(jsonData)!; }
                catch
                {
                    MessageBox.Show("Data was corrupted. Program will autogenerate blank json file", "Data loss", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    File.Delete(filePath);
                    books = new List<Book>();
                    SaveData();
                }
            }
            else
            {
                books = new List<Book>();
                SaveData();
            }
        }

        private void SaveData()
        {
            string jsonData = JsonConvert.SerializeObject(books, Formatting.Indented);
            File.WriteAllText(filePath, jsonData);
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            var addBookForm = new AddBookForm(this);
            addBookForm.ShowDialog();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            SaveData();
            RefreshDataGridView();
        }

        private void RemoveBookButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var book = dataGridView1.SelectedRows[0].DataBoundItem as Book;
                books.Remove(book!);
                SaveData();
                RefreshDataGridView();
                ClearBookPictureBox(); // Очищаем изображение после удаления книги
            }
        }

        private void RefreshDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = books;
        }

        private void ClearBookPictureBox()
        {
            bookPictureBox.Image = null;
        }

        private void CategoryFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterBooks();
        }

        private void StatusFilterComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            FilterBooks();
        }

        private void DataGridView1_SelectionChanged(object? sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var book = dataGridView1.SelectedRows[0].DataBoundItem as Book;
                if (book != null && File.Exists(book.ImagePath))
                {
                    bookPictureBox.Image = Image.FromFile(book.ImagePath);
                }
                else
                {
                    ClearBookPictureBox(); // Очищаем изображение, если его нет или путь недействителен
                }
            }
            else
            {
                ClearBookPictureBox(); // Очищаем изображение, если ничего не выбрано
            }
        }

        private void FilterBooks()
        {
            var filteredBooks = books;

            if (categoryFilterComboBox.Text != "All Categories" && !string.IsNullOrEmpty(categoryFilterComboBox.Text))
            {
                filteredBooks = filteredBooks.Where(b => b.Category == categoryFilterComboBox.Text).ToList();
            }

            if (statusFilterComboBox.Text != "All Statuses" && !string.IsNullOrEmpty(statusFilterComboBox.Text))
            {
                filteredBooks = filteredBooks.Where(b => b.Status == statusFilterComboBox.Text).ToList();
            }

            if (!string.IsNullOrEmpty(searchTextBox.Text))
            {
                filteredBooks = filteredBooks.Where(b => b.Title != null && b.Title.IndexOf(searchTextBox.Text, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filteredBooks;
        }

        private void InstructionsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InstructionForm instructionForm = new InstructionForm();
            instructionForm.ShowDialog();
        }

        private void DataGridView1_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count && e.ColumnIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] != null)
            {
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (cell.OwningColumn.DataPropertyName == "Status")
                {
                    // Обновляем статус книги в списке
                    var book = dataGridView1.Rows[e.RowIndex].DataBoundItem as Book;
                    if (book != null)
                    {
                        book.Status = cell.Value.ToString();
                        SaveData();
                    }
                }
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterBooks();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/qwertasdf123456/LibraryCatalog",
                UseShellExecute = true
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class Book
    {
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Category { get; set; }
        public string? Status { get; set; }
        public string? ImagePath { get; set; }
    }
}
