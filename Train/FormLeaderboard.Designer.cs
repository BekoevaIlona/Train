namespace Train
{
    partial class FormLeaderboard
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
            this.listBoxLeaderboard = new System.Windows.Forms.ListBox();
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
            this.buttonMenu.Location = new System.Drawing.Point(689, 39);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(60, 60);
            this.buttonMenu.TabIndex = 7;
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
            this.buttonClose.Location = new System.Drawing.Point(755, 39);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(60, 60);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // listBoxLeaderboard
            // 
            this.listBoxLeaderboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxLeaderboard.Font = new System.Drawing.Font("a_MachinaOrtoSls", 22.2F, System.Drawing.FontStyle.Bold);
            this.listBoxLeaderboard.FormattingEnabled = true;
            this.listBoxLeaderboard.ItemHeight = 43;
            this.listBoxLeaderboard.Location = new System.Drawing.Point(269, 285);
            this.listBoxLeaderboard.Name = "listBoxLeaderboard";
            this.listBoxLeaderboard.Size = new System.Drawing.Size(296, 430);
            this.listBoxLeaderboard.TabIndex = 8;
            this.listBoxLeaderboard.SelectedIndexChanged += new System.EventHandler(this.listBoxLeaderboard_SelectedIndexChanged);
            // 
            // FormLeaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Train.Properties.Resources.рейтинг1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(855, 847);
            this.Controls.Add(this.listBoxLeaderboard);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLeaderboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLeaderboard";
            this.Load += new System.EventHandler(this.FormLeaderboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ListBox listBoxLeaderboard;
    }
}