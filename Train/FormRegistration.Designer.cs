namespace Train
{
    partial class FormRegistration
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
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.pictureBoxIconPassword = new System.Windows.Forms.PictureBox();
            this.pictureBoxIconLogin = new System.Windows.Forms.PictureBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelСonfirmPassword = new System.Windows.Forms.Label();
            this.pictureBoxСonfirmPassword = new System.Windows.Forms.PictureBox();
            this.textBoxСonfirmPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxСonfirmPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("a_MachinaOrtoSls", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelPassword.Location = new System.Drawing.Point(143, 393);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(80, 27);
            this.labelPassword.TabIndex = 20;
            this.labelPassword.Text = "пароль";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelLogin.Font = new System.Drawing.Font("a_MachinaOrtoSls", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(143, 292);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(67, 27);
            this.labelLogin.TabIndex = 19;
            this.labelLogin.Text = "логин";
            // 
            // pictureBoxIconPassword
            // 
            this.pictureBoxIconPassword.Image = global::Train.Properties.Resources.иконка_пароль;
            this.pictureBoxIconPassword.Location = new System.Drawing.Point(89, 423);
            this.pictureBoxIconPassword.Name = "pictureBoxIconPassword";
            this.pictureBoxIconPassword.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxIconPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIconPassword.TabIndex = 18;
            this.pictureBoxIconPassword.TabStop = false;
            // 
            // pictureBoxIconLogin
            // 
            this.pictureBoxIconLogin.Image = global::Train.Properties.Resources.иконка_логин;
            this.pictureBoxIconLogin.Location = new System.Drawing.Point(89, 322);
            this.pictureBoxIconLogin.Name = "pictureBoxIconLogin";
            this.pictureBoxIconLogin.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxIconLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIconLogin.TabIndex = 17;
            this.pictureBoxIconLogin.TabStop = false;
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
            this.buttonRegister.Location = new System.Drawing.Point(111, 641);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(316, 49);
            this.buttonRegister.TabIndex = 16;
            this.buttonRegister.Text = "зарегистрироваться";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(241)))), ((int)(((byte)(212)))));
            this.textBoxLogin.Font = new System.Drawing.Font("a_MachinaOrtoSls", 22.2F, System.Drawing.FontStyle.Bold);
            this.textBoxLogin.Location = new System.Drawing.Point(148, 322);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(322, 51);
            this.textBoxLogin.TabIndex = 15;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(241)))), ((int)(((byte)(212)))));
            this.textBoxPassword.Font = new System.Drawing.Font("a_MachinaOrtoSls", 22.2F, System.Drawing.FontStyle.Bold);
            this.textBoxPassword.Location = new System.Drawing.Point(148, 423);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '/';
            this.textBoxPassword.Size = new System.Drawing.Size(322, 51);
            this.textBoxPassword.TabIndex = 14;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelСonfirmPassword
            // 
            this.labelСonfirmPassword.AutoSize = true;
            this.labelСonfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelСonfirmPassword.Font = new System.Drawing.Font("a_MachinaOrtoSls", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelСonfirmPassword.Location = new System.Drawing.Point(143, 495);
            this.labelСonfirmPassword.Name = "labelСonfirmPassword";
            this.labelСonfirmPassword.Size = new System.Drawing.Size(184, 27);
            this.labelСonfirmPassword.TabIndex = 23;
            this.labelСonfirmPassword.Text = "повторите пароль";
            // 
            // pictureBoxСonfirmPassword
            // 
            this.pictureBoxСonfirmPassword.Image = global::Train.Properties.Resources.иконка_пароль;
            this.pictureBoxСonfirmPassword.Location = new System.Drawing.Point(89, 525);
            this.pictureBoxСonfirmPassword.Name = "pictureBoxСonfirmPassword";
            this.pictureBoxСonfirmPassword.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxСonfirmPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxСonfirmPassword.TabIndex = 22;
            this.pictureBoxСonfirmPassword.TabStop = false;
            // 
            // textBoxСonfirmPassword
            // 
            this.textBoxСonfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(241)))), ((int)(((byte)(212)))));
            this.textBoxСonfirmPassword.Font = new System.Drawing.Font("a_MachinaOrtoSls", 22.2F, System.Drawing.FontStyle.Bold);
            this.textBoxСonfirmPassword.Location = new System.Drawing.Point(148, 525);
            this.textBoxСonfirmPassword.Name = "textBoxСonfirmPassword";
            this.textBoxСonfirmPassword.PasswordChar = '/';
            this.textBoxСonfirmPassword.Size = new System.Drawing.Size(322, 51);
            this.textBoxСonfirmPassword.TabIndex = 21;
            this.textBoxСonfirmPassword.UseSystemPasswordChar = true;
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Train.Properties.Resources.форма_авторизации;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(557, 802);
            this.Controls.Add(this.labelСonfirmPassword);
            this.Controls.Add(this.pictureBoxСonfirmPassword);
            this.Controls.Add(this.textBoxСonfirmPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.pictureBoxIconPassword);
            this.Controls.Add(this.pictureBoxIconLogin);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Name = "FormRegistration";
            this.Text = "FormRegistration";
            this.Load += new System.EventHandler(this.FormRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxСonfirmPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.PictureBox pictureBoxIconPassword;
        private System.Windows.Forms.PictureBox pictureBoxIconLogin;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelСonfirmPassword;
        private System.Windows.Forms.PictureBox pictureBoxСonfirmPassword;
        private System.Windows.Forms.TextBox textBoxСonfirmPassword;
    }
}