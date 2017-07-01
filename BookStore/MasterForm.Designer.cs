namespace BookStoreScreen
{
    partial class MasterForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managerUserToolStripMenuItem,
            this.managerRoleToolStripMenuItem,
            this.managerCategoryToolStripMenuItem,
            this.managerBookToolStripMenuItem,
            this.managerAuthorToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // managerUserToolStripMenuItem
            // 
            this.managerUserToolStripMenuItem.Name = "managerUserToolStripMenuItem";
            this.managerUserToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.managerUserToolStripMenuItem.Text = "Manager User";
            this.managerUserToolStripMenuItem.Click += new System.EventHandler(this.managerUserToolStripMenuItem_Click);
            // 
            // managerRoleToolStripMenuItem
            // 
            this.managerRoleToolStripMenuItem.Name = "managerRoleToolStripMenuItem";
            this.managerRoleToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.managerRoleToolStripMenuItem.Text = "Manager Role";
            this.managerRoleToolStripMenuItem.Click += new System.EventHandler(this.managerRoleToolStripMenuItem_Click);
            // 
            // managerCategoryToolStripMenuItem
            // 
            this.managerCategoryToolStripMenuItem.Name = "managerCategoryToolStripMenuItem";
            this.managerCategoryToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.managerCategoryToolStripMenuItem.Text = "Manager Category";
            this.managerCategoryToolStripMenuItem.Click += new System.EventHandler(this.managerCategoryToolStripMenuItem_Click);
            // 
            // managerBookToolStripMenuItem
            // 
            this.managerBookToolStripMenuItem.Name = "managerBookToolStripMenuItem";
            this.managerBookToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.managerBookToolStripMenuItem.Text = "Manager Book";
            this.managerBookToolStripMenuItem.Click += new System.EventHandler(this.managerBookToolStripMenuItem_Click);
            // 
            // managerAuthorToolStripMenuItem
            // 
            this.managerAuthorToolStripMenuItem.Name = "managerAuthorToolStripMenuItem";
            this.managerAuthorToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.managerAuthorToolStripMenuItem.Text = "Manager Author";
            this.managerAuthorToolStripMenuItem.Click += new System.EventHandler(this.managerAuthorToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.logOutToolStripMenuItem.Text = "LogOut";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUserInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblUserInfo.Location = new System.Drawing.Point(878, 9);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(63, 13);
            this.lblUserInfo.TabIndex = 6;
            this.lblUserInfo.Text = "Hello Admin";
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(241)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.lblUserInfo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1000, 550);
            this.MinimumSize = new System.Drawing.Size(1000, 550);
            this.Name = "MasterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MasterForm_FormClosed);
            this.Load += new System.EventHandler(this.MasterForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerRoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerAuthorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Label lblUserInfo;
    }
}