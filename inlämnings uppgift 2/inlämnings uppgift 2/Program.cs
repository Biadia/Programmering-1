int tal1 = 25;
int tal2 = 35;
int tal3 = 45;
int summa = tal1 + tal2 + tal3;
int medel = summa / 3;

string meddelande1 = "Summan blir " + summa;
string meddelande2 = "Medelvärdet blir " + medel;

Console.WriteLine("Talen är " + tal1 + " " + tal2 + " " + tal3);
Console.WriteLine(meddelande1);
Console.WriteLine(meddelande2);


string förnamn = "Bianca";
string efternamn = "Johansson";
int ålder = 17;
int födelseår = 2024 - ålder;
int gammal = födelseår + 50;

Console.WriteLine("Jag heter " + förnamn + " " + efternamn);
Console.WriteLine("Jag är " + ålder + " år");
Console.WriteLine(gammal + " fyller jag 50 år");


double Bas = 10.5;
double Höjd = 12.5;
double Area = (Bas * Höjd) / 2;

Console.WriteLine("Triangelns area blir " + Area);


int lån = 200000;
double ränta = 4.3;
Console.WriteLine(lån + (ränta / 100) * lån);

Console.WriteLine("Ange ditt förnamn");
string fnamn;
fnamn = Console.ReadLine();
Console.WriteLine("Ange ditt efternamn");
string enamn;
enamn = Console.ReadLine();
Console.WriteLine("Hur många barn har du?");
string abarn;
abarn = Console.ReadLine();
Console.WriteLine(fnamn + " " + enamn + " har " + abarn + " barn ");

Console.WriteLine("Skriv ett ord på engleska");
string eng;
eng = Console.ReadLine();
Console.WriteLine("Vad är översättningen på svenska?");
string sve;
sve = Console.ReadLine();
Console.WriteLine(eng + " betyder " + sve + " på svenska.");

Console.WriteLine("Namn?");
string namn;
namn = Console.ReadLine();
Console.WriteLine("Telfonnummer?");
string tn;
tn = Console.ReadLine();
Console.WriteLine("Email?");
string email;
email = Console.ReadLine();
Console.WriteLine("Vi har tagit emot uppgifterna: ");
Console.WriteLine("Namn: " + namn);
Console.WriteLine("Telefonnummer: " + tn);
Console.WriteLine("Email: " + email);







