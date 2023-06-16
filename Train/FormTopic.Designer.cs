namespace Train
{
    partial class FormTopic
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
            this.buttonFruitsVegetables = new System.Windows.Forms.Button();
            this.buttonAnimals = new System.Windows.Forms.Button();
            this.buttonNature = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFruitsVegetables
            // 
            this.buttonFruitsVegetables.Location = new System.Drawing.Point(273, 72);
            this.buttonFruitsVegetables.Name = "buttonFruitsVegetables";
            this.buttonFruitsVegetables.Size = new System.Drawing.Size(75, 23);
            this.buttonFruitsVegetables.TabIndex = 0;
            this.buttonFruitsVegetables.Text = "button1";
            this.buttonFruitsVegetables.UseVisualStyleBackColor = true;
            this.buttonFruitsVegetables.Click += new System.EventHandler(this.buttonFruitsVegetables_Click);
            // 
            // buttonAnimals
            // 
            this.buttonAnimals.Location = new System.Drawing.Point(273, 128);
            this.buttonAnimals.Name = "buttonAnimals";
            this.buttonAnimals.Size = new System.Drawing.Size(75, 23);
            this.buttonAnimals.TabIndex = 1;
            this.buttonAnimals.Text = "button2";
            this.buttonAnimals.UseVisualStyleBackColor = true;
            // 
            // buttonNature
            // 
            this.buttonNature.Location = new System.Drawing.Point(273, 190);
            this.buttonNature.Name = "buttonNature";
            this.buttonNature.Size = new System.Drawing.Size(75, 23);
            this.buttonNature.TabIndex = 2;
            this.buttonNature.Text = "button3";
            this.buttonNature.UseVisualStyleBackColor = true;
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
            this.buttonMenu.Location = new System.Drawing.Point(674, 12);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(60, 60);
            this.buttonMenu.TabIndex = 4;
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
            this.buttonClose.Location = new System.Drawing.Point(728, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(60, 60);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonNature);
            this.Controls.Add(this.buttonAnimals);
            this.Controls.Add(this.buttonFruitsVegetables);
            this.Name = "FormTopic";
            this.Text = "FormTopic";
            this.Load += new System.EventHandler(this.FormTopic_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFruitsVegetables;
        private System.Windows.Forms.Button buttonAnimals;
        private System.Windows.Forms.Button buttonNature;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonClose;
    }
}