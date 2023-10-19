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
        int boruHizi = 8;
        int gravity = 15;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            kus.Top += gravity;
            boruAlt.Left -= boruHizi;
            boruÜst.Left -= boruHizi;
            lblscore.Text = "Score: "+ score;
            if (boruAlt.Left<-150)
            {
                boruAlt.Left = 800;
                score++;
            }
            if (boruÜst.Left<-180)
            {
                boruÜst.Left = 950;
                score++;
            }
            if (kus.Bounds.IntersectsWith(boruAlt.Bounds)||kus.Bounds.IntersectsWith(boruÜst.Bounds)||kus.Bounds.IntersectsWith(zemin.Bounds))
            {
                endGame();
            }
            if (score>5)
            {
                boruHizi = 15;
            }
            if (score>20)
            {
                boruHizi = 30;
            }
            if (score>50)
            {
                boruHizi = 100; 
            }
            if (kus.Top<-25)
            {
                endGame();
            }
        }

        private void gamekeydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Space)
            {
                gravity = -15;
            }
        }

        private void gamekeyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }
        private void endGame()
        {
            gameTimer.Stop();
            lblscore.Text = "Game Over";
        }

    }
}
