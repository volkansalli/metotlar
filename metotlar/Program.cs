using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=3;
            int b=4;

            Console.WriteLine("düz main classının altına yazılan fonksiyon/metot");
            Console.WriteLine(topla(a,b));

            Console.WriteLine(" Kendi olusturduğumuz Benimmetotlar classının altına yazılan fonksiyon/metot");
             Benimmetotlar volki=new Benimmetotlar();
             volki.ekranayazdir(Convert.ToString((a+b))); 

             Console.WriteLine(" Kendi olusturduğumuz Benimmetotlar classının altına yazılan ref li fonksiyon");
            int sonuc=volki.arttirvetopla(ref a,ref b);
            volki.ekranayazdir(Convert.ToString(sonuc));
            volki.ekranayazdir(Convert.ToString((a+b)));
        }
        static int topla(int x, int y){
            return x+y;
        }
    }
    class Benimmetotlar{
        
        public void ekranayazdir(string veri){
            Console.WriteLine(veri);
        }

        public int arttirvetopla(ref int a,ref int b){
            a++;
            b++;
            return a+b;
        }
    }
}
