using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //P1();
            //P2();
            //P3();
            //P4();
            //P5();
            //P6();
            //P7();
            //P8();
            //P9();
            //P10();
            //P11();
            P12();
           


        }

    

        /// <summary>
        /// Sortare selectie. Implementati algoritmul de sortare <Selection Sort>.
        /// </summary>
        private static void P12()
        {
            Console.Write("Introduceti numarul de elemente ce doriti sa le sortati = ");
            int n = int.Parse(Console.ReadLine());

            int[] tab = new int[100];

            Console.Write("Introduceti elemntele tabelului = ");
            for (int i = 0; i < n; i++)
            {
                tab[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                    if (tab[i] > tab[j])
                    {
                        int aux = tab[i];
                        tab[i] = tab[j];
                        tab[j] = aux;
                    }

            Console.Write("Elementele tabloului dupa sortare sunt =  ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ,", tab[i]);
            }

        }

        /// <summary>
        /// Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene).
        /// </summary>

        private static void P11()
        {
            Console.Write("Introduceti n = ");
            int n = int.Parse(Console.ReadLine());

            int[] tab = new int[100];
            int nr = 0;

            for (int i = 2; i <= n; ++i)
            {
                if (tab[i] == 0)
                {
                    nr++;
                    for (int j = i + i; j <= n; j += i)
                    {
                        tab[j] = 1;
                    }
                }
            }


        }

        /// <summary>
        /// Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. Se cere sa se determine pozitia unui element dat k. Daca elementul nu se gaseste in vector rezultatul va fi -1
        /// </summary>

        private static void P10()
        {
            Console.Write("Introduceti lungimea vectorului : ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Introduceti k : ");
            int k = int.Parse(Console.ReadLine());


            int[] tab1 = new int[100];
            bool cresc = false;

            Console.Write("Introduceti elementele vectorului : ");
            for (int i = 0; i < n; i++)
            {
                tab1[i] = int.Parse(Console.ReadLine());
            }


            for (int i = 0; i < n; i++)
            {
                if (tab1[i] < tab1[i + 1])
                    cresc = false;
            }

            if (cresc)
            {


            }
            else
            {
                Console.Write(" EROARE !! Elementele vectorului nu sunt in ordine crescatoare !! ");
            }


        }


        /// <summary>
        /// Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga.
        /// </summary>
        private static void P9()
        {
            Console.Write("Introduceti lungimea vectorului : ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Introduceti k : ");
            int k = int.Parse(Console.ReadLine());


            int[] tab1 = new int[100];

            Console.Write("Introduceti elementele vectorului : ");
            for (int i = 0; i < n; i++)
            {
                tab1[i] = int.Parse(Console.ReadLine());
            }

            int aux = tab1[0];

            if (k == 1)
                Console.Write("Vectorul dupa rotire = ");
            else
                Console.Write("Vectorul dupa rotiri = ");

            while (k != 0)
            {
                for (int i = 0; i < n; i++)
                {
                    if (i == n - 1)
                    {
                        tab1[i] = aux;
                        aux = tab1[0];
                    }
                    else
                        tab1[i] = tab1[i + 1];

                }
                k--;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write($" {tab1[i]} ");
            }
        }

        /// <summary>
        /// Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga. Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc.
        /// </summary>

        private static void P8()
        {
            Console.Write("Introduceti lungimea vectorului : ");
            int n = int.Parse(Console.ReadLine());

            int[] tab1 = new int[100];

            Console.Write("Introduceti elementele vectorului : ");
            for (int i = 0; i < n; i++)
            {
                tab1[i] = int.Parse(Console.ReadLine());
            }

            int aux = tab1[0];


            for (int i = 0; i < n; i++)
            {
                if (i == n - 1)
                    tab1[i] = aux;
                else
                    tab1[i] = tab1[i + 1];
            }

            Console.Write("Vectorul dupa rotire = ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($" {tab1[i]} ");
            }
        }

        /// <summary>
        /// Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector. Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.
        /// </summary>

        private static void P7()
        {
            Console.Write("Introduceti lungimea vectorului : ");
            int n = int.Parse(Console.ReadLine());

            int[] tab1 = new int[100];
            int aux = 0;
            int a = n;

            Console.Write("Introduceti elementele vectorului : ");
            for (int i = 1; i <= n; i++)
            {
                tab1[i] = int.Parse(Console.ReadLine());
            }


            for (int i = 1; i <= a / 2; i++)
            {
                aux = tab1[i];
                tab1[i] = tab1[n];
                tab1[n] = aux;
                n = n - 1;


            }

            Console.Write("Vectorul dupa inversare = ");
            for (int i = 1; i <= a; i++)
            {
                Console.Write($"{tab1[i]} ");
            }
        }

        /// <summary>
        /// Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k. Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga.
        /// </summary>

        private static void P6()
        {
            Console.Write("Introduceti lungimea vectorului : ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Introduceti pozitia k : ");
            int k = int.Parse(Console.ReadLine());

            int[] tab1 = new int[100];

            Console.Write("Introduceti elementele vectorului : ");
            for (int i = 0; i < n; i++)
            {
                tab1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (i == k)
                {
                    n = n - 1;
                    for (int a = i; a < n; a++)
                        tab1[a] = tab1[a + 1];

                    i = n;
                }

            }

            Console.Write("Elementele vectorului dupa executare : ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(" " + tab1[i]);
            }
        }

        /// <summary>
        /// Se da un vector cu n elemente, o valoare e si o pozitie din vector k. Se cere sa se insereze valoarea e in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero. 
        /// </summary>

        private static void P5()
        {
            Console.Write("Introduceti lungimea vectorului : ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Introduceti valoare e : ");
            int e = int.Parse(Console.ReadLine());

            Console.Write("Introduceti pozitia k : ");
            int k = int.Parse(Console.ReadLine());



            int[] tab1 = new int[100];

            Console.Write("Introduceti elementele vectorului : ");
            for (int i = 0; i < n; i++)
            {
                if (i == k)
                    tab1[i] = e;
                else
                    tab1[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Elementele vectorului sunt : ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(" " + tab1[i]);

            }

        }
        /// <summary>
        /// Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea.
        /// </summary>

        private static void P4()
        {
            Console.Write("Introduceti lungimea vectorului : ");
            int n = int.Parse(Console.ReadLine());

            int[] tab1 = new int[100];

            int nrmin = 1;
            int nrmax = 1;

            Console.Write("Introduceti primul element al  vectorului : ");
            tab1[0] = int.Parse(Console.ReadLine());

            int min = tab1[0];
            int max = tab1[0];

            Console.Write("Introduceti restul elementelor : ");
            for (int i = 1; i < n; i++)
            {
                tab1[i] = int.Parse(Console.ReadLine());

                if (tab1[i] <= min)
                {
                    if (tab1[i] == min)
                    {
                        nrmin++;
                    }
                    else
                    {
                        min = tab1[i];
                        nrmin = 1;
                    }
                }

                if (tab1[i] >= max)
                {
                    if (tab1[i] == max)
                    {
                        nrmax++;
                    }
                    else
                    {
                        max = tab1[i];
                        nrmax = 1;
                    }
                }
            }
            Console.Write("Cea mai mica valoare a vectorului {0} si apare de {1} ori iar cea mai  mare valoare a vectorului este {2} si apare de {3} ori . ", min, nrmin, max, nrmax);
        }



        /// <summary>
        /// Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului. Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz)
        /// </summary>

        private static void P3()
        {
            Console.Write("Introduceti lungimea vectorului : ");
            int n = int.Parse(Console.ReadLine());

            int[] tab1 = new int[100];

            int pozmin = 0;
            int pozmax = 0;

            Console.Write("Introduceti primul element al  vectorului : ");
            tab1[0] = int.Parse(Console.ReadLine());

            int min = tab1[0];
            int max = tab1[0];

            Console.Write("Introduceti restul elementelor : ");
            for (int i = 1; i < n; i++)
            {
                tab1[i] = int.Parse(Console.ReadLine());

                if (tab1[i] < min)
                {
                    min = tab1[i];
                    pozmin = i;
                }


                if (tab1[i] > max)
                {
                    max = tab1[i];
                    pozmax = i;
                }

            }

            Console.Write("Cel mai mic element al vectorului apare pe pozitia {0} si cel mai mare pe pozitia {1} . ", pozmin, pozmax);
        }


        /// <summary>
        /// Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1.
        /// </summary>
        private static void P2()
        {
            Console.Write("Introduceti n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti k = ");
            int k = int.Parse(Console.ReadLine());



            bool aux = true;
            int aux2 = -1;
            int[] tab1 = new int[100];

            for (int i = 0; i < n; i++)
            {
                tab1[i] = int.Parse(Console.ReadLine());

                if (tab1[i] == k)

                {
                    if (aux)
                    {
                        aux2 = i;
                        aux = false;
                    }
                }
            }
            if (aux2 == -1)
                Console.Write("{0} nu apare in vectorul dat . ", k);
            else
                Console.Write("Prima pozitie din vector pe care apare {0} este {1} . ", k, aux2);

        }

        /// <summary>
        /// Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.
        /// </summary>

        private static void P1()
        {
            Console.Write("Introduceti n = ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int[] tab1 = new int[100];

            for (int i = 0; i < n; i++)
            {
                tab1[i] = int.Parse(Console.ReadLine());
                sum = sum + tab1[i];
            }

            Console.Write("Suma elementelor unui vector de {0} numere este = {1} ", n, sum);
            Console.WriteLine();
        }
    }
}
    

