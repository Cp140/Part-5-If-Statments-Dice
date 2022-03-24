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
            this.SuspendLayout();
            // 
            // btnBet
            // 
            this.btnBet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet.Location = new System.Drawing.Point(85, 251);
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
            this.txtBank.Location = new System.Drawing.Point(391, 107);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(63, 24);
            this.txtBank.TabIndex = 1;
            this.txtBank.Text = "100.00$";
            // 
            // rtbDie1
            // 
            this.rtbDie1.Location = new System.Drawing.Point(23, 54);
            this.rtbDie1.Name = "rtbDie1";
            this.rtbDie1.Size = new System.Drawing.Size(160, 152);
            this.rtbDie1.TabIndex = 2;
            this.rtbDie1.Text = "";
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBank.ForeColor = System.Drawing.Color.White;
            this.lblBank.Location = new System.Drawing.Point(375, 80);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(100, 18);
            this.lblBank.TabIndex = 3;
            this.lblBank.Text = "Bank Account";
            // 
            // rtbDie2
            // 
            this.rtbDie2.Location = new System.Drawing.Point(198, 54);
            this.rtbDie2.Name = "rtbDie2";
            this.rtbDie2.Size = new System.Drawing.Size(160, 152);
            this.rtbDie2.TabIndex = 4;
            this.rtbDie2.Text = "";
            // 
            // txtBet
            // 
            this.txtBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBet.Location = new System.Drawing.Point(155, 221);
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(492, 337);
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
    }
}

