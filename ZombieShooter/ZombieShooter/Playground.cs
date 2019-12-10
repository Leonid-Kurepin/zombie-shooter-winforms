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
        private string facing = "up";
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

        }

        private void keyisup(object sender, KeyEventArgs e)
        {

        }

        private void gameEngine(object sender, EventArgs e)
        {

        }

        private void DropAmmo()
        {

        }

        private void Shoot(string direction)
        {

        }
        private void MakeZombie()
        {

        }
    }
}
