///to zadanko se po prostu tutaj przepisuje zeby se latwiej wypelnic karte, moze wrzuce roziwazana karte tez tu
class Zad1
{
    public static int skroc(int x)
    {
        return x/10;
    }
    public static int dopisz(int x)
    {
        return x*10;
    }
    public static int ostatnia(int x)
    {
        return x%10;
    }
    public static int f(int a ,int b)
    {
        if(b==0)
        {
            return 0;
        }
        int k = ostatnia(b);
        int w = f(a, skroc(b));
        w = dopisz(w);
        while(k > 0)
        {
            w+=a;
            k--;
        }
        return w;
    }
    public static void main(String[] args)
    {
        System.out.println();
    }
}
