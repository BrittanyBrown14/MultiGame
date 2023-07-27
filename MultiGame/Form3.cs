using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiGame
{
    public partial class Form3 : Form
    {
        public Form3()
        {
           
            InitializeComponent();
            timer3.Start();
            this.Controls.Add(cursor);
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            cursor.Location = new Point(10, 10);
            cursor.BackColor = Color.Crimson;

        }
        int timeLeft;
        private void AllTheLabelsTrue()
        {
            label1.Enabled = true;
            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            label11.Enabled = true;
            label12.Enabled = true;
            label13.Enabled = true;
            label14.Enabled = true;
            label15.Enabled = true;
            label53.Enabled = true;
            label32.Enabled = true;
            label73.Enabled = true;
            label70.Enabled = true;
            label17.Enabled = true;
            label18.Enabled = true;
            label19.Enabled = true;
            label77.Enabled = true;
            label68.Enabled = true;
            label21.Enabled = true;
            label22.Enabled = true;
            label23.Enabled = true;
            label24.Enabled = true;
            label25.Enabled = true;
            label26.Enabled = true;
            label27.Enabled = true;
            label28.Enabled = true;
            label29.Enabled = true;
            label30.Enabled = true;
            label31.Enabled = true;
            label33.Enabled = true;
            label35.Enabled = true;
            label36.Enabled = true;
            label37.Enabled = true;
            label38.Enabled = true;
            label39.Enabled = true;
            label40.Enabled = true;
            label58.Enabled = true;
            label55.Enabled = true;
            label41.Enabled = true;
            label42.Enabled = true;
            label43.Enabled = true;
            label78.Enabled = true;
            label75.Enabled = true;
            label72.Enabled = true;
            label69.Enabled = true;
            label45.Enabled = true;
            label46.Enabled = true;
            label47.Enabled = true;
            label48.Enabled = true;
            label56.Enabled = true;
            label49.Enabled = true;
            label50.Enabled = true;
            label51.Enabled = true;
            label52.Enabled = true;
            label20.Enabled = true;
            label86.Enabled = true;
            label59.Enabled = true;
            label87.Enabled = true;
            label82.Enabled = true;
            label61.Enabled = true;
            label62.Enabled = true;
            label83.Enabled = true;
            label64.Enabled = true;
            label65.Enabled = true;
            label99.Enabled = true;
            label98.Enabled = true;
            label95.Enabled = true;
            label97.Enabled = true;
            label94.Enabled = true;
            label91.Enabled = true;
            label89.Enabled = true;
            label16.Enabled = true;
            label21.Enabled = true;
            label30.Enabled = true;
            label57.Enabled = true;
            label44.Enabled = true;
            label34.Enabled = true;
            label60.Enabled = true;
            label63.Enabled = true;
            label66.Enabled = true;
            label67.Enabled = true;
            label100.Enabled = true;
            AoiKagi.Enabled = true;
            GinKagi.Enabled = true;
            AkaiKagi.Enabled = true;
        }

        private void AllTheLabelsFalse()
        {
            label1.Enabled = false;
            label2.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            label6.Enabled = false;
            label7.Enabled = false;
            label8.Enabled = false;
            label9.Enabled = false;
            label10.Enabled = false;
            label11.Enabled = false;
            label12.Enabled = false;
            label13.Enabled = false;
            label14.Enabled = false;
            label15.Enabled = false;
            label53.Enabled = false;
            label32.Enabled = false;
            label73.Enabled = false;
            label70.Enabled = false;
            label17.Enabled = false;
            label18.Enabled = false;
            label19.Enabled = false;
            label77.Enabled = false;
            label68.Enabled = false;
            label21.Enabled = false;
            label22.Enabled = false;
            label23.Enabled = false;
            label24.Enabled = false;
            label25.Enabled = false;
            label26.Enabled = false;
            label27.Enabled = false;
            label28.Enabled = false;
            label29.Enabled = false;
            label30.Enabled = false;
            label31.Enabled = false;
            label33.Enabled = false;
            label35.Enabled = false;
            label36.Enabled = false;
            label37.Enabled = false;
            label38.Enabled = false;
            label39.Enabled = false;
            label40.Enabled = false;
            label58.Enabled = false;
            label55.Enabled = false;
            label41.Enabled = false;
            label42.Enabled = false;
            label43.Enabled = false;
            label78.Enabled = false;
            label75.Enabled = false;
            label72.Enabled = false;
            label69.Enabled = false;
            label45.Enabled = false;
            label46.Enabled = false;
            label47.Enabled = false;
            label48.Enabled = false;
            label56.Enabled = false;
            label49.Enabled = false;
            label50.Enabled = false;
            label51.Enabled = false;
            label52.Enabled = false;
            label20.Enabled = false;
            label86.Enabled = false;
            label59.Enabled = false;
            label87.Enabled = false;
            label82.Enabled = false;
            label61.Enabled = false;
            label62.Enabled = false;
            label83.Enabled = false;
            label64.Enabled = false;
            label65.Enabled = false;
            label99.Enabled = false;
            label98.Enabled = false;
            label95.Enabled = false;
            label97.Enabled = false;
            label94.Enabled = false;
            label91.Enabled = false;
            label89.Enabled = false;
            label16.Enabled = false;
            label21.Enabled = false;
            label30.Enabled = false;
            label57.Enabled = false;
            label44.Enabled = false;
            label34.Enabled = false;
            label60.Enabled = true;
            label63.Enabled = true;
            label66.Enabled = true;
            label67.Enabled = true;
            label100.Enabled = false;
            AoiKagi.Enabled = false;
            GinKagi.Enabled = false;
            AkaiKagi.Enabled = false;
        }

        Random random = new Random();
        Stopwatch stopwatch = new Stopwatch();

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + "";
                finishButton.Enabled = false;
                label60.Enabled = false;
                label63.Enabled = false;
                label66.Enabled = false;
                label67.Enabled = false;
            }
            else
            {
                timeLabel.Visible = false;
                MoveToStart();
                timer1.Stop();
                AllTheLabelsTrue();
                timer2.Start();
                timer5.Start();
                finishButton.Enabled = true;
                cursor.Visible = true;
                stopwatch.Start();
            }
            if (timeLabel.Visible == false)
            {
                timer6.Enabled = true;
                stopwatch.Start();
            }

        } // countdown starter timer

        private void startButton_Click(object sender, EventArgs e)
        {
            timeLeft = 3;
            timeLabel.Text = "3";
            timer1.Start();
            timeLabel.Visible = true;
            startButton.Visible = false;
            finishButton.Enabled = true;
            label60.Enabled = false;
            label63.Enabled = false;
            label66.Enabled = false;
            label67.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Enemy1.Visible = true;
            int x1 = random.Next(0, 510);
            int y1 = random.Next(0, 487);
            Enemy1.Top = y1;
            Enemy1.Left = x1;

            Enemy2.Visible = true;
            int x2 = random.Next(0, 510);
            int y2 = random.Next(0, 487);
            Enemy2.Top = y2;
            Enemy2.Left = x2;

            Enemy3.Visible = true;
            int x3 = random.Next(0, 510);
            int y3 = random.Next(0, 487);
            Enemy3.Top = y3;
            Enemy3.Left = x3;

            Enemy4.Visible = true;
            int x4 = random.Next(0, 510);
            int y4 = random.Next(0, 487);
            Enemy4.Top = y4;
            Enemy4.Left = x4;

            Enemy5.Visible = true;
            int x5 = random.Next(0, 510);
            int y5 = random.Next(0, 487);
            Enemy5.Top = y5;
            Enemy5.Left = x5;

            Enemy6.Visible = true;
            int x6 = random.Next(0, 510);
            int y6 = random.Next(0, 487);
            Enemy6.Top = y6;
            Enemy6.Left = x6;
        } // randomiser timer

        //show a 'congrat' message box
        private void finishButton_MouseClick(object sender, MouseEventArgs e)
        {
            stopwatch.Stop();
            MessageBox.Show("You Cleared the Maze!", "Congratulations!");
            AllTheLabelsFalse();
            restartButton.Visible = true;
            finishButton.Enabled = false;
            timer2.Stop();
            timer5.Stop();
            Enemy1.Visible = false;
            Enemy2.Visible = false;
            Enemy3.Visible = false;
            Enemy4.Visible = false;
            Enemy5.Visible = false;
            Enemy6.Visible = false;
            label21.Enabled = false;
            label30.Enabled = false;
            label31.Enabled = false;
            label3.Enabled = false;
            label44.Enabled = false;
            label57.Enabled = false;
            label60.Enabled = false;
            label63.Enabled = false;
            label66.Enabled = false;
            label67.Enabled = false;
        }

        /// <summary> 
        /// Move the pointer to a point 10 pixels down and to the right 
        /// of the starting point in the upper-left corner of the maze. 
        /// </summary> 
        private void MoveToStart()
        {
            Point startingPoint = panel1.Location;
            startingPoint.Offset(20, 20);
            Cursor.Position = PointToScreen(startingPoint);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void wall_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
            progressBar1.Value += 25;

            if (progressBar1.Value == 100)
            {
                stopwatch.Stop();
                MessageBox.Show("You have lost all of your lives!", "Too Bad!");
                restartButton.Visible = true;
                finishButton.Enabled = false;
                power1.Visible = false;
                AllTheLabelsFalse();
                timer2.Stop();
                timer5.Stop();
                Enemy1.Visible = false;
                Enemy2.Visible = false;
                Enemy3.Visible = false;
                Enemy4.Visible = false;
                Enemy5.Visible = false;
                Enemy6.Visible = false;
                label21.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label3.Enabled = false;
                label44.Enabled = false;
                label57.Enabled = false;
                label60.Enabled = false;
                label63.Enabled = false;
                label66.Enabled = false;
                label67.Enabled = false;
                AoiKagi.Visible = false;
                AkaiKagi.Visible = false;
                GinKagi.Visible = false;
            }
        } //life loss death

        private void restartButton_Click(object sender, EventArgs e)
        {

            progressBar1.Value -= progressBar1.Value;
            timeLeft = 3;
            timeLabel.Text = "3";
            stopwatch = Stopwatch.StartNew();
            stopwatch.Stop();
            timer1.Start();

            if (timer1.Enabled == true)
                timeLabel.Visible = true;
            startButton.Visible = false;
            restartButton.Visible = false;
            power1.Visible = false;
            AllTheLabelsFalse();
            TotalElapsed();
            label21.BackColor = Color.LightCyan;
            label30.BackColor = Color.LightCyan;
            label31.BackColor = Color.LightCyan;
            label3.BackColor = Color.LightCyan;
            label44.BackColor = Color.LightCyan;
            label57.BackColor = Color.LightCyan;
            label34.BackColor = Color.LightCyan;
            GinKagi.BackColor = Color.LightCyan;


        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 

        private void Enemy1_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You got killed by your Orange enemy!", "Oh No!");
            stopwatch.Stop();
            restartButton.Visible = true;
            AllTheLabelsFalse();
            timer2.Stop();
            timer5.Stop();
            finishButton.Enabled = false;
            power1.Visible = false;
            Enemy1.Visible = false;
            Enemy2.Visible = false;
            Enemy3.Visible = false;
            Enemy4.Visible = false;
            Enemy5.Visible = false;
            Enemy6.Visible = false;
            label21.Enabled = false;
            label30.Enabled = false;
            label31.Enabled = false;
            label3.Enabled = false;
            label44.Enabled = false;
            label57.Enabled = false;
            label60.Enabled = false;
            label63.Enabled = false;
            label66.Enabled = false;
            label67.Enabled = false;
            AoiKagi.Visible = false;
            AkaiKagi.Visible = false;
            GinKagi.Visible = false;
        } // orange death

        private void Enemy2_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You got killed by your Chartreuse enemy!", "Oh No!");
            stopwatch.Stop();
            restartButton.Visible = true;
            AllTheLabelsFalse();
            timer2.Stop();
            timer5.Stop();
            finishButton.Enabled = false;
            power1.Visible = false;
            Enemy1.Visible = false;
            Enemy2.Visible = false;
            Enemy3.Visible = false;
            Enemy4.Visible = false;
            Enemy5.Visible = false;
            Enemy6.Visible = false;
            label21.Enabled = false;
            label30.Enabled = false;
            label31.Enabled = false;
            label3.Enabled = false;
            label44.Enabled = false;
            label57.Enabled = false;
            label60.Enabled = false;
            label63.Enabled = false;
            label66.Enabled = false;
            label67.Enabled = false;
            AoiKagi.Visible = false;
            AkaiKagi.Visible = false;
            GinKagi.Visible = false;
        } // charturse death

        private void Enemy3_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You got killed by your Orchid enemy!", "Oh No!");
            stopwatch.Stop();
            finishButton.Enabled = false;
            restartButton.Visible = true;
            power1.Visible = false;
            AllTheLabelsFalse();
            timer2.Stop();
            timer5.Stop();
            Enemy1.Visible = false;
            Enemy2.Visible = false;
            Enemy3.Visible = false;
            Enemy4.Visible = false;
            Enemy5.Visible = false;
            Enemy6.Visible = false;
            label21.Enabled = false;
            label30.Enabled = false;
            label31.Enabled = false;
            label3.Enabled = false;
            label44.Enabled = false;
            label57.Enabled = false;
            label60.Enabled = false;
            label63.Enabled = false;
            label66.Enabled = false;
            label67.Enabled = false;
            AoiKagi.Visible = false;
            AkaiKagi.Visible = false;
            GinKagi.Visible = false;
        } // orchid death

        private void Enemy4_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You got killed by your Rosy Brown enemy!", "Oh No!");
            stopwatch.Stop();
            finishButton.Enabled = false;
            restartButton.Visible = true;
            power1.Visible = false;
            AllTheLabelsFalse();
            timer2.Stop();
            timer5.Stop();
            Enemy1.Visible = false;
            Enemy2.Visible = false;
            Enemy3.Visible = false;
            Enemy4.Visible = false;
            Enemy5.Visible = false;
            Enemy6.Visible = false;
            label21.Enabled = false;
            label30.Enabled = false;
            label31.Enabled = false;
            label3.Enabled = false;
            label44.Enabled = false;
            label57.Enabled = false;
            label60.Enabled = false;
            label63.Enabled = false;
            label66.Enabled = false;
            label67.Enabled = false;
            AoiKagi.Visible = false;
            AkaiKagi.Visible = false;
            GinKagi.Visible = false;
        } // rosy brown death

        private void Enemy5_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You got killed by your Sky Blue enemy!", "Oh No!");
            stopwatch.Stop();
            finishButton.Enabled = false;
            restartButton.Visible = true;
            power1.Visible = false;
            AllTheLabelsFalse();
            timer2.Stop();
            timer5.Stop();
            Enemy1.Visible = false;
            Enemy2.Visible = false;
            Enemy3.Visible = false;
            Enemy4.Visible = false;
            Enemy5.Visible = false;
            Enemy6.Visible = false;
            label21.Enabled = false;
            label30.Enabled = false;
            label31.Enabled = false;
            label3.Enabled = false;
            label44.Enabled = false;
            label57.Enabled = false;
            label60.Enabled = false;
            label63.Enabled = false;
            label66.Enabled = false;
            label67.Enabled = false;
            AoiKagi.Visible = false;
            AkaiKagi.Visible = false;
            GinKagi.Visible = false;
        } // sky blue death

        private void Enemy6_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You got killed by your Gold enemy!", "Oh No!");
            stopwatch.Stop();
            finishButton.Enabled = false;
            restartButton.Visible = true;
            power1.Visible = false;
            AllTheLabelsFalse();
            timer2.Stop();
            timer5.Stop();
            Enemy1.Visible = false;
            Enemy2.Visible = false;
            Enemy3.Visible = false;
            Enemy4.Visible = false;
            Enemy5.Visible = false;
            Enemy6.Visible = false;
            label21.Enabled = false;
            label30.Enabled = false;
            label31.Enabled = false;
            label3.Enabled = false;
            label44.Enabled = false;
            label57.Enabled = false;
            label60.Enabled = false;
            label63.Enabled = false;
            label66.Enabled = false;
            label67.Enabled = false;
            AoiKagi.Visible = false;
            AkaiKagi.Visible = false;
            GinKagi.Visible = false;
        } // gold death

        private void timer3_Tick(object sender, EventArgs e)
        {
            Enemy1.Location = new Point(Enemy1.Location.X + 5, Enemy1.Location.Y);
            if (Enemy1.Location.X > this.Width)
                Enemy1.Location = new Point(0 - Enemy1.Width, Enemy1.Location.Y);

            /////////////////////////////////////////////////////////////////////

            Enemy2.Location = new Point(Enemy2.Location.X, Enemy2.Location.Y + 5);
            if (Enemy2.Location.Y > this.Height)
                Enemy2.Location = new Point(0 - Enemy2.Location.X, 0 - Enemy2.Height);

            /////////////////////////////////////////////////////////////////////

            Enemy3.Location = new Point(Enemy3.Location.X - 5, Enemy3.Location.Y);
            if (Enemy3.Location.X > this.Width)
                Enemy3.Location = new Point(0 + Enemy3.Width, Enemy3.Location.Y);

            /////////////////////////////////////////////////////////////////////

            Enemy4.Location = new Point(Enemy4.Location.X, Enemy4.Location.Y - 5);
            if (Enemy4.Location.Y > this.Height)
                Enemy4.Location = new Point(0 - Enemy4.Location.X, 0 + Enemy4.Height);

            /////////////////////////////////////////////////////////////////////

            Enemy5.Location = new Point(Enemy5.Location.X + 5, Enemy5.Location.Y);
            if (Enemy5.Location.X > this.Width)
                Enemy5.Location = new Point(0 - Enemy5.Width, Enemy5.Location.Y);

            /////////////////////////////////////////////////////////////////////

            Enemy6.Location = new Point(Enemy6.Location.X, Enemy6.Location.Y + 5);
            if (Enemy6.Location.Y > this.Height)
                Enemy6.Location = new Point(0 - Enemy6.Location.X, 0 - Enemy6.Height);
        } // directional enemy timer (how fast they move) 

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////        

        private void False()
        {
            Enemy1.Visible = false;
            Enemy2.Visible = false;
            Enemy3.Visible = false;
            Enemy4.Visible = false;
            Enemy5.Visible = false;
            Enemy6.Visible = false;
            label21.Enabled = false;
            label30.Enabled = false;
            label60.Enabled = false;
            label63.Enabled = false;
            label66.Enabled = false;
            label67.Enabled = false;
        }

        private void TurnBack()
        {
            label30.BackColor = Color.MidnightBlue;
            label21.BackColor = Color.MidnightBlue;
        }

        private void trap_MouseMove(object sender, MouseEventArgs e)
        {
            //only L30 kills

            TurnBack();
            label21.Enabled = true;
            label30.Enabled = true;

            Point startingPoint = panel1.Location;
            startingPoint.Offset(190, 218);
            Cursor.Position = PointToScreen(startingPoint);
        }

        private void trap_MouseEnter(object sender, EventArgs e)
        {
            if (label21.BackColor == Color.MidnightBlue)
            {
                MoveToStart();
                progressBar1.Value += 25;
            }

            label21.Enabled = false;
            label30.Enabled = false;

            if (progressBar1.Value == 100)
            {
                stopwatch.Stop();
                MessageBox.Show("You have lost all of your lives!", "Too Bad!");
                restartButton.Visible = true;
                finishButton.Enabled = false;
                power1.Visible = false;
                AllTheLabelsFalse();
                timer2.Stop();
                timer5.Stop();
                False();

            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////        

        private void False2()
        {
            Enemy1.Visible = false;
            Enemy2.Visible = false;
            Enemy3.Visible = false;
            Enemy4.Visible = false;
            Enemy5.Visible = false;
            Enemy6.Visible = false;
            label3.Enabled = false;
            label31.Enabled = false;
            label60.Enabled = false;
            label63.Enabled = false;
            label66.Enabled = false;
            label67.Enabled = false;
        }

        private void TurnBack2()
        {
            label31.BackColor = Color.MidnightBlue;
            label3.BackColor = Color.MidnightBlue;
        }

        private void trap2_MouseMove(object sender, MouseEventArgs e)
        {
            //both kill

            TurnBack2();
            label31.Enabled = true;
            label3.Enabled = true;

            Point startingPoint = panel1.Location;
            startingPoint.Offset(10, 99);
            Cursor.Position = PointToScreen(startingPoint);

        }

        private void trap2_MouseEnter(object sender, EventArgs e)
        {
            if (label31.BackColor == Color.MidnightBlue)
            {
                MoveToStart();
                progressBar1.Value += 25;
            }

            label31.Enabled = false;
            label3.Enabled = false;

            if (progressBar1.Value == 100)
            {
                stopwatch.Stop();
                MessageBox.Show("You have lost all of your lives!", "Too Bad!");
                restartButton.Visible = true;
                finishButton.Enabled = false;
                power1.Visible = false;
                AllTheLabelsFalse();
                timer2.Stop();
                timer5.Stop();
                False2();

                if (timer6.Enabled == false)
                {
                    label31.Enabled = false;
                    label3.Enabled = false;
                }

            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void False3()
        {
            Enemy1.Visible = false;
            Enemy2.Visible = false;
            Enemy3.Visible = false;
            Enemy4.Visible = false;
            Enemy5.Visible = false;
            Enemy6.Visible = false;
            label44.Enabled = false;
            label57.Enabled = false;
            label60.Enabled = false;
            label63.Enabled = false;
            label66.Enabled = false;
            label67.Enabled = false;
        }

        private void TurnBack3()
        {
            label44.BackColor = Color.MidnightBlue;
            label57.BackColor = Color.MidnightBlue;
        }

        private void trap3_MouseMove(object sender, MouseEventArgs e)
        {
            //both kill

            TurnBack3();
            label44.Enabled = true;
            label57.Enabled = true;

            Point startingPoint = panel1.Location;
            startingPoint.Offset(11, 442);
            Cursor.Position = PointToScreen(startingPoint);
        }

        private void trap3_MouseEnter(object sender, EventArgs e)
        {
            if (label57.BackColor == Color.MidnightBlue)
            {
                MoveToStart();
                progressBar1.Value += 25;
            }

            label44.Enabled = false;
            label57.Enabled = false;

            if (progressBar1.Value == 100)
            {
                stopwatch.Stop();
                MessageBox.Show("You have lost all of your lives!", "Too Bad!");
                restartButton.Visible = true;
                finishButton.Enabled = false;
                power1.Visible = false;
                AllTheLabelsFalse();
                timer2.Stop();
                timer5.Stop();
                False3();
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void TurnBack4()
        {
            label34.BackColor = Color.MidnightBlue;
            AoiKagi.Visible = true;

            Point startingPoint = panel1.Location;
            startingPoint.Offset(405, 570);
            Cursor.Position = PointToScreen(startingPoint);
        }

        private void trap4_MouseEnter(object sender, EventArgs e)
        {
            TurnBack4();
            label34.Enabled = true;
            AoiKagi.Visible = true;
            {
                MessageBox.Show("Get the Blue Key!", "Wait!");

                Point startingPoint = panel1.Location;
                startingPoint.Offset(405, 570);
                Cursor.Position = PointToScreen(startingPoint);
            }
        }

        private void AoiKagi_MouseEnter(object sender, EventArgs e)
        {
            AoiKagi.Visible = false;
            MessageBox.Show("Now, get the Red Key!", "Next...");
            AkaiKagi.Visible = true;

            Point startingPoint = panel1.Location;
            startingPoint.Offset(507, 99);
            Cursor.Position = PointToScreen(startingPoint);
        }

        private void AkaiKagi_MouseEnter(object sender, EventArgs e)
        {
            AkaiKagi.Visible = false;
            MessageBox.Show("Get the Gold Key!", "You're almost there!");
            GinKagi.Visible = true;

            Point startingPoint = panel1.Location;
            startingPoint.Offset(33, 165);
            Cursor.Position = PointToScreen(startingPoint);
        }

        private void GinKagi_MouseEnter(object sender, EventArgs e)
        {
            GinKagi.Visible = false;
            MessageBox.Show("Head to the Finish!", "Great!");
            label34.Enabled = false;
            label34.BackColor = Color.LightCyan;

            Point startingPoint = panel1.Location;
            startingPoint.Offset(494, 327);
            Cursor.Position = PointToScreen(startingPoint);
        }

        private void wall2_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }

        private void power1_MouseEnter(object sender, EventArgs e)
        {
            if (power1.Visible == true)
            {
                power1.Visible = false;
                timer3.Enabled = false;
                timer2.Enabled = false;
                timeLeft = 3;
                timer4.Start();
            }
        } //the apple 'power up'

        private void timer4_Tick(object sender, EventArgs e) // power up effect length timer
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                power1.Visible = true;
            }
            else
            {
                timer4.Stop();
                timer2.Enabled = true;
                timer3.Enabled = true;
            }
        }

        private void timer5_Tick(object sender, EventArgs e) // power up location randomiser timer
        {
            timer2.Enabled = true;
            timer3.Enabled = true;
            power1.Visible = true;
            int x7 = random.Next(0, 510);
            int y7 = random.Next(0, 487);
            power1.Top = y7;
            power1.Left = x7;

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////        

        private void TotalElapsed()
        {
            btimeLabel.Text = stopwatch.Elapsed.TotalMinutes.ToString();
            btimeLabel.Text = "Time Elapsed:" + stopwatch.Elapsed.TotalMinutes;

            btimeLabel.Text = stopwatch.Elapsed.TotalSeconds.ToString();
            btimeLabel.Text = "Time Elapsed:" + stopwatch.Elapsed.TotalSeconds;

            btimeLabel.Text = stopwatch.Elapsed.TotalMilliseconds.ToString();
            btimeLabel.Text = "Time Elapsed:" + stopwatch.Elapsed.TotalMilliseconds;

            btimeLabel.Text = string.Format("{0:00}:{1:00}:{2:00}", stopwatch.Elapsed.TotalMinutes, stopwatch.Elapsed.TotalSeconds, stopwatch.Elapsed.TotalMilliseconds / 10);
            btimeLabel.Text = string.Format("{0:00}:{1:00}:{2:00}" + Environment.NewLine, stopwatch.Elapsed.TotalMinutes, stopwatch.Elapsed.TotalSeconds, stopwatch.Elapsed.TotalMilliseconds / 10);
        } // leaderboard business

        private void timer6_Tick(object sender, EventArgs e)
        {

            StopLabel.Text = "Time Elapsed:" + stopwatch.Elapsed.Minutes;
            StopLabel.Text = "Time Elapsed:" + stopwatch.Elapsed.Seconds;
            StopLabel.Text = "Time Elapsed:" + stopwatch.Elapsed.Milliseconds;

            StopLabel.Text = string.Format("{0:00}:{1:00}:{2:00}", stopwatch.Elapsed.Minutes, stopwatch.Elapsed.Seconds, stopwatch.Elapsed.Milliseconds / 10);

            if (restartButton.Visible == true)
            {
                TotalElapsed();
            }
        } // leaderboard business

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////           

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A)
            {
                cursor.Location = new Point(cursor.Location.X - 1, cursor.Location.Y);
            }

            if (e.KeyData == Keys.D)
            {
                cursor.Location = new Point(cursor.Location.X + 1, cursor.Location.Y);
            }

            if (e.KeyData == Keys.W)
            {
                cursor.Location = new Point(cursor.Location.X, cursor.Location.Y + 1);
            }

            if (e.KeyData == Keys.S)
            {
                cursor.Location = new Point(cursor.Location.X, cursor.Location.Y - 1);
            }
        } // cursor control

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /* 
        
         * fix the traps!!!!!!!! 6/10
        
         * make it so that the labels near the traps work as the originals do lol/10
           
         * make it so that each time is kept. 2/10
           
         * make the label the thing that you control. 4/10
         
         */
    }
}





























































//(shilpi.bhatt@reedonline.co.uk)