using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    internal class RollDice
    {
        public void Roll(int iRolls)
        {
            // Create a array for possible roll numbers.
            int[] rollTotals = new int[13];

            for (int iCount = 0; iCount < iRolls; iCount++)
            {
                Random rnd = new Random();
                int iDieRoll1 = rnd.Next(1, 7);

                Random rnd2 = new Random();
                int iDieRoll2 = rnd.Next(1, 7);

                int iRollCombo = iDieRoll1 + iDieRoll2;

                // rollTotals[total]++;
                rollTotals[iRollCombo] = (rollTotals[iRollCombo] + 1);
            }

            // Calculate the percentage of times that the number was rolled
            for (int iCount2 = 2; iCount2 < rollTotals.Length; iCount2++)
            {
                // percentage = how many times the specific number was rolled / total number of rolls * 100
                string asterisks = new string('*', (rollTotals[iCount2]  * 100 / iRolls));

                Console.WriteLine($"{iCount2}: {asterisks}");
            }        
        }
    }
}