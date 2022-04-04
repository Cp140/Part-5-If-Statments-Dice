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
            this.lblBank = new System.Windows.Forms.Label();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnOddSum = new System.Windows.Forms.Button();
            this.btnEvenSum = new System.Windows.Forms.Button();
            this.btnNotDouble = new System.Windows.Forms.Button();
            this.btnDoubles = new System.Windows.Forms.Button();
            this.imgDie1 = new System.Windows.Forms.PictureBox();
            this.imgDie2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgDie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDie2)).BeginInit();
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
            this.txtBank.Location = new System.Drawing.Point(451, 96);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(105, 24);
            this.txtBank.TabIndex = 1;
            this.txtBank.Text = "100$";
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
            // txtBet
            // 
            this.txtBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBet.Location = new System.Drawing.Point(184, 334);
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(84, 24);
            this.txtBet.TabIndex = 5;
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
            this.btnOddSum.Click += new System.EventHandler(this.btnOddSum_Click);
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
            this.btnEvenSum.Click += new System.EventHandler(this.btnEvenSum_Click);
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
            this.btnNotDouble.Click += new System.EventHandler(this.btnNotDouble_Click);
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
            this.btnDoubles.Click += new System.EventHandler(this.btnDoubles_Click);
            // 
            // imgDie1
            // 
            this.imgDie1.BackColor = System.Drawing.Color.LimeGreen;
            this.imgDie1.Location = new System.Drawing.Point(17, 72);
            this.imgDie1.Name = "imgDie1";
            this.imgDie1.Size = new System.Drawing.Size(208, 208);
            this.imgDie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDie1.TabIndex = 11;
            this.imgDie1.TabStop = false;
            // 
            // imgDie2
            // 
            this.imgDie2.BackColor = System.Drawing.Color.LimeGreen;
            this.imgDie2.Location = new System.Drawing.Point(231, 72);
            this.imgDie2.Name = "imgDie2";
            this.imgDie2.Size = new System.Drawing.Size(208, 208);
            this.imgDie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDie2.TabIndex = 12;
            this.imgDie2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(448, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 126);
            this.label1.TabIndex = 13;
            this.label1.Text = "Gambling Sim 2023\r\nchose a die out come \r\nand select a bet \r\nammount. Double 2x \r" +
    "\nbet, Not double 1.5x \r\nEven sum Win bet,\r\nOdd sum Win bet\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(111, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "place bet";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(607, 437);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgDie2);
            this.Controls.Add(this.imgDie1);
            this.Controls.Add(this.btnDoubles);
            this.Controls.Add(this.btnNotDouble);
            this.Controls.Add(this.btnEvenSum);
            this.Controls.Add(this.btnOddSum);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtBet);
            this.Controls.Add(this.lblBank);
            this.Controls.Add(this.txtBank);
            this.Controls.Add(this.btnBet);
            this.Name = "frmMain";
            this.Text = "Gambling Sim 2023";
            ((System.ComponentModel.ISupportInitialize)(this.imgDie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDie2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.TextBox txtBet;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnOddSum;
        private System.Windows.Forms.Button btnEvenSum;
        private System.Windows.Forms.Button btnNotDouble;
        private System.Windows.Forms.Button btnDoubles;
        private System.Windows.Forms.PictureBox imgDie1;
        private System.Windows.Forms.PictureBox imgDie2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

