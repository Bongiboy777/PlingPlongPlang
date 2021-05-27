using System;

namespace Plingplangplong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class RainDrops
    {
        public string PlingPlangPlongConvert(int number)
        {
            string ans = "";
            if(number % 3 == 0)
            {
                ans += "Pling";
            }

            if (number % 5 == 0)
            {
                ans += "Plang";
            }

            if (number % 7 == 0)
            {
                ans += "Plong";
            }
                try
                {
                return ans != "" ? ans: number.ToString() ;
                }

                catch(Exception e)
                {
                    return "Not a valid input.";
                }

            
        }
    }
}
