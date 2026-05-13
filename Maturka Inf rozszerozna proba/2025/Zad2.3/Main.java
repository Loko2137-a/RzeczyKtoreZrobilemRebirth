import java.util.Scanner;
import java.io.IOException;
import java.io.File;
import java.io.FileWriter;
public class Main
{
    public static int SliceA(int k, int j)
    {
        int a;
        int potega = 1;
        int i = 0;
        while(i < j)
        {
            potega*=10;
            i++;
        }
        a = k / potega;
        return a;
    }
    public static int SliceB(int k, int j)
    {
        int b;
        int potega = 1;
        int i = 0;
        while(i < j)
        {
            potega*=10;
            i++;
        }
        b = k % potega;
        return b;
    }
    public static void main(String[] args)
    {
        int Maxstopien = -1;
        int Najliczba = 0;
        try
        {
            File plik = new File("liczby2.txt");
            Scanner Reader = new Scanner(plik);
            FileWriter writer = new FileWriter("Wynik.txt");
            while(Reader.hasNextInt())
            {
                int stopien = 0;
                int n = Reader.nextInt();
                int i = 0;
                int n2 = n * n;
                int temp = n2;
                while(temp > 0)
                {
                    temp/=10;
                    i++;
                }
                for(int j = 1;  j<i ;j++)
                {
                    int a = SliceA(n2, j);
                    int b = SliceB(n2, j);
                    if(a + b <= n)
                    {
                        stopien++;
                    }
                }
                if(stopien > Maxstopien)
                {
                    Maxstopien= stopien;
                    Najliczba = n;
                }
            }
            writer.write(String.valueOf(Najliczba) + "\n");
            writer.write(String.valueOf(Maxstopien));
            writer.close();
            Reader.close();
        }
        catch(IOException e)
        {
            System.out.print(e);
        }
    }
}
