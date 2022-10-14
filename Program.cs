// See https://aka.ms/new-console-template for more information
Console.Write("Введите число: ");
string? sNum = Console.ReadLine();

int num = Convert.ToInt32(sNum);
 
if (num%2 == 0)
    Console.WriteLine("Число четное!");
else
    Console.WriteLine("Число нечетное!");
