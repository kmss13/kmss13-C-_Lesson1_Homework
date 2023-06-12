Console.WriteLine("Введите число");
string inputString = Console.ReadLine();
int number = Convert.ToInt32(inputString);

if (number % 2 == 0)
{
    Console.WriteLine("Введенное число чётное");
}
else
{
    Console.WriteLine("Введенное число нечётное");
}

