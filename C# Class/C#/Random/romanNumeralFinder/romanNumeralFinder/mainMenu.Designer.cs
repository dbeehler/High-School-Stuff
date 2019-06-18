namespace romanNumeralFinder
{
    partial class mainMenu
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
            this.btnCalcualte = new System.Windows.Forms.Button();
            this.txtNumeral = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcualte
            // 
            this.btnCalcualte.Location = new System.Drawing.Point(54, 79);
            this.btnCalcualte.Name = "btnCalcualte";
            this.btnCalcualte.Size = new System.Drawing.Size(75, 23);
            this.btnCalcualte.TabIndex = 0;
            this.btnCalcualte.Text = "Calculate";
            this.btnCalcualte.UseVisualStyleBackColor = true;
            this.btnCalcualte.Click += new System.EventHandler(this.btnCalcualte_Click);
            // 
            // txtNumeral
            // 
            this.txtNumeral.Location = new System.Drawing.Point(62, 12);
            this.txtNumeral.Name = "txtNumeral";
            this.txtNumeral.Size = new System.Drawing.Size(100, 20);
            this.txtNumeral.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Roman \r\nNumeral";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(66, 48);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(51, 13);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "unknown";
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 115);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumeral);
            this.Controls.Add(this.btnCalcualte);
            this.Name = "mainMenu";
            this.Text = "Translate";
            this.Load += new System.EventHandler(this.mainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcualte;
        private System.Windows.Forms.TextBox txtNumeral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumber;
    }
}

