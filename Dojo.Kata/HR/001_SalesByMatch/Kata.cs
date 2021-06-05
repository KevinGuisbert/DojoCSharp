using System.Collections.Generic;
using System.Linq;

namespace Dojo.Kata.HR._001_SalesByMatch
{
    public class Kata
    {

        #region Practice



        #endregion

        #region Solution

        /// <summary>
        /// Best Performance Solution.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="ar"></param>
        /// <returns></returns>
        public static int sockMerchantRemoving(int n, List<int> ar)
        {
            int result = 0;
            int valuesRemovedCounter = 0;
            int firstArrayValue;

            while (ar.Count > 0)
            {
                firstArrayValue = ar[0];
                valuesRemovedCounter = ar.RemoveAll(item => item == firstArrayValue);
                if (valuesRemovedCounter % 2 != 0)
                {
                    valuesRemovedCounter--; 
                }
                if (valuesRemovedCounter > 0)
                {
                    result += (valuesRemovedCounter / 2);
                }
            }

            return result;
        }

        public static int sockMerchantAuxiliarArray(int n, List<int> ar)
        {
            int result = 0;
            List<int> PairStack = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (PairStack.Contains(ar[i]))
                {
                    PairStack.Remove(ar[i]);
                    result++;
                }
                else
                {
                    PairStack.Add(ar[i]);
                }
            }

            return result;
        }

        public static int sockMerchant(int n, List<int> ar)
        {
            int result = 0;
            int maxValue = ar.Max() + 1;
            for (int i = 0; i < n; i++)
            {
                if (ar[i] == maxValue)
                    continue;

                for (int j = i + 1; j < n; j++)
                {
                    if (ar[i] == ar[j])
                    {
                        ar[i] = maxValue;
                        ar[j] = maxValue;
                        result++;
                        break;
                    }
                }
            }

            return result;
        }

        #endregion

    }
}
