using System.Drawing;

namespace One_Sq_Tetris
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
            this.blockPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // blockPanel
            // 
            this.blockPanel.Location = new System.Drawing.Point(12, 12);
            this.blockPanel.Name = "blockPanel";
            this.blockPanel.Size = new System.Drawing.Size(350, 500);
            this.blockPanel.TabIndex = 0;
            this.blockPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);


            //tworzymy etykiety
            int blokNumber = 0;
            int blokPossitionX = 0;
            int blokRow = 0;


            foreach (System.Windows.Forms.Label blok in blockLabels)
            {
                blockLabels[blokNumber] = new System.Windows.Forms.Label();
                this.blockLabels[blokNumber].BackColor = Color.LightCoral;
                this.blockLabels[blokNumber].Location = new System.Drawing.Point(60 * blokPossitionX,60 * blokRow);
                this.blockLabels[blokNumber].Name = "blokLabel" + blokNumber.ToString();
                this.blockLabels[blokNumber].Size = new System.Drawing.Size(50,50);
                this.blockLabels[blokNumber].TabIndex = blokNumber;
                blokNumber++;
                blokPossitionX++;


                if (blokNumber == 5)
                {
                    blokRow++;
                    blokPossitionX = 0;
                }

                if (blokNumber == 10)
                {
                    blokRow++;
                    blokPossitionX = 0;
                }
                if (blokNumber == 15)
                {
                    blokRow++;
                    blokPossitionX = 0;
                }

                if (blokNumber == 20)
                {
                    blokRow++;
                    blokPossitionX = 0;
                }
                if (blokNumber == 25)
                {
                    blokRow++;
                    blokPossitionX = 0;
                }

                if (blokNumber == 30)
                {
                    blokRow++;
                    blokPossitionX = 0;
                }
                if (blokNumber == 35)
                {
                    blokRow++;
                    blokPossitionX = 0;
                }

                if (blokNumber == 40)
                {
                    blokRow++;
                    blokPossitionX = 0;
                }

                blokNumber = 0;

                foreach (System.Windows.Forms.Label blok in blockLabels)
                {
                    this.blockPanel.Controls.Add(this.blockLabels[blokNumber]);
                    blokNumber++;
                }

            }

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(350, 500);
            this.Controls.Add(this.blockPanel);
            this.Name = "Form1";
            this.Text = "Tetris One Square";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel blockPanel;

        private System.Windows.Forms.Label[] blockLabels;

        public System.Windows.Forms.Label[] BlockLabels
        {
            get { return blockLabels; }
            set { blockLabels = value; }
        }

    }
}

