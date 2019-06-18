namespace deepSpaceInvaders
{
    partial class optionMenu
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
            this.btnCont = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.usrName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.blinkTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnCont
            // 
            this.btnCont.Location = new System.Drawing.Point(101, 86);
            this.btnCont.Name = "btnCont";
            this.btnCont.Size = new System.Drawing.Size(75, 23);
            this.btnCont.TabIndex = 0;
            this.btnCont.Text = "Continue";
            this.btnCont.UseVisualStyleBackColor = true;
            this.btnCont.Click += new System.EventHandler(this.btnCont_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "You lost. Exit to main menu.";
            // 
            // usrName
            // 
            this.usrName.Location = new System.Drawing.Point(82, 47);
            this.usrName.Name = "usrName";
            this.usrName.Size = new System.Drawing.Size(100, 20);
            this.usrName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Red;
            this.lblName.Location = new System.Drawing.Point(79, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(92, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "ENTER NAME:";
            // 
            // blinkTimer
            // 
            this.blinkTimer.Enabled = true;
            this.blinkTimer.Interval = 250;
            this.blinkTimer.Tick += new System.EventHandler(this.blinkTimer_Tick);
            // 
            // optionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 118);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.usrName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCont);
            this.Name = "optionMenu";
            this.Text = "optionMenu";
            this.Load += new System.EventHandler(this.optionMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usrName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Timer blinkTimer;
    }
}