using System;

namespace Week1Day3.esercizio2
{
    class Program
    {
        static void Main(string[] args)
        {

            //            Analizza NumeriSi scriva un programma per poter analizzare una sequenza di numeri.
            //Dati N numeri interi letti da tastiera(alternativa generati in maniera Random)
            //si vogliono calcolare e stampare su schermo diversi risultati: 1.quanti sono i numeri positivi, nulli e negativi
            //2.quanti sono i numeri pari e dispari
            //3.se la sequenza dei numeri inseriti è crescente, decrescente oppure né crescente né decrescente.Suggerimento.
            //Una sequenza è crescente se ogni numero è maggiore del precedente,
            //decrescente se ogni numero è minore del precedente,
            //né crescente né decrescente in tutti gli altri casi.

            Console.WriteLine("Ciao! Con quanti numeri vuoi lavorare?");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Scelta errata. Devi inserire un numero itero.");
            }

            int[] a = new int[n];

            Console.WriteLine("Inserisci 1 se vuoi scegliere i numeri della sequenza, oppure 2 se vuoi che venga generata in modo random");
            int scelta;
            while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 1 || scelta > 2)
            {
                Console.WriteLine("Scelta errata. Devi inserire un numero itero e deve essere 1 o 2.");
            }
            if(scelta == 1)
            {
                generateArray(ref a, n);
            }
            else
            {
                generateRandomArray(ref a, n);
            }

            Print(a, n);
            numbers(a, n, out int pos, out int neg, out int nul);
            pariEdispari(a, n, out int pari, out int dispari);
            dec(a, n);

        }


        private static void Print(int[]x, int dim)
        {
            int i = 0;
            Console.WriteLine($"La sequenza di {dim} numeri generata casualmente e' :");
            for(i = 0; i < dim; i++)
            {
                Console.Write(($"{x[i]}\t"));
            }
            Console.WriteLine("\n");
        }

        private static void generateArray(ref int[]x, int dim)
        {
            int i = 0, num = 0;
            for(i=0; i < dim; i++)
            {
                Console.WriteLine("Inserisci numero");
                
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Scelta errata. Devi inserire un numero itero.");
                }
                x[i] = num;

            }
        }

        private static void generateRandomArray(ref int[] x, int dim)
        {
            int i = 0;
            Random random = new Random();

            for (i = 0; i < dim; i++)
            {
                x[i] = random.Next(1, 100);

            }
        }

        private static void numbers(int[] x, int dim, out int pos, out int neg, out int nul)
        {
            int i = 0;
            pos = 0;
            neg = 0;
            nul = 0;
            for(i = 0; i < dim; i++)
            {
               if(x[i] > 0)
                {
                    pos++;
                }
               else if(x[i] < 0)
                {
                    neg++;
                }
               else
                {
                    nul++;
                }
            }
            Console.WriteLine($"I numeri positivi sono {pos}");
            Console.WriteLine($"I numeri negativi sono {neg}");
            Console.WriteLine($"I numeri nulli sono {nul}");
        }

        private static void pariEdispari(int[]x, int dim, out int pari, out int dispari)
        {
            int i = 0;
            pari = 0;
            dispari = 0;

            for(i=0; i<dim; i++)
            {
                if (x[i] % 2 == 0)
                {
                    pari++;
                }
                else dispari++;
            }
            Console.WriteLine($"I numeri pari sono {pari}");
            Console.WriteLine($"I numeri dispari sono {dispari}");
        }

        private static void dec(int[]x, int dim)
        {
            int i = 0,cresc = 0, decr = 0;

            while (i < dim && (i+1)< dim)
            {
                
                if(x[i + 1] > x[i])
                {
                    cresc++;
                }
                else if(x[i + 1] < x[i])
                {
                    decr++;
                }
                i++;
            }
            if(cresc == dim-1)
            {
                Console.WriteLine("La sequenza dei numeri è crescente");
            }
            else if(decr == dim-1)
            {
                Console.WriteLine("La sequenza dei numeri è decrescente");
            }
            else
            {
                Console.WriteLine("La sequenza dei numeri non è nè crescente nè decrescente");
            }
            
            
        }
    }
}
