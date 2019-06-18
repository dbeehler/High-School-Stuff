namespace deepSpaceInvaders
{
    partial class HighScores
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
            this.highSoreList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // highSoreList
            // 
            this.highSoreList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.highSoreList.FormattingEnabled = true;
            this.highSoreList.Location = new System.Drawing.Point(0, 0);
            this.highSoreList.Name = "highSoreList";
            this.highSoreList.Size = new System.Drawing.Size(295, 450);
            this.highSoreList.TabIndex = 0;
            // 
            // HighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 450);
            this.Controls.Add(this.highSoreList);
            this.Name = "HighScores";
            this.Text = "Highschores";
            this.Load += new System.EventHandler(this.HighScores_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox highSoreList;
    }
}