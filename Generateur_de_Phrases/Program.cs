using System;
using System.Collections.Generic;

namespace Generateur_de_Phrases
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sujet - verbe - complement
            var sujets = new string[] { "Une voiture", "Un homme", "Un chat", "Un titan", "Un Magicien", "Une femme", "Un soldat" };
            var verbes = new string[] { "mange", "écrase", "détruit", "avale", "observe", "néttoie", "s'accroche à", "se bat avec", "attrape", "regarde" };
            var cod = new string[] { "un arbre", "un equipement", "le soleil", "le mur", "le ciel", "une souris", "un livre", "une carte", "la lune", "un crapaud" };

            const int nb_phrases = 100;
            var phrasesUniques = new List<string>();
            int doublonsEvites = 0;

            while (phrasesUniques.Count<nb_phrases)
            {
                var sujet = obtenirElementAleatoire(sujets);
                var verbe = obtenirElementAleatoire(verbes);
                var cods = obtenirElementAleatoire(cod);

                var phrase = sujet + " " + verbe + " " + cods + ".";
                phrase = phrase.Replace("à le", "au");

                if (!phrasesUniques.Contains(phrase))
                {
                    phrasesUniques.Add(phrase);
                }
                else
                {
                    doublonsEvites++;
                }



            }
            
            foreach (var p in phrasesUniques)
            {
                Console.WriteLine(p);
                Console.WriteLine();
            }
           
            Console.WriteLine("Nombre de phrases uniques : " + phrasesUniques.Count);
            Console.WriteLine("Nombre de doublons évités : " + doublonsEvites);


        }
        static string obtenirElementAleatoire(string[] t)
        {
            Random r = new Random();
            int i = r.Next(t.Length);
            return t[i];
        }
    }
}
