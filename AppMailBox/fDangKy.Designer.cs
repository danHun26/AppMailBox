
namespace AppMailBox
{
    partial class fDangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDangKy));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCheckMail = new System.Windows.Forms.Button();
            this.txtCheckMail = new MaterialSkin.Controls.MaterialTextBox();
            this.lBackLogin = new System.Windows.Forms.Label();
            this.lTime = new MaterialSkin.Controls.MaterialLabel();
            this.lDate = new MaterialSkin.Controls.MaterialLabel();
            this.cbShowPass = new MaterialSkin.Controls.MaterialCheckbox();
            this.txtFirstName = new MaterialSkin.Controls.MaterialTextBox();
            this.cmdSex = new MaterialSkin.Controls.MaterialComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtReEnter = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.txtUserName = new MaterialSkin.Controls.MaterialTextBox();
            this.dTBirth = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.txtLastName = new MaterialSkin.Controls.MaterialTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 100);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(96, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "REGISTER SERVICE";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(88, 94);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnConfirm);
            this.panel3.Controls.Add(this.btnCheckMail);
            this.panel3.Controls.Add(this.txtCheckMail);
            this.panel3.Controls.Add(this.lBackLogin);
            this.panel3.Controls.Add(this.lTime);
            this.panel3.Controls.Add(this.lDate);
            this.panel3.Controls.Add(this.cbShowPass);
            this.panel3.Controls.Add(this.txtFirstName);
            this.panel3.Controls.Add(this.cmdSex);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.btnSignUp);
            this.panel3.Controls.Add(this.txtReEnter);
            this.panel3.Controls.Add(this.txtPassword);
            this.panel3.Controls.Add(this.txtUserName);
            this.panel3.Controls.Add(this.dTBirth);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Controls.Add(this.txtLastName);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(480, 584);
            this.panel3.TabIndex = 3;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.White;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnConfirm.Location = new System.Drawing.Point(375, 155);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(99, 50);
            this.btnConfirm.TabIndex = 16;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCheckMail
            // 
            this.btnCheckMail.BackColor = System.Drawing.Color.White;
            this.btnCheckMail.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckMail.Image")));
            this.btnCheckMail.Location = new System.Drawing.Point(424, 457);
            this.btnCheckMail.Name = "btnCheckMail";
            this.btnCheckMail.Size = new System.Drawing.Size(50, 50);
            this.btnCheckMail.TabIndex = 15;
            this.btnCheckMail.UseVisualStyleBackColor = false;
            this.btnCheckMail.Click += new System.EventHandler(this.btnCheckMail_Click);
            // 
            // txtCheckMail
            // 
            this.txtCheckMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCheckMail.Depth = 0;
            this.txtCheckMail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCheckMail.Hint = "Confirm Email";
            this.txtCheckMail.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtCheckMail.LeadingIcon")));
            this.txtCheckMail.Location = new System.Drawing.Point(224, 457);
            this.txtCheckMail.MaxLength = 50;
            this.txtCheckMail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCheckMail.Multiline = false;
            this.txtCheckMail.Name = "txtCheckMail";
            this.txtCheckMail.Size = new System.Drawing.Size(194, 50);
            this.txtCheckMail.TabIndex = 14;
            this.txtCheckMail.Text = "";
            this.txtCheckMail.TrailingIcon = null;
            // 
            // lBackLogin
            // 
            this.lBackLogin.AutoSize = true;
            this.lBackLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lBackLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBackLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.lBackLogin.Location = new System.Drawing.Point(351, 11);
            this.lBackLogin.Name = "lBackLogin";
            this.lBackLogin.Size = new System.Drawing.Size(117, 18);
            this.lBackLogin.TabIndex = 0;
            this.lBackLogin.Text = "Go back to login";
            this.lBackLogin.Click += new System.EventHandler(this.lBackLogin_Click);
            // 
            // lTime
            // 
            this.lTime.AutoSize = true;
            this.lTime.Depth = 0;
            this.lTime.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lTime.Location = new System.Drawing.Point(12, 524);
            this.lTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(37, 19);
            this.lTime.TabIndex = 13;
            this.lTime.Text = "Time";
            this.lTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Depth = 0;
            this.lDate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lDate.Location = new System.Drawing.Point(12, 543);
            this.lDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(34, 19);
            this.lDate.TabIndex = 12;
            this.lDate.Text = "Date";
            this.lDate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // cbShowPass
            // 
            this.cbShowPass.AutoSize = true;
            this.cbShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbShowPass.Depth = 0;
            this.cbShowPass.Location = new System.Drawing.Point(5, 457);
            this.cbShowPass.Margin = new System.Windows.Forms.Padding(0);
            this.cbShowPass.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbShowPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbShowPass.Name = "cbShowPass";
            this.cbShowPass.Ripple = true;
            this.cbShowPass.Size = new System.Drawing.Size(148, 37);
            this.cbShowPass.TabIndex = 11;
            this.cbShowPass.Text = "Show password";
            this.cbShowPass.UseVisualStyleBackColor = true;
            this.cbShowPass.Click += new System.EventHandler(this.cbShowPass_CheckedChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Depth = 0;
            this.txtFirstName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFirstName.Hint = "First Name:";
            this.txtFirstName.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtFirstName.LeadingIcon")));
            this.txtFirstName.Location = new System.Drawing.Point(0, 43);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFirstName.Multiline = false;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(480, 50);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.Text = "";
            this.txtFirstName.TrailingIcon = null;
            // 
            // cmdSex
            // 
            this.cmdSex.AutoResize = false;
            this.cmdSex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmdSex.Depth = 0;
            this.cmdSex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmdSex.DropDownHeight = 174;
            this.cmdSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdSex.DropDownWidth = 121;
            this.cmdSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmdSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmdSex.FormattingEnabled = true;
            this.cmdSex.Hint = "Sex";
            this.cmdSex.IntegralHeight = false;
            this.cmdSex.ItemHeight = 43;
            this.cmdSex.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmdSex.Location = new System.Drawing.Point(0, 237);
            this.cmdSex.MaxDropDownItems = 4;
            this.cmdSex.MouseState = MaterialSkin.MouseState.OUT;
            this.cmdSex.Name = "cmdSex";
            this.cmdSex.Size = new System.Drawing.Size(480, 49);
            this.cmdSex.StartIndex = 0;
            this.cmdSex.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnExit.Location = new System.Drawing.Point(352, 513);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 49);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSignUp.Location = new System.Drawing.Point(224, 513);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(122, 49);
            this.btnSignUp.TabIndex = 9;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtReEnter
            // 
            this.txtReEnter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReEnter.Depth = 0;
            this.txtReEnter.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtReEnter.Hint = "Re-Enter password:";
            this.txtReEnter.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtReEnter.LeadingIcon")));
            this.txtReEnter.Location = new System.Drawing.Point(0, 404);
            this.txtReEnter.MaxLength = 50;
            this.txtReEnter.MouseState = MaterialSkin.MouseState.OUT;
            this.txtReEnter.Multiline = false;
            this.txtReEnter.Name = "txtReEnter";
            this.txtReEnter.Password = true;
            this.txtReEnter.Size = new System.Drawing.Size(480, 50);
            this.txtReEnter.TabIndex = 8;
            this.txtReEnter.Text = "";
            this.txtReEnter.TrailingIcon = null;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.Hint = "Password:";
            this.txtPassword.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtPassword.LeadingIcon")));
            this.txtPassword.Location = new System.Drawing.Point(0, 348);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Password = true;
            this.txtPassword.Size = new System.Drawing.Size(480, 50);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.Text = "";
            this.txtPassword.TrailingIcon = null;
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Depth = 0;
            this.txtUserName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUserName.Hint = "Username:";
            this.txtUserName.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtUserName.LeadingIcon")));
            this.txtUserName.Location = new System.Drawing.Point(0, 292);
            this.txtUserName.MaxLength = 50;
            this.txtUserName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUserName.Multiline = false;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(480, 50);
            this.txtUserName.TabIndex = 6;
            this.txtUserName.Text = "";
            this.txtUserName.TrailingIcon = null;
            // 
            // dTBirth
            // 
            this.dTBirth.Location = new System.Drawing.Point(148, 211);
            this.dTBirth.Name = "dTBirth";
            this.dTBirth.Size = new System.Drawing.Size(226, 20);
            this.dTBirth.TabIndex = 4;
            this.dTBirth.Value = new System.DateTime(2021, 10, 4, 17, 53, 52, 0);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.Hint = "Email:";
            this.txtEmail.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtEmail.LeadingIcon")));
            this.txtEmail.Location = new System.Drawing.Point(0, 155);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(369, 50);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Text = "";
            this.txtEmail.TrailingIcon = null;
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Depth = 0;
            this.txtLastName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLastName.Hint = "Last Name:";
            this.txtLastName.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtLastName.LeadingIcon")));
            this.txtLastName.Location = new System.Drawing.Point(0, 99);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLastName.Multiline = false;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(480, 50);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.Text = "";
            this.txtLastName.TrailingIcon = null;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label6.Location = new System.Drawing.Point(12, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Date of birth:";
            this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label4.Location = new System.Drawing.Point(22, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 24);
            this.label4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sign Up";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // fDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 684);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Service  - MailBox";
            this.Load += new System.EventHandler(this.fDangKy_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCheckMail;
        private MaterialSkin.Controls.MaterialTextBox txtCheckMail;
        private System.Windows.Forms.Label lBackLogin;
        private MaterialSkin.Controls.MaterialLabel lTime;
        private MaterialSkin.Controls.MaterialLabel lDate;
        private MaterialSkin.Controls.MaterialCheckbox cbShowPass;
        private MaterialSkin.Controls.MaterialTextBox txtFirstName;
        private MaterialSkin.Controls.MaterialComboBox cmdSex;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSignUp;
        private MaterialSkin.Controls.MaterialTextBox txtReEnter;
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
        private MaterialSkin.Controls.MaterialTextBox txtUserName;
        private System.Windows.Forms.DateTimePicker dTBirth;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialTextBox txtLastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer;
    }
}