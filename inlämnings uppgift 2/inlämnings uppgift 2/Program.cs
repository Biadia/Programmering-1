//int tal1 = 25;
//int tal2 = 35;
//int tal3 = 45;
//int summa = tal1 + tal2 + tal3;
//int medel = summa / 3;

//string meddelande1 = "Summan blir " + summa;
//string meddelande2 = "Medelvärdet blir " + medel;

//Console.WriteLine("Talen är " + tal1 + " " + tal2 + " " + tal3);
//Console.WriteLine(meddelande1);
//Console.WriteLine(meddelande2);


//string förnamn = "Bianca";
//string efternamn = "Johansson";
//int ålder = 17;
//int födelseår = 2024 - ålder;
//int gammal = födelseår + 50;

//Console.WriteLine("Jag heter " + förnamn + " " + efternamn);
//Console.WriteLine("Jag är " + ålder + " år");
//Console.WriteLine(gammal + " fyller jag 50 år");


//double Bas = 10.5;
//double Höjd = 12.5;
//double Area = (Bas * Höjd) / 2;

//Console.WriteLine("Triangelns area blir " + Area);


//int lån = 200000;
//double ränta = 4.3;
//Console.WriteLine(lån + (ränta / 100) * lån);

//Console.WriteLine("Ange ditt förnamn");
//string fnamn;
//fnamn = Console.ReadLine();
//Console.WriteLine("Ange ditt efternamn");
//string enamn;
//enamn = Console.ReadLine();
//Console.WriteLine("Hur många barn har du?");
//string abarn;
//abarn = Console.ReadLine();
//Console.WriteLine(fnamn + " " + enamn + " har " + abarn + " barn ");

//Console.WriteLine("Skriv ett ord på engleska");
//string eng;
//eng = Console.ReadLine();
//Console.WriteLine("Vad är översättningen på svenska?");
//string sve;
//sve = Console.ReadLine();
//Console.WriteLine(eng + " betyder " + sve + " på svenska.");

//Console.WriteLine("Namn?");
//string namn;
//namn = Console.ReadLine();
//Console.WriteLine("Telfonnummer?");
//string tn;
//tn = Console.ReadLine();
//Console.WriteLine("Email?");
//string email;
//email = Console.ReadLine();
//Console.WriteLine("Vi har tagit emot uppgifterna: ");
//Console.WriteLine("Namn: " + namn);
//Console.WriteLine("Telefonnummer: " + tn);
//Console.WriteLine("Email: " + email);

//// övning 3.1 a

//int tall1 = (int)(3 * 1.5);
//double tall2 = 35 / 10 * 10;
//double tall3 = (double)(7 / 2);
//double tall4 = (double)7 / 2;
//Console.WriteLine($"Summan blir: {tall1}");
//Console.WriteLine($"Summan blir: {tall2}");
//Console.WriteLine($"Summan blir: {tall3}");
//Console.WriteLine($"Summan blir: {tall1}");

//// övning 3.2 a
//Console.WriteLine("Hur mycket tid?");
//string minuter;
//minuter = Console.ReadLine();
//int min = int.Parse(minuter);
//int tim = (min / 60);
//int timmin = tim * 60;
//int min1 = min - timmin;
//Console.WriteLine($"Det blir {tim} timmar och {min1} minuter");

//// övning 3.2 b
//Console.WriteLine("Hur mycket lång tid?");
//string månader;
//månader = Console.ReadLine();
//int mån = int.Parse(månader);
//int år = (mån / 12);
//int månår = år * 12;
//int mån1 = mån - månår;
//Console.WriteLine($"Det blir {år} år och {mån1} månader");

//// övning 3.2 c
//Console.WriteLine("Skriv ett tusental");
//int tusental = int.Parse(Console.ReadLine());
//int hundra = tusental % 1000;
//int mellanskillnad = 1000 - hundra;
//int avrund = tusental + mellanskillnad;
//Console.WriteLine(avrund);

//// övning 3.3

//Console.WriteLine("Ange ett decimaltal");
//double decital = double.Parse(Console.ReadLine());

//double nära = Math.Round(decital);
//double ner = Math.Floor(decital);
//double upp = Math.Ceiling(decital);

//Console.WriteLine($"Avrundat till närmaste talet {nära}");
//Console.WriteLine($"Avrundat neråt {ner}");
//Console.WriteLine($"Avrundat uppåt {upp}");

//// övning 3.4

//Console.WriteLine("Tänk på ett nummer");
//int ognummer = int.Parse(Console.ReadLine());
//int nummer = ognummer; 
//nummer += 1;
//nummer *= 2;
//nummer -= 6;
//nummer /= 2;
//nummer += 3;
//nummer -= ognummer;
//Console.WriteLine($"Nu har du fått talet {nummer}");

//// övning 3.5

//int a = 3;
//int b = 4;
//int c = 4;

//bool lika1 = a == b;
//bool lika2 = b == c;
//bool lika3 = c == a;
//bool mindre4 = a < b;
//bool mindre5 = a > b;
//bool mindre6 = b < a;
//bool mindre7 = b > a;
//bool ML8 = b <= c;
//bool ML9 = a <= c;
//bool ML10 = b >= c;
//bool ML11 = c <= a;


//Console.WriteLine($"1: {lika1}\n2: {lika2}\n3: {lika3}");
//Console.WriteLine($"4: {mindre4}\n5: {mindre5}\n6: {mindre6}\n7: {mindre7}");
//Console.WriteLine($"8: {ML8}\n9: {ML9}\n10: {ML10}\n11: {ML11}");

//// övning 3.6
//Console.WriteLine("Vad kostar varan?");
//int pris = int.Parse(Console.ReadLine());
//Console.WriteLine("Hur mycket pengar har du?");
//int pengar = int.Parse(Console.ReadLine());

//bool råd = pengar >= pris;
//Console.WriteLine($"Jag har råd: {råd}");

//// övning 3.7a
//int a = 1;
//int b = 2;
//int c = 3;

//Console.WriteLine(1 < 2 && 5 > 4); 
//Console.WriteLine(1 == 2 && 1 < 2); 
//Console.WriteLine(1 == 2 || 2 == 2); 
//Console.WriteLine(3 <= 4 && 3 >= 4); 
//Console.WriteLine(2 < 1 || 2 == 0); 
//Console.WriteLine(5 < 5 && 5 > 5); 
//Console.WriteLine(5 < 5 || 5 > 5); 
//Console.WriteLine(a < b && a > b); 
//Console.WriteLine(a < b || a > b); 
//Console.WriteLine(a < c && b > c); 
//Console.WriteLine(a == b && a < c); 
//Console.WriteLine(b <= c && b >= a); 


//// övning 3.7b

//Console.WriteLine("Skriv ett tal");
//string tal1;
//tal1 = Console.ReadLine();
//int tal11 = int.Parse(tal1);
//Console.WriteLine("Ett till");
//string tal2;
//tal2 = Console.ReadLine();
//int tall2 = int.Parse(tal2);
//Console.WriteLine("Och ett sista");
//string tal3;
//tal3 = Console.ReadLine();
//int tall3 = int.Parse(tal3);

//bool följd = tal11 < tall2 && tall2 < tall3;

//Console.WriteLine($"Talen är i ordningföljd: {följd}");