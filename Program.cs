using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сыграем в игру? :)");
            Console.WriteLine("Да, Нет, Не знаю");

            string answer = Console.ReadLine();
            switch (answer)
            {
                case "Да":
                    // код для тех кто ответил да
                    Console.WriteLine("Ладно. Почеши нос и погладь живот :D");
                    Console.WriteLine("Ответ: Сделал, Нет");

                    string answer1 = Console.ReadLine();
                    switch (answer1)
                    {
                        case "Сделал":
                            Console.WriteLine("Молодец. Улыбайся :)");
                            break;

                    }
                    break;


                case "Нет":
                    // код для тех кто ответил нет
                    Console.WriteLine("А может быть все-таки да?");
                    Console.WriteLine("Ответ: Ладно, давай");

                    string answer2 = Console.ReadLine();
                    switch (answer2)
                    {
                        case "Ладно, давай":
                            Console.WriteLine("Почеши нос и погладь живот :D");
                            Console.WriteLine("Ответ: Сделал, Нет");

                            string answer3 = Console.ReadLine();
                            switch (answer3)
                            {
                                case "Сделал":
                                    Console.WriteLine("Молодец. Улыбайся :)");
                                    break;
                            }
                            break;

                        case "Не знаю":
                            // код для тех кто ответил не знаю
                            Console.WriteLine("Решайся");
                            Console.WriteLine("Давай играть со мной");
                            Console.WriteLine("Ответ: Давай играть, так уж и быть");

                            string answer4 = Console.ReadLine();
                            switch (answer4)
                            {
                                case "Давай играть, так уж и быть":
                                    Console.WriteLine("Почеши нос и погладь живот :D");
                                    Console.WriteLine("Ответ: Сделал, Нет");

                                    string answer5 = Console.ReadLine();
                                    switch (answer5)
                                    {
                                        case "Сделал":
                                            Console.WriteLine("Молодец. Улыбайся :)");
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }
    }
}




