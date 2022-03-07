using System;

namespace Kollitoo
{
    class Program
    {

        static void Main(string[] args)
        {
            Nelinurk a = new Nelinurk();
            a.Korgus = int.Parse(Console.ReadLine());
            a.Laius = int.Parse(Console.ReadLine());
            
            a.Umbermoot();
            a.Pindala();
        }
        

    }
}
