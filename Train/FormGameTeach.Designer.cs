namespace Train
{
    partial class FormGameTeach
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
            this.labelRules = new System.Windows.Forms.Label();
            this.panelCards = new System.Windows.Forms.Panel();
            this.panelCardsSelectedLanguage = new System.Windows.Forms.Panel();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonNextCards = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.White;
            this.buttonMenu.BackgroundImage = global::Train.Properties.Resources.IconMenu;
            this.buttonMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonMenu.FlatAppearance.BorderSize = 0;
            this.buttonMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.Location = new System.Drawing.Point(1359, 12);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(50, 50);
            this.buttonMenu.TabIndex = 5;
            this.buttonMenu.UseVisualStyleBackColor = false;
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
            this.buttonClose.Location = new System.Drawing.Point(1415, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(50, 50);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelRules
            // 
            this.labelRules.AutoSize = true;
            this.labelRules.BackColor = System.Drawing.Color.Transparent;
            this.labelRules.Font = new System.Drawing.Font("a_MachinaOrtoSls", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRules.ForeColor = System.Drawing.Color.White;
            this.labelRules.Location = new System.Drawing.Point(247, 63);
            this.labelRules.Name = "labelRules";
            this.labelRules.Size = new System.Drawing.Size(55, 20);
            this.labelRules.TabIndex = 6;
            this.labelRules.Text = "label1";
            this.labelRules.Click += new System.EventHandler(this.labelRules_Click);
            // 
            // panelCards
            // 
            this.panelCards.BackColor = System.Drawing.Color.White;
            this.panelCards.Location = new System.Drawing.Point(841, 128);
            this.panelCards.Name = "panelCards";
            this.panelCards.Size = new System.Drawing.Size(295, 616);
            this.panelCards.TabIndex = 7;
            this.panelCards.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCards_Paint);
            // 
            // panelCardsSelectedLanguage
            // 
            this.panelCardsSelectedLanguage.BackColor = System.Drawing.Color.White;
            this.panelCardsSelectedLanguage.Location = new System.Drawing.Point(1170, 128);
            this.panelCardsSelectedLanguage.Name = "panelCardsSelectedLanguage";
            this.panelCardsSelectedLanguage.Size = new System.Drawing.Size(295, 616);
            this.panelCardsSelectedLanguage.TabIndex = 8;
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.White;
            this.buttonPlay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(26)))), ((int)(((byte)(12)))));
            this.buttonPlay.FlatAppearance.BorderSize = 6;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Font = new System.Drawing.Font("a_MachinaOrtoSls", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlay.Location = new System.Drawing.Point(1020, 34);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(233, 64);
            this.buttonPlay.TabIndex = 9;
            this.buttonPlay.Text = "играть";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonNextCards
            // 
            this.buttonNextCards.BackColor = System.Drawing.Color.White;
            this.buttonNextCards.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(26)))), ((int)(((byte)(12)))));
            this.buttonNextCards.FlatAppearance.BorderSize = 6;
            this.buttonNextCards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextCards.Font = new System.Drawing.Font("a_MachinaOrtoSls", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNextCards.Location = new System.Drawing.Point(814, 763);
            this.buttonNextCards.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNextCards.Name = "buttonNextCards";
            this.buttonNextCards.Size = new System.Drawing.Size(651, 66);
            this.buttonNextCards.TabIndex = 10;
            this.buttonNextCards.Text = "Показать следующие картинки";
            this.buttonNextCards.UseVisualStyleBackColor = false;
            this.buttonNextCards.Click += new System.EventHandler(this.buttonNextCards_Click);
            // 
            // FormGameTeach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Train.Properties.Resources.formGameTeach;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1482, 853);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonNextCards);
            this.Controls.Add(this.panelCardsSelectedLanguage);
            this.Controls.Add(this.panelCards);
            this.Controls.Add(this.labelRules);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGameTeach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGameTeach";
            this.Load += new System.EventHandler(this.FormGameTeach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelRules;
        private System.Windows.Forms.Panel panelCards;
        private System.Windows.Forms.Panel panelCardsSelectedLanguage;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonNextCards;
    }
}