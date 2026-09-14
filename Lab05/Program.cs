namespace Lab05
{
    internal class Program
    {
        private static int monMaxHp;

        static void Main(string[] args)
        {
            Console.WriteLine(" ===> BATTLE NAGE <=== ");
            Console.WriteLine("Hero vs. Moonsters -- Finght Calculator");

            Console.WriteLine("Hero Health: ");
            bool isHeroHp =int.TryParse(Console.ReadLine(), out int heroHp);
            Console.WriteLine("Hero Attack: ");
            bool isHeroAtk = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.WriteLine("Hero Defense: ");
            bool isHeroDef = int.TryParse(Console.ReadLine(), out int heroDef);

            
            Console.WriteLine("Monster Health: ");
            bool ismonHp = int.TryParse(Console.ReadLine(), out int monHp);
            Console.WriteLine("Monster Attack: ");
            bool ismonAtk = int.TryParse(Console.ReadLine(), out int monAtk);
            Console.WriteLine("Monster Defense: ");
            bool ismonDef = int.TryParse(Console.ReadLine(), out int monDef);

            
            bool allHeroValid = isHeroHp && isHeroAtk && isHeroDef;
            bool allMonValid = ismonHp && ismonAtk && ismonDef;
            Console.WriteLine($"Stats Validation: Hero: {allHeroValid}, Monster: {allMonValid}");
            Console.WriteLine($"[Hero]      HP: {heroHp} ATK: {heroAtk} DEF: {heroDef}");
            Console.WriteLine($"[Monster]   HP: {monHp} ATK: {monAtk} DEF: {monDef}");

            
            int potionHeal = 8;
            //1. 1 = 1+2
            //heroHp = heroHp + potionHeal;
            //2.
            heroHp += potionHeal;
            Console.WriteLine($"\n=> Hero drinks a potion, healing {potionHeal}. health is now {heroHp}");

            
            int normalDamage = Math.Max(0, heroAtk - monDef);
            Console.WriteLine($"Normal Attack deal: {normalDamage} DMG");


            int powerDamage = Math.Max(0, (heroAtk * 2) - monDef);
            Console.WriteLine($"Power Attack deal: {powerDamage} DMG");


            int counterDamage = Math.Max(0, (monAtk - heroDef) / 2);
            Console.WriteLine($"Monster Counter Attack deal: {counterDamage} DMG");

            Random rng = new Random();
            int roll = rng.Next(1, 101);
            bool isCrit = roll <= 10;
            int critDamage = normalDamage + Convert.ToInt32(isCrit) * normalDamage;
            Console.WriteLine($"Critical hit roll: {roll} (Critical: {isCrit})");
            Console.WriteLine($"Normal Attack  would deal Critical: {critDamage} DMG");


            bool heroHitsHarder = heroAtk > monAtk;
            bool canOneShotWithNormal = normalDamage >= monHp;
            bool monsterCanOneShotHero = counterDamage >= heroHp;
            bool safeTrade = normalDamage > counterDamage && !monsterCanOneShotHero;
            bool luckyOrLethal = isCrit || canOneShotWithNormal;
            Console.WriteLine($"Hero hits harder than Monster: {heroHitsHarder}");
            Console.WriteLine($"Normal Attack can defeat Monster in one hit: {canOneShotWithNormal}");
            Console.WriteLine($"Monster could defeat Hero in one hit back: {monsterCanOneShotHero}");
            Console.WriteLine($"This is a safe trade for Hero: {safeTrade}");
            Console.WriteLine($"This attack is lucky or lethal: {luckyOrLethal}");

            
            monHp -= normalDamage;
            Console.WriteLine($"Hero attacks! Monster HP: {monHp}/{monMaxHp}");

            
            bool monsterDefeated = monHp <= 0;
            int goldEarned = (monMaxHp - monHp) * 2;
            Console.WriteLine($"Monster defeated: {monsterDefeated}");
            Console.WriteLine($"Gold earned: {goldEarned}");





        }
    }
}
