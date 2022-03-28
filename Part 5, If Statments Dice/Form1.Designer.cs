namespace Part_5__If_Statments_Dice
{
    partial class frmMain
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
            this.btnBet = new System.Windows.Forms.Button();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.rtbDie1 = new System.Windows.Forms.RichTextBox();
            this.lblBank = new System.Windows.Forms.Label();
            this.rtbDie2 = new System.Windows.Forms.RichTextBox();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnOddSum = new System.Windows.Forms.Button();
            this.btnEvenSum = new System.Windows.Forms.Button();
            this.btnNotDouble = new System.Windows.Forms.Button();
            this.btnDoubles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBet
            // 
            this.btnBet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet.Location = new System.Drawing.Point(114, 364);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(218, 51);
            this.btnBet.TabIndex = 0;
            this.btnBet.Text = "Roll";
            this.btnBet.UseVisualStyleBackColor = false;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // txtBank
            // 
            this.txtBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBank.Location = new System.Drawing.Point(464, 99);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(63, 24);
            this.txtBank.TabIndex = 1;
            this.txtBank.Text = "100.00$";
            // 
            // rtbDie1
            // 
            this.rtbDie1.Location = new System.Drawing.Point(17, 72);
            this.rtbDie1.Name = "rtbDie1";
            this.rtbDie1.Size = new System.Drawing.Size(208, 208);
            this.rtbDie1.TabIndex = 2;
            this.rtbDie1.Text = "";
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBank.ForeColor = System.Drawing.Color.White;
            this.lblBank.Location = new System.Drawing.Point(448, 72);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(100, 18);
            this.lblBank.TabIndex = 3;
            this.lblBank.Text = "Bank Account";
            // 
            // rtbDie2
            // 
            this.rtbDie2.Location = new System.Drawing.Point(231, 72);
            this.rtbDie2.Name = "rtbDie2";
            this.rtbDie2.Size = new System.Drawing.Size(208, 208);
            this.rtbDie2.TabIndex = 4;
            this.rtbDie2.Text = "";
            // 
            // txtBet
            // 
            this.txtBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBet.Location = new System.Drawing.Point(184, 334);
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(72, 24);
            this.txtBet.TabIndex = 5;
            this.txtBet.Text = "Place Bet";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(26, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(377, 24);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Place your bet, try your luck, You can\'t losse";
            // 
            // btnOddSum
            // 
            this.btnOddSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOddSum.Location = new System.Drawing.Point(338, 286);
            this.btnOddSum.Name = "btnOddSum";
            this.btnOddSum.Size = new System.Drawing.Size(101, 34);
            this.btnOddSum.TabIndex = 7;
            this.btnOddSum.Text = "Odd Sum";
            this.btnOddSum.UseVisualStyleBackColor = true;
            // 
            // btnEvenSum
            // 
            this.btnEvenSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvenSum.Location = new System.Drawing.Point(231, 286);
            this.btnEvenSum.Name = "btnEvenSum";
            this.btnEvenSum.Size = new System.Drawing.Size(101, 34);
            this.btnEvenSum.TabIndex = 8;
            this.btnEvenSum.Text = "Even Sum";
            this.btnEvenSum.UseVisualStyleBackColor = true;
            // 
            // btnNotDouble
            // 
            this.btnNotDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotDouble.Location = new System.Drawing.Point(124, 286);
            this.btnNotDouble.Name = "btnNotDouble";
            this.btnNotDouble.Size = new System.Drawing.Size(101, 34);
            this.btnNotDouble.TabIndex = 9;
            this.btnNotDouble.Text = "Not Double";
            this.btnNotDouble.UseVisualStyleBackColor = true;
            // 
            // btnDoubles
            // 
            this.btnDoubles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoubles.Location = new System.Drawing.Point(17, 286);
            this.btnDoubles.Name = "btnDoubles";
            this.btnDoubles.Size = new System.Drawing.Size(101, 34);
            this.btnDoubles.TabIndex = 10;
            this.btnDoubles.Text = "Doubles";
            this.btnDoubles.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(568, 437);
            this.Controls.Add(this.btnDoubles);
            this.Controls.Add(this.btnNotDouble);
            this.Controls.Add(this.btnEvenSum);
            this.Controls.Add(this.btnOddSum);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtBet);
            this.Controls.Add(this.rtbDie2);
            this.Controls.Add(this.lblBank);
            this.Controls.Add(this.rtbDie1);
            this.Controls.Add(this.txtBank);
            this.Controls.Add(this.btnBet);
            this.Name = "frmMain";
            this.Text = "Gambling Sim 2023";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.RichTextBox rtbDie1;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.RichTextBox rtbDie2;
        private System.Windows.Forms.TextBox txtBet;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnOddSum;
        private System.Windows.Forms.Button btnEvenSum;
        private System.Windows.Forms.Button btnNotDouble;
        private System.Windows.Forms.Button btnDoubles;
    }
}

