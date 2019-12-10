using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZombieShooter
{
    class Bullet
    {
        public string Direction { get; set; }
        public int Speed { get; set; } = 20;
        public int Left { get; set; }
        public int Top { get; set; }

        private readonly PictureBox _bulletPictureBox;
        private readonly Timer _timer;

        public Bullet(Form form, string direction)
        {
            Direction = direction;

            _bulletPictureBox = new PictureBox();
            _timer = new Timer();

            _bulletPictureBox.BackColor = Color.White;
            _bulletPictureBox.Size = new Size(5, 5);
            _bulletPictureBox.Tag = "bullet";
            _bulletPictureBox.Left = Left;
            _bulletPictureBox.Top = Top;
            _bulletPictureBox.BringToFront();

            form.Controls.Add(_bulletPictureBox);

            _timer.Interval = Speed;
            _timer.Tick += new EventHandler(timer_Tick);
            _timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (Direction.Equals("left"))
            {
                _bulletPictureBox.Left -= Speed;
            }

            if (Direction.Equals("right"))
            {
                _bulletPictureBox.Left += Speed;
            }

            if (Direction.Equals("up"))
            {
                _bulletPictureBox.Top -= Speed;
            }

            if (Direction.Equals("down"))
            {
                _bulletPictureBox.Top += Speed;
            }
        }
    }
}
