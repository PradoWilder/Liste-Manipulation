namespace ManipulerListe
{
    using System;

    using System.Collections.Generic;


    public class StringListManipulation
    {
        public static void Main(string[] args)
        {
            // Déclaration et initialisation d'une liste de chaînes de caractères
            List<string> maListe = new List<string>() { "chaine1", "chaine2", "chaine3" };

            // Affichage de la liste initiale
            Console.WriteLine("Liste initiale: ");
            foreach (string element in maListe)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            // Suppression de la première chaîne avec RemoveAt([index])
            maListe.RemoveAt(0);

            // Affichage de la liste après la suppression
            Console.WriteLine("Liste après suppression de la première chaîne: ");
            foreach (string element in maListe)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            // Suppression de la troisième chaîne avec Remove([valeur])
            maListe.Remove("chaine3");

            // Affichage de la liste après la suppression
            Console.WriteLine("Liste après suppression de la troisième chaîne: ");
            foreach (string element in maListe)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            // Modification de la deuxième chaîne en utilisant son indice
            if(maListe.Count > 0)
            {
                maListe[0] = "chaine2_modifiée à afficher";
            }
            else
            {
                Console.WriteLine("La liste est vide");
            }

            // Affichage de la liste après la modification
            Console.WriteLine("Liste après modification de la deuxième chaîne: ");
            foreach (string element in maListe)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
