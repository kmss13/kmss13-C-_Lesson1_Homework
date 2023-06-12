Console.WriteLine("Введите первое число");
string inputString1 = Console.ReadLine();

Console.WriteLine("Введите второе число");
string inputString2 = Console.ReadLine();

int number1 = Convert.ToInt32(inputString1);
int number2 = Convert.ToInt32(inputString2);

if (number1 > number2)
{
    Console.WriteLine($"Число {number1} больше числа {number2}");
}
else
{
    Console.WriteLine($"Число {number2} больше числа {number1}");
}

