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
            const string GameTitle = "Ironclad Frontier"; 

            var weaponName = "Duskfang Reaver";  
            var weaponRank = 'S';                   
            int weaponLevel = 37;
            float baseDamage = 64.2f;
            double durabilityPrecise = 93.6;        
            bool isEquippable = true;

            Console.WriteLine($"+==============================+");
            Console.WriteLine($"|      {GameTitle}      |");
            Console.WriteLine($"+==============================+");
            Console.WriteLine($"| Weapon     : {weaponName}");
            Console.WriteLine($"| Rank       : {weaponRank}");
            Console.WriteLine($"| Level Req. : {weaponLevel}");
            Console.WriteLine($"| Base DMG   : {baseDamage}");
            Console.WriteLine($"| Durability : {durabilityPrecise}");
            Console.WriteLine($"| Equippable : {isEquippable}");
            Console.WriteLine($"+==============================+");
            Console.WriteLine();

            
            double weaponLevelAsDouble = weaponLevel;
            Console.WriteLine($"Level Req. as double (implicit) : {weaponLevelAsDouble}");

            
            int durabilityTruncated = (int)durabilityPrecise;          
            int durabilityRounded = Convert.ToInt32(durabilityPrecise); 
            Console.WriteLine($"Durability cast (truncates)     : {durabilityTruncated}");
            Console.WriteLine($"Durability Convert (rounds)     : {durabilityRounded}");
        }
    }
}