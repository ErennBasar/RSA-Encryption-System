using System.Diagnostics.Contracts;
using System.Text.RegularExpressions;

namespace Rsa_sifreleme;

public class Program
{


    public static void Main(string[] args)
    {

        tersMod M = new tersMod();



        System.Console.WriteLine("p asal sayisini giriniz:");
        int a = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("q asal sayisini giriniz:");
        int b = Convert.ToInt32(Console.ReadLine());


        findR(a, b);



        static int findR(int x, int y)
        {

            System.Console.WriteLine("(totient degeri)r = {0}", (x - 1) * (y - 1));
            return (x - 1) * (y - 1);
        }


        M.tersmod(a, b);
        Console.ReadLine();
    }


}

