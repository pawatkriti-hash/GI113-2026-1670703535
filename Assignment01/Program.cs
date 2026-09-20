// Student ID : 1670703535
// Name       : Phawat Krittiyaphinit
// Section    : 129A
// No.        : 4

using System;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string TrainerClass = "Elite Four";
            const string AbilityName = "Blaze";

            var pokemonSpecies = "Charflare";    
            var typeCode = 'F';                   
            int currentHp = 142;
            float attackPower = 118.3f;
            double weightKgRaw = 89.4;
            bool isFainted = false;

            double currentHpAsDouble = currentHp;

            double happinessRaw = 47.6;
            int happinessCast = (int)happinessRaw;               
            int happinessConvert = Convert.ToInt32(happinessRaw); 

            Console.WriteLine("======================================");
            Console.WriteLine($"  {TrainerClass} BATTLE CARD");
            Console.WriteLine("======================================");
            Console.WriteLine($" สายพันธุ์      : {pokemonSpecies}");
            Console.WriteLine($" รหัสธาตุ       : {typeCode}");
            Console.WriteLine($" ความสามารถ     : {AbilityName}");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($" HP ปัจจุบัน (int)    : {currentHp}");
            Console.WriteLine($" HP ปัจจุบัน (double) : {currentHpAsDouble} ");
            Console.WriteLine($" พลังโจมตี            : {attackPower}");
            Console.WriteLine($" น้ำหนัก (กก.)         : {weightKgRaw}");
            Console.WriteLine($" สลบแล้ว?             : {isFainted}");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($" ค่าความสุขดิบ         : {happinessRaw}");
            Console.WriteLine($" (int) cast            : {happinessCast} ");
            Console.WriteLine($" Convert.ToInt32        : {happinessConvert} ");
            Console.WriteLine("======================================");
        }
    }
}