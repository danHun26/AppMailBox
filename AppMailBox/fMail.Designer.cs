
namespace AppMailBox
{
    partial class fMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMail));
            this.btnGarbageCan = new System.Windows.Forms.Button();
            this.btnDrafts = new System.Windows.Forms.Button();
            this.btnStarred = new System.Windows.Forms.Button();
            this.btnAllMail = new System.Windows.Forms.Button();
            this.btnOutbox = new System.Windows.Forms.Button();
            this.btnInbox = new System.Windows.Forms.Button();
            this.cmbEmail = new MaterialSkin.Controls.MaterialComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddEmail = new System.Windows.Forms.Button();
            this.lTotal = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.wbMail = new System.Windows.Forms.WebBrowser();
            this.dtpMail = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRecovery = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.dgvListMail = new System.Windows.Forms.DataGridView();
            this.drvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drvTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drvSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drvContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabHelp = new System.Windows.Forms.TabPage();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.btnNewMail = new System.Windows.Forms.Button();
            this.btnDeleteMail = new System.Windows.Forms.Button();
            this.btnArchiveMail = new System.Windows.Forms.Button();
            this.btnReplyMail = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSendReceive = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnVersion = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMail)).BeginInit();
            this.tabHelp.SuspendLayout();
            this.tabAccount.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGarbageCan
            // 
            this.btnGarbageCan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnGarbageCan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGarbageCan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGarbageCan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGarbageCan.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnGarbageCan.Image = ((System.Drawing.Image)(resources.GetObject("btnGarbageCan.Image")));
            this.btnGarbageCan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGarbageCan.Location = new System.Drawing.Point(0, 249);
            this.btnGarbageCan.Name = "btnGarbageCan";
            this.btnGarbageCan.Size = new System.Drawing.Size(259, 40);
            this.btnGarbageCan.TabIndex = 14;
            this.btnGarbageCan.Text = "Garbage can";
            this.btnGarbageCan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGarbageCan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGarbageCan.UseVisualStyleBackColor = false;
            this.btnGarbageCan.Click += new System.EventHandler(this.btnGarbageCan_Click);
            // 
            // btnDrafts
            // 
            this.btnDrafts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnDrafts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDrafts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDrafts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrafts.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnDrafts.Image = ((System.Drawing.Image)(resources.GetObject("btnDrafts.Image")));
            this.btnDrafts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrafts.Location = new System.Drawing.Point(0, 209);
            this.btnDrafts.Name = "btnDrafts";
            this.btnDrafts.Size = new System.Drawing.Size(259, 40);
            this.btnDrafts.TabIndex = 13;
            this.btnDrafts.Text = "Drafts";
            this.btnDrafts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrafts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDrafts.UseVisualStyleBackColor = false;
            this.btnDrafts.Click += new System.EventHandler(this.btnDrafts_Click);
            // 
            // btnStarred
            // 
            this.btnStarred.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnStarred.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStarred.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStarred.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStarred.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnStarred.Image = ((System.Drawing.Image)(resources.GetObject("btnStarred.Image")));
            this.btnStarred.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStarred.Location = new System.Drawing.Point(0, 169);
            this.btnStarred.Name = "btnStarred";
            this.btnStarred.Size = new System.Drawing.Size(259, 40);
            this.btnStarred.TabIndex = 12;
            this.btnStarred.Text = "Starred";
            this.btnStarred.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStarred.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStarred.UseVisualStyleBackColor = false;
            this.btnStarred.Click += new System.EventHandler(this.btnStarred_Click);
            // 
            // btnAllMail
            // 
            this.btnAllMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnAllMail.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllMail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAllMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllMail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAllMail.Image = ((System.Drawing.Image)(resources.GetObject("btnAllMail.Image")));
            this.btnAllMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllMail.Location = new System.Drawing.Point(0, 129);
            this.btnAllMail.Name = "btnAllMail";
            this.btnAllMail.Size = new System.Drawing.Size(259, 40);
            this.btnAllMail.TabIndex = 11;
            this.btnAllMail.Text = "All mail";
            this.btnAllMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllMail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllMail.UseVisualStyleBackColor = false;
            this.btnAllMail.Click += new System.EventHandler(this.btnAllMail_Click);
            // 
            // btnOutbox
            // 
            this.btnOutbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnOutbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOutbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOutbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnOutbox.Image = ((System.Drawing.Image)(resources.GetObject("btnOutbox.Image")));
            this.btnOutbox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOutbox.Location = new System.Drawing.Point(0, 89);
            this.btnOutbox.Name = "btnOutbox";
            this.btnOutbox.Size = new System.Drawing.Size(259, 40);
            this.btnOutbox.TabIndex = 10;
            this.btnOutbox.Text = "Outbox";
            this.btnOutbox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOutbox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOutbox.UseVisualStyleBackColor = false;
            this.btnOutbox.Click += new System.EventHandler(this.btnOutbox_Click);
            // 
            // btnInbox
            // 
            this.btnInbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnInbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnInbox.Image = ((System.Drawing.Image)(resources.GetObject("btnInbox.Image")));
            this.btnInbox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInbox.Location = new System.Drawing.Point(0, 49);
            this.btnInbox.Name = "btnInbox";
            this.btnInbox.Size = new System.Drawing.Size(259, 40);
            this.btnInbox.TabIndex = 9;
            this.btnInbox.Text = "Inbox";
            this.btnInbox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInbox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInbox.UseVisualStyleBackColor = false;
            this.btnInbox.Click += new System.EventHandler(this.btnInbox_Click);
            // 
            // cmbEmail
            // 
            this.cmbEmail.AutoResize = false;
            this.cmbEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmbEmail.Depth = 0;
            this.cmbEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbEmail.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbEmail.DropDownHeight = 174;
            this.cmbEmail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmail.DropDownWidth = 121;
            this.cmbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbEmail.FormattingEnabled = true;
            this.cmbEmail.IntegralHeight = false;
            this.cmbEmail.ItemHeight = 43;
            this.cmbEmail.Items.AddRange(new object[] {
            "jamk1126@gmail.com",
            "atgjbmagic@gmail.com",
            "kurokuro12344@gmail.com"});
            this.cmbEmail.Location = new System.Drawing.Point(0, 0);
            this.cmbEmail.MaxDropDownItems = 4;
            this.cmbEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbEmail.Name = "cmbEmail";
            this.cmbEmail.Size = new System.Drawing.Size(259, 49);
            this.cmbEmail.StartIndex = 0;
            this.cmbEmail.TabIndex = 8;
            this.cmbEmail.SelectedIndexChanged += new System.EventHandler(this.cmbEmail_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnAddEmail);
            this.panel2.Controls.Add(this.btnGarbageCan);
            this.panel2.Controls.Add(this.btnDrafts);
            this.panel2.Controls.Add(this.btnStarred);
            this.panel2.Controls.Add(this.btnAllMail);
            this.panel2.Controls.Add(this.btnOutbox);
            this.panel2.Controls.Add(this.btnInbox);
            this.panel2.Controls.Add(this.cmbEmail);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 475);
            this.panel2.TabIndex = 5;
            // 
            // btnAddEmail
            // 
            this.btnAddEmail.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAddEmail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddEmail.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEmail.Image")));
            this.btnAddEmail.Location = new System.Drawing.Point(0, 438);
            this.btnAddEmail.Name = "btnAddEmail";
            this.btnAddEmail.Size = new System.Drawing.Size(259, 35);
            this.btnAddEmail.TabIndex = 16;
            this.btnAddEmail.UseVisualStyleBackColor = false;
            this.btnAddEmail.Click += new System.EventHandler(this.btnAddEmail_Click);
            // 
            // lTotal
            // 
            this.lTotal.AutoSize = true;
            this.lTotal.Depth = 0;
            this.lTotal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lTotal.Location = new System.Drawing.Point(6, 439);
            this.lTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(42, 19);
            this.lTotal.TabIndex = 17;
            this.lTotal.Text = "Total:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 86);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.wbMail);
            this.panel3.Controls.Add(this.dtpMail);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(757, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(327, 475);
            this.panel3.TabIndex = 8;
            // 
            // wbMail
            // 
            this.wbMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbMail.Location = new System.Drawing.Point(0, 20);
            this.wbMail.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbMail.Name = "wbMail";
            this.wbMail.Size = new System.Drawing.Size(327, 455);
            this.wbMail.TabIndex = 17;
            // 
            // dtpMail
            // 
            this.dtpMail.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpMail.Enabled = false;
            this.dtpMail.Location = new System.Drawing.Point(0, 0);
            this.dtpMail.Name = "dtpMail";
            this.dtpMail.Size = new System.Drawing.Size(327, 20);
            this.dtpMail.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnRecovery);
            this.panel4.Controls.Add(this.btnDeleteAll);
            this.panel4.Controls.Add(this.lTotal);
            this.panel4.Controls.Add(this.dgvListMail);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(261, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(496, 475);
            this.panel4.TabIndex = 9;
            // 
            // btnRecovery
            // 
            this.btnRecovery.BackColor = System.Drawing.Color.DarkGreen;
            this.btnRecovery.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRecovery.Enabled = false;
            this.btnRecovery.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRecovery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecovery.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRecovery.Image = ((System.Drawing.Image)(resources.GetObject("btnRecovery.Image")));
            this.btnRecovery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecovery.Location = new System.Drawing.Point(369, 432);
            this.btnRecovery.Name = "btnRecovery";
            this.btnRecovery.Size = new System.Drawing.Size(121, 40);
            this.btnRecovery.TabIndex = 19;
            this.btnRecovery.Text = "Recovery";
            this.btnRecovery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecovery.UseVisualStyleBackColor = false;
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BackColor = System.Drawing.Color.Maroon;
            this.btnDeleteAll.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDeleteAll.Enabled = false;
            this.btnDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteAll.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAll.Image")));
            this.btnDeleteAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAll.Location = new System.Drawing.Point(242, 432);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(121, 40);
            this.btnDeleteAll.TabIndex = 18;
            this.btnDeleteAll.Text = "Delete all";
            this.btnDeleteAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // dgvListMail
            // 
            this.dgvListMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListMail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListMail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.drvID,
            this.drvTo,
            this.drvSubject,
            this.drvContent});
            this.dgvListMail.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvListMail.Location = new System.Drawing.Point(0, 0);
            this.dgvListMail.Name = "dgvListMail";
            this.dgvListMail.Size = new System.Drawing.Size(496, 426);
            this.dgvListMail.TabIndex = 15;
            this.dgvListMail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListMail_CellClick);
            // 
            // drvID
            // 
            this.drvID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.drvID.HeaderText = "ID";
            this.drvID.Name = "drvID";
            this.drvID.Width = 43;
            // 
            // drvTo
            // 
            this.drvTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.drvTo.HeaderText = "To";
            this.drvTo.Name = "drvTo";
            // 
            // drvSubject
            // 
            this.drvSubject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.drvSubject.HeaderText = "Subject";
            this.drvSubject.Name = "drvSubject";
            // 
            // drvContent
            // 
            this.drvContent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.drvContent.HeaderText = "Content";
            this.drvContent.Name = "drvContent";
            // 
            // tabHelp
            // 
            this.tabHelp.Controls.Add(this.btnVersion);
            this.tabHelp.Controls.Add(this.btnContact);
            this.tabHelp.Controls.Add(this.btnReport);
            this.tabHelp.Location = new System.Drawing.Point(4, 22);
            this.tabHelp.Name = "tabHelp";
            this.tabHelp.Size = new System.Drawing.Size(1072, 56);
            this.tabHelp.TabIndex = 2;
            this.tabHelp.Text = "Help";
            this.tabHelp.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(200, 3);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(191, 50);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Feedback";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnContact
            // 
            this.btnContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContact.Image = ((System.Drawing.Image)(resources.GetObject("btnContact.Image")));
            this.btnContact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContact.Location = new System.Drawing.Point(6, 3);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(188, 50);
            this.btnContact.TabIndex = 1;
            this.btnContact.Text = "Contact";
            this.btnContact.UseVisualStyleBackColor = true;
            // 
            // tabAccount
            // 
            this.tabAccount.Controls.Add(this.btnLogOut);
            this.tabAccount.Controls.Add(this.btnExit);
            this.tabAccount.Controls.Add(this.btnEdit);
            this.tabAccount.Location = new System.Drawing.Point(4, 22);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Size = new System.Drawing.Size(1072, 56);
            this.tabAccount.TabIndex = 3;
            this.tabAccount.Text = "Account";
            this.tabAccount.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(6, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(182, 50);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "My account";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(387, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(189, 50);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(194, 3);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(187, 50);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.btnSendReceive);
            this.tabHome.Controls.Add(this.btnBack);
            this.tabHome.Controls.Add(this.btnReplyMail);
            this.tabHome.Controls.Add(this.btnArchiveMail);
            this.tabHome.Controls.Add(this.btnDeleteMail);
            this.tabHome.Controls.Add(this.btnNewMail);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Size = new System.Drawing.Size(1072, 56);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // btnNewMail
            // 
            this.btnNewMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewMail.Image = ((System.Drawing.Image)(resources.GetObject("btnNewMail.Image")));
            this.btnNewMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewMail.Location = new System.Drawing.Point(6, 3);
            this.btnNewMail.Name = "btnNewMail";
            this.btnNewMail.Size = new System.Drawing.Size(222, 50);
            this.btnNewMail.TabIndex = 1;
            this.btnNewMail.Text = "New Mail / resend mail";
            this.btnNewMail.UseVisualStyleBackColor = true;
            this.btnNewMail.Click += new System.EventHandler(this.btnNewMail_Click);
            // 
            // btnDeleteMail
            // 
            this.btnDeleteMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMail.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteMail.Image")));
            this.btnDeleteMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteMail.Location = new System.Drawing.Point(234, 3);
            this.btnDeleteMail.Name = "btnDeleteMail";
            this.btnDeleteMail.Size = new System.Drawing.Size(155, 50);
            this.btnDeleteMail.TabIndex = 2;
            this.btnDeleteMail.Text = "Delete Mail";
            this.btnDeleteMail.UseVisualStyleBackColor = true;
            this.btnDeleteMail.Click += new System.EventHandler(this.btnDeleteMail_Click);
            // 
            // btnArchiveMail
            // 
            this.btnArchiveMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchiveMail.Image = ((System.Drawing.Image)(resources.GetObject("btnArchiveMail.Image")));
            this.btnArchiveMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArchiveMail.Location = new System.Drawing.Point(395, 3);
            this.btnArchiveMail.Name = "btnArchiveMail";
            this.btnArchiveMail.Size = new System.Drawing.Size(165, 50);
            this.btnArchiveMail.TabIndex = 3;
            this.btnArchiveMail.Text = "Archive Mail";
            this.btnArchiveMail.UseVisualStyleBackColor = true;
            // 
            // btnReplyMail
            // 
            this.btnReplyMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplyMail.Image = ((System.Drawing.Image)(resources.GetObject("btnReplyMail.Image")));
            this.btnReplyMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReplyMail.Location = new System.Drawing.Point(566, 3);
            this.btnReplyMail.Name = "btnReplyMail";
            this.btnReplyMail.Size = new System.Drawing.Size(161, 50);
            this.btnReplyMail.TabIndex = 4;
            this.btnReplyMail.Text = "Reply Mail";
            this.btnReplyMail.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(933, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 50);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnSendReceive
            // 
            this.btnSendReceive.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSendReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendReceive.Image = ((System.Drawing.Image)(resources.GetObject("btnSendReceive.Image")));
            this.btnSendReceive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendReceive.Location = new System.Drawing.Point(733, 3);
            this.btnSendReceive.Name = "btnSendReceive";
            this.btnSendReceive.Size = new System.Drawing.Size(194, 50);
            this.btnSendReceive.TabIndex = 8;
            this.btnSendReceive.Text = "Sync account";
            this.btnSendReceive.UseVisualStyleBackColor = false;
            this.btnSendReceive.Click += new System.EventHandler(this.btnSendReceive_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHome);
            this.tabControl1.Controls.Add(this.tabAccount);
            this.tabControl1.Controls.Add(this.tabHelp);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1080, 82);
            this.tabControl1.TabIndex = 1;
            // 
            // btnVersion
            // 
            this.btnVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVersion.Image = ((System.Drawing.Image)(resources.GetObject("btnVersion.Image")));
            this.btnVersion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVersion.Location = new System.Drawing.Point(397, 3);
            this.btnVersion.Name = "btnVersion";
            this.btnVersion.Size = new System.Drawing.Size(191, 50);
            this.btnVersion.TabIndex = 3;
            this.btnVersion.Text = "About MailBox";
            this.btnVersion.UseVisualStyleBackColor = true;
            // 
            // fMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MailBox";
            this.Load += new System.EventHandler(this.fMail_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMail)).EndInit();
            this.tabHelp.ResumeLayout(false);
            this.tabAccount.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGarbageCan;
        private System.Windows.Forms.Button btnDrafts;
        private System.Windows.Forms.Button btnStarred;
        private System.Windows.Forms.Button btnAllMail;
        private System.Windows.Forms.Button btnOutbox;
        private System.Windows.Forms.Button btnInbox;
        private MaterialSkin.Controls.MaterialComboBox cmbEmail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpMail;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvListMail;
        private MaterialSkin.Controls.MaterialLabel lTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn drvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn drvTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn drvSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn drvContent;
        private System.Windows.Forms.Button btnAddEmail;
        private System.Windows.Forms.WebBrowser wbMail;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnRecovery;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.Button btnSendReceive;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReplyMail;
        private System.Windows.Forms.Button btnArchiveMail;
        private System.Windows.Forms.Button btnDeleteMail;
        private System.Windows.Forms.Button btnNewMail;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TabPage tabHelp;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnVersion;
    }
}