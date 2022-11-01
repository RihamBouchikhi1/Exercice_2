using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[] tab = new int[6];
            tab[0] = 2;
            tab[1] = 3;
            tab[2] = 4;
            tab[3] = 7;
            tab[4] = 10;

            afficher(tab);
            Console.WriteLine("entrez un nombre ");
            N = int.Parse(Console.ReadLine());
            Inserer(tab, N);
            afficher(tab);
        }

        public static void Inserer(int[] tab, int NB)
        {
            int pos = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] >= NB)
                    pos = i;
                break;

            }
            for (int j = pos; j < tab.Length; j++)
            {
                tab[j + 1] = tab[j];
            }
            tab[pos] = NB;
        }



        public static void afficher(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);

            }
        }

    }

}
