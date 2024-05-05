namespace Rsa_sifreleme;

public class tersMod
{

    public int tersmod(int sayi1, int sayi2)
    {

        static int findN(int x, int y)
        {


            System.Console.WriteLine("N = {0} (p * q)", (x * y));
            return (x * y);
        }

        Sifreleme S = new Sifreleme();
        Desifreleme D = new Desifreleme();

        int c, mod, sonuc = 0;
        long d = 1000000000000000000;
        Console.WriteLine("tersi olan sayiyi giriniz(e):");
        c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("mod değerini giriniz(r):");
        mod = Convert.ToInt32(Console.ReadLine());





        for (int i = 1; i <= d; i++)
        {

            if ((c * i) % mod == 1)
            {

                sonuc = i;

                Console.WriteLine("Sonuç:{0} (gizli anahtar)" , sonuc);

                break;

            }
        }
        S.msgbulucu(c, findN(sayi1, sayi2));
        D.msgcozucu(sonuc, findN(sayi1, sayi2));
        return 0;
    }
}




