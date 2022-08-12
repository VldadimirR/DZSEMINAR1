// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int userNumberA = new int();
int userNumberB = new int();
Console.WriteLine("Введите 1  число");
userNumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
userNumberB = Convert.ToInt32(Console.ReadLine());
if(userNumberA > userNumberB)
{
    Console.WriteLine($"Наибольшее число {userNumberA}, наименьшее {userNumberB}");
}
else
{
    Console.WriteLine($"Наибольшее число {userNumberB}, наименьшее {userNumberA}");
}