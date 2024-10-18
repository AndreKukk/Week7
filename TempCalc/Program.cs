Console.WriteLine("Vali teisendamise tüüp (1/2)");
Console.WriteLine("1 on F to C ja 2 on C to F");

int choice = Int32.Parse(Console.ReadLine());

if (choice == 1)
{
    Console.WriteLine("Sisesta temperatuur Fahrenheitis:");
    double Fahrenheit = Double.Parse(Console.ReadLine());
    ConvertToCelcius(Fahrenheit);
}
else if (choice == 2)
{
    Console.WriteLine("Sisesta temperatuur Celsiuses:");
    double celsius = Double.Parse(Console.ReadLine());
    ConvertToFahrenheit(celsius);
}
else
{
    Console.WriteLine("Vale valik");
}

static void ConvertToCelcius(double fahrenheit)
{
    double celsius = (fahrenheit - 32) * 5 / 9;
    Console.WriteLine($"{fahrenheit}°F on {celsius:F2}°C.");
}

static void ConvertToFahrenheit(double celsius)
{
    double fahrenheit = (celsius * 9) / 5 + 32;
    Console.WriteLine($"{celsius}°C on {fahrenheit:F2}°F.");
}