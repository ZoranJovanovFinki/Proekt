using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Grafika
{

    public class Mreza
    {
        public int[] indeks = new int[60];
        public Point[] tck = new Point[60];
        public bool[] tocno = new bool[60];

        public Mreza ()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    indeks[10 * i + j] = 10 * i + j;
                    tck[10 * i + j] = new Point((j) * 50, (i) * 50);
                    tocno[10 * i + j] = false;
                }
            }
        }

        public Rectangle[] pretvori()
        {
            Rectangle[] prati = new Rectangle[60];
            Size koc1 = new Size(50,50);

            for (int n = 0; n < 60; n++)
            {
                prati[n] = new Rectangle( tck[n], koc1 );
            }
            return prati;
        }

        public bool kontrola(Mreza mreza)
        {
            bool nov = true;
            for (int i = 0; i < 60; i++)
            {
                if ((this.tocno[i] == true) && (mreza.tocno[i] == true))
                {
                    nov = false;
                }
            }
            return nov;
        }
    }



    public class Blok
    {
        public int[] index = new int[5];
        public Point[] parce = new Point[5];

        public Blok(int[] indx, Mreza ipsilon)
        {
            for (int d = 0; d < 5; d++)
            {
                index[d] = indx[d];
                parce[d] = ipsilon.tck[index[d]];
            }
        }

        public Rectangle[] nizaPravoagolnici(Blok tvor)
        {
            Rectangle[] niz = new Rectangle[5];
            Size koco = new Size(50,50);
            for (int i = 0; i < 5; i++)
            {
                niz[i] = new Rectangle(tvor.parce[i], koco);
            }
            return niz;
        }
    }
}
