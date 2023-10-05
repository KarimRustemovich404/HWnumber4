using System;

namespace HWnumber4NeLaboratorka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3. Пользователь вводит число и получает его рисунок, состоящий из #\nВведите число:");
            int value = int.Parse(Console.ReadLine());

            switch (value)
            {
                case 0:
                    Console.WriteLine(" ####\n#    #\n#    #\n#    #\n#    #\n#    #\n ####");
                    break;
                case 1:
                    Console.WriteLine("  #\n ##\n# #\n  #\n  #\n  #\n  #");
                    break;
                case 2:
                    Console.WriteLine(" ###\n#   #\n    #\n   #\n  #\n #\n#####");
                    break;
                case 3:
                    Console.WriteLine(" ###\n#   #\n   #\n  #\n   #\n#   #\n ###");
                    break;
                case 4:
                    Console.WriteLine("    #\n   ##\n  # #\n #####\n    #\n    #\n    #");
                    break;
                case 5:
                    Console.WriteLine("#####\n#\n####\n    #\n    #\n    #\n####");
                    break;
                case 6:
                    Console.WriteLine(" ###\n#   #\n#\n####\n#   #\n#   #\n ###");
                    break;
                case 7:
                    Console.WriteLine("#####\n    #\n   #\n ###\n #\n#\n#");
                    break;
                case 8:
                    Console.WriteLine(" ###\n#   #\n#   #\n ###\n#   #\n#   #\n ###");
                    break;
                case 9:
                    Console.WriteLine(" ###\n#   #\n#   #\n ####\n    #\n#   #\n ###");
                    break;

                default:

                    try
                    {
                        if (value < 0)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ошибка! Значение меньше нуля.");
                        }
                        else if (value > 9)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ошибка! Значенеие больше девяти.");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Unexpected value");
                    }
                    break;
            }
            Console.WriteLine("нажмите хоть что-то, пожалуйтса ;(");
            Console.ReadKey();

        }
    }
}



