/// to nie dziala nie chce mi se tego robic nawet
import java.util.Scanner;
class Ciag
{
    private double[] ciag;
    private int n;
    public Ciag()
    {

    }
    public void Wczytaj()
    {
        Scanner scan = new Scanner(System.in);
        System.out.print("Podaj dlugosc ciagu: ");
        n = scan.nextInt();
        for(int i = 0; i < n; i++)
        {
            System.out.print("Podaj wyraz do ciagu: ");
            ciag[i] = scan.nextInt();
        }
    }
    public boolean czyArytemtyczny()
    {
        double r = ciag[1] - ciag[0];
        for (int i = 0; i < ciag.length; i++)
        {
            if((ciag[i] + r) != ciag[i + 1])
            {
                return false;
            }
        }
        return true;
    }
    public boolean czyGeometryczny()
    {
        return true;
    }
}
class Main
{
    static void main()
    {

    }
}
