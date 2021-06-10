using System;
using System.Collections.Generic;
using System.Text;

namespace Dojo.Kata.HR._003_JumpingOnTheClouds
{
    public class Kata
    {

        public static int jumpingOnClouds(List<int> c)
        {
            int jumps = 0;

            for (int i = 0; i < c.Count - 1; i++)
            {
                if (i + 2 <= c.Count - 1 && c[i + 2] != 1)
                {
                    i++;
                }
                jumps++;
            }

            return jumps;
        }


    }
}