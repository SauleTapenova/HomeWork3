// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.WriteLine("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine("max = " + n1 + ", min = " + n2);
}
else
{
    Console.WriteLine("max = " + n2 + ", min = " + n1);
}
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/* 
Console.WriteLine("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a third number: ");
int n3 = Convert.ToInt32(Console.ReadLine());

if(n1 > n2)
{
    if(n1 > n3)
    {
      Console.WriteLine("max =" + n1);
    }
    else
    {
      Console.WriteLine("max =" + n3);
    }
}
else
    
{
    if(n2 > n3)
    {
      Console.WriteLine("max =" + n2);
    }
    else
    {
      Console.WriteLine("max =" + n3);
    }
}
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.WriteLine("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
int a = n1 % 2;

if(a == 0) 
{
  Console.WriteLine("да");  
}
else
{
    Console.WriteLine("нет");  
}
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.WriteLine("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
int current = 1;

while(current <= n)
{
    if(current % 2 == 0)
    {
       Console.Write(current + "  "); 
    }
    current ++;
}
*/