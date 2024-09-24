// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Windows.Markup;

Console.WriteLine("Hello, World!");
Console.WriteLine( " Calculator Program");
do {
    double Num1 = 0;
    double Num2 = 0;
    double result = 0;

    Console.WriteLine(" enter Number 1 :");
    Num1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine(" enter Number 2 :");
    Num2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine(" input an option ");
    Console.WriteLine(" + : add");
    Console.WriteLine(" - : subtract");
    Console.WriteLine(" * : multiply ");
    Console.WriteLine(" / : divide ");

    switch (Console.ReadLine())
    {
        case "+":
            result = Num1 + Num2;
            Console.WriteLine($"Your result: {Num2} + {Num1} = " + result);
            break;

        case "-":
            result = Num1 - Num2;
            Console.WriteLine($"Your result: {Num1} - {Num2} = " + result);
            break;

        case "*":
            result = Num1 * Num2;
            Console.WriteLine($"Your result: {Num2} * {Num1} = " + result);
            break;

        case "/":
            result = Num1 / Num2;
            Console.WriteLine($"Your result: {Num1} / {Num2} = " + result);
            break;
    }
    Console.WriteLine(" WOULD YOU LIKE TO CONTINUE Y/N (Y = yes , N = NO): " );

} while(Console.ReadLine().ToUpper() == " Y ");

Console.WriteLine(" BYE ");

