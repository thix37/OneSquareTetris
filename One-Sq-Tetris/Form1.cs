using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace One_Sq_Tetris
{
    public partial class Form1 : Form
    {
        private Color[] blokEmptyColor;

        private Timer _timer;

        private int tetrisPiecePosition;

        private bool[] bloksFilled;
        
        public Form1()
        {
            InitializeComponent();

            _timer = new Timer();
            _timer.Interval = 200;
            _timer.Enabled = true;
            _timer.Tick+=new System.EventHandler(TimerTickEvent);

            blokEmptyColor = new Color[2];

           bloksFilled = new bool[40];

    
            tetrisPiecePosition = -3;

            blokEmptyColor[0] = Color.LightCoral;
            blokEmptyColor[1] = Color.Plum;

            foreach (Label label in BlockLabels)
            {
                label.BackColor = blokEmptyColor[0];

            }

            _timer.Start();

        }

        private void TimerTickEvent(object sender, EventArgs e)
        {
            tetrisPiecePosition += 5;

            if (tetrisPiecePosition > 40)
            {
                tetrisPiecePosition = 2;

            }


            if (tetrisPiecePosition < 40)
            {
                if (BlockLabels[tetrisPiecePosition].BackColor == blokEmptyColor[0])
                {
                    BlockLabels[tetrisPiecePosition].BackColor = blokEmptyColor[1];

                    if (tetrisPiecePosition > 5)
                    {
                        BlockLabels[tetrisPiecePosition - 5].BackColor = blokEmptyColor[0];

                    }
                }
            }

        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left)
            {
                if (tetrisPiecePosition < 39 && bloksFilled[tetrisPiecePosition]==false)
                {
                    if(tetrisPiecePosition!=0 && tetrisPiecePosition!=5 && tetrisPiecePosition!=10 &&
                        tetrisPiecePosition!=15 && tetrisPiecePosition!=20 && tetrisPiecePosition!=25 &&
                        tetrisPiecePosition != 30 && tetrisPiecePosition != 35 && BlockLabels[tetrisPiecePosition-1].BackColor!=blokEmptyColor[1])
                    {
                        tetrisPiecePosition--;
                        BlockLabels[tetrisPiecePosition].BackColor = blokEmptyColor[1];
                        BlockLabels[tetrisPiecePosition + 1].BackColor = blokEmptyColor[0];
                        return true;
                    }
                }
            }
            if (keyData == Keys.Right)
            {
                if (tetrisPiecePosition < 39 && bloksFilled[tetrisPiecePosition] == false)
                {
                    if (tetrisPiecePosition != 0 && tetrisPiecePosition != 4 && tetrisPiecePosition != 9 &&
                        tetrisPiecePosition != 14 && tetrisPiecePosition != 19 && tetrisPiecePosition != 24 &&
                        tetrisPiecePosition != 29 && tetrisPiecePosition != 34 && BlockLabels[tetrisPiecePosition + 1].BackColor != blokEmptyColor[1])
                    {
                        tetrisPiecePosition++;
                        BlockLabels[tetrisPiecePosition].BackColor = blokEmptyColor[1];
                        BlockLabels[tetrisPiecePosition - 1].BackColor = blokEmptyColor[0];
                        return true;
                    }
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
