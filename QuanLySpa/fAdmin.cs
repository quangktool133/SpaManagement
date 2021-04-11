using QuanLySpa.DAO;
using QuanLySpa.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySpa
{
    public partial class fAdmin : Form
    {
        BindingSource serviceList = new BindingSource();
        BindingSource accountList = new BindingSource();



        public Account loginAccount;
        public fAdmin()
        {
            InitializeComponent();
            LoadData();
        }

         private void panel5_Paint(object sender, PaintEventArgs e)
         {

         }

         private void tpService_Click(object sender, EventArgs e)
         {

         }

        private void fAdmin_Load(object sender, EventArgs e)
        {

        }


        #region methods

        List<Service> SearchServiceByName(string name)
        {
            List<Service> listFood = ServiceDAO.Instance.SearchServiceByName(name);

            return listFood;
        }



        void LoadData()
        {
            dtgvService.DataSource = serviceList;
            dtgvAccount.DataSource = accountList;

            LoadDateTimePickerBill();
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            LoadListService();
            LoadAccount();
            AddServiceBinding();
            AddAccountBinding();
            LoadCategoryIntoCombobox(cbServiceCategory);
        }

        void AddAccountBinding()
        {
            txbUserName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txbDisplayName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));          
            numericUpDownAccountType.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }

        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }




        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }

        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListByDay(checkIn, checkOut);
        }

        void AddServiceBinding()
        {
            txbServiceName.DataBindings.Add(new Binding("Text", dtgvService.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbServiceID.DataBindings.Add(new Binding("Text", dtgvService.DataSource, "ID", true, DataSourceUpdateMode.Never));
            nmServicePrice.DataBindings.Add(new Binding("Value", dtgvService.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }

        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }


        void AddAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công. Mật khẩu của bạn là: 0");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }

            LoadAccount();
        }

        void EditAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.UpdateAccount(userName, displayName, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }

            LoadAccount();
        }

        void DeleteAccount(string userName)
        {
            if (loginAccount.UserName.Equals(userName))
            {
                MessageBox.Show("Vui lòng đừng xóa chính bạn chứ");
                return;
            }
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }

            LoadAccount();
        }

        void ResetPass(string userName)
        {
            if (AccountDAO.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại");
            }
        }

        #endregion

        #region events
        private void btnViewBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }

        void LoadListService()
        {
            serviceList.DataSource = ServiceDAO.Instance.GetListService();
        }

        private void btnShowService_Click(object sender, EventArgs e)
        {
            LoadListService();
        }

        private void txbServiceID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvService.SelectedCells.Count > 0)
                {
                    int id = (int)dtgvService.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;

                    Category cateogory = CategoryDAO.Instance.GetCategoryByID(id);

                    cbServiceCategory.SelectedItem = cateogory;

                    int index = -1;
                    int i = 0;
                    foreach (Category item in cbServiceCategory.Items)
                    {
                        if (item.ID == cateogory.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }

                    cbServiceCategory.SelectedIndex = index;
                }
            }
            catch { }
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            string name = txbServiceName.Text;
            int categoryID = (cbServiceCategory.SelectedItem as Category).ID;
            float price = (float)nmServicePrice.Value;

            if (ServiceDAO.Instance.InsertService(name, categoryID, price))
            {
                MessageBox.Show("Thêm dịch vụ thành công");
                LoadListService();
                if (insertService != null)
                    insertService(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm dịch vụ");
            }
        }

        private void btnEditService_Click(object sender, EventArgs e)
        {
            string name = txbServiceName.Text;
            int categoryID = (cbServiceCategory.SelectedItem as Category).ID;
            float price = (float)nmServicePrice.Value;
            int id = Convert.ToInt32(txbServiceID.Text);

            if (ServiceDAO.Instance.UpdateService(id, name, categoryID, price))
            {
                MessageBox.Show("Sửa dịch vụ thành công");
                LoadListService();
                if (updateService != null)
                    updateService(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa dịch vụ");
            }
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbServiceID.Text);

            if (ServiceDAO.Instance.DeleteService(id))
            {
                MessageBox.Show("Xóa dịch vụ thành công");
                LoadListService();
                if (deleteService != null)
                    deleteService(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa dịch vụ");
            }
        }

        private event EventHandler insertService;
        public event EventHandler InsertService
        {
            add { insertService += value; }
            remove { insertService -= value; }
        }

        private event EventHandler deleteService;
        public event EventHandler DeleteService
        {
            add { deleteService += value; }
            remove { deleteService -= value; }
        }

        private event EventHandler updateService;
        public event EventHandler UpdateService
        {
            add { updateService += value; }
            remove { updateService -= value; }
        }



        private void btnSearchService_Click(object sender, EventArgs e)
        {
           serviceList.DataSource =  SearchServiceByName(txbSearchServiceName.Text);
        }

        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string displayName = txbDisplayName.Text;
            int type = (int)numericUpDownAccountType.Value;

            AddAccount(userName, displayName, type);
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;

            DeleteAccount(userName);
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string displayName = txbDisplayName.Text;
            int type = (int)numericUpDownAccountType.Value;

            EditAccount(userName, displayName, type);
        }
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;

            ResetPass(userName);
        }


        #endregion

        private void dtpkFromDate_ValueChanged(object sender, EventArgs e)
        {

        }
    } 
    }

