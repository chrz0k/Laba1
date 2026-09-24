internal class Program
{
    static void Main(string[] args)
    {
        Functions functions = new Functions();
        int choice = 1;
        while (choice != 0)
        {
            Console.Clear();
            Console.WriteLine("=== Лабораторная работа №1 ===");
            Console.WriteLine(" 0) Выход из программы");

            Console.WriteLine(" 1) 1.2.  Сумма знаков (сложение двух последних знаков)");
            Console.WriteLine(" 2) 1.4.  Есть ли позитив (положительное ли число)");
            Console.WriteLine(" 3) 1.6.  Большая буква (true если буква заглавная)");
            Console.WriteLine(" 4) 1.8.  Делитель (true если нацело делятся числа)");
            Console.WriteLine(" 5) 1.10. Многократный вызов");

            Console.WriteLine(" 6) 2.2.  Безопасное деление");
            Console.WriteLine(" 7) 2.4.  Строка сравнения");
            Console.WriteLine(" 8) 2.6.  Тройная сумма");
            Console.WriteLine(" 9) 2.8.  Возраст");
            Console.WriteLine("10) 2.10. Вывод дней недели");

            Console.WriteLine("11) 3.2.  Числа наоборот");
            Console.WriteLine("12) 3.4.  Степень числа");
            Console.WriteLine("13) 3.6.  Одинаковость");
            Console.WriteLine("14) 3.8.  Левый треугольник");
            Console.WriteLine("15) 3.10. Угадайка");

            Console.WriteLine("16) 4.2.  Поиск последнего значения");
            Console.WriteLine("17) 4.4.  Добавление в массив");
            Console.WriteLine("18) 4.6.  Реверс");
            Console.WriteLine("19) 4.8.  Обьединение");
            Console.WriteLine("20) 4.10. Удалить негатив");

            Console.WriteLine("============================");
            Console.Write("Выберите пункт(0-20): ");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine("============================");

            switch(choice)
            {
                case 1: // 1.2.
                    {
                        Console.Write("Введите число(не менее 10): ");
                        int x = int.Parse(Console.ReadLine());
                        if (x < 10)
                        {
                            Console.WriteLine("Ошибка! Введено число менее 10.");
                        }
                        else
                        {
                            x = functions.SumLastNums(x);
                            Console.WriteLine($"Результат: {x}");
                        }

                        functions.Pause();
                        break;
                    }

                case 2: // 1.4.
                    {
                        Console.Write("Введите число: ");
                        int x = int.Parse(Console.ReadLine());
                        bool isPositive = functions.IsPositive(x);
                        Console.WriteLine($"Результат: {isPositive}");

                        functions.Pause();
                        break;
                    }
                
                case 3: // 1.6.
                    {
                        Console.Write("Введите букву(на англ): ");
                        char a = char.Parse(Console.ReadLine());

                        bool isUpper = functions.IsUpperCase(a);
                        Console.WriteLine($"Результат: {isUpper}");

                        functions.Pause();
                        break;
                    }
                
                case 4: // 1.8.
                    {
                        Console.Write("Введите первое число: ");
                        int x = int.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        int y = int.Parse(Console.ReadLine());

                        bool isDivisor = functions.IsDivisor(x, y);
                        Console.WriteLine($"Результат: {isDivisor}");

                        functions.Pause();
                        break;
                    }
                
                case 5: // 1.10.
                    {
                        Console.Write("Введите 1-е число: ");
                        int result = int.Parse(Console.ReadLine());

                        for (int i = 2; i <= 5; i++)
                        {
                            Console.Write($"Введите {i}-е число: ");
                            result = functions.LastNumSum(result, int.Parse(Console.ReadLine()));
                        }

                        Console.WriteLine($"Результат: {result}");

                        functions.Pause();
                        break;
                    }
                
                case 6:
                    {
                        functions.Pause();
                        break;
                    }
                
                case 7:
                    {
                        functions.Pause();
                        break;
                    }
                
                case 8:
                    {
                        functions.Pause();
                        break;
                    }
                
                case 9:
                    {
                        functions.Pause();
                        break;
                    }
                
                case 10:
                    {
                        functions.Pause();
                        break;
                    }
                
                case 11:
                    {
                        functions.Pause();
                        break;
                    }
                
                case 12:
                    {
                        functions.Pause();
                        break;
                    }
                
                case 13:
                    {
                        functions.Pause();
                        break;
                    }
                
                case 14:
                    {
                        functions.Pause();
                        break;
                    }
                
                case 15:
                    {
                        functions.Pause();
                        break;
                    }
                
                case 16:
                    {
                        functions.Pause();
                        break;
                    }
                
                case 17:
                    {
                        functions.Pause();
                        break;
                    }
                
                case 18:
                    {
                        functions.Pause();
                        break;
                    }
                
                case 19:
                    {
                        functions.Pause();
                        break;
                    }
                
                case 20:
                    {
                        functions.Pause();
                        break;
                    }



                case 0: Console.WriteLine("Выход из программы.."); break;
                default: Console.WriteLine("Ошибка! Ты ввел неверное значение."); break;
            }
        }

    }
}

public class Functions
{
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
        if(x >= 'A' && x <= 'Z')
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
        if ((a % b) == 0 || (b % a) == 0 )
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