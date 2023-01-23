using System;
using System.Text;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Ex1());
            //Console.WriteLine(Ex2());
            //Console.WriteLine(Ex3());
            //Console.WriteLine(Ex4());
            //Console.WriteLine(Ex5());
            //Console.WriteLine(Ex6());
            //Console.WriteLine(Ex7());
        }
        
        static int Ex1()
        {
            /* Scrieti un program care va afisa pozitia unui substring intr-un string, ambele
               siruri de caractere fiind citite de la tastatura*/

            string sir = Console.ReadLine();
            string subsir = Console.ReadLine();

            return sir.IndexOf(subsir);
        }

        static string Ex2()
        {
            /* Scrieti un program care sa verifice daca un sir de caractere citit de la
            tastatura este sau nu palindrom.*/

            string sir = Console.ReadLine();
            string rezultat = "Sirul este palindrom";
            int n = sir.Length - 1;

            for(int i = 0; i< sir.Length/2; i++)
            {
                if(sir[i] != sir[n])
                {
                    rezultat = "Sirul nu este palindrom";
                }
                n--;
            }
            return rezultat;
            
        }

        static int Ex3()
        {
            /* Scrieti un program care va numara toate aparitiile unui caracter intr-un sir
            de caractere. Atat caracterul cautat cat si sirul de caractere vor fi citite de la
            tastatura*/

            string sir = Console.ReadLine();
            char caracter = char.Parse(Console.ReadLine());
            int nrCaracter = 0;

            foreach(char ch in sir)
            {
                if(ch == caracter)
                {
                    nrCaracter++;
                }
            }
            return nrCaracter;
        }

        static string Ex4()
        {
            /* Scrieti un program care va afisa caracterul cu numarul cel mai mare de aparitii dintr-un string citit
            de la tastatura, ignorand caseing-ul literelor.*/

            string sir = Console.ReadLine();
            sir = sir.ToLower();
            int maxim = 0;
            char litera = 'a';

            for(int i = 0; i < sir.Length; i++)
            {
                int numar = 0;
                for(int j = 0; j < sir.Length; j++)
                {
                    if(sir[i] == sir[j])
                    {
                        numar++;
                    }
                }
                if(numar > maxim)
                {
                    maxim = numar;
                    litera = sir[i];
                }
            }
            return $"{litera} apare de {maxim} ori";
        }

        static StringBuilder Ex5()
        {
            /* Un program care va normaliza un sir de caractere citit de la tastatura astfel incat fiecare cuvant din
            sir sa inceapa cu MAJUSCULA, restul literelor fiind transformate in litere mici.*/

            string sir = Console.ReadLine();
            StringBuilder rezultat = new StringBuilder(sir.Length);
            bool isUpper = true;

            foreach(char ch in sir)
            {
                if(isUpper)
                {
                    rezultat.Append(char.ToUpper(ch));
                    isUpper = false;
                }
                else
                {
                    rezultat.Append(char.ToLower(ch));
                }
                if(ch == ' ')
                {
                    isUpper = true;
                }
            }

            return rezultat;

        }

        static int Ex6()
        {
            /* Screiti un program care va numara vocalele dintr-un sir de caractere citit de
            la tastatura.*/

            string sir = Console.ReadLine();
            sir = sir.ToLower();
            char[] vocale = new[] { 'a', 'e', 'i', 'o', 'u' };
            int nrVocale = 0;

            foreach(char ch in sir)
            {
                for(int i = 0; i < vocale.Length; i++)
                {
                    if(ch == vocale[i])
                    {
                        nrVocale++;
                    }
                }
            }
            return nrVocale;
        }

        static string Ex7()
        {
            /* Scrieti un program care va citi doua siruri de caractere de la tastatura si va
            verifica daca cele doua siruri de caractere sunt anagrame.*/

            string sir1 = Console.ReadLine();
            string sir2 = Console.ReadLine();
            sir1 = sir1.ToLower();
            sir2 = sir2.ToLower();

            for (int i = 0; i < sir1.Length; i++)
            {
                int numar1 = 0;
                int numar2 = 0;
                if (sir1[i] != ' ')
                {
                    for (int j = 0; j < sir1.Length; j++)
                    {
                        if (sir1[i] == sir1[j])
                        {
                            numar1++;
                        }
                    }
                    for (int j = 0; j < sir2.Length; j++)
                    {
                        if (sir1[i] == sir2[j])
                        {
                            numar2++;
                        }
                    }
                    if (numar1 != numar2)
                    {
                        return "sirurile nu sunt anagrame";
                    }
                }
            }
            return "sirurile sunt anagrame";

        }

    }
}
