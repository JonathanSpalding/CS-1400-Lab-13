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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokenMachine
{
    // The Box class definition
    class TokenMachine
    {
        // State the data members of the class. 
        private int numTokens = 100;
        private int numQuarters = 0;

        // The default constructor
        // Purpose: It sets all declared variables (data members of the class) to what they need to be.
        // Parameters: None
        // Returns: None
        public TokenMachine()
            {
            numTokens = 100;
            numQuarters = 0;
            }

        // The parameterized constructor
        // Purpose: It sets all declared variables (data members of the class) to the values passed in
        // Parameters: Integers, the numTokens and numQuarters.
        // Returns: None
        public TokenMachine(int p1, int p2)
        {
            numTokens = p1;
            numQuarters = p2;
        }
        // The Reset method
        // Purpose: If this isn't here the program breaks. 
        // Parameters: None
        // Returns: none. I've tried to figure it out, but none of the slides, videos, or books show how to get this working. It doesn't seem to work the same as the other methods.
        public void Reset()
        {

        }
        // The GetToken method
        // Purpose: return the number of tokens minus one
        // Parameters: None
        // Returns: An integer height value
        public int GetToken()
        {
            numTokens = --numTokens;
            return numTokens;
        }
        // The CountQuarters method
        // Purpose: To return the number of quarters plus one.
        // Parameters: None
        // Returns: An integer height value
        public int CountQuarters()
        {
            numQuarters = ++numQuarters;
            return numQuarters;
        }
    }
}
