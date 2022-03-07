using System;
using System.Collections.Generic;
using System.Text;

namespace Kollitoo
{
    class Nelinurk
    {
        int korgus;
        int laius;
        Tuup tuup;
     

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

        public string Figura
        {
            get
            {
                var figura = "";
                if (Korgus==Laius)
                {
                    figura = "ruud";
                }
                else
                {
                    figura = "ristkülik";
                }
                return figura;
            }
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
            Console.WriteLine($"Se on {Figura} ");
        }
    }
}

    

