using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String[] gameBoard = new string[9];
        int currentTrun = 0;
        public String returnSymbol(int turn)
        {
            if (turn % 2 == 0)
            {
                return "O";
            }
            else
            {
                return "X";
            }
        }
        public System.Drawing.Color determineColor(String symbol)
        {
            if (symbol.Equals("O"))
            {
                return System.Drawing.Color.LightBlue;
            }
            else if (symbol.Equals("X"))
            {
                return System.Drawing.Color.LawnGreen;
            }
            return System.Drawing.Color.White;
        }
        public void checkforwinner()
        {
            for (int i = 0; i < 8; i++)
            {
                String combination = " ";
                int o = 0, t = 0, th = 0;

                switch (i)
                {
                    case 0:
                        combination = gameBoard[0] + gameBoard[4] + gameBoard[8];
                        o = 0;
                        t = 4;
                        th = 8;
                        break;
                    case 1:
                        combination = gameBoard[2] + gameBoard[4] + gameBoard[6];
                        o = 2;
                        t = 4;
                        th = 6;
                        break;
                    case 2:
                        combination = gameBoard[0] + gameBoard[1] + gameBoard[2];
                        o = 0;
                        t = 1;
                        th = 2;
                        break;
                    case 3:
                        combination = gameBoard[3] + gameBoard[4] + gameBoard[5];
                        o = 3;
                        t = 4;
                        th = 5;
                        break;
                    case 4:
                        combination = gameBoard[6] + gameBoard[7] + gameBoard[8];
                        o = 6;
                        t = 7;
                        th = 8;
                        break;
                    case 5:
                        combination = gameBoard[0] + gameBoard[3] + gameBoard[6];
                        o = 0;
                        t = 3;
                        th = 6;
                        break;
                    case 6:
                        combination = gameBoard[1] + gameBoard[4] + gameBoard[7];
                        o = 1;
                        t = 4;
                        th = 7;
                        break;
                    case 7:
                        combination = gameBoard[2] + gameBoard[4] + gameBoard[5];
                        o = 2;
                        t = 4;
                        th = 5;
                        break;
                }
                if (combination.Equals("OOO"))
                {
                    changeColor(o);
                    changeColor(t);
                    changeColor(th);

                    MessageBox.Show("O has won game", "We have a winner !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    reset();
                }
                else if (combination.Equals("XXX"))
                {
                    changeColor(o);
                    changeColor(t);
                    changeColor(th);
                    MessageBox.Show("X has won game", "We have a winner !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    reset();
                }
                checkdraw();

            }
        }
        public void reset()
        {
            b1.Text = "";
            b2.Text = "";
            b3.Text = "";
            b4.Text = "";
            b5.Text = "";
            b6.Text = "";
            b7.Text = "";
            b8.Text = "";
            b9.Text = "";
            b1.BackColor = System.Drawing.Color.White;
            b2.BackColor = System.Drawing.Color.White;
            b3.BackColor = System.Drawing.Color.White;
            b4.BackColor = System.Drawing.Color.White;
            b5.BackColor = System.Drawing.Color.White;
            b6.BackColor = System.Drawing.Color.White;
            b7.BackColor = System.Drawing.Color.White;
            b8.BackColor = System.Drawing.Color.White;
            b9.BackColor = System.Drawing.Color.White;
            gameBoard = new string[9];
            currentTrun = 0;
        }
        public void changeColor(int number)
        {
            switch (number)
            {
                case 0:
                    b1.BackColor = System.Drawing.Color.Red; break;
                case 1:
                    b2.BackColor = System.Drawing.Color.Red; break;
                case 2:
                    b3.BackColor = System.Drawing.Color.Red; break;
                case 3:
                    b4.BackColor = System.Drawing.Color.Red; break;
                case 4:
                    b5.BackColor = System.Drawing.Color.Red; break;
                case 5:
                    b6.BackColor = System.Drawing.Color.Red; break;
                case 6:
                    b7.BackColor = System.Drawing.Color.Red; break;
                case 7:
                    b8.BackColor = System.Drawing.Color.Red; break;
                case 8:
                    b9.BackColor = System.Drawing.Color.Red; break;
            }
        }
        public void checkdraw()
        {
            int counter = 0;
            for (int i = 0; i < gameBoard.Length; i++)
            {
                if (gameBoard[i] != null)
                {
                    counter++;
                }
                if (counter == 9)
                {
                    MessageBox.Show("That's Draw", "No winner Today:(", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //reset();
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentTrun++;
            gameBoard[0] = returnSymbol(currentTrun);
            Color buttoncolor = determineColor(gameBoard[0]);
            b1.BackColor = buttoncolor;
            b1.Text = gameBoard[0];
            checkforwinner();
        }



        private void b2_Click(object sender, EventArgs e)
        {
            currentTrun++;
            gameBoard[1] = returnSymbol(currentTrun);
            Color buttoncolor = determineColor(gameBoard[1]);
            b2.BackColor = buttoncolor;
            b2.Text = gameBoard[1];
            checkforwinner();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            currentTrun++;
            gameBoard[2] = returnSymbol(currentTrun);
            Color buttoncolor = determineColor(gameBoard[2]);
            b3.BackColor = buttoncolor;
            b3.Text = gameBoard[2];
            checkforwinner();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            currentTrun++;
            gameBoard[3] = returnSymbol(currentTrun);
            Color buttoncolor = determineColor(gameBoard[3]);
            b4.BackColor = buttoncolor;
            b4.Text = gameBoard[3];
            checkforwinner();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            currentTrun++;
            gameBoard[4] = returnSymbol(currentTrun);
            Color buttoncolor = determineColor(gameBoard[4]);
            b5.BackColor = buttoncolor;
            b5.Text = gameBoard[4];
            checkforwinner();
        }

        private void b6_Click(object sender, EventArgs e)
        {
            currentTrun++;
            gameBoard[5] = returnSymbol(currentTrun);
            Color buttoncolor = determineColor(gameBoard[5]);
            b6.BackColor = buttoncolor;
            b6.Text = gameBoard[5];
            checkforwinner();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            currentTrun++;
            gameBoard[6] = returnSymbol(currentTrun);
            Color buttoncolor = determineColor(gameBoard[6]);
            b7.BackColor = buttoncolor;
            b7.Text = gameBoard[6];
            checkforwinner();
        }


        private void b8_Click(object sender, EventArgs e)
        {
            currentTrun++;
            gameBoard[7] = returnSymbol(currentTrun);
            Color buttoncolor = determineColor(gameBoard[7]);
            b8.BackColor = buttoncolor;
            b8.Text = gameBoard[7];
            checkforwinner();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            currentTrun++;
            gameBoard[8] = returnSymbol(currentTrun);
            Color buttoncolor = determineColor(gameBoard[8]);
            b9.BackColor = buttoncolor;
            b9.Text = gameBoard[8];
            checkforwinner();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            reset();
        }
    }
}
