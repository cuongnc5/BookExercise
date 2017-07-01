using BookStoreBusiness;
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
    public partial class Login : Form
    {
  
        //  declare variable
         IUserBusiness mUserBusiness {get;set;}

        public Login()
        {
            mUserBusiness = new UserBusiness();
            InitializeComponent();
        }

        /// <summary>
        /// Handle event click on button Cancel 
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">EventArgs object</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Handle event click on button Login 
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">EventArgs object</param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Get user by user id to check permision after login
            UserViewModel userViewModel = new UserViewModel();
            userViewModel = mUserBusiness.GetUserById(this.txtUsername.Text);
            if (userViewModel != null && userViewModel.Password.Equals(this.txtPassword.Text))
            {
                Program.UserViewModel = userViewModel;
                Books frmBook = new Books();
                this.Hide();
                frmBook.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username or password is not correct!","Login Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.txtUsername.Focus();
            }
        }
    }
}
