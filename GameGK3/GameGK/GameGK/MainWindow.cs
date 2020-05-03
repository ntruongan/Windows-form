﻿using GameGK.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameGK
{
    public partial class MainWindow : Form
    {
        Grid MainGrid;
        Grid ExtraGrid;
        private Board board;
        private int level;
        MainWindowController mainWindowController;
        Menu MENU;
        public MainWindow(int level)
        {
            InitializeComponent();
            this.level = level;
            
        }
        public MainWindow(Menu menu)
        {
            InitializeComponent();
            MENU = menu;
            MENU.Hide();
            this.Size = this.MaximumSize;
            lbScore.Text = String.Format("{0,7}", "");
            //level = int.Parse(lbLevel.Text);
            level = 1;
            MainGrid = new Grid(myPanel1, 10, 20);
            myPanel1.Width = MainGrid.Width;
            myPanel1.Height = MainGrid.Height;
            ExtraGrid = new Grid(myPanel2, 4, 4);
            myPanel2.Width = ExtraGrid.Width;
            myPanel2.Height = ExtraGrid.Height;
            board = new Board(MainGrid, ExtraGrid);
            mainWindowController = new MainWindowController(board, this, this.level);
        }
        
        private void myPanel1_Paint(object sender, PaintEventArgs e)
        {
            MainGrid.GraphicGrid(myPanel1, e.Graphics);
        }

        private void myPanel2_Paint(object sender, PaintEventArgs e)
        {
            ExtraGrid.GraphicGrid(myPanel2, e.Graphics);
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            mainWindowController.MainWindow_KeyDown(sender, e);
        }
      
        private void MainWindow_Load(object sender, EventArgs e)
        {
            btnStartStop.BackgroundImage = Image.FromFile(Application.StartupPath + @"\pause.png");
            btnStartStop.BackgroundImageLayout = ImageLayout.Stretch;
            btnRestart.BackgroundImage = Image.FromFile(Application.StartupPath + @"\restart.png");
            btnRestart.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BackgroundImage = Image.FromFile(Application.StartupPath + @"\neonwall.jpg");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            pnGameOver.BackgroundImage = Image.FromFile(Application.StartupPath + @"\gameover.png");
            pnGameOver.BackgroundImageLayout = ImageLayout.Stretch;
            pnScore.BackgroundImage = Image.FromFile(Application.StartupPath + @"\fs.png");
            pnScore.BackgroundImageLayout = ImageLayout.Stretch;
            lbScore.Font = new Font("Digital Numbers", 20);
            lbScore.ForeColor = Color.FromArgb(39, 255, 229);
            lbLevel.Font = new Font("2020 Outline Fortune Kei", 22);
            lbLevel.ForeColor = Color.FromArgb(144, 13, 205);
            ptTetris.BackgroundImage = Image.FromFile(Application.StartupPath + @"\\tetris.jpg");
            ptTetris.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            mainWindowController.GamePause();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            btnStartStop.BackgroundImage = Image.FromFile(Application.StartupPath + @"\pause.png");
            btnStartStop.BackgroundImageLayout = ImageLayout.Stretch;
            mainWindowController.GameStart();
        }

        private void pnScore_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawString("0000000", new Font("Digital Numbers", 20), new SolidBrush(Color.FromArgb(58, 77, 75)), new Point(37, 47));
        }

        private void ptTetris_Click(object sender, EventArgs e)
        {
            MENU.Show();
            this.Close();
        }
    }
    public class MyPanel:Panel
    {
        public MyPanel():base()
        {
            this.DoubleBuffered = true;
        }
    }
}