using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuAgratter
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("Combien de tirage ?");
            //  int i = Convert.ToInt32(Console.ReadLine());
            Jeu jeu1 = new Jeu(new int[3,3]);
            jeu1.grille();
            Console.WriteLine(jeu1.ToString());
            Console.WriteLine(jeu1.Gagne());

            Console.ReadLine();
        }
    }
    
}
