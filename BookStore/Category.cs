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
using Utilities;

namespace BookStoreScreen
{
    public partial class Category : MasterForm
    {
        #region Variable definition
        private string mAction = String.Empty;
        private Form mParentForm = null;
        private CategoryBusiness mCategoryBusiness;
        private int mRowSelectedIndex = 0;
        #endregion

        #region Constructor
        public Category(Form parentForm)
            : base("Category")
        {
            InitializeComponent();
            mCategoryBusiness = new CategoryBusiness();
            mParentForm = parentForm;
        }

        public Category()
        {
            InitializeComponent();

        }
        #endregion

        #region Methods
        /// <summary>
        /// Set status of control
        /// </summary>
        /// <param name="action">Action name:Create,Update, Delete</param>
        private void InitControl(string action)
        {
            switch (action)
            {
                case Constants.ACTION_CREATE:
                    this.txtID.ReadOnly = true;
                    this.txtName.ReadOnly = false;
                    this.rtbDescription.Enabled = false;

                    this.txtID.Enabled = false;
                    this.txtName.Enabled = true;
                    this.rtbDescription.Enabled = true;

                    this.txtID.Text = String.Empty;
                    this.txtName.Text = String.Empty;
                    this.rtbDescription.Text = String.Empty;

                    this.btnUpdate.Enabled = false;
                    this.btnCreate.Enabled = false;
                    this.btnSave.Enabled = true;
                    this.btnClear.Enabled = true;
                    this.AcceptButton = btnSave;
                    this.btnSave.Focus();
                    this.mAction = Constants.ACTION_CREATE;
                    break;
                case Constants.ACTION_UPDATE:
                    this.txtID.ReadOnly = true;
                    this.txtName.ReadOnly = false;
                    this.rtbDescription.Enabled = false;

                    this.txtID.Enabled = false;
                    this.txtName.Enabled = true;
                    this.rtbDescription.Enabled = true;

                    this.btnUpdate.Enabled = false;
                    this.btnCreate.Enabled = false;
                    this.btnSave.Enabled = true;
                    this.btnClear.Enabled = true;
                     this.AcceptButton = btnSave;
                    this.btnSave.Focus();
                    this.mAction = Constants.ACTION_UPDATE;
                    break;
                case Constants.ACTION_DELETE:                   
                case Constants.ACTION_VIEW:
                    this.txtID.ReadOnly = true;
                    this.txtName.ReadOnly = true;
                    this.rtbDescription.Enabled = true;

                    this.txtID.Enabled = false;
                    this.txtName.Enabled = false;
                    this.rtbDescription.Enabled = false;

                    this.btnUpdate.Enabled = true;
                    this.btnCreate.Enabled = true;
                    this.btnSave.Enabled = false;
                    this.btnClear.Enabled = false;
                    this.AcceptButton = btnReload;
                    this.btnReload.Focus();
                    this.mAction = Constants.ACTION_DELETE;
                    break;
                default:
                    this.txtID.ReadOnly = true;
                    this.txtName.ReadOnly = true;
                    this.rtbDescription.Enabled = true;

                    this.txtID.Enabled = false;
                    this.txtName.Enabled = false;
                    this.rtbDescription.Enabled = false;

                    this.btnCreate.Enabled = true;
                    this.btnUpdate.Enabled = false;
                    this.btnClear.Enabled = false;
                    this.btnSave.Enabled = false;
                    this.btnCreate.Focus();
                    break;
            }

            if (Program.UserViewModel.Role.Equals(Constants.ROLE_ADMIN) && lvDisplay.Items.Count > 0)
            {
                this.btnDelete.Enabled = true;
            }
            else
            {
                this.btnDelete.Enabled = false;
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
                lvDisplay.Items.Clear();

                //Get category list
                List<CategoryViewModel> lstAuthorViewModel = mCategoryBusiness.GetAll();

                if (lstAuthorViewModel != null && lstAuthorViewModel.Count > 0)
                {

                    for (int i = 0; i < lstAuthorViewModel.Count; i++)
                    {
                        ListViewItem lvItem = new ListViewItem((i + 1).ToString());
                        lvItem.SubItems.Add(lstAuthorViewModel[i].Id.ToString());
                        lvItem.SubItems.Add(lstAuthorViewModel[i].Title);
                        lvItem.SubItems.Add(lstAuthorViewModel[i].Description);
                        lvItem.SubItems.Add(lstAuthorViewModel[i].CreateTime.ToString(Constants.DATE_FORMAT_1));
                        lvDisplay.Items.Add(lvItem);
                    }
                    this.SetSelectedItem(this.mRowSelectedIndex);
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
            lvDisplay.Items[index].Selected = true;
            lvDisplay.Items[index].Focused = true;
        }

        /// <summary>
        /// Get Category information form grid
        /// </summary>
        /// <param name="listViewItem">ListViewItem</param>
        /// <returns>CategoryViewModel object</returns>
        private CategoryViewModel GetAuthorFromListView(ListViewItem listViewItem)
        {
            CategoryViewModel category = new CategoryViewModel();
            category.Id = Convert.ToInt32(listViewItem.SubItems[1].Text);
            category.Title = listViewItem.SubItems[2].Text;
            category.Description = listViewItem.SubItems[3].Text;
            category.CreateTime = DateTime.Parse(listViewItem.SubItems[4].Text);
            return category;
        }


        #endregion

        #region Events

        private void Category_Load(object sender, EventArgs e)
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
        private void Category_FormClosed(object sender, FormClosedEventArgs e)
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
            this.InitControl(Constants.ACTION_VIEW);
            CategoryViewModel category = GetAuthorFromListView(e.Item);
            this.txtID.Text = category.Id.ToString();
            this.txtName.Text = category.Title;
            this.rtbDescription.Text = category.Description;
            this.lblCreateTime.Text = category.CreateTime.ToString();
            this.mRowSelectedIndex = e.ItemIndex;

        }

        /// <summary>
        /// The process create a category
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            InitControl(Constants.ACTION_CREATE);
            this.txtID.Text = (mCategoryBusiness.GetMaxId() + 1).ToString();

        }

        /// <summary>
        /// Handle process update an category
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.InitControl(Constants.ACTION_UPDATE);

        }

        /// <summary>
        /// Handle process delete an category
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.mAction = Constants.ACTION_DELETE;
            btnSave.PerformClick();
        }

        /// <summary>
        /// Handle process save an category
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Declace variable
            CategoryViewModel categoryViewModel = new CategoryViewModel();

            //Resut insert
            bool result = false;

            try
            {
                //Validation 
                // Check category id
                if (!mAction.Equals(Constants.ACTION_DELETE) && !mAction.Equals(Constants.ACTION_VIEW))
                {
                    if (String.IsNullOrEmpty(this.txtName.Text.Trim()))
                    {
                        MessageBox.Show("Category ID cannot Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtID.Focus();
                        return;
                    }

                    //Check category name
                    if (string.IsNullOrEmpty(this.txtName.Text.Trim()))
                    {
                        MessageBox.Show("Please Input Category Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtName.Focus();
                        return;
                    }
                }


                //Get category infor from control
                categoryViewModel.Id = Convert.ToInt32(this.txtID.Text);
                categoryViewModel.Title = this.txtName.Text;
                categoryViewModel.Description = this.rtbDescription.Text;
                categoryViewModel.DelFlag = false;
                switch (mAction)
                {
                    case Constants.ACTION_UPDATE:
                        if (CheckIdExist(categoryViewModel.Id))
                        {
                            //Update category
                            categoryViewModel.CreateTime = DateTime.Parse(this.lblCreateTime.Text);
                            categoryViewModel.LastUpdateTime = DateTime.Now;
                            result = mCategoryBusiness.Edit(categoryViewModel);
                            if (result)
                            {
                                MessageBox.Show("Update category successfuly", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Update category error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                    case Constants.ACTION_CREATE:
                        categoryViewModel.CreateTime = DateTime.Now;
                        categoryViewModel.LastUpdateTime = DateTime.Now;
                        result = mCategoryBusiness.Create(categoryViewModel);
                        if (result)
                        {
                            MessageBox.Show("Create category successfuly", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Create category error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case Constants.ACTION_DELETE:
                        //Update category
                        categoryViewModel.DelFlag = true;
                        categoryViewModel.CreateTime = DateTime.Parse(this.lblCreateTime.Text);
                        categoryViewModel.LastUpdateTime = DateTime.Now;
                        result = mCategoryBusiness.Edit(categoryViewModel);
                        if (result)
                        {
                            MessageBox.Show("Delete category successfuly", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Delete category error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.txtID.Text = string.Empty;
            this.txtName.Text = string.Empty;
            this.rtbDescription.Text = string.Empty;

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
        /// Check exist category
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return true if exist and vice versa</returns>
        private bool CheckIdExist(int id)
        {
            CategoryViewModel category = mCategoryBusiness.GetById(id);
            return category != null ? true : false;
        }

        #endregion


    }
}
