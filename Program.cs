//homeework1

//task2. Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

/*
Console.WriteLine("Input number 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2: ");
int b = Convert.ToInt32(Console.ReadLine());
int min;
int max;

if (a > b)
{
max = a;
min = b;
}
else 
{
max = b;
min = a;
}
Console.WriteLine($"Min = {min} and Max = {max}");
*/

//task4. Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.

/*
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max;

if(a > b && a > c)
{
  max = a;
}
else if (b > a && b > c)
{
  max = b;
}
else
{
  max = c;
}
Console.WriteLine("Максимальное число: " + max);
*/

//task6. Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(num % 2 == 0 ? "Число чётное" : "Число не чётное");
*/

//task8. Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

/*
Console.Write("Напишите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;

 if(count == 1)
  {
    count += 1;
  }
while(count <= num)
{
  Console.WriteLine(count);
  count += 2;
}
*/