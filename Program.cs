//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет,
//является ли оно палиндромом.
//
//int number = Convert.ToInt32(Console.ReadLine());
//
//if (number > 9999 && number <= 99999)
//{
//    int first = number / 1000;
//    int last = number % 100;
//
//    if (first / 10 == last % 10 && first % 10 == last / 10)
//    {
//        Console.WriteLine($"Число {number} является полиндромом!");
//    }
//    else
//    {
//        Console.WriteLine($"Число {number} не является полиндромом!");
//}
//}
//else
//{
//    Console.WriteLine($"Число {number} не пятизначное!");
//}
//
//------------------------------------------------------------------------
//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве.
//
//Console.Write("Enter  A1: ");
//int A1 = Convert.ToInt32(Console.ReadLine());
//
//Console.Write("Enter A2: ");
//int A2 = Convert.ToInt32(Console.ReadLine());
//
//Console.Write("Enter A3: ");
//int A3 = Convert.ToInt32(Console.ReadLine());
//
//Console.Write("Enter B1: ");
//int B1 = Convert.ToInt32(Console.ReadLine());
//
//Console.Write("Enter B2: ");
//int B2 = Convert.ToInt32(Console.ReadLine());
//
//Console.Write("Enter B3: ");
//int B3 = Convert.ToInt32(Console.ReadLine());
//
//double result = Math.Sqrt(Math.Pow(B1 - A1, 2) + Math.Pow(B2 - A2, 2) + Math.Pow(B3 - A3, 2));
//Console.WriteLine(result);
//
//---------------------------------------------------------------
//Задача 23
//Напишите программу, которая принимает на вход число (N)
//и выдаёт таблицу кубов чисел от 1 до N.

//int N = new Random().Next(1, 5);
//
//int cube = 0;
//
//for (int i = 1; i <= N; i++)
//{
//    cube = i * i * i;
//    Console.WriteLine(cube);
//}