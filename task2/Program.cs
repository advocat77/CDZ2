Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
{
   Console.WriteLine($"Третьей цифры нет");
}
else
if (number > 1000)
{
   number = number / 10;
}
int thirdDigit = number % 10;
Console.WriteLine($"Третья цифра числа {thirdDigit}");