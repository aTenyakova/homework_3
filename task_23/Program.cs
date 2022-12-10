// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int finishNumber = Convert.ToInt32(Console.ReadLine());

for (int startNumber = 1; startNumber <= finishNumber; startNumber++)
{
    Console.Write(Math.Pow(startNumber, 3) + " ");
}