using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class Luhn
    {
        public static void CheckNo(string cardNumber)
        {
            string result = "";
            int result2 = 0;
            int dummyVar = 0;

            char[] charArr = cardNumber.ToCharArray();
            Array.Reverse(charArr);
            int[] cardNo = new int[charArr.Length];

            for (int i = 0; i < cardNo.Length; i++)
            {
                cardNo[i] = Convert.ToInt32(charArr[i].ToString());
                result += cardNo[i];
            }
            Console.WriteLine("After flip and convert to number: " + result);

            for (int i = 0; i < charArr.Length; i++)
            {
                if (i % 2 != 0)
                {
                    if (cardNo[i] > 4)
                    {
                        int dummyVar4 = 0;
                        string dummyVar2 = "";
                        dummyVar = cardNo[i] * 2;

                        dummyVar2 = dummyVar.ToString();
                        char[] dummyVar3 = dummyVar2.ToCharArray();
                        dummyVar4 = Convert.ToInt32(dummyVar3[0].ToString()) + Convert.ToInt32(dummyVar3[1].ToString());

                        result2 += dummyVar4;
                        //Console.WriteLine("Odd, After *2: " + i);
                    }
                    else
                    {
                        result2 += cardNo[i] * 2;
                        //Console.WriteLine("Even, After * 2: " + i);
                    }
                }
                else
                {
                    result2 += cardNo[i];
                }
            }
            //Console.WriteLine(result + "\n");
            //Console.WriteLine(result2 + "\n");
        }
    }
}
