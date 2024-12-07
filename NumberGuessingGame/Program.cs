using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("I'm thinking of a number between 1 and 100.");
            Console.WriteLine("You have 5 chances to guess the correct number.");
            Console.WriteLine();
            Console.WriteLine("Please select the difficulty level:");
            Console.WriteLine("1. Easy (10 chances)");
            Console.WriteLine("2. Medium (5 chances)");
            Console.WriteLine("3. Hard (3 chances)");

            //in ra màn hình yêu cầu chọn mức độ chơi 
            Console.WriteLine("Please select the difficulty level:");

            // xác định số lần chơi
            int chances = 0;

            int difficultyLevel = int.Parse(Console.ReadLine());

            switch (difficultyLevel)
            {
                case 1:
                    chances = 10;
                    break;
                case 2:
                    chances = 5;
                    break;
                case 3:
                    chances = 3;
                    break;
                default:
                    Console.WriteLine("Invalid difficulty level. Please try again.");
                    break;
            }
            // tạo số ngẫu nhiên từ 1 đến 100
            Random random = new Random();
            int correctNumber = random.Next(1, 101);

            while (chances > 0)
            {
                Console.WriteLine("You have " + chances + " chances left.");
                Console.WriteLine("Please enter your guess:");
                int guess = int.Parse(Console.ReadLine());

                if (guess == correctNumber)
                {
                    Console.WriteLine("Congratulations! You guessed the correct number.");
                    break;
                }
                else if (guess < correctNumber)
                {
                    Console.WriteLine("The correct number is greater than your guess.");
                }
                else
                {
                    Console.WriteLine("The correct number is less than your guess.");
                }

                chances--;
            }

            if (chances == 0)
            {
                Console.WriteLine("You have run out of chances. The correct number was: " + correctNumber);
            }
            //dừng màn hình xem kết quả 
            Console.ReadLine();
        }
    }
}
