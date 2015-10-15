/*
 * Created by: Alex Mathias
 * Created on: 05-Oct-2015
 * Created for: ICS3U
 * Daily Assignment – Unit 3-05
 * This program is a Factorial number calculator
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorialNumber
{
    public partial class frmFactorialNumber : Form
    {
        public frmFactorialNumber()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Variables
            Double factorialNumber;
            Double factorialAnswer;
            int factorialCounter;

            this.lstListBox.Items.Clear();
            factorialAnswer = 1;
            factorialNumber = Convert.ToDouble(this.txtFactorialNumber.Text)+1; //sorry about that.
            factorialCounter = 0;

            //loop
           
           for (factorialCounter = 1; factorialNumber != factorialCounter; factorialCounter++)   {
 
                this.lstListBox.Items.Add(factorialCounter);
                factorialAnswer = factorialAnswer * factorialCounter;

            } 

            //Output
            this.lblAnswer.Text = Convert.ToString(factorialAnswer);
        }
    }
}
