using System;

namespace Laba1
{
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

                Console.WriteLine(" 1) 1.2.  Сумма знаков");
                Console.WriteLine(" 2) 1.4.  Есть ли позитив");
                Console.WriteLine(" 3) 1.6.  Большая буква");
                Console.WriteLine(" 4) 1.8.  Делитель");
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
                choice = functions.GetIntInput();
                Console.WriteLine("============================");

                switch (choice)
                {
                    case 1: // 1.2.
                        {
                            Console.Write("Введите число(не менее 10): ");

                            int x = functions.GetIntInput(10,int.MaxValue);
                            x = functions.SumLastNums(x);

                            Console.WriteLine($"Сумма последних двух цифр: {x}");

                            functions.Pause();
                            break;
                        }

                    case 2: // 1.4.
                        {
                            Console.Write("Введите число: ");
                            int x = functions.GetIntInput();
                            bool isPositive = functions.IsPositive(x);
                            Console.WriteLine($"Положительное ли число: {isPositive}");

                            functions.Pause();
                            break;
                        }

                    case 3: // 1.6.
                        {
                            Console.Write("Введите букву(на англ): ");
                            char a = functions.GetCharInput();

                            bool isUpper = functions.IsUpperCase(a);
                            Console.WriteLine($"Заглавная ли это буква: {isUpper}");

                            functions.Pause();
                            break;
                        }

                    case 4: // 1.8.
                        {
                            Console.Write("Введите первое число: ");
                            int x = functions.GetIntInput();
                            Console.Write("Введите второе число: ");
                            int y = functions.GetIntInput();

                            bool isDivisor = functions.IsDivisor(x, y);
                            Console.WriteLine($"Делятся ли числа нацело друг на друга: {isDivisor}");

                            functions.Pause();
                            break;
                        }

                    case 5: // 1.10.
                        {
                            Console.Write("Введите 1-е число: ");
                            int result = functions.GetIntInput();

                            for (int i = 2; i <= 5; i++)
                            {
                                Console.Write($"Введите {i}-е число: ");
                                result = functions.LastNumSum(result, functions.GetIntInput());
                            }

                            Console.WriteLine($"Результат: {result}");

                            functions.Pause();
                            break;
                        }

                    case 6: // 2.2.
                        {
                            Console.Write("Введите x: ");
                            int x = functions.GetIntInput();
                            Console.Write("Введите y: ");
                            int y = functions.GetIntInput();

                            double result = functions.SafeDiv(x, y);
                            Console.WriteLine($"Результат деления x на y: {result}");

                            functions.Pause();
                            break;
                        }

                    case 7: // 2.4.
                        {
                            Console.Write("Введите x: ");
                            int x = functions.GetIntInput();
                            Console.Write("Введите y: ");
                            int y = functions.GetIntInput();

                            string result = functions.MakeDecision(x, y);
                            Console.WriteLine($"Результат: {result}");

                            functions.Pause();
                            break;
                        }

                    case 8: // 2.6.
                        {
                            Console.Write("Введите x: ");
                            int x = functions.GetIntInput();
                            Console.Write("Введите y: ");
                            int y = functions.GetIntInput();
                            Console.Write("Введите z: ");
                            int z = functions.GetIntInput();

                            bool result = functions.Sum3(x, y, z);
                            Console.WriteLine($"Результат: {result}");

                            functions.Pause();
                            break;
                        }

                    case 9: // 2.8.
                        {
                            Console.Write("Введите ваш возраст: ");
                            int x = functions.GetIntInput(0,int.MaxValue);

                            Console.WriteLine("Вам " + functions.Age(x));

                            functions.Pause();
                            break;
                        }

                    case 10: // 2.10.
                        {
                            Console.Write("Введите день недели(пример: четверг): ");
                            string day = Console.ReadLine();

                            Console.WriteLine("Результат:");
                            functions.PrintDays(day);

                            functions.Pause();
                            break;
                        }

                    case 11: // 3.2.
                        {
                            Console.Write("Введите число: ");
                            int x = functions.GetIntInput();

                            Console.WriteLine("Результат: '" + functions.ReverseListNums(x) + "'");

                            functions.Pause();
                            break;
                        }

                    case 12: // 3.4.
                        {
                            Console.Write("Введите x: ");
                            int x = functions.GetIntInput();
                            Console.Write("Введите y: ");
                            int y = functions.GetIntInput(0,int.MaxValue);

                            Console.WriteLine("Результат(x^y): " + functions.Pow(x,y));

                            functions.Pause();
                            break;
                        }

                    case 13: // 3.6.
                        {
                            Console.Write("Введите число: ");
                            int x = functions.GetIntInput();

                            Console.WriteLine("Результат: " + functions.EqualNum(x));

                            functions.Pause();
                            break;
                        }

                    case 14: // 3.8.
                        {
                            Console.Write("Введите число: ");
                            int x = functions.GetIntInput();

                            Console.WriteLine("Результат: ");
                            functions.LeftTriangle(x);

                            functions.Pause();
                            break;
                        }

                    case 15: // 3.10.
                        {
                            functions.GuessGame();

                            functions.Pause();
                            break;
                        }

                    case 16: // 4.2.
                        {
                            functions.Pause();
                            break;
                        }

                    case 17: // 4.4.
                        {
                            functions.Pause();
                            break;
                        }

                    case 18: // 4.6.
                        {
                            functions.Pause();
                            break;
                        }

                    case 19: // 4.8.
                        {
                            functions.Pause();
                            break;
                        }

                    case 20: // 4.10.
                        {
                            functions.Pause();
                            break;
                        }



                    case 0:
                        Console.WriteLine("Выход из программы.");
                        break;
                    default:
                        Console.WriteLine("Ошибка! Введено неверное значение.");
                        functions.Pause();
                        break;
                }

            }

        }

    }

}