/*
// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.

Console.Write("Введите число 1:    ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2:    ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1>number2)
{
    Console.WriteLine("Max число " + number1);
}
else 
{
Console.WriteLine("Max число " + number2);
}
*/


/* Задача 4. Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число  ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число  ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число  ");
int number3 = Convert.ToInt32(Console.ReadLine());


int max = 0;

if (number1 >= number2 && number1 >= number3)
    max = number1;
else if (number2 >= number1 && number2 >= number3)
    max = number2;
 else if (number3 >= number1 && number3 >= number2)
    max = number3;   

Console.WriteLine("Максимальное число   " + max);
*/



/*
//Задача 6. Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0) 
{
Console.Write("Число четное и делится на 2 без остатка");
}
else
{
  Console.Write("Число нечетное и не делится на 2 без остатка");  
}
*/

/*
// Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите первое число диапазона  ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число диапазона  ");
int number2 = Convert.ToInt32(Console.ReadLine());

for (int i = number1; i <=number2; i++)
{
    if (i % 2 ==0)
    {
        Console.Write(i + "  ");
    }
*/
