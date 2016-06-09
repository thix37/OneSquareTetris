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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.graToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zabijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAutorzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jakGracToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.blockLabels = new System.Windows.Forms.Label[40];
            this.SuspendLayout();
            // 
            // blockPanel
            // 
            this.blockPanel.Location = new System.Drawing.Point(0, 27);
            this.blockPanel.Name = "blockPanel";
            this.blockPanel.Size = new System.Drawing.Size(350, 550);
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
                this.blockLabels[blokNumber].Location = new System.Drawing.Point(60 * blokPossitionX, 60 * blokRow);
                this.blockLabels[blokNumber].Name = "blokLabel" + blokNumber.ToString();
                this.blockLabels[blokNumber].Size = new System.Drawing.Size(50, 50);
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

            }

                blokNumber = 0;

                foreach (System.Windows.Forms.Label blok in blockLabels)
                {
                    this.blockPanel.Controls.Add(this.blockLabels[blokNumber]);
                    blokNumber++;
                }

            
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graToolStripMenuItem,
            this.oAutorzeToolStripMenuItem,
            this.jakGracToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(350, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // graToolStripMenuItem
            // 
            this.graToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zabijToolStripMenuItem});
            this.graToolStripMenuItem.Name = "graToolStripMenuItem";
            this.graToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.graToolStripMenuItem.Text = "Gra";
            // 
            // zabijToolStripMenuItem
            // 
            this.zabijToolStripMenuItem.Name = "zabijToolStripMenuItem";
            this.zabijToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.zabijToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zabijToolStripMenuItem.Text = "Zabij";
            this.zabijToolStripMenuItem.Click += new System.EventHandler(this.zabijToolStripMenuItem_Click);
            // 
            // oAutorzeToolStripMenuItem
            // 
            this.oAutorzeToolStripMenuItem.Name = "oAutorzeToolStripMenuItem";
            this.oAutorzeToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.oAutorzeToolStripMenuItem.Text = "O Autorze";
            this.oAutorzeToolStripMenuItem.Click += new System.EventHandler(this.oAutorzeToolStripMenuItem_Click);
            // 
            // jakGracToolStripMenuItem
            // 
            this.jakGracToolStripMenuItem.Name = "jakGracToolStripMenuItem";
            this.jakGracToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.jakGracToolStripMenuItem.Text = "Jak grac?";
            this.jakGracToolStripMenuItem.Click += new System.EventHandler(this.jakGracToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(350, 500);
            this.Controls.Add(this.blockPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Tetris One Square";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel blockPanel;

        private System.Windows.Forms.Label[] blockLabels;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem graToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zabijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAutorzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jakGracToolStripMenuItem;

        public System.Windows.Forms.Label[] BlockLabels
        {
            get { return blockLabels; }
            set { blockLabels = value; }
        }

    }
}

