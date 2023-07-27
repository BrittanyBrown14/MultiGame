using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace MultiGame
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            labelFalse();
            playerId();

           
        }
        int x = 0;
        Color SpaceCadet = Color.FromArgb (45, 48, 71);


        private void labelTrue()
        {
            gameLabel1.Enabled = true;
            gameLabel2.Enabled = true;
            gameLabel3.Enabled = true;
            gameLabel4.Enabled = true;
            gameLabel5.Enabled = true;
            gameLabel6.Enabled = true;
            gameLabel7.Enabled = true;
            gameLabel8.Enabled = true;
            gameLabel9.Enabled = true;
        }

        private void labelFalse()
        {
            gameLabel1.Enabled = false;
            gameLabel2.Enabled = false;
            gameLabel3.Enabled = false;
            gameLabel4.Enabled = false;
            gameLabel5.Enabled = false;
            gameLabel6.Enabled = false;
            gameLabel7.Enabled = false;
            gameLabel8.Enabled = false;
            gameLabel9.Enabled = false;
        }

        private void noText()
        {
            gameLabel1.Text = "";
            gameLabel2.Text = "";
            gameLabel3.Text = "";
            gameLabel4.Text = "";
            gameLabel5.Text = "";
            gameLabel6.Text = "";
            gameLabel7.Text = "";
            gameLabel8.Text = "";
            gameLabel9.Text = "";

            gameLabel1.ForeColor = Color.White;
            gameLabel2.ForeColor = Color.White;
            gameLabel3.ForeColor = Color.White;
            gameLabel4.ForeColor = Color.White;
            gameLabel5.ForeColor = Color.White;
            gameLabel6.ForeColor = Color.White;
            gameLabel7.ForeColor = Color.White;
            gameLabel8.ForeColor = Color.White;
            gameLabel9.ForeColor = Color.White;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            noText();
            label1.BackColor = Color.Maroon;;
            labelTrue();
            gameBox.Enabled = true;
            resetButton.Enabled = false;
            x = 0;
        }

        private void gameLabel1_Click(object sender, EventArgs e)
        {

            x++;
            while (label1.BackColor == Color.Maroon)
            {
                if (gameLabel1.Text == "")
                {
                    gameLabel1.Text = "X";
                    label1.BackColor = SpaceCadet;

                    label2.BackColor = Color.Maroon;
                    p1Win();
                }
                else if (gameLabel1.Text == "" && label1.BackColor == SpaceCadet)
                {
                    gameLabel1.Text = "0";
                    label1.BackColor = Color.Maroon;
                    label2.BackColor = SpaceCadet;
                }
                else
                {
                    return;
                }
            }

            while (label2.BackColor == Color.Maroon)
            {
                if (gameLabel1.Text == "")
                {
                    gameLabel1.Text = "O";
                    label1.BackColor = Color.Maroon;
                    label2.BackColor = SpaceCadet;
                    p2Win();
                }
                else if (gameLabel1.Text == "" && label2.BackColor == SpaceCadet)
                {
                    gameLabel1.Text = "X";
                    label1.BackColor = Color.Maroon;
                    label2.BackColor = SpaceCadet;
                }
                else
                {
                    
                    return;
                }
            }
        }

        private void gameLabel2_Click(object sender, EventArgs e)
        {
            x++;
            while (label1.BackColor == Color.Maroon)
            {
                if (gameLabel2.Text == "")
                {
                    gameLabel2.Text = "X";
                    label1.BackColor = SpaceCadet;
                    label2.BackColor = Color.Maroon;
                    p1Win();
                    
                }
                else if (gameLabel2.Text == "" && label1.BackColor == SpaceCadet)
                {
                    gameLabel2.Text = "0";
                    label1.BackColor = Color.Maroon;
                    label2.BackColor = SpaceCadet;
                }
                else
                {
                    
                    return;
                }
            }

            while (label2.BackColor == Color.Maroon)
            {
                if (gameLabel2.Text == "")
                {
                    gameLabel2.Text = "O";
                    label1.BackColor = Color.Maroon;
                    label2.BackColor = SpaceCadet;
                    p2Win();
                    
                }
                else if (gameLabel2.Text == "" && label2.BackColor == SpaceCadet)
                {
                    gameLabel2.Text = "X";
                    label1.BackColor = Color.Maroon;
                    label2.BackColor = SpaceCadet;
                }
                else
                {
                    
                    return;
                }
            }
        }

        private void gameLabel3_Click(object sender, EventArgs e)
        {
            x++;
            while (label1.BackColor == Color.Maroon)
            {
                if (gameLabel3.Text == "")
                {
                    gameLabel3.Text = "X";
                    label1.BackColor = SpaceCadet;
                    label2.BackColor = Color.Maroon;
                    p1Win();
                    
                }
                else if (gameLabel3.Text == "" && label1.BackColor == SpaceCadet)
                {
                    gameLabel3.Text = "0";
                    label1.BackColor = Color.Maroon;
                    label2.BackColor = SpaceCadet;
                }
                else
                {
                    
                    return;
                }
            }

            while (label2.BackColor == Color.Maroon)
            {
                if (gameLabel3.Text == "")
                {
                    gameLabel3.Text = "O";
                    label1.BackColor = Color.Maroon;
                    label2.BackColor = SpaceCadet;
                    p2Win();
                    
                }
                else if (gameLabel3.Text == "" && label2.BackColor == SpaceCadet)
                {
                    gameLabel3.Text = "X";
                    label1.BackColor = Color.Maroon;
                    label2.BackColor = SpaceCadet;
                }
                else
                {
                    
                    return;
                }
            }

        }

        private void gameLabel4_Click(object sender, EventArgs e)
        {
            x++;
            while (label1.BackColor == Color.Maroon)
            {
                if (gameLabel4.Text == "")
                {
                    gameLabel4.Text = "X";
                    label1.BackColor = SpaceCadet;
                    label2.BackColor = Color.Maroon;
                    p1Win();
                    
                }
                else if (gameLabel4.Text == "" && label1.BackColor == SpaceCadet)
                {
                    gameLabel4.Text = "0";
                    label1.BackColor = Color.Maroon;
                    label2.BackColor = SpaceCadet;
                }
                else
                {
                    
                    return;
                }
            }

            while (label2.BackColor == Color.Maroon)
            {
                if (gameLabel4.Text == "")
                {
                    gameLabel4.Text = "O";
                    label1.BackColor = Color.Maroon;
                    label2.BackColor = SpaceCadet;
                    p2Win();
                    
                }
                else if (gameLabel4.Text == "" && label2.BackColor == SpaceCadet)
                {
                    gameLabel4.Text = "X";
                    label1.BackColor = Color.Maroon;
                    label2.BackColor = SpaceCadet;
                }
                else
                {
                    
                    return;
                }
            }
        }

        private void gameLabel5_Click(object sender, EventArgs e)
        {
            x++;
            
            while (label1.BackColor == Color.Maroon)
            {
                if (gameLabel5.Text == "")
                {
                    gameLabel5.Text = "X";
                    label1.BackColor = SpaceCadet;
                    label2.BackColor = Color.Maroon;
                    p1Win();
                    
                }
                else if (gameLabel5.Text == "" && label1.BackColor == SpaceCadet)
                {
                    gameLabel5.Text = "0";
                    label1.BackColor = Color.Maroon;
                    label2.BackColor = SpaceCadet;
                }
                else
                {
                    
                    return;
                }
            }

            while (label2.BackColor == Color.Maroon)
            {
                if (gameLabel5.Text == "")
                {
                    gameLabel5.Text = "O";
                    label1.BackColor = Color.Maroon;
                    label2.BackColor = SpaceCadet;
                    p2Win();
                    
                }
                else if (gameLabel5.Text == "" && label2.BackColor == SpaceCadet)
                {
                    gameLabel5.Text = "X";
                    label1.BackColor = Color.Maroon;
                    label2.BackColor = SpaceCadet;
                }
                else
                {
                    
                    return;
                }
            }
        }

        private void gameLabel6_Click(object sender, EventArgs e)
        {
            x++;
            
            while (label1.BackColor == Color.Maroon)
            {
                if (gameLabel6.Text == "")
                {
                    gameLabel6.Text = "X";
                    label1.BackColor = SpaceCadet;
                    label2.BackColor = Color.Maroon;
                    p1Win();
                    
                }
                else if (gameLabel6.Text == "" && label1.BackColor == SpaceCadet)
                {
                    gameLabel6.Text = "0";
                    label1.BackColor = Color.Maroon;
                    label2.BackColor = SpaceCadet;
                }
                else
                {
                    
                    return;
                }
            }

            while (label2.BackColor == Color.Maroon)
            {
                if (gameLabel6.Text == "")
                {
                    gameLabel6.Text = "O";
                    label1.BackColor = Color.Maroon;
                    label2.BackColor = SpaceCadet;
                    p2Win();
                    
                }
                else if (gameLabel6.Text == "" && label2.BackColor == SpaceCadet)
                {
                    gameLabel6.Text = "X";
                    label1.BackColor = Color.Maroon;
                    label2.BackColor = SpaceCadet;
                }
                else
                {
                    return;
                }
            }
        }

        private void gameLabel7_Click(object sender, EventArgs e)
        {
            x++;
            while (label1.BackColor == Color.Maroon)
            {
                if (gameLabel7.Text == "")
                {
                    gameLabel7.Text = "X";
                    label1.BackColor = SpaceCadet;
                    label2.BackColor = Color.Maroon;
                    p1Win();
                    
                }
                else if (gameLabel7.Text == "" && label1.BackColor == SpaceCadet)
                {
                    gameLabel7.Text = "0";
                    label1.BackColor = Color.Maroon;
                    label2.BackColor = SpaceCadet;
                }
                else
                {
                    
                    return;
                }
            }

            while (label2.BackColor == Color.Maroon)
            {
                if (gameLabel7.Text == "")
                {
                    gameLabel7.Text = "O";
                    label1.BackColor = Color.Maroon;
                    label2.BackColor = SpaceCadet;
                    p2Win();
                    
                }
                else if (gameLabel7.Text == "" && label2.BackColor == SpaceCadet)
                {
                    gameLabel7.Text = "X";
                    label1.BackColor = Color.Maroon;
                    label2.BackColor = SpaceCadet;
                }
                else
                {
                    
                    return;
                }
            }
        }

        private void gameLabel8_Click(object sender, EventArgs e)
        {
            x++;
            while (label1.BackColor == Color.Maroon)
            {
                if (gameLabel8.Text == "")
                {
                    gameLabel8.Text = "X";
                    label1.BackColor = SpaceCadet;
                    label2.BackColor = Color.Maroon;
                    p1Win();
                    
                }
                else if (gameLabel8.Text == "" && label1.BackColor == SpaceCadet)
                {
                    gameLabel8.Text = "0";
                    label1.BackColor = Color.Maroon;
                    label2.BackColor = SpaceCadet;
                }
                else
                {
                    return;
                }
            }

            while (label2.BackColor == Color.Maroon)
            {
                if (gameLabel8.Text == "")
                {
                    gameLabel8.Text = "O";
                    label1.BackColor = Color.Maroon;
                    label2.BackColor = SpaceCadet;
                    p2Win();
                    
                }
                else if (gameLabel8.Text == "" && label2.BackColor == SpaceCadet)
                {
                    gameLabel8.Text = "X";
                    label1.BackColor = Color.Maroon;
                    label2.BackColor = SpaceCadet;
                }
                else
                {                    
                    return;
                }
            }
        }

        private void gameLabel9_Click(object sender, EventArgs e)
        {
            x++;
           
            while (label1.BackColor == Color.Maroon)
            {
                if (gameLabel9.Text == "")
                {
                    gameLabel9.Text = "X";
                    label1.BackColor = SpaceCadet;
                    label2.BackColor = Color.Maroon;
                    p1Win();
                    
                }
                else if (gameLabel9.Text == "" && label1.BackColor == SpaceCadet)
                {
                    gameLabel9.Text = "0";
                    label1.BackColor = Color.Maroon;
                    label2.BackColor = SpaceCadet;
                }
                else
                {
                    
                    return;
                }
            }

            while (label2.BackColor == Color.Maroon)
            {
                if (gameLabel9.Text == "")
                {
                    gameLabel9.Text = "O";
                    label1.BackColor = Color.Maroon;
                    label2.BackColor = SpaceCadet;
                    p2Win();
                    
                }
                else if (gameLabel9.Text == "" && label2.BackColor == SpaceCadet)
                {
                    gameLabel9.Text = "X";
                    label1.BackColor = Color.Maroon;
                    label2.BackColor = SpaceCadet;
                }
                else
                {
                    return;
                }
            }
            

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            noText();
            label1.BackColor = Color.Maroon;
            label2.BackColor = SpaceCadet;
            x = 0;
        }

        public void p1Win()
        {
            if (gameLabel1.Text == "X" && gameLabel2.Text == "X" && gameLabel3.Text == "X")
            {
                gameLabel1.ForeColor = Color.Crimson;
                gameLabel2.ForeColor = Color.Crimson;
                gameLabel3.ForeColor = Color.Crimson;

                MessageBox.Show("Player One is the Winner!!", "Winner!");
                resetButton.Enabled = true;
            }

            else if (gameLabel4.Text == "X" && gameLabel5.Text == "X" && gameLabel6.Text == "X")
            {
                gameLabel4.ForeColor = Color.Crimson;
                gameLabel5.ForeColor = Color.Crimson;
                gameLabel6.ForeColor = Color.Crimson;

                MessageBox.Show("Player One is the Winner!!", "Winner!");
                resetButton.Enabled = true;
            }

            else if (gameLabel7.Text == "X" && gameLabel8.Text == "X" && gameLabel9.Text == "X")
            {
                gameLabel7.ForeColor = Color.Crimson;
                gameLabel8.ForeColor = Color.Crimson;
                gameLabel9.ForeColor = Color.Crimson;

                MessageBox.Show("Player One is the Winner!!", "Winner!");
                resetButton.Enabled = true;
            }

            else if (gameLabel1.Text == "X" && gameLabel4.Text == "X" && gameLabel7.Text == "X")
            {
                gameLabel1.ForeColor = Color.Crimson;
                gameLabel4.ForeColor = Color.Crimson;
                gameLabel7.ForeColor = Color.Crimson;

                MessageBox.Show("Player One is the Winner!!", "Winner!");
                resetButton.Enabled = true;
            }

            else if (gameLabel2.Text == "X" && gameLabel5.Text == "X" && gameLabel8.Text == "X")
            {
                gameLabel2.ForeColor = Color.Crimson;
                gameLabel5.ForeColor = Color.Crimson;
                gameLabel8.ForeColor = Color.Crimson;

                MessageBox.Show("Player One is the Winner!!", "Winner!");
                resetButton.Enabled = true;
            }

            else if (gameLabel3.Text == "X" && gameLabel6.Text == "X" && gameLabel9.Text == "X")
            {
                gameLabel3.ForeColor = Color.Crimson;
                gameLabel6.ForeColor = Color.Crimson;
                gameLabel9.ForeColor = Color.Crimson;

                MessageBox.Show("Player One is the Winner!!", "Winner!");
                resetButton.Enabled = true;
            }

            else if (gameLabel1.Text == "X" && gameLabel5.Text == "X" && gameLabel9.Text == "X")
            {
                gameLabel1.ForeColor = Color.Crimson;
                gameLabel5.ForeColor = Color.Crimson;
                gameLabel9.ForeColor = Color.Crimson;

                MessageBox.Show("Player One is the Winner!!", "Winner!");
                resetButton.Enabled = true;
            }

            else if (gameLabel3.Text == "X" && gameLabel5.Text == "X" && gameLabel7.Text == "X")
            {
                gameLabel3.ForeColor = Color.Crimson;
                gameLabel5.ForeColor = Color.Crimson;
                gameLabel7.ForeColor = Color.Crimson;

                MessageBox.Show("Player One is the Winner!!", "Winner!");
                resetButton.Enabled = true;
            }
            else
            {
                counter();   
            }

        }
        public void p2Win()
        {
            if (gameLabel1.Text == "O" && gameLabel2.Text == "O" && gameLabel3.Text == "O")
            {
                gameLabel1.ForeColor = Color.Crimson;
                gameLabel2.ForeColor = Color.Crimson;
                gameLabel3.ForeColor = Color.Crimson;

                MessageBox.Show("Player Two is the Winner!!", "Winner!");
                resetButton.Enabled = true;
            }

            else if (gameLabel4.Text == "O" && gameLabel5.Text == "O" && gameLabel6.Text == "O")
            {
                gameLabel4.ForeColor = Color.Crimson;
                gameLabel5.ForeColor = Color.Crimson;
                gameLabel6.ForeColor = Color.Crimson;

                MessageBox.Show("Player Two is the Winner!!", "Winner!");
                resetButton.Enabled = true;
            }

            else if (gameLabel7.Text == "O" && gameLabel8.Text == "O" && gameLabel9.Text == "O")
            {
                gameLabel7.ForeColor = Color.Crimson;
                gameLabel8.ForeColor = Color.Crimson;
                gameLabel9.ForeColor = Color.Crimson;

                MessageBox.Show("Player Two is the Winner!!", "Winner!");
                resetButton.Enabled = true;
            }

            else if (gameLabel1.Text == "O" && gameLabel4.Text == "O" && gameLabel7.Text == "O")
            {
                gameLabel1.ForeColor = Color.Crimson;
                gameLabel4.ForeColor = Color.Crimson;
                gameLabel7.ForeColor = Color.Crimson;

                MessageBox.Show("Player Two is the Winner!!", "Winner!");
                resetButton.Enabled = true;
            }

            else if (gameLabel2.Text == "O" && gameLabel5.Text == "O" && gameLabel8.Text == "O")
            {
                gameLabel2.ForeColor = Color.Crimson;
                gameLabel5.ForeColor = Color.Crimson;
                gameLabel8.ForeColor = Color.Crimson;

                MessageBox.Show("Player Two is the Winner!!", "Winner!");
                resetButton.Enabled = true;
            }

            else if (gameLabel3.Text == "O" && gameLabel6.Text == "O" && gameLabel9.Text == "O")
            {
                gameLabel3.ForeColor = Color.Crimson;
                gameLabel6.ForeColor = Color.Crimson;
                gameLabel9.ForeColor = Color.Crimson;

                MessageBox.Show("Player Two is the Winner!!", "Winner!");
                resetButton.Enabled = true;
            }

            else if (gameLabel1.Text == "O" && gameLabel5.Text == "O" && gameLabel9.Text == "O")
            {
                gameLabel1.ForeColor = Color.Crimson;
                gameLabel5.ForeColor = Color.Crimson;
                gameLabel9.ForeColor = Color.Crimson;

                MessageBox.Show("Player Two is the Winner!!", "Winner!");
                resetButton.Enabled = true;
            }

            else if (gameLabel3.Text == "O" && gameLabel5.Text == "O" && gameLabel7.Text == "O")
            {
                gameLabel3.ForeColor = Color.Crimson;
                gameLabel5.ForeColor = Color.Crimson;
                gameLabel7.ForeColor = Color.Crimson;

                MessageBox.Show("Player Two is the Winner!!", "Winner!");
                resetButton.Enabled = true;
            }
            else
            {
                counter();
                return;
            }
        }
        public void counter()
        {

            if (x == 9 && gameLabel1.Text != "" && gameLabel2.Text != "" && gameLabel3.Text != "" &&
                gameLabel4.Text != "" && gameLabel5.Text != "" && gameLabel6.Text != "" &&
                gameLabel7.Text != "" && gameLabel8.Text != "" && gameLabel9.Text != "")
            {
                MessageBox.Show("There is no winner in this round.\nToo bad", "Draw!");
                resetButton.Enabled = true;

            }        

        }
        public void playerId()
        {
            string name1 = Interaction.InputBox("Name for Player 1", "Player Identification").ToString();
            string name2 = Interaction.InputBox("Name for Player 2", "Player Identification").ToString();

            label1.Text = name1;
            label2.Text = name2;

            if (name1 == null)
            {
                label1.Text = "Player 1";
            }
            else if (name2 == null)
            {
                label2.Text = "Player 2";
            }
        }

    }
}

