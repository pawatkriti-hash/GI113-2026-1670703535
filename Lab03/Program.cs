namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;
            // ontput แสดงตัวแปร
            Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine($"\nName: {bossName}\nRank: {rank}\nLevel: {level} / {MaxLevel}\nHP: {currentHp} / {maxHp}" +
                $"\nAttack Power: {attackPower}\nCritical Multiplier: {critMultiplier}\nIs Boss: {isBoss}");

            //ทำ Implicit int -> duble
            Console.WriteLine("\n----- Implicit Conversiron : HP as double -----");
            double currentHpDouble = currentHp;
            Console.WriteLine($"HP (double): {currentHpDouble}");

            //ทำ Implicit 
            Console.WriteLine("\n----- Exact HP Percent (no integer truncation");
            double hpPercent = currentHpDouble * 100 / maxHp;
            Console.WriteLine($"HP Percent (exact): {hpPercent}%");

            //ทำ Explicit โดนการ Casting (float) AttackPower ->> Int
            Console.WriteLine("\n----- Explicit Cast: Attack Power -> Display Int -----");
            int attackInt = (int)attackPower;
            Console.WriteLine($"Attack Power (int cast): {attackInt}");

            Console.WriteLine("\n----- Cast vs Convert: Crit Multiplier -----");
            int critMultiplierIntCast = (int)critMultiplier;
            Console.WriteLine($"Critical Multiplier (int cast): {critMultiplierIntCast}");
            int critMultiplierIntConvert = Convert.ToInt32(critMultiplier);
            Console.WriteLine($"Critical Multiplier (int convert): {critMultiplierIntConvert}");


        }
    }
}
