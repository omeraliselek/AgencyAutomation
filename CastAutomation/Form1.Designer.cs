namespace CastAutomation
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.GrpBoxLogin = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.PictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.ChckRememberme = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GrpBoxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpBoxLogin
            // 
            this.GrpBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GrpBoxLogin.Controls.Add(this.linkLabel1);
            this.GrpBoxLogin.Controls.Add(this.PictureBoxLogin);
            this.GrpBoxLogin.Controls.Add(this.ChckRememberme);
            this.GrpBoxLogin.Controls.Add(this.label3);
            this.GrpBoxLogin.Controls.Add(this.label2);
            this.GrpBoxLogin.Controls.Add(this.BtnLogin);
            this.GrpBoxLogin.Controls.Add(this.TxtPassword);
            this.GrpBoxLogin.Controls.Add(this.TxtUserName);
            this.GrpBoxLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GrpBoxLogin.Location = new System.Drawing.Point(557, 25);
            this.GrpBoxLogin.Name = "GrpBoxLogin";
            this.GrpBoxLogin.Size = new System.Drawing.Size(351, 262);
            this.GrpBoxLogin.TabIndex = 0;
            this.GrpBoxLogin.TabStop = false;
            this.GrpBoxLogin.Text = "Login";
            this.GrpBoxLogin.UseWaitCursor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(22, 223);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(310, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "ÜYE GİRİŞİ YAPMADAN FORMLARI DOLAŞMAK İSTİYORUM";
            this.linkLabel1.UseWaitCursor = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // PictureBoxLogin
            // 
            this.PictureBoxLogin.Image = global::CastAutomation.Properties.Resources.uye_girisi_icon;
            this.PictureBoxLogin.Location = new System.Drawing.Point(149, 19);
            this.PictureBoxLogin.Name = "PictureBoxLogin";
            this.PictureBoxLogin.Size = new System.Drawing.Size(106, 74);
            this.PictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxLogin.TabIndex = 6;
            this.PictureBoxLogin.TabStop = false;
            this.PictureBoxLogin.UseWaitCursor = true;
            // 
            // ChckRememberme
            // 
            this.ChckRememberme.AutoSize = true;
            this.ChckRememberme.Location = new System.Drawing.Point(114, 176);
            this.ChckRememberme.Name = "ChckRememberme";
            this.ChckRememberme.Size = new System.Drawing.Size(94, 17);
            this.ChckRememberme.TabIndex = 5;
            this.ChckRememberme.Text = "Remember me";
            this.ChckRememberme.UseVisualStyleBackColor = true;
            this.ChckRememberme.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password :";
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Name :";
            this.label2.UseWaitCursor = true;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.White;
            this.BtnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnLogin.Location = new System.Drawing.Point(215, 171);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(90, 23);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "LOGİN";
            this.BtnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.UseWaitCursor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(114, 136);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(191, 20);
            this.TxtPassword.TabIndex = 1;
            this.TxtPassword.UseWaitCursor = true;
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(114, 102);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(191, 20);
            this.TxtUserName.TabIndex = 0;
            this.TxtUserName.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agency Management System";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(934, 326);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrpBoxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.Text = "LOGİN";
            this.GrpBoxLogin.ResumeLayout(false);
            this.GrpBoxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBoxLogin;
        private System.Windows.Forms.CheckBox ChckRememberme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PictureBoxLogin;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

