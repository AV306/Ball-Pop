
using System;

namespace Ball_Pop
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlGame = new System.Windows.Forms.Panel();
            this.lblPopped = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtOver = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.picArrow = new System.Windows.Forms.PictureBox();
            this.timGame = new System.Windows.Forms.Timer(this.components);
            this.timBalls = new System.Windows.Forms.Timer(this.components);
            this.debug = new System.Windows.Forms.Label();
            this.timDebug = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGame
            // 
            this.pnlGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlGame.BackColor = System.Drawing.Color.White;
            this.pnlGame.Location = new System.Drawing.Point(12, 12);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(720, 405);
            this.pnlGame.TabIndex = 0;
            // 
            // lblPopped
            // 
            this.lblPopped.AutoSize = true;
            this.lblPopped.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopped.Location = new System.Drawing.Point(738, 12);
            this.lblPopped.Name = "lblPopped";
            this.lblPopped.Size = new System.Drawing.Size(102, 20);
            this.lblPopped.TabIndex = 1;
            this.lblPopped.Text = "Balls Popped";
            // 
            // txtScore
            // 
            this.txtScore.BackColor = System.Drawing.Color.White;
            this.txtScore.Location = new System.Drawing.Point(742, 35);
            this.txtScore.Multiline = true;
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(181, 46);
            this.txtScore.TabIndex = 0;
            // 
            // txtOver
            // 
            this.txtOver.BackColor = System.Drawing.SystemColors.Control;
            this.txtOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOver.Location = new System.Drawing.Point(742, 87);
            this.txtOver.Multiline = true;
            this.txtOver.Name = "txtOver";
            this.txtOver.Size = new System.Drawing.Size(181, 65);
            this.txtOver.TabIndex = 2;
            this.txtOver.Text = "Game Over";
            this.txtOver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(742, 158);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(181, 54);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(742, 218);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(181, 54);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Bye!";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picBall
            // 
            this.picBall.Image = ((System.Drawing.Image)(resources.GetObject("picBall.Image")));
            this.picBall.Location = new System.Drawing.Point(742, 278);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(50, 50);
            this.picBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBall.TabIndex = 5;
            this.picBall.TabStop = false;
            // 
            // picArrow
            // 
            this.picArrow.Image = ((System.Drawing.Image)(resources.GetObject("picArrow.Image")));
            this.picArrow.Location = new System.Drawing.Point(798, 278);
            this.picArrow.Name = "picArrow";
            this.picArrow.Size = new System.Drawing.Size(50, 50);
            this.picArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picArrow.TabIndex = 6;
            this.picArrow.TabStop = false;
            this.picArrow.Visible = false;
            // 
            // timGame
            // 
            this.timGame.Interval = 60000;
            this.timGame.Tick += new System.EventHandler(this.timGame_Tick);
            // 
            // timBalls
            // 
            this.timBalls.Tick += new System.EventHandler(this.timBalls_Tick);
            // 
            // debug
            // 
            this.debug.AutoSize = true;
            this.debug.Location = new System.Drawing.Point(776, 374);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(0, 13);
            this.debug.TabIndex = 7;
            // 
            // timDebug
            // 
            this.timDebug.Enabled = true;
            this.timDebug.Interval = 1000;
            this.timDebug.Tick += new System.EventHandler(this.timDebug_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 429);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.picArrow);
            this.Controls.Add(this.picBall);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtOver);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.lblPopped);
            this.Controls.Add(this.pnlGame);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Ball Pop";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Label lblPopped;
        private System.Windows.Forms.TextBox txtOver;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.PictureBox picArrow;
        private System.Windows.Forms.Timer timGame;
        private System.Windows.Forms.Timer timBalls;
        private System.Windows.Forms.Label debug;
        private System.Windows.Forms.Timer timDebug;
        private System.Windows.Forms.TextBox txtScore;
    }
}

