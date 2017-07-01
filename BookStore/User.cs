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
    public partial class User : MasterForm
    {
        //Declace variable
        IUserBusiness m_userBusiness { get; set; }
        private Form m_parentForm = null;

        public User(IUserBusiness userBusiness,Form parentForm):base("ListUser")
        {
            InitializeComponent();
            this.m_parentForm = parentForm;
            this.m_userBusiness = userBusiness;
        }

        private void ListUser_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handle Event close form:
        /// - show parent form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_parentForm.Show();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnAuthoAvatar_Click(object sender, EventArgs e)
        {

        }
    }
}
