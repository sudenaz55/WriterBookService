using System;
using System.Linq;
using System.Windows.Forms;
using WriterBookService.Data;
using WriterBookService.Models;
using System.Data.Entity;

namespace WriterBookService.Forms
{
    public partial class MainForm : Form
    {
        private readonly WriterDbContext _context;
        private int? selectedWriterId = null;
        private int? selectedBookId = null;
        private int? selectedWriterBookId = null;

        public MainForm()
        {
            InitializeComponent();
            _context = new WriterDbContext();
            btnAddWriter.Click += btnAddWriter_Click;
            btnEditWriter.Click += btnEditWriter_Click;
            btnDeleteWriter.Click += btnDeleteWriter_Click;
            dgvWriters.SelectionChanged += dgvWriters_SelectionChanged;
            btnSearchWriter.Click += btnSearchWriter_Click;

            btnAddBook.Click += btnAddBook_Click;
            btnEditBook.Click += btnEditBook_Click;
            btnDeleteBook.Click += btnDeleteBook_Click;
            dgvBooks.SelectionChanged += dgvBooks_SelectionChanged;
            btnSearchBook.Click += btnSearchBook_Click;

            btnAssignWriterToBook.Click += btnAssignWriterToBook_Click;
            btnDeleteWriterBook.Click += btnDeleteWriterBook_Click;
            dgvWriterBooks.SelectionChanged += dgvWriterBooks_SelectionChanged;
            btnSearchWriterBook.Click += btnSearchWriterBook_Click;

            LoadData();
        }

        private void LoadData()
        {
            dgvWriters.DataSource = _context.Writers.ToList();
            dgvWriters.ClearSelection();

            dgvBooks.DataSource = _context.Books.ToList();
            dgvBooks.ClearSelection();

            cmbWriters.DataSource = _context.Writers.ToList();
            cmbWriters.DisplayMember = "FirstName";
            cmbWriters.ValueMember = "WriterId";

            cmbBooks.DataSource = _context.Books.ToList();
            cmbBooks.DisplayMember = "Title";
            cmbBooks.ValueMember = "BookId";

            dgvWriterBooks.DataSource = _context.WriterBooks
                .Include(wb => wb.Writer)
                .Include(wb => wb.Book)
                .Select(wb => new
                {
                    wb.WriterBookId,
                    Writer = wb.Writer.FirstName + " " + wb.Writer.LastName,
                    Book = wb.Book.Title
                })
                .ToList();
            dgvWriterBooks.ClearSelection();

            txtWriterFirstName.Text = txtWriterLastName.Text = txtWriterEmail.Text = string.Empty;
            dtpWriterBirthDate.Value = DateTime.Now;
            txtBookTitle.Text = txtBookISBN.Text = txtBookPrice.Text = string.Empty;
            dtpBookPublicationDate.Value = DateTime.Now;
            selectedWriterId = null;
            selectedBookId = null;
            selectedWriterBookId = null;
        }

        private void btnAddWriter_Click(object sender, EventArgs e)
        {
            var writer = new Writer
            {
                FirstName = txtWriterFirstName.Text,
                LastName = txtWriterLastName.Text,
                Email = txtWriterEmail.Text,
                BirthDate = dtpWriterBirthDate.Value
            };
            _context.Writers.Add(writer);
            _context.SaveChanges();
            LoadData();
        }
        private void btnEditWriter_Click(object sender, EventArgs e)
        {
            if (selectedWriterId == null) return;
            var writer = _context.Writers.Find(selectedWriterId);
            if (writer == null) return;
            writer.FirstName = txtWriterFirstName.Text;
            writer.LastName = txtWriterLastName.Text;
            writer.Email = txtWriterEmail.Text;
            writer.BirthDate = dtpWriterBirthDate.Value;
            _context.SaveChanges();
            LoadData();
        }
        private void btnDeleteWriter_Click(object sender, EventArgs e)
        {
            if (selectedWriterId == null) return;
            var writer = _context.Writers.Find(selectedWriterId);
            if (writer == null) return;
            _context.Writers.Remove(writer);
            _context.SaveChanges();
            LoadData();
        }
        private void dgvWriters_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvWriters.SelectedRows.Count > 0)
            {
                var row = dgvWriters.SelectedRows[0];
                selectedWriterId = Convert.ToInt32(row.Cells["WriterId"].Value);
                txtWriterFirstName.Text = row.Cells["FirstName"].Value.ToString();
                txtWriterLastName.Text = row.Cells["LastName"].Value.ToString();
                txtWriterEmail.Text = row.Cells["Email"].Value.ToString();
                dtpWriterBirthDate.Value = Convert.ToDateTime(row.Cells["BirthDate"].Value);
            }
            else
            {
                selectedWriterId = null;
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            var book = new Book
            {
                Title = txtBookTitle.Text,
                ISBN = txtBookISBN.Text,
                PublicationDate = dtpBookPublicationDate.Value,
                Price = decimal.TryParse(txtBookPrice.Text, out var price) ? price : 0
            };
            _context.Books.Add(book);
            _context.SaveChanges();
            LoadData();
        }
        private void btnEditBook_Click(object sender, EventArgs e)
        {
            if (selectedBookId == null) return;
            var book = _context.Books.Find(selectedBookId);
            if (book == null) return;
            book.Title = txtBookTitle.Text;
            book.ISBN = txtBookISBN.Text;
            book.PublicationDate = dtpBookPublicationDate.Value;
            book.Price = decimal.TryParse(txtBookPrice.Text, out var price) ? price : 0;
            _context.SaveChanges();
            LoadData();
        }
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (selectedBookId == null) return;
            var book = _context.Books.Find(selectedBookId);
            if (book == null) return;
            _context.Books.Remove(book);
            _context.SaveChanges();
            LoadData();
        }
        private void dgvBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0)
            {
                var row = dgvBooks.SelectedRows[0];
                selectedBookId = Convert.ToInt32(row.Cells["BookId"].Value);
                txtBookTitle.Text = row.Cells["Title"].Value.ToString();
                txtBookISBN.Text = row.Cells["ISBN"].Value.ToString();
                dtpBookPublicationDate.Value = Convert.ToDateTime(row.Cells["PublicationDate"].Value);
                txtBookPrice.Text = row.Cells["Price"].Value.ToString();
            }
            else
            {
                selectedBookId = null;
            }
        }

        private void btnAssignWriterToBook_Click(object sender, EventArgs e)
        {
            var writerId = Convert.ToInt32(cmbWriters.SelectedValue);
            var bookId = Convert.ToInt32(cmbBooks.SelectedValue);
            var writerBook = new WriterBook
            {
                WriterId = writerId,
                BookId = bookId
            };
            _context.WriterBooks.Add(writerBook);
            _context.SaveChanges();
            LoadData();
        }
        private void btnDeleteWriterBook_Click(object sender, EventArgs e)
        {
            if (selectedWriterBookId == null) return;
            var writerBook = _context.WriterBooks.Find(selectedWriterBookId);
            if (writerBook == null) return;
            _context.WriterBooks.Remove(writerBook);
            _context.SaveChanges();
            LoadData();
        }
        private void dgvWriterBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvWriterBooks.SelectedRows.Count > 0)
            {
                var row = dgvWriterBooks.SelectedRows[0];
                selectedWriterBookId = Convert.ToInt32(row.Cells["WriterBookId"].Value);
            }
            else
            {
                selectedWriterBookId = null;
            }
        }

        private void btnSearchWriter_Click(object sender, EventArgs e)
        {
            var searchText = txtSearchWriter.Text.ToLower();
            var writers = _context.Writers
                .Where(w => w.FirstName.ToLower().Contains(searchText) ||
                           w.LastName.ToLower().Contains(searchText) ||
                           w.Email.ToLower().Contains(searchText))
                .ToList();
            dgvWriters.DataSource = writers;
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            var searchText = txtSearchBook.Text.ToLower();
            var books = _context.Books
                .Where(b => b.Title.ToLower().Contains(searchText) ||
                           b.ISBN.ToLower().Contains(searchText))
                .ToList();
            dgvBooks.DataSource = books;
        }

        private void btnSearchWriterBook_Click(object sender, EventArgs e)
        {
            var searchText = txtSearchWriterBook.Text.ToLower();
            var writerBooks = _context.WriterBooks
                .Include(wb => wb.Writer)
                .Include(wb => wb.Book)
                .Where(wb => (wb.Writer.FirstName + " " + wb.Writer.LastName).ToLower().Contains(searchText) ||
                            wb.Book.Title.ToLower().Contains(searchText))
                .Select(wb => new
                {
                    wb.WriterBookId,
                    Writer = wb.Writer.FirstName + " " + wb.Writer.LastName,
                    Book = wb.Book.Title
                })
                .ToList();
            dgvWriterBooks.DataSource = writerBooks;
        }
    }
}