Console.Write("Введите цифру, обозначающую день недели ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 6)
{
   Console.WriteLine($"Сегодня выходной");
}
else
if (number == 7)
{
   Console.WriteLine($"Сегодня выходной");
}
else
   Console.WriteLine($"Сегодня рабочий день");
