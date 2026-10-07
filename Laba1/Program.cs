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
                Console.WriteLine("19) 4.8.  Объединение");
                Console.WriteLine("20) 4.10. Удалить негатив");

                Console.WriteLine("============================");
                Console.Write("Выберите пункт(0-20): ");
                choice = functions.GetIntInput();
                Console.WriteLine("============================");

                switch (choice)
                {
                    case 1: // Задача 1.2.
                        {
                            Console.Write("Введите число(не менее 10): ");

                            int x = functions.GetIntInput(10, int.MaxValue);
                            x = functions.SumLastNums(x);

                            Console.WriteLine($"Сумма последних двух цифр: {x}");

                            functions.Pause();
                            break;
                        }

                    case 2: // Задача 1.4.
                        {
                            Console.Write("Введите число: ");
                            int x = functions.GetIntInput();
                            bool isPositive = functions.IsPositive(x);
                            Console.WriteLine($"Положительное ли число: {isPositive}");

                            functions.Pause();
                            break;
                        }

                    case 3: // Задача 1.6.
                        {
                            Console.Write("Введите букву(на англ): ");
                            char a = functions.GetCharInput();
                            while (!char.IsLetter(a) || (a >= 'А' && a <= 'я'))
                            {
                                Console.Write("Ошибка! Введите корректную букву: ");
                                a = functions.GetCharInput();
                            }
                            bool isUpper = functions.IsUpperCase(a);
                            Console.WriteLine($"Заглавная ли это буква: {isUpper}");

                            functions.Pause();
                            break;
                        }

                    case 4: // Задача 1.8.
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

                    case 5: // Задача 1.10.
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

                    case 6: // Задача 2.2.
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

                    case 7: // Задача 2.4.
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

                    case 8: // Задача 2.6.
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

                    case 9: // Задача 2.8.
                        {
                            Console.Write("Введите ваш возраст: ");
                            int x = functions.GetIntInput(0, 150);

                            Console.WriteLine($"Вам {functions.Age(x)}");

                            functions.Pause();
                            break;
                        }

                    case 10: // Задача 2.10.
                        {
                            Console.Write("Введите день недели(пример: четверг): ");
                            string day = Console.ReadLine();

                            Console.WriteLine("Результат:");
                            functions.PrintDays(day);

                            functions.Pause();
                            break;
                        }

                    case 11: // Задача 3.2.
                        {
                            Console.Write("Введите число: ");
                            int x = functions.GetIntInput(0, 1000);

                            Console.WriteLine($"Результат: '{functions.ReverseListNums(x)}'");

                            functions.Pause();
                            break;
                        }

                    case 12: // Задача 3.4.
                        {
                            Console.Write("Введите x(от -10 до 10): ");
                            int x = functions.GetIntInput(-10,10);
                            Console.Write("Введите y(от 0 до 9): ");
                            int y = functions.GetIntInput(0, 9);

                            Console.WriteLine($"Результат(x^y): {functions.Pow(x, y)}");

                            functions.Pause();
                            break;
                        }

                    case 13: // Задача 3.6.
                        {
                            Console.Write("Введите число: ");
                            int x = functions.GetIntInput(0, int.MaxValue);

                            Console.WriteLine($"Результат: {functions.EqualNum(x)}");

                            functions.Pause();
                            break;
                        }

                    case 14: // Задача 3.8.
                        {
                            Console.Write("Введите число: ");
                            int x = functions.GetIntInput(1,50);

                            Console.WriteLine("Результат: ");
                            functions.LeftTriangle(x);

                            functions.Pause();
                            break;
                        }

                    case 15: // Задача 3.10.
                        {
                            functions.GuessGame();

                            functions.Pause();
                            break;
                        }

                    case 16: // Задача 4.2.
                        {
                            int[] arr = [1, 2, 3, 4, 2, 2, 5];
                            Console.Write("Дан массив: [");
                            for (int i = 0; i < arr.Length; i++)
                            {
                                if (i == arr.Length - 1)
                                {
                                    Console.Write(arr[i]);
                                }
                                else
                                {
                                    Console.Write(arr[i] + ", ");
                                }                     
                            }
                            Console.WriteLine("]");
                            Console.Write("Введите число, индекс которого нужно найти: ");
                            int x = functions.GetIntInput();

                            Console.WriteLine($"Результат: {functions.FindLast(arr, x)}");

                            functions.Pause();
                            break;
                        }

                    case 17: // Задача 4.4.
                        {
                            int[] arr = [1, 2, 3, 4, 5];
                            Console.Write("Дан массив: [");
                            for (int i = 0; i < arr.Length; i++)
                            {
                                if (i == arr.Length - 1)
                                {
                                    Console.Write(arr[i]);
                                }
                                else
                                {
                                    Console.Write(arr[i] + ", ");
                                }
                            }
                            Console.WriteLine("]");
                            Console.Write("Введите число, которое хотите вставить: ");
                            int x = functions.GetIntInput();
                            Console.Write("Введите на какую позицию: ");
                            int pos = functions.GetIntInput(0, arr.Length);

                            arr = functions.Add(arr, x, pos);

                            Console.Write("Результат: [");
                            for (int i = 0; i < arr.Length; i++)
                            {
                                if (i == arr.Length - 1)
                                {
                                    Console.Write(arr[i]);
                                }
                                else
                                {
                                    Console.Write(arr[i] + ", ");
                                }
                            }
                            Console.WriteLine("]");

                            functions.Pause();
                            break;
                        }

                    case 18: // Задача 4.6.
                        {
                            int[] arr = [1, 2, 3, 4, 5];
                            Console.Write("Дан массив: [");
                            for (int i = 0; i < arr.Length; i++)
                            {
                                if (i == arr.Length - 1)
                                {
                                    Console.Write(arr[i]);
                                }
                                else
                                {
                                    Console.Write(arr[i] + ", ");
                                }
                            }
                            Console.WriteLine("]");

                            functions.Reverse(arr);

                            Console.Write("Результат: [");
                            for (int i = 0; i < arr.Length; i++)
                            {
                                if (i == arr.Length - 1)
                                {
                                    Console.Write(arr[i]);
                                }
                                else
                                {
                                    Console.Write(arr[i] + ", ");
                                }
                            }
                            Console.WriteLine("]");

                            functions.Pause();
                            break;
                        }

                    case 19: // Задача 4.8.
                        {
                            int[] arr1 = [1, 2, 3];
                            int[] arr2 = [7, 8, 9];
                            Console.Write("Дан массив1: [");
                            for (int i = 0; i < arr1.Length; i++)
                            {
                                if (i == arr1.Length - 1)
                                {
                                    Console.Write(arr1[i]);
                                }
                                else
                                {
                                    Console.Write(arr1[i] + ", ");
                                }
                            }
                            Console.WriteLine("]");
                            Console.Write("Дан массив2: [");
                            for (int i = 0; i < arr2.Length; i++)
                            {
                                if (i == arr2.Length - 1)
                                {
                                    Console.Write(arr2[i]);
                                }
                                else
                                {
                                    Console.Write(arr2[i] + ", ");
                                }
                            }
                            Console.WriteLine("]");

                            int[] arr3 = new int[arr1.Length + arr2.Length];
                            arr3 = functions.Concat(arr1, arr2);

                            Console.Write("Результат объединения: [");
                            for (int i = 0; i < arr3.Length; i++)
                            {
                                if (i == arr3.Length - 1)
                                {
                                    Console.Write(arr3[i]);
                                }
                                else
                                {
                                    Console.Write(arr3[i] + ", ");
                                }
                            }
                            Console.WriteLine("]");

                            functions.Pause();
                            break;
                        }

                    case 20: // Задача 4.10.
                        {
                            int[] arr = [1, 2, -3, 4, -2, 2, -5];
                            Console.Write("Дан массив: [");
                            for (int i = 0; i < arr.Length; i++)
                            {
                                if (i == arr.Length - 1)
                                {
                                    Console.Write(arr[i]);
                                }
                                else
                                {
                                    Console.Write(arr[i] + ", ");
                                }
                            }
                            Console.WriteLine("]");

                            arr = functions.DeleteNegative(arr);

                            Console.Write("Результат: [");
                            for (int i = 0; i < arr.Length; i++)
                            {
                                if (i == arr.Length - 1)
                                {
                                    Console.Write(arr[i]);
                                }
                                else
                                {
                                    Console.Write(arr[i] + ", ");
                                }
                            }
                            Console.WriteLine("]");

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