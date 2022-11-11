// // Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// string ResultNumbers(int n)
// {
//     if (n == 1)
//         return "1";
//     return ResultNumbers(n - 1) + ", " + Convert.ToString(n);
// }


// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(ResultNumbers(n));

// // 63
// void ResultNumbers(int n, int j)
// {
//     if (n == j)
//         Console.Write($" {n} ");
//     else
//     {
//         Console.Write($" {j} ");
//         ResultNumbers(n, ++j);
//     }
// }


// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine()), j = 1;
// ResultNumbers(n, j);

// // Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Console.WriteLine("Введите число M");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N");
// int n = Convert.ToInt32(Console.ReadLine());

// if (m > n)
// {
//     Console.WriteLine("Число M не может быть больше N");
// }
// else
// {
//     PrintNumbers(n, m);
// }

// void PrintNumbers(int n, int m)
// {
//     if (n < m) return;
//     PrintNumbers(n - 1, m);
//     Console.Write(n + " ");
// }

// // 65 task


// string ResultNumbers(int m, int n)
// {
//     if (n == m)
//         return $"{m}";
//     return ResultNumbers(m, n - 1) + ", " + Convert.ToString(n);
// }


// Console.Clear();
// Console.Write("Введите число 1-ое: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 2-ое: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(ResultNumbers(m, n));


// // Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// Console.WriteLine("Введите число N");
// int n = Convert.ToInt32(Console.ReadLine());

// int sum = PrintNumbers(n);
// Console.WriteLine(sum);
// int PrintNumbers(int n)
// {
  
//     if (n <= 0) return 0;
  
//     return n % 10 + PrintNumbers(n / 10);

// }

// // 67 task

// int ResultNumbers(int n)
// {
//     if (n / 10 == 0)
//         return n;
//     return ResultNumbers(n / 10) + n % 10;
// }


// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(ResultNumbers(n));


// // Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// int ResultNumbers(int a, int b)
// {
//     if (b == 0)
//         return 1;
//     return ResultNumbers(a, b - 1) * a;
// }


// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(ResultNumbers(a, b));
