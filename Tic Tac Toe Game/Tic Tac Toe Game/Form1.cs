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
        public String returnSymbol (int turn)
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
         public void checkforwinner()
        {
            for(int i =0; i < 8; i++)
            {
                String combination = " ";
                
                    switch (i)
                    {
                        case 0: combination = gameBoard[0] + gameBoard[4] + gameBoard[8];
                            break;
                        case 1: combination = gameBoard[2] + gameBoard[4] + gameBoard[6];
                            break;
                        case 2: combination = gameBoard[0] + gameBoard[1] + gameBoard[2];
                            break;
                        case 3: combination = gameBoard[3] + gameBoard[4] + gameBoard[5];
                            break;
                        case 4: combination = gameBoard[6] + gameBoard[7] + gameBoard[8];
                            break;
                        case 5: combination = gameBoard[0] + gameBoard[3] + gameBoard[6];
                            break;
                        case 6: combination = gameBoard[1] + gameBoard[4] + gameBoard[7];
                            break;
                        case 7: combination = gameBoard[2] + gameBoard[4] + gameBoard[5];
                            break;
                    }
                    if(combination.Equals ("OOO"))
                {
                    MessageBox.Show("O has won game", "We have a winner !",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    reset();
                }
                else if(combination.Equals("XXX"))
                {
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
            gameBoard = new string[9];
            currentTrun = 0;
        }
        public void checkdraw()
        {
            int counter = 0;
            for(int i = 0; i < gameBoard.Length; i++)
            {
                if (gameBoard[i] != null)
                {
                    counter++;
                }
                if (counter ==9)
                {
                    MessageBox.Show("That's Draw", "No winner Today:(", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    reset();
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
            b1.Text = gameBoard[0];
            checkforwinner();
        }

        

        private void b2_Click(object sender, EventArgs e)
        {
            currentTrun++;
            gameBoard[1] = returnSymbol(currentTrun);
            b2.Text = gameBoard[1];
            checkforwinner();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            currentTrun++;
            gameBoard[2] = returnSymbol(currentTrun);
            b3.Text = gameBoard[2];
            checkforwinner();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            currentTrun++;
            gameBoard[3] = returnSymbol(currentTrun);
            b4.Text = gameBoard[3];
            checkforwinner();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            currentTrun++;
            gameBoard[4] = returnSymbol(currentTrun);
            b5.Text = gameBoard[4];
            checkforwinner();
        }

        private void b6_Click(object sender, EventArgs e)
        {
            currentTrun++;
            gameBoard[5] = returnSymbol(currentTrun);
            b6.Text = gameBoard[5];
            checkforwinner();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            currentTrun++;
            gameBoard[6] = returnSymbol(currentTrun);
            b7.Text = gameBoard[6];
            checkforwinner();
        }
        

        private void b8_Click(object sender, EventArgs e)
        {
            currentTrun++;
            gameBoard[7] = returnSymbol(currentTrun);
            b8.Text = gameBoard[7];
            checkforwinner();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            currentTrun++;
            gameBoard[8] = returnSymbol(currentTrun);
            b9.Text = gameBoard[8];
            checkforwinner();
        }
    }
}
