using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Basic.Lesson_4._1
{
    partial class Practice
    {
        //B4-P1/25. If_TimeOfDayGreeting
        public static void B4_P1_25_If_TimeOfDayGreeting()
        {
        }

        //B4-P2/25. If_NumbersComparing
        public static void B4_P2_25_If_NumbersComparing()
        {
        }

        //B4-P3/25. If_PositiveNumbersComparing
        public static void B4_P3_25_If_PositiveNumbersComparing()
        {
        }

        //B4-P4/25. If_Akinator5Numbers
        public static void B4_P4_25_If_Akinator5Numbers()
        {

        }

        //B4-P5/25. Switch_DayOfWeek
        public static void B4_P5_25_Switch_DayOfWeek()
        {
        }

        //B4-P6/25. Switch_GameNavigation
        public static void B4_P6_25_Switch_GameNavigation()
        {

        }

        //B4-P7/25. For_10OddEven
        public static void B4_P7_25_For_10OddEven()
        {

        }


        //B4-P8/25. For_3DevideNumbers
        public static void B4_P8_25_For_3DevideNumbers()
        {
        }


        //B4-P9/25. For_Matrix10x10
        public static void B4_P9_25_For_Matrix10x10()
        {

        }


        //B4-P10/25. For_HelloWorld
        public static void B4_P10_25_For_HelloWorld()
        {
        }


        //B4_P11/25. For_Afrochildren
        public static void B4_P11_25_For_Afrochildren()
        {

        }


        //B4-P12/25. For_Minus10OddEven
        public static void B4_P12_25_For_Minus10OddEven()
        {
        }


        //B4-P13/25 For_LettersCount
        public static void B4_P13_25_For_LettersCount()
        {
            Console.WriteLine("Введите слово");
            string str = Console.ReadLine();
            str = str.ToLower();
            int k = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] == 'а') || (str[i] == 'a'))
                {
                    k++;
                }
            }
            Console.WriteLine($"Количесво букв 'a' равно {k}");
        }


        //B4-P14/25 *For_AlphabetBack
        public static void B4_P14_25_For_AlphabetBack()
        {
            for (int i = 122; i >= 97; i--)
            {
                char t = Convert.ToChar(i);
                Console.Write($"{t} ");
            }
        }


        //B4-P15/25 While_OddEventNumber
        public static void B4_P15_25_While_OddEventNumber()
        {

        }


        //B4-P16/25 DoWhile_OddEventNumber
        public static void B4_P16_25_DoWhile_OddEventNumber()
        {

        }


        //B4-P17/25 While_HelloWorld
        public static void B4_P17_25_While_HelloWorld()
        {
        }


        //B4-P18/25 While_Multiplier
        public static void B4_P18_25_While_Multiplier()
        {
            int sum = 1;
            Console.Write("Введите число ");
            int number = Int32.Parse(Console.ReadLine());
            Console.Write("Введите степень, в которую требуется возвести число ");
            int power = Int32.Parse(Console.ReadLine());
            while (power >= 1)
            {
                power--;
                sum *= number;
            }
            Console.WriteLine($"Ответ - {sum}");
        }


        //B4-P19/25 While_SolveNumberAdding
        public static void B4_P19_25_While_SolveNumberAdding()
        {

        }


        //B4-P20/25 While_DiceGame
        public static void B4_P20_25_While_DiceGame()
        {
            int number = 0;
            int sum = 0;
            int ostatok = 25;
            while (sum <= 25)
            {
                Console.WriteLine("Нажмите Enter чтобы бросить кость");
                while (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Random random = new Random();
                    number = random.Next(7);
                    break;
                }
                sum += number;
                if (ostatok < number)
                {
                    Console.WriteLine($"Кость - {number} ");
                    Console.WriteLine($"Осталось 0 шагов");
                    Console.WriteLine("Finish");
                    break;
                }
                ostatok = 25 - sum;
                Console.WriteLine($"Кость - {number} ");
                Console.WriteLine($"Осталось {25 - sum} шагов");
            }

        }


        //B4-P21/25 *While_DiceGameMultiplePlayers
        public static void dB4_P21_25_While_DiceGameMultiplePlayers()
        {
            int number = 0;
            int number1 = 0;                        
            int sum = 0;
            int sum1 = 0;
            int ostatok = 25;
            int ostatok1 = 25;
            while ((sum <= 25) || (sum1<=25))
            {
                Console.WriteLine("Нажмите Enter чтобы бросить кость");
                while (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Random random = new Random();                 
                    number = random.Next(7);
                    number1 = random.Next(7);
                    break;
                }
                sum += number;
                sum1 += number1;
                if (ostatok < number)
                {
                    Console.WriteLine($"Кость 1 игрока - {number} ");
                    Console.WriteLine($"Кость 2 игрока - {number1} ");
                    Console.WriteLine("Осталось 0 шагов");
                    Console.WriteLine("Finish, победил 1 игрок");
                    break;
                }
                if (ostatok1 < number1)
                {
                    Console.WriteLine($"Кость 1 игрока - {number} ");
                    Console.WriteLine($"Кость 2 игрока - {number1} ");
                    Console.WriteLine("Осталось 0 шагов");
                    Console.WriteLine("Finish, победил 2 игрок");
                    break;
                }
                ostatok = 25 - sum;
                ostatok1 = 25 - sum;
                Console.WriteLine($"Кость 1 игрока- {number} ");
                Console.WriteLine($"Кость 2 игрока- {number1} ");
                Console.WriteLine($"Осталось {25 - sum} шагов для 1 игрока");
                Console.WriteLine($"Осталось {25 - sum1} шагов для 2 игрока");
            }

        }


        //B4-P22_25 *While_Akinator100Numbers
        public static void B4_P22_25_While_Akinator100Numbers()
        {
            Console.WriteLine("Загадайте число от 1 до 100");
            Console.WriteLine("На вопросы отвечайте да или нет");
            int ch = 50;
            int half = 25;
            int numb = 0;
            while (numb != 1)
            {
                Console.WriteLine($"Ваше число {ch}? ");
                if (Console.ReadLine() == "да")
                {
                    Console.WriteLine($"Ваше число - {ch}");
                    numb = 1;
                }
                else
                {
                    Console.WriteLine($"Ваше больше {ch}? ");
                    if (Console.ReadLine() == "да")
                    {
                        if (half == 0)
                        {
                            half++;}
                        ch += half;
                        half /= 2;
                    }                        
                    else 
                    {
                        if (half == 0)
                        {
                            half++;
                        }
                        ch -= half;
                        half /= 2;
                    }
                }
            }

        }


        //B4-P23/25 IfElse_Calcultor
        public static void B4_P23_25_IfElse_Calcultor()
        {

        }


        //B4-P24_25 Switch_Calculator
        public static void B4_P24_25_Switch_Calculator()
        {

        }


        //B4-P25/25 Cycle_WordRevercse
        public static void B4_P25_25_Cycle_WordRevercse()
        {
            Console.WriteLine("Введите слово");
            string word = Console.ReadLine();                    
            for (int i = word.Length-1; i>=0; i--)
            {
                Console.Write(word[i]);
            }            
        }
    }
}
