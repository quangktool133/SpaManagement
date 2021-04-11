
namespace QuanLySpa
{
    partial class fAdmin
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
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.panel18 = new System.Windows.Forms.Panel();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.panel21 = new System.Windows.Forms.Panel();
            this.numericUpDownAccountType = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.txbDisplayName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel27 = new System.Windows.Forms.Panel();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel28 = new System.Windows.Forms.Panel();
            this.btnShowAccount = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.panel29 = new System.Windows.Forms.Panel();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.tpService = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txbSearchServiceName = new System.Windows.Forms.TextBox();
            this.btnSearchService = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.nmServicePrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cbServiceCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txbServiceName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txbServiceID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnShowService = new System.Windows.Forms.Button();
            this.btnEditService = new System.Windows.Forms.Button();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvService = new System.Windows.Forms.DataGridView();
            this.tpBill = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnViewBill = new System.Windows.Forms.Button();
            this.dtpkToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkFromDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.tcServiceCategory = new System.Windows.Forms.TabControl();
            this.tpAccount.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccountType)).BeginInit();
            this.panel22.SuspendLayout();
            this.panel27.SuspendLayout();
            this.panel28.SuspendLayout();
            this.panel29.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.tpService.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmServicePrice)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvService)).BeginInit();
            this.tpBill.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.tcServiceCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpAccount
            // 
            this.tpAccount.Controls.Add(this.panel18);
            this.tpAccount.Controls.Add(this.panel28);
            this.tpAccount.Controls.Add(this.panel29);
            this.tpAccount.Location = new System.Drawing.Point(4, 25);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccount.Size = new System.Drawing.Size(902, 533);
            this.tpAccount.TabIndex = 4;
            this.tpAccount.Text = "Tài Khoản";
            this.tpAccount.UseVisualStyleBackColor = true;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.btnResetPassword);
            this.panel18.Controls.Add(this.panel21);
            this.panel18.Controls.Add(this.panel22);
            this.panel18.Controls.Add(this.panel27);
            this.panel18.Location = new System.Drawing.Point(475, 84);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(421, 447);
            this.panel18.TabIndex = 6;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(247, 204);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(162, 53);
            this.btnResetPassword.TabIndex = 7;
            this.btnResetPassword.Text = "Đặt Lại Mật Khẩu";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.numericUpDownAccountType);
            this.panel21.Controls.Add(this.label9);
            this.panel21.Location = new System.Drawing.Point(13, 130);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(396, 57);
            this.panel21.TabIndex = 6;
            // 
            // numericUpDownAccountType
            // 
            this.numericUpDownAccountType.Location = new System.Drawing.Point(165, 20);
            this.numericUpDownAccountType.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAccountType.Name = "numericUpDownAccountType";
            this.numericUpDownAccountType.Size = new System.Drawing.Size(48, 22);
            this.numericUpDownAccountType.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Loại Tài Khoản : ";
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.txbDisplayName);
            this.panel22.Controls.Add(this.label10);
            this.panel22.Location = new System.Drawing.Point(13, 67);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(396, 57);
            this.panel22.TabIndex = 5;
            // 
            // txbDisplayName
            // 
            this.txbDisplayName.Location = new System.Drawing.Point(165, 19);
            this.txbDisplayName.Name = "txbDisplayName";
            this.txbDisplayName.Size = new System.Drawing.Size(208, 22);
            this.txbDisplayName.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tên Hiển Thị : ";
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.txbUserName);
            this.panel27.Controls.Add(this.label13);
            this.panel27.Location = new System.Drawing.Point(13, 4);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(396, 57);
            this.panel27.TabIndex = 4;
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(165, 20);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(208, 22);
            this.txbUserName.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tên Tài Khoản : ";
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.btnShowAccount);
            this.panel28.Controls.Add(this.btnEditAccount);
            this.panel28.Controls.Add(this.btnDeleteAccount);
            this.panel28.Controls.Add(this.btnAddAccount);
            this.panel28.Location = new System.Drawing.Point(9, 4);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(460, 78);
            this.panel28.TabIndex = 5;
            // 
            // btnShowAccount
            // 
            this.btnShowAccount.Location = new System.Drawing.Point(348, 12);
            this.btnShowAccount.Name = "btnShowAccount";
            this.btnShowAccount.Size = new System.Drawing.Size(109, 53);
            this.btnShowAccount.TabIndex = 3;
            this.btnShowAccount.Text = "Xem";
            this.btnShowAccount.UseVisualStyleBackColor = true;
            this.btnShowAccount.Click += new System.EventHandler(this.btnShowAccount_Click);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Location = new System.Drawing.Point(233, 12);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(109, 53);
            this.btnEditAccount.TabIndex = 2;
            this.btnEditAccount.Text = "Sửa";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(118, 12);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(109, 53);
            this.btnDeleteAccount.TabIndex = 1;
            this.btnDeleteAccount.Text = "Xóa ";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(3, 12);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(109, 53);
            this.btnAddAccount.TabIndex = 0;
            this.btnAddAccount.Text = "Thêm ";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // panel29
            // 
            this.panel29.Controls.Add(this.dtgvAccount);
            this.panel29.Location = new System.Drawing.Point(6, 84);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(463, 437);
            this.panel29.TabIndex = 4;
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Location = new System.Drawing.Point(3, 4);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.RowHeadersWidth = 51;
            this.dtgvAccount.RowTemplate.Height = 24;
            this.dtgvAccount.Size = new System.Drawing.Size(457, 430);
            this.dtgvAccount.TabIndex = 0;
            // 
            // tpService
            // 
            this.tpService.Controls.Add(this.panel6);
            this.tpService.Controls.Add(this.panel5);
            this.tpService.Controls.Add(this.panel4);
            this.tpService.Controls.Add(this.panel3);
            this.tpService.Location = new System.Drawing.Point(4, 25);
            this.tpService.Name = "tpService";
            this.tpService.Padding = new System.Windows.Forms.Padding(3);
            this.tpService.Size = new System.Drawing.Size(902, 533);
            this.tpService.TabIndex = 1;
            this.tpService.Text = "Dịch Vụ";
            this.tpService.UseVisualStyleBackColor = true;
            this.tpService.Click += new System.EventHandler(this.tpService_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txbSearchServiceName);
            this.panel6.Controls.Add(this.btnSearchService);
            this.panel6.Location = new System.Drawing.Point(475, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(421, 78);
            this.panel6.TabIndex = 3;
            // 
            // txbSearchServiceName
            // 
            this.txbSearchServiceName.Location = new System.Drawing.Point(13, 27);
            this.txbSearchServiceName.Name = "txbSearchServiceName";
            this.txbSearchServiceName.Size = new System.Drawing.Size(290, 22);
            this.txbSearchServiceName.TabIndex = 1;
            // 
            // btnSearchService
            // 
            this.btnSearchService.Location = new System.Drawing.Point(309, 12);
            this.btnSearchService.Name = "btnSearchService";
            this.btnSearchService.Size = new System.Drawing.Size(109, 53);
            this.btnSearchService.TabIndex = 2;
            this.btnSearchService.Text = "Tìm";
            this.btnSearchService.UseVisualStyleBackColor = true;
            this.btnSearchService.Click += new System.EventHandler(this.btnSearchService_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Location = new System.Drawing.Point(475, 90);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(421, 447);
            this.panel5.TabIndex = 2;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.nmServicePrice);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Location = new System.Drawing.Point(12, 195);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(396, 57);
            this.panel10.TabIndex = 7;
            // 
            // nmServicePrice
            // 
            this.nmServicePrice.Location = new System.Drawing.Point(145, 20);
            this.nmServicePrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmServicePrice.Name = "nmServicePrice";
            this.nmServicePrice.Size = new System.Drawing.Size(231, 22);
            this.nmServicePrice.TabIndex = 1;
            this.nmServicePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá : ";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.cbServiceCategory);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Location = new System.Drawing.Point(13, 130);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(396, 57);
            this.panel9.TabIndex = 6;
            // 
            // cbServiceCategory
            // 
            this.cbServiceCategory.FormattingEnabled = true;
            this.cbServiceCategory.Location = new System.Drawing.Point(144, 20);
            this.cbServiceCategory.Name = "cbServiceCategory";
            this.cbServiceCategory.Size = new System.Drawing.Size(231, 24);
            this.cbServiceCategory.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh Mục : ";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txbServiceName);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(13, 67);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(396, 57);
            this.panel8.TabIndex = 5;
            // 
            // txbServiceName
            // 
            this.txbServiceName.Location = new System.Drawing.Point(144, 20);
            this.txbServiceName.Name = "txbServiceName";
            this.txbServiceName.Size = new System.Drawing.Size(231, 22);
            this.txbServiceName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Dịch Vụ : ";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txbServiceID);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(13, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(396, 57);
            this.panel7.TabIndex = 4;
            // 
            // txbServiceID
            // 
            this.txbServiceID.Location = new System.Drawing.Point(144, 25);
            this.txbServiceID.Name = "txbServiceID";
            this.txbServiceID.ReadOnly = true;
            this.txbServiceID.Size = new System.Drawing.Size(231, 22);
            this.txbServiceID.TabIndex = 1;
            this.txbServiceID.TextChanged += new System.EventHandler(this.txbServiceID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID : ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnShowService);
            this.panel4.Controls.Add(this.btnEditService);
            this.panel4.Controls.Add(this.btnDeleteService);
            this.panel4.Controls.Add(this.btnAddService);
            this.panel4.Location = new System.Drawing.Point(9, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(460, 78);
            this.panel4.TabIndex = 1;
            // 
            // btnShowService
            // 
            this.btnShowService.Location = new System.Drawing.Point(348, 12);
            this.btnShowService.Name = "btnShowService";
            this.btnShowService.Size = new System.Drawing.Size(109, 53);
            this.btnShowService.TabIndex = 3;
            this.btnShowService.Text = "Xem";
            this.btnShowService.UseVisualStyleBackColor = true;
            this.btnShowService.Click += new System.EventHandler(this.btnShowService_Click);
            // 
            // btnEditService
            // 
            this.btnEditService.Location = new System.Drawing.Point(233, 12);
            this.btnEditService.Name = "btnEditService";
            this.btnEditService.Size = new System.Drawing.Size(109, 53);
            this.btnEditService.TabIndex = 2;
            this.btnEditService.Text = "Sửa";
            this.btnEditService.UseVisualStyleBackColor = true;
            this.btnEditService.Click += new System.EventHandler(this.btnEditService_Click);
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.Location = new System.Drawing.Point(118, 12);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(109, 53);
            this.btnDeleteService.TabIndex = 1;
            this.btnDeleteService.Text = "Xóa ";
            this.btnDeleteService.UseVisualStyleBackColor = true;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(3, 12);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(109, 53);
            this.btnAddService.TabIndex = 0;
            this.btnAddService.Text = "Thêm ";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvService);
            this.panel3.Location = new System.Drawing.Point(6, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(463, 437);
            this.panel3.TabIndex = 0;
            // 
            // dtgvService
            // 
            this.dtgvService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvService.Location = new System.Drawing.Point(3, 4);
            this.dtgvService.Name = "dtgvService";
            this.dtgvService.RowHeadersWidth = 51;
            this.dtgvService.RowTemplate.Height = 24;
            this.dtgvService.Size = new System.Drawing.Size(457, 430);
            this.dtgvService.TabIndex = 0;
            // 
            // tpBill
            // 
            this.tpBill.Controls.Add(this.panel2);
            this.tpBill.Controls.Add(this.panel1);
            this.tpBill.Location = new System.Drawing.Point(4, 25);
            this.tpBill.Name = "tpBill";
            this.tpBill.Padding = new System.Windows.Forms.Padding(3);
            this.tpBill.Size = new System.Drawing.Size(902, 533);
            this.tpBill.TabIndex = 0;
            this.tpBill.Text = "Doanh Thu";
            this.tpBill.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnViewBill);
            this.panel2.Controls.Add(this.dtpkToDate);
            this.panel2.Controls.Add(this.dtpkFromDate);
            this.panel2.Location = new System.Drawing.Point(3, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(890, 33);
            this.panel2.TabIndex = 2;
            // 
            // btnViewBill
            // 
            this.btnViewBill.Location = new System.Drawing.Point(398, 3);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(118, 27);
            this.btnViewBill.TabIndex = 2;
            this.btnViewBill.Text = "Thống Kê";
            this.btnViewBill.UseVisualStyleBackColor = true;
            this.btnViewBill.Click += new System.EventHandler(this.btnViewBill_Click);
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.Location = new System.Drawing.Point(589, 3);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(298, 22);
            this.dtpkToDate.TabIndex = 1;
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.Location = new System.Drawing.Point(3, 3);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(298, 22);
            this.dtpkFromDate.TabIndex = 0;
            this.dtpkFromDate.ValueChanged += new System.EventHandler(this.dtpkFromDate_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvBill);
            this.panel1.Location = new System.Drawing.Point(3, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 482);
            this.panel1.TabIndex = 1;
            // 
            // dtgvBill
            // 
            this.dtgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Location = new System.Drawing.Point(3, 3);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.RowHeadersWidth = 51;
            this.dtgvBill.RowTemplate.Height = 24;
            this.dtgvBill.Size = new System.Drawing.Size(887, 476);
            this.dtgvBill.TabIndex = 0;
            // 
            // tcServiceCategory
            // 
            this.tcServiceCategory.Controls.Add(this.tpBill);
            this.tcServiceCategory.Controls.Add(this.tpService);
            this.tcServiceCategory.Controls.Add(this.tpAccount);
            this.tcServiceCategory.Location = new System.Drawing.Point(12, 12);
            this.tcServiceCategory.Name = "tcServiceCategory";
            this.tcServiceCategory.SelectedIndex = 0;
            this.tcServiceCategory.Size = new System.Drawing.Size(910, 562);
            this.tcServiceCategory.TabIndex = 0;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 605);
            this.Controls.Add(this.tcServiceCategory);
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.fAdmin_Load);
            this.tpAccount.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccountType)).EndInit();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.panel27.ResumeLayout(false);
            this.panel27.PerformLayout();
            this.panel28.ResumeLayout(false);
            this.panel29.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.tpService.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmServicePrice)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvService)).EndInit();
            this.tpBill.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.tcServiceCategory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpAccount;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.TextBox txbDisplayName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.Button btnShowAccount;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.TabPage tpService;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txbSearchServiceName;
        private System.Windows.Forms.Button btnSearchService;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.NumericUpDown nmServicePrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox cbServiceCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txbServiceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txbServiceID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnShowService;
        private System.Windows.Forms.Button btnEditService;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvService;
        private System.Windows.Forms.TabPage tpBill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnViewBill;
        private System.Windows.Forms.DateTimePicker dtpkToDate;
        private System.Windows.Forms.DateTimePicker dtpkFromDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.TabControl tcServiceCategory;
        private System.Windows.Forms.NumericUpDown numericUpDownAccountType;
    }
}