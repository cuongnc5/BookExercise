using BookStoreBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace BookStoreScreen
{
    public partial class Author : MasterForm
    {
        #region Declace variable

        IAuthorBusiness mAuthorBusiness { get; set; }
        private Form mParentForm = null;
        private string mAction = String.Empty;

        #endregion

        #region Methods
        public Author(Form parentForm)
            : base("Author")
        {
            InitializeComponent();
            this.mParentForm = parentForm;
            this.mAuthorBusiness = new AuthorBusiness();
        }

        /// <summary>
        /// Set status of control
        /// </summary>
        /// <param name="action">Action name:Create,Update, Delete</param>
        private void InitControl(string action)
        {
            switch (action)
            {
                case Constants.ACTION_CREATE:
                    this.txtAuthorID.ReadOnly = true;
                    this.txtAuthorName.ReadOnly = false;
                    this.rtbDescription.ReadOnly = false;

                    this.txtAuthorID.Enabled = false;
                    this.txtAuthorName.Enabled = true;
                    this.rtbDescription.Enabled = true;

                    this.btnAuthoAvatar.Enabled = true;
                    this.txtAuthorID.Text = string.Empty;
                    this.txtAuthorName.Text = string.Empty;
                    this.rtbDescription.Text = string.Empty;
                    this.lblOldAvatarUrl.Text = string.Empty;
                    this.ptbAvatar.Image = null;
                    this.btnUpdateAuthor.Enabled = false;
                    this.btnDeleteAuthor.Enabled = false;
                    this.btnCreateAuthor.Enabled = false;
                    this.btnSave.Enabled = true;
                    this.btnClear.Enabled = true;
                    this.mAction = Constants.ACTION_CREATE;
                    break;
                case Constants.ACTION_UPDATE:
                    this.txtAuthorID.ReadOnly = true;
                    this.txtAuthorName.ReadOnly = false;
                    this.rtbDescription.ReadOnly = false;

                    this.txtAuthorID.Enabled = false;
                    this.txtAuthorName.Enabled = true;
                    this.rtbDescription.Enabled = true;

                    this.btnAuthoAvatar.Enabled = true;
                    this.btnUpdateAuthor.Enabled = false;
                    this.btnCreateAuthor.Enabled = false;
                    this.btnDeleteAuthor.Enabled = false;
                    this.btnSave.Enabled = true;
                    this.btnClear.Enabled = true;
                    this.mAction = Constants.ACTION_UPDATE;
                    break;
                case Constants.ACTION_DELETE:
                case Constants.ACTION_VIEW:
                    this.txtAuthorID.ReadOnly = false;
                    this.txtAuthorName.ReadOnly = false;
                    this.rtbDescription.ReadOnly = false;

                    this.txtAuthorID.Enabled = false;
                    this.txtAuthorName.Enabled = false;
                    this.rtbDescription.Enabled = false;
                    this.btnAuthoAvatar.Enabled = false;

                    this.btnUpdateAuthor.Enabled = true;
                    this.btnCreateAuthor.Enabled = true;
                    this.btnSave.Enabled = false;
                    this.btnClear.Enabled = false;

                    if (Program.UserViewModel.Role.Equals(Constants.ROLE_ADMIN) && lvAuthor.Items.Count > 0)
                    {
                        this.btnDeleteAuthor.Enabled = true;
                    }
                    else
                    {
                        this.btnDeleteAuthor.Enabled = false;
                    }

                    break;

                default:
                    this.txtAuthorID.Text = string.Empty;
                    this.txtAuthorName.Text = string.Empty;
                    this.rtbDescription.Text = string.Empty;
                    this.lblOldAvatarUrl.Text = string.Empty;
                    this.ptbAvatar.Image = null;

                    this.txtAuthorID.ReadOnly = true;
                    this.txtAuthorName.ReadOnly = true;
                    this.rtbDescription.Enabled = false;
                    this.btnAuthoAvatar.Enabled = false;
                    this.btnCreateAuthor.Enabled = true;
                    this.btnUpdateAuthor.Enabled = false;
                    this.btnClear.Enabled = false;
                    this.btnSave.Enabled = false;

                    if (Program.UserViewModel.Role.Equals(Constants.ROLE_ADMIN) && lvAuthor.Items.Count > 0)
                    {
                        this.btnDeleteAuthor.Enabled = true;

                    }
                    else
                    {
                        this.btnDeleteAuthor.Enabled = false;
                    }
                    break;
            }


        }

        /// <summary>
        /// Load data
        /// </summary>
        /// <returns>True if sucessfull and vice versa</returns>
        private bool InitData()
        {
            bool result = false;
            try
            {
                //Clear grid
                lvAuthor.Items.Clear();

                //Get author list
                List<AuthorViewModel> lstAuthorViewModel = mAuthorBusiness.GetAllAuthor();

                if (lstAuthorViewModel != null && lstAuthorViewModel.Count > 0)
                {

                    for (int i = 0; i < lstAuthorViewModel.Count; i++)
                    {
                        ListViewItem lvItem = new ListViewItem((i + 1).ToString());
                        lvItem.SubItems.Add(lstAuthorViewModel[i].Id.ToString());
                        lvItem.SubItems.Add(lstAuthorViewModel[i].Name);
                        lvItem.SubItems.Add(lstAuthorViewModel[i].Description);
                        lvItem.SubItems.Add(lstAuthorViewModel[i].CreateTime.ToString(Constants.DATE_FORMAT_1));
                        lvItem.SubItems.Add(lstAuthorViewModel[i].Cover);
                        lvAuthor.Items.Add(lvItem);
                    }
                    this.SetSelectedItem(0);
                }

                result = true;
            }
            catch (Exception)
            {

                result = false;
                //log ex
            }
            return result;

        }

        /// <summary>
        /// Set selected item for list view
        /// </summary>
        /// <param name="index"></param>
        public void SetSelectedItem(int index)
        {
            lvAuthor.Items[index].Selected = true;
            lvAuthor.Items[index].Focused = true;
        }

        /// <summary>
        /// Get Author information form grid
        /// </summary>
        /// <param name="listViewItem">ListViewItem</param>
        /// <returns>AuthorViewModel object</returns>
        private AuthorViewModel GetAuthorFromListView(ListViewItem listViewItem)
        {
            AuthorViewModel author = new AuthorViewModel();
            author.Id = Convert.ToInt32(listViewItem.SubItems[1].Text);
            author.Name = listViewItem.SubItems[2].Text;
            author.Description = listViewItem.SubItems[3].Text;
            author.CreateTime = DateTime.Parse(listViewItem.SubItems[4].Text);
            author.Cover = listViewItem.SubItems[5].Text;
            return author;
        }

        /// <summary>
        /// Check exist author
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return true if exist and vice versa</returns>
        private bool CheckIdExist(int id)
        {
            AuthorViewModel author = mAuthorBusiness.GetAuthorById(id);
            return author != null ? true : false;
        }
        #endregion

        #region Events

        /// <summary>
        /// Load data for grid and set status of control
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">EventArgs object</param>
        private void ListAuthor_Load(object sender, EventArgs e)
        {
            //Init control
            InitControl(String.Empty);

            //Load data
            bool loadData = InitData();
            if (!loadData)
            {
                MessageBox.Show("Load Data Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handle process  Close_Form: Close this form and display parent form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Author_FormClosed(object sender, FormClosedEventArgs e)
        {
            mParentForm.Show();
        }

        /// <summary>
        /// lvAuthor_SelectedIndexChanged event
        /// 1. Display text to control for user can update, delete.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvAuthor_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            AuthorViewModel author = GetAuthorFromListView(e.Item);
            InitControl(Constants.ACTION_VIEW);

            this.txtAuthorID.Text = author.Id.ToString();
            this.txtAuthorName.Text = author.Name;
            this.rtbDescription.Text = author.Description;
            this.lblCreateTime.Text = author.CreateTime.ToString();
            if (!string.IsNullOrEmpty(author.Cover))
            {
                string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

                this.ptbAvatar.ImageLocation = paths + author.Cover;
            }

        }

        /// <summary>
        /// The process create a author
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            InitControl(Constants.ACTION_CREATE);
            this.txtAuthorID.Text = (mAuthorBusiness.GetMaxId() + 1).ToString();



        }

        /// <summary>
        /// Handle process update an author
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.InitControl(Constants.ACTION_UPDATE);

        }

        /// <summary>
        /// Handle process delete an author
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want delete the author", "Confrim", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                this.mAction = Constants.ACTION_DELETE;
                btnSave.PerformClick();
            }

        }

        /// <summary>
        /// Handle process save an author
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Declace variable
            AuthorViewModel authorViewModel = new AuthorViewModel();

            //Resut insert
            bool result = false;

            try
            {
                //Validation 
                // Check author id
                if (!mAction.Equals(Constants.ACTION_DELETE) && !mAction.Equals(Constants.ACTION_VIEW))
                {
                    if (String.IsNullOrEmpty(this.txtAuthorName.Text.Trim()))
                    {
                        MessageBox.Show("Author ID cannot Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtAuthorID.Focus();
                        return;
                    }

                    //Check author name
                    if (string.IsNullOrEmpty(this.txtAuthorName.Text.Trim()))
                    {
                        MessageBox.Show("Please Input Author Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtAuthorName.Focus();
                        return;
                    }
                }


                //Get author infor from control
                authorViewModel.Id = Convert.ToInt32(this.txtAuthorID.Text);
                authorViewModel.Name = this.txtAuthorName.Text;
                authorViewModel.Description = this.rtbDescription.Text;

                //Cpy image
                FileInfo img = new FileInfo(ptbAvatar.ImageLocation);

                string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                string newFileName = String.Format("{0}{1}", DateTime.Now.ToString(Constants.DATE_FORMAT_2), img.Extension);
                string newAvatarUrl = String.Format("{0}{1}", Constants.IMAGES_FOLDER_ROOT, newFileName);
                if (!newAvatarUrl.Equals(lblOldAvatarUrl.Text))
                {
                    File.Copy(ptbAvatar.ImageLocation, paths + Constants.IMAGES_FOLDER_ROOT + newFileName, true);
                    authorViewModel.Cover = newAvatarUrl;
                }
                else
                {
                    authorViewModel.Cover = lblOldAvatarUrl.Text;
                }

                switch (mAction)
                {
                    case Constants.ACTION_UPDATE:
                        if (CheckIdExist(authorViewModel.Id))
                        {
                            //Update author
                            authorViewModel.CreateTime = DateTime.Parse(this.lblCreateTime.Text);
                            authorViewModel.LastUpdateTime = DateTime.Now;
                            authorViewModel.DelFlag = false;
                            result = mAuthorBusiness.EditAuthor(authorViewModel);
                            if (result)
                            {
                                MessageBox.Show("Update author successfuly", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Update author error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                    case Constants.ACTION_CREATE:
                        authorViewModel.CreateTime = DateTime.Now;
                        authorViewModel.DelFlag = false;
                        result = mAuthorBusiness.CreateAuthor(authorViewModel);
                        if (result)
                        {
                            MessageBox.Show("Create author successfuly", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Create author error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case Constants.ACTION_DELETE:
                        //Update author
                        authorViewModel.DelFlag = true;
                        authorViewModel.CreateTime = DateTime.Parse(this.lblCreateTime.Text);
                        authorViewModel.LastUpdateTime = DateTime.Now;
                        result = mAuthorBusiness.EditAuthor(authorViewModel);
                        if (result)
                        {
                            MessageBox.Show("Delete author successfuly", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Delete author error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    default:
                        break;
                }
                if (result)
                    btnReload.PerformClick();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Todo: Log
            }
        }

        /// <summary>
        /// Reset value of control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtAuthorID.Text = string.Empty;
            this.txtAuthorName.Text = string.Empty;
            this.rtbDescription.Text = string.Empty;
            this.ptbAvatar.ImageLocation = string.Empty;
            this.ptbAvatar.Image = null;
        }

        /// <summary>
        /// Reload data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReload_Click(object sender, EventArgs e)
        {
            //Init control
            InitControl(String.Empty);

            //Load data
            bool loadData = InitData();
            if (!loadData)
            {
                MessageBox.Show("Load Data Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Get cover for author
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangeCover_Click(object sender, EventArgs e)
        {
            // Wrap the creation of the OpenFileDialog instance in a using statement,
            // rather than manually calling the Dispose method to ensure proper disposal
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

                if (dlg.ShowDialog() == DialogResult.OK)
                {

                    // Create a new Bitmap object from the picture file on disk,
                    // and assign that to the PictureBox.Image property
                    ptbAvatar.ImageLocation = dlg.FileName;
                }
            }
        }
        #endregion

    }
}
