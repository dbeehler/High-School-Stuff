namespace deepSpaceInvaders
{
    partial class level
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.playerPictureBox = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.shootTimer = new System.Windows.Forms.Timer(this.components);
            this.lblKills = new System.Windows.Forms.Label();
            this.playerTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // playerPictureBox
            // 
            this.playerPictureBox.Image = global::deepSpaceInvaders.Properties.Resources.First_Ball_50;
            this.playerPictureBox.Location = new System.Drawing.Point(260, 499);
            this.playerPictureBox.Name = "playerPictureBox";
            this.playerPictureBox.Size = new System.Drawing.Size(50, 50);
            this.playerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.playerPictureBox.TabIndex = 1;
            this.playerPictureBox.TabStop = false;
            this.playerPictureBox.Tag = "player";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(553, 459);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(143, 39);
            this.lblScore.TabIndex = 47;
            this.lblScore.Text = "Score: 0";
            // 
            // shootTimer
            // 
            this.shootTimer.Enabled = true;
            this.shootTimer.Interval = 2500;
            this.shootTimer.Tick += new System.EventHandler(this.shootTimer_Tick);
            // 
            // lblKills
            // 
            this.lblKills.AutoSize = true;
            this.lblKills.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKills.Location = new System.Drawing.Point(553, 498);
            this.lblKills.Name = "lblKills";
            this.lblKills.Size = new System.Drawing.Size(143, 39);
            this.lblKills.TabIndex = 48;
            this.lblKills.Text = "Score: 0";
            // 
            // playerTimer
            // 
            this.playerTimer.Interval = 75;
            this.playerTimer.Tick += new System.EventHandler(this.playerTimer_Tick);
            // 
            // level
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblKills);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.playerPictureBox);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "level";
            this.Text = "level";
            this.Load += new System.EventHandler(this.level_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox playerPictureBox;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer shootTimer;
        private System.Windows.Forms.Label lblKills;
        private System.Windows.Forms.Timer playerTimer;
    }
}