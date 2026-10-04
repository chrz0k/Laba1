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
    }
}
