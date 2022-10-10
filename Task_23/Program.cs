// Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N

Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());

for(int count = 1; count <= num; count++)
{
    int num1 = count * count * count;
    Console.WriteLine(num1);
}