﻿namespace BookStoreScreen
{
    partial class Books
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblOldCoverUrl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAuthor = new System.Windows.Forms.ComboBox();
            this.btnCover = new System.Windows.Forms.Button();
            this.ptbCover = new System.Windows.Forms.PictureBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblCreateTime = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lvListBook = new System.Windows.Forms.ListView();
            this.colNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBookId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBookDesscription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCeateDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBookCover = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPublisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbAuthorSearch = new System.Windows.Forms.ComboBox();
            this.cmbCategorySearch = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbYearSearch = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCover)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbYear);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtPublisher);
            this.groupBox1.Controls.Add(this.lblPublisher);
            this.groupBox1.Controls.Add(this.lblOldCoverUrl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbCategory);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbAuthor);
            this.groupBox1.Controls.Add(this.btnCover);
            this.groupBox1.Controls.Add(this.ptbCover);
            this.groupBox1.Controls.Add(this.btnReload);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.lblCreateTime);
            this.groupBox1.Controls.Add(this.rtbDescription);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(959, 187);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Information";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(856, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 63;
            this.label11.Text = "Year";
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(891, 19);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(65, 21);
            this.cmbYear.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(142, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 61;
            this.label8.Text = "Publisher";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(198, 47);
            this.txtPublisher.MaxLength = 250;
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(420, 20);
            this.txtPublisher.TabIndex = 5;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(476, 90);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(0, 13);
            this.lblPublisher.TabIndex = 59;
            this.lblPublisher.Visible = false;
            // 
            // lblOldCoverUrl
            // 
            this.lblOldCoverUrl.AutoSize = true;
            this.lblOldCoverUrl.Location = new System.Drawing.Point(490, 85);
            this.lblOldCoverUrl.Name = "lblOldCoverUrl";
            this.lblOldCoverUrl.Size = new System.Drawing.Size(0, 13);
            this.lblOldCoverUrl.TabIndex = 58;
            this.lblOldCoverUrl.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(628, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Category";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(680, 47);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(164, 21);
            this.cmbCategory.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(636, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Author";
            // 
            // cmbAuthor
            // 
            this.cmbAuthor.FormattingEnabled = true;
            this.cmbAuthor.Location = new System.Drawing.Point(680, 19);
            this.cmbAuthor.Name = "cmbAuthor";
            this.cmbAuthor.Size = new System.Drawing.Size(164, 21);
            this.cmbAuthor.TabIndex = 3;
            // 
            // btnCover
            // 
            this.btnCover.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCover.Location = new System.Drawing.Point(3, 149);
            this.btnCover.Margin = new System.Windows.Forms.Padding(4);
            this.btnCover.Name = "btnCover";
            this.btnCover.Size = new System.Drawing.Size(126, 30);
            this.btnCover.TabIndex = 8;
            this.btnCover.Text = "Change Cover";
            this.btnCover.UseVisualStyleBackColor = true;
            this.btnCover.Click += new System.EventHandler(this.btnChangeCover_Click);
            // 
            // ptbCover
            // 
            this.ptbCover.Location = new System.Drawing.Point(4, 19);
            this.ptbCover.Name = "ptbCover";
            this.ptbCover.Size = new System.Drawing.Size(125, 124);
            this.ptbCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCover.TabIndex = 52;
            this.ptbCover.TabStop = false;
            // 
            // btnReload
            // 
            this.btnReload.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReload.Location = new System.Drawing.Point(804, 145);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(104, 36);
            this.btnReload.TabIndex = 14;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClear.BackColor = System.Drawing.Color.Linen;
            this.btnClear.Location = new System.Drawing.Point(678, 145);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 36);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.BackColor = System.Drawing.Color.Coral;
            this.btnSave.Location = new System.Drawing.Point(557, 145);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 36);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.Location = new System.Drawing.Point(445, 145);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 36);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdate.Location = new System.Drawing.Point(321, 145);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 36);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCreate.Location = new System.Drawing.Point(197, 145);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(104, 36);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblCreateTime
            // 
            this.lblCreateTime.AutoSize = true;
            this.lblCreateTime.Location = new System.Drawing.Point(452, 26);
            this.lblCreateTime.Name = "lblCreateTime";
            this.lblCreateTime.Size = new System.Drawing.Size(0, 13);
            this.lblCreateTime.TabIndex = 45;
            this.lblCreateTime.Visible = false;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(198, 74);
            this.rtbDescription.MaxLength = 500;
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(758, 57);
            this.rtbDescription.TabIndex = 7;
            this.rtbDescription.Text = "";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(345, 19);
            this.txtName.MaxLength = 250;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(273, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(199, 19);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(80, 20);
            this.txtID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "ID:";
            // 
            // lvListBook
            // 
            this.lvListBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvListBook.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvListBook.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNo,
            this.colBookId,
            this.colBookName,
            this.colBookDesscription,
            this.colCeateDate,
            this.colBookCover,
            this.colAuthor,
            this.colCategory,
            this.colPublisher,
            this.colYear});
            this.lvListBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvListBook.FullRowSelect = true;
            this.lvListBook.GridLines = true;
            this.lvListBook.Location = new System.Drawing.Point(15, 254);
            this.lvListBook.Margin = new System.Windows.Forms.Padding(4);
            this.lvListBook.Name = "lvListBook";
            this.lvListBook.Size = new System.Drawing.Size(958, 246);
            this.lvListBook.TabIndex = 20;
            this.lvListBook.UseCompatibleStateImageBehavior = false;
            this.lvListBook.View = System.Windows.Forms.View.Details;
            this.lvListBook.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvDisplay_ItemSelectionChanged);
            // 
            // colNo
            // 
            this.colNo.Text = "No.";
            this.colNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colNo.Width = 43;
            // 
            // colBookId
            // 
            this.colBookId.Text = "ID";
            this.colBookId.Width = 66;
            // 
            // colBookName
            // 
            this.colBookName.Text = "Name";
            this.colBookName.Width = 172;
            // 
            // colBookDesscription
            // 
            this.colBookDesscription.Text = "Description";
            this.colBookDesscription.Width = 292;
            // 
            // colCeateDate
            // 
            this.colCeateDate.Text = "Create Date";
            this.colCeateDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCeateDate.Width = 125;
            // 
            // colBookCover
            // 
            this.colBookCover.Text = "Cover";
            this.colBookCover.Width = 0;
            // 
            // colAuthor
            // 
            this.colAuthor.Text = "Author";
            this.colAuthor.Width = 0;
            // 
            // colCategory
            // 
            this.colCategory.Text = "Category";
            this.colCategory.Width = 0;
            // 
            // colPublisher
            // 
            this.colPublisher.Text = "Publisher";
            this.colPublisher.Width = 198;
            // 
            // colYear
            // 
            this.colYear.Text = "Year";
            this.colYear.Width = 58;
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(61, 227);
            this.txtSearchName.MaxLength = 100;
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(150, 20);
            this.txtSearchName.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Name: ";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSearch.Location = new System.Drawing.Point(866, 223);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 26);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(225, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "Author";
            // 
            // cmbAuthorSearch
            // 
            this.cmbAuthorSearch.FormattingEnabled = true;
            this.cmbAuthorSearch.Location = new System.Drawing.Point(269, 227);
            this.cmbAuthorSearch.Name = "cmbAuthorSearch";
            this.cmbAuthorSearch.Size = new System.Drawing.Size(168, 21);
            this.cmbAuthorSearch.TabIndex = 16;
            // 
            // cmbCategorySearch
            // 
            this.cmbCategorySearch.FormattingEnabled = true;
            this.cmbCategorySearch.Location = new System.Drawing.Point(519, 226);
            this.cmbCategorySearch.Name = "cmbCategorySearch";
            this.cmbCategorySearch.Size = new System.Drawing.Size(153, 21);
            this.cmbCategorySearch.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(467, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 59;
            this.label9.Text = "Category";
            // 
            // cmbYearSearch
            // 
            this.cmbYearSearch.FormattingEnabled = true;
            this.cmbYearSearch.Location = new System.Drawing.Point(727, 226);
            this.cmbYearSearch.Name = "cmbYearSearch";
            this.cmbYearSearch.Size = new System.Drawing.Size(95, 21);
            this.cmbYearSearch.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(695, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "Year";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(364, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(244, 25);
            this.label12.TabIndex = 60;
            this.label12.Text = "BOOK MANAGEMENT";
            // 
            // Books
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbYearSearch);
            this.Controls.Add(this.cmbCategorySearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbAuthorSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lvListBook);
            this.Controls.Add(this.groupBox1);
            this.Name = "Books";
            this.Load += new System.EventHandler(this.Book_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lvListBook, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtSearchName, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.cmbAuthorSearch, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.cmbCategorySearch, 0);
            this.Controls.SetChildIndex(this.cmbYearSearch, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblCreateTime;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAuthor;
        private System.Windows.Forms.Button btnCover;
        private System.Windows.Forms.PictureBox ptbCover;
        private System.Windows.Forms.ListView lvListBook;
        private System.Windows.Forms.ColumnHeader colNo;
        private System.Windows.Forms.ColumnHeader colBookId;
        private System.Windows.Forms.ColumnHeader colBookName;
        private System.Windows.Forms.ColumnHeader colBookDesscription;
        private System.Windows.Forms.ColumnHeader colCeateDate;
        private System.Windows.Forms.ColumnHeader colBookCover;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbAuthorSearch;
        private System.Windows.Forms.Label lblOldCoverUrl;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.ColumnHeader colAuthor;
        private System.Windows.Forms.ColumnHeader colCategory;
        private System.Windows.Forms.ColumnHeader colPublisher;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.ComboBox cmbCategorySearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbYearSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ColumnHeader colYear;
        private System.Windows.Forms.Label label12;
    }
}