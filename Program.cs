using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hvilket dyr vil du ta vare på?");
        string navn = Console.ReadLine();

        VirtualPet pet = new VirtualPet(navn); // Ustawiamy wiek na 2

        bool running = true;
        while (running)
        {
            Console.WriteLine($"\n1. Gi {pet.Name} mat");
            Console.WriteLine($"2. Kos med {pet.Name}");
            Console.WriteLine($"3. Sjekk om {pet.Name} må på do");
            Console.WriteLine("4. Avslutt");

            string valg = Console.ReadLine();

            switch (valg)
            {
                case "1":
                    pet.Feed();
                    break;
                case "2":
                    pet.Cuddle();
                    break;
                case "3":
                    pet.CheckToilet();
                    break;
                case "4":
                    running = false;
                    Console.WriteLine("Ha det bra!");
                    break;
                default:
                    Console.WriteLine("Ugyldig valg, prøv igjen.");
                    break;
            }
        }
    }
}
