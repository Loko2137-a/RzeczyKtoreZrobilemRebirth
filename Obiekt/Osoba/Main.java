class Osoba
{
    private int id;
    private String imie;
    private static int liczbaInstacji = 0;
    public Osoba()
    {
        id = 0;
        imie = "";
        liczbaInstacji++;
    }
    public Osoba(int id, String imie)
    {
        this.id = id;
        this.imie = imie;
        liczbaInstacji++;
    }
    public Osoba(Osoba other)
    {
        this.id = other.id;
        this.imie = other.imie;
        liczbaInstacji++;
    }
    public void Przywitanie(String imie)
    {
        if(this.imie.equals(" "))
        {
            this.imie = "Brak Danych";
        }
        System.out.println("Czesc " + imie + " Nazywam sie " + this.imie);
    }
}
class Main
{
    public static void main(String[] args)
    {
        Osoba o1 = new Osoba(0, "Maciej");
        Osoba o2 = new Osoba(o1);
        o1.Przywitanie("Lukasz");
        o2.Przywitanie("Marcel");
    }
}
