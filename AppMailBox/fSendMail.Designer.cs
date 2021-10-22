
namespace AppMailBox
{
    partial class fSendMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSendMail));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuThưToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gửiMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chữĐậmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chữNghiênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chữGạchChânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaNộiDungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoThưMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSubjectMail = new MaterialSkin.Controls.MaterialTextBox();
            this.txtToMail = new MaterialSkin.Controls.MaterialTextBox();
            this.btnBrowser1 = new MaterialSkin.Controls.MaterialButton();
            this.txtFromMail = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtIdentification = new MaterialSkin.Controls.MaterialTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPathAttach = new MaterialSkin.Controls.MaterialTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rTxtContent = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.mailToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lưuThưToolStripMenuItem,
            this.gửiMailToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // lưuThưToolStripMenuItem
            // 
            this.lưuThưToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lưuThưToolStripMenuItem.Image")));
            this.lưuThưToolStripMenuItem.Name = "lưuThưToolStripMenuItem";
            this.lưuThưToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.lưuThưToolStripMenuItem.Text = "Save drafts";
            this.lưuThưToolStripMenuItem.Click += new System.EventHandler(this.lưuThưToolStripMenuItem_Click);
            // 
            // gửiMailToolStripMenuItem
            // 
            this.gửiMailToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gửiMailToolStripMenuItem.Image")));
            this.gửiMailToolStripMenuItem.Name = "gửiMailToolStripMenuItem";
            this.gửiMailToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.gửiMailToolStripMenuItem.Text = "Send mail";
            this.gửiMailToolStripMenuItem.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thoátToolStripMenuItem.Image")));
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.thoátToolStripMenuItem.Text = "Exit";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chữĐậmToolStripMenuItem,
            this.chữNghiênToolStripMenuItem,
            this.chữGạchChânToolStripMenuItem});
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // chữĐậmToolStripMenuItem
            // 
            this.chữĐậmToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("chữĐậmToolStripMenuItem.Image")));
            this.chữĐậmToolStripMenuItem.Name = "chữĐậmToolStripMenuItem";
            this.chữĐậmToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.chữĐậmToolStripMenuItem.Text = "Bold";
            this.chữĐậmToolStripMenuItem.Click += new System.EventHandler(this.chữĐậmToolStripMenuItem_Click);
            // 
            // chữNghiênToolStripMenuItem
            // 
            this.chữNghiênToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("chữNghiênToolStripMenuItem.Image")));
            this.chữNghiênToolStripMenuItem.Name = "chữNghiênToolStripMenuItem";
            this.chữNghiênToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.chữNghiênToolStripMenuItem.Text = "Italicized";
            this.chữNghiênToolStripMenuItem.Click += new System.EventHandler(this.chữNghiênToolStripMenuItem_Click);
            // 
            // chữGạchChânToolStripMenuItem
            // 
            this.chữGạchChânToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("chữGạchChânToolStripMenuItem.Image")));
            this.chữGạchChânToolStripMenuItem.Name = "chữGạchChânToolStripMenuItem";
            this.chữGạchChânToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.chữGạchChânToolStripMenuItem.Text = "Underline";
            this.chữGạchChânToolStripMenuItem.Click += new System.EventHandler(this.chữGạchChânToolStripMenuItem_Click);
            // 
            // mailToolStripMenuItem
            // 
            this.mailToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaNộiDungToolStripMenuItem,
            this.tạoThưMớiToolStripMenuItem});
            this.mailToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.mailToolStripMenuItem.Name = "mailToolStripMenuItem";
            this.mailToolStripMenuItem.Size = new System.Drawing.Size(45, 21);
            this.mailToolStripMenuItem.Text = "Mail";
            // 
            // xóaNộiDungToolStripMenuItem
            // 
            this.xóaNộiDungToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("xóaNộiDungToolStripMenuItem.Image")));
            this.xóaNộiDungToolStripMenuItem.Name = "xóaNộiDungToolStripMenuItem";
            this.xóaNộiDungToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.xóaNộiDungToolStripMenuItem.Text = "Delete content";
            this.xóaNộiDungToolStripMenuItem.Click += new System.EventHandler(this.xóaNộiDungToolStripMenuItem_Click);
            // 
            // tạoThưMớiToolStripMenuItem
            // 
            this.tạoThưMớiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tạoThưMớiToolStripMenuItem.Image")));
            this.tạoThưMớiToolStripMenuItem.Name = "tạoThưMớiToolStripMenuItem";
            this.tạoThưMớiToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.tạoThưMớiToolStripMenuItem.Text = "Create new mail";
            this.tạoThưMớiToolStripMenuItem.Click += new System.EventHandler(this.tạoThưMớiToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.txtSubjectMail);
            this.panel1.Controls.Add(this.txtToMail);
            this.panel1.Controls.Add(this.btnBrowser1);
            this.panel1.Controls.Add(this.txtFromMail);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 169);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            // 
            // txtSubjectMail
            // 
            this.txtSubjectMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubjectMail.Depth = 0;
            this.txtSubjectMail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSubjectMail.Hint = "Subject:";
            this.txtSubjectMail.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtSubjectMail.LeadingIcon")));
            this.txtSubjectMail.Location = new System.Drawing.Point(133, 113);
            this.txtSubjectMail.MaxLength = 50;
            this.txtSubjectMail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSubjectMail.Multiline = false;
            this.txtSubjectMail.Name = "txtSubjectMail";
            this.txtSubjectMail.Size = new System.Drawing.Size(664, 50);
            this.txtSubjectMail.TabIndex = 4;
            this.txtSubjectMail.Text = "";
            this.txtSubjectMail.TrailingIcon = null;
            // 
            // txtToMail
            // 
            this.txtToMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtToMail.Depth = 0;
            this.txtToMail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtToMail.Hint = "To:";
            this.txtToMail.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtToMail.LeadingIcon")));
            this.txtToMail.Location = new System.Drawing.Point(133, 60);
            this.txtToMail.MaxLength = 50;
            this.txtToMail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtToMail.Multiline = false;
            this.txtToMail.Name = "txtToMail";
            this.txtToMail.Size = new System.Drawing.Size(664, 50);
            this.txtToMail.TabIndex = 3;
            this.txtToMail.Text = "";
            this.txtToMail.TrailingIcon = null;
            // 
            // btnBrowser1
            // 
            this.btnBrowser1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowser1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBrowser1.Depth = 0;
            this.btnBrowser1.HighEmphasis = false;
            this.btnBrowser1.Icon = null;
            this.btnBrowser1.Location = new System.Drawing.Point(13, 119);
            this.btnBrowser1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBrowser1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBrowser1.Name = "btnBrowser1";
            this.btnBrowser1.Size = new System.Drawing.Size(102, 36);
            this.btnBrowser1.TabIndex = 7;
            this.btnBrowser1.Text = "Browser...";
            this.btnBrowser1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBrowser1.UseAccentColor = false;
            this.btnBrowser1.UseVisualStyleBackColor = true;
            this.btnBrowser1.Click += new System.EventHandler(this.btnBrowser1_Click);
            // 
            // txtFromMail
            // 
            this.txtFromMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFromMail.Depth = 0;
            this.txtFromMail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFromMail.Hint = "From:";
            this.txtFromMail.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtFromMail.LeadingIcon")));
            this.txtFromMail.Location = new System.Drawing.Point(133, 3);
            this.txtFromMail.MaxLength = 50;
            this.txtFromMail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFromMail.Multiline = false;
            this.txtFromMail.Name = "txtFromMail";
            this.txtFromMail.ReadOnly = true;
            this.txtFromMail.Size = new System.Drawing.Size(664, 50);
            this.txtFromMail.TabIndex = 2;
            this.txtFromMail.Text = "";
            this.txtFromMail.TrailingIcon = null;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.Location = new System.Drawing.Point(3, 3);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(124, 107);
            this.btnSend.TabIndex = 0;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 391);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(800, 70);
            this.panel6.TabIndex = 6;
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.txtIdentification);
            this.panel3.Location = new System.Drawing.Point(635, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 50);
            this.panel3.TabIndex = 2;
            // 
            // txtIdentification
            // 
            this.txtIdentification.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentification.Depth = 0;
            this.txtIdentification.Enabled = false;
            this.txtIdentification.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdentification.LeadingIcon = null;
            this.txtIdentification.Location = new System.Drawing.Point(0, 1);
            this.txtIdentification.MaxLength = 50;
            this.txtIdentification.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdentification.Multiline = false;
            this.txtIdentification.Name = "txtIdentification";
            this.txtIdentification.Size = new System.Drawing.Size(153, 50);
            this.txtIdentification.TabIndex = 8;
            this.txtIdentification.Text = "File: ";
            this.txtIdentification.TrailingIcon = null;
            this.txtIdentification.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.txtPathAttach);
            this.panel2.Location = new System.Drawing.Point(146, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 50);
            this.panel2.TabIndex = 1;
            // 
            // txtPathAttach
            // 
            this.txtPathAttach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPathAttach.Depth = 0;
            this.txtPathAttach.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPathAttach.Hint = "Path:";
            this.txtPathAttach.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtPathAttach.LeadingIcon")));
            this.txtPathAttach.Location = new System.Drawing.Point(0, 0);
            this.txtPathAttach.MaxLength = 50;
            this.txtPathAttach.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPathAttach.Multiline = false;
            this.txtPathAttach.Name = "txtPathAttach";
            this.txtPathAttach.Size = new System.Drawing.Size(483, 50);
            this.txtPathAttach.TabIndex = 6;
            this.txtPathAttach.Text = "";
            this.txtPathAttach.TrailingIcon = null;
            this.txtPathAttach.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(3, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Attachments:";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.rTxtContent);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 194);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(800, 197);
            this.panel5.TabIndex = 7;
            // 
            // rTxtContent
            // 
            this.rTxtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTxtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxtContent.Location = new System.Drawing.Point(0, 0);
            this.rTxtContent.Name = "rTxtContent";
            this.rTxtContent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rTxtContent.Size = new System.Drawing.Size(800, 197);
            this.rTxtContent.TabIndex = 0;
            this.rTxtContent.Text = "";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(761, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // fSendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fSendMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "No subject - Send mail";
            this.Load += new System.EventHandler(this.fSendMail_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuThưToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gửiMailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chữĐậmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chữNghiênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chữGạchChânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaNộiDungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoThưMớiToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox txtSubjectMail;
        private MaterialSkin.Controls.MaterialTextBox txtToMail;
        private MaterialSkin.Controls.MaterialButton btnBrowser1;
        private MaterialSkin.Controls.MaterialTextBox txtFromMail;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialTextBox txtIdentification;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialTextBox txtPathAttach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RichTextBox rTxtContent;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button button1;
    }
}