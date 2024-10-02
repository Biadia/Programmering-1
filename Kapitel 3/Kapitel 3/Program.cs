// övning 4.1

Console.WriteLine("Hur mycket bensin har du i tanken?");
int tank = int.Parse(Console.ReadLine());

double pris = 14.5;
double tankas = 50 - tank;
if (tank < 10)
{
    Console.WriteLine($"Du bör tanka, du kan tanka {tankas} och det kommer kosta {tankas * pris} kr.");
}
else
{
    Console.WriteLine($"Du kan fortsätta köra!");
}


// övning 4.2a

Console.WriteLine("Hur gammal är du?");
int ålder = int.Parse(Console.ReadLine());

if (ålder > 15 && ålder < 65)
{
    Console.WriteLine($"Resan kostar 20kr");
}
else
{
    Console.WriteLine("Resan kostar 10kr");
}




// övning 4.3

Console.WriteLine("Skriv ett år");
int år = int.Parse(Console.ReadLine());

if (((år % 4 == 0) && (år % 100 != 0)) || (år % 400 == 0))
{
    Console.WriteLine($"Året {år} är ett skottår!");
}
else
{
    Console.WriteLine($"Året {år} är inte ett skottår");
}


// övning 4.4a

Console.WriteLine("Hur många spel vill du köpa?");
int spel = int.Parse(Console.ReadLine());

double pr    is = 50.99;
double pris5 = (pris * spel) * 0.95;
double pris10 = (pris * spel) * 0.90;
double pris15 = (pris * spel) * 0.85;
if (spel < 5)
{
    Console.WriteLine($"Din totala kostnad blir {pris * spel}kr");
}
if (spel >= 5 && spel < 10)
{
    Console.WriteLine($"Din totala kostnad blir {pris5}kr");
}
if (spel >= 10 && spel < 15)
{
    Console.WriteLine($"Din totala kostnad blir {pris10}kr");
}
if (spel >= 15)
{
    Console.WriteLine($"Din totala kostnad blir {pris15}kr");
}


// övning 4.4b

Console.Write("Ange ett tal ");
double tal1 = double.Parse(Console.ReadLine());
Console.Write("Ange ett till tal ");
double tal2 = double.Parse(Console.ReadLine());
Console.Write("Ange ett räknesätt (+, -, *, /)");
string räknesätt = Console.ReadLine();

if (räknesätt == "+")
{
    Console.WriteLine($"Addition: {tal1} * {tal2} = {tal1 * tal2}");
}
else if (räknesätt == "-")
{
    Console.WriteLine($"Subtraktion: {tal1} - {tal2} = {tal1 - tal2}");
}
else if (räknesätt == "*")
{
    Console.WriteLine($"Multiplikation: {tal1} * {tal2} = {tal1 * tal2}");
}
else if (räknesätt == "/")
{
    Console.WriteLine($"Division: {tal1} / {tal2} = {tal1 / tal2}");
}

// övning 4.5

Console.Write("Ange ett tal ");
double tal3 = double.Parse(Console.ReadLine());
Console.Write("Ange ett till tal ");
double tal4 = double.Parse(Console.ReadLine());
Console.Write("Ange ett räknesätt (+, -, *, /)");
string räknesätt2 = Console.ReadLine();

switch (räknesätt2)
{

    case "+":
        Console.WriteLine($"Addition: {tal3} + {tal4} = {tal3 + tal4}");
        break;

    case "-":
        Console.WriteLine($"Subtraktion: {tal3} - {tal4} = {tal3 - tal4}");
        break;

    case "*":
        Console.WriteLine($"Multiplikation: {tal3} * {tal4} = {tal3 * tal4}");
        break;

    case "/":
        Console.WriteLine($"Division: {tal3} / {tal4} = {tal3 * tal4}");
        break;

    default:
        Console.WriteLine("Error");
        break;
}
