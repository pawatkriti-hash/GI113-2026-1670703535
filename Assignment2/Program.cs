// Student ID: <1670703535>
// Name: <ภาวัต กฤติยาพินิต>
// Section: <Section 129A>
// No.: <เลขที่ 4 >

using System;

class Program 
{
    static void Main()
    {
        const string MaterialName = "Iron";
        const double SmeltRate = 0.25;
        const double SalvageRate = 0.30;
        const double MaxBatch = 500;

        Console.WriteLine("----------------------------------");
        Console.WriteLine("--     Welcome to the Forge     --");
        Console.WriteLine("----------------------------------");
        Console.WriteLine($"=> {MaterialName} Smelting {SmeltRate} / Salvage {SalvageRate}");
        Console.WriteLine("=> Key 'S' for Smelt (Ore -> Ingot)");
        Console.WriteLine("=> Key 'B' for Breakdown (Ingot -> Ore)");

        Console.Write("=> Choose Menu: ");
        bool menuOk = char.TryParse(Console.ReadLine(), out char menu);

        Console.Write("=> How much would you like: ");
        bool amountOk = double.TryParse(Console.ReadLine(), out double amount);

        if (amountOk && amount > 0 && amount <= MaxBatch)
        {
            if (menuOk && (menu == 'S' || menu == 's'))
            {
                double result = amount * SmeltRate;
                Console.WriteLine($"=> {amount:F2} {MaterialName} Ore = {result:F2} {MaterialName} Ingot");
            }
            else if (menuOk && (menu == 'B' || menu == 'b'))
            {
                double result = amount / SalvageRate;
                Console.WriteLine($"=> {amount:F2} {MaterialName} Ingot = {result:F2} {MaterialName} Ore");
            }
            else
            {
                Console.WriteLine("=> Error: invalid menu. Please key S or B.");
            }
        }
        else
        {
            Console.WriteLine($"=> Error: invalid amount. Enter a number greater than 0 and not more than {MaxBatch}.");
        }
    }
}