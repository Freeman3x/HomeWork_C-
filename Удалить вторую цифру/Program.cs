Console.Write("Введите трехзначное число: ");

int number = int.Parse(Console.ReadLine());

int a = number / 100;

int b = number % 100;

int c = b / 10; 

int d = number % 10; 

Console.Write("первое число: ");
Console.WriteLine(a);

Console.Write("второе число: ");
Console.WriteLine(c);

Console.Write("третье число: ");
Console.WriteLine(d);

Console.Write("Новое число: ");
Console.Write(a);Console.Write(d);