using System;

public class VirtualPet
{
    private string name;
   // private int age;
    private bool isHungry = true;
    private bool needsCuddle = true;
    private bool needsToilet = false;

    public string GetName()
    {
        return name;
    }

    // public int Age => age;

    public VirtualPet(string name)
    {
        this.name = name;
       // this.age = age;
    }

    public void Feed()
    {
        if (isHungry)
        {
            Console.WriteLine($"{name} er mett og fornøyd!");
            isHungry = false;
            needsToilet = true;
        }
        else
        {
            Console.WriteLine($"{name} er allerede mett.");
        }
    }

    public void Cuddle()
    {
        if (needsCuddle)
        {
            Console.WriteLine($"{name} smiler!");
            needsCuddle = false;
        }
        else
        {
            Console.WriteLine($"{name} er allerede glad.");
        }
    }

    public void CheckToilet()
    {
        if (needsToilet)
        {
            Console.WriteLine($"{name} må på do! 💩");
            needsToilet = false;
        }
        else
        {
            Console.WriteLine($"{name} trenger ikke å gå på do.");
        }
    }
}
