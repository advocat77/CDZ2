Console.Write("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
int firstDigit = number / 100;
int thirdDigit = number % 10;
int result = (number - firstDigit * 100 - thirdDigit) / 10;
Console.WriteLine($"Вторая цифра числа {number}->{result}");