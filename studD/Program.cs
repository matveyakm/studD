using System;

namespace studD
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringNum;
            string firstpartOne = "12";
            int firstPartTwo = 2;
            double secondpart;
            while (firstPartTwo <= 398)
            {
                firstPartTwo++;
                char[] needThree = firstPartTwo.ToString().ToCharArray();
                if (needThree[0].ToString().Equals("3"))
                {
                    secondpart = 5670;
                    while (secondpart <= 5679)
                    {
                        stringNum = firstpartOne + firstPartTwo.ToString() + secondpart.ToString();
                        if (Convert.ToDouble(stringNum) % 169 == 0)
                        {
                            Console.WriteLine(stringNum + "   " + (Convert.ToDouble(stringNum) / 169));
                        }
                        secondpart++;
                    }
                }
            }

        }
    }
}