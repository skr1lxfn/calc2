using System;
while (true)
{
    Console.WriteLine("Введите первое значение");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите знак (+, -, *, /): ");
    string operation = Console.ReadLine();
    Console.WriteLine("Введите второе значение");
    double b = Convert.ToDouble(Console.ReadLine());
    if (operation == "+")
    {
        Console.WriteLine($"Ответ:{a + b}");
    }
    else if (operation == "-")
    {
        Console.WriteLine($"Ответ:{a - b}");
    }
    else if (operation == "*")
    {
        Console.WriteLine($"Ответ:{a * b}");
    }
    else if (operation == "/")
    {
        Console.WriteLine($"Ответ:{a / b}");
    }
}


