namespace politicalFever
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtCan1 = new System.Windows.Forms.TextBox();
            this.txtCan2 = new System.Windows.Forms.TextBox();
            this.lblCanPercent1 = new System.Windows.Forms.Label();
            this.lblCanPercent2 = new System.Windows.Forms.Label();
            this.lblTotalBet = new System.Windows.Forms.Label();
            this.txtTotalVote = new System.Windows.Forms.TextBox();
            this.lblCanPercent3 = new System.Windows.Forms.Label();
            this.lblCan3 = new System.Windows.Forms.Label();
            this.lblFinalCan1 = new System.Windows.Forms.Label();
            this.lblVotesCan1 = new System.Windows.Forms.Label();
            this.lblFinalCan2 = new System.Windows.Forms.Label();
            this.lblVotesCan2 = new System.Windows.Forms.Label();
            this.lblFinalCan3 = new System.Windows.Forms.Label();
            this.lblVotesCan3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(105, 160);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtCan1
            // 
            this.txtCan1.Location = new System.Drawing.Point(92, 80);
            this.txtCan1.Name = "txtCan1";
            this.txtCan1.Size = new System.Drawing.Size(100, 20);
            this.txtCan1.TabIndex = 1;
            // 
            // txtCan2
            // 
            this.txtCan2.Location = new System.Drawing.Point(92, 106);
            this.txtCan2.Name = "txtCan2";
            this.txtCan2.Size = new System.Drawing.Size(100, 20);
            this.txtCan2.TabIndex = 3;
            // 
            // lblCanPercent1
            // 
            this.lblCanPercent1.AutoSize = true;
            this.lblCanPercent1.Location = new System.Drawing.Point(5, 87);
            this.lblCanPercent1.Name = "lblCanPercent1";
            this.lblCanPercent1.Size = new System.Drawing.Size(81, 13);
            this.lblCanPercent1.TabIndex = 4;
            this.lblCanPercent1.Text = "Can 1 Percent :";
            // 
            // lblCanPercent2
            // 
            this.lblCanPercent2.AutoSize = true;
            this.lblCanPercent2.Location = new System.Drawing.Point(5, 113);
            this.lblCanPercent2.Name = "lblCanPercent2";
            this.lblCanPercent2.Size = new System.Drawing.Size(81, 13);
            this.lblCanPercent2.TabIndex = 5;
            this.lblCanPercent2.Text = "Can 2 Percent :";
            // 
            // lblTotalBet
            // 
            this.lblTotalBet.AutoSize = true;
            this.lblTotalBet.Location = new System.Drawing.Point(19, 61);
            this.lblTotalBet.Name = "lblTotalBet";
            this.lblTotalBet.Size = new System.Drawing.Size(67, 13);
            this.lblTotalBet.TabIndex = 8;
            this.lblTotalBet.Text = "Total Votes :";
            // 
            // txtTotalVote
            // 
            this.txtTotalVote.Location = new System.Drawing.Point(92, 54);
            this.txtTotalVote.Name = "txtTotalVote";
            this.txtTotalVote.Size = new System.Drawing.Size(100, 20);
            this.txtTotalVote.TabIndex = 7;
            // 
            // lblCanPercent3
            // 
            this.lblCanPercent3.AutoSize = true;
            this.lblCanPercent3.Location = new System.Drawing.Point(5, 139);
            this.lblCanPercent3.Name = "lblCanPercent3";
            this.lblCanPercent3.Size = new System.Drawing.Size(81, 13);
            this.lblCanPercent3.TabIndex = 6;
            this.lblCanPercent3.Text = "Can 3 Percent :";
            // 
            // lblCan3
            // 
            this.lblCan3.AutoSize = true;
            this.lblCan3.Location = new System.Drawing.Point(92, 139);
            this.lblCan3.Name = "lblCan3";
            this.lblCan3.Size = new System.Drawing.Size(51, 13);
            this.lblCan3.TabIndex = 9;
            this.lblCan3.Text = "unknown";
            // 
            // lblFinalCan1
            // 
            this.lblFinalCan1.AutoSize = true;
            this.lblFinalCan1.Location = new System.Drawing.Point(299, 54);
            this.lblFinalCan1.Name = "lblFinalCan1";
            this.lblFinalCan1.Size = new System.Drawing.Size(51, 13);
            this.lblFinalCan1.TabIndex = 11;
            this.lblFinalCan1.Text = "unknown";
            // 
            // lblVotesCan1
            // 
            this.lblVotesCan1.AutoSize = true;
            this.lblVotesCan1.Location = new System.Drawing.Point(212, 54);
            this.lblVotesCan1.Name = "lblVotesCan1";
            this.lblVotesCan1.Size = new System.Drawing.Size(68, 13);
            this.lblVotesCan1.TabIndex = 10;
            this.lblVotesCan1.Text = "Can 1 Votes:";
            // 
            // lblFinalCan2
            // 
            this.lblFinalCan2.AutoSize = true;
            this.lblFinalCan2.Location = new System.Drawing.Point(299, 80);
            this.lblFinalCan2.Name = "lblFinalCan2";
            this.lblFinalCan2.Size = new System.Drawing.Size(51, 13);
            this.lblFinalCan2.TabIndex = 13;
            this.lblFinalCan2.Text = "unknown";
            // 
            // lblVotesCan2
            // 
            this.lblVotesCan2.AutoSize = true;
            this.lblVotesCan2.Location = new System.Drawing.Point(212, 80);
            this.lblVotesCan2.Name = "lblVotesCan2";
            this.lblVotesCan2.Size = new System.Drawing.Size(68, 13);
            this.lblVotesCan2.TabIndex = 12;
            this.lblVotesCan2.Text = "Can 2 Votes:";
            // 
            // lblFinalCan3
            // 
            this.lblFinalCan3.AutoSize = true;
            this.lblFinalCan3.Location = new System.Drawing.Point(299, 106);
            this.lblFinalCan3.Name = "lblFinalCan3";
            this.lblFinalCan3.Size = new System.Drawing.Size(51, 13);
            this.lblFinalCan3.TabIndex = 15;
            this.lblFinalCan3.Text = "unknown";
            // 
            // lblVotesCan3
            // 
            this.lblVotesCan3.AutoSize = true;
            this.lblVotesCan3.Location = new System.Drawing.Point(212, 106);
            this.lblVotesCan3.Name = "lblVotesCan3";
            this.lblVotesCan3.Size = new System.Drawing.Size(68, 13);
            this.lblVotesCan3.TabIndex = 14;
            this.lblVotesCan3.Text = "Can 3 Votes:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 262);
            this.Controls.Add(this.lblFinalCan3);
            this.Controls.Add(this.lblVotesCan3);
            this.Controls.Add(this.lblFinalCan2);
            this.Controls.Add(this.lblVotesCan2);
            this.Controls.Add(this.lblFinalCan1);
            this.Controls.Add(this.lblVotesCan1);
            this.Controls.Add(this.lblCan3);
            this.Controls.Add(this.lblTotalBet);
            this.Controls.Add(this.txtTotalVote);
            this.Controls.Add(this.lblCanPercent3);
            this.Controls.Add(this.lblCanPercent2);
            this.Controls.Add(this.lblCanPercent1);
            this.Controls.Add(this.txtCan2);
            this.Controls.Add(this.txtCan1);
            this.Controls.Add(this.btnCalc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtCan1;
        private System.Windows.Forms.TextBox txtCan2;
        private System.Windows.Forms.Label lblCanPercent1;
        private System.Windows.Forms.Label lblCanPercent2;
        private System.Windows.Forms.Label lblTotalBet;
        private System.Windows.Forms.TextBox txtTotalVote;
        private System.Windows.Forms.Label lblCanPercent3;
        private System.Windows.Forms.Label lblCan3;
        private System.Windows.Forms.Label lblFinalCan1;
        private System.Windows.Forms.Label lblVotesCan1;
        private System.Windows.Forms.Label lblFinalCan2;
        private System.Windows.Forms.Label lblVotesCan2;
        private System.Windows.Forms.Label lblFinalCan3;
        private System.Windows.Forms.Label lblVotesCan3;
    }
}

