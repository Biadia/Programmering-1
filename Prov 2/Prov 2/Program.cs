Random grad = new Random();

int styrka = grad.Next(1, 11);
int smidighet = grad.Next(1, 11);
int träffsäkerhet = grad.Next(1, 11);
int intelligens = grad.Next(1, 11); 

// Hur kollar man vilken som är lägst respektive högst
int svag = 3;
int stark = 4;


Console.WriteLine($"Välkommen till RPG Roller!\nDina förmågor:\nStyrka: {styrka}\nSmidighet: {smidighet}\nTräffsäkerhet: {träffsäkerhet}\nIntelligens: {intelligens}"); // Intro

for (int i = 0; i < 1; i++) // Omgångar
{

    Console.WriteLine($"Din svagaste färdighet är: {svag}\nDin starkaste färdighet är: {stark} ");
    Console.WriteLine($"Välj:\n1: Slå på en färdighet\n2: Avlsuta"); // Vad vill man göra
    string val = Console.ReadLine();

    switch (val) 
    {
        case "1": // Ifall man vill köra
            {
                string färdighet = "";
                while (färdighet == "" || färdighet == null) // Så ifall man inte skriver in vad man vill göra fortsätter den fråga tills den får ett svar
                {
                    Random slag = new Random(); 
                    int tärning = slag.Next(1, 11); // Tärning slaget
                    Console.WriteLine($"Vilken färdighet vill du slå på?\n1.Styrka: {styrka}\n2.Smidighet: {smidighet}\n3.Träffsäkerhet: {träffsäkerhet}\n4.Intelligens: {intelligens}");
                    färdighet = Console.ReadLine();
                    

                        if (färdighet == "1")  // styrka
                        {
                                  if (styrka < tärning) // Du lyckades
                                  {  
                                      Console.WriteLine($"Du har {styrka} i Styrka...\nOch slår en {tärning}...\nVilket innebär att du...lyckades!");
                                      int nyStyrka = tärning;
                                      Console.WriteLine($"Din nya styrka blir\nStyrka: {nyStyrka}");
                                  }
                                  else // Du misslyckades
                                  {
                                      Console.WriteLine($"Du har {styrka} i Styrka...\nOch slår en {tärning}...\nVilket innebär att du...misslyckades!");
                                      Console.WriteLine($"Dina färdigheter i styrka stannar samma: {styrka}");
                                  }
                        }
                        else if (färdighet == "2") 
                        {
                        // smidighet
                        if (smidighet < tärning) // Du lyckades
                        {
                            Console.WriteLine($"Du har {smidighet} i Smidighet...\nOch slår en {tärning}...\nVilket innebär att du...lyckades!");
                            int nySmidighet = tärning;
                            Console.WriteLine($"Din nya smidighet blir\nSmidighet: {nySmidighet}");
                        }
                        else // Du misslyckades
                        {
                            Console.WriteLine($"Du har {smidighet} i Smidighet...\nOch slår en {tärning}...\nVilket innebär att du...misslyckades!");
                            Console.WriteLine($"Dina färdigheter i smidighet stannar samma: {smidighet}");
                        }
                    }
                        else if (färdighet == "3")
                        {
                        // Träffsäkerhet
                        if (träffsäkerhet < tärning) // Du lyckades
                        {
                            Console.WriteLine($"Du har {träffsäkerhet} i Träffsäkerhet...\nOch slår en {tärning}...\nVilket innebär att du...lyckades!");
                            int nyTräffsäkerhet = tärning;
                            Console.WriteLine($"Din nya Träffsäkerhet blir\nTräffsäkerhet: {nyTräffsäkerhet}");
                        }
                        else // Du misslyckades
                        {
                            Console.WriteLine($"Du har {träffsäkerhet} i Träffsäkerhet...\nOch slår en {tärning}...\nVilket innebär att du...misslyckades!");
                            Console.WriteLine($"Dina färdigheter i Träffsäkerhet stannar samma: {träffsäkerhet}");
                        }
                    }
                        else if (färdighet == "4")
                        {
                        // Intelligens
                        if (intelligens < tärning) // Du lyckades
                        {
                            Console.WriteLine($"Du har {intelligens} i Intelligens...\nOch slår en {tärning}...\nVilket innebär att du...lyckades!");
                            int nyIntelligens = tärning;
                            Console.WriteLine($"Din nya Intelligens blir\nIntelligens: {nyIntelligens}");
                        }
                        else // Du misslyckades
                        {
                            Console.WriteLine($"Du har {intelligens} i Intelligens...\nOch slår en {tärning}...\nVilket innebär att du...misslyckades!");
                            Console.WriteLine($"Dina färdigheter i Intelligens stannar samma: {intelligens}");
                        }
                    }
                }
                break;

            } 
        case "2": // Ifall man inte vill köra
            {
                Console.WriteLine("Tack för att du har spelat!");
                break;
            }

    }

    Console.ReadLine();
    i--; // Kör om
}
