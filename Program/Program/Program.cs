string imie = "Anna";
char plec = 'k';
int wiek = 28;

if ((plec == 'k') && (wiek < 30))
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}

if ((imie == "Ewa") && (wiek == 30))
{
    Console.WriteLine("Ewa, lat 30");
}

if ((plec == 'm') && (wiek < 18))
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}