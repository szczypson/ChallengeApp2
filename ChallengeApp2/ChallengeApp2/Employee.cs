namespace ChallengeApp2
{
    public class Employee
    {
        private List<int> Punkty = new List<int>();
        public Employee(string Imię, string Nazwisko, int Wiek, int Punkty)
        {
            this.Imię = Imię;
            this.Nazwisko = Nazwisko;
            this.Wiek = Wiek;
        }
        public string Imię { get; private set; }
        public string Nazwisko { get; private set; }
        public int Wiek { get; private set; }

        public int punkty
        {
            get
           {
                return this.Punkty.Sum();
            }
        }

        public void AddPunkty(int number)
        {
            this.Punkty.Add(number);
        }
    }
}
