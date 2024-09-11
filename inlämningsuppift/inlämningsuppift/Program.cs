//uppgift a

Console.WriteLine("Hur mycket pengar vill du ta ut?");

string uttag;
uttag = Console.ReadLine();
int uttag2 = int.Parse(uttag);
int belopp = uttag2 / 100 * 100;

Console.WriteLine("Uttag: " + belopp + " kr");


// uppgift b

Console.WriteLine("Hur mycket pengar vill du ta ut?");
string mängd;
mängd = Console.ReadLine();
int mängd2 = int.Parse(mängd);
int m5 = (mängd2 / 500) * 500;
int m1 = (mängd2 / 100) * 100;
int belopp2 = m1 - m5;
Console.WriteLine("Uttag i 500 lappar: " + m5);
Console.WriteLine("Uttag i 100 lappar: " + belopp2);

// uppgift 2

Console.Write("Ange ett tecken ");
char tecken = Console.ReadLine()[0];
Console.WriteLine($"{tecken}\n{tecken} {tecken}\n{tecken} {tecken} {tecken}\n{tecken} {tecken} {tecken} {tecken}");





