namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int heroHP = 100;
            int monHp = 100;
            int atk = 100;

            Console.WriteLine("Adventure of Brian");
            Console.WriteLine(">=== Monster Encounter 1 <===");
            Console.WriteLine("ACTION A: ATTACK");
            Console.WriteLine("ACTION B: FLEE\n");

            Console.Write("Choose your action: ");
            bool inputOk = char.TryParse(Console.ReadLine(), out char choice);

            if (!inputOk || (choice != 'a' && choice != 'A' && choice != 'b' && choice != 'B'))
            {
                Console.WriteLine("Invalid input, Please choose between a, b");
            }
            else if (choice == 'a' || choice == 'A')
            {
                monHp -= atk;
                if (monHp <= 0)
                {
                    Console.WriteLine($"Player attack monster with {atk} points, Monster defeated!!!");
                }
                else
                {
                    Console.WriteLine($"Player attack monster with {atk} points, Monster HP has {monHp}HP left.");
                }
            }
            else if (choice == 'b' || choice == 'B')
            {
                heroHP -= atk;
            }
            else
            {
                Console.WriteLine("Timeout: You ran out of time");
            }

        }
    }
}

