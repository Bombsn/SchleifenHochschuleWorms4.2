using System;

namespace SchleifenHochschuleWorms4._2
{
    class Program
    {
        public static readonly int MaxVal = 49;

        static void Main(string[] args)
        {
            DrawPyramide(GetRandomNumber(FetchNumbers(), FetchNumbers()));

            Console.WriteLine("whos the k1ng?");
            Console.WriteLine("Yes Bombsn is!!!!11");
            Console.ReadKey();
        }


        static void DrawPyramide(int rows)
        {
            int stars = 1;

            for (int i = 0; i < rows; i++)
            {
                int spaces = rows - 1 - i;
                Console.Write(new string(' ', spaces));

                Console.WriteLine(new string('*', stars));
                stars += 2;
            }
        }


        static int FetchNumbers()
        {
            int result;
            do
            {
                Console.WriteLine($"Geben Sie eine Zahl zwischen 0 und {MaxVal + 1} ein:");
                string userInput = Console.ReadLine();

                int.TryParse(userInput, out result);

                if (result < 1 || result > MaxVal)
                    Console.WriteLine($"ich sagte nicht grösser als {MaxVal} und nicht kleiner als 1, spast lololo11!!!!");
                
            } while (result < 1 || result > MaxVal);

            return result;
        }


        static int GetRandomNumber(int val1, int val2)
        {
            var rand = new Random();
            int tempVal;

            if (val1 <= val2)
                tempVal = rand.Next(val1, val2);
            else
                tempVal = rand.Next(val2, val1);

            if (tempVal % 2 == 0)
                return tempVal + 1;
            else
                return tempVal;
        }
    }
}
