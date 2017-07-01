using BookStoreBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace BookStoreScreen
{
    public partial class Books : MasterForm
    {
        #region Declace variable
        //Declace variable
        IAuthorBusiness mAuthorBusiness { get; set; }
        IBookBusiness mBookBusiness { get; set; }
        ICategoryBusiness mCategoryBusiness { get; set; }
        List<CategoryViewModel> mListCategory = null;
        List<AuthorViewModel> mListAuthor = null;
        List<int> mListYear = null;

        string mAction { get; set; }
        private Form mParentForm = null;
        #endregion

        #region Methods

        //Contructor
        public Books()
            : base("Books")
        {
            InitializeComponent();
            this.mAuthorBusiness = new AuthorBusiness();
            this.mBookBusiness = new BookBusiness();
            this.mCategoryBusiness = new CategoryBusiness();

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
                    this.txtID.ReadOnly = true;
                    this.txtName.ReadOnly = false;
                    this.rtbDescription.Enabled = false;
                    this.txtPublisher.ReadOnly = false;

                    this.cmbYear.Enabled = true;
                    this.txtID.Enabled = false;
                    this.txtName.Enabled = true;
                    this.rtbDescription.Enabled = true;
                    this.cmbAuthor.Enabled = true;
                    this.cmbCategory.Enabled = true;
                    this.txtPublisher.Enabled = true;

                    this.txtID.Text = String.Empty;
                    this.txtName.Text = String.Empty;
                    this.rtbDescription.Text = String.Empty;
                    this.lblOldCoverUrl.Text = string.Empty;
                    this.ptbCover.Image = null;

                    this.btnCover.Enabled = true;
                    this.btnUpdate.Enabled = false;
                    this.btnCreate.Enabled = false;
                    this.btnDelete.Enabled = false;
                    this.btnSave.Enabled = true;
                    this.btnClear.Enabled = true;
                    this.mAction = Constants.ACTION_CREATE;
                    break;
                case Constants.ACTION_UPDATE:
                    this.txtID.ReadOnly = true;
                    this.txtName.ReadOnly = false;
                    this.rtbDescription.Enabled = false;
                    this.txtPublisher.ReadOnly = false;

                    this.cmbYear.Enabled = true;
                    this.txtID.Enabled = false;
                    this.txtName.Enabled = true;
                    this.rtbDescription.Enabled = true;
                    this.cmbAuthor.Enabled = true;
                    this.cmbCategory.Enabled = true;
                    this.txtPublisher.Enabled = true;

                    this.btnCover.Enabled = true;
                    this.btnUpdate.Enabled = false;
                    this.btnCreate.Enabled = false;
                    this.btnDelete.Enabled = false;
                    this.btnSave.Enabled = true;
                    this.btnClear.Enabled = true;
                    this.mAction = Constants.ACTION_UPDATE;
                    break;
                case Constants.ACTION_DELETE:
                case Constants.ACTION_VIEW:
                    this.txtID.ReadOnly = true;
                    this.txtName.ReadOnly = true;
                    this.rtbDescription.Enabled = true;
                    this.txtPublisher.ReadOnly = true;

                    this.cmbYear.Enabled = false;
                    this.cmbAuthor.Enabled = false;
                    this.cmbCategory.Enabled = false;
                    this.txtPublisher.Enabled = false;
                    this.txtID.Enabled = false;
                    this.txtName.Enabled = false;
                    this.rtbDescription.Enabled = false;

                    this.btnUpdate.Enabled = true;
                    this.btnCreate.Enabled = true;
                    this.btnSave.Enabled = false;
                    this.btnClear.Enabled = false;
                    // Only Admin can delete 
                    if (Program.UserViewModel.Role.Equals(Constants.ROLE_ADMIN) && lvDisplay.Items.Count > 0)
                    {
                        this.btnDelete.Enabled = true;
                    }
                    else
                    {
                        this.btnDelete.Enabled = false;
                    }
                    break;

                default:
                    this.txtID.ReadOnly = true;
                    this.txtName.ReadOnly = true;
                    this.rtbDescription.Enabled = true;
                    this.txtPublisher.ReadOnly = true;

                    this.cmbYear.Enabled = false;
                    this.cmbAuthor.Enabled = false;
                    this.cmbCategory.Enabled = false;
                    this.txtPublisher.Enabled = false;
                    this.txtID.Enabled = false;
                    this.txtName.Enabled = false;
                    this.rtbDescription.Enabled = false;

                    this.btnCover.Enabled = false;
                    this.btnCreate.Enabled = true;
                    this.btnUpdate.Enabled = false;
                    this.btnClear.Enabled = false;
                    this.btnSave.Enabled = false;
                    // Only Admin can delete 
                    if (Program.UserViewModel.Role.Equals(Constants.ROLE_ADMIN) && lvDisplay.Items.Count > 0)
                    {
                        this.btnDelete.Enabled = true;
                    }
                    else
                    {
                        this.btnDelete.Enabled = false;
                    }
                    break;
            }



        }

        /// <summary>
        /// Load data
        /// </summary>
        /// <returns>True if sucessfull and vice versa</returns>
        private bool InitData(bool isSearch)
        {
            bool result = false;
            //Get  list book
            List<BookViewModel> lstBookViewModel = null;

            try
            {
                //Clear grid
                lvDisplay.Items.Clear();

                int categoryId = Convert.ToInt32(this.cmbCategorySearch.SelectedValue);
                int authorId =  Convert.ToInt32(this.cmbAuthorSearch.SelectedValue);
                int year =  Convert.ToInt32(this.cmbYearSearch.SelectedItem);
                string searchKey=this.txtSearchName.Text;
                if (!isSearch)
                {
                    lstBookViewModel = mBookBusiness.GetAll();

                }
                else
                {
                    lstBookViewModel = mBookBusiness.SearchBook(searchKey, categoryId, authorId, year);
                }


                //Get list Author 
                List<AuthorViewModel> lstAuthorViewModel = mAuthorBusiness.GetAllAuthor();

                //Get list Category 
                List<CategoryViewModel> lstCategoryViewModel = mCategoryBusiness.GetAll();

                //Binding to author combobox
                if (lstAuthorViewModel != null && lstAuthorViewModel.Count > 0)
                {
                    //add empty value
                    lstAuthorViewModel.Insert(0, new AuthorViewModel()
                    {
                        Id = 0,
                        Name = String.Empty
                    });

                    this.cmbAuthor.DataSource = new BindingSource(lstAuthorViewModel, null);
                    this.cmbAuthor.DisplayMember = "Name";
                    this.cmbAuthor.ValueMember = "Id";

                    this.cmbAuthorSearch.DataSource = new BindingSource(lstAuthorViewModel, null);
                    this.cmbAuthorSearch.DisplayMember = "Name";
                    this.cmbAuthorSearch.ValueMember = "Id";

                    if (isSearch)
                    {
                        this.cmbAuthorSearch.SelectedIndex = lstAuthorViewModel.FindIndex(x => x.Id == authorId);
                    }
                    mListAuthor = lstAuthorViewModel;

                }

                // Binding to category combobox
                if (lstCategoryViewModel != null && lstCategoryViewModel.Count > 0)
                {

                    //add empty value
                    lstCategoryViewModel.Insert(0, new CategoryViewModel()
                    {
                        Id = 0,
                        Title = String.Empty
                    });
                    this.cmbCategory.DataSource = new BindingSource(lstCategoryViewModel, null);
                    this.cmbCategory.DisplayMember = "Title";
                    this.cmbCategory.ValueMember = "Id";

                    this.cmbCategorySearch.DataSource = new BindingSource(lstCategoryViewModel, null);
                    this.cmbCategorySearch.DisplayMember = "Title";
                    this.cmbCategorySearch.ValueMember = "Id";

                    if (isSearch)
                    {
                        this.cmbCategorySearch.SelectedIndex = lstCategoryViewModel.FindIndex(x => x.Id == categoryId);
                    }

                    mListCategory = lstCategoryViewModel;
                }

                //binding to grid
                if (lstBookViewModel != null && lstBookViewModel.Count > 0)
                {

                    for (int i = 0; i < lstBookViewModel.Count; i++)
                    {
                        ListViewItem lvItem = new ListViewItem((i + 1).ToString());
                        lvItem.SubItems.Add(lstBookViewModel[i].Id.ToString());
                        lvItem.SubItems.Add(lstBookViewModel[i].Title);
                        lvItem.SubItems.Add(lstBookViewModel[i].Description);
                        lvItem.SubItems.Add(lstBookViewModel[i].CreateTime.ToString(Constants.DATE_FORMAT_1));
                        lvItem.SubItems.Add(lstBookViewModel[i].Cover);
                        lvItem.SubItems.Add(lstBookViewModel[i].Author.ToString());
                        lvItem.SubItems.Add(lstBookViewModel[i].Category.ToString());
                        lvItem.SubItems.Add(lstBookViewModel[i].Publisher);
                        lvItem.SubItems.Add(lstBookViewModel[i].Year.ToString());

                        lvDisplay.Items.Add(lvItem);
                    }
                    this.SetSelectedItem(0);
                }

                mListYear = new List<int>();
                // Add data for year combobox
                for (int i = 1920; i < DateTime.Now.Year; i++)
                {

                    cmbYearSearch.Items.Add(i.ToString());
                    cmbYear.Items.Add(i.ToString());
                    mListYear.Add(i);
                }
                if (isSearch)
                {
                    this.cmbYear.SelectedIndex = mListYear.FindIndex(x => x == year);
                    this.txtSearchName.Text = searchKey;
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
        /// Get Book information form grid
        /// </summary>
        /// <param name="listViewItem">ListViewItem</param>
        /// <returns>BookViewModel object</returns>
        private BookViewModel GetAuthorFromListView(ListViewItem listViewItem)
        {
            BookViewModel book = new BookViewModel();
            book.Id = Convert.ToInt32(listViewItem.SubItems[1].Text);
            book.Title = listViewItem.SubItems[2].Text;
            book.Description = listViewItem.SubItems[3].Text;
            book.CreateTime = DateTime.Parse(listViewItem.SubItems[4].Text);
            book.Cover = listViewItem.SubItems[5].Text;
            book.Author = Convert.ToInt32(listViewItem.SubItems[6].Text);
            book.Category = Convert.ToInt32(listViewItem.SubItems[7].Text);
            book.Publisher = listViewItem.SubItems[8].Text;
            book.Year = Convert.ToInt32(listViewItem.SubItems[9].Text);
            return book;

        }

        /// <summary>
        /// Check exist book
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return true if exist and vice versa</returns>
        private bool CheckIdExist(int id)
        {
            BookViewModel book = mBookBusiness.GetById(id);
            return book != null ? true : false;
        }
        #endregion

        #region Events

        /// <summary>
        /// Load data for grid and set status of control
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">EventArgs object</param>
        private void Book_Load(object sender, EventArgs e)
        {
            //Search flag
            bool isSearch = false;
            // setting event of btnSearch
            btnSearch.Click -= new EventHandler(btnSearch_Click);

            //Init control
            InitControl(String.Empty);

            //Load data
            bool loadData = InitData(isSearch);
            if (!loadData)
            {
                MessageBox.Show("Load Data Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // setting event of btnSearch
            btnSearch.Click += new EventHandler(btnSearch_Click);
        }

        /// <summary>
        /// Handle process  Close_Form: Close this form and display parent form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Book_FormClosed(object sender, FormClosedEventArgs e)
        {
            mParentForm.Show();
        }

        /// <summary>
        /// lvAuthor_SelectedIndexChanged event
        /// 1. Display text to control for user can update, delete.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvDisplay_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            BookViewModel book = GetAuthorFromListView(e.Item);
            InitControl(Constants.ACTION_VIEW);

            this.txtID.Text = book.Id.ToString();
            this.txtName.Text = book.Title;
            this.rtbDescription.Text = book.Description;
            this.lblCreateTime.Text = book.CreateTime.ToString();
            this.lblPublisher.Text = book.Publisher;
            this.lblOldCoverUrl.Text = book.Cover;

            if (!string.IsNullOrEmpty(book.Cover))
            {
                string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

                this.ptbCover.ImageLocation = paths + book.Cover;
            }

            if (mListAuthor != null && mListAuthor.Count > 0)
            {
                int index = mListAuthor.FindIndex(x => x.Id == book.Id);
                this.cmbAuthor.SelectedIndex = index;
            }

            if (mListCategory != null && mListCategory.Count > 0)
            {
                int index = mListCategory.FindIndex(x => x.Id == book.Id);
                this.cmbCategory.SelectedIndex = index;
            }
            if (mListYear != null && mListYear.Count > 0)
            {
                int index = mListYear.FindIndex(x => x == book.Year);
                this.cmbYear.SelectedIndex = index;
            }

        }

        /// <summary>
        /// The process create a book
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            InitControl("Create");
            this.txtID.Text = (mAuthorBusiness.GetMaxId() + 1).ToString();



        }

        /// <summary>
        /// Handle process update an book
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.InitControl("Update");

        }

        /// <summary>
        /// Handle process delete an book
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.mAction = Constants.ACTION_DELETE;
            btnSave.PerformClick();
        }

        /// <summary>
        /// Handle process save an book
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Declace variable
            BookViewModel bookViewModel = new BookViewModel();

            //Resut insert
            bool result = false;

            try
            {
                //Validation 
                // Check book id
                if (!mAction.Equals(Constants.ACTION_DELETE) && !mAction.Equals(Constants.ACTION_VIEW))
                {
                    if (String.IsNullOrEmpty(this.txtName.Text.Trim()))
                    {
                        MessageBox.Show("Book ID cannot blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtID.Focus();
                        return;
                    }

                    //Check book name
                    if (string.IsNullOrEmpty(this.txtName.Text.Trim()))
                    {
                        MessageBox.Show("Book Name cannot blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtName.Focus();
                        return;
                    }

                    //Check book Year
                    if (string.IsNullOrEmpty(this.cmbYear.SelectedItem.ToString()))
                    {
                        MessageBox.Show("Year cannot blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.cmbYear.Focus();
                        return;
                    }

                    //Check book Author
                    if (string.IsNullOrEmpty(this.cmbAuthor.SelectedValue.ToString()))
                    {
                        MessageBox.Show("Author cannot blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.cmbAuthor.Focus();
                        return;
                    }
                    //Check book Category
                    if (string.IsNullOrEmpty(this.cmbCategory.SelectedValue.ToString()))
                    {
                        MessageBox.Show("Category cannot blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.cmbCategory.Focus();
                        return;
                    }

                    //Check book publisher
                    if (string.IsNullOrEmpty(this.txtPublisher.Text.Trim()))
                    {
                        MessageBox.Show("Publisher cannot blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtPublisher.Focus();
                        return;
                    }
                }


                //Get book infor from control
                bookViewModel.Id = Convert.ToInt32(this.txtID.Text);
                bookViewModel.Title = this.txtName.Text;
                bookViewModel.Description = this.rtbDescription.Text;
                bookViewModel.Author = Convert.ToInt32(this.cmbAuthor.SelectedValue);
                bookViewModel.Category = Convert.ToInt32(this.cmbCategory.SelectedValue);
                bookViewModel.Publisher = txtPublisher.Text;
                bookViewModel.Year = Convert.ToInt32(cmbYear.SelectedItem);

                //Cpy image
                if (!string.IsNullOrEmpty(ptbCover.ImageLocation))
                {
                    FileInfo img = new FileInfo(ptbCover.ImageLocation);

                    string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    string newFileName = String.Format("{0}{1}", DateTime.Now.ToString(Constants.DATE_FORMAT_2), img.Extension);
                    string newAvatarUrl = String.Format("{0}{1}", Constants.IMAGES_FOLDER_ROOT, newFileName);
                    if (!newAvatarUrl.Equals(lblOldCoverUrl.Text))
                    {
                        File.Copy(ptbCover.ImageLocation, paths + Constants.IMAGES_FOLDER_ROOT + newFileName, true);
                        bookViewModel.Cover = newAvatarUrl;
                    }
                    else
                    {
                        bookViewModel.Cover = lblOldCoverUrl.Text;
                    }
                }
                else
                {
                    bookViewModel.Cover = lblOldCoverUrl.Text;
                }

                switch (mAction)
                {
                    case Constants.ACTION_UPDATE:
                        if (CheckIdExist(bookViewModel.Id))
                        {
                            //Update book
                            bookViewModel.CreateTime = DateTime.Parse(this.lblCreateTime.Text);
                            bookViewModel.LastUpdateTime = DateTime.Now;
                            bookViewModel.DelFlag = false;
                            result = mBookBusiness.Edit(bookViewModel);
                            if (result)
                            {
                                MessageBox.Show("Update book successfuly", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Update book error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                    case Constants.ACTION_CREATE:
                        bookViewModel.CreateTime = DateTime.Now;
                        bookViewModel.LastUpdateTime = DateTime.Now;
                        bookViewModel.DelFlag = false;

                        result = mBookBusiness.Create(bookViewModel);
                        if (result)
                        {
                            MessageBox.Show("Create book successfuly", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Create book error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case Constants.ACTION_DELETE:
                        //Update book
                        bookViewModel.DelFlag = true;
                        bookViewModel.CreateTime = DateTime.Parse(this.lblCreateTime.Text);
                        bookViewModel.LastUpdateTime = DateTime.Now;
                        result = mBookBusiness.Edit(bookViewModel);
                        if (result)
                        {
                            MessageBox.Show("Delete book successfuly", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Delete book error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        }

        /// <summary>
        /// Reload data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReload_Click(object sender, EventArgs e)
        {
            //Search flag
            bool isSearch = false;

            // setting event of btnSearch
            btnSearch.Click -= new EventHandler(btnSearch_Click);

            //Init control
            InitControl(String.Empty);

            //Load data
            bool loadData = InitData(isSearch);
            if (!loadData)
            {
                MessageBox.Show("Load Data Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // setting event of btnSearch
            btnSearch.Click += new EventHandler(btnSearch_Click);
        }

        /// <summary>
        /// Get cover for book
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
                    ptbCover.ImageLocation = dlg.FileName;
                }
            }
        }


        /// <summary>
        /// Event Click On button Search 
        /// Handle logic search book
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Search flag
            bool isSearch = true;

            try
            {
                //Load data
                bool loadData = InitData(isSearch);
                if (!loadData)
                {
                    MessageBox.Show("Load Data Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load Data Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Event SelectedIndexChanged on AuthorSearch 
        /// Handle logic search book by author
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbAuthorSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        /// <summary>
        /// Event SelectedIndexChanged on CategorySearch 
        /// Handle logic search book by category
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCategorySearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        /// <summary>
        /// Event YearSearch on AuthorSearch 
        /// Handle logic search book by year
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbYearSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        #endregion

    }
}