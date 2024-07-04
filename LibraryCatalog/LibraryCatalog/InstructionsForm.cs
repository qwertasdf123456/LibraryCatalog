namespace LibraryCatalog
{
    public partial class InstructionForm : Form
    {
        public InstructionForm()
        {
            InitializeComponent();
            InitializeInstructionsText();
        }

        private void InitializeInstructionsText()
        {
            instructionsRichTextBox.Text = @"Instructions for using the application:

1. Adding a book:
   - Click the 'Add Book' button.
   - Enter the book details in the respective fields.
   - Select the book's category and status.
   - Click 'Save' to save the changes.

2. Removing a book:
   - Select the book in the table.
   - Click the 'Remove Book' button to delete the book from the catalog.

3. Filtering books:
   - Use the 'Category' and 'Status' dropdown lists to filter books by category and status.

Note: The book status is automatically saved when selected from the dropdown list in the table.

Enjoy using the application!
";
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
