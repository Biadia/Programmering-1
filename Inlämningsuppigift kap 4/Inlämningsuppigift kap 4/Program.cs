// Inledning/Öppning
Console.WriteLine("Logga in på din bank!\nAnvändernamn?");
string användarnamn = Console.ReadLine();
Console.WriteLine("Lösenord?");
string lösenord = Console.ReadLine();

// (Rätt) Inloggning
if (användarnamn == "petter" && lösenord == "abc123!")
{

    Console.WriteLine("Saldo på konto: 10 000kr\nVill du...?\n1. Ta ut pengar\n2. Sätta in pengar\n3. Logga ut"); // Val att göra på bankappen
    int val = int.Parse(Console.ReadLine());

    switch (val)
    {

        case 1: // Ta ut pengar
            Console.WriteLine("Hur mycket pengar vill du ta ut?");
            int taut = int.Parse(Console.ReadLine());
            if (taut <= 10000 && taut > 0)
            {
                Console.WriteLine($"Du kommer ta ut {taut} kronor och du kommer ha {10000 - taut} kronor kvar på kontot");
            }
            else
            {
                Console.WriteLine($"Du kan inte ta ut den här summan\nSaldo på kontot: 10 000kr");
            }
            break;

        case 2: // Sätta in pengar
            Console.WriteLine("Hur mycket pengar vill du sätta in?\nMax summa att sätta in är 50 000kr");
            int sättain = int.Parse(Console.ReadLine());
            if (sättain <= 50000 && sättain > 0)
            {
                Console.WriteLine($"Du kommer sätta in {sättain} kronor och din uppdaterade saldo är: {sättain + 10000}kr");
            }
            else
            {
                Console.WriteLine($"Denna summan går inte att sätta in\nSaldo på kontot: 10 000kr");
            }
            break;

        case 3: // Logga ut
            Console.WriteLine("Är du säker på att du vill logga ut?\nJa eller Nej?");
            string loggaut = Console.ReadLine();
            switch (loggaut)
            {
                case "Ja":
                    Console.WriteLine("Du har valt att logga ut\nSes snart igen!");
                    break;
                case "Nej":
                    Console.WriteLine("Du har valt att stanna inloggad!");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            break;

        default:
            Console.WriteLine("Error");
            break;
    }
}

else if (användarnamn != "petter" && lösenord == "abc123!") // fel inmatning av användarnamn
{
    Console.WriteLine("Ojsan fel användarnamn"); 
}
else if (användarnamn == "petter" && lösenord != "abc123!") // fel inmatning av lösen
{
    Console.WriteLine("Ojsan fel lösenord");
}
else if (användarnamn != "petter" && lösenord != "abc123!") // fel inmatning av lösen och användarnamn
{
    Console.WriteLine("Ojsan fel användarnamn och lösenord");
}