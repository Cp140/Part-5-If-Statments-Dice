using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_5__If_Statments_Dice
{
    public partial class frmMain : Form
    {
        //Random generator
        Random rnd = new Random();

        //Variables
        double bet;
        double bankAccount = 100;
        double die1;
        double die2;
        double currentBet;
        bool doubles = false;
        bool notDoubles = false;
        bool evenSum = false;
        bool oddSum = false;
        
        public frmMain()
        {
            InitializeComponent();
        }
        public void Roll()
        {
            die1 = rnd.Next(0, 7);
            die2 = rnd.Next(0, 7);
            rtbDie1.Text = ($"{die1}");
            rtbDie2.Text = ($"{die2}");
        }



            private void btnBet_Click(object sender, EventArgs e)
        {
            
            


            Roll();

            if (double.TryParse(txtBet.Text, out currentBet))
            {

                if (bet <= bankAccount)
                {
                    bet = 0;
                }
                // bet is valid

                if (doubles == true && die1 == die2)
                {
                     bankAccount = bankAccount + (currentBet * 2);
                     txtBank.Text = ($"{bankAccount}");
                   

                }
                else if (notDoubles == true && die1 != die2)
                {
                    bankAccount = bankAccount + (currentBet * 1.5);
                    txtBank.Text = ($"{bankAccount}");

                }
                else if (evenSum == true && ((die1 + die2) % 2 == 0))
                {
                    bankAccount = bankAccount + (currentBet * 2);
                    txtBank.Text = ($"{bankAccount}");
                }
                else if (oddSum == true && ((die1 + die2) % 2 == 1))
                {
                    bankAccount = bankAccount + (currentBet * 2);
                    txtBank.Text = ($"{bankAccount}");

                }
                else
                {
                    bankAccount = bankAccount - currentBet;
                    txtBank.Text = ($"{bankAccount}");
                }




            }
            else
            {

            }
        }

        private void btnDoubles_Click(object sender, EventArgs e)
        {
            doubles = true;
            notDoubles = false;
            evenSum = false;
            oddSum = false;
        }

        private void btnNotDouble_Click(object sender, EventArgs e)
        {
            doubles = false;
            notDoubles = true;
            evenSum = false;
            oddSum = false;
        }

        private void btnEvenSum_Click(object sender, EventArgs e)
        {
            doubles = false;
            notDoubles = false;
            evenSum = true;
            oddSum = false;
        }

        private void btnOddSum_Click(object sender, EventArgs e)
        {
            doubles = false;
            notDoubles = false;
            evenSum = false;
            oddSum = true;
        }

        
    }
}
