using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen Pen = new Pen(Color.White, 10);

            // Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;


            e.Graphics.DrawLine(Pen, 300, 200, 600, 200);
            e.Graphics.DrawLine(Pen, 300, 300, 600, 300);
            e.Graphics.DrawLine(Pen, 400, 100, 400, 400);
            e.Graphics.DrawLine(Pen, 500, 100, 500, 400);
        }

        bool TopHorizontalSame()
        {
            return ((Convert.ToChar(pctTR.Tag) == Convert.ToChar(pctTM.Tag)) && (Convert.ToChar(pctTM.Tag) == Convert.ToChar(pctTL.Tag)) && (Convert.ToChar(pctTM.Tag) != 'Q'));
        }
        bool MiddleHorizontalSame()
        {
            return (Convert.ToChar(pctMR.Tag) == Convert.ToChar(pctMM.Tag) && Convert.ToChar(pctMM.Tag) == Convert.ToChar(pctML.Tag) && Convert.ToChar(pctML.Tag) != 'Q');
        }
        bool BottomHorizontalSame()
        {
            return (Convert.ToChar(pctBR.Tag) == Convert.ToChar(pctBM.Tag) && Convert.ToChar(pctBM.Tag) == Convert.ToChar(pctBL.Tag) && Convert.ToChar(pctBL.Tag) != 'Q');
        }
        bool LeftVerticalSame()
        {
            return (Convert.ToChar(pctTL.Tag) == Convert.ToChar(pctML.Tag) && Convert.ToChar(pctML.Tag) == Convert.ToChar(pctBL.Tag) && Convert.ToChar(pctBL.Tag) != 'Q');
        }
        bool MiddleVerticalSame()
        {
            return (Convert.ToChar(pctTM.Tag) == Convert.ToChar(pctMM.Tag) && Convert.ToChar(pctMM.Tag) == Convert.ToChar(pctBM.Tag) && Convert.ToChar(pctBM.Tag) != 'Q');
        }
        bool RightVerticalSame()
        {
            return (Convert.ToChar(pctTR.Tag) == Convert.ToChar(pctMR.Tag) && Convert.ToChar(pctMR.Tag) == Convert.ToChar(pctBR.Tag) && Convert.ToChar(pctBR.Tag) != 'Q');
        }
        bool LeftRightDiagonalSame()
        {
            return (Convert.ToChar(pctTL.Tag) == Convert.ToChar(pctMM.Tag) && Convert.ToChar(pctMM.Tag) == Convert.ToChar(pctBR.Tag) && Convert.ToChar(pctBR.Tag) != 'Q');
        }
        bool RightLeftDiagonalSame()
        {
            return (Convert.ToChar(pctTR.Tag) == Convert.ToChar(pctMM.Tag) && Convert.ToChar(pctMM.Tag) == Convert.ToChar(pctBL.Tag) && Convert.ToChar(pctMM.Tag) != 'Q');
        }
        bool GameOver()
        {
            if(TopHorizontalSame())
            { 
                pctTL.BackColor = Color.Green;
                pctTM.BackColor = Color.Green;
                pctTR.BackColor = Color.Green;
                return true; 
            }
            else if(BottomHorizontalSame())
            {
                pctBL.BackColor = Color.Green;
                pctBM.BackColor = Color.Green;
                pctBR.BackColor = Color.Green;
                return true; 
            }
            else if(MiddleHorizontalSame())
            {
                pctML.BackColor = Color.Green;
                pctMM.BackColor = Color.Green;
                pctMR.BackColor = Color.Green;
                return true; 
            }
            else if(LeftVerticalSame())
            {
                pctTL.BackColor = Color.Green;
                pctML.BackColor = Color.Green;
                pctBL.BackColor = Color.Green;
                return true;
            }
            else if(RightVerticalSame())
            {
                pctTR.BackColor = Color.Green;
                pctMR.BackColor = Color.Green;
                pctBR.BackColor = Color.Green;
                return true; 
            }
            else if(MiddleVerticalSame())
            {
                pctTM.BackColor = Color.Green;
                pctMM.BackColor = Color.Green;
                pctBM.BackColor = Color.Green;
                return true;
            }
            else if(LeftRightDiagonalSame())
            {
                pctTL.BackColor = Color.Green;
                pctMM.BackColor = Color.Green;
                pctBR.BackColor = Color.Green;
                return true;
            }
            else if(RightLeftDiagonalSame())
            {
                pctTR.BackColor = Color.Green;
                pctMM.BackColor = Color.Green;
                pctBL.BackColor = Color.Green;
                return true;
            }
            else { return false; }
        }

        void DisableBoard()
        {
            pctTL.Enabled = false;
            pctTM.Enabled = false;
            pctTR.Enabled = false;

            pctML.Enabled = false;
            pctMM.Enabled = false;
            pctMR.Enabled = false;

            pctBL.Enabled = false;
            pctBM.Enabled = false;
            pctBR.Enabled = false;
        }
        void EnableBoard()
        {
            pctTL.Enabled = true;
            pctTM.Enabled = true;
            pctTR.Enabled = true;

            pctML.Enabled = true;
            pctMM.Enabled = true;
            pctMR.Enabled = true;

            pctBL.Enabled = true;
            pctBM.Enabled = true;
            pctBR.Enabled = true;
        }

        bool isBoardFull()
        {
            return (Convert.ToChar(pctTL.Tag) != 'Q' && Convert.ToChar(pctTM.Tag) != 'Q'
                    && Convert.ToChar(pctTR.Tag) != 'Q' && Convert.ToChar(pctML.Tag) != 'Q'
                    && Convert.ToChar(pctMM.Tag) != 'Q' && Convert.ToChar(pctMR.Tag) != 'Q'
                    && Convert.ToChar(pctBL.Tag) != 'Q' && Convert.ToChar(pctBM.Tag) != 'Q'
                    && Convert.ToChar(pctBR.Tag) != 'Q');
        }

        void RestartWinner()
        {
            winner.Text = "In Progress";
        }
        void RestartTurn()
        {
            turn.Text = "Player 1";
            turn.Tag = '1';
        }
        void RestartBoardValues()
        {
            pctTL.Tag = 'Q';
            pctTM.Tag = 'Q';
            pctTR.Tag = 'Q';

            pctML.Tag = 'Q';
            pctMM.Tag = 'Q';
            pctMR.Tag = 'Q';

            pctBL.Tag = 'Q';
            pctBM.Tag = 'Q';
            pctBR.Tag = 'Q';
        }
        void RestartBoardImages()
        {
            pctTL.Image = Resources.Question;
            pctTL.BackColor = Color.Black;
            pctTM.Image = Resources.Question;
            pctTM.BackColor = Color.Black;
            pctTR.Image = Resources.Question;
            pctTR.BackColor = Color.Black;

            pctML.Image = Resources.Question;
            pctML.BackColor = Color.Black;
            pctMM.Image = Resources.Question;
            pctMM.BackColor = Color.Black;
            pctMR.Image = Resources.Question;
            pctMR.BackColor = Color.Black;

            pctBL.Image = Resources.Question;
            pctBL.BackColor = Color.Black;
            pctBM.Image = Resources.Question;
            pctBM.BackColor = Color.Black;
            pctBR.Image = Resources.Question;
            pctBR.BackColor = Color.Black;
        }
        void restartGame()
        {
            EnableBoard();
            RestartBoardImages();
            RestartBoardValues();
            RestartTurn();
            RestartWinner();
        }

        void picture_Click(PictureBox pictureBox)
        {
            if (Convert.ToChar(pictureBox.Tag) != 'Q')
                MessageBox.Show("Already taken by your opponent", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (Convert.ToChar(turn.Tag) == '1')
                {
                    pictureBox.Image = Resources.X;
                    pictureBox.Tag = 'X';
                    turn.Tag = '2';
                }
                else
                {
                    pictureBox.Image = Resources.O;
                    pictureBox.Tag = 'O';
                    turn.Tag = '1';
                }

                turn.Text = $"Player {turn.Tag}";

                if (GameOver())
                {
                    DisableBoard();
                    turn.Text = "Game Over";

                    winner.Text = (Convert.ToChar(turn.Tag) == '1') ? $"Player 2" : $"Player 1";
                }
                else if(isBoardFull())
                {
                    DisableBoard();
                    turn.Text = "Game Over";
                    winner.Text = "Draw";
                }
            }
        }

        private void picture_Click(object sender, EventArgs e)
        {
            picture_Click((PictureBox) sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            restartGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            restartGame();
        }
    }
}
