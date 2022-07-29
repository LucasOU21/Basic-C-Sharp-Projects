using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the year from 2000 to 2022 with a twist.");
            int year = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 2002;

            do
            {
                switch (number)
                {
                    case 2005:
                        Console.WriteLine("You guessed 2005. It's a little warm.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2020:
                        Console.WriteLine("You guessed 2020. Antarctica Cold.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2008:
                        Console.WriteLine("You guessed 2008. Warmish.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2002:
                        Console.WriteLine("You guessed 2002. That is correct!... The year i was born -YourDev");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You guessed the year " + year + ". Try again");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);



            Console.Read();
        }
    }
}
