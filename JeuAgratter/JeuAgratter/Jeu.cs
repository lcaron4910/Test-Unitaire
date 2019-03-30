using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuAgratter
{
    public class Jeu
    {

        Random rnd = new Random();
        int[,] carte = new int[3,3];
        int s;
        int i = 0;
        string resultat;
        public Jeu(int[,] carte)
        {
            this.carte = carte;
        }
        public int Gagne()
        {
            int somme1 = 0, somme2 = 0, somme3 = 0;
            for (int ligne = 0; ligne < 3; ligne++)
            {
                for (int colonne = 0; colonne < 3; colonne++)
                {
                    switch (carte[ligne, colonne])
                    {
                        case 1:
                            somme1 += 1;
                            break;
                        case 2:
                            somme2 += 1;
                            break;
                        case 3:
                            somme3 += 1;
                            break;
                    }
                    if (colonne == 2)
                    {
                        if (carte[ligne, colonne] == carte[ligne, colonne - 1] && carte[ligne, colonne] == carte[ligne, colonne - 2])
                        {
                            return 100;
                        }
                    }
                    if (ligne == 2)
                    {
                        if (carte[ligne, colonne] == carte[ligne - 1, colonne] && carte[ligne - 1, colonne] == carte[ligne - 2, colonne])
                        {
                            return 100;
                        }
                    }
                    if (ligne == 2)
                    {
                        if (colonne == 0)
                        {
                            if (carte[ligne, colonne] == carte[ligne - 1, colonne + 1] && carte[ligne, colonne] == carte[ligne - 2, colonne + 2])
                            {
                                return 100;
                            }
                        }
                        if (colonne == 2)
                        {
                            if (carte[ligne, colonne] == carte[ligne - 1, colonne - 1] && carte[ligne, colonne] == carte[ligne - 2, colonne - 2])
                            {
                                return 100;
                            }
                        }
                    }
                }
                
            }
            if (somme1 >= 6 || somme2 >= 6 || somme3 >= 6)
            {
                return 50;
            }
            return 0;

        }
        public void grille()
        {
            for (int ligne = 0; ligne < 3; ligne++)
            {
                for (int colonne = 0; colonne < 3; colonne++)
                {
                    int remplissage = rnd.Next(1, 4);
                    i++;
                    carte[ligne, colonne] = remplissage;
                }
            }
            
        }
        public override string ToString()
        {
            int k = 0;
            for (int ligne = 0; ligne < 3; ligne++)
            {
                
                for (int colonne = 0; colonne < 3; colonne++)
                {
                    k++;
                    s = carte[ligne, colonne];
                    if (k <= 3 && k >=3 || k <= 6 && k >= 6)
                    {
                        resultat = resultat + Convert.ToString(s)+"\n";
                    }
                    else
                    {
                        resultat = resultat + Convert.ToString(s);
                    }
                    
                }
            }
            return resultat;
        }

    }
}
