import java.util.Scanner;
class Sortowanie
{
    private int[] tablicaLiczb = new int[10];
    public void WypelnijTablice()
    {
        Scanner scan = new Scanner(System.in);
        for(int i = 0; i < tablicaLiczb.length; i++)
        {
            System.out.print("Podaj liczbe: ");
            tablicaLiczb[i] = scan.nextInt();
        }
        scan.close();
    }
    private int znajdzMax(int start)
    {
        int max = start;
        for(int i = start + 1; i < tablicaLiczb.length; i++)
        {
            if(tablicaLiczb[i] > tablicaLiczb[max])
            {
                max = i;
            }
        }
        return max;
    }
    public void sortowanie()
    {
        for(int i = 0; i< tablicaLiczb.length; i++)
        {
            int maxIndex = znajdzMax(i);
            int temp = tablicaLiczb[i];
            tablicaLiczb[i] = tablicaLiczb[maxIndex];
            tablicaLiczb[maxIndex] = temp;
        }
    }
    public void Wyswielt()
    {
        for(int liczba: tablicaLiczb)
        {
            System.out.print(liczba + " ");
        }
    }
}
class Main
{
    public static void main(String[] Args)
    {
        Sortowanie sortowanie1 = new Sortowanie();
        sortowanie1.WypelnijTablice();
        sortowanie1.Wyswielt();
        System.out.println();
        sortowanie1.sortowanie();
        sortowanie1.Wyswielt();
    }
}
