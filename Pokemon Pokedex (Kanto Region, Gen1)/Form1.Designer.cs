namespace Pokemon_Pokedex__Kanto_Region__Gen1_
{
    partial class Form1
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
            this.StartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Nuzlocke = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.StartButton.Location = new System.Drawing.Point(312, 281);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(152, 37);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Click Here to Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(603, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pokemon Pokedex (Kanto Region, 1st Gen)";
            // 
            // Nuzlocke
            // 
            this.Nuzlocke.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Nuzlocke.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuzlocke.Location = new System.Drawing.Point(312, 351);
            this.Nuzlocke.Name = "Nuzlocke";
            this.Nuzlocke.Size = new System.Drawing.Size(152, 39);
            this.Nuzlocke.TabIndex = 3;
            this.Nuzlocke.Text = "Nuzlocke information";
            this.Nuzlocke.UseVisualStyleBackColor = false;
            this.Nuzlocke.Click += new System.EventHandler(this.Nuzlocke_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pokemon_Pokedex__Kanto_Region__Gen1_.Properties.Resources.Wallpaper_Pikachu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Nuzlocke);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Nuzlocke;
    }
}

