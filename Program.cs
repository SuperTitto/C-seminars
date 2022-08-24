/*
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
int SecondDigit (int number)
{
   int dec = number / 100;
   int ed = number % 100;
   int result = ed / 10;
   
   return result;
}

int randNumber = new Random().Next(100, 1000);
int secondD = SecondDigit(randNumber);

Console.WriteLine($"Second digit of {randNumber} is {secondD}");
*/


/*
// Задача 13. Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

int SecondDigit (int number)
{
   int ed = number % 10;
   
   return ed;
}

int randNumber = new Random().Next(1, 1000);
int secondD = SecondDigit(randNumber);

Console.WriteLine($"Second digit of {randNumber} is {secondD}");
*/



/*
// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

void WT (int number)  
{
    if (number <= 5)
   {
   Console.WriteLine("Будний день");}
    else
    {Console.WriteLine("Выходной");}   
}

Console.WriteLine("Введите число от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());

WT(number);
*/