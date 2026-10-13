//Creator : Mia Lassine 107B
//Date : 13/10/2026
//Programme : Ex N°1 Boucle

namespace Boucles;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */

        // Etape 1 : faire un compteur qui va de 1 à 10

        Console.WriteLine("Compteur 1 : ");
        for (int c = 1;c<=10;c++)
        {
            Console.WriteLine("Ligne " + c);
        }
        Console.WriteLine("------------------------");

        // Etape 2 : faire un décompte qui va de 5 à 1 puis qui dit "Bonne année !"

        Console.WriteLine("\n------------------------");
        Console.WriteLine("Compteur 2 : ");
        for (int c = 5; c > 0;c--)
        {
            Console.WriteLine(c);
        }
        Console.WriteLine("Bonne année !");
        Console.WriteLine("------------------------");

        // Etape 3 : faire un compteur qui va de -4 à 2

        Console.WriteLine("\n------------------------");
        Console.WriteLine("Compteur 3 : ");
        for (int c = -4; c <= 2; c++)
        {
            Console.WriteLine("Ligne " + c);
        }
        Console.WriteLine("------------------------");

        // Etape 4 : faire un compteur qui compte 2 par 2 de 0 à 15

        Console.WriteLine("\n------------------------");
        Console.WriteLine("Compteur 4 : ");
        for (int c = 0; c < 15; c = c + 2)
        {
            Console.WriteLine("Ligne " + c);
            if(c == 14)
            {
                c = 15;
                Console.WriteLine("Ligne " + c);
            }
        }
        Console.WriteLine("------------------------");

        // Etape 5 : faire une boucle qui se répète à chaque fois que l'utilisateur écrit autre chose que "oui"

        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}