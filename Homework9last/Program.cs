//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
 void PrintNumbers(int num)
 {   
     if (num > 0)
     {  
        Console.Write(num + " ");
        PrintNumbers(num - 1);
    }
     
 }

 Console.Write("Input a number: ");
 int n = Convert.ToInt32(Console.ReadLine());
 PrintNumbers(n);
 */

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
     int SumNumbers(int m, int n)
     {
          if(m < n)
          { 
             return m + SumNumbers(m + 1,n);
          }
          if(m > n)
          {  
             return m + SumNumbers(m - 1,n);
          }

        return n;       
     }
    
     Console.Write("Enter number M: ");
     int m = Convert.ToInt32(Console.ReadLine());
     Console.Write("Enter number N: ");
     int n = Convert.ToInt32(Console.ReadLine());
     int res = SumNumbers(m,n);
     Console.WriteLine("Sum: " + (res));
     */