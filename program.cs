using System;

namespace GuessNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в игру 'Угадай число'!");
            Console.WriteLine("Я загадал число от 1 до 100. Попробуй угадать!");

            Random random = new Random();
            int secretNumber = random.Next(1, 101);

            int attempts = 0; 
            bool guessed = false; 

           
            while (!guessed)
            {
                Console.Write("Введите ваше предположение: ");
                string input = Console.ReadLine(); 

                if (int.TryParse(input, out int guess))
                {
                    attempts++; 

                 
                    if (guess == secretNumber)
                    {
                        guessed = true; 
                        Console.WriteLine($"Поздравляем! Вы угадали число {secretNumber} за {attempts} попыток!");
                    }
                    else if (guess < secretNumber)
                    {
                        Console.WriteLine("Неверно. Загаданное число больше.");
                    }
                    else
                    {
                        Console.WriteLine("Неверно. Загаданное число меньше.");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка. Введите корректное целое число.");
                }
            }
        }
    }
}
