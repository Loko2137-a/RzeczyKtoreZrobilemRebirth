import java.util.Random;
class Tablica
{
    private int[] tablicaLiczb;
    private int iloscElementow;
    public Tablica(int iloscElementow)
    {
        Random rand = new Random();
        this.iloscElementow = iloscElementow;
        this.tablicaLiczb = new int[iloscElementow];
        for(int i = 0; i < iloscElementow; i++)
        {
            this.tablicaLiczb[i] = rand.nextInt(1000) + 1;
        }
    }
    public void wyswietl()
    {
        for(int i = 0; i < tablicaLiczb.length;i++)
        {
            System.out.println(i + " " + tablicaLiczb[i]);
        }
    }
    public int wyszkukaj(int szukana)
    {
        for(int i = 0; i < tablicaLiczb.length; i++)
        {
            if(tablicaLiczb[i] == szukana)
            {
                return i;
            }
        }
        return -1;
    }
    public int policzNieparzyste()
    {
        int iloscNieparzystych = 0;
        for(int i = 0; i < tablicaLiczb.length; i++)
        {
            if(!(i % 2 == 0))
            {
                System.out.println(tablicaLiczb[i] + " jest nieparzyste");
                iloscNieparzystych++;
            }
        }
        return iloscNieparzystych;
    }
    public int policzSrednia()
    {
        int srednia;
        int suma = 0;
        for(int i = 0; i < tablicaLiczb.length; i++)
        {
            suma+=tablicaLiczb[i];
        }
        srednia = suma / tablicaLiczb.length;
        return srednia;
    }
}

class Main
{
    public static void main(String[] args)
    {
        Tablica tablica1 = new Tablica(100);
        tablica1.wyswietl();
        System.out.println("Ilosc nieparzystych: " + tablica1.policzNieparzyste());
        System.out.println("Srednia: "+tablica1.policzSrednia());
    }
}
