import java.util.Random;
import java.util.Scanner;
class Main
{
    public static int podliczPunkty(int[] tablicaLiczbZKostek)
    {
        int iloscPunktow = 0;
        for(int i = 1;  i <= 6; i++)
        {
            int IloscWystapien = 0;
            for(int j = 0; j < tablicaLiczbZKostek.length; j++)
            {
                if(tablicaLiczbZKostek[j] == i)
                {
                    IloscWystapien++;
                }
            }
            if(IloscWystapien > 1)
            {
                iloscPunktow += i * IloscWystapien;
            }
        }
        return iloscPunktow;
    }
    public static int[] wylosujKostke(int IloscKostek)
    {
        Random rand = new Random();
        int[] tablicaLiczbZkostek = new int[IloscKostek];
        for(int i = 0; i < IloscKostek; i++)
        {
            tablicaLiczbZkostek[i] = rand.nextInt(6) + 1;
        }
        return tablicaLiczbZkostek;
    }
    public static void main(String[] args)
    {
        Scanner scan = new Scanner(System.in);
        char odp;
        int IloscKostek;
        boolean jeszczeRaz = true;
        System.out.print("Ile kostek chcesz rzucic(3 - 10)");
        IloscKostek = scan.nextInt();
        while(IloscKostek < 3 || IloscKostek > 10 )
        {
            System.out.print("Ile kostek chcesz rzucic(3 - 10)");
            IloscKostek = scan.nextInt();
        }
        while(jeszczeRaz)
        {
            int[] kostki = wylosujKostke(IloscKostek);
            int iloscPunktow = podliczPunkty(kostki);
            for(int i = 0; i < kostki.length; i++)
            {
                int index = i + 1;
                System.out.println("Kostka " + index + ": " + kostki[i]);
            }
            System.out.println("Liczba uzyskanych punktów: " + iloscPunktow);
            System.out.println("Jeszcze raz?");
            odp = scan.next().charAt(0);
            if(odp == 'n')
            {
                jeszczeRaz = false;
            }
        }
    }
}
