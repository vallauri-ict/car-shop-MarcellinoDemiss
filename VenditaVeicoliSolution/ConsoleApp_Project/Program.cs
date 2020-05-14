using System;
using Microsoft.VisualBasic;
using System.Data.OleDb;
using carShopDllProject;
using System.IO;

namespace ConsoleApp_Project
{
    class Program
    {
        public static dbUtils utils = new dbUtils();

        static void Main(string[] args)
        {
            string nomeTab;
            char scelta;
            do
            {
                menu();
                Console.Write("Digita la tua scelta: ");
                scelta = Console.ReadKey().KeyChar;
                switch (scelta)
                {
                    case '1':
                        Console.WriteLine("\nInserisci il nome della tabella: ");
                        nomeTab = Console.ReadLine();
                        dbUtils.creaTabella(nomeTab);
                        Console.WriteLine("Tabella creata");
                        Console.ReadKey();
                        break;
                    case '2':
                        Console.WriteLine("\nInserisci il nome della tabella: ");
                        nomeTab = Console.ReadLine();

                        Console.WriteLine("\nInserisci la marca: ");
                        string marca = Console.ReadLine();

                        Console.WriteLine("\nInserisci il modello: ");
                        string modello = Console.ReadLine();

                        Console.WriteLine("\nInserisci il colore: ");
                        string colore = Console.ReadLine();

                        Console.WriteLine("\nInserisci la cilindrata: ");
                        int cilindrata = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nInserisci la potenza: ");
                        int potenza = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nInserisci la data di immatricolazione: ");
                        DateTime immatricolazione = Convert.ToDateTime(Console.ReadLine());

                        Console.WriteLine("\nIl veicolo è usato?: ");
                        string usata = Console.ReadLine();

                        Console.WriteLine("\nIl veicolo ha 0 km?: ");
                        string isKmZero = Console.ReadLine();

                        Console.WriteLine("\nQuanti km ha il veicolo: ");
                        int kmPercorsi = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nQuanto costa il veicolo: ");
                        int prezzo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nInserisci quanti airbag ha l'auto: ");
                        int numAirBag = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nInserisci la marca della sella della moto: ");
                        string marcaSella = Console.ReadLine();

                        dbUtils.aggiungiItem(nomeTab, marca, modello, colore, cilindrata, potenza, immatricolazione, usata, isKmZero, kmPercorsi, prezzo, numAirBag, marcaSella);
                        Console.WriteLine("Elemento creato");
                        Console.ReadKey();
                        break;
                    case '3':
                        Console.WriteLine("\nInserisci il nome della tabella: ");
                        nomeTab = Console.ReadLine();
                        dbUtils.listaTabella(nomeTab);
                        Console.ReadKey();
                        break;
                    case '4':
                        Console.WriteLine("\nInserisci il nome della tabella: ");
                        nomeTab = Console.ReadLine();
                        int id = dbUtils.trovaId(nomeTab);
                        dbUtils.eliminaItem(nomeTab, id);
                        id = 0;
                        Console.WriteLine("Elemento eliminato");
                        Console.ReadKey();
                        break;
                    case '5':
                        Console.WriteLine("\nInserisci il nome della tabella: ");
                        nomeTab = Console.ReadLine();
                        dbUtils.eliminaTabella(nomeTab);
                        id = 0;
                        Console.WriteLine("Tabella eliminata");
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (scelta != 'X' && scelta != 'x');
        }

        private static void menu()
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Crea tabella");
            Console.WriteLine("2 - Inserisci nuovo elemento");
            Console.WriteLine("3 - Lista di veicoli");
            Console.WriteLine("4 - Elimina elemento");
            Console.WriteLine("5 - Elimina tabella");
            Console.WriteLine("x - Termina Programma");
        }
    }
}
