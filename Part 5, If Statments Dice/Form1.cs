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
        int bet;
        int bankAccount;
        int die1;
        int die2;
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
            bankAccount = 100;
            int currentBet;


            Roll();

            if (Int32.TryParse(txtBet.Text, out currentBet))
            {

                if (bet <= bankAccount)
                {
                    bet = 0;
                }
                // bet is valid

                if (doubles == true)
                {




                }
                else if (notDoubles == true)
                {


                }
                else if (evenSum == true) 
                { 
                    

                }
                else if (oddSum == true)
                {


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
