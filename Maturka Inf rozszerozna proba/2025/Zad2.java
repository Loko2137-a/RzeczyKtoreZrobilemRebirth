class Zad2
{
    public static void slice(int k)
    {
        int a, b, iloscCyfr, temp = k;
        iloscCyfr = 0;
        while (temp>0)
        {
            temp/=10;
            iloscCyfr++;
        }
        if(iloscCyfr % 2 == 0) return;
        int polowa = iloscCyfr/2;
        int potega = 1;
        int i = 0;
        while(i < polowa)
        {
            potega*=10;
            i++;
        }
        a = k / potega;
        b = k % potega;
        System.out.println(a + " " + b);
    }
    public static void main(String[] args)
    {
        slice(120056);
    }
}
