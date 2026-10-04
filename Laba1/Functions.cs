using System.Xml.XPath;

namespace Laba1
{
    internal class Functions
    {
        public int GetIntInput()
        {
            while(true)
            {
                string inputString = Console.ReadLine();
                if(int.TryParse(inputString, out int result))
                {
                    return result;
                }

                Console.Write("Ошибка! Введите корректное целое число: ");
            }
        }

        public int GetIntInput(int x, int y)
        {
            while (true)
            {
                string inputString = Console.ReadLine();
                if (int.TryParse(inputString, out int result))
                {
                    if (result >= x && result <= y)
                    {
                        return result;
                    }
                }

                Console.Write("Ошибка! Введите корректное целое число: ");
            }
        }

        public char GetCharInput()
        {
            while (true)
            {
                string inputString = Console.ReadLine();
                if (char.TryParse(inputString, out char result))
                {
                    return result;
                }

                Console.Write("Ошибка! Введите одну букву: ");
            }
        }

        public void Pause()
        {
            Console.WriteLine("============================");
            Console.Write("Нажмите любую кнопку для продолжения...");
            Console.ReadKey();
        }

        public int SumLastNums(int x) // 1.2.
        {
            int result = x % 10 + (x / 10) % 10;
            return result;
        }

        public bool IsPositive(int x) // 1.4.
        {
            if (x > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsUpperCase(char x) // 1.6.
        {
            if (x >= 'A' && x <= 'Z')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsDivisor(int a, int b) // 1.8.
        {
            if (a == 0 || b == 0)
            {
                return false;
            }
            if ((a % b) == 0 || (b % a) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int LastNumSum(int a, int b) // 1.10.
        {
            return a % 10 + b % 10;
        }

        public double SafeDiv(int x,int y) // 2.2.
        {
            if (y == 0)
            {
                return 0;
            }
            else
            {
                return x / y;
            }
        }

        public string MakeDecision(int x,int y) // 2.4.
        {
            if(x < y)
            {
                return $"{x}<{y}";
            }
            else if(x > y)
            {
                return $"{x}>{y}";
            }
            else
            {
                return $"{x}=={y}";
            }
        }

        public bool Sum3(int x, int y, int z) // 2.6.
        {
            if ((x + y) == z || (x + z) == y || (y + z) == x) 
            {
                return true;
            }

            return false;
        }

        public string Age(int x) // 2.8.
        {
            if (x % 10 == 1 && x != 11)
            {
                return $"{x} год";
            }
            else if ((x % 10 == 2 || x % 10 == 3 || x % 10 == 4) && x != 12 && x != 13 && x != 14)
            {
                return $"{x} года";
            }
            else
            {
                return $"{x} лет";
            }
        }

        public void PrintDays(string x) // 2.10.
        {
            string[] days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
            switch (x)
            {
                case "понедельник":
                    for (int i = Array.IndexOf(days, "понедельник") + 1; i <= 6; i++) 
                    {
                        Console.WriteLine(days[i]);
                    }
                    break;
                case "вторник":
                    for (int i = Array.IndexOf(days, "вторник") + 1; i <= 6; i++)
                    {
                        Console.WriteLine(days[i]);
                    }
                    break;
                case "среда":
                    for (int i = Array.IndexOf(days, "среда") + 1; i <= 6; i++)
                    {
                        Console.WriteLine(days[i]);
                    }
                    break;
                case "четверг":
                    for (int i = Array.IndexOf(days, "четверг") + 1; i <= 6; i++)
                    {
                        Console.WriteLine(days[i]);
                    }
                    break;
                case "пятница":
                    for (int i = Array.IndexOf(days, "пятница") + 1; i <= 6; i++)
                    {
                        Console.WriteLine(days[i]);
                    }
                    break;
                case "суббота":
                    for (int i = Array.IndexOf(days, "суббота") + 1; i <= 6; i++)
                    {
                        Console.WriteLine(days[i]);
                    }
                    break;
                case "воскресенье":
                    Console.WriteLine("Это был послединй день недели.");
                    break;
                default:
                    Console.WriteLine("Это не день недели.");
                    break;
            }
        }

        public string ReverseListNums(int x) // 3.2.
        {
            string result = "";
            for (int i = x; i >= 0; i--)
            {
                result += i;
                if (i != 0)
                {
                    result = result + " ";
                }
            }
            return result;
        }

        public int Pow(int x, int y) // 3.4.
        {
            int result = 1;
            for (int i = 0; i < y; i++)
            {
                result *= x;
            }
            return result;
        }

        public bool EqualNum(int x) // 3.6.
        {
            while (x > 0)
            {
                if(x % 10 == x)
                {
                    break;
                }
                if (x % 10 != (x / 10) % 10)
                {
                    return false;
                }
                x /= 10;
            }
            return true;
        }

        public void LeftTriangle(int x) // 3.8.
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void GuessGame()
        {
            Functions functions = new Functions();
            Random random = new Random();
            int randomNum = random.Next(0, 10);
            int countTry = 1;

            Console.Write("Введите число от 0 до 9: ");
            int x = functions.GetIntInput();

            while (x != randomNum)
            {
                Console.Write("Вы не угадали, введите число от 0 до 9: ");
                x = functions.GetIntInput();
                countTry += 1;
            }  
            Console.WriteLine("Вы угадали!");
            Console.WriteLine($"Вы отгадали за {countTry} попытки.");
        }








    }
}
