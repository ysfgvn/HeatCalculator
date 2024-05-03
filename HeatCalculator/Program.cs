    Console.WriteLine("Please select the unit of temperature you want to convert\n");
    Console.WriteLine("1. Celsius to Fahrenheit");
    Console.WriteLine("2. Fahrenheit to Celsius");
    Console.WriteLine("3. Celsius to Kelvin");
    Console.WriteLine("4. Kelvin To Celsius");
    Console.WriteLine("Simply enter the number to make your selection.");

    string operation = Console.ReadLine();

    if (operation == "1")
    {
        Console.WriteLine("You are currently converting temperature from Celsius to Fahrenheit.\nPlease enter a degree.");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double result = (celsius * 1.8) + 32;
        Console.WriteLine("The temperature in Fahrenheit is currently: " + result);
    }
    else if (operation == "2")
    {
        Console.WriteLine("You are currently converting temperature from Fahrenheit to Celsius.\nPlease enter a degree.");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        double result = (fahrenheit - 32) / 1.8;
        Console.WriteLine("The temperature in Celsius is currently: " + result);
    }
    else if (operation == "3")
    {
        Console.WriteLine("You are currently converting temperature from Celsius to Kelvin.\nPlease enter a degree.");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double result = celsius + 273.15;
        Console.WriteLine("The temperature in Kelvin is currently: " + result);
    }
    else if (operation == "4")
    {
        Console.WriteLine("You are currently converting temperature from Kelvin to Celsius.\nPlease enter a degree.");
        double kelvin = Convert.ToDouble(Console.ReadLine());
        double result = kelvin - 273.15;
        Console.WriteLine("The temperature in Celsius is currently: " + result);
    }
    else
    {
        Console.WriteLine("You have pressed the wrong key. Restarting the program.");
    }
