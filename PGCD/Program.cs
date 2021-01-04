using System;

namespace PGCD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calcul du PGCD de deux nombres (Méthode d'Euclide)";

            Console.Write("Entrez le premier nombre : ");
            var nbre1 = int.Parse(Console.ReadLine());

            Console.Write("Entrez le second nombre : ");
            var nbre2 = int.Parse(Console.ReadLine());

            Console.WriteLine("pgcd({0};{1}) = {2}", nbre1, nbre2, pgcd(nbre1, nbre2));
        }

        static int pgcd(int x, int y)
        {
            if (x < y)
            {
                int r;
                do
                {
                    r = x % y;
                    x = y;
                    y = r;
                } while (r != 0);
                return x;
            }
            else
            {
                Console.WriteLine("Opération impossible - Valeur Nulle");
                return 0;
            }
        }
    }
}
