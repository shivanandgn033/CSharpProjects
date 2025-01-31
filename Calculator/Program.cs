// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the calculator!");
        Console.Write("First number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Operator (+, -, *, /): ");
        string op = Console.ReadLine();

        Console.Write("Second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = op switch
        {
            "+" => num1 + num2,
            "-" => num1 - num2,
            "*" => num1 * num2,
            "/" when num2 != 0 => num1 / num2,
            _ => double.NaN
        };

        Console.WriteLine($"Result: {result}");
