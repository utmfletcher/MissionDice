using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MissionDice
{
    internal class DiceTools
    {

        Random random = new Random();

        public void RollDice(int numRolls) 
        {
            // Creates an array that will hold the possible values for two 6 sided dice 
            int[] resultArray = new int[13];


            
            for (int i = 0; i < numRolls; i++) // for as manny rolls as the user inputs . . .
            {
                int roll = (random.Next(1, 7) + random.Next(1, 7)); // . . .simulate the roll . . 
                
                resultArray[roll]++; // . . . and assign the result to the result array in the correct position
            }

            for (int i = 2; i <= 12; i++) 
            {   
                // find position in array
                int number = i; 
                
                // calculate the percentage
                float percentage =(float)Math.Round((resultArray[i] / (float)numRolls ), 2) ; 
                percentage = (int)(percentage * 100);


                // Generate appropriate asterises  
                string asterisks = new string('*', (int)percentage);


                //output 
                Console.WriteLine(number + ":" + asterisks);
            }
        }
    }
}
