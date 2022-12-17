// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
// Console.Write("Введите первое число: ");
// int num1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число: ");
// int num2 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите третье число: ");
// int num3 = int.Parse(Console.ReadLine()!);

// GetTriangle(num1, num2, num3);

// void GetTriangle(int a, int b, int c)
// {

//     if (a + b > c && a + c > b && b + c > a)
//     {
//         Console.WriteLine("yes");

//     }
//     else
//     {
//         Console.WriteLine("no");
//     }
// }
// Console.Write("Введите число:");
// int num = int.Parse(Console.ReadLine()!);

// string Answer(int n)
// {
// int res = 0;
// string answ = "";
// while (num > 0)
//     {
//         res = num % 2;
//         num = num / 2;
//         answ = res + answ;


//     }
//     return answ;
// }
// Console.Write(Answer(num));

// Console.Write("Введите число:");
// int num = int.Parse(Console.ReadLine()!);
// int[] ArrayFibonachi(int n)
// {
//     int [] array = new int [n];
//     array [0] = 0;
//     array [1] = 1;
//     int i = 2;

//     while (i < n)
// {
//     array[i] = array[i-1] + array[i - 2] ;
   
//     i++;
// }
// return array;
// }
// int [] res = ArrayFibonachi(num);
// Console.WriteLine(string.Join(" ", res));