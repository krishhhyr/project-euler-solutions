using System.ComponentModel;

namespace Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limit = 1000;
            int sum = 0;

            for (int k = 0; k < limit; k++) 
            {
                if ((k % 3 == 0) || (k % 5 == 0)) 
                {
                    sum= sum+k;
                }
            }
            Console.WriteLine(sum);

            //Old Code

            //int multipleof3 = 0;
            //int multipleof5 = 0;

            //for (int k = 0; k < limit; k++) 
            //{
            //    multipleof3 = 3 * k;
            //    multipleof5 = 5 * k;

            //    if (multipleof3 > limit) 
            //    {
            //        multipleof3 = 0;
            //    }

            //    if (multipleof5 > limit)
            //    {
            //        multipleof5 = 0;
            //    }

            //    sum = sum + multipleof3 + multipleof5;
            //}

        }
    }
}