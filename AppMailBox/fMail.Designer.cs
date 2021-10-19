
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
            this.drvSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnGarbageCan = new System.Windows.Forms.Button();
            this.btnAddEmail = new System.Windows.Forms.Button();
            this.btnDrafts = new System.Windows.Forms.Button();
            this.btnStarred = new System.Windows.Forms.Button();
            this.btnAllMail = new System.Windows.Forms.Button();
            this.btnOutbox = new System.Windows.Forms.Button();
            this.btnInbox = new System.Windows.Forms.Button();
            this.cmbEmail = new MaterialSkin.Controls.MaterialComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpMail = new System.Windows.Forms.DateTimePicker();
            this.rtxtBodyMail = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvListMail = new System.Windows.Forms.DataGridView();
            this.drvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drvTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drvContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnContact = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnReplyAll = new System.Windows.Forms.Button();
            this.btnReplyMail = new System.Windows.Forms.Button();
            this.btnArchiveMail = new System.Windows.Forms.Button();
            this.btnDeleteMail = new System.Windows.Forms.Button();
            this.btnNewMail = new System.Windows.Forms.Button();
            this.tabSend = new System.Windows.Forms.TabPage();
            this.btnUpdateFolder = new System.Windows.Forms.Button();
            this.btnSendAll = new System.Windows.Forms.Button();
            this.btnCancelAll = new System.Windows.Forms.Button();
            this.btnSendReceive = new System.Windows.Forms.Button();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tabHelp = new System.Windows.Forms.TabPage();
            this.btnReport = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMail)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.tabSend.SuspendLayout();
            this.tabAccount.SuspendLayout();
            this.tabHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // drvSubject
            // 
            this.drvSubject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.drvSubject.HeaderText = "Subject";
            this.drvSubject.Name = "drvSubject";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(11, 403);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(77, 19);
            this.materialLabel1.TabIndex = 15;
            this.materialLabel1.Text = "Total Mail:";
            // 
            // btnGarbageCan
            // 
            this.btnGarbageCan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnGarbageCan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGarbageCan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGarbageCan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGarbageCan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGarbageCan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGarbageCan.Location = new System.Drawing.Point(0, 175);
            this.btnGarbageCan.Name = "btnGarbageCan";
            this.btnGarbageCan.Size = new System.Drawing.Size(259, 35);
            this.btnGarbageCan.TabIndex = 14;
            this.btnGarbageCan.Text = "Garbage can";
            this.btnGarbageCan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGarbageCan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGarbageCan.UseVisualStyleBackColor = false;
            // 
            // btnAddEmail
            // 
            this.btnAddEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnAddEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddEmail.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEmail.Image")));
            this.btnAddEmail.Location = new System.Drawing.Point(211, 425);
            this.btnAddEmail.Name = "btnAddEmail";
            this.btnAddEmail.Size = new System.Drawing.Size(49, 49);
            this.btnAddEmail.TabIndex = 14;
            this.btnAddEmail.UseVisualStyleBackColor = false;
            this.btnAddEmail.Click += new System.EventHandler(this.btnAddEmail_Click);
            // 
            // btnDrafts
            // 
            this.btnDrafts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnDrafts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDrafts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDrafts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrafts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDrafts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrafts.Location = new System.Drawing.Point(0, 140);
            this.btnDrafts.Name = "btnDrafts";
            this.btnDrafts.Size = new System.Drawing.Size(259, 35);
            this.btnDrafts.TabIndex = 13;
            this.btnDrafts.Text = "Drafts";
            this.btnDrafts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrafts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDrafts.UseVisualStyleBackColor = false;
            // 
            // btnStarred
            // 
            this.btnStarred.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnStarred.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStarred.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStarred.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStarred.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStarred.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStarred.Location = new System.Drawing.Point(0, 105);
            this.btnStarred.Name = "btnStarred";
            this.btnStarred.Size = new System.Drawing.Size(259, 35);
            this.btnStarred.TabIndex = 12;
            this.btnStarred.Text = "Starred";
            this.btnStarred.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStarred.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStarred.UseVisualStyleBackColor = false;
            // 
            // btnAllMail
            // 
            this.btnAllMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnAllMail.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllMail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAllMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllMail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAllMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllMail.Location = new System.Drawing.Point(0, 70);
            this.btnAllMail.Name = "btnAllMail";
            this.btnAllMail.Size = new System.Drawing.Size(259, 35);
            this.btnAllMail.TabIndex = 11;
            this.btnAllMail.Text = "All mail";
            this.btnAllMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllMail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllMail.UseVisualStyleBackColor = false;
            // 
            // btnOutbox
            // 
            this.btnOutbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnOutbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOutbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOutbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOutbox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOutbox.Location = new System.Drawing.Point(0, 35);
            this.btnOutbox.Name = "btnOutbox";
            this.btnOutbox.Size = new System.Drawing.Size(259, 35);
            this.btnOutbox.TabIndex = 10;
            this.btnOutbox.Text = "Outbox";
            this.btnOutbox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOutbox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOutbox.UseVisualStyleBackColor = false;
            // 
            // btnInbox
            // 
            this.btnInbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnInbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInbox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInbox.Location = new System.Drawing.Point(0, 0);
            this.btnInbox.Name = "btnInbox";
            this.btnInbox.Size = new System.Drawing.Size(259, 35);
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
            "atgjbmagic@gmail.com"});
            this.cmbEmail.Location = new System.Drawing.Point(-1, 425);
            this.cmbEmail.MaxDropDownItems = 4;
            this.cmbEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbEmail.Name = "cmbEmail";
            this.cmbEmail.Size = new System.Drawing.Size(216, 49);
            this.cmbEmail.StartIndex = 0;
            this.cmbEmail.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtpMail);
            this.panel3.Controls.Add(this.rtxtBodyMail);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(550, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(534, 475);
            this.panel3.TabIndex = 7;
            // 
            // dtpMail
            // 
            this.dtpMail.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpMail.Enabled = false;
            this.dtpMail.Location = new System.Drawing.Point(0, 0);
            this.dtpMail.Name = "dtpMail";
            this.dtpMail.Size = new System.Drawing.Size(534, 20);
            this.dtpMail.TabIndex = 16;
            // 
            // rtxtBodyMail
            // 
            this.rtxtBodyMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtBodyMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtBodyMail.Location = new System.Drawing.Point(0, 0);
            this.rtxtBodyMail.Name = "rtxtBodyMail";
            this.rtxtBodyMail.ReadOnly = true;
            this.rtxtBodyMail.Size = new System.Drawing.Size(534, 401);
            this.rtxtBodyMail.TabIndex = 15;
            this.rtxtBodyMail.Text = "";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 401);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(534, 74);
            this.panel5.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.dgvListMail);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(261, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(823, 475);
            this.panel4.TabIndex = 6;
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
            this.dgvListMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListMail.Location = new System.Drawing.Point(0, 0);
            this.dgvListMail.Name = "dgvListMail";
            this.dgvListMail.Size = new System.Drawing.Size(823, 475);
            this.dgvListMail.TabIndex = 14;
            // 
            // drvID
            // 
            this.drvID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.drvID.HeaderText = "ID";
            this.drvID.Name = "drvID";
            // 
            // drvTo
            // 
            this.drvTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.drvTo.HeaderText = "To";
            this.drvTo.Name = "drvTo";
            // 
            // drvContent
            // 
            this.drvContent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.drvContent.HeaderText = "Content";
            this.drvContent.Name = "drvContent";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.materialLabel1);
            this.panel2.Controls.Add(this.btnGarbageCan);
            this.panel2.Controls.Add(this.btnAddEmail);
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
            // btnContact
            // 
            this.btnContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContact.Image = ((System.Drawing.Image)(resources.GetObject("btnContact.Image")));
            this.btnContact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContact.Location = new System.Drawing.Point(6, 3);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(150, 50);
            this.btnContact.TabIndex = 1;
            this.btnContact.Text = "Contact";
            this.btnContact.UseVisualStyleBackColor = true;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHome);
            this.tabControl1.Controls.Add(this.tabSend);
            this.tabControl1.Controls.Add(this.tabAccount);
            this.tabControl1.Controls.Add(this.tabHelp);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1080, 82);
            this.tabControl1.TabIndex = 1;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.btnBack);
            this.tabHome.Controls.Add(this.btnForward);
            this.tabHome.Controls.Add(this.btnReplyAll);
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
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(942, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(124, 50);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnForward
            // 
            this.btnForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForward.Image = ((System.Drawing.Image)(resources.GetObject("btnForward.Image")));
            this.btnForward.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnForward.Location = new System.Drawing.Point(805, 3);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(131, 50);
            this.btnForward.TabIndex = 6;
            this.btnForward.Text = "Forward";
            this.btnForward.UseVisualStyleBackColor = true;
            // 
            // btnReplyAll
            // 
            this.btnReplyAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplyAll.Image = ((System.Drawing.Image)(resources.GetObject("btnReplyAll.Image")));
            this.btnReplyAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReplyAll.Location = new System.Drawing.Point(631, 3);
            this.btnReplyAll.Name = "btnReplyAll";
            this.btnReplyAll.Size = new System.Drawing.Size(168, 50);
            this.btnReplyAll.TabIndex = 5;
            this.btnReplyAll.Text = "Reply All Mail";
            this.btnReplyAll.UseVisualStyleBackColor = true;
            // 
            // btnReplyMail
            // 
            this.btnReplyMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplyMail.Image = ((System.Drawing.Image)(resources.GetObject("btnReplyMail.Image")));
            this.btnReplyMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReplyMail.Location = new System.Drawing.Point(478, 3);
            this.btnReplyMail.Name = "btnReplyMail";
            this.btnReplyMail.Size = new System.Drawing.Size(147, 50);
            this.btnReplyMail.TabIndex = 4;
            this.btnReplyMail.Text = "Reply Mail";
            this.btnReplyMail.UseVisualStyleBackColor = true;
            // 
            // btnArchiveMail
            // 
            this.btnArchiveMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchiveMail.Image = ((System.Drawing.Image)(resources.GetObject("btnArchiveMail.Image")));
            this.btnArchiveMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArchiveMail.Location = new System.Drawing.Point(318, 3);
            this.btnArchiveMail.Name = "btnArchiveMail";
            this.btnArchiveMail.Size = new System.Drawing.Size(154, 50);
            this.btnArchiveMail.TabIndex = 3;
            this.btnArchiveMail.Text = "Archive Mail";
            this.btnArchiveMail.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMail
            // 
            this.btnDeleteMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMail.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteMail.Image")));
            this.btnDeleteMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteMail.Location = new System.Drawing.Point(152, 3);
            this.btnDeleteMail.Name = "btnDeleteMail";
            this.btnDeleteMail.Size = new System.Drawing.Size(160, 50);
            this.btnDeleteMail.TabIndex = 2;
            this.btnDeleteMail.Text = "Delete Mail";
            this.btnDeleteMail.UseVisualStyleBackColor = true;
            // 
            // btnNewMail
            // 
            this.btnNewMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewMail.Image = ((System.Drawing.Image)(resources.GetObject("btnNewMail.Image")));
            this.btnNewMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewMail.Location = new System.Drawing.Point(6, 3);
            this.btnNewMail.Name = "btnNewMail";
            this.btnNewMail.Size = new System.Drawing.Size(140, 50);
            this.btnNewMail.TabIndex = 1;
            this.btnNewMail.Text = "New Mail";
            this.btnNewMail.UseVisualStyleBackColor = true;
            this.btnNewMail.Click += new System.EventHandler(this.btnNewMail_Click);
            // 
            // tabSend
            // 
            this.tabSend.Controls.Add(this.btnUpdateFolder);
            this.tabSend.Controls.Add(this.btnSendAll);
            this.tabSend.Controls.Add(this.btnCancelAll);
            this.tabSend.Controls.Add(this.btnSendReceive);
            this.tabSend.Location = new System.Drawing.Point(4, 22);
            this.tabSend.Name = "tabSend";
            this.tabSend.Size = new System.Drawing.Size(1072, 56);
            this.tabSend.TabIndex = 1;
            this.tabSend.Text = "Send/Receive";
            this.tabSend.UseVisualStyleBackColor = true;
            // 
            // btnUpdateFolder
            // 
            this.btnUpdateFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateFolder.Image")));
            this.btnUpdateFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateFolder.Location = new System.Drawing.Point(405, 3);
            this.btnUpdateFolder.Name = "btnUpdateFolder";
            this.btnUpdateFolder.Size = new System.Drawing.Size(179, 50);
            this.btnUpdateFolder.TabIndex = 3;
            this.btnUpdateFolder.Text = "Update Folder";
            this.btnUpdateFolder.UseVisualStyleBackColor = true;
            // 
            // btnSendAll
            // 
            this.btnSendAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendAll.Image = ((System.Drawing.Image)(resources.GetObject("btnSendAll.Image")));
            this.btnSendAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendAll.Location = new System.Drawing.Point(249, 3);
            this.btnSendAll.Name = "btnSendAll";
            this.btnSendAll.Size = new System.Drawing.Size(150, 50);
            this.btnSendAll.TabIndex = 2;
            this.btnSendAll.Text = "Send All";
            this.btnSendAll.UseVisualStyleBackColor = true;
            // 
            // btnCancelAll
            // 
            this.btnCancelAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAll.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelAll.Image")));
            this.btnCancelAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelAll.Location = new System.Drawing.Point(590, 3);
            this.btnCancelAll.Name = "btnCancelAll";
            this.btnCancelAll.Size = new System.Drawing.Size(142, 50);
            this.btnCancelAll.TabIndex = 4;
            this.btnCancelAll.Text = "Cancel All";
            this.btnCancelAll.UseVisualStyleBackColor = true;
            // 
            // btnSendReceive
            // 
            this.btnSendReceive.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSendReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendReceive.Image = ((System.Drawing.Image)(resources.GetObject("btnSendReceive.Image")));
            this.btnSendReceive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendReceive.Location = new System.Drawing.Point(6, 3);
            this.btnSendReceive.Name = "btnSendReceive";
            this.btnSendReceive.Size = new System.Drawing.Size(237, 50);
            this.btnSendReceive.TabIndex = 1;
            this.btnSendReceive.Text = "Send / Receive All Folder";
            this.btnSendReceive.UseVisualStyleBackColor = false;
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
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(162, 3);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(150, 50);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(318, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 50);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(6, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(150, 50);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // tabHelp
            // 
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
            this.btnReport.Location = new System.Drawing.Point(162, 3);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(150, 50);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Feedback";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // fMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MailBox";
            this.Load += new System.EventHandler(this.fMail_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMail)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabSend.ResumeLayout(false);
            this.tabAccount.ResumeLayout(false);
            this.tabHelp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn drvSubject;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Button btnGarbageCan;
        private System.Windows.Forms.Button btnAddEmail;
        private System.Windows.Forms.Button btnDrafts;
        private System.Windows.Forms.Button btnStarred;
        private System.Windows.Forms.Button btnAllMail;
        private System.Windows.Forms.Button btnOutbox;
        private System.Windows.Forms.Button btnInbox;
        private MaterialSkin.Controls.MaterialComboBox cmbEmail;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpMail;
        private System.Windows.Forms.RichTextBox rtxtBodyMail;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvListMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn drvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn drvTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn drvContent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnReplyAll;
        private System.Windows.Forms.Button btnReplyMail;
        private System.Windows.Forms.Button btnArchiveMail;
        private System.Windows.Forms.Button btnDeleteMail;
        private System.Windows.Forms.Button btnNewMail;
        private System.Windows.Forms.TabPage tabSend;
        private System.Windows.Forms.Button btnUpdateFolder;
        private System.Windows.Forms.Button btnSendAll;
        private System.Windows.Forms.Button btnCancelAll;
        private System.Windows.Forms.Button btnSendReceive;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TabPage tabHelp;
        private System.Windows.Forms.Button btnReport;
    }
}