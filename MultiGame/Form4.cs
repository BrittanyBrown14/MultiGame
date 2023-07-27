using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiGame
{
    public partial class Form4 : Form
    {
            //Create a random object called randomizer
            //to generate random numbers
            Random randomizer = new Random();

            //these intereger variables store the number
            // for the addition problems
            int addend1;
            int addend2;

            //these intereger variables store the number
            // for the subtraction problems
            int minuend;
            int subtrahend;

            //these integer variables store the numbers
            // for the multiplication problem.
            int multiplicand;
            int multiplier;

            //these interger varible store the number
            //for the divition problems
            int dividend;
            int divisor;

            //this integer variable keeps track if the remaining
            // time.
            int timeLeft;

            public Form4()
            {
                InitializeComponent();
            }

            public void StartTheQuiz()
            {
                AddProblem();
                SubProblem();
                MultiProblem();
                DivProblem();

                //start the timer
                timeLeft = 30;
                timeLabel.Text = "30 秒";
                timer1.Start();
            }

            private void startButton_Click(object sender, EventArgs e) //start
            {
                StartTheQuiz();
                startButton.Enabled = false;

                // if the timer has run down, the button should appear
                // work as normal. the 'one more time' and 'show the answers;
                // button shouldn't be visable or work if the timer is on.
                // 
                if (timer1.Enabled == true)
                    button1.Visible = false;
                button1.Enabled = false;

                if (timer1.Enabled == false)
                    button1.Visible = true;
                button1.Enabled = true;

                if (timer1.Enabled == false)
                    button1.Enabled = true;

                if (timer1.Enabled == true)
                    button3.Visible = false;
                button3.Enabled = false;
                startButton.Visible = false;

                if (timer1.Enabled == false)
                    button3.Enabled = true;

            }

            private bool CheckTheAnswer()
            {
                if ((addend1 + addend2 == sum.Value)
                    && (minuend - subtrahend == difference.Value)
                    && (multiplicand * multiplier == product.Value)
                    && (dividend / divisor == quotient.Value))
                    return true;
                else
                    return false;
            }

            private void ShowTheAnswer()
            // ShowTheAnswer shows the correct anwser for each eqaution.
            // Once clicked, 'show the answers' button should disappear
            // the 'one more time' button should be visable and working.
            {
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                button1.Visible = false;
                button3.Visible = true;
                button3.Enabled = true;
            }

            private void answerButton_Click(object sender, EventArgs e)
            {
                ShowTheAnswer();
                button1.Enabled = false;

                // when the timer is on, the 'show the answers' button should not be seen.
                if (timer1.Enabled == true)
                {
                    button1.Visible = false;
                    button1.Enabled = false;
                }
            }
            private void timer1_Tick(object sender, EventArgs e)
            {
                if (timeLeft < 12)
                {
                    timeLabel.BackColor = Color.Red;
                }

                if (CheckTheAnswer())
                {
                    //if CheckTheAnswer() returns true, then the user got the answer right.
                    //stop the timer and show the message box.
                    //the 'one mroe time' button should be visable and working
                    //at this time.
                    timer1.Stop();
                    MessageBox.Show("You got all the question's right!", "Congratulations!");
                    button3.Visible = true;
                    button3.Enabled = true;

                    startButton.Enabled = true;
                    {
                        timeLabel.BackColor = Color.MidnightBlue;
                    }
                }
                else if (timeLeft > 0)
                {
                    //display the new time left by updating the TimeLeft Label.
                    timeLeft = timeLeft - 1;
                    timeLabel.Text = timeLeft + " seconds";
                }
                else
                {
                    //if the user ran out of time, stop the timmer,
                    //show the message box and fill in the answers.
                    timer1.Stop();
                    timeLabel.Text = "Time's Up!";
                    MessageBox.Show("You didn't finish in time!", "Sorry!");
                    button3.Visible = true;
                    button3.Enabled = true;

                    // if the start button is enabled, you should not be able
                    // to see the time label or the 'one more time' button yet
                    // you should be able to see the 'show the answers; button
                    startButton.Enabled = true;
                    {
                        timeLabel.BackColor = Color.MidnightBlue;
                        button1.Visible = true;
                        button3.Visible = false;
                    }
                }
            }

            private void answer_Enter(object sender, EventArgs e)
            {
                //selecet the whole number in the NumericUpDown control
                NumericUpDown answerBox = sender as NumericUpDown;

                if (answerBox != null)
                {
                    int lengthOfAnswer = answerBox.Value.ToString().Length;
                    answerBox.Select(0, lengthOfAnswer);
                }
            }

            private void button1_Click_1(object sender, EventArgs e) //answer
            {
                ShowTheAnswer();

                // when the timer is on, the 'show the answers' button should not be shown.
                if (timer1.Enabled == true)
                {
                    button1.Visible = false;
                    button1.Enabled = false;
                }
            }

            private void closeButton_Click(object sender, EventArgs e) //close
            {
                //close the form.
                this.Close();
            }

            private void button3_Click(object sender, EventArgs e) //mou ikai
            {
                // restart the game but only when it has finished.
                // the 'one more time' button should disappear once
                // the game has restarted.
                StartTheQuiz();
                button3.Enabled = false;
                button3.Visible = false;
            }

            private void AddProblem()
            {
                //fill in the addtion problem.
                //generate 2 numbers randomly to add together
                //store the values in the variables 'addend1' & 'addend2'
                addend1 = randomizer.Next(51);
                addend2 = randomizer.Next(51);

                //convert the 2 randomly generated numbers into strings
                //so they can be displayed in the labels controls
                plusLeftLabel.Text = addend1.ToString();
                plusRightLabel.Text = addend2.ToString();

                //'sum' is the name of the NumericUpDown control
                // this step makes sure its value is zero before adding any values to it.
                sum.Value = 0;
            }

            private void SubProblem()
            {
                //Fill in the subtraction problem
                minuend = randomizer.Next(1, 101);
                subtrahend = randomizer.Next(1, minuend);
                minusLeftLabel.Text = minuend.ToString();
                minusRightLabel.Text = subtrahend.ToString();
                difference.Value = 0;
            }

            private void DivProblem()
            {
                divisor = randomizer.Next(2, 11);
                int temporaryQuoteint = randomizer.Next(2, 11);
                dividend = divisor * temporaryQuoteint;
                dividedLeftLabel.Text = dividend.ToString();
                dividedRightLabel.Text = divisor.ToString();
                quotient.Value = 0;
            }

            private void MultiProblem()
            {
                //fill in the multiplication problem
                multiplicand = randomizer.Next(2, 11);
                multiplier = randomizer.Next(2, 11);
                timeLeftLabel.Text = multiplicand.ToString();
                timeRightLabel.Text = multiplier.ToString();
                product.Value = 0;
            }

        }
    }
