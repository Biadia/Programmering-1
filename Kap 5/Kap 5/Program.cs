////5.1
//Random rnd = new Random();
//int slump = rnd.Next(1, 8);
//switch (slump)
//{
//    case 1:
//        Console.WriteLine($"Dag nr. {slump} är måndag!");
//        break;
//    case 2:
//        Console.WriteLine($"Dag nr. {slump} är tisdag!");
//        break;
//    case 3:
//        Console.WriteLine($"Dag nr. {slump} är onsdag!");
//        break;
//    case 4:
//        Console.WriteLine($"Dag nr. {slump} är torsdag!");
//        break;
//    case 5:
//        Console.WriteLine($"Dag nr. {slump} är fredag!");
//        break;
//    case 6:
//        Console.WriteLine($"Dag nr. {slump} är lördag!");
//        break;
//    case 7:
//        Console.WriteLine($"Dag nr. {slump} är söndag!");
//        break;
//    default:
//        Console.WriteLine($"{slump} finns inte som en veckodag");
//        break;
//}

//// 5.2a
//Random rnd = new Random();
//int[] tärning = new int[6];
//tärning[0] = rnd.Next(1, 7);
//tärning[1] = rnd.Next(1, 7);
//tärning[2] = rnd.Next(1, 7);
//tärning[3] = rnd.Next(1, 7);
//tärning[4] = rnd.Next(1, 7);
//Console.Write($"{tärning[0]} {tärning[1]} {tärning[2]} {tärning[3]} {tärning[4]}");

//// 5.2b
//Console.Write("Ange");
//double tal1 = double.Parse( Console.ReadLine() );
//Console.Write($"Ange");
//double tal2 = double.Parse( Console.ReadLine() );
//Console.Write($"Ange");
//double tal3 = double.Parse(Console.ReadLine());
//Console.Write($"Ange");
//double tal4 = double.Parse(Console.ReadLine());

//double[] tal = new double[4];
//tal[0] = tal1;
//tal[1] = tal2;
//tal[2] = tal3;
//tal[3] = tal4;
//Console.WriteLine($"{tal1} {tal2} {tal3} {tal4}");


//// 5.3a

//string[] personer = new string[3];
//personer[0] = "Jack";
//personer[1] = "Peter";
//personer[2] = "Sara";

//int[] löner = new int[3];
//löner[0] = 40000;
//löner[1] = 42000;
//löner[2] = 48000;

//Console.WriteLine($"Personer i listan 3\nPerson 1: {personer[0]} har lönen {löner[0]}\nPerson 2: {personer[1]} har lönen {löner[1]}\nPerson 3: {personer[2]} har lönen {löner[0]}");

//// 5.3a facit
//string[] personerf = {"Jack", "Peter", "Sara" };
//double[] lönerf = { 40000, 42000, 48000 };
//Console.WriteLine($"Antar personer i listan {personerf.Length}");
//int index = 0;
//Console.WriteLine($"Person {index + 1}: {personerf[index]} har lön {lönerf[index++]}");
//Console.WriteLine($"Person {index + 1}: {personerf[index]} har lön {lönerf[index++]}");
//Console.WriteLine($"Person {index + 1}: {personerf[index]} har lön {lönerf[index]}");

//// 5.4a
//int[,] m = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
//Console.WriteLine($"Diagonalen åt höger blir: {m[0, 0] + m[1,1] + m[2,2]}");
//Console.WriteLine($"Diagonalen åt vänster blir: {m[0,2] + m[1, 1] + m[2, 0]}");

//// 5.4b facit ?
//int[,] C = { {2,8 },
//             {0,9 }
//            };

//int[,] D = { {5,6 },
//             {11,3}
//            };

//int[,] result = new int[2, 2];
//if (C.GetLength(0) == D.GetLength((0)) && C.GetLength(1) == D.GetLength(1))
//{


//    result[0, 0] = C[0, 0] - D[0, 0];
//    result[0, 1] = C[0, 1] - D[0, 1];
//    result[1, 0] = C[1, 0] - D[1, 0];
//    result[1, 1] = C[1, 1] - D[1, 1];

//    Console.WriteLine($"result\n{result[0, 0]}  {result[0, 1]}\n{result[1, 0]}  {result[1, 1]}");
//}
//else
//{
//    Console.WriteLine($"Matrisen matchar inte");
//}

// 5.5 b


//string[] arsenal = { "blå", "vit", "rosa" };
//string[] manchester = { "röd", "vit" };
//string[] Real = { "vit", "gul", "svart" };
//string[] Barca = { "röd", "blå" };


//string[][] färg = new string[4][];

//färg[0] = arsenal;
//färg[1] = manchester;
//färg[2] = Real;
//färg[3] = Barca;

//Console.WriteLine($"Arsenal: {färg[0][0]}, {färg[0][1]}, {färg[0][2]}");
//Console.WriteLine($"Manchester United: {färg[1][0]}, {färg[1][1]}");
//Console.WriteLine($"Real Madrid: {färg[2][0]}, {färg[2][1]}, {färg[2][2]}");
//Console.WriteLine($"Barcelona: {färg[3][0]}, {färg[3][1]}");

//// 5.6

//double sädeskorn = 1;
//int rutor = 64;
//int ruta = 1;

//while (ruta <= rutor)
//{
//    Console.WriteLine($"Ruta {ruta} :{sädeskorn}");
//    sädeskorn *= 2;
//    ruta++;
//}

//// 5.7

//using System.Diagnostics.SymbolStore;


//Console.WriteLine($"Hur mycket tjänar du per dag?");
//int lön = int.Parse(Console.ReadLine());

//string val;
//int räkning = 1;
//while (true)
//{
//    Console.WriteLine($"Hur mycket vill du ha?");
//    int mål = int.Parse(Console.ReadLine());
//    int summa = mål / lön;
//    Console.WriteLine($"{summa}");
//    Console.WriteLine($"Vill du fortsätta göra beräkningar?");
//    val = Console.ReadLine();

//    if (val == "nej")
//    {
//        break;
//    }
//}

//// 5.7 facit 

//int antalDagar = 1;
//double dagensLon = 0.01;
//double totalBelopp = 0.01;
//string val = "";
//while (true)
//{
//    Console.Write($"Önskar belopp? ");
//    double onskatBelopp = double.Parse(Console.ReadLine());

//    while (totalBelopp < onskatBelopp)
//    {
//        antalDagar++;
//        dagensLon = dagensLon * 2;
//        totalBelopp = totalBelopp + dagensLon;
//    }
//    Console.WriteLine($"Du blir rik efter {antalDagar} dagar");

//    // köra om
//    Console.Write("En till beräknig? (yes/no)");
//    val = Console.ReadLine();
//    // villkor för att stoppa loopen
//    if (val != "yes")
//    {
//        break;
//    }

//}

//// 5.8a

//Random rnd = new Random();

//    for (int varv = 0; varv < 100; varv++)
//    {
//        Console.WriteLine($"Varv {varv}: Slumptal {rnd.Next(1, 100)}");
//    }

//// 5.8b

//Random rnd = new Random();
//int varv = 0;
//while (varv < 100)
//{
//    Console.WriteLine($"Varv {varv++}: Slumptal {rnd.Next(1, 100)}");
//}

//// 5.8 c

//for (int varv = 0; varv < 50; varv++)
//{
//    Console.WriteLine($"Varv {varv+1}");
//    if ( varv == 24 )
//    { 
//        break;
//    }
//}


//// 5.8 d

//int summa = 0;
//for (int tal = 0; tal < 5; tal++)
//{

//    summa += tal;

//}

//Console.WriteLine($"{summa}");


//// 5.8 e test
//for (int i = 10; i > 0; i--)
//{
//    Console.WriteLine(i);
//}

//// 5.8 f test
//for (int i = 5; i <= 50; i = i + 5)
//{
//    Console.WriteLine(i);
//}


//// 5.8 g test
//Console.Write($"Loop starts at? ");
//int start = int.Parse(Console.ReadLine());


//Console.Write($"Loop ends at? ");
//int ends = int.Parse(Console.ReadLine());

//Console.Write($"Loop stage? ");
//int stage = int.Parse(Console.ReadLine());
//// custom loop
//for (int i = start; i <= ends; i = i + stage)
//{
//    Console.WriteLine(i);
//}


//// 5.9 a
//string[] namnlista = {"ofo", "bok", "lpi",
//                      "doo", "", "kgf",
//                      "", "ass","wtq", "yod" };
//int sakna = 0;
//for (int i = 0; i < namnlista.Length; i++)
//{

//    if (namnlista[i] == "") ;
//    {
//        sakna++;
//    }
//}
//Console.WriteLine($"Listan saknar: {sakna} namn");


//// 5.9 b
//int[] tal = new int[10];
//for (int i = 0; i < tal.Length; i++)
//{
//    Console.Write("Nummer? ");
//    tal[i] = int.Parse(Console.ReadLine());
//}
//Console.WriteLine("Inlästa talen:");
//for (int i = 0; i < tal.Length; ++i)
//    {
//    Console.WriteLine($"{tal[i]}");

//}

//// 5.9 c
//int[] tärning = new int[1000];

//Random rnd = new Random();

//for (int i = 0; i < tärning.Length; i++)
//{
//    tärning[i] = rnd.Next(1, 7);
//}

//int sexor = 0;
//for (int i = 0; i < tärning.Length; i++)
//{
//    if (tärning[i] == 6)
//    {
//        sexor++;
//    }
//}

//Console.WriteLine($"Det finns {sexor} stycken sexor");

// 5.10 

int[,] fyrkant1 = { };

if (fyrkant1 = fyrkant2 =)