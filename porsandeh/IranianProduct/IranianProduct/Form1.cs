using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IranianProduct
{
    public partial class Form1 : Form
    {
        int[] topBlock = new int[19];
        int[] leftBlock = new int[19];
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            topBlock[0] = pictureBox39.Top;
            leftBlock[0] = pictureBox39.Left;
            topBlock[1] = pictureBox40.Top;
            leftBlock[1] = pictureBox40.Left;
            topBlock[2] = pictureBox41.Top;
            leftBlock[2] = pictureBox41.Left;
            topBlock[3] = pictureBox42.Top;
            leftBlock[3] = pictureBox42.Left;
            topBlock[4] = pictureBox43.Top;
            leftBlock[4] = pictureBox43.Left;
            topBlock[5] = pictureBox44.Top;
            leftBlock[5] = pictureBox44.Left;
            topBlock[6] = pictureBox45.Top;
            leftBlock[6] = pictureBox45.Left;
            topBlock[7] = pictureBox46.Top;
            leftBlock[7] = pictureBox46.Left;
            topBlock[8] = pictureBox47.Top;
            leftBlock[8] = pictureBox47.Left;
            topBlock[9] = pictureBox48.Top;
            leftBlock[9] = pictureBox48.Left;
            topBlock[10] = pictureBox49.Top;
            leftBlock[10] = pictureBox49.Left;
            topBlock[11] = pictureBox50.Top;
            leftBlock[11] = pictureBox50.Left;
            topBlock[12] = pictureBox51.Top;
            leftBlock[12] = pictureBox51.Left;
            topBlock[13] = pictureBox52.Top;
            leftBlock[13] = pictureBox52.Left;
            topBlock[14] = pictureBox53.Top;
            leftBlock[14] = pictureBox53.Left;
            topBlock[15] = pictureBox54.Top;
            leftBlock[15] = pictureBox54.Left;
            topBlock[16] = pictureBox55.Top;
            leftBlock[16] = pictureBox55.Left;
            topBlock[17] = pictureBox56.Top;
            leftBlock[17] = pictureBox56.Left;
            topBlock[18] = pictureBox57.Top;
            leftBlock[18] = pictureBox57.Left;
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            bool check = false;
            for (int i = 0; i < 19; i++)
                if (picBoxMan.Left - 56 == leftBlock[i] && picBoxMan.Top == topBlock[i])
                    check = true;
            if (picBoxMan.Left - 56 > 17 && !check)
                picBoxMan.Left = picBoxMan.Left - 56;
            if ((picBoxMan.Top == picBoxForeign1.Top && picBoxMan.Left == picBoxForeign1.Left) || (picBoxMan.Top == picBoxForeign2.Top && picBoxMan.Left == picBoxForeign2.Left) || (picBoxMan.Top == picBoxForeign3.Top && picBoxMan.Left == picBoxForeign3.Left) || (picBoxMan.Top == picBoxForeign4.Top && picBoxMan.Left == picBoxForeign4.Left))
            {
                score--;
                label2.Text = score.ToString();
            }
            if ((picBoxMan.Top == picBoxCrab1.Top && picBoxMan.Left == picBoxCrab1.Left) || (picBoxMan.Top == picBoxCrab2.Top && picBoxMan.Left == picBoxCrab2.Left) || (picBoxMan.Top == picBoxCrab3.Top && picBoxMan.Left == picBoxCrab3.Left))
            {
                score -= 3;
                label2.Text = score.ToString();
            }
            if ((picBoxMan.Top == picBoxIran1.Top && picBoxMan.Left == picBoxIran1.Left) || (picBoxMan.Top == picBoxIran2.Top && picBoxMan.Left == picBoxIran2.Left) || (picBoxMan.Top == picBoxIran3.Top && picBoxMan.Left == picBoxIran3.Left) || (picBoxMan.Top == picBoxIran4.Top && picBoxMan.Left == picBoxIran4.Left))
            {
                score++;
                label2.Text = score.ToString();
            }

        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            bool check = false;
            for (int i = 0; i < 19; i++)
                if (picBoxMan.Left + 56 == leftBlock[i] && picBoxMan.Top == topBlock[i])
                    check = true;
            if (picBoxMan.Left + 56 < 536 && !check)
                picBoxMan.Left = picBoxMan.Left + 56;
            if ((picBoxMan.Top == picBoxForeign1.Top && picBoxMan.Left == picBoxForeign1.Left) || (picBoxMan.Top == picBoxForeign2.Top && picBoxMan.Left == picBoxForeign2.Left) || (picBoxMan.Top == picBoxForeign3.Top && picBoxMan.Left == picBoxForeign3.Left) || (picBoxMan.Top == picBoxForeign4.Top && picBoxMan.Left == picBoxForeign4.Left))
            {
                score--;
                label2.Text = score.ToString();
            }
            if ((picBoxMan.Top == picBoxCrab1.Top && picBoxMan.Left == picBoxCrab1.Left) || (picBoxMan.Top == picBoxCrab2.Top && picBoxMan.Left == picBoxCrab2.Left) || (picBoxMan.Top == picBoxCrab3.Top && picBoxMan.Left == picBoxCrab3.Left))
            {
                score -= 3;
                label2.Text = score.ToString();
            }
            if ((picBoxMan.Top == picBoxIran1.Top && picBoxMan.Left == picBoxIran1.Left) || (picBoxMan.Top == picBoxIran2.Top && picBoxMan.Left == picBoxIran2.Left) || (picBoxMan.Top == picBoxIran3.Top && picBoxMan.Left == picBoxIran3.Left) || (picBoxMan.Top == picBoxIran4.Top && picBoxMan.Left == picBoxIran4.Left))
            {
                score++;
                label2.Text = score.ToString();
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            bool check = false;
            for (int i = 0; i < 19; i++)
                if (picBoxMan.Top + 56 == topBlock[i] && picBoxMan.Left == leftBlock[i])
                    check = true;
            if (picBoxMan.Top + 56 < 486 && !check)
                picBoxMan.Top = picBoxMan.Top + 56;
            if ((picBoxMan.Top == picBoxForeign1.Top && picBoxMan.Left == picBoxForeign1.Left) || (picBoxMan.Top == picBoxForeign2.Top && picBoxMan.Left == picBoxForeign2.Left) || (picBoxMan.Top == picBoxForeign3.Top && picBoxMan.Left == picBoxForeign3.Left) || (picBoxMan.Top == picBoxForeign4.Top && picBoxMan.Left == picBoxForeign4.Left))
            {
                score--;
                label2.Text = score.ToString();
            }
            if ((picBoxMan.Top == picBoxCrab1.Top && picBoxMan.Left == picBoxCrab1.Left) || (picBoxMan.Top == picBoxCrab2.Top && picBoxMan.Left == picBoxCrab2.Left) || (picBoxMan.Top == picBoxCrab3.Top && picBoxMan.Left == picBoxCrab3.Left))
            {
                score -= 3;
                label2.Text = score.ToString();
            }
            if ((picBoxMan.Top == picBoxIran1.Top && picBoxMan.Left == picBoxIran1.Left) || (picBoxMan.Top == picBoxIran2.Top && picBoxMan.Left == picBoxIran2.Left) || (picBoxMan.Top == picBoxIran3.Top && picBoxMan.Left == picBoxIran3.Left) || (picBoxMan.Top == picBoxIran4.Top && picBoxMan.Left == picBoxIran4.Left))
            {
                score++;
                label2.Text = score.ToString();
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            bool check = false;
            for (int i = 0; i < 19; i++)
                if (picBoxMan.Top - 56 == topBlock[i] && picBoxMan.Left == leftBlock[i])
                    check = true;
            if (picBoxMan.Top - 56 > 12 && !check)
                picBoxMan.Top = picBoxMan.Top - 56;
            if ((picBoxMan.Top == picBoxForeign1.Top && picBoxMan.Left == picBoxForeign1.Left) || (picBoxMan.Top == picBoxForeign2.Top && picBoxMan.Left == picBoxForeign2.Left) || (picBoxMan.Top == picBoxForeign3.Top && picBoxMan.Left == picBoxForeign3.Left) || (picBoxMan.Top == picBoxForeign4.Top && picBoxMan.Left == picBoxForeign4.Left))
            {
                score--;
                label2.Text = score.ToString();
            }
            if ((picBoxMan.Top == picBoxCrab1.Top && picBoxMan.Left == picBoxCrab1.Left) || (picBoxMan.Top == picBoxCrab2.Top && picBoxMan.Left == picBoxCrab2.Left) || (picBoxMan.Top == picBoxCrab3.Top && picBoxMan.Left == picBoxCrab3.Left))
            {
                score -= 3;
                label2.Text = score.ToString();
            }
            if ((picBoxMan.Top == picBoxIran1.Top && picBoxMan.Left == picBoxIran1.Left) || (picBoxMan.Top == picBoxIran2.Top && picBoxMan.Left == picBoxIran2.Left) || (picBoxMan.Top == picBoxIran3.Top && picBoxMan.Left == picBoxIran3.Left) || (picBoxMan.Top == picBoxIran4.Top && picBoxMan.Left == picBoxIran4.Left))
            {
                score++;
                label2.Text = score.ToString();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            score = 0;
            label2.Text = score.ToString();
            picBoxMan.Left = 237;
            picBoxMan.Top = 460;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                DialogResult result2;
                result2 = MessageBox.Show("آیا میخواهید از بازی خارج شوید ؟", "!اخطار", MessageBoxButtons.YesNo);
                if (result2 == DialogResult.Yes) 
                {
                    Application.Exit();
                }
        } 
    }
}
