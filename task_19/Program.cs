// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int temp = number;
int reverse = 0;

if (number > 10000 && number < 100000)
{
    for (reverse = 0; number > 0; number /= 10)
    {
        int lastNumber = number % 10;
        reverse = reverse * 10 + lastNumber;
    }
        if (temp == reverse)
        {
            Console.Write("Это палиндром");
        }
    else Console.Write("Это не палиндром");
}
else Console.WriteLine("Неверное число");