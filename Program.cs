using System.Collections;

namespace Custom_God_Morgen;

class Program
{
    static void Main(string[] args)
    {
        // Console.Clear();
        DateTime tid = DateTime.Now;
        String? person = "";
        Boolean validName = false;
        string oppgave = "";
        string tidOmrade = "";
        string? valg = "";
        List<string> validValg = new() { "1", "2", "3", "4", "5" };
        Dictionary<string, string> oppgaver = new()
         {
             { "Undervisning", "Det blir en par timer da!" },
             { "Utvikling", "Hvet ikke hvor mye kan de ta!" },
             { "Undersøking", "Skulle ikke ta mye tid" },
             { "Spise", "Mmm jeg er sulten også!! Bon apetit!" },
             { "Slapa","Den er beste du kan gjøre!"}
             };

        // Input Name
        while (!validName)
        {
            Console.WriteLine("Vær så snill Identifisere deg ... Hva er fornavnet ditt?");
            person = Console.ReadLine();
            if (person.Length > 1)
            { validName = true; }
            else
            {
                Console.Clear();
                Console.WriteLine("Thats Not a Valid Name");
            }

        }

        // Hilse med Tid

        Console.WriteLine($"Hi {person}! så fint du kommer this {tid.DayOfWeek} klokka {tid.Hour}:");
        if (tid.Hour >= 5 && tid.Hour < 12)
        { tidOmrade = "Morgen"; }
        else if (tid.Hour >= 12 && tid.Hour < 20)
        { tidOmrade = "Kveld"; }
        else
        { tidOmrade = "Night"; }
        Console.WriteLine($"!!!Good {tidOmrade} {person}!!!");

        // Input oppgave
        while (!(validValg.Contains(valg)))
        {
            Console.WriteLine($"Hva skal du gjøre i dag {person}?");
            Console.WriteLine($"1. Undervisning\n2. Utvikling\n3. Undersøking\n4. Spise\n5. Slapa");

            valg = Console.ReadLine();
            if (!(validValg.Contains(valg)))
            {
                Console.Clear();
                Console.WriteLine("Not an option! try again....");
            }
        }

        switch (valg)
        {
            case "1":
                oppgave = "Undervisning";
                break;
            case "2":
                oppgave = "Utvikling";
                break;
            case "3":
                oppgave = "Undersøking";
                break;
            case "4":
                oppgave = "Spise";
                break;
            case "5":
                oppgave = "Slapa";
                break;
        }

        Console.WriteLine($"Ohh! Så du skal start {oppgave} ...");
        Console.WriteLine($"{oppgaver[oppgave]}");


    }

}
