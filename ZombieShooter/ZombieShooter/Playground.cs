using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZombieShooter
{
    public partial class Playground : Form
    {
        private bool goUp;
        private bool goDown;
        private bool goRight;
        private bool goLeft;
        private string facing = "up"; // bullet direction
        private double playerHealth = 100;
        private int speed = 10;
        private int ammo = 10;
        private int zombieSpeed = 3;
        private int score = 0;
        private bool gameOver = false;
        Random rnd = new Random();

        public Playground()
        {
            InitializeComponent();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (gameOver)
            {
                return;
            }

            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                facing = "left";
                player.Image = Properties.Resources.left;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                facing = "right";
                player.Image = Properties.Resources.right;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                facing = "up";
                player.Image = Properties.Resources.up;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                facing = "down";
                player.Image = Properties.Resources.down;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (gameOver)
            {
                return;
            }

            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }

            // shoot by press the Space button
            if (e.KeyCode == Keys.Space && ammo > 0)
            {
                ammo--;

                Shoot(facing);

                if (ammo < 1)
                {
                    DropAmmo();
                }
            }
        }

        private void gameEngine(object sender, EventArgs e)
        {
            if (playerHealth > 1)
            {
                progressBar1.Value = Convert.ToInt32(playerHealth);
            }
            else
            {
                player.Image = Properties.Resources.dead;
                timer1.Stop();
                gameOver = true;
            }

            labelAmmo.Text = "Ammo:  " + ammo;
            labelKills.Text = "Kills:  " + score;

            if (playerHealth < 20)
            {
                progressBar1.ForeColor = Color.Red;
            }

            if (goLeft && (player.Left) > 0)
            {
                player.Left -= speed;
            }

            if (goRight && player.Right < this.Width)
            {
                player.Left += speed;
            }

            if (goUp && player.Top > 0)
            {
                player.Top -= speed;
            }

            if (goDown && player.Bottom < this.Height)
            {
                player.Top += speed;
            }

            foreach (Control c in this.Controls)
            {
                if (!(c is PictureBox) || c.Tag == null)
                {
                    continue;
                }

                var pictureBox = (PictureBox) c;

                // Ammo
                if (pictureBox.Tag.ToString().Equals("ammo"))
                {
                    if ((pictureBox).Bounds.IntersectsWith(player.Bounds))
                    {
                        this.Controls.Remove(pictureBox);
                        pictureBox.Dispose();

                        ammo += 5;
                    }
                }

                // Bullet
                if (pictureBox.Tag.ToString().Equals("bullet"))
                {
                    //Out of screen
                    if (pictureBox.Left < 1 ||
                        pictureBox.Right > this.Width ||
                        pictureBox.Top < 100 ||
                        pictureBox.Bottom > this.Height)
                    {
                        this.Controls.Remove(pictureBox);
                        pictureBox.Dispose();
                    }
                }

                //Zombie
                if (pictureBox.Tag.ToString().Equals("zombie"))
                {
                    if (pictureBox.Bounds.IntersectsWith(player.Bounds))
                    {
                        playerHealth -= 1;
                    }

                    // Go left
                    if (pictureBox.Left > player.Left)
                    {
                        pictureBox.Left -= zombieSpeed;
                        pictureBox.Image = Properties.Resources.zleft;
                    }

                    // Go right
                    if (pictureBox.Left < player.Left)
                    {
                        pictureBox.Left += zombieSpeed;
                        pictureBox.Image = Properties.Resources.zright;
                    }

                    // Go up
                    if (pictureBox.Top > player.Top)
                    {
                        pictureBox.Top -= zombieSpeed;
                        pictureBox.Image = Properties.Resources.zup;
                    }

                    // Go down
                    if (pictureBox.Top < player.Top)
                    {
                        pictureBox.Top += zombieSpeed;
                        pictureBox.Image = Properties.Resources.zdown;
                    }

                    foreach (Control bulletControl in this.Controls)
                    {
                        if (!(bulletControl is PictureBox) || 
                            bulletControl.Tag == null ||
                            !pictureBox.Tag.ToString().Equals("bullet"))
                        {
                            continue;
                        }

                        var bullet = (PictureBox) bulletControl;
                        var zombie = pictureBox;

                        // Bullet hits zombie
                        if (zombie.Bounds.IntersectsWith(bullet.Bounds))
                        {
                            this.Controls.Remove(bullet);
                            this.Controls.Remove(zombie);
                            bullet.Dispose();
                            zombie.Dispose();

                            score++;
                            MakeZombie();
                        }
                    }
                }
            }
        }

        private void DropAmmo()
        {
            var ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = rnd.Next(10, this.Width);
            ammo.Top = rnd.Next(110, this.Height);
            ammo.Tag = "ammo";
            ammo.BringToFront();
            player.BringToFront();
        }

        private void Shoot(string direction)
        {
        }
        private void MakeZombie()
        {

        }
    }
}
