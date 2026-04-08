import java.util.Scanner;
class Main
{
    public static void losujTablice(int[] tablicaLiczb)
    {
        for(int i = 0; i < tablicaLiczb.length -1; i++)
        {
            tablicaLiczb[i] = (int)(Math.random()*100);
        }
    }
    public static void wyszukaj(int szukana, int[] tablicaLiczb)
    {
        int index;
        tablicaLiczb[tablicaLiczb.length - 1] = szukana;
        for(int i = 0; i < tablicaLiczb.length; i++)
        {
            if(tablicaLiczb[i] == szukana)
            {
                if(i == 50)
                {
                    System.out.println("Nie ma tej liczby");
                }
                else
                {
                    index = i;
                    System.out.println("Znaleziono liczbe " + szukana + " na indexie " + index);
                    break;
                }
                break;
            }
        }
    }
    public static void wyswietl(int[] tablicaLiczb)
    {
        for(int liczba: tablicaLiczb)
        {
            System.out.print(liczba+ ", ");
        }
    }
    public static void main(String[] args)
    {
        Scanner scan = new Scanner(System.in);
        int szukana;
        System.out.print("Podaj szukaną liczbe: ");
        szukana = scan.nextInt();
        scan.close();
        int[] tablicaLiczb = new int[51];
        losujTablice(tablicaLiczb);
        wyszukaj(szukana, tablicaLiczb);
        wyswietl(tablicaLiczb);
    }
}
