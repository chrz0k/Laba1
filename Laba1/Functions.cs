namespace Laba1
{
    internal class Functions
    {
        public int GetIntInput()
        {
            while (true)
            {
                string inputString = Console.ReadLine();
                if (int.TryParse(inputString, out int result))
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

        public int SumLastNums(int x) // Для задачи 1.2.
        {
            int result = x % 10 + (x / 10) % 10;
            return result;
        }

        public bool IsPositive(int x) // Для задачи 1.4.
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

        public bool IsUpperCase(char x) // Для задачи 1.6.
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

        public bool IsDivisor(int a, int b) // Для задачи 1.8.
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

        public int LastNumSum(int a, int b) // Для задачи 1.10.
        {
            return a % 10 + b % 10;
        }

        public double SafeDiv(int x, int y) // Для задачи 2.2.
        {
            if (y == 0)
            {
                return 0;
            }
            else
            {
                return (double)x / y;
            }
        }

        public string MakeDecision(int x, int y) // Для задачи 2.4.
        {
            if (x < y)
            {
                return $"{x}<{y}";
            }
            else if (x > y)
            {
                return $"{x}>{y}";
            }
            else
            {
                return $"{x}=={y}";
            }
        }

        public bool Sum3(int x, int y, int z) // Для задачи 2.6.
        {
            if ((x + y) == z || (x + z) == y || (y + z) == x)
            {
                return true;
            }

            return false;
        }

        public string Age(int x) // Для задачи 2.8.
        {
            int lastTwo = x % 100;
            int last = x % 10;

            if (lastTwo >= 11 && lastTwo <= 14)
            {
                return $"{x} лет";
            }
            if (last == 1)
            {
                return $"{x} год";
            }
            if (last >= 2 && last <= 4)
            {
                return $"{x} года";
            }
            return $"{x} лет";
        }

        public void PrintDays(string x) // Для задачи 2.10.
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
                    Console.WriteLine("Это был последний день недели.");
                    break;
                default:
                    Console.WriteLine("Это не день недели.");
                    break;
            }
        }

        public string ReverseListNums(int x) // Для задачи 3.2.
        {
            string result = "";
            for (int i = x; i >= 0; i--)
            {
                result += i;
                if (i != 0)
                {
                    result += " ";
                }
            }
            return result;
        }

        public int Pow(int x, int y) // Для задачи 3.4.
        {
            int result = 1;
            for (int i = 0; i < y; i++)
            {
                result *= x;
            }
            return result;
        }

        public bool EqualNum(int x) // Для задачи 3.6.
        {
            while (x > 0)
            {
                if (x % 10 == x)
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

        public void LeftTriangle(int x) // Для задачи 3.8.
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

        public void GuessGame() // Для задачи 3.10.
        {
            Random random = new Random();
            int randomNum = random.Next(0, 10);
            int countTry = 1;

            Console.Write("Введите число от 0 до 9: ");
            int x = GetIntInput(0, 9);

            while (x != randomNum)
            {
                Console.Write("Вы не угадали, введите число от 0 до 9: ");
                x = GetIntInput();
                countTry++;
            }
            Console.WriteLine("Вы угадали!");
            Console.WriteLine($"Количество попыток: {countTry}");
        }

        public int FindLast(int[] arr, int x) // Для задачи 4.2.
        {
            int findX = arr.Length + 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    findX = i;
                }
            }
            if (findX == arr.Length + 1)
            {
                findX = -1;
            }
            return findX;
        }

        public int[] Add(int[] arr, int x, int pos) // Для задачи 4.4.
        {
            int[] newArr = new int[arr.Length + 1];

            for (int i = 0; i < pos; i++)
            {
                newArr[i] = arr[i];
            }

            newArr[pos] = x;

            for (int i = pos; i < arr.Length; i++)
            {
                newArr[i + 1] = arr[i];
            }

            return newArr;
        }

        public void Reverse(int[] array) // Для задачи 4.6.
        {
            int[] newArray = new int[array.Length];
            int j = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                newArray[j] = array[i];
                j++;
            }

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = newArray[i];
            }
        }

        public int[] Concat(int[] arr1, int[] arr2) // Для задачи 4.8.
        {
            int[] newArr = new int[arr1.Length + arr2.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                newArr[i] = arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                newArr[i + arr1.Length] = arr2[i];
            }

            return newArr;
        }

        public int[] DeleteNegative(int[] arr) // Для задачи 4.10.
        {
            int countNeg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    countNeg++;
                }
            }

            int[] newArr = new int[arr.Length - countNeg];

            countNeg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    newArr[i - countNeg] = arr[i];
                }
                else
                {
                    countNeg++;
                }
            }

            return newArr;
        }
    }
}
