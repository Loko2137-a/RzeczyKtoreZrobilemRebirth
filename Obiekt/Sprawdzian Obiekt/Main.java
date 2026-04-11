import java.util.Scanner;
class Main
{
    public static int[] Sortowanie(int[] tablicaLiczb, int n)
    {
        int i = 1;
        while(i < n)
        {
            int j = i -1;
            int temp = tablicaLiczb[i];
            while(j >= 0 && tablicaLiczb[j] > temp)
            {
                tablicaLiczb[j+1] = tablicaLiczb[j];
                j--;
            }
            tablicaLiczb[j + 1] = temp;
            i++;
        }
        return tablicaLiczb;
    }
    public static void main(String[] args)
    {
        int n;
        Scanner scan = new Scanner(System.in);
        System.out.print("Podaj ilosc elementow tablicy: ");
        n = scan.nextInt();
        int[] tablicaLiczb = new int[n];
        for(int i = 0; i < n; i++)
        {
            System.out.print("Podaj liczbe: ");
            tablicaLiczb[i] = scan.nextInt();
        }
        int[] posortowana = Sortowanie(tablicaLiczb, n);
        for (int liczba: posortowana)
        {
            System.out.print(liczba + " ");
        }
    }
}
