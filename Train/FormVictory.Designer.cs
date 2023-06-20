namespace Train
{
    partial class FormVictory
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
            this.button7 = new System.Windows.Forms.Button();
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.buttonNO = new System.Windows.Forms.Button();
            this.buttonYES = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.BackgroundImage = global::Train.Properties.Resources.IconMenu;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(26)))), ((int)(((byte)(12)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(944, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 60);
            this.button7.TabIndex = 40;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCloseForm.BackgroundImage = global::Train.Properties.Resources.крестик1;
            this.buttonCloseForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCloseForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(26)))), ((int)(((byte)(12)))));
            this.buttonCloseForm.FlatAppearance.BorderSize = 0;
            this.buttonCloseForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonCloseForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseForm.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseForm.Location = new System.Drawing.Point(1010, 12);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(60, 60);
            this.buttonCloseForm.TabIndex = 39;
            this.buttonCloseForm.UseVisualStyleBackColor = true;
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // buttonNO
            // 
            this.buttonNO.BackColor = System.Drawing.Color.Transparent;
            this.buttonNO.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(26)))), ((int)(((byte)(12)))));
            this.buttonNO.FlatAppearance.BorderSize = 6;
            this.buttonNO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNO.Font = new System.Drawing.Font("a_MachinaOrtoSls", 16.2F, System.Drawing.FontStyle.Bold);
            this.buttonNO.Location = new System.Drawing.Point(605, 591);
            this.buttonNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNO.Name = "buttonNO";
            this.buttonNO.Size = new System.Drawing.Size(130, 51);
            this.buttonNO.TabIndex = 42;
            this.buttonNO.Text = "нет";
            this.buttonNO.UseVisualStyleBackColor = false;
            this.buttonNO.Click += new System.EventHandler(this.buttonNO_Click);
            // 
            // buttonYES
            // 
            this.buttonYES.BackColor = System.Drawing.Color.Transparent;
            this.buttonYES.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(26)))), ((int)(((byte)(12)))));
            this.buttonYES.FlatAppearance.BorderSize = 6;
            this.buttonYES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonYES.Font = new System.Drawing.Font("a_MachinaOrtoSls", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonYES.Location = new System.Drawing.Point(334, 591);
            this.buttonYES.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonYES.Name = "buttonYES";
            this.buttonYES.Size = new System.Drawing.Size(130, 51);
            this.buttonYES.TabIndex = 41;
            this.buttonYES.Text = "да";
            this.buttonYES.UseVisualStyleBackColor = false;
            this.buttonYES.Click += new System.EventHandler(this.buttonYES_Click);
            // 
            // FormVictory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Train.Properties.Resources.victory1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.buttonNO);
            this.Controls.Add(this.buttonYES);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonCloseForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVictory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVictory";
            this.Load += new System.EventHandler(this.FormVictory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonCloseForm;
        private System.Windows.Forms.Button buttonNO;
        private System.Windows.Forms.Button buttonYES;
    }
}