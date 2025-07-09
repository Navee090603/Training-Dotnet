using System;


namespace Day6
{
    class GradeSystem
    {
        public  static string GradeCalculator(int scores)
        {
            if (scores >= 0)
            {
                if (scores >= 90)
                {
                    return "A";
                }
                else if(scores<=89 && scores >= 70)
                {
                    return "B";
                }
                else
                {
                    return "C";
                }
            }

            else
            {
                throw new Custom_Exception("Score are Negative !");
            }
        }

        public static void Main()
        {
            try
            {
                GradeCalculator(-3);
            }
            catch(Custom_Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }
}
