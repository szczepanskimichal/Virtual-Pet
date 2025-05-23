using System;

using static System.Console;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; // Set UTF-8 encoding for console output NORSK SPRÅK!!!!!!!!!!

        WriteLine("Hei! Velkommen til Virtual Pet-spillet!");
        WriteLine("Du kan ta vare på to forskjellige dyr.");
        WriteLine("Hva heter du?");
        
        string brukerNavn = ReadLine();

        getBrukerNavn(brukerNavn);
        WriteLine("Hva heter dyr?");
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

    private static void getBrukerNavn(string brukerNavn)
    {
        WriteLine($"Hei {brukerNavn}! Velkommen til Virtual Pet-spillet!");
    }
}
