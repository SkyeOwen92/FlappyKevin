using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyKyle
{
    public partial class Form1 : Form
    {
        int gravity = 5;
        int pipeSpeed = 8;
        int nextLevel = 5;
        int score = 0;
        Random rnd = new Random();
        int placement = 2;
        bool gameOver = false;
        int highScore = 0; 
        public Form1()
        {
            InitializeComponent();
            Ground.Controls.Add(scoreTxt);
            scoreTxt.Left = 20;
            scoreTxt.Top = 25;
            Ground.Controls.Add(HighScore);
            HighScore.Left = 200;
            HighScore.Top = 70;
        }

        private void timerEvent(object sender, EventArgs e)
        {
            Kevin.Top += gravity;
            pt.Left -= pipeSpeed; 
            pb.Left -= pipeSpeed;
            pt1.Left -= pipeSpeed;
            pb1.Left -= pipeSpeed;
            scoreTxt.Text = "Score: " + score;
            HighScore.Text = "High Score: " + highScore;
            placement = rnd.Next(1,3);
            if( pt.Left < -150)
            {
                pb.Left = 800;
                pt.Left = 800;
                switch (placement)
                {
                    case 1:
                        pt.Top = -100;
                        pb.Top = 350;
                        break;
                    case 2:
                        pt.Top = -50;
                        pb.Top = 400;
                        break;
                    case 3:
                        pt.Top = -150;
                        pb.Top = 300;
                        break;
                }
                
                score++;
                placement = rnd.Next(1, 3);
                if (score >= highScore)
                {
                    highScore = score;
                }
            }
            if (pt1.Left < -150)
            {
                pb1.Left = 800;
                pt1.Left = 800;
                switch (placement)
                {
                    case 1:
                        pt1.Top = -100;
                        pb1.Top = 350;
                        break;
                    case 2:
                        pt1.Top = -50;
                        pb1.Top = 400;
                        break;
                    case 3:
                        pt1.Top = -150;
                        pb1.Top = 300;
                        break;
                }
                score++;
                placement = rnd.Next(1, 3);
                if (score >= highScore)
                {
                    highScore = score;
                }
            }
            if (score > nextLevel)
            {
                pipeSpeed += 3;
                nextLevel += 5; 
            }
            if(Kevin.Bounds.IntersectsWith(pb.Bounds) ||
                Kevin.Bounds.IntersectsWith(pb1.Bounds) ||
                Kevin.Bounds.IntersectsWith(pt.Bounds) ||
                Kevin.Bounds.IntersectsWith(pt1.Bounds) ||
                Kevin.Bounds.IntersectsWith(Ground.Bounds) ||
                Kevin.Top < -5 )
            {
                EndGame();
            }

        }

        private void IsPressed(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            gravity = -5;
            if (e.KeyCode == Keys.R && gameOver)
            Restart();
        }


        private void IsReleased(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            gravity = 5;
        }
        private void EndGame()
        {
            
            GameClock.Stop();
            scoreTxt.Text += " Game Over! Press R to try again.";
            gameOver = true;
            
        }
        private void Restart()
        {
            gameOver = false;
            Kevin.Location = new Point(148, 222);
            gravity = 5;
            pipeSpeed = 8;
            nextLevel = 5;
            score = 0;
            scoreTxt.Text = "Score: " + score;
            pb.Left = 400;
            pt.Left = 400;
            pb1.Left = 800;
            pt1.Left = 800;
            pt.Top = -100;
            pb.Top = 350;
            pt1.Top = -50;
            pb1.Top = 400;
            GameClock.Start();
        }
    }
}
