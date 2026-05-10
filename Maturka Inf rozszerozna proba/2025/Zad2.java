class Zad2
{
    public static void slice(int k)
    {
        int a, b, iloscCyfr, temp = k;
        while (temp>0)
        {
            temp/=10;
            iloscCyfr++;
        }
        a = k / 1000;
        b = k % 1000;
        System.out.println(a + " " + b);
    }
    public static void main(String[] args)
    {
        slice(12);
    }
}
