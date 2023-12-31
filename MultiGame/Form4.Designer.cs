﻿namespace MultiGame
{
    partial class Form4
    {
      
            /// <summary>
            /// Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

            /// <summary>
            /// Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

            #region Windows Form Designer generated code

            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
                this.components = new System.ComponentModel.Container();
                this.timeLabel = new System.Windows.Forms.Label();
                this.label1 = new System.Windows.Forms.Label();
                this.plusLeftLabel = new System.Windows.Forms.Label();
                this.label2 = new System.Windows.Forms.Label();
                this.plusRightLabel = new System.Windows.Forms.Label();
                this.label4 = new System.Windows.Forms.Label();
                this.sum = new System.Windows.Forms.NumericUpDown();
                this.difference = new System.Windows.Forms.NumericUpDown();
                this.label3 = new System.Windows.Forms.Label();
                this.minusRightLabel = new System.Windows.Forms.Label();
                this.label6 = new System.Windows.Forms.Label();
                this.minusLeftLabel = new System.Windows.Forms.Label();
                this.quotient = new System.Windows.Forms.NumericUpDown();
                this.label8 = new System.Windows.Forms.Label();
                this.dividedRightLabel = new System.Windows.Forms.Label();
                this.label10 = new System.Windows.Forms.Label();
                this.dividedLeftLabel = new System.Windows.Forms.Label();
                this.product = new System.Windows.Forms.NumericUpDown();
                this.label12 = new System.Windows.Forms.Label();
                this.timeRightLabel = new System.Windows.Forms.Label();
                this.label14 = new System.Windows.Forms.Label();
                this.timeLeftLabel = new System.Windows.Forms.Label();
                this.startButton = new System.Windows.Forms.Button();
                this.timer1 = new System.Windows.Forms.Timer(this.components);
                this.button1 = new System.Windows.Forms.Button();
                this.closeButton = new System.Windows.Forms.Button();
                this.button3 = new System.Windows.Forms.Button();
                ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
                this.SuspendLayout();
                // 
                // timeLabel
                // 
                this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.timeLabel.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
                this.timeLabel.ForeColor = System.Drawing.Color.LightCyan;
                this.timeLabel.Location = new System.Drawing.Point(299, 9);
                this.timeLabel.Name = "timeLabel";
                this.timeLabel.Size = new System.Drawing.Size(200, 30);
                this.timeLabel.TabIndex = 0;
                // 
                // label1
                // 
                this.label1.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
                this.label1.ForeColor = System.Drawing.Color.LightCyan;
                this.label1.Location = new System.Drawing.Point(163, 9);
                this.label1.Name = "label1";
                this.label1.Size = new System.Drawing.Size(130, 30);
                this.label1.TabIndex = 1;
                this.label1.Text = "Time Left:";
                this.label1.Click += new System.EventHandler(this.answerButton_Click);
                // 
                // plusLeftLabel
                // 
                this.plusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.plusLeftLabel.ForeColor = System.Drawing.Color.LightCyan;
                this.plusLeftLabel.Location = new System.Drawing.Point(35, 64);
                this.plusLeftLabel.Name = "plusLeftLabel";
                this.plusLeftLabel.Size = new System.Drawing.Size(60, 50);
                this.plusLeftLabel.TabIndex = 2;
                this.plusLeftLabel.Text = "?";
                this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // label2
                // 
                this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label2.ForeColor = System.Drawing.Color.LightCyan;
                this.label2.Location = new System.Drawing.Point(101, 64);
                this.label2.Name = "label2";
                this.label2.Size = new System.Drawing.Size(60, 50);
                this.label2.TabIndex = 3;
                this.label2.Text = "+";
                this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // plusRightLabel
                // 
                this.plusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.plusRightLabel.ForeColor = System.Drawing.Color.LightCyan;
                this.plusRightLabel.Location = new System.Drawing.Point(167, 64);
                this.plusRightLabel.Name = "plusRightLabel";
                this.plusRightLabel.Size = new System.Drawing.Size(60, 50);
                this.plusRightLabel.TabIndex = 4;
                this.plusRightLabel.Text = "?";
                this.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // label4
                // 
                this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label4.ForeColor = System.Drawing.Color.LightCyan;
                this.label4.Location = new System.Drawing.Point(233, 64);
                this.label4.Name = "label4";
                this.label4.Size = new System.Drawing.Size(60, 50);
                this.label4.TabIndex = 5;
                this.label4.Text = "=";
                this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // sum
                // 
                this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.sum.ForeColor = System.Drawing.Color.MidnightBlue;
                this.sum.Location = new System.Drawing.Point(299, 73);
                this.sum.Name = "sum";
                this.sum.Size = new System.Drawing.Size(100, 35);
                this.sum.TabIndex = 2;
                this.sum.Enter += new System.EventHandler(this.answer_Enter);
                // 
                // difference
                // 
                this.difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.difference.ForeColor = System.Drawing.Color.MidnightBlue;
                this.difference.Location = new System.Drawing.Point(299, 140);
                this.difference.Name = "difference";
                this.difference.Size = new System.Drawing.Size(100, 35);
                this.difference.TabIndex = 3;
                this.difference.Enter += new System.EventHandler(this.answer_Enter);
                // 
                // label3
                // 
                this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label3.ForeColor = System.Drawing.Color.LightCyan;
                this.label3.Location = new System.Drawing.Point(233, 131);
                this.label3.Name = "label3";
                this.label3.Size = new System.Drawing.Size(60, 50);
                this.label3.TabIndex = 10;
                this.label3.Text = "=";
                this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // minusRightLabel
                // 
                this.minusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.minusRightLabel.ForeColor = System.Drawing.Color.LightCyan;
                this.minusRightLabel.Location = new System.Drawing.Point(167, 131);
                this.minusRightLabel.Name = "minusRightLabel";
                this.minusRightLabel.Size = new System.Drawing.Size(60, 50);
                this.minusRightLabel.TabIndex = 9;
                this.minusRightLabel.Text = "?";
                this.minusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // label6
                // 
                this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label6.ForeColor = System.Drawing.Color.LightCyan;
                this.label6.Location = new System.Drawing.Point(101, 128);
                this.label6.Name = "label6";
                this.label6.Size = new System.Drawing.Size(60, 50);
                this.label6.TabIndex = 8;
                this.label6.Text = "-";
                this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // minusLeftLabel
                // 
                this.minusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.minusLeftLabel.ForeColor = System.Drawing.Color.LightCyan;
                this.minusLeftLabel.Location = new System.Drawing.Point(35, 131);
                this.minusLeftLabel.Name = "minusLeftLabel";
                this.minusLeftLabel.Size = new System.Drawing.Size(60, 50);
                this.minusLeftLabel.TabIndex = 7;
                this.minusLeftLabel.Text = "?";
                this.minusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // quotient
                // 
                this.quotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.quotient.ForeColor = System.Drawing.Color.MidnightBlue;
                this.quotient.Location = new System.Drawing.Point(299, 208);
                this.quotient.Name = "quotient";
                this.quotient.Size = new System.Drawing.Size(100, 35);
                this.quotient.TabIndex = 4;
                this.quotient.Enter += new System.EventHandler(this.answer_Enter);
                // 
                // label8
                // 
                this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label8.ForeColor = System.Drawing.Color.LightCyan;
                this.label8.Location = new System.Drawing.Point(233, 199);
                this.label8.Name = "label8";
                this.label8.Size = new System.Drawing.Size(60, 50);
                this.label8.TabIndex = 15;
                this.label8.Text = "=";
                this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // dividedRightLabel
                // 
                this.dividedRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.dividedRightLabel.ForeColor = System.Drawing.Color.LightCyan;
                this.dividedRightLabel.Location = new System.Drawing.Point(167, 199);
                this.dividedRightLabel.Name = "dividedRightLabel";
                this.dividedRightLabel.Size = new System.Drawing.Size(60, 50);
                this.dividedRightLabel.TabIndex = 14;
                this.dividedRightLabel.Text = "?";
                this.dividedRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // label10
                // 
                this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label10.ForeColor = System.Drawing.Color.LightCyan;
                this.label10.Location = new System.Drawing.Point(101, 200);
                this.label10.Name = "label10";
                this.label10.Size = new System.Drawing.Size(60, 50);
                this.label10.TabIndex = 13;
                this.label10.Text = "÷";
                this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // dividedLeftLabel
                // 
                this.dividedLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.dividedLeftLabel.ForeColor = System.Drawing.Color.LightCyan;
                this.dividedLeftLabel.Location = new System.Drawing.Point(35, 200);
                this.dividedLeftLabel.Name = "dividedLeftLabel";
                this.dividedLeftLabel.Size = new System.Drawing.Size(60, 50);
                this.dividedLeftLabel.TabIndex = 12;
                this.dividedLeftLabel.Text = "?";
                this.dividedLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // product
                // 
                this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.product.ForeColor = System.Drawing.Color.MidnightBlue;
                this.product.Location = new System.Drawing.Point(299, 272);
                this.product.Name = "product";
                this.product.Size = new System.Drawing.Size(100, 35);
                this.product.TabIndex = 5;
                this.product.Enter += new System.EventHandler(this.answer_Enter);
                // 
                // label12
                // 
                this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label12.ForeColor = System.Drawing.Color.LightCyan;
                this.label12.Location = new System.Drawing.Point(233, 263);
                this.label12.Name = "label12";
                this.label12.Size = new System.Drawing.Size(60, 50);
                this.label12.TabIndex = 20;
                this.label12.Text = "=";
                this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // timeRightLabel
                // 
                this.timeRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.timeRightLabel.ForeColor = System.Drawing.Color.LightCyan;
                this.timeRightLabel.Location = new System.Drawing.Point(167, 263);
                this.timeRightLabel.Name = "timeRightLabel";
                this.timeRightLabel.Size = new System.Drawing.Size(60, 50);
                this.timeRightLabel.TabIndex = 19;
                this.timeRightLabel.Text = "?";
                this.timeRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // label14
                // 
                this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label14.ForeColor = System.Drawing.Color.LightCyan;
                this.label14.Location = new System.Drawing.Point(101, 260);
                this.label14.Name = "label14";
                this.label14.Size = new System.Drawing.Size(60, 50);
                this.label14.TabIndex = 18;
                this.label14.Text = "x";
                this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // timeLeftLabel
                // 
                this.timeLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.timeLeftLabel.ForeColor = System.Drawing.Color.LightCyan;
                this.timeLeftLabel.Location = new System.Drawing.Point(35, 263);
                this.timeLeftLabel.Name = "timeLeftLabel";
                this.timeLeftLabel.Size = new System.Drawing.Size(60, 50);
                this.timeLeftLabel.TabIndex = 17;
                this.timeLeftLabel.Text = "?";
                this.timeLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // startButton
                // 
                this.startButton.AutoSize = true;
                this.startButton.BackColor = System.Drawing.Color.MidnightBlue;
                this.startButton.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
                this.startButton.ForeColor = System.Drawing.Color.LightCyan;
                this.startButton.Location = new System.Drawing.Point(134, 340);
                this.startButton.Name = "startButton";
                this.startButton.Size = new System.Drawing.Size(231, 37);
                this.startButton.TabIndex = 1;
                this.startButton.Text = "Start the Quiz";
                this.startButton.UseVisualStyleBackColor = false;
                this.startButton.Click += new System.EventHandler(this.startButton_Click);
                // 
                // timer1
                // 
                this.timer1.Interval = 1000;
                this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
                // 
                // button1
                // 
                this.button1.AutoSize = true;
                this.button1.BackColor = System.Drawing.Color.MidnightBlue;
                this.button1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
                this.button1.ForeColor = System.Drawing.Color.LightCyan;
                this.button1.Location = new System.Drawing.Point(379, 358);
                this.button1.Name = "button1";
                this.button1.Size = new System.Drawing.Size(137, 40);
                this.button1.TabIndex = 25;
                this.button1.Text = "Show the answers";
                this.button1.UseVisualStyleBackColor = false;
                this.button1.Visible = false;
                this.button1.Click += new System.EventHandler(this.button1_Click_1);
                // 
                // closeButton
                // 
                this.closeButton.BackColor = System.Drawing.Color.MidnightBlue;
                this.closeButton.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
                this.closeButton.ForeColor = System.Drawing.Color.MistyRose;
                this.closeButton.Location = new System.Drawing.Point(1, 4);
                this.closeButton.Name = "closeButton";
                this.closeButton.Size = new System.Drawing.Size(94, 35);
                this.closeButton.TabIndex = 26;
                this.closeButton.Text = "Close";
                this.closeButton.UseVisualStyleBackColor = false;
                this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
                // 
                // button3
                // 
                this.button3.AutoSize = true;
                this.button3.BackColor = System.Drawing.Color.MidnightBlue;
                this.button3.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
                this.button3.ForeColor = System.Drawing.Color.LightCyan;
                this.button3.Location = new System.Drawing.Point(134, 340);
                this.button3.Name = "button3";
                this.button3.Size = new System.Drawing.Size(231, 37);
                this.button3.TabIndex = 27;
                this.button3.Text = "One more time?";
                this.button3.UseVisualStyleBackColor = false;
                this.button3.Visible = false;
                this.button3.Click += new System.EventHandler(this.button3_Click);
                // 
                // Form1
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackColor = System.Drawing.Color.MidnightBlue;
                this.ClientSize = new System.Drawing.Size(516, 398);
                this.Controls.Add(this.button3);
                this.Controls.Add(this.closeButton);
                this.Controls.Add(this.button1);
                this.Controls.Add(this.startButton);
                this.Controls.Add(this.product);
                this.Controls.Add(this.label12);
                this.Controls.Add(this.timeRightLabel);
                this.Controls.Add(this.label14);
                this.Controls.Add(this.timeLeftLabel);
                this.Controls.Add(this.quotient);
                this.Controls.Add(this.label8);
                this.Controls.Add(this.dividedRightLabel);
                this.Controls.Add(this.label10);
                this.Controls.Add(this.dividedLeftLabel);
                this.Controls.Add(this.difference);
                this.Controls.Add(this.label3);
                this.Controls.Add(this.minusRightLabel);
                this.Controls.Add(this.label6);
                this.Controls.Add(this.minusLeftLabel);
                this.Controls.Add(this.sum);
                this.Controls.Add(this.label4);
                this.Controls.Add(this.plusRightLabel);
                this.Controls.Add(this.label2);
                this.Controls.Add(this.plusLeftLabel);
                this.Controls.Add(this.label1);
                this.Controls.Add(this.timeLabel);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
                this.MaximizeBox = false;
                this.Name = "Form1";
                this.Text = "Maths Quiz";
                ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
                this.ResumeLayout(false);
                this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.Label timeLabel;
            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.Label plusLeftLabel;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.Label plusRightLabel;
            private System.Windows.Forms.Label label4;
            private System.Windows.Forms.NumericUpDown sum;
            private System.Windows.Forms.NumericUpDown difference;
            private System.Windows.Forms.Label label3;
            private System.Windows.Forms.Label minusRightLabel;
            private System.Windows.Forms.Label label6;
            private System.Windows.Forms.Label minusLeftLabel;
            private System.Windows.Forms.NumericUpDown quotient;
            private System.Windows.Forms.Label label8;
            private System.Windows.Forms.Label dividedRightLabel;
            private System.Windows.Forms.Label label10;
            private System.Windows.Forms.Label dividedLeftLabel;
            private System.Windows.Forms.NumericUpDown product;
            private System.Windows.Forms.Label label12;
            private System.Windows.Forms.Label timeRightLabel;
            private System.Windows.Forms.Label label14;
            private System.Windows.Forms.Label timeLeftLabel;
            private System.Windows.Forms.Button startButton;
            private System.Windows.Forms.Timer timer1;
            private System.Windows.Forms.Button button1;
            private System.Windows.Forms.Button closeButton;
            private System.Windows.Forms.Button button3;
        }
    }