using System;

namespace SchleifenHochschuleWorms4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int input1 = FetchNumbers();
            int input2 = FetchNumbers();

            int randVal = GetRandomNumber(input1, input2);

            DrawPyramide(randVal);

            Console.WriteLine("whos the k1ng?");
            Console.WriteLine("Yes Bombsn is!!!!11");
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
            Console.WriteLine("Geben Sie eine Zahl zwischen 0 und 16 ein:");
            string userInput = Console.ReadLine();

            int.TryParse(userInput, out int result);

            if (result < 1 || result > 15)
            {
                Console.WriteLine("ich sagte nicht grösser als 15 und nicht kleiner als 1, spast lololo11!!!!");
                FetchNumbers();
            }

            return result;
        }





        static int GetRandomNumber(int val1, int val2)
        {
            var rand = new Random();
            int tempVal;

            if (val1 <= val2)
            {
                tempVal = rand.Next(val1, val2);
            }
            else
            {
                tempVal = rand.Next(val2, val1);
            }

            if (tempVal % 2 == 0)
                return tempVal + 1;
            else
                return tempVal;
        }
    }
}
