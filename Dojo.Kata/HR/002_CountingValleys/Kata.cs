using System;
using System.Collections.Generic;
using System.Text;

namespace Dojo.Kata.HR._002_CountingValleys
{
    public class Kata
    {

        public static int countingValleys(int steps, string path)
        {
            int valleys = 0;
            int currentLevel = 0;

            for (int i = 0; i < steps; i++)
            {
                if (path[i].ToString() == "U")
                {
                    currentLevel++;
                }
                else
                {
                    currentLevel--;
                }
                if (path[i].ToString() == "U" && currentLevel == 0)
                {
                    valleys++;
                }
            }

            return valleys;
        }

    }
}
