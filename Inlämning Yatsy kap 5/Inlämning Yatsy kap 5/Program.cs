// Yatsy
using System.ComponentModel.Design;

Random tärning = new Random();

int[] slag = new int[5]; 


for (int x = 0; x < 1; x++) // Omgångar
{
    int antalpar = 0;
    bool triss = false;
    bool fyrtal = false;
    bool yatsy = false;
    int poäng = 0;

    for (int t = 0; t < 5; t++) // random 1-6 till tärning
    {
        slag[t] = tärning.Next(1, 7);
        Console.Write($"{slag[t]} ");
    }
    Console.WriteLine();
    for (int i = 1; i <= 6; i++) // Ränka poäng
    {
        int partal = 0;
        for (int j = 0; j < 5; j++) 
        {
            if (i == slag[j]) // Par
            {
                partal++;
            }
        }
        switch (partal) // Vad man fick och hur mycket poäng
        {
            case 2:
                {
                    antalpar++;
                    poäng += i * 2;
                    break;
                }
            case 3:
                {
                    triss = true;
                    poäng += i * 3;
                    break;
                }
            case 4:
                {
                    fyrtal = true;
                    poäng += i * 4;
                    break;
                }
                case 5:
                {
                    yatsy = true;
                    break;
                }
                
        }
    }
    // Skriver ut poöngen
    if (yatsy == true)
    {
        Console.WriteLine($"Yatsy!");
        Console.WriteLine($"50 Poäng");
    }
    else if (fyrtal == true)
    {
        Console.WriteLine($"Fyrtal");
        Console.WriteLine($"{poäng} Poäng");
    }
    else if (triss && antalpar == 1)
    {
        Console.WriteLine("Kåk");
        Console.WriteLine($"{poäng} Poäng");
    }
    else if (triss == true)
    {
        Console.WriteLine("Triss");
        Console.WriteLine($"{poäng} Poäng");
    }
    else if (3 > antalpar && antalpar > 1)
    {
        Console.WriteLine("Tvåpar");
        Console.WriteLine($"{poäng} Poäng");
    }
    else if (antalpar == 1)
    {
        Console.WriteLine("Par");
        Console.WriteLine($"{poäng} Poäng");
    }
    else if (!slag.Contains(6) && antalpar == 0) 
    {
        Console.WriteLine("Liten stege");
        Console.WriteLine($"15 Poäng");
    }
    else if (!slag.Contains(1) && antalpar == 0) 
    {
        Console.WriteLine("Stor stege");
        Console.WriteLine($"20 Poäng");
    }
    else 
    {
        Console.WriteLine("Inga poäng");
        Console.WriteLine($"{poäng} Poäng");
    }

   

    Console.Write($"Vill du spara någon av tärningarna? ");
    string val = Console.ReadLine();
    if (val != null)
    {
        Console.Write("Vilken tärning vill du ha kvar? (1-5) ");
        string spara = Console.ReadLine();
        slag[0] = int.Parse("1");
        slag[1] = int.Parse("2");
        slag[2] = int.Parse("3");
        slag[3] = int.Parse("4");
        slag[4] = int.Parse("5");
    }

    Console.ReadLine();
    x--;
    Console.Clear();
}







