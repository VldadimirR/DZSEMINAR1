//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
int number = new int();
Console.WriteLine("Введите  число");
number = Convert.ToInt32(Console.ReadLine());
int number2 = number%2;
if (number2 > 0) 
{
    Console.WriteLine($"{number} - Число нечетное");
}
else
{
   Console.WriteLine($"{number} - Число четное");
}

