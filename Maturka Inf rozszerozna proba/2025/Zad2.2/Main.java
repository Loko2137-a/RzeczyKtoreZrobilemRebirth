import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
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
    public static int SliceA(int k)
    {
        int a, iloscCyfr, polowa, temp = k;
        iloscCyfr = 0;
        polowa = 0;
        while(temp > 0)
        {
            temp/=10;
            iloscCyfr++;
        }
        if(iloscCyfr%2!=0) return -1;
        polowa = iloscCyfr/2;
        int potega = 1;
        int i = 0;
        while(i < polowa)
        {
            potega*=10;
            i++;
        }
        a = k / potega;
        return a;
    }
    public static int SliceB(int k)
    {
        int b, iloscCyfr, polowa, temp = k;
        iloscCyfr = 0;
        polowa = 0;
        while(temp > 0)
        {
            temp/=10;
            iloscCyfr++;
        }
        if(iloscCyfr%2!=0) return -1;
        polowa = iloscCyfr/2;
        int potega = 1;
        int i = 0;
        while(i < polowa)
        {
            potega*=10;
            i++;
        }
        b = k % potega;
        return b;
    }
    public static void main(String[] args)
    {
        int IloscLiczb = 0;
        try
        {
            File plik = new File("liczby1.txt");
            FileWriter writer = new FileWriter("Wynik.txt");
            Scanner Reader = new Scanner(plik);
            while (Reader.hasNextInt())
            {
                int k = Reader.nextInt();
                int a = SliceA(k);
                int b = SliceB(k);
                if(NWD(a,b) == 1)
                {
                    IloscLiczb++;
                }
            }
            writer.write(String.valueOf(IloscLiczb));
            Reader.close();
            writer.close();
        }
        catch(IOException e)
        {
            System.out.println(e);
        }

    }
}
