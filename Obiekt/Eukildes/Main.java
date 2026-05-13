import java.util.Scanner;
class Main
{
    public static int NWD(int a, int b)
    {
        while(a!=b)
        {
            if(a>b)
            {
                a-=b;
            }
            else
            {
                b-=a;
            }
        }
        return a;
    }
    public static void main(String[] args)
    {
        Scanner scan = new Scanner(System.in);
        int a,b;
        System.out.print("Podaj a:");
        a = scan.nextInt();
        System.out.print("Podaj b:");
        b = scan.nextInt();
        scan.close();
        int nwd = NWD(a,b);
        System.out.println("NWD(" + a + ", " + b + "): " + nwd);
    }
}
