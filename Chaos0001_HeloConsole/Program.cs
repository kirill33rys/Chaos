// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите первое число");
// string input = Console.ReadLine();
// int namber1 = Convert.ToInt32(input);
// Console.WriteLine("Введите второе число");
// input = Console.ReadLine();
// int namber2 = Convert.ToInt32(input);
// if (namber1 > namber2)
// Console.WriteLine($"Большее число = {namber1}   меньшее число = {namber2}");
// else Console.WriteLine($"Большее число = {namber2} меньшее число = {namber1}");




// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Введите первое число");
// string input = Console.ReadLine();
// int namber1 = Convert.ToInt32(input);
// Console.WriteLine("Введите второе число");
// input = Console.ReadLine();
// int namber2 = Convert.ToInt32(input);
// Console.WriteLine("Введите третье число");
// input = Console.ReadLine();
// int namber3 = Convert.ToInt32(input);
// int max = namber1;
// if (max < namber2) max = namber2;
// if (max < namber3) max = namber3;
// Console.WriteLine($"Максимальное число = {max}");


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет



// Console.WriteLine("Введите число");
// string input = Console.ReadLine();
// int n = Convert.ToInt32(input);
// if (n % 2 == 0)
// Console.WriteLine($"Число {n} четное");
// else Console.WriteLine($"Число {n} нечетное");

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// // Console.WriteLine("Введите число ");
// // string input = Console.ReadLine();
// // int n = Convert.ToInt32(input);
// // for(int i=1;i<=n;i++)
// // {
// // if (i % 2 == 0)
// // System.Console.Write($"{i}," );
// }


// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int Prompt(string msg)
// {

// Console.WriteLine($"{msg}");
// return Convert.ToInt32(Console.ReadLine());
// }
// int number = Prompt("Введите трехзначное число");
// if (number >=100 && number <1000)
// {
// int mid = (number % 100 - number % 10) /  10;
// Console.WriteLine($"Вторая цифра числа {number} является {mid}");
// }
// else
// Console.WriteLine("Это число не трехзначное");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// int Prompt(string msg)
// {

// Console.WriteLine($"{msg}");
// return Convert.ToInt32(Console.ReadLine());
// }
// int number = Prompt("Введите число");

// int fnumber(int number)
// {
// while (number > 999)
// {
// number /= 10;
// }
// return number % 10;
// }

// bool check(int number)
// {
// if (number < 100)
// return false;
// else return true;
// }

// if (check(number) != true)
// Console.WriteLine($"Третьей цифры нет");
// else
// Console.WriteLine($"Третья цифра числа {number} является {fnumber(number)}");

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// int Prompt(string msg)
// {

// Console.WriteLine($"{msg}");
// return Convert.ToInt32(Console.ReadLine());
// }
// int number = Prompt("Введите число дня недели");
// string ss = "Это не день недели";
// string check(int number)
// {
// if (number >= 6 && number < 8) ss = "Это выходной";
// if (number >= 1 && number < 7) ss = "Это будний день";
// return ss;
// }
// Console.WriteLine(check(number));


// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// int num,r,sum=0,a;
// Console.Write("Введите пятизначное число:");
// num = Convert.ToInt32(Console.ReadLine());
// if(num>9999 && num<100000)
// {
// for(a=num;num!=0;num=num/10)
// {
// r=num % 10;
// sum=sum*10+r;
// }
// if(a==sum)
// Console.Write($"{a} является палиндромом.");
// else
// Console.Write($"{a} не является палиндромом.");
// } else
// Console.Write("Введите пятизначное число! ");


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// int InputN(string message)
// {
// System.Console.Write($"{message}> ");
// int value;
// if (int.TryParse(Console.ReadLine(), out value))
// {
// return value;
// }
// System.Console.WriteLine("Вы ввели не число");
// Environment.Exit(1);
// return 0;

// }

// int x1 = InputN ("Введите координату X точки A");
// int y1 = InputN ("Введите координату Y точки A");
// int z1 = InputN ("Введите координату Z точки A");
// int x2 = InputN ("Введите координату X точки B");
// int y2 = InputN ("Введите координату Y точки B");
// int z2 = InputN ("Введите координату Z точки B");

// double dis(int x1, int y1, int z1, int x2, int y2, int z2)
// {
// int deltax = x2 - x1;
// int deltay = y2 - y1;
// int deltaz = z2 - z1;
// return Math.Sqrt(deltax*deltax+deltay*deltay+deltaz*deltaz);
// }
// System.Console.Write($"Растояние между точками A и B равно {dis(x1, y1, z1, x2, y2, z2):F2}");


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Таблица кубов:\n");
// for (int i=1;i<=n;i++)
// {
// int x = i*i*i;
// Console.Write($"{x}, ");
// }


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// Console.Write("Введите количество элементов массива: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int[] randomArray = new int[a];

// void mas(int a)
// {
// for (int i = 0; i < a; i++)
// {
// randomArray[i] = new Random().Next(99,999);
// Console.Write(randomArray[i] + "");
// }

// }

// int kol(int[] randomArray)
// {
// int kol = 0;
// for (int i = 0; i < randomArray.Length; i++)
// {
// if (randomArray[i] % 2 == 0)
// kol = kol + 1;
// }
// return kol;
// }

// mas(a);
// Console.Write($"\nКоличество чётных чисел в массиве: {kol(randomArray)}");




// // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// // [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6] -> 0


// // using static System.Console;
// // Clear();
// // Write("Введите размер массива: ");
// // int length=int.Parse(ReadLine()!);
// // Write("Введите минимальное значение массива: ");
// // int min=int.Parse(ReadLine()!);
// // Write("Введите максимальное значение массива: ");
// // int max=int.Parse(ReadLine()!);
// // int[] Array= GetArray(length, min, max);WriteLine($"[{string.Join(", ", Array)}]");
// //  FindEven(Array);
// //  int[] GetArray(int size, int minValue, int maxValue)
// //  {
// //     Randomrnd= newRandom();// переменная генератор случайных чисел int[] 
// //     result= newint[size];
// //     for(int i= 0; i< result.Length; i++)
// //     {
// //       result[i] = rnd.Next(minValue, maxValue+ 1);
// //     }
// //     return result;
// // }

// // voidFindEven(int [,]  MyArray);
// // {
// //     inteven=0;
// //     for(inti= 0;i< MyArray.Length; i++)
// //      {
// //         if(MyArray[i]%2==0)
// //         {
// //             even=even+1;
// //             }
// //     }
// //             WriteLine($"Чётных чисел {even}");
// }


// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// Console.Write("Введите размерность m массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размерность n массива:");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] randomArray = new double[m,n];

// void mas(int m, int n)
// {
// int i,j;
// Random rand = new Random();
// for (i = 0; i < m; i++)
// {
// Console.WriteLine();
// for (j = 0; j < n; j++)
// {
// randomArray[i,j] = rand.NextDouble();
// Console.Write($"{randomArray[i,j]:F2}");
// }

// }

// }

// mas(m,n);




// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет



// Console.Write("Введите размерность m массива:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размерность n массива:");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] randomArray = new double[m,n];
// Console.Write("Введите позицию строки:");
// int m2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите позицию столбца:");
// int n2 = Convert.ToInt32(Console.ReadLine());
// void mas(int m, int n)
// {
// int i,j;
// Random rand = new Random();
// for (i = 0; i < m; i++)
// {
// Console.WriteLine();
// for (j = 0; j < n; j++)
// {
// randomArray[i,j] = rand.NextDouble();
// Console.Write($"{randomArray[i,j]:F2}");
// }
// Console.WriteLine();
// }
// }
// mas(m,n);
// if (m2<1 || n2<1)
// Console.Write("Позиции строк не могут быть отрицательными");
// else if (m2 <= m+1 && n2 <= n+1)
// Console.Write($"Значение элемента равно {randomArray[m2-1,n2-1]:F2}");
// else Console.Write("Такого элемента нет в массиве");



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4


// Console.Write("Введите размерность m массива:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размерность n массива:");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] randomArray = new int[m,n];

// void mas(int m, int n)
// {
// int i,j;
// Random rand = new Random();
// for (i = 0; i < m; i++)
// {
// Console.WriteLine();
// for (j = 0; j < n; j++)
// {
// randomArray[i,j] = rand.Next(1,9);
// Console.Write($"{randomArray[i,j]}");
// }
// Console.WriteLine();
// }
// }

// void arif(int m, int n)
// {
// Console.Write("Среднее арифметическое каждого столбца:");
// int i,j;
// Random rand = new Random();
// for (j = 0; j < n; j++)
// {
// double sum = 0;
// for (i = 0; i < m; i++)
// {
// sum = sum + randomArray[i,j];
// }
// Console.Write($"{sum/(i):F1};");
// }
// }
// mas(m,n);
// arif(m,n);








