namespace ZombieShooter
{
    partial class Playground
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
            this.labelAmmo = new System.Windows.Forms.Label();
            this.labelKills = new System.Windows.Forms.Label();
            this.labelHealth = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // labelAmmo
            // 
            this.labelAmmo.AutoSize = true;
            this.labelAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmmo.ForeColor = System.Drawing.Color.White;
            this.labelAmmo.Location = new System.Drawing.Point(46, 61);
            this.labelAmmo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAmmo.Name = "labelAmmo";
            this.labelAmmo.Size = new System.Drawing.Size(134, 32);
            this.labelAmmo.TabIndex = 0;
            this.labelAmmo.Text = "Ammo: 0";
            // 
            // labelKills
            // 
            this.labelKills.AutoSize = true;
            this.labelKills.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKills.ForeColor = System.Drawing.Color.White;
            this.labelKills.Location = new System.Drawing.Point(298, 60);
            this.labelKills.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelKills.Name = "labelKills";
            this.labelKills.Size = new System.Drawing.Size(108, 32);
            this.labelKills.TabIndex = 1;
            this.labelKills.Text = "Kills: 0";
            // 
            // labelHealth
            // 
            this.labelHealth.AutoSize = true;
            this.labelHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHealth.ForeColor = System.Drawing.Color.White;
            this.labelHealth.Location = new System.Drawing.Point(523, 60);
            this.labelHealth.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelHealth.Name = "labelHealth";
            this.labelHealth.Size = new System.Drawing.Size(104, 32);
            this.labelHealth.TabIndex = 2;
            this.labelHealth.Text = "Health";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(650, 61);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(244, 32);
            this.progressBar1.TabIndex = 3;
            // 
            // Playground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(921, 658);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelHealth);
            this.Controls.Add(this.labelKills);
            this.Controls.Add(this.labelAmmo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Playground";
            this.Text = "Zombie Shooter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAmmo;
        private System.Windows.Forms.Label labelKills;
        private System.Windows.Forms.Label labelHealth;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

