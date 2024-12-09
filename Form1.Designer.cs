namespace Crownhart_FinalLibraryCatalog
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAddBook = new Label();
            lblTitle = new Label();
            lblAuthor = new Label();
            lblISBN = new Label();
            lblCopies = new Label();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtISBN = new TextBox();
            txtCopies = new TextBox();
            lblWarning = new Label();
            btnSubmit = new Button();
            lsbCatalog = new ListBox();
            lblCatalog = new Label();
            lsbBorrowing = new ListBox();
            lblBorrowing = new Label();
            btnBorrow = new Button();
            btnUndoBorrow = new Button();
            lblSearch = new Label();
            lblWaitList = new Label();
            chbTitle = new CheckBox();
            chbISBN = new CheckBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            chbWaitListYes = new CheckBox();
            chbWaitListNo = new CheckBox();
            lblUserName = new Label();
            txtUserName = new TextBox();
            btnAddWaitList = new Button();
            lblNotifyUser = new Label();
            lblResults = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblAddBook
            // 
            lblAddBook.AutoSize = true;
            lblAddBook.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddBook.Location = new Point(117, 21);
            lblAddBook.Name = "lblAddBook";
            lblAddBook.Size = new Size(131, 21);
            lblAddBook.TabIndex = 0;
            lblAddBook.Text = "Add Books Here";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(26, 71);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(42, 21);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Title:";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAuthor.Location = new Point(26, 114);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(61, 21);
            lblAuthor.TabIndex = 2;
            lblAuthor.Text = "Author:";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblISBN.Location = new Point(29, 161);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(47, 21);
            lblISBN.TabIndex = 3;
            lblISBN.Text = "ISBN:";
            // 
            // lblCopies
            // 
            lblCopies.AutoSize = true;
            lblCopies.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCopies.Location = new Point(26, 201);
            lblCopies.Name = "lblCopies";
            lblCopies.Size = new Size(57, 21);
            lblCopies.TabIndex = 4;
            lblCopies.Text = "Copies";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(117, 76);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(131, 23);
            txtTitle.TabIndex = 5;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(117, 114);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(131, 23);
            txtAuthor.TabIndex = 6;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(117, 159);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(131, 23);
            txtISBN.TabIndex = 7;
            // 
            // txtCopies
            // 
            txtCopies.Location = new Point(117, 201);
            txtCopies.Name = "txtCopies";
            txtCopies.Size = new Size(131, 23);
            txtCopies.TabIndex = 8;
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.Location = new Point(129, 242);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(83, 15);
            lblWarning.TabIndex = 9;
            lblWarning.Text = "Input Warning";
            lblWarning.Visible = false;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(137, 270);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 31);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lsbCatalog
            // 
            lsbCatalog.FormattingEnabled = true;
            lsbCatalog.ItemHeight = 15;
            lsbCatalog.Location = new Point(335, 76);
            lsbCatalog.Name = "lsbCatalog";
            lsbCatalog.Size = new Size(223, 319);
            lsbCatalog.TabIndex = 11;
            // 
            // lblCatalog
            // 
            lblCatalog.AutoSize = true;
            lblCatalog.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCatalog.Location = new Point(416, 21);
            lblCatalog.Name = "lblCatalog";
            lblCatalog.Size = new Size(69, 21);
            lblCatalog.TabIndex = 12;
            lblCatalog.Text = "Catalog";
            // 
            // lsbBorrowing
            // 
            lsbBorrowing.FormattingEnabled = true;
            lsbBorrowing.ItemHeight = 15;
            lsbBorrowing.Location = new Point(609, 76);
            lsbBorrowing.Name = "lsbBorrowing";
            lsbBorrowing.Size = new Size(223, 319);
            lsbBorrowing.TabIndex = 13;
            // 
            // lblBorrowing
            // 
            lblBorrowing.AutoSize = true;
            lblBorrowing.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBorrowing.Location = new Point(675, 21);
            lblBorrowing.Name = "lblBorrowing";
            lblBorrowing.Size = new Size(84, 21);
            lblBorrowing.TabIndex = 14;
            lblBorrowing.Text = "Borrowed";
            // 
            // btnBorrow
            // 
            btnBorrow.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrow.Location = new Point(335, 422);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(142, 31);
            btnBorrow.TabIndex = 15;
            btnBorrow.Text = "Borrow";
            btnBorrow.UseVisualStyleBackColor = true;
            btnBorrow.Click += btnBorrow_Click;
            // 
            // btnUndoBorrow
            // 
            btnUndoBorrow.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUndoBorrow.Location = new Point(335, 490);
            btnUndoBorrow.Name = "btnUndoBorrow";
            btnUndoBorrow.Size = new Size(142, 31);
            btnUndoBorrow.TabIndex = 16;
            btnUndoBorrow.Text = "Undo Borrow";
            btnUndoBorrow.UseVisualStyleBackColor = true;
            btnUndoBorrow.Click += btnUndoBorrow_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(33, 358);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(61, 21);
            lblSearch.TabIndex = 17;
            lblSearch.Text = "Search";
            // 
            // lblWaitList
            // 
            lblWaitList.AutoSize = true;
            lblWaitList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWaitList.Location = new Point(866, 71);
            lblWaitList.Name = "lblWaitList";
            lblWaitList.Size = new Size(138, 21);
            lblWaitList.TabIndex = 18;
            lblWaitList.Text = "Add To Wait List?";
            lblWaitList.Visible = false;
            // 
            // chbTitle
            // 
            chbTitle.AutoSize = true;
            chbTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chbTitle.Location = new Point(33, 391);
            chbTitle.Name = "chbTitle";
            chbTitle.Size = new Size(141, 25);
            chbTitle.TabIndex = 19;
            chbTitle.Text = "Search By Title";
            chbTitle.UseVisualStyleBackColor = true;
            chbTitle.CheckedChanged += chbTitle_CheckedChanged;
            // 
            // chbISBN
            // 
            chbISBN.AutoSize = true;
            chbISBN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chbISBN.Location = new Point(33, 422);
            chbISBN.Name = "chbISBN";
            chbISBN.Size = new Size(144, 25);
            chbISBN.TabIndex = 20;
            chbISBN.Text = "Search By ISBN";
            chbISBN.UseVisualStyleBackColor = true;
            chbISBN.CheckedChanged += chbISBN_CheckedChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(33, 466);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(179, 23);
            txtSearch.TabIndex = 21;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(56, 521);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(103, 33);
            btnSearch.TabIndex = 22;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // chbWaitListYes
            // 
            chbWaitListYes.AutoSize = true;
            chbWaitListYes.Enabled = false;
            chbWaitListYes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbWaitListYes.Location = new Point(883, 114);
            chbWaitListYes.Name = "chbWaitListYes";
            chbWaitListYes.Size = new Size(52, 25);
            chbWaitListYes.TabIndex = 23;
            chbWaitListYes.Text = "Yes";
            chbWaitListYes.UseVisualStyleBackColor = true;
            chbWaitListYes.Visible = false;
            chbWaitListYes.CheckedChanged += chbWaitListYes_CheckedChanged;
            // 
            // chbWaitListNo
            // 
            chbWaitListNo.AutoSize = true;
            chbWaitListNo.Enabled = false;
            chbWaitListNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbWaitListNo.Location = new Point(885, 145);
            chbWaitListNo.Name = "chbWaitListNo";
            chbWaitListNo.Size = new Size(50, 25);
            chbWaitListNo.TabIndex = 24;
            chbWaitListNo.Text = "No";
            chbWaitListNo.UseVisualStyleBackColor = true;
            chbWaitListNo.Visible = false;
            chbWaitListNo.CheckedChanged += chbWaitListNo_CheckedChanged;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(866, 184);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(144, 21);
            lblUserName.TabIndex = 25;
            lblUserName.Text = "Enter a Username";
            lblUserName.Visible = false;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(866, 234);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(172, 23);
            txtUserName.TabIndex = 26;
            txtUserName.Visible = false;
            // 
            // btnAddWaitList
            // 
            btnAddWaitList.Enabled = false;
            btnAddWaitList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddWaitList.Location = new Point(883, 280);
            btnAddWaitList.Name = "btnAddWaitList";
            btnAddWaitList.Size = new Size(142, 31);
            btnAddWaitList.TabIndex = 27;
            btnAddWaitList.Text = "Add To Wait List";
            btnAddWaitList.UseVisualStyleBackColor = true;
            btnAddWaitList.Visible = false;
            btnAddWaitList.Click += btnAddWaitList_Click;
            // 
            // lblNotifyUser
            // 
            lblNotifyUser.AutoSize = true;
            lblNotifyUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNotifyUser.Location = new Point(866, 21);
            lblNotifyUser.Name = "lblNotifyUser";
            lblNotifyUser.Size = new Size(172, 21);
            lblNotifyUser.TabIndex = 28;
            lblNotifyUser.Text = "Wait List Notification";
            lblNotifyUser.Visible = false;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Location = new Point(92, 490);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(60, 15);
            lblResults.TabIndex = 29;
            lblResults.Text = "NoResults";
            lblResults.Visible = false;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(927, 505);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(143, 40);
            btnClose.TabIndex = 30;
            btnClose.Text = "Exit Application";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 566);
            Controls.Add(btnClose);
            Controls.Add(lblResults);
            Controls.Add(lblNotifyUser);
            Controls.Add(btnAddWaitList);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            Controls.Add(chbWaitListNo);
            Controls.Add(chbWaitListYes);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(chbISBN);
            Controls.Add(chbTitle);
            Controls.Add(lblWaitList);
            Controls.Add(lblSearch);
            Controls.Add(btnUndoBorrow);
            Controls.Add(btnBorrow);
            Controls.Add(lblBorrowing);
            Controls.Add(lsbBorrowing);
            Controls.Add(lblCatalog);
            Controls.Add(lsbCatalog);
            Controls.Add(btnSubmit);
            Controls.Add(lblWarning);
            Controls.Add(txtCopies);
            Controls.Add(txtISBN);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Controls.Add(lblCopies);
            Controls.Add(lblISBN);
            Controls.Add(lblAuthor);
            Controls.Add(lblTitle);
            Controls.Add(lblAddBook);
            Name = "frmMain";
            Text = "Library Catalog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddBook;
        private Label lblTitle;
        private Label lblAuthor;
        private Label lblISBN;
        private Label lblCopies;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtISBN;
        private TextBox txtCopies;
        private Label lblWarning;
        private Button btnSubmit;
        private ListBox lsbCatalog;
        private Label lblCatalog;
        private ListBox lsbBorrowing;
        private Label lblBorrowing;
        private Button btnBorrow;
        private Button btnUndoBorrow;
        private Label lblSearch;
        private Label lblWaitList;
        private CheckBox chbTitle;
        private CheckBox chbISBN;
        private TextBox txtSearch;
        private Button btnSearch;
        private CheckBox chbWaitListYes;
        private CheckBox chbWaitListNo;
        private Label lblUserName;
        private TextBox txtUserName;
        private Button btnAddWaitList;
        private Label lblNotifyUser;
        private Label lblResults;
        private Button btnClose;
    }
}
