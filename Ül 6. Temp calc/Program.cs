    static void Main()
    {
        Console.WriteLine("Vali teisendamise tüüp:");
        Console.WriteLine("1: Fahrenheit to Celsius");
        Console.WriteLine("2: Celsius to Fahrenheit");

   
        int choice = Int32.Parse(Console.ReadLine());

       
        if (choice == 1)
        {
            Console.WriteLine("Sisesta temperatuur Fahrenheitis:");
            double fahrenheit = Double.Parse(Console.ReadLine());
            ConvertToCelsius(fahrenheit);
        }
        else if (choice == 2)
        {
            Console.WriteLine("Sisesta temperatuur Celsiuses:");
            double celsius = Double.Parse(Console.ReadLine());
            ConvertToFahrenheit(celsius);
        }
        else
        {
            Console.WriteLine("Vale valik. Palun vali kas 1 või 2.");
        }
    }

    // Funktsioon Fahrenheitist Celsiuse arvutamiseks
    static void ConvertToCelsius(double fahrenheit)
    {
        double celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"{fahrenheit} kraadi Fahrenheit on {celsius} kraadi Celsiust.");
    }

    // Funktsioon Celsiuse teisendamiseks Fahrenheitiks
    static void ConvertToFahrenheit(double celsius)
    {
        double fahrenheit = (celsius * 9) / 5 + 32;
        Console.WriteLine($"{celsius} kraadi Celsiust on {fahrenheit} kraadi Fahrenheiti.");
    }

