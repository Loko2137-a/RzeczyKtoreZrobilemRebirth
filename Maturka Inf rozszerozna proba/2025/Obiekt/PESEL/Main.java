import java.util.Scanner;
class Main
{
    public static char jakaPlec(char[] PESEL)
    {
        if((PESEL[9] - '0') % 2 == 0)
        {
            return 'K';
        }
        return 'M';
    }
    public static boolean czyPrawidlowy(char[] PESEL)
    {
        if (PESEL.length != 11) return false;
        int[] wagi = {1,3,7,9,1,3,7,9,1,3};
        int suma = 0;
        for(int i = 0; i < 10; i++)
        {
            suma += (PESEL[i] - '0') * wagi[i];
        }
        int kontrolna = (10 - (suma % 10)) % 10;
        return kontrolna == (PESEL[10] - '0');
    }
    public static void main(String[] args)
    {
        String sPlec, sPESEL;
        Scanner scan = new Scanner(System.in);
        System.out.print("Podaj pesel: ");
        sPESEL = scan.nextLine();
        scan.close();
        char[] PESEL = sPESEL.toCharArray();
        char plec = jakaPlec(PESEL);
        if(plec == 'K')
        {
            sPlec = "Kobieta";
        }
        else
        {
            sPlec = "Mezczyzna";
        }
        System.out.println("Plec: " + sPlec);
        if(czyPrawidlowy(PESEL))
        {
            System.out.println("Prawidłowy PESEL!");
        }
        else
        {
            System.out.println("Nieprawidłowy PESEL!");
        }
    }
}
