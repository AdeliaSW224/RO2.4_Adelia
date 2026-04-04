using System.ComponentModel.Design;

Console.WriteLine("Exercise1");

Console.WriteLine("Enter first number:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number:"); 
int b = Convert.ToInt32(Console.ReadLine());

if (a == b)
{
    Console.WriteLine("Numbers are equal");
} else if (a > b)
{
    Console.WriteLine("First number is greater than second");
} else
{
    Console.WriteLine("First number is less than second");
}

Console.WriteLine("Exercise2");

Console.WriteLine("Enter number");
int s = Convert.ToInt32(Console.ReadLine());

if (s > 5 && s < 10)
{
    Console.WriteLine("The number is greater than 5");
}
else
{
    Console.WriteLine("Unknown number");
}

Console.WriteLine("Exercise3");

Console.WriteLine("Enter number");
int d = Convert.ToInt32(Console.ReadLine());

if (d == 5 || d == 10)
{
    Console.WriteLine("The number is either 5 or 10");
}
else
{
    Console.WriteLine("Unknown number");
}

Console.WriteLine("Exercise4");

Console.WriteLine("Enter number");
double e = Convert.ToDouble(Console.ReadLine());
double interest;
if (e < 100)
{
    interest = e * 0.05;
}
else if (e > 100 && e < 200)
{
    interest = e * 0.07;
}
else
{
    interest = e * 0.1;
}
    Console.WriteLine($"{e + interest}");

Console.WriteLine("Exercise5");

Console.WriteLine("Enter number");
double i = Convert.ToDouble(Console.ReadLine());
double interes;
if (i < 100)
{
    interes = 1 * 0.05;
}
else if (i > 100 && 1 < 200)
{
    interes = i * 0.07;
}
else
{
    interes = i * 0.1;
}
Console.WriteLine($"{i + interes + 15}");

Console.WriteLine("Exercise6");

Console.WriteLine("Enter operation number: 1.Addition 2.Subtraction 3.Multiplication");
int o = Convert.ToInt32(Console.ReadLine());
switch (o)
{
    case 1:
        Console.WriteLine("addition");
        break;
    case 2:
        Console.WriteLine("substraction");
        break;
    case 3:
        Console.WriteLine("multiplication");
        break;
    default:
        Console.WriteLine("operation is undefined");
        break;
}

Console.WriteLine("Exercise7");

Console.WriteLine("Enter operation number: 1.Addition 2.Subtraction 3.Multiplication");
int u = Convert.ToInt32(Console.ReadLine());
int w = Convert.ToInt32(Console.ReadLine());
int q = Convert.ToInt32(Console.ReadLine());
switch (u)
{
    case 1:
        Console.WriteLine($"{w + q}");
        break;
    case 2:
        Console.WriteLine($"{w - q}");
        break;
    case 3:
        Console.WriteLine($"{w * q}");
        break;
    default:
        Console.WriteLine("operation is undefined");
        break;
} 