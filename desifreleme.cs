using System.Numerics;

public class Desifreleme
{


    public long msgcozucu(long a, long b)
    {

        System.Console.WriteLine("sifreli metni cozmek icin sifrelenmis veriyi giriniz: ");
        long msg = Convert.ToInt64(Console.ReadLine());



        BigInteger sonucstr = BigInteger.Pow(msg, (int)a);
        



        BigInteger kalan = sonucstr % b;

        System.Console.WriteLine("sifresi cozulmus veriniz: {0}", kalan);
        return 0;
    }
}