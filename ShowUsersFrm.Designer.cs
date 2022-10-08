namespace EPED
    {
    partial class ShowUsersFrm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label userEmailAddressLabel;
            System.Windows.Forms.Label userLevelLabel;
            System.Windows.Forms.Label userPasswordLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowUsersFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbl_usersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tbl_usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eped_db1DataSet = new EPED.eped_db1DataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbl_usersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tbl_usersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userEmailAddressTextBox = new System.Windows.Forms.TextBox();
            this.userPasswordTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.btnViewPW = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.pnlNewPassword = new System.Windows.Forms.Panel();
            this.btnSetPassword = new System.Windows.Forms.Button();
            this.txbVerifyPassword = new System.Windows.Forms.TextBox();
            this.txbNewPassword = new System.Windows.Forms.TextBox();
            this.txbCurPassword = new System.Windows.Forms.TextBox();
            this.userLevelComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSetAsDefaultUser = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnUpdateDatabase = new System.Windows.Forms.Button();
            this.tbl_usersTableAdapter = new EPED.eped_db1DataSetTableAdapters.tbl_usersTableAdapter();
            this.tableAdapterManager = new EPED.eped_db1DataSetTableAdapters.TableAdapterManager();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            userNameLabel = new System.Windows.Forms.Label();
            userEmailAddressLabel = new System.Windows.Forms.Label();
            userLevelLabel = new System.Windows.Forms.Label();
            userPasswordLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_usersBindingNavigator)).BeginInit();
            this.tbl_usersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eped_db1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_usersDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlNewPassword.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            userNameLabel.Location = new System.Drawing.Point(24, 24);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(69, 15);
            userNameLabel.TabIndex = 2;
            userNameLabel.Text = "User Name:";
            // 
            // userEmailAddressLabel
            // 
            userEmailAddressLabel.AutoSize = true;
            userEmailAddressLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userEmailAddressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            userEmailAddressLabel.Location = new System.Drawing.Point(24, 55);
            userEmailAddressLabel.Name = "userEmailAddressLabel";
            userEmailAddressLabel.Size = new System.Drawing.Size(116, 15);
            userEmailAddressLabel.TabIndex = 4;
            userEmailAddressLabel.Text = "User Email Address:";
            // 
            // userLevelLabel
            // 
            userLevelLabel.AutoSize = true;
            userLevelLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userLevelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            userLevelLabel.Location = new System.Drawing.Point(24, 85);
            userLevelLabel.Name = "userLevelLabel";
            userLevelLabel.Size = new System.Drawing.Size(65, 15);
            userLevelLabel.TabIndex = 6;
            userLevelLabel.Text = "User Level:";
            // 
            // userPasswordLabel
            // 
            userPasswordLabel.AutoSize = true;
            userPasswordLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            userPasswordLabel.Location = new System.Drawing.Point(24, 115);
            userPasswordLabel.Name = "userPasswordLabel";
            userPasswordLabel.Size = new System.Drawing.Size(92, 15);
            userPasswordLabel.TabIndex = 8;
            userPasswordLabel.Text = "User Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            label1.Location = new System.Drawing.Point(13, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(89, 15);
            label1.TabIndex = 11;
            label1.Text = "OLD Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            label2.Location = new System.Drawing.Point(12, 52);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(93, 15);
            label2.TabIndex = 13;
            label2.Text = "NEW Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            label3.Location = new System.Drawing.Point(12, 82);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(132, 15);
            label3.TabIndex = 15;
            label3.Text = "VERIFY NEW Password:";
            // 
            // tbl_usersBindingNavigator
            // 
            this.tbl_usersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbl_usersBindingNavigator.BindingSource = this.tbl_usersBindingSource;
            this.tbl_usersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbl_usersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbl_usersBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tbl_usersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tbl_usersBindingNavigatorSaveItem});
            this.tbl_usersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbl_usersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbl_usersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbl_usersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbl_usersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbl_usersBindingNavigator.Name = "tbl_usersBindingNavigator";
            this.tbl_usersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbl_usersBindingNavigator.Size = new System.Drawing.Size(1101, 29);
            this.tbl_usersBindingNavigator.TabIndex = 0;
            this.tbl_usersBindingNavigator.Text = "bindingNavigator1";
            this.tbl_usersBindingNavigator.Visible = false;
            this.tbl_usersBindingNavigator.RefreshItems += new System.EventHandler(this.tbl_usersBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 26);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // tbl_usersBindingSource
            // 
            this.tbl_usersBindingSource.DataMember = "tbl_users";
            this.tbl_usersBindingSource.DataSource = this.eped_db1DataSet;
            // 
            // eped_db1DataSet
            // 
            this.eped_db1DataSet.DataSetName = "eped_db1DataSet";
            this.eped_db1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 26);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 26);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 26);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 26);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 29);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(58, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 26);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 26);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // tbl_usersBindingNavigatorSaveItem
            // 
            this.tbl_usersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbl_usersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbl_usersBindingNavigatorSaveItem.Image")));
            this.tbl_usersBindingNavigatorSaveItem.Name = "tbl_usersBindingNavigatorSaveItem";
            this.tbl_usersBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 26);
            this.tbl_usersBindingNavigatorSaveItem.Text = "Save Data";
            this.tbl_usersBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbl_usersBindingNavigatorSaveItem_Click);
            // 
            // tbl_usersDataGridView
            // 
            this.tbl_usersDataGridView.AllowUserToAddRows = false;
            this.tbl_usersDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.tbl_usersDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tbl_usersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_usersDataGridView.AutoGenerateColumns = false;
            this.tbl_usersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tbl_usersDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.tbl_usersDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tbl_usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tbl_usersDataGridView.DataSource = this.tbl_usersBindingSource;
            this.tbl_usersDataGridView.Location = new System.Drawing.Point(14, 54);
            this.tbl_usersDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbl_usersDataGridView.Name = "tbl_usersDataGridView";
            this.tbl_usersDataGridView.RowHeadersWidth = 51;
            this.tbl_usersDataGridView.Size = new System.Drawing.Size(577, 446);
            this.tbl_usersDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "UserName";
            this.dataGridViewTextBoxColumn1.HeaderText = "UserName";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 90;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UserEmailAddress";
            this.dataGridViewTextBoxColumn2.HeaderText = "UserEmailAddress";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UserLevel";
            this.dataGridViewTextBoxColumn3.HeaderText = "UserLevel";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 86;
            // 
            // userEmailAddressTextBox
            // 
            this.userEmailAddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userEmailAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_usersBindingSource, "UserEmailAddress", true));
            this.userEmailAddressTextBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userEmailAddressTextBox.Location = new System.Drawing.Point(149, 52);
            this.userEmailAddressTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userEmailAddressTextBox.Name = "userEmailAddressTextBox";
            this.userEmailAddressTextBox.Size = new System.Drawing.Size(241, 23);
            this.userEmailAddressTextBox.TabIndex = 5;
            // 
            // userPasswordTextBox
            // 
            this.userPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_usersBindingSource, "UserPassword", true));
            this.userPasswordTextBox.Enabled = false;
            this.userPasswordTextBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPasswordTextBox.Location = new System.Drawing.Point(149, 112);
            this.userPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userPasswordTextBox.Name = "userPasswordTextBox";
            this.userPasswordTextBox.PasswordChar = '*';
            this.userPasswordTextBox.Size = new System.Drawing.Size(228, 23);
            this.userPasswordTextBox.TabIndex = 9;
            this.userPasswordTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.userPasswordTextBox_Validating);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.userNameTextBox);
            this.panel1.Controls.Add(this.btnViewPW);
            this.panel1.Controls.Add(this.btnChangePassword);
            this.panel1.Controls.Add(this.pnlNewPassword);
            this.panel1.Controls.Add(this.userLevelComboBox);
            this.panel1.Controls.Add(userNameLabel);
            this.panel1.Controls.Add(userEmailAddressLabel);
            this.panel1.Controls.Add(this.userEmailAddressTextBox);
            this.panel1.Controls.Add(userLevelLabel);
            this.panel1.Controls.Add(userPasswordLabel);
            this.panel1.Controls.Add(this.userPasswordTextBox);
            this.panel1.Location = new System.Drawing.Point(618, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 351);
            this.panel1.TabIndex = 10;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_usersBindingSource, "UserName", true));
            this.userNameTextBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(149, 21);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(241, 23);
            this.userNameTextBox.TabIndex = 16;
            // 
            // btnViewPW
            // 
            this.btnViewPW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnViewPW.Font = new System.Drawing.Font("Wingdings 2", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnViewPW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnViewPW.Location = new System.Drawing.Point(385, 112);
            this.btnViewPW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnViewPW.Name = "btnViewPW";
            this.btnViewPW.Size = new System.Drawing.Size(29, 22);
            this.btnViewPW.TabIndex = 15;
            this.btnViewPW.Text = "8";
            this.btnViewPW.UseVisualStyleBackColor = false;
            this.btnViewPW.Visible = false;
            this.btnViewPW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnViewPW_MouseDown);
            this.btnViewPW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnViewPW_MouseUp);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnChangePassword.Location = new System.Drawing.Point(149, 142);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(229, 26);
            this.btnChangePassword.TabIndex = 14;
            this.btnChangePassword.Text = "CHANGE PASSWORD";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.button3_Click);
            // 
            // pnlNewPassword
            // 
            this.pnlNewPassword.Controls.Add(this.btnSetPassword);
            this.pnlNewPassword.Controls.Add(label3);
            this.pnlNewPassword.Controls.Add(this.txbVerifyPassword);
            this.pnlNewPassword.Controls.Add(label2);
            this.pnlNewPassword.Controls.Add(this.txbNewPassword);
            this.pnlNewPassword.Controls.Add(label1);
            this.pnlNewPassword.Controls.Add(this.txbCurPassword);
            this.pnlNewPassword.Location = new System.Drawing.Point(13, 170);
            this.pnlNewPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlNewPassword.Name = "pnlNewPassword";
            this.pnlNewPassword.Size = new System.Drawing.Size(401, 158);
            this.pnlNewPassword.TabIndex = 13;
            this.pnlNewPassword.Visible = false;
            // 
            // btnSetPassword
            // 
            this.btnSetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnSetPassword.FlatAppearance.BorderSize = 0;
            this.btnSetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnSetPassword.Location = new System.Drawing.Point(166, 109);
            this.btnSetPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSetPassword.Name = "btnSetPassword";
            this.btnSetPassword.Size = new System.Drawing.Size(212, 26);
            this.btnSetPassword.TabIndex = 17;
            this.btnSetPassword.Text = "SAVE NEW PASSWORD";
            this.btnSetPassword.UseVisualStyleBackColor = false;
            this.btnSetPassword.Click += new System.EventHandler(this.btnSetPassword_Click);
            // 
            // txbVerifyPassword
            // 
            this.txbVerifyPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbVerifyPassword.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbVerifyPassword.Location = new System.Drawing.Point(166, 79);
            this.txbVerifyPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbVerifyPassword.Name = "txbVerifyPassword";
            this.txbVerifyPassword.PasswordChar = '*';
            this.txbVerifyPassword.Size = new System.Drawing.Size(212, 23);
            this.txbVerifyPassword.TabIndex = 16;
            this.txbVerifyPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txbVerifyPassword_Validating);
            // 
            // txbNewPassword
            // 
            this.txbNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNewPassword.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNewPassword.Location = new System.Drawing.Point(166, 49);
            this.txbNewPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbNewPassword.Name = "txbNewPassword";
            this.txbNewPassword.PasswordChar = '*';
            this.txbNewPassword.Size = new System.Drawing.Size(212, 23);
            this.txbNewPassword.TabIndex = 14;
            this.txbNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txbNewPassword_Validating);
            // 
            // txbCurPassword
            // 
            this.txbCurPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCurPassword.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCurPassword.Location = new System.Drawing.Point(166, 16);
            this.txbCurPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbCurPassword.Name = "txbCurPassword";
            this.txbCurPassword.PasswordChar = '*';
            this.txbCurPassword.Size = new System.Drawing.Size(213, 23);
            this.txbCurPassword.TabIndex = 12;
            this.txbCurPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txbCurPassword_Validating);
            // 
            // userLevelComboBox
            // 
            this.userLevelComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_usersBindingSource, "UserLevel", true));
            this.userLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.userLevelComboBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLevelComboBox.FormattingEnabled = true;
            this.userLevelComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.userLevelComboBox.Location = new System.Drawing.Point(149, 81);
            this.userLevelComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userLevelComboBox.Name = "userLevelComboBox";
            this.userLevelComboBox.Size = new System.Drawing.Size(73, 23);
            this.userLevelComboBox.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnSetAsDefaultUser);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnAddNew);
            this.panel2.Controls.Add(this.btnUpdateDatabase);
            this.panel2.Location = new System.Drawing.Point(618, 415);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 145);
            this.panel2.TabIndex = 11;
            // 
            // btnSetAsDefaultUser
            // 
            this.btnSetAsDefaultUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetAsDefaultUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnSetAsDefaultUser.FlatAppearance.BorderSize = 0;
            this.btnSetAsDefaultUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetAsDefaultUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetAsDefaultUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnSetAsDefaultUser.Location = new System.Drawing.Point(253, 18);
            this.btnSetAsDefaultUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSetAsDefaultUser.Name = "btnSetAsDefaultUser";
            this.btnSetAsDefaultUser.Size = new System.Drawing.Size(157, 48);
            this.btnSetAsDefaultUser.TabIndex = 77;
            this.btnSetAsDefaultUser.Text = "SET AS CURRENT USER";
            this.btnSetAsDefaultUser.UseVisualStyleBackColor = false;
            this.btnSetAsDefaultUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnClose.Location = new System.Drawing.Point(253, 82);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(157, 48);
            this.btnClose.TabIndex = 74;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnAddNew.Location = new System.Drawing.Point(62, 18);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(157, 48);
            this.btnAddNew.TabIndex = 76;
            this.btnAddNew.Text = "ADD NEW";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.AddNew_Button_Click);
            // 
            // btnUpdateDatabase
            // 
            this.btnUpdateDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnUpdateDatabase.FlatAppearance.BorderSize = 0;
            this.btnUpdateDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnUpdateDatabase.Location = new System.Drawing.Point(62, 82);
            this.btnUpdateDatabase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateDatabase.Name = "btnUpdateDatabase";
            this.btnUpdateDatabase.Size = new System.Drawing.Size(157, 48);
            this.btnUpdateDatabase.TabIndex = 75;
            this.btnUpdateDatabase.Text = "SAVE UPDATES";
            this.btnUpdateDatabase.UseVisualStyleBackColor = false;
            this.btnUpdateDatabase.Click += new System.EventHandler(this.UpdateDB_Button_Click);
            // 
            // tbl_usersTableAdapter
            // 
            this.tbl_usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_assetlogsTableAdapter = null;
            this.tableAdapterManager.tbl_assetregisterTableAdapter = null;
            this.tableAdapterManager.tbl_colorTableAdapter = null;
            this.tableAdapterManager.tbl_partslistTableAdapter = null;
            this.tableAdapterManager.tbl_pmscheduleTableAdapter = null;
            this.tableAdapterManager.tbl_pmtasksTableAdapter = null;
            this.tableAdapterManager.tbl_reportTableAdapter = null;
            this.tableAdapterManager.tbl_settingsTableAdapter = null;
            this.tableAdapterManager.tbl_usersTableAdapter = this.tbl_usersTableAdapter;
            this.tableAdapterManager.tbl_worksordersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EPED.eped_db1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ShowUsersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1101, 579);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbl_usersDataGridView);
            this.Controls.Add(this.tbl_usersBindingNavigator);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ShowUsersFrm";
            this.Text = "List of Users";
            this.Activated += new System.EventHandler(this.ShowUsersFrm_Activated);
            this.Load += new System.EventHandler(this.UsersFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_usersBindingNavigator)).EndInit();
            this.tbl_usersBindingNavigator.ResumeLayout(false);
            this.tbl_usersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eped_db1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_usersDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlNewPassword.ResumeLayout(false);
            this.pnlNewPassword.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private eped_db1DataSet eped_db1DataSet;
        private System.Windows.Forms.BindingSource tbl_usersBindingSource;
        private eped_db1DataSetTableAdapters.tbl_usersTableAdapter tbl_usersTableAdapter;
        private eped_db1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbl_usersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tbl_usersBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tbl_usersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox userEmailAddressTextBox;
        private System.Windows.Forms.TextBox userPasswordTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnAddNew;
        internal System.Windows.Forms.Button btnUpdateDatabase;
        internal System.Windows.Forms.Button btnSetAsDefaultUser;
        private System.Windows.Forms.ComboBox userLevelComboBox;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Panel pnlNewPassword;
        private System.Windows.Forms.TextBox txbVerifyPassword;
        private System.Windows.Forms.TextBox txbNewPassword;
        private System.Windows.Forms.TextBox txbCurPassword;
        private System.Windows.Forms.Button btnSetPassword;
        private System.Windows.Forms.Button btnViewPW;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox userNameTextBox;
        }
    }