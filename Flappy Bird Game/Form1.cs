using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird_Game
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 8;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;

            pipeTop.Left -= pipeSpeed;
            pipeBottom.Left -= pipeSpeed;
            
            pipeTop2.Left -= pipeSpeed;
            pipeBottom2.Left -= pipeSpeed;

            //pipeTop.Top = -80; //(Top limit = -400, Bottom limit = -80)
            //pipeBottom.Top = 440; //(Top limit = 120, Bottom limit = 440)

            scoreText.Text = "Score:" + score;

            if (pipeTop.Left < -80)
            {
                pipeTop.Left = 500;
                pipeBottom.Left = 500;
                pipeTop.Top = randomPipePostion();
                pipeBottom.Top = pipeTop.Top + 520;
                score++;
            }

            if (pipeTop2.Left < -80)
            {
                pipeTop2.Left = 500;
                pipeBottom2.Left = 500;
                pipeTop2.Top = randomPipePostion();
                pipeBottom2.Top = pipeTop2.Top + 520;
                score++;
            }


            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) || flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) || flappyBird.Bounds.IntersectsWith(ground.Bounds) || flappyBird.Top < -5) { endGame(); };

            if (flappyBird.Bounds.IntersectsWith(pipeBottom2.Bounds) || flappyBird.Bounds.IntersectsWith(pipeTop2.Bounds) || flappyBird.Bounds.IntersectsWith(ground.Bounds) || flappyBird.Top < -5) { endGame(); };

        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) gravity = -8;
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) gravity = 8;
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text = score.ToString() + " Game Over!!!";
        }

        private int randomPipePostion()
        {
            Random rand = new Random();
            int number = rand.Next(-400, -80);

            return number;
        }

    }
}