class Main
{
    public static void Sito(boolean[] tablicaWartosci)
    {
        int n = tablicaWartosci.length;
        tablicaWartosci[0] = false;
        tablicaWartosci[1] = false;
        for(int i = 2; i < Math.sqrt(n); i++)
        {
            if(tablicaWartosci[i] == true)
            {
                for(int j = 2*i; j < n; j+=i)
                {
                    tablicaWartosci[j] = false;
                }
            }
        }
    }
    public static void Wypelnij(boolean[] tablicaWartosci)
    {
        for(int i = 0; i < tablicaWartosci.length; i++)
        {
            tablicaWartosci[i] = true;
        }
    }
    public static void Wyswietl(boolean[] tablicaWartosci)
    {
        for(int i = 0; i < tablicaWartosci.length; i++)
        {
            if(tablicaWartosci[i])
            {
                System.out.println(i + " jest liczba pierwsza");
            }
            else
            {
                System.out.println(i + " nie jest liczba pierwsza");
            }
        }
    }
    public static void main(String[] args)
    {
        boolean[] A = new boolean[100];
        Wypelnij(A);
        Sito(A);
        Wyswietl(A);
    }
}
