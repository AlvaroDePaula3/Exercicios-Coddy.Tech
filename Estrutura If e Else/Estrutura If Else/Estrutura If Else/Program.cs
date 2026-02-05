using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite a velocidade dos ventos");
        int wind = int.Parse(Console.ReadLine()); // Don't change this line
        string status = "unset";
        // Type your code below
        if (wind < 8)
        {
            status = "Calm";
        }
        else if (wind >= 8 && wind < 31)
        {
            status = "Breeze";
        }
        else if (wind > 32 && wind < 63)
        {
            status = "Gale";
        }
        else
        {
            status = "Storm";
        }

        // Don\'t change the line below
        Console.WriteLine("status = " + status);
    }
}