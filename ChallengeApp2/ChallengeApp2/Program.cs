using ChallengeApp2;

Employee pracownik1 = new Employee("Adam", "Gozdek", 33, 0);
Employee pracownik2 = new Employee("Monika", "Kwiatek", 23, 0);
Employee pracownik3 = new Employee("Zuzia", "Kowalska", 24, 0);
Employee pracownik4 = new Employee("Damian", "Damianowski", 34, 0);
Employee pracownik5 = new Employee("Przemek", "Szczypkowski", 46, 0);

pracownik1.AddPunkty(5);
pracownik1.AddPunkty(2);
pracownik1.AddPunkty(1);
pracownik1.AddPunkty(2);
pracownik1.AddPunkty(1);

pracownik2.AddPunkty(2);
pracownik2.AddPunkty(5);
pracownik2.AddPunkty(9);
pracownik2.AddPunkty(5);
pracownik2.AddPunkty(9);

pracownik3.AddPunkty(10);
pracownik3.AddPunkty(1);
pracownik3.AddPunkty(1);
pracownik3.AddPunkty(1);
pracownik3.AddPunkty(1);

pracownik4.AddPunkty(6);
pracownik4.AddPunkty(4);
pracownik4.AddPunkty(7);
pracownik4.AddPunkty(2);
pracownik4.AddPunkty(9);

pracownik5.AddPunkty(3);
pracownik5.AddPunkty(2);
pracownik5.AddPunkty(9);
pracownik5.AddPunkty(9);
pracownik5.AddPunkty(9);

List<Employee> lista_pracownikow = new List<Employee>()
{
pracownik1, pracownik2, pracownik3, pracownik4, pracownik5
};

int maxResult = -1;
Employee userWithMaxResult = null;

foreach (var pracownik in lista_pracownikow)
{
    if (pracownik.punkty > maxResult)
    {
        maxResult = pracownik.punkty;
        userWithMaxResult = pracownik;
    }
}

Console.WriteLine("Pracownik z najwyższą liczbą ocen to: ");
Console.WriteLine(userWithMaxResult.Imię + " " + userWithMaxResult.Nazwisko);
Console.WriteLine("Wiek: " + userWithMaxResult.Wiek + "  Punkty: " + userWithMaxResult.punkty);
