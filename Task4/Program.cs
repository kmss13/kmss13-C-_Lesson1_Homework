Console.WriteLine("Введите число");
string inputString = Console.ReadLine();
int number = Convert.ToInt32(inputString);
int count = 1;

Console.WriteLine();// Пустая строка для разграничения введенного числа и вывода чисел

while (count < number) 
{
    if (count % 2 == 0)
    {
        Console.WriteLine(count);  
    }

count++;
}