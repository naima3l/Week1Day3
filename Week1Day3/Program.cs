using System;
using System.Collections.Generic;

namespace Week1Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Routine();

            //Createarray();
            //ExerciseArray();

            //Random per generare numeri casuali
            Random random = new Random();
            int ranNumber = random.Next(10, 21);
            Console.WriteLine($"E' stato generato casualmente il numero {ranNumber}");

            


        }

        private static void ExerciseArray()
        {
            //Indovina valore: Creare e inizializzare un array di interi dimensione N=4;
            //Chiedere all'utente di provare ad indovinare un numero. Verificare se il numero inserito dall'utente c'è nell'array
            //Se c'è stampa "hai vinto", se non c'è stampa "Hai perso".
            int[] arrayGuess = { 15, 0, 23, 6 };
            Console.WriteLine("Ciao! Prova ad indovinare un numero.");
            Console.WriteLine("Inserisci un numero");
            int guess;
            while (!int.TryParse(Console.ReadLine(), out guess))
            {
                Console.WriteLine("Scelta errata. Devi inserire un itero.");
            }
            int index = Array.IndexOf(arrayGuess, guess);
            if (index == -1)
            {
                Console.WriteLine("Mi dispice! Hai perso.");
            }
            else
            {
                Console.WriteLine("Congratulazioni! Hai vinto!");
                Console.WriteLine($"Il numero che hai indovinato si trova in posizione {index}");
            }
        }

        private static void CreateArray()
        {
            int[] firstArray = new int[5];
            firstArray[0] = 3;
            firstArray[1] = 10;
            firstArray[2] = 13;
            firstArray[3] = 55;
            firstArray[4] = 8;

            //cerco la posizione in base al valore
            int index = Array.IndexOf(firstArray, 10);
            Console.WriteLine($"Il numero 10 si trova alla posizione {index}");

            Console.WriteLine("Print of my firstArray :\n");
            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write($"{firstArray[i]}\t");
            }

            int[] numbers = { 1, 2, 45, 67, 70 };

            string[] names = { "Renata", "Alessandra", "Arianna" };

            //lista --accenni--
            List<int> listNumbers = new List<int>();
            listNumbers.Add(23);
            listNumbers.Add(223);
            int elements = listNumbers.Count;
            Console.WriteLine($"\nLa mia lista contiene {elements} elementi");
            listNumbers.Add(5);
            Console.WriteLine($"\nLa mia lista contiene {listNumbers.Count} elementi");

            //Matrici
            int[,] firstMatrix = new int[2, 3];
            int[,] secondtMatrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            Console.WriteLine("La mia matrice e' :");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(secondtMatrix[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
        }

        private static void Routine()
        {
            Menu();

            int a = 1, b = 2;
            int somma = 0;
            somma = Sum(a, b);
            Console.WriteLine($"La somma è {somma}");

            int e = 45;
            int f = 2;
            PrintSum(e, f);

            int var1 = 10;
            ChangeValue(var1);
            Console.WriteLine($"Il valore di var1 dopo la chiamata a ChangeValue e' {var1}");

            int var2 = 20;
            ChangeValueByRif(ref var2);
            Console.WriteLine($"Il valore di var2 dopo la chiamata a ChangeValue e' {var2}");


            int n = 2, m = 10;
            int res = SumAfterIncrement(ref n, m);
            Console.WriteLine($"La var n vale {n}, la var m vale {m} e la somma e' {res}");



            //out
            int x1 = 2, x2 = 3;
            int diff = DifferenzaEProdotto(x1, x2, out int prodotto);
            Console.WriteLine($"Il prodotto di {x1} e {x2} e' {prodotto}");
            Console.WriteLine($"La differenza tra {x1} e {x2} e' {diff}");

            //TryParse
            Menu();
            Console.WriteLine("Inserisci la tua scelta");
            //int scelta = int.Parse(Console.ReadLine()); // non è molto sicuro perchè se l'utente inserisce qualcosa che non può essere convertito in int poi si blocca
            //bool checkInt = int.TryParse(Console.ReadLine(), out int scelta);
            //Console.WriteLine($"La scelta dell'utente e' {scelta}");

            int scelta;
            while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 1 || scelta > 3)
            {
                Console.WriteLine("Scelta errata. Deve essere un itero compreso tra 1 e 3. Riprova.");
            }
            Console.WriteLine($"La scelta dell'utente e' {scelta}");
        }

        //Mi deve restituire la differenza. Ma mi interessa anche avere in output il prodotto dei due valori passati in input.
        private static int DifferenzaEProdotto(int x, int y, out int p)
        {
            int diff = x - y;
            p = x * y; //out int p mi serve perchè io voglio ritornare anche il prodotto ma ci può essere un solo ret
            return diff;
        }





        //Scrivere una funzione che prende in input 2 interi ,uno per rif e l'altro no, li incrementa di 1  restituice la loro somma
        private static int SumAfterIncrement( ref int x, int y)
        {
            x++;
            y++;
            return Sum(x,y);
        }

        private static void ChangeValue(int x) //per valore, var cambia solo dentro la funzione ma dopo ritorna con il suo vecchio valore
        {
            x = 5;
            Console.WriteLine($"Ho cambiato il mio parametro. Adesso e+ uguale a {x}");
        }

        private static void ChangeValueByRif(ref int x) //con ref, anche dopo la chiamata a funzione il valore di var viene modificato
        {
            x = 5;
            Console.WriteLine($"Ho cambiato il mio parametro. Adesso e+ uguale a {x}");
        }

        private static int Sum(int x, int y)
        {
            int z = x + y;
            return z;
        }

        private static void PrintSum(int x, int y)
        {
            Console.WriteLine($"La somma tra {x} e {y} e' {Sum(x, y)}");
        }
     
        private static void Menu()
        {
            Console.WriteLine("*****Menu******");
            Console.WriteLine("1. Opzione 1");
            Console.WriteLine("2. Opzione 2");
            Console.WriteLine("3. Opzione 3");
        }

        //overloading
        private static int Sum(int x, int y, int z)
        {
            return x + y + z;
        }

        private static int Sum(ref int x, int y, int z)
        {
            return x + y + z;
        }

        private static double Sum(double a, double b)
        {
            return a + b;
        }
    }
}
