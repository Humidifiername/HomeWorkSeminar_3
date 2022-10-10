//  Напишите программу, которая принимает на вход пятизначное число и првоеряет, является ли оно палиндромом

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

//if (num % 10 == num )


//int num1 = num % 10;(9)
//int num1 = num / 100 % 10;(7)
//int num1 = num % 100 / 10;(8)
//int num1 = num / 1000 % 100 / 10;(5)
//int num1 = num / 100 % 100 / 10;(6)

if (num % 10 == num / 1000 % 100 / 10 && num / 100 % 100 / 10 == num % 100 / 10)
{
    Console.WriteLine($"да - {num}");
}
else
{
    Console.WriteLine($"нет - {num}");
}
