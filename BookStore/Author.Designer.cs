namespace BookStoreScreen
{
    partial class Author
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
            this.lvAuthor = new System.Windows.Forms.ListView();
            this.colNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAuthorId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAuthorName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAuthorDesscription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCreateDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAuthorCover = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDeleteAuthor = new System.Windows.Forms.Button();
            this.btnUpdateAuthor = new System.Windows.Forms.Button();
            this.btnCreateAuthor = new System.Windows.Forms.Button();
            this.lblCreateTime = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.txtAuthorID = new System.Windows.Forms.TextBox();
            this.lblOldAvatarUrl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAuthoAvatar = new System.Windows.Forms.Button();
            this.ptbAvatar = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lvAuthor
            // 
            this.lvAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvAuthor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvAuthor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNo,
            this.colAuthorId,
            this.colAuthorName,
            this.colAuthorDesscription,
            this.colCreateDate,
            this.colAuthorCover});
            this.lvAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvAuthor.FullRowSelect = true;
            this.lvAuthor.GridLines = true;
            this.lvAuthor.Location = new System.Drawing.Point(12, 233);
            this.lvAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.lvAuthor.Name = "lvAuthor";
            this.lvAuthor.Size = new System.Drawing.Size(958, 275);
            this.lvAuthor.TabIndex = 11;
            this.lvAuthor.UseCompatibleStateImageBehavior = false;
            this.lvAuthor.View = System.Windows.Forms.View.Details;
            this.lvAuthor.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvAuthor_ItemSelectionChanged);
            // 
            // colNo
            // 
            this.colNo.Text = "No.";
            this.colNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colAuthorId
            // 
            this.colAuthorId.Text = "ID";
            this.colAuthorId.Width = 116;
            // 
            // colAuthorName
            // 
            this.colAuthorName.Text = "Name";
            this.colAuthorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colAuthorName.Width = 237;
            // 
            // colAuthorDesscription
            // 
            this.colAuthorDesscription.Text = "Description";
            this.colAuthorDesscription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colAuthorDesscription.Width = 363;
            // 
            // colCreateDate
            // 
            this.colCreateDate.Text = "Create Date";
            this.colCreateDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCreateDate.Width = 177;
            // 
            // colAuthorCover
            // 
            this.colAuthorCover.Text = "Cover";
            this.colAuthorCover.Width = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReload);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnDeleteAuthor);
            this.groupBox1.Controls.Add(this.btnUpdateAuthor);
            this.groupBox1.Controls.Add(this.btnCreateAuthor);
            this.groupBox1.Controls.Add(this.lblCreateTime);
            this.groupBox1.Controls.Add(this.rtbDescription);
            this.groupBox1.Controls.Add(this.txtAuthorName);
            this.groupBox1.Controls.Add(this.txtAuthorID);
            this.groupBox1.Controls.Add(this.lblOldAvatarUrl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnAuthoAvatar);
            this.groupBox1.Controls.Add(this.ptbAvatar);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(959, 198);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Author Information";
            // 
            // btnReload
            // 
            this.btnReload.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReload.Location = new System.Drawing.Point(807, 147);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(104, 36);
            this.btnReload.TabIndex = 10;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClear.BackColor = System.Drawing.Color.Linen;
            this.btnClear.Location = new System.Drawing.Point(681, 147);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 36);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.BackColor = System.Drawing.Color.Coral;
            this.btnSave.Location = new System.Drawing.Point(560, 147);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 36);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDeleteAuthor
            // 
            this.btnDeleteAuthor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteAuthor.Location = new System.Drawing.Point(448, 147);
            this.btnDeleteAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteAuthor.Name = "btnDeleteAuthor";
            this.btnDeleteAuthor.Size = new System.Drawing.Size(104, 36);
            this.btnDeleteAuthor.TabIndex = 7;
            this.btnDeleteAuthor.Text = "Delete";
            this.btnDeleteAuthor.UseVisualStyleBackColor = true;
            this.btnDeleteAuthor.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdateAuthor
            // 
            this.btnUpdateAuthor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdateAuthor.Location = new System.Drawing.Point(324, 147);
            this.btnUpdateAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateAuthor.Name = "btnUpdateAuthor";
            this.btnUpdateAuthor.Size = new System.Drawing.Size(104, 36);
            this.btnUpdateAuthor.TabIndex = 6;
            this.btnUpdateAuthor.Text = "Update";
            this.btnUpdateAuthor.UseVisualStyleBackColor = true;
            this.btnUpdateAuthor.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreateAuthor
            // 
            this.btnCreateAuthor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCreateAuthor.Location = new System.Drawing.Point(200, 147);
            this.btnCreateAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateAuthor.Name = "btnCreateAuthor";
            this.btnCreateAuthor.Size = new System.Drawing.Size(104, 36);
            this.btnCreateAuthor.TabIndex = 5;
            this.btnCreateAuthor.Text = "Create";
            this.btnCreateAuthor.UseVisualStyleBackColor = true;
            this.btnCreateAuthor.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblCreateTime
            // 
            this.lblCreateTime.AutoSize = true;
            this.lblCreateTime.Location = new System.Drawing.Point(474, 35);
            this.lblCreateTime.Name = "lblCreateTime";
            this.lblCreateTime.Size = new System.Drawing.Size(0, 13);
            this.lblCreateTime.TabIndex = 45;
            this.lblCreateTime.Visible = false;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(201, 84);
            this.rtbDescription.MaxLength = 255;
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(752, 56);
            this.rtbDescription.TabIndex = 3;
            this.rtbDescription.Text = "";
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(201, 60);
            this.txtAuthorName.MaxLength = 100;
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(216, 20);
            this.txtAuthorName.TabIndex = 2;
            // 
            // txtAuthorID
            // 
            this.txtAuthorID.Location = new System.Drawing.Point(201, 28);
            this.txtAuthorID.Name = "txtAuthorID";
            this.txtAuthorID.ReadOnly = true;
            this.txtAuthorID.Size = new System.Drawing.Size(121, 20);
            this.txtAuthorID.TabIndex = 1;
            // 
            // lblOldAvatarUrl
            // 
            this.lblOldAvatarUrl.AutoSize = true;
            this.lblOldAvatarUrl.Enabled = false;
            this.lblOldAvatarUrl.Location = new System.Drawing.Point(585, 31);
            this.lblOldAvatarUrl.Name = "lblOldAvatarUrl";
            this.lblOldAvatarUrl.Size = new System.Drawing.Size(0, 13);
            this.lblOldAvatarUrl.TabIndex = 41;
            this.lblOldAvatarUrl.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "ID:";
            // 
            // btnAuthoAvatar
            // 
            this.btnAuthoAvatar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAuthoAvatar.Location = new System.Drawing.Point(9, 153);
            this.btnAuthoAvatar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAuthoAvatar.Name = "btnAuthoAvatar";
            this.btnAuthoAvatar.Size = new System.Drawing.Size(126, 30);
            this.btnAuthoAvatar.TabIndex = 4;
            this.btnAuthoAvatar.Text = "Change Avatar";
            this.btnAuthoAvatar.UseVisualStyleBackColor = true;
            this.btnAuthoAvatar.Click += new System.EventHandler(this.btnChangeCover_Click);
            // 
            // ptbAvatar
            // 
            this.ptbAvatar.Location = new System.Drawing.Point(6, 19);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.Size = new System.Drawing.Size(125, 124);
            this.ptbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAvatar.TabIndex = 33;
            this.ptbAvatar.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(387, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "AUTHOR MANAGEMENT";
            // 
            // Author
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lvAuthor);
            this.Controls.Add(this.groupBox1);
            this.Name = "Author";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Author_FormClosed);
            this.Load += new System.EventHandler(this.ListAuthor_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lvAuthor, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvAuthor;
        private System.Windows.Forms.ColumnHeader colAuthorName;
        private System.Windows.Forms.ColumnHeader colAuthorId;
        private System.Windows.Forms.ColumnHeader colAuthorDesscription;
        private System.Windows.Forms.ColumnHeader colCreateDate;
        private System.Windows.Forms.ColumnHeader colNo;
        private System.Windows.Forms.ColumnHeader colAuthorCover;
       
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDeleteAuthor;
        private System.Windows.Forms.Button btnUpdateAuthor;
        private System.Windows.Forms.Button btnCreateAuthor;
        private System.Windows.Forms.Label lblCreateTime;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.TextBox txtAuthorID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAuthoAvatar;
        private System.Windows.Forms.PictureBox ptbAvatar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOldAvatarUrl;

    }
}