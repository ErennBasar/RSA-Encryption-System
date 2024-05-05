
using System.Net.Sockets;
using System.Numerics;

public class Sifreleme
{


    public long msgbulucu(long a, long b)
    {

        System.Console.WriteLine("sifrelenecek veriyi giriniz: ");

        
        long msg = Convert.ToInt64(Console.ReadLine());




        BigInteger sonucstr = BigInteger.Pow(msg, (int)a);

        


        BigInteger kalan = sonucstr % b;

        System.Console.WriteLine("sifrelenmis veriniz: {0}", kalan);
        return 0;
    }
}