namespace WriterBookService.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

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
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.grpWriters = new System.Windows.Forms.GroupBox();
            this.dgvWriters = new System.Windows.Forms.DataGridView();
            this.txtWriterFirstName = new System.Windows.Forms.TextBox();
            this.txtWriterLastName = new System.Windows.Forms.TextBox();
            this.txtWriterEmail = new System.Windows.Forms.TextBox();
            this.dtpWriterBirthDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddWriter = new System.Windows.Forms.Button();
            this.btnEditWriter = new System.Windows.Forms.Button();
            this.btnDeleteWriter = new System.Windows.Forms.Button();
            this.lblWriterFirstName = new System.Windows.Forms.Label();
            this.lblWriterLastName = new System.Windows.Forms.Label();
            this.lblWriterEmail = new System.Windows.Forms.Label();
            this.lblWriterBirthDate = new System.Windows.Forms.Label();
            this.txtSearchWriter = new System.Windows.Forms.TextBox();
            this.btnSearchWriter = new System.Windows.Forms.Button();
            this.lblSearchWriter = new System.Windows.Forms.Label();
            this.grpBooks = new System.Windows.Forms.GroupBox();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.txtBookISBN = new System.Windows.Forms.TextBox();
            this.dtpBookPublicationDate = new System.Windows.Forms.DateTimePicker();
            this.txtBookPrice = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblBookISBN = new System.Windows.Forms.Label();
            this.lblBookPublicationDate = new System.Windows.Forms.Label();
            this.lblBookPrice = new System.Windows.Forms.Label();
            this.txtSearchBook = new System.Windows.Forms.TextBox();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.lblSearchBook = new System.Windows.Forms.Label();
            this.splitContainerBottom = new System.Windows.Forms.SplitContainer();
            this.grpWriterBook = new System.Windows.Forms.GroupBox();
            this.cmbWriters = new System.Windows.Forms.ComboBox();
            this.cmbBooks = new System.Windows.Forms.ComboBox();
            this.btnAssignWriterToBook = new System.Windows.Forms.Button();
            this.dgvWriterBooks = new System.Windows.Forms.DataGridView();
            this.btnDeleteWriterBook = new System.Windows.Forms.Button();
            this.lblAssignWriter = new System.Windows.Forms.Label();
            this.lblAssignBook = new System.Windows.Forms.Label();
            this.txtSearchWriterBook = new System.Windows.Forms.TextBox();
            this.btnSearchWriterBook = new System.Windows.Forms.Button();
            this.lblSearchWriterBook = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.grpWriters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWriters)).BeginInit();
            this.grpBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBottom)).BeginInit();
            this.splitContainerBottom.Panel1.SuspendLayout();
            this.splitContainerBottom.SuspendLayout();
            this.grpWriterBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWriterBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.grpWriters);
            this.splitContainerMain.Panel1.Controls.Add(this.grpBooks);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerBottom);
            this.splitContainerMain.Size = new System.Drawing.Size(832, 603);
            this.splitContainerMain.SplitterDistance = 428;
            this.splitContainerMain.TabIndex = 0;
            // 
            // grpWriters
            // 
            this.grpWriters.Controls.Add(this.dgvWriters);
            this.grpWriters.Controls.Add(this.txtWriterFirstName);
            this.grpWriters.Controls.Add(this.txtWriterLastName);
            this.grpWriters.Controls.Add(this.txtWriterEmail);
            this.grpWriters.Controls.Add(this.dtpWriterBirthDate);
            this.grpWriters.Controls.Add(this.btnAddWriter);
            this.grpWriters.Controls.Add(this.btnEditWriter);
            this.grpWriters.Controls.Add(this.btnDeleteWriter);
            this.grpWriters.Controls.Add(this.lblWriterFirstName);
            this.grpWriters.Controls.Add(this.lblWriterLastName);
            this.grpWriters.Controls.Add(this.lblWriterEmail);
            this.grpWriters.Controls.Add(this.lblWriterBirthDate);
            this.grpWriters.Controls.Add(this.txtSearchWriter);
            this.grpWriters.Controls.Add(this.btnSearchWriter);
            this.grpWriters.Controls.Add(this.lblSearchWriter);
            this.grpWriters.Location = new System.Drawing.Point(10, 10);
            this.grpWriters.Name = "grpWriters";
            this.grpWriters.Size = new System.Drawing.Size(400, 326);
            this.grpWriters.TabIndex = 0;
            this.grpWriters.TabStop = false;
            this.grpWriters.Text = "Yazarlar";
            // 
            // dgvWriters
            // 
            this.dgvWriters.ColumnHeadersHeight = 29;
            this.dgvWriters.Location = new System.Drawing.Point(10, 20);
            this.dgvWriters.Name = "dgvWriters";
            this.dgvWriters.RowHeadersWidth = 51;
            this.dgvWriters.Size = new System.Drawing.Size(380, 120);
            this.dgvWriters.TabIndex = 0;
            // 
            // txtWriterFirstName
            // 
            this.txtWriterFirstName.Location = new System.Drawing.Point(80, 150);
            this.txtWriterFirstName.Name = "txtWriterFirstName";
            this.txtWriterFirstName.Size = new System.Drawing.Size(120, 22);
            this.txtWriterFirstName.TabIndex = 1;
            // 
            // txtWriterLastName
            // 
            this.txtWriterLastName.Location = new System.Drawing.Point(270, 150);
            this.txtWriterLastName.Name = "txtWriterLastName";
            this.txtWriterLastName.Size = new System.Drawing.Size(120, 22);
            this.txtWriterLastName.TabIndex = 2;
            // 
            // txtWriterEmail
            // 
            this.txtWriterEmail.Location = new System.Drawing.Point(80, 180);
            this.txtWriterEmail.Name = "txtWriterEmail";
            this.txtWriterEmail.Size = new System.Drawing.Size(120, 22);
            this.txtWriterEmail.TabIndex = 3;
            // 
            // dtpWriterBirthDate
            // 
            this.dtpWriterBirthDate.Location = new System.Drawing.Point(300, 180);
            this.dtpWriterBirthDate.Name = "dtpWriterBirthDate";
            this.dtpWriterBirthDate.Size = new System.Drawing.Size(90, 22);
            this.dtpWriterBirthDate.TabIndex = 4;
            // 
            // btnAddWriter
            // 
            this.btnAddWriter.Location = new System.Drawing.Point(14, 220);
            this.btnAddWriter.Name = "btnAddWriter";
            this.btnAddWriter.Size = new System.Drawing.Size(60, 25);
            this.btnAddWriter.TabIndex = 5;
            this.btnAddWriter.Text = "Ekle";
            // 
            // btnEditWriter
            // 
            this.btnEditWriter.Location = new System.Drawing.Point(80, 220);
            this.btnEditWriter.Name = "btnEditWriter";
            this.btnEditWriter.Size = new System.Drawing.Size(64, 25);
            this.btnEditWriter.TabIndex = 6;
            this.btnEditWriter.Text = "Düzenle";
            // 
            // btnDeleteWriter
            // 
            this.btnDeleteWriter.Location = new System.Drawing.Point(150, 220);
            this.btnDeleteWriter.Name = "btnDeleteWriter";
            this.btnDeleteWriter.Size = new System.Drawing.Size(60, 25);
            this.btnDeleteWriter.TabIndex = 7;
            this.btnDeleteWriter.Text = "Sil";
            // 
            // lblWriterFirstName
            // 
            this.lblWriterFirstName.Location = new System.Drawing.Point(10, 150);
            this.lblWriterFirstName.Name = "lblWriterFirstName";
            this.lblWriterFirstName.Size = new System.Drawing.Size(60, 20);
            this.lblWriterFirstName.TabIndex = 8;
            this.lblWriterFirstName.Text = "Ad:";
            // 
            // lblWriterLastName
            // 
            this.lblWriterLastName.Location = new System.Drawing.Point(210, 150);
            this.lblWriterLastName.Name = "lblWriterLastName";
            this.lblWriterLastName.Size = new System.Drawing.Size(60, 20);
            this.lblWriterLastName.TabIndex = 9;
            this.lblWriterLastName.Text = "Soyad:";
            // 
            // lblWriterEmail
            // 
            this.lblWriterEmail.Location = new System.Drawing.Point(10, 180);
            this.lblWriterEmail.Name = "lblWriterEmail";
            this.lblWriterEmail.Size = new System.Drawing.Size(60, 20);
            this.lblWriterEmail.TabIndex = 10;
            this.lblWriterEmail.Text = "E-posta:";
            // 
            // lblWriterBirthDate
            // 
            this.lblWriterBirthDate.Location = new System.Drawing.Point(210, 180);
            this.lblWriterBirthDate.Name = "lblWriterBirthDate";
            this.lblWriterBirthDate.Size = new System.Drawing.Size(80, 20);
            this.lblWriterBirthDate.TabIndex = 11;
            this.lblWriterBirthDate.Text = "Doğum Tarihi:";
            // 
            // txtSearchWriter
            // 
            this.txtSearchWriter.Location = new System.Drawing.Point(60, 278);
            this.txtSearchWriter.Name = "txtSearchWriter";
            this.txtSearchWriter.Size = new System.Drawing.Size(150, 22);
            this.txtSearchWriter.TabIndex = 12;
            // 
            // btnSearchWriter
            // 
            this.btnSearchWriter.Location = new System.Drawing.Point(216, 278);
            this.btnSearchWriter.Name = "btnSearchWriter";
            this.btnSearchWriter.Size = new System.Drawing.Size(75, 23);
            this.btnSearchWriter.TabIndex = 13;
            this.btnSearchWriter.Text = "Ara";
            // 
            // lblSearchWriter
            // 
            this.lblSearchWriter.AutoSize = true;
            this.lblSearchWriter.Location = new System.Drawing.Point(23, 281);
            this.lblSearchWriter.Name = "lblSearchWriter";
            this.lblSearchWriter.Size = new System.Drawing.Size(31, 16);
            this.lblSearchWriter.TabIndex = 14;
            this.lblSearchWriter.Text = "Ara:";
            // 
            // grpBooks
            // 
            this.grpBooks.Controls.Add(this.dgvBooks);
            this.grpBooks.Controls.Add(this.txtBookTitle);
            this.grpBooks.Controls.Add(this.txtBookISBN);
            this.grpBooks.Controls.Add(this.dtpBookPublicationDate);
            this.grpBooks.Controls.Add(this.txtBookPrice);
            this.grpBooks.Controls.Add(this.btnAddBook);
            this.grpBooks.Controls.Add(this.btnEditBook);
            this.grpBooks.Controls.Add(this.btnDeleteBook);
            this.grpBooks.Controls.Add(this.lblBookTitle);
            this.grpBooks.Controls.Add(this.lblBookISBN);
            this.grpBooks.Controls.Add(this.lblBookPublicationDate);
            this.grpBooks.Controls.Add(this.lblBookPrice);
            this.grpBooks.Controls.Add(this.txtSearchBook);
            this.grpBooks.Controls.Add(this.btnSearchBook);
            this.grpBooks.Controls.Add(this.lblSearchBook);
            this.grpBooks.Location = new System.Drawing.Point(420, 10);
            this.grpBooks.Name = "grpBooks";
            this.grpBooks.Size = new System.Drawing.Size(400, 326);
            this.grpBooks.TabIndex = 1;
            this.grpBooks.TabStop = false;
            this.grpBooks.Text = "Kitaplar";
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeight = 29;
            this.dgvBooks.Location = new System.Drawing.Point(10, 20);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.Size = new System.Drawing.Size(380, 120);
            this.dgvBooks.TabIndex = 0;
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(80, 150);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(120, 22);
            this.txtBookTitle.TabIndex = 1;
            // 
            // txtBookISBN
            // 
            this.txtBookISBN.Location = new System.Drawing.Point(270, 150);
            this.txtBookISBN.Name = "txtBookISBN";
            this.txtBookISBN.Size = new System.Drawing.Size(120, 22);
            this.txtBookISBN.TabIndex = 2;
            // 
            // dtpBookPublicationDate
            // 
            this.dtpBookPublicationDate.Location = new System.Drawing.Point(100, 180);
            this.dtpBookPublicationDate.Name = "dtpBookPublicationDate";
            this.dtpBookPublicationDate.Size = new System.Drawing.Size(100, 22);
            this.dtpBookPublicationDate.TabIndex = 3;
            // 
            // txtBookPrice
            // 
            this.txtBookPrice.Location = new System.Drawing.Point(270, 180);
            this.txtBookPrice.Name = "txtBookPrice";
            this.txtBookPrice.Size = new System.Drawing.Size(120, 22);
            this.txtBookPrice.TabIndex = 4;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(14, 220);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(60, 25);
            this.btnAddBook.TabIndex = 5;
            this.btnAddBook.Text = "Ekle";
            // 
            // btnEditBook
            // 
            this.btnEditBook.Location = new System.Drawing.Point(80, 220);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(64, 25);
            this.btnEditBook.TabIndex = 6;
            this.btnEditBook.Text = "Düzenle";
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(150, 220);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(60, 25);
            this.btnDeleteBook.TabIndex = 7;
            this.btnDeleteBook.Text = "Sil";
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.Location = new System.Drawing.Point(10, 150);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(60, 20);
            this.lblBookTitle.TabIndex = 8;
            this.lblBookTitle.Text = "Başlık:";
            // 
            // lblBookISBN
            // 
            this.lblBookISBN.Location = new System.Drawing.Point(210, 150);
            this.lblBookISBN.Name = "lblBookISBN";
            this.lblBookISBN.Size = new System.Drawing.Size(60, 20);
            this.lblBookISBN.TabIndex = 9;
            this.lblBookISBN.Text = "ISBN:";
            // 
            // lblBookPublicationDate
            // 
            this.lblBookPublicationDate.Location = new System.Drawing.Point(10, 180);
            this.lblBookPublicationDate.Name = "lblBookPublicationDate";
            this.lblBookPublicationDate.Size = new System.Drawing.Size(80, 20);
            this.lblBookPublicationDate.TabIndex = 10;
            this.lblBookPublicationDate.Text = "Yayın Tarihi:";
            // 
            // lblBookPrice
            // 
            this.lblBookPrice.Location = new System.Drawing.Point(210, 180);
            this.lblBookPrice.Name = "lblBookPrice";
            this.lblBookPrice.Size = new System.Drawing.Size(60, 20);
            this.lblBookPrice.TabIndex = 11;
            this.lblBookPrice.Text = "Fiyat:";
            // 
            // txtSearchBook
            // 
            this.txtSearchBook.Location = new System.Drawing.Point(73, 275);
            this.txtSearchBook.Name = "txtSearchBook";
            this.txtSearchBook.Size = new System.Drawing.Size(150, 22);
            this.txtSearchBook.TabIndex = 12;
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Location = new System.Drawing.Point(242, 274);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(75, 23);
            this.btnSearchBook.TabIndex = 13;
            this.btnSearchBook.Text = "Ara";
            // 
            // lblSearchBook
            // 
            this.lblSearchBook.AutoSize = true;
            this.lblSearchBook.Location = new System.Drawing.Point(36, 278);
            this.lblSearchBook.Name = "lblSearchBook";
            this.lblSearchBook.Size = new System.Drawing.Size(31, 16);
            this.lblSearchBook.TabIndex = 14;
            this.lblSearchBook.Text = "Ara:";
            // 
            // splitContainerBottom
            // 
            this.splitContainerBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBottom.Location = new System.Drawing.Point(0, 0);
            this.splitContainerBottom.Name = "splitContainerBottom";
            this.splitContainerBottom.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerBottom.Panel1
            // 
            this.splitContainerBottom.Panel1.Controls.Add(this.grpWriterBook);
            this.splitContainerBottom.Size = new System.Drawing.Size(832, 171);
            this.splitContainerBottom.SplitterDistance = 121;
            this.splitContainerBottom.TabIndex = 0;
            // 
            // grpWriterBook
            // 
            this.grpWriterBook.Controls.Add(this.cmbWriters);
            this.grpWriterBook.Controls.Add(this.cmbBooks);
            this.grpWriterBook.Controls.Add(this.btnAssignWriterToBook);
            this.grpWriterBook.Controls.Add(this.dgvWriterBooks);
            this.grpWriterBook.Controls.Add(this.btnDeleteWriterBook);
            this.grpWriterBook.Controls.Add(this.lblAssignWriter);
            this.grpWriterBook.Controls.Add(this.lblAssignBook);
            this.grpWriterBook.Controls.Add(this.txtSearchWriterBook);
            this.grpWriterBook.Controls.Add(this.btnSearchWriterBook);
            this.grpWriterBook.Controls.Add(this.lblSearchWriterBook);
            this.grpWriterBook.Location = new System.Drawing.Point(10, 10);
            this.grpWriterBook.Name = "grpWriterBook";
            this.grpWriterBook.Size = new System.Drawing.Size(810, 140);
            this.grpWriterBook.TabIndex = 0;
            this.grpWriterBook.TabStop = false;
            this.grpWriterBook.Text = "Yazar-Kitap İlişkilendirme";
            // 
            // cmbWriters
            // 
            this.cmbWriters.Location = new System.Drawing.Point(60, 30);
            this.cmbWriters.Name = "cmbWriters";
            this.cmbWriters.Size = new System.Drawing.Size(150, 24);
            this.cmbWriters.TabIndex = 0;
            // 
            // cmbBooks
            // 
            this.cmbBooks.Location = new System.Drawing.Point(270, 30);
            this.cmbBooks.Name = "cmbBooks";
            this.cmbBooks.Size = new System.Drawing.Size(150, 24);
            this.cmbBooks.TabIndex = 1;
            // 
            // btnAssignWriterToBook
            // 
            this.btnAssignWriterToBook.Location = new System.Drawing.Point(430, 30);
            this.btnAssignWriterToBook.Name = "btnAssignWriterToBook";
            this.btnAssignWriterToBook.Size = new System.Drawing.Size(80, 25);
            this.btnAssignWriterToBook.TabIndex = 2;
            this.btnAssignWriterToBook.Text = "Eşleştir";
            // 
            // dgvWriterBooks
            // 
            this.dgvWriterBooks.ColumnHeadersHeight = 29;
            this.dgvWriterBooks.Location = new System.Drawing.Point(10, 60);
            this.dgvWriterBooks.Name = "dgvWriterBooks";
            this.dgvWriterBooks.RowHeadersWidth = 51;
            this.dgvWriterBooks.Size = new System.Drawing.Size(500, 70);
            this.dgvWriterBooks.TabIndex = 3;
            // 
            // btnDeleteWriterBook
            // 
            this.btnDeleteWriterBook.Location = new System.Drawing.Point(520, 60);
            this.btnDeleteWriterBook.Name = "btnDeleteWriterBook";
            this.btnDeleteWriterBook.Size = new System.Drawing.Size(80, 25);
            this.btnDeleteWriterBook.TabIndex = 4;
            this.btnDeleteWriterBook.Text = "İlişkiyi Sil";
            // 
            // lblAssignWriter
            // 
            this.lblAssignWriter.Location = new System.Drawing.Point(2, 30);
            this.lblAssignWriter.Name = "lblAssignWriter";
            this.lblAssignWriter.Size = new System.Drawing.Size(48, 20);
            this.lblAssignWriter.TabIndex = 5;
            this.lblAssignWriter.Text = "Yazar:";
            // 
            // lblAssignBook
            // 
            this.lblAssignBook.Location = new System.Drawing.Point(220, 30);
            this.lblAssignBook.Name = "lblAssignBook";
            this.lblAssignBook.Size = new System.Drawing.Size(40, 20);
            this.lblAssignBook.TabIndex = 6;
            this.lblAssignBook.Text = "Kitap:";
            // 
            // txtSearchWriterBook
            // 
            this.txtSearchWriterBook.Location = new System.Drawing.Point(579, 29);
            this.txtSearchWriterBook.Name = "txtSearchWriterBook";
            this.txtSearchWriterBook.Size = new System.Drawing.Size(150, 22);
            this.txtSearchWriterBook.TabIndex = 7;
            // 
            // btnSearchWriterBook
            // 
            this.btnSearchWriterBook.Location = new System.Drawing.Point(735, 27);
            this.btnSearchWriterBook.Name = "btnSearchWriterBook";
            this.btnSearchWriterBook.Size = new System.Drawing.Size(75, 23);
            this.btnSearchWriterBook.TabIndex = 8;
            this.btnSearchWriterBook.Text = "Ara";
            // 
            // lblSearchWriterBook
            // 
            this.lblSearchWriterBook.AutoSize = true;
            this.lblSearchWriterBook.Location = new System.Drawing.Point(532, 32);
            this.lblSearchWriterBook.Name = "lblSearchWriterBook";
            this.lblSearchWriterBook.Size = new System.Drawing.Size(31, 16);
            this.lblSearchWriterBook.TabIndex = 9;
            this.lblSearchWriterBook.Text = "Ara:";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(832, 603);
            this.Controls.Add(this.splitContainerMain);
            this.Name = "MainForm";
            this.Text = "Writer Service";
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.grpWriters.ResumeLayout(false);
            this.grpWriters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWriters)).EndInit();
            this.grpBooks.ResumeLayout(false);
            this.grpBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.splitContainerBottom.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBottom)).EndInit();
            this.splitContainerBottom.ResumeLayout(false);
            this.grpWriterBook.ResumeLayout(false);
            this.grpWriterBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWriterBooks)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.GroupBox grpWriters;
        private System.Windows.Forms.DataGridView dgvWriters;
        private System.Windows.Forms.TextBox txtWriterFirstName;
        private System.Windows.Forms.TextBox txtWriterLastName;
        private System.Windows.Forms.TextBox txtWriterEmail;
        private System.Windows.Forms.DateTimePicker dtpWriterBirthDate;
        private System.Windows.Forms.Button btnAddWriter;
        private System.Windows.Forms.Button btnEditWriter;
        private System.Windows.Forms.Button btnDeleteWriter;
        private System.Windows.Forms.Label lblWriterFirstName;
        private System.Windows.Forms.Label lblWriterLastName;
        private System.Windows.Forms.Label lblWriterEmail;
        private System.Windows.Forms.Label lblWriterBirthDate;
        private System.Windows.Forms.TextBox txtSearchWriter;
        private System.Windows.Forms.Button btnSearchWriter;
        private System.Windows.Forms.Label lblSearchWriter;

        private System.Windows.Forms.GroupBox grpBooks;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.TextBox txtBookISBN;
        private System.Windows.Forms.DateTimePicker dtpBookPublicationDate;
        private System.Windows.Forms.TextBox txtBookPrice;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblBookPublicationDate;
        private System.Windows.Forms.Label lblBookPrice;
        private System.Windows.Forms.TextBox txtSearchBook;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.Label lblSearchBook;

        private System.Windows.Forms.SplitContainer splitContainerBottom;
        private System.Windows.Forms.GroupBox grpWriterBook;
        private System.Windows.Forms.ComboBox cmbWriters;
        private System.Windows.Forms.ComboBox cmbBooks;
        private System.Windows.Forms.Button btnAssignWriterToBook;
        private System.Windows.Forms.DataGridView dgvWriterBooks;
        private System.Windows.Forms.Button btnDeleteWriterBook;
        private System.Windows.Forms.Label lblAssignWriter;
        private System.Windows.Forms.Label lblAssignBook;
        private System.Windows.Forms.Label lblBookISBN;
        private System.Windows.Forms.TextBox txtSearchWriterBook;
        private System.Windows.Forms.Button btnSearchWriterBook;
        private System.Windows.Forms.Label lblSearchWriterBook;
    }
}