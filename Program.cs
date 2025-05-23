using System;

using static System.Console;

class Program
{
    static void Main()
    {
        WriteLine("Hvilket dyr vil du ta vare på, 1 eller 2?");
        string navn = ReadLine();

        VirtualPet pet = new VirtualPet(navn); // Ustawiamy wiek na 2

        bool play = true;
        while (play)
        {
            WriteLine($"\n1. Gi {pet.GetName()} mat");
            WriteLine($"2. Kos med {pet.GetName()}");
            WriteLine($"3. Sjekk om {pet.GetName()} må på do");
            WriteLine($"4. Sjekk om {pet.GetName()} sover");
            WriteLine("5. Avslutt");

           

            string valg = ReadLine();

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
                    pet.CheckSleep();
                    break;
                case "5":
                    play = false;
                    WriteLine("Ha det bra!");
                    break;
                default:
                    WriteLine("Ugyldig valg, prøv igjen.");
                    break;
            }
        }
    }
}
