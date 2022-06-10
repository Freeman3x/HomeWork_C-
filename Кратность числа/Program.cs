Console.Write("Введите число: ");

double number = double.Parse(Console.ReadLine());

Console.Write("Введите делитель ");

double a = double.Parse(Console.ReadLine());

double b = number / a;

double c = b % 1;

if(c == 0)
{
    Console.WriteLine("Число кратно ");
}
else
{
    Console.Write("Число не кратно, остаток от деления = ");
    Console.WriteLine(c);
}
