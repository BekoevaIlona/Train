namespace Train
{
    partial class FormGame
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
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.timerTrainMove = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxLife = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLife)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.White;
            this.buttonMenu.BackgroundImage = global::Train.Properties.Resources.IconMenu;
            this.buttonMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(26)))), ((int)(((byte)(12)))));
            this.buttonMenu.FlatAppearance.BorderSize = 3;
            this.buttonMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.Location = new System.Drawing.Point(1407, 7);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(40, 40);
            this.buttonMenu.TabIndex = 3;
            this.buttonMenu.UseVisualStyleBackColor = false;
            // 
            // buttonClose
            // 
            this.buttonClose.BackgroundImage = global::Train.Properties.Resources.крестик1;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(26)))), ((int)(((byte)(12)))));
            this.buttonClose.FlatAppearance.BorderSize = 3;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(1453, 7);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(40, 40);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // timerTrainMove
            // 
            this.timerTrainMove.Enabled = true;
            this.timerTrainMove.Interval = 5;
            this.timerTrainMove.Tick += new System.EventHandler(this.timerTrainMove_Tick);
            // 
            // pictureBoxLife
            // 
            this.pictureBoxLife.Image = global::Train.Properties.Resources._5;
            this.pictureBoxLife.Location = new System.Drawing.Point(984, 765);
            this.pictureBoxLife.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLife.Name = "pictureBoxLife";
            this.pictureBoxLife.Size = new System.Drawing.Size(504, 124);
            this.pictureBoxLife.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLife.TabIndex = 25;
            this.pictureBoxLife.TabStop = false;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Train.Properties.Resources.FormGame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1500, 900);
            this.Controls.Add(this.pictureBoxLife);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGame";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.Shown += new System.EventHandler(this.FormGame_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLife)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Timer timerTrainMove;
        private System.Windows.Forms.PictureBox pictureBoxLife;
    }
}