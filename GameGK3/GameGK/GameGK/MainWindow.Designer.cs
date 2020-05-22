﻿namespace GameGK
{
    partial class MainWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbLevel = new System.Windows.Forms.Label();
            this.pnScore = new System.Windows.Forms.Panel();
            this.lbScore = new System.Windows.Forms.Label();
            this.pnGameOver = new System.Windows.Forms.Panel();
            this.btnRestart = new System.Windows.Forms.PictureBox();
            this.btnStartStop = new System.Windows.Forms.PictureBox();
            this.ptTetris = new System.Windows.Forms.PictureBox();
            this.lb_name_acc = new System.Windows.Forms.Label();
            this.lb_name_score = new System.Windows.Forms.Label();
            this.pn_info_player = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.myPanel2 = new GameGK.MyPanel();
            this.myPanel1 = new GameGK.MyPanel();
            this.panel1.SuspendLayout();
            this.pnScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStartStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptTetris)).BeginInit();
            this.pn_info_player.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pn_info_player);
            this.panel1.Controls.Add(this.lbLevel);
            this.panel1.Controls.Add(this.pnScore);
            this.panel1.Controls.Add(this.pnGameOver);
            this.panel1.Controls.Add(this.btnRestart);
            this.panel1.Controls.Add(this.btnStartStop);
            this.panel1.Controls.Add(this.myPanel2);
            this.panel1.Controls.Add(this.myPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 880);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.BackColor = System.Drawing.Color.Transparent;
            this.lbLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLevel.Location = new System.Drawing.Point(961, 23);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(66, 20);
            this.lbLevel.TabIndex = 9;
            this.lbLevel.Text = "Level 1";
            // 
            // pnScore
            // 
            this.pnScore.BackColor = System.Drawing.Color.Transparent;
            this.pnScore.Controls.Add(this.lbScore);
            this.pnScore.Location = new System.Drawing.Point(816, 46);
            this.pnScore.Name = "pnScore";
            this.pnScore.Size = new System.Drawing.Size(356, 191);
            this.pnScore.TabIndex = 8;
            this.pnScore.Paint += new System.Windows.Forms.PaintEventHandler(this.pnScore_Paint);
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.BackColor = System.Drawing.Color.Transparent;
            this.lbScore.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbScore.Location = new System.Drawing.Point(56, 71);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(0, 29);
            this.lbScore.TabIndex = 6;
            this.lbScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnGameOver
            // 
            this.pnGameOver.BackColor = System.Drawing.Color.Transparent;
            this.pnGameOver.Location = new System.Drawing.Point(783, 243);
            this.pnGameOver.Name = "pnGameOver";
            this.pnGameOver.Size = new System.Drawing.Size(404, 178);
            this.pnGameOver.TabIndex = 0;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Transparent;
            this.btnRestart.Location = new System.Drawing.Point(867, 501);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(222, 108);
            this.btnRestart.TabIndex = 7;
            this.btnRestart.TabStop = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnStartStop
            // 
            this.btnStartStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStartStop.Location = new System.Drawing.Point(888, 427);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(180, 73);
            this.btnStartStop.TabIndex = 7;
            this.btnStartStop.TabStop = false;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // ptTetris
            // 
            this.ptTetris.Location = new System.Drawing.Point(39, 24);
            this.ptTetris.Name = "ptTetris";
            this.ptTetris.Size = new System.Drawing.Size(240, 73);
            this.ptTetris.TabIndex = 10;
            this.ptTetris.TabStop = false;
            this.ptTetris.Click += new System.EventHandler(this.ptTetris_Click);
            // 
            // lb_name_acc
            // 
            this.lb_name_acc.AutoSize = true;
            this.lb_name_acc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_name_acc.ForeColor = System.Drawing.Color.Red;
            this.lb_name_acc.Location = new System.Drawing.Point(149, 70);
            this.lb_name_acc.Name = "lb_name_acc";
            this.lb_name_acc.Size = new System.Drawing.Size(79, 29);
            this.lb_name_acc.TabIndex = 10;
            this.lb_name_acc.Text = "label1";
            this.lb_name_acc.Click += new System.EventHandler(this.lb_name_acc_Click);
            // 
            // lb_name_score
            // 
            this.lb_name_score.AutoSize = true;
            this.lb_name_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_name_score.ForeColor = System.Drawing.Color.Red;
            this.lb_name_score.Location = new System.Drawing.Point(149, 99);
            this.lb_name_score.Name = "lb_name_score";
            this.lb_name_score.Size = new System.Drawing.Size(79, 29);
            this.lb_name_score.TabIndex = 11;
            this.lb_name_score.Text = "label1";
            // 
            // pn_info_player
            // 
            this.pn_info_player.BackColor = System.Drawing.Color.Transparent;
            this.pn_info_player.Controls.Add(this.label3);
            this.pn_info_player.Controls.Add(this.label2);
            this.pn_info_player.Controls.Add(this.label1);
            this.pn_info_player.Controls.Add(this.lb_name_acc);
            this.pn_info_player.Controls.Add(this.lb_name_score);
            this.pn_info_player.Location = new System.Drawing.Point(11, 117);
            this.pn_info_player.Name = "pn_info_player";
            this.pn_info_player.Size = new System.Drawing.Size(334, 144);
            this.pn_info_player.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Player Infomation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(7, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(7, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "High Score: ";
            // 
            // myPanel2
            // 
            this.myPanel2.BackColor = System.Drawing.Color.Transparent;
            this.myPanel2.Location = new System.Drawing.Point(112, 305);
            this.myPanel2.Name = "myPanel2";
            this.myPanel2.Size = new System.Drawing.Size(200, 100);
            this.myPanel2.TabIndex = 1;
            this.myPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.myPanel2_Paint);
            // 
            // myPanel1
            // 
            this.myPanel1.BackColor = System.Drawing.Color.Transparent;
            this.myPanel1.Location = new System.Drawing.Point(378, 23);
            this.myPanel1.Name = "myPanel1";
            this.myPanel1.Size = new System.Drawing.Size(386, 844);
            this.myPanel1.TabIndex = 0;
            this.myPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.myPanel1_Paint);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 880);
            this.Controls.Add(this.ptTetris);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1200, 880);
            this.MinimumSize = new System.Drawing.Size(1200, 880);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnScore.ResumeLayout(false);
            this.pnScore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStartStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptTetris)).EndInit();
            this.pn_info_player.ResumeLayout(false);
            this.pn_info_player.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MyPanel myPanel1;
        private MyPanel myPanel2;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbScore;
        public System.Windows.Forms.PictureBox btnStartStop;
        public System.Windows.Forms.PictureBox btnRestart;
        public System.Windows.Forms.Panel pnGameOver;
        private System.Windows.Forms.Panel pnScore;
        public System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.PictureBox ptTetris;
        private System.Windows.Forms.Label lb_name_acc;
        private System.Windows.Forms.Panel pn_info_player;
        private System.Windows.Forms.Label lb_name_score;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

