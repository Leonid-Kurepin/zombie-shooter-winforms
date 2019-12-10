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
            this.components = new System.ComponentModel.Container();
            this.labelAmmo = new System.Windows.Forms.Label();
            this.labelKills = new System.Windows.Forms.Label();
            this.labelHealth = new System.Windows.Forms.Label();
            this.progressBarHealth = new System.Windows.Forms.ProgressBar();
            this.pictureBoxZombie1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.pictureBoxZombie2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxZombie3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZombie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZombie2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZombie3)).BeginInit();
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
            // progressBarHealth
            // 
            this.progressBarHealth.Location = new System.Drawing.Point(650, 61);
            this.progressBarHealth.Name = "progressBarHealth";
            this.progressBarHealth.Size = new System.Drawing.Size(244, 32);
            this.progressBarHealth.TabIndex = 3;
            // 
            // pictureBoxZombie1
            // 
            this.pictureBoxZombie1.Image = global::ZombieShooter.Properties.Resources.zdown;
            this.pictureBoxZombie1.Location = new System.Drawing.Point(90, 192);
            this.pictureBoxZombie1.Name = "pictureBoxZombie1";
            this.pictureBoxZombie1.Size = new System.Drawing.Size(71, 71);
            this.pictureBoxZombie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxZombie1.TabIndex = 4;
            this.pictureBoxZombie1.TabStop = false;
            this.pictureBoxZombie1.Tag = "zombie";
            // 
            // player
            // 
            this.player.Image = global::ZombieShooter.Properties.Resources.up;
            this.player.Location = new System.Drawing.Point(430, 266);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(71, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 5;
            this.player.TabStop = false;
            this.player.Tag = "player";
            // 
            // pictureBoxZombie2
            // 
            this.pictureBoxZombie2.Image = global::ZombieShooter.Properties.Resources.zdown;
            this.pictureBoxZombie2.Location = new System.Drawing.Point(760, 192);
            this.pictureBoxZombie2.Name = "pictureBoxZombie2";
            this.pictureBoxZombie2.Size = new System.Drawing.Size(71, 71);
            this.pictureBoxZombie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxZombie2.TabIndex = 6;
            this.pictureBoxZombie2.TabStop = false;
            this.pictureBoxZombie2.Tag = "zombie";
            // 
            // pictureBoxZombie3
            // 
            this.pictureBoxZombie3.Image = global::ZombieShooter.Properties.Resources.zup;
            this.pictureBoxZombie3.Location = new System.Drawing.Point(430, 514);
            this.pictureBoxZombie3.Name = "pictureBoxZombie3";
            this.pictureBoxZombie3.Size = new System.Drawing.Size(71, 71);
            this.pictureBoxZombie3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxZombie3.TabIndex = 7;
            this.pictureBoxZombie3.TabStop = false;
            this.pictureBoxZombie3.Tag = "zombie";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.GameEngine);
            // 
            // Playground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(921, 658);
            this.Controls.Add(this.pictureBoxZombie3);
            this.Controls.Add(this.pictureBoxZombie2);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBoxZombie1);
            this.Controls.Add(this.progressBarHealth);
            this.Controls.Add(this.labelHealth);
            this.Controls.Add(this.labelKills);
            this.Controls.Add(this.labelAmmo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Playground";
            this.Tag = "zombie";
            this.Text = "Zombie Shooter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZombie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZombie2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZombie3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAmmo;
        private System.Windows.Forms.Label labelKills;
        private System.Windows.Forms.Label labelHealth;
        private System.Windows.Forms.ProgressBar progressBarHealth;
        private System.Windows.Forms.PictureBox pictureBoxZombie1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox pictureBoxZombie2;
        private System.Windows.Forms.PictureBox pictureBoxZombie3;
        private System.Windows.Forms.Timer timer1;
    }
}

