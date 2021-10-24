
namespace AppMailBox
{
    partial class fFeedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fFeedback));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSendFB = new System.Windows.Forms.Button();
            this.rtxFeedback = new System.Windows.Forms.RichTextBox();
            this.btnS5 = new System.Windows.Forms.Button();
            this.btnS4 = new System.Windows.Forms.Button();
            this.btnS3 = new System.Windows.Forms.Button();
            this.btnS2 = new System.Windows.Forms.Button();
            this.btnS1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 54);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(185, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your Feedback";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "MailBox   ";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnSendFB);
            this.panel2.Controls.Add(this.rtxFeedback);
            this.panel2.Controls.Add(this.btnS5);
            this.panel2.Controls.Add(this.btnS4);
            this.panel2.Controls.Add(this.btnS3);
            this.panel2.Controls.Add(this.btnS2);
            this.panel2.Controls.Add(this.btnS1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 357);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnClose.Location = new System.Drawing.Point(309, 285);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSendFB
            // 
            this.btnSendFB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnSendFB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSendFB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendFB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSendFB.Location = new System.Drawing.Point(203, 285);
            this.btnSendFB.Name = "btnSendFB";
            this.btnSendFB.Size = new System.Drawing.Size(100, 30);
            this.btnSendFB.TabIndex = 8;
            this.btnSendFB.Text = "Send";
            this.btnSendFB.UseVisualStyleBackColor = false;
            this.btnSendFB.Click += new System.EventHandler(this.btnSendFB_Click);
            // 
            // rtxFeedback
            // 
            this.rtxFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxFeedback.Location = new System.Drawing.Point(12, 182);
            this.rtxFeedback.Name = "rtxFeedback";
            this.rtxFeedback.Size = new System.Drawing.Size(397, 96);
            this.rtxFeedback.TabIndex = 7;
            this.rtxFeedback.Text = "";
            // 
            // btnS5
            // 
            this.btnS5.Image = ((System.Drawing.Image)(resources.GetObject("btnS5.Image")));
            this.btnS5.Location = new System.Drawing.Point(287, 103);
            this.btnS5.Name = "btnS5";
            this.btnS5.Size = new System.Drawing.Size(45, 45);
            this.btnS5.TabIndex = 6;
            this.btnS5.UseVisualStyleBackColor = true;
            this.btnS5.Click += new System.EventHandler(this.btnS5_Click);
            // 
            // btnS4
            // 
            this.btnS4.Image = ((System.Drawing.Image)(resources.GetObject("btnS4.Image")));
            this.btnS4.Location = new System.Drawing.Point(236, 103);
            this.btnS4.Name = "btnS4";
            this.btnS4.Size = new System.Drawing.Size(45, 45);
            this.btnS4.TabIndex = 5;
            this.btnS4.UseVisualStyleBackColor = true;
            this.btnS4.Click += new System.EventHandler(this.btnS4_Click);
            // 
            // btnS3
            // 
            this.btnS3.Image = ((System.Drawing.Image)(resources.GetObject("btnS3.Image")));
            this.btnS3.Location = new System.Drawing.Point(185, 103);
            this.btnS3.Name = "btnS3";
            this.btnS3.Size = new System.Drawing.Size(45, 45);
            this.btnS3.TabIndex = 4;
            this.btnS3.UseVisualStyleBackColor = true;
            this.btnS3.Click += new System.EventHandler(this.btnS3_Click);
            // 
            // btnS2
            // 
            this.btnS2.Image = ((System.Drawing.Image)(resources.GetObject("btnS2.Image")));
            this.btnS2.Location = new System.Drawing.Point(134, 103);
            this.btnS2.Name = "btnS2";
            this.btnS2.Size = new System.Drawing.Size(45, 45);
            this.btnS2.TabIndex = 3;
            this.btnS2.UseVisualStyleBackColor = true;
            this.btnS2.Click += new System.EventHandler(this.btnS2_Click);
            // 
            // btnS1
            // 
            this.btnS1.BackColor = System.Drawing.Color.FloralWhite;
            this.btnS1.Image = ((System.Drawing.Image)(resources.GetObject("btnS1.Image")));
            this.btnS1.Location = new System.Drawing.Point(83, 103);
            this.btnS1.Name = "btnS1";
            this.btnS1.Size = new System.Drawing.Size(45, 45);
            this.btnS1.TabIndex = 2;
            this.btnS1.UseVisualStyleBackColor = false;
            this.btnS1.Click += new System.EventHandler(this.btnS1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "What is your opinion of this page?";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "We would like your feedback to improve out application";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // fFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 411);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fFeedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feedback";
            this.Load += new System.EventHandler(this.fFeedback_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnS5;
        private System.Windows.Forms.Button btnS4;
        private System.Windows.Forms.Button btnS3;
        private System.Windows.Forms.Button btnS2;
        private System.Windows.Forms.Button btnS1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSendFB;
        private System.Windows.Forms.RichTextBox rtxFeedback;
    }
}