using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime;
using System.Xml.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static int DemanderTemps()
        {
            int time = 0;

            while (time == 0)
            {
                Console.Write("\nCombien de mois envisagez-vous de faire la formation ? ");
                string newtime = Console.ReadLine();

                    time = int.Parse(newtime);

                if (time < 0)
                {
                    Console.WriteLine("Erreur : le nombre de mois doit être supérieur à 1");
                }
            }
            return time;
        }

        static int DemanderArgent()
        {
            int money = 0;

            while (money <= 1000)
            {
                Console.Write("\nQuel est votre budget en euro ? ");
                string newmoney = Console.ReadLine();

                money = int.Parse(newmoney);

                if (money <= 1000)
                {
                    Console.WriteLine("Erreur : le budget est de minimum 1000 euros");
                }
            }
            return money;
        }

        static int DemanderLongueur()
        {
            int longueur = 0;

            Console.Write("\nEntrer la longueur du rectangle (en cm) : ");
            string lg = Console.ReadLine();

            longueur = int.Parse(lg);

            return longueur;
        }

        static int DemanderLargeur()
        {
            int largeur = 0;

            Console.Write("\nEntrer la largeur du rectangle (en cm) : ");
            string larg = Console.ReadLine();

            largeur = int.Parse(larg);

            return largeur;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour et bienvenue à la Coding Academy !\n");
            Console.WriteLine("Afin de bien vous orienter, veuillez répondre aux questions suivantes :");

            bool test = false;

            while (true)
            {
                int time = DemanderTemps();

                Console.WriteLine($"\nVous avez choisi de faire {time} mois de formation");

                int money = DemanderArgent();

                Console.WriteLine($"\nVotre budget est de {money} euros");

                if (time >= 6 && money > 5000)
                {
                    Console.WriteLine("\nSelon vos critères, vous décider de faire une Grande formation");
                    break;
                }
                else if (time < 6 && money <= 5000)
                {
                    Console.WriteLine("\nSelon vos critères, vous décider de faire une petite formation");
                    break;
                }
                else
                {
                    test = !test;
                    Console.WriteLine("\nFormation non valide");
                    Console.WriteLine("\nVeuillez rentrer des informations valide afin de pouvoir continuer");
                }
            }

            Console.WriteLine("\nBien joué ! Vous avez saisis les bonnes informations !");

            Console.WriteLine("\nAfin de valoriser le code de cette appli nous allons calculer l'air et le périmètre d'un parallépipède");

            int longueur = DemanderLongueur();

            int largeur = DemanderLargeur();

            int air = longueur * largeur;

            int perimetre = (longueur + largeur) * 2;

            Console.WriteLine($"\nLe périmètre du rectangle est de {perimetre} cm2 et l'air est de {air} cm2 ");

            Console.WriteLine("\nOK ! Très bien ! Enfin pour finaliser passons à la dernière étape");

            Console.WriteLine("\nNous allons chercher à trouver un nombre dans une liste et calculer la somme de tous les nombres de celle-ci");

            List<int> list = new List<int>();

            Console.WriteLine("\nEntrer différents nombres entiers positifs");

            Console.Write("\nPremier nombre positif : ");

            int nb = int.Parse(Console.ReadLine());
            list.Add(nb);

            Console.Write("Deuxième nombre positif : ");

            int nb2 = int.Parse(Console.ReadLine());
            list.Add(nb2);

            Console.Write("Troisième nombre positif : ");

            int nb3 = int.Parse(Console.ReadLine());
            list.Add(nb3);

            foreach (int i in list) ;

            int somme = nb + nb2 + nb3;

            string str = "The greater of {list}.";

            //int SommeTotale = max + somme;

            Console.WriteLine($"La somme de la liste est égal à {somme}");

            //Console.WriteLine(str, nb, nb2, nb3, Math.Max(nb, nb2, nb3));

            //Console.WriteLine($"Voici la somme de tout les nombre : {SommeTotale}");
        }
    }
}