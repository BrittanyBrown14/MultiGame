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
    public partial class Form5 : Form
    {
        //use this random object to to chose random icons for the squares
        Random random = new Random();

        //each of these letters is an intresting icon
        //in the Webdings font. and each icon will appear
        //twice in the list. but japanese is cooler ^_^
        List<string> icons = new List<string>
        {
            "愛", "愛", "男", "男", "犬", "犬", "車", "車",
            "気", "気", "空", "空", "赤", "赤", "茶", "茶"
        };

        /// <summary>
        /// Assign a random icon to each of the squares
        /// </summary>
        private void AssignIconToSquares()
            {
                // The TableLayoutPanel has 16 labels,
                // and the icon list has 16 icons,
                // so an icon is pulled at random from the list
                // and added to each label

                foreach (Control control in tableLayoutPanel1.Controls)
                // The statements you want to execute 
                // for each label go here
                // The statements use iconLabel to access 
                // each label's properties and method
                {
                    Label iconLabel = control as Label;
                    if (iconLabel != null)
                    {
                        int randomNumber = random.Next(icons.Count);
                        iconLabel.Text = icons[randomNumber];
                        iconLabel.ForeColor = iconLabel.BackColor;
                        icons.RemoveAt(randomNumber);
                    }
                }
                button2.Visible = false;
                button2.Enabled = false;
            }
            public Form5()
            {
                InitializeComponent();
                AssignIconToSquares();
            }

            private void label_Click(object sender, EventArgs e)
            {
                // the labels will not work unless you press
                // the start 'Geemu wo hajimeyou' button.
                if (timer2.Enabled == false)
                    return;

                // The timer is only on after two non-matching 
                // icons have been shown to the player, 
                // so ignore any clicks if the timer is running
                if (timer1.Enabled == true)
                    return;

                Label clickedLabel = sender as Label;
                if (clickedLabel != null)
                {
                    // If the clicked label is black, the player clicked
                    // an icon that's already been revealed
                    // ignore the click
                    if (clickedLabel.ForeColor == Color.LightCyan)
                        button4.Enabled = true;

                    if (clickedLabel.ForeColor == Color.LightCyan)
                        return;

                    // If firstClicked is null, this is the first icon 
                    // in the pair that the player clicked,
                    // so set firstClicked to the label that the player 
                    // clicked, change its color to black, and return
                    if (firstClicked == null)
                    {
                        firstClicked = clickedLabel;
                        firstClicked.ForeColor = Color.LightCyan;
                        return;
                    }
                    // If the player gets this far, the timer isn't
                    // running and firstClicked isn't null,
                    // so this must be the second icon the player clicked
                    // Set its color to black
                    secondClicked = clickedLabel;
                    secondClicked.ForeColor = Color.LightCyan;
                    CheckForWinner();

                    // If the player clicked two matching icons, keep them 
                    // black and reset firstClicked and secondClicked 
                    // so the player can click another icon
                    if (firstClicked.Text == secondClicked.Text)
                    {
                        firstClicked = null;
                        secondClicked = null;
                        return;
                    }

                    // If the player gets this far, the player 
                    // clicked two different icons, so start the 
                    // timer (which will wait half of 
                    // a second, and then hide the icons)
                    timer1.Start();
                }
            }
            // firstClicked points to the first Label control 
            // that the player clicks, but it will be null 
            // if the player hasn't clicked a label yet
            Label firstClicked = null;

            // secondClicked points to the second Label control 
            // that the player clicks
            Label secondClicked = null;

            /// <summary>
            /// This timer is started when the player clicks 
            /// two icons that don't match,
            /// so it counts three quarters of a second 
            /// and then turns itself off and hides both icons
            /// </summary>
            private void timer1_Tick(object sender, EventArgs e)
            {

                //Stop the timer
                timer1.Stop();

                //hide both icons
                firstClicked.ForeColor = firstClicked.BackColor;
                secondClicked.ForeColor = secondClicked.BackColor;

                // Reset firstClicked and secondClicked 
                // so the next time a label is
                // clicked, the program knows it's the first click
                firstClicked = null;
                secondClicked = null;
            }
            private void CheckForWinner()
            {
                // Go through all of the labels in the TableLayoutPanel, 
                // checking each one to see if its icon is matched
                foreach (Control control in tableLayoutPanel1.Controls)
                {
                    Label iconLabel = control as Label;
                    if (iconLabel != null)
                    {
                        if (iconLabel.ForeColor == iconLabel.BackColor)
                            return;
                    }

                }
                // If the loop didn’t return, it didn't find
                // any unmatched icons. That means the user won. Show a message.
                // the replay and start button should be visable and enabled too.
                timer2.Stop();
                timeLabel.Text = "Finished!";
                MessageBox.Show("You matched them all!", "Congratulations!");
                button4.Visible = false;
                button4.Enabled = false;
                button3.Visible = true;
                button3.Enabled = true;
                button2.Enabled = false;
                button2.Visible = false;

            }
            // This integer variable keeps track of the 
            // remaining time.
            int timeLeft;
            private void StartTheGame()
            {
                timeLeft = 30;
                timeLabel.Text = "30 Seconds";
                timer2.Start();

                if (button4.Enabled == true)
                    button4.Visible = false;
                button4.Enabled = false;
            }
            private void button4_Click(object sender, EventArgs e)
            {
                // this is a Start Button
                // you have click this for the game to start
                // until then, no labels will be able to work.
                StartTheGame();
                button4.Enabled = false;
                button2.Enabled = true;
                button2.Visible = true;
            }

            private void timer2_Tick(object sender, EventArgs e)
            {
                {
                    if (timeLeft > 0)
                    {
                        // Display the new time left
                        // by updating the Time Left label.
                        timeLeft = timeLeft - 1;
                        timeLabel.Text = timeLeft + " seconds";
                    }
                    else
                    {
                        // If the user ran out of time, stop the timer
                        //and show a MessageBox
                        timer2.Stop();
                        timeLabel.Text = "Time's Up!";
                        MessageBox.Show("You didn't finish in time!", "Sorry!");
                        button4.Visible = false;
                        button4.Enabled = false;
                        button3.Visible = true;
                        button3.Enabled = true;
                        button2.Enabled = false;
                        button2.Visible = false;
                    }

                    // once the game starts, you shouldn't be able to see or
                    // use the reset button until the game has finished.           
                    if (timer2.Enabled == true)
                        button3.Visible = false;
                    button3.Enabled = false;

                    if (timer2.Enabled == false)
                        button3.Visible = true;
                    button3.Enabled = true;

                    // once 'start' has been clicked, the replay button
                    // should disappear and reappear only when the pause
                    // button has been pressed. once the game restarts,
                    // the replay button should disappear again.
                    if (button2.Enabled == true)
                        button1.Visible = false;

                    if (button2.Enabled == false)
                        button2.Enabled = true;
                    return;
                }
            }
            // when you click the reset button, It should rest the game and the timer
            // so you can play again, without restarting the entire game.

            private void ResetTheGame()
            {
                Random random2 = new Random();
                List<string> icons = new List<string>
            {
                "愛", "愛", "男", "男", "犬", "犬", "車", "車",
                "気", "気", "空", "空", "赤", "赤", "茶", "茶"
            };
                {
                    // The TableLayoutPanel has 16 labels,
                    // and the icon list has 16 icons,
                    // so an icon is pulled at random from the list
                    // and added to each label

                    foreach (Control control in tableLayoutPanel1.Controls)
                    // The statements you want to execute 
                    // for each label go here
                    // The statements use iconLabel to access 
                    // each label's properties and method
                    {
                        Label iconLabel = control as Label;
                        if (iconLabel != null)
                        {
                            int randomNumber = random.Next(icons.Count);
                            iconLabel.Text = icons[randomNumber];
                            iconLabel.ForeColor = iconLabel.BackColor;
                            icons.RemoveAt(randomNumber);
                        }
                    }
                }
                // the 'reset' button is not visable at this time
                // and the 'start' is now visable and working.
                button3.Visible = false;
                button4.Visible = true;
                button4.Enabled = true;
            }

            // this reset the icons so the game can restart again.
            private void button3_Click(object sender, EventArgs e)
            {
                ResetTheGame();
                button3.Enabled = false;
                timer2.Stop();

                if (button3.Enabled == true)
                    StartTheGame();
            }

            // this pauses the game
            private void PauseTheGame()
            {
                timer2.Enabled = false;
            }
            private void button2_Click(object sender, EventArgs e)
            {
                PauseTheGame();
                button2.Enabled = false;

                // if the button has not been pressed, the replay
                // button should tbe visable and be enabled.
                if (button2.Enabled == false)
                    button1.Visible = true;
                return;
            }

            // this replays the game from where it was paused
            private void ReplayTheGame()
            {
                timer2.Enabled = true;
            }
            private void button1_Click(object sender, EventArgs e)
            {
                ReplayTheGame();
                button1.Visible = false;
            }

            private void closeButton_Click(object sender, EventArgs e)
            {
                //closes the form
                this.Close();
            }
        }
    }
