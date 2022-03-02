using System;
using System.Collections.Generic;
using System.Text;

namespace Kollitoo
{
    class Nelinurk
    {
        int korgus;
        int laius;

     

        public int Korgus
        {
            set
            {
                 korgus = value;
            }
            get { return korgus; }
        }
        public int Laius
        {
            set
            {
                laius = value;
            }
            get { return laius; }
        }

        

        public void Umbermoot()
        {
            int a = korgus;
            int b = laius;
            int c = (a + b) * 2;
            Console.WriteLine($"Minu ümbermõõt on {c} ");
        }

        public void Pindala()
        {
            int a = korgus;
            int b = laius;
            int c = (a * b) ;
            Console.WriteLine($"Minu pindala on {c} ");
        }
    }
}

    

