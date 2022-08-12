//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int userNumberA = new int();
int userNumberB = new int();
int userNumberC = new int();
Console.WriteLine("Введите 1  число");
userNumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
userNumberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число");
userNumberC = Convert.ToInt32(Console.ReadLine());

int max = userNumberA;
if ( userNumberA > max) max = userNumberA;
if ( userNumberB > max) max = userNumberB;
if (userNumberC > max) max = userNumberC;
Console.WriteLine($"Наибольшее число  - {max}");