﻿namespace Train
{
    partial class FormAuthorization
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
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackgroundImage = global::Train.Properties.Resources.IconMenu;
            this.buttonMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonMenu.FlatAppearance.BorderSize = 0;
            this.buttonMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.Location = new System.Drawing.Point(425, 23);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(60, 60);
            this.buttonMenu.TabIndex = 5;
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackgroundImage = global::Train.Properties.Resources.крестик1;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(491, 23);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(60, 60);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(241)))), ((int)(((byte)(212)))));
            this.textBoxPassword.Font = new System.Drawing.Font("a_MachinaOrtoSls", 22.2F, System.Drawing.FontStyle.Bold);
            this.textBoxPassword.Location = new System.Drawing.Point(169, 467);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '/';
            this.textBoxPassword.Size = new System.Drawing.Size(316, 51);
            this.textBoxPassword.TabIndex = 6;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(241)))), ((int)(((byte)(212)))));
            this.textBoxLogin.Font = new System.Drawing.Font("a_MachinaOrtoSls", 22.2F, System.Drawing.FontStyle.Bold);
            this.textBoxLogin.Location = new System.Drawing.Point(169, 370);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(316, 51);
            this.textBoxLogin.TabIndex = 7;
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(26)))), ((int)(((byte)(12)))));
            this.buttonRegister.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(26)))), ((int)(((byte)(12)))));
            this.buttonRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(26)))), ((int)(((byte)(12)))));
            this.buttonRegister.Font = new System.Drawing.Font("a_MachinaOrtoSls", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(241)))), ((int)(((byte)(212)))));
            this.buttonRegister.Location = new System.Drawing.Point(127, 685);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(316, 49);
            this.buttonRegister.TabIndex = 8;
            this.buttonRegister.Text = "зарегистрироваться";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(241)))), ((int)(((byte)(212)))));
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(26)))), ((int)(((byte)(12)))));
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(26)))), ((int)(((byte)(12)))));
            this.buttonLogin.Font = new System.Drawing.Font("a_MachinaOrtoSls", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(26)))), ((int)(((byte)(12)))));
            this.buttonLogin.Location = new System.Drawing.Point(205, 603);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(161, 59);
            this.buttonLogin.TabIndex = 9;
            this.buttonLogin.Text = "войти";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // FormAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Train.Properties.Resources.форма_авторизации;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(575, 849);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAuthorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAuthorization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonLogin;
    }
}