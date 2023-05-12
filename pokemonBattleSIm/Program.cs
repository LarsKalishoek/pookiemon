
namespace pokemonBattleSIm;
using System;
using System.Security.Cryptography.X509Certificates;

internal class Program
    {
        static void Main(string[] args)
        {
         Charmander charmander = new Charmander("charmander", "fire", "water", 100);
                
        bool x = true;
        while (x)
        {
            Console.WriteLine("Enter Charmander's name: ");
            string char_name = Console.ReadLine();
            charmander.setName(char_name);
            Console.WriteLine("Name: " + charmander.getName());
            Console.WriteLine("Type: " + charmander.getType());
            Console.WriteLine("Weakness: " + charmander.getWeakness());
            Console.WriteLine("Hp: " + charmander.getHp());
            for (int i = 0; i <= 10; i++)
            {
                charmander.BattleCry();
            }
            Console.WriteLine("Do you want to continue y/n: ");
            string check_state = Console.ReadLine().ToLower();
            if (check_state == "y")
            {
                x = true;
            }
            else
            {
                x = false; break;
            }
        }
    }
        
}
    