using System;

namespace Plingplangplong
{
    public static class RainDrops
    {
        public static string PlingPlangPlongConvert(int number)
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

                return ans != "" ? ans: number.ToString() ;
        }
    }
}
