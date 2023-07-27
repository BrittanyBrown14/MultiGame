namespace MultiGame
{
    partial class Form1
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
            this.tttButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mazeButton = new System.Windows.Forms.Button();
            this.mathsButton = new System.Windows.Forms.Button();
            this.matchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tttButton
            // 
            this.tttButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(113)))));
            this.tttButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tttButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.tttButton.Location = new System.Drawing.Point(12, 61);
            this.tttButton.Name = "tttButton";
            this.tttButton.Size = new System.Drawing.Size(292, 32);
            this.tttButton.TabIndex = 0;
            this.tttButton.Text = "Tic Tac Toe";
            this.tttButton.UseVisualStyleBackColor = false;
            this.tttButton.Click += new System.EventHandler(this.tttButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(113)))));
            this.label1.Location = new System.Drawing.Point(82, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose A Game";
            // 
            // mazeButton
            // 
            this.mazeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(113)))));
            this.mazeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mazeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.mazeButton.Location = new System.Drawing.Point(12, 123);
            this.mazeButton.Name = "mazeButton";
            this.mazeButton.Size = new System.Drawing.Size(292, 32);
            this.mazeButton.TabIndex = 0;
            this.mazeButton.Text = "Maze";
            this.mazeButton.UseVisualStyleBackColor = false;
            this.mazeButton.Click += new System.EventHandler(this.mazeButton_Click);
            // 
            // mathsButton
            // 
            this.mathsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(113)))));
            this.mathsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mathsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.mathsButton.Location = new System.Drawing.Point(12, 190);
            this.mathsButton.Name = "mathsButton";
            this.mathsButton.Size = new System.Drawing.Size(292, 32);
            this.mathsButton.TabIndex = 0;
            this.mathsButton.Text = "Maths Quiz";
            this.mathsButton.UseVisualStyleBackColor = false;
            this.mathsButton.Click += new System.EventHandler(this.mathsButton_Click);
            // 
            // matchButton
            // 
            this.matchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(113)))));
            this.matchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.matchButton.Location = new System.Drawing.Point(12, 253);
            this.matchButton.Name = "matchButton";
            this.matchButton.Size = new System.Drawing.Size(292, 32);
            this.matchButton.TabIndex = 0;
            this.matchButton.Text = "Matching Game";
            this.matchButton.UseVisualStyleBackColor = false;
            this.matchButton.Click += new System.EventHandler(this.matchButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(315, 335);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matchButton);
            this.Controls.Add(this.mathsButton);
            this.Controls.Add(this.mazeButton);
            this.Controls.Add(this.tttButton);
            this.Name = "Form1";
            this.Text = "Choose A Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tttButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mazeButton;
        private System.Windows.Forms.Button mathsButton;
        private System.Windows.Forms.Button matchButton;
    }
}

