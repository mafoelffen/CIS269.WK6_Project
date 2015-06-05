namespace _42dayrange
{
    partial class EasterEggForm
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbPacman = new System.Windows.Forms.PictureBox();
            this.pbMinion = new System.Windows.Forms.PictureBox();
            this.lblNotice = new System.Windows.Forms.Label();
            this.lblNotice2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPacman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinion)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbPacman
            // 
            this.pbPacman.BackgroundImage = global::_42dayrange.Properties.Resources.PacMan;
            this.pbPacman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPacman.Location = new System.Drawing.Point(-4, 177);
            this.pbPacman.Name = "pbPacman";
            this.pbPacman.Size = new System.Drawing.Size(47, 38);
            this.pbPacman.TabIndex = 0;
            this.pbPacman.TabStop = false;
            // 
            // pbMinion
            // 
            this.pbMinion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinion.BackgroundImage = global::_42dayrange.Properties.Resources.YellowMinion;
            this.pbMinion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMinion.Location = new System.Drawing.Point(378, 121);
            this.pbMinion.Name = "pbMinion";
            this.pbMinion.Size = new System.Drawing.Size(69, 106);
            this.pbMinion.TabIndex = 1;
            this.pbMinion.TabStop = false;
            // 
            // lblNotice
            // 
            this.lblNotice.AutoSize = true;
            this.lblNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotice.Location = new System.Drawing.Point(23, 252);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(60, 20);
            this.lblNotice.TabIndex = 2;
            this.lblNotice.Text = "Notice";
            // 
            // lblNotice2
            // 
            this.lblNotice2.AutoSize = true;
            this.lblNotice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotice2.Location = new System.Drawing.Point(27, 285);
            this.lblNotice2.Name = "lblNotice2";
            this.lblNotice2.Size = new System.Drawing.Size(70, 20);
            this.lblNotice2.TabIndex = 3;
            this.lblNotice2.Text = "Notice2";
            // 
            // EasterEggForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 333);
            this.Controls.Add(this.lblNotice2);
            this.Controls.Add(this.lblNotice);
            this.Controls.Add(this.pbMinion);
            this.Controls.Add(this.pbPacman);
            this.Name = "EasterEggForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasterEggForm";
            this.Load += new System.EventHandler(this.EasterEggForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPacman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbPacman;
        private System.Windows.Forms.PictureBox pbMinion;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.Label lblNotice2;
    }
}