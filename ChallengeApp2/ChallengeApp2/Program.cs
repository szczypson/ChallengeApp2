var imie = "Ewa";
var isMale = false;
var wiek = 33;

if (wiek < 30 && isMale == false)
{
    Console.WriteLine("Kobieta, poniżej lat 30");
}
else if (wiek == 33 && imie == "Ewa" && isMale == false)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (wiek < 18 && isMale == true)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else if (wiek == 46 && isMale == true && imie == "Przemek")
{
    Console.WriteLine("Przemek, lat 46");
}
