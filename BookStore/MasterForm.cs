using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreScreen
{
    public partial class MasterForm : Form
    {
        string m_FormId = string.Empty;
        public MasterForm()
        {
            InitializeComponent();
        }
        public MasterForm(string id)
        {
           
            InitializeComponent();
            this.m_FormId = id;
           
        }

        private void MasterForm_Load(object sender, EventArgs e)
        {
            if (Program.UserViewModel!=null && !string.IsNullOrEmpty(Program.UserViewModel.FirstName))
            this.lblUserInfo.Text = String.Format("Hi {0}", Program.UserViewModel.FirstName);
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            //ListUser frmListUser = new ListUser();
            //frmListUser.ShowDialog();
        }

        /// <summary>
        /// Logout action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            this.Hide();
            frmLogin.Show();
        }

        private void managerUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void managerRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void managerCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category frmCategory = new Category(Books.ActiveForm);
            if (!this.Name.Equals(frmCategory.Name))
            {
                this.Hide();
                frmCategory.ShowDialog();
            }
        }

        private void managerBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books frmBook = new Books();
            if (!this.Name.Equals(frmBook.Name))
            {
                this.Hide();
                frmBook.ShowDialog();
            }
        }

        private void managerAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Author frmAuthor = new Author(Books.ActiveForm);
            if (!this.Name.Equals(frmAuthor.Name)){
                this.Hide();
                frmAuthor.ShowDialog();
            }
            
        }

        private void MasterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
