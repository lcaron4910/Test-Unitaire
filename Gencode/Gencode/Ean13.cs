using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gencode
{
    class Ean13
    {
        private int[] ean13;
        public Ean13(int[] ean13)
        {
            if (ean13.Length != 12)
            {
                throw new Exception("Un code Ean 13 doit être un tableau de 12 entiers");
            }
            this.ean13 = new int[12];
            int k = 0;
            foreach (int i in ean13)
            {
                if (i < 0 || i > 9)
                {
                    throw new Exception("un élément du gencode n'est pas compris entre 0 et 9");
                }
            }
            for (int i = 0; i < 12; i++)
            {
                this.ean13[i] = ean13[i];
            }
        }
        private int Poids(int indiceDepart)
        {
            int poids = 0;
            for (int i = indiceDepart; i < 12; i = i + 2)
            {
                poids = poids + this.ean13[i];
            }
            return poids;
        }
        public int PoidsPair()
        {
            return Poids(1)*3;
        }
        public int PoidsImpair()
        {
            return Poids(0)*1;
        }
        public int Reste()
        {
            int reste = (PoidsPair() + PoidsImpair()) % 10;
            return reste;
        }
        public int Cle()
        {
            int cle = 0;
            int reste = Reste();
            if (reste == 0)
            {
                cle = 0;
            }
            else
            {
                cle = 10 - reste;
            }
            return cle;
        }
        public override string ToString()
        {
            string s = "";
            for (int i = 1; i < 13; i++)
            {
                s += this.ean13[i-1];
                if ((i % 4) == 0)
                {
                    s += "-";
                }
            }
            s += Cle();
            return s;
        }
    }
}
