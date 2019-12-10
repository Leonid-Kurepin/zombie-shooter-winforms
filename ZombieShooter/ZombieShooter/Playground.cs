using System;
using System.Drawing;
using System.Windows.Forms;

namespace ZombieShooter
{
    public partial class Playground : Form
    {
        private bool _goUp;
        private bool _goDown;
        private bool _goRight;
        private bool _goLeft;
        private string _facing = "up"; // shoot direction
        private double _playerHealth = 100;
        private int _speed = 10;
        private int _ammo = 10;
        private int _zombieSpeed = 3;
        private int _score = 0;
        private bool _gameOver = false;
        private readonly Random _rnd = new Random();

        public Playground()
        {
            InitializeComponent();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (_gameOver)
            {
                return;
            }

            if (e.KeyCode == Keys.Left)
            {
                _goLeft = true;
                _facing = "left";
                player.Image = Properties.Resources.left;
            }

            if (e.KeyCode == Keys.Right)
            {
                _goRight = true;
                _facing = "right";
                player.Image = Properties.Resources.right;
            }

            if (e.KeyCode == Keys.Up)
            {
                _goUp = true;
                _facing = "up";
                player.Image = Properties.Resources.up;
            }

            if (e.KeyCode == Keys.Down)
            {
                _goDown = true;
                _facing = "down";
                player.Image = Properties.Resources.down;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (_gameOver)
            {
                return;
            }

            if (e.KeyCode == Keys.Left)
            {
                _goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                _goRight = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                _goUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                _goDown = false;
            }

            // shoot by press the Space button
            if (e.KeyCode == Keys.Space && _ammo > 0)
            {
                _ammo--;

                Shoot(_facing);

                if (_ammo < 1)
                {
                    DropAmmo();
                }
            }
        }

        private void GameEngine(object sender, EventArgs e)
        {
            if (_playerHealth > 1)
            {
                progressBarHealth.Value = Convert.ToInt32(_playerHealth);
            }
            else
            {
                player.Image = Properties.Resources.dead;
                timer1.Stop();
                _gameOver = true;
            }

            labelAmmo.Text = "Ammo:  " + _ammo;
            labelKills.Text = "Kills:  " + _score;

            if (_playerHealth < 20)
            {
                progressBarHealth.ForeColor = Color.Red;
            }

            if (_goLeft && (player.Left) > 0)
            {
                player.Left -= _speed;
            }

            if (_goRight && player.Right < this.Width)
            {
                player.Left += _speed;
            }

            if (_goUp && player.Top > 100)
            {
                player.Top -= _speed;
            }

            if (_goDown && player.Bottom < this.Height)
            {
                player.Top += _speed;
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

                        _ammo += 5;
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
                        _playerHealth -= 1;
                    }

                    // Go left
                    if (pictureBox.Left > player.Left)
                    {
                        pictureBox.Left -= _zombieSpeed;
                        pictureBox.Image = Properties.Resources.zleft;
                    }

                    // Go right
                    if (pictureBox.Left < player.Left)
                    {
                        pictureBox.Left += _zombieSpeed;
                        pictureBox.Image = Properties.Resources.zright;
                    }

                    // Go up
                    if (pictureBox.Top > player.Top)
                    {
                        pictureBox.Top -= _zombieSpeed;
                        pictureBox.Image = Properties.Resources.zup;
                    }

                    // Go down
                    if (pictureBox.Top < player.Top)
                    {
                        pictureBox.Top += _zombieSpeed;
                        pictureBox.Image = Properties.Resources.zdown;
                    }

                    foreach (Control bulletControl in this.Controls)
                    {
                        if (!(bulletControl is PictureBox) ||
                            bulletControl.Tag == null ||
                            !bulletControl.Tag.ToString().Equals("bullet"))
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

                            _score++;
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
            ammo.Left = _rnd.Next(10, this.Width - 50);
            ammo.Top = _rnd.Next(110, this.Height - 50);
            ammo.Tag = "ammo";

            this.Controls.Add(ammo);
            ammo.BringToFront();
            player.BringToFront();
        }

        private void Shoot(string direction)
        {
            var left = player.Left + (player.Width / 2);
            var top = player.Top + (player.Width / 2);
            var bullet = new Bullet(this, direction, left, top);
        }

        private void MakeZombie()
        {
            PictureBox zombie = new PictureBox();
            zombie.Tag = "zombie";
            zombie.Image = Properties.Resources.zdown;
            zombie.Left = _rnd.Next(0, this.Width);
            zombie.Top = _rnd.Next(0, this.Height);
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;

            this.Controls.Add(zombie);
            player.BringToFront();
        }
    }
}
