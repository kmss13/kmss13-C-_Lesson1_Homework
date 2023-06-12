Console.WriteLine("Введите первое число");
string inputString1 = Console.ReadLine();

Console.WriteLine("Введите второе число");
string inputString2 = Console.ReadLine();

Console.WriteLine("Введите третье число");
string inputString3 = Console.ReadLine();

int number1 = Convert.ToInt32(inputString1);
int number2 = Convert.ToInt32(inputString2);
int number3 = Convert.ToInt32(inputString3);
int max;

if (number2 > number1)
{
    max = number2;
}
else
{
    max = number1;
}
if (number3 > max)
{
    Console.WriteLine($"Число {number3} максимальное");
}
else
{
    Console.WriteLine($"Число {max} максимальное");
}
