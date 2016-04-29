// Author: Jonathan Spalding
// Assignment: Lab 13
// Instructor "Roger deBry
// Clas: CS 1400
// Date Written: 2/18/2016
//
// "I declare that the following source code was written solely by me. I understand that copying any source code, in whole or in part, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy."
//----------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TokenMachine
{
    public partial class Form1 : Form
    {
        // a class level reference to a token machine
        private TokenMachine tm;
        public Form1()
        {
            InitializeComponent();
            // create a token machine object
            tm = new TokenMachine();
            tm.Reset();
        }
        // The exitToolStripMenuItem1_Click Method
        // Purpose: Display a pop up box when you click About
        // Parameters: The sending object, and the event arguments
        // Returns: none
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // The aboutToolStripMenuItem_Click Method
        // Purpose: Display a pop up box when you click About
        // Parameters: The sending object, and the event arguments
        // Returns: none
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jonathan Spalding\nCS1400\nLab 13");

        }
        // The button1_click method
        // Purpose: call back the methods from the TokenMachine.cs file and outstring it into the text boxes.
        // Parameters: The sending object, and the event arguments
        // returns: none
        private void button1_Click(object sender, EventArgs e)
        {
            //call back the methods for adding quarters and removing tokens.
            int quartersTotal = tm.CountQuarters();
            int tokensTotal = tm.GetToken();
            //convert to strings and place them in their own variables.
            string quarterOutStr = $"{quartersTotal}";
            string tokenOutStr = $"{tokensTotal}";
            //output the strings in the text boxes.
            quarters.Text = quarterOutStr;
            tokens.Text = tokenOutStr;
        }
        // The button2_click method
        // Purpose: revert the results back to 0 and 100.
        // Parameters: The sending object, and the event arguments
        // returns: none
        private void button2_Click(object sender, EventArgs e)
        {
            //put back the original strings for the text boxes.
            quarters.Text = "0";
            tokens.Text = "100";
        }
    }
}
