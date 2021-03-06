﻿using System;
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
            _timer.Interval = 100;
            _timer.Enabled = true;
            _timer.Tick += new System.EventHandler(TimerTickEvent);

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

            if (tetrisPiecePosition < 35)
            {
                if (BlockLabels[tetrisPiecePosition].BackColor == blokEmptyColor[1])
                {
                    tetrisPiecePosition = 2;

                }
            }

            if (tetrisPiecePosition == 2)
            {
                int ile = 0;
                foreach (Label blok in BlockLabels)
                {
                    if (blok.BackColor == blokEmptyColor[1])
                    {
                        bloksFilled[ile] = true;
                    }
                    ile++;
                }

            }

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

            if(BlockLabels[35].BackColor == blokEmptyColor[1] && 
               BlockLabels[36].BackColor == blokEmptyColor[1] &&
               BlockLabels[37].BackColor == blokEmptyColor[1] && 
               BlockLabels[38].BackColor == blokEmptyColor[1] &&
               BlockLabels[39].BackColor == blokEmptyColor[1] )
            {
                //czyscimy linie, bo sa wszystkie kwadraty zapelnione
                BlockLabels[35].BackColor = blokEmptyColor[0];
                BlockLabels[36].BackColor = blokEmptyColor[0] ;
                BlockLabels[37].BackColor = blokEmptyColor[0] ;
                BlockLabels[38].BackColor = blokEmptyColor[0] ;
                BlockLabels[39].BackColor = blokEmptyColor[0] ;

                int ileBloks = 0;

                bloksFilled = new bool[40];

                foreach (Label blok in BlockLabels)
                {
                    if (blok.BackColor == blokEmptyColor[1])
                    {
                        bloksFilled[ileBloks + 5] = true;
                    }

                    ileBloks++;
                }

                foreach (Label blok in BlockLabels)
                {
                    blok.BackColor = blokEmptyColor[0];
                }

                //opadanie po wyczyszczeniu
                int ileKlockow = 0;
                foreach (bool blokFilled in bloksFilled)
                {
                    if (blokFilled == true)
                    {
                        BlockLabels[ileKlockow].BackColor = blokEmptyColor[1];
                    }
                    ileKlockow++;
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

            //kiedy klocki sa az do samej gory
            if (BlockLabels[2].BackColor == blokEmptyColor[1] && BlockLabels[2 + 5].BackColor == blokEmptyColor[1])
            {
                _timer.Stop();
                DialogResult quitOrContinue = MessageBox.Show("Przegrales. Czy chcesz grac od nowa?", "Przegrana!", MessageBoxButtons.YesNo);
                if (quitOrContinue == DialogResult.Yes)
                {
                    foreach (Label blok in BlockLabels)
                    {
                        blok.BackColor = blokEmptyColor[0];
                    }
                    bloksFilled = new bool[40];
                    tetrisPiecePosition = -3;
                    _timer.Start();
                }
                else
                {
                    Environment.Exit(0);
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

        private void oAutorzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            	MessageBox.Show("Martyna Florian","Informacja o Autorze",MessageBoxButtons.OK,MessageBoxIcon.Warning);

        }

        private void zabijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void jakGracToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jesli spadajace klocki zapelnia linie, to ona znika, a powyzsze klocki spadaja linie nizej. Przegrana jest wtedy, gdy klocki ulozone jeden na drugim dotkna gornej czesci planszy. Powodzenia! ", "Zasady gry", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
