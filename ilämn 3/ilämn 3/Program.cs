// inlämningsuppgift 3

Console.WriteLine("Vilket klockslag börjar evenemagnet?(0-23)");
int timmar = int.Parse(Console.ReadLine());

Console.WriteLine("Vilket minut börjar evenemanget(0-59)?");
int minuter = int.Parse(Console.ReadLine());

Console.WriteLine("Hur lång tid är evenenmanget?(I minuter)");
int tiden = int.Parse(Console.ReadLine());

int tim = (minuter + tiden) / 60;
int min = (minuter + tiden) % 60;

int Antaltimmar = timmar + tim;

int tim2 = Antaltimmar / 24;
int total = Antaltimmar - 24 * tim2;
Console.WriteLine($"{total}:{min}"); 

