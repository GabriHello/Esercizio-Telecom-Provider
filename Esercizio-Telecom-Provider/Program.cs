using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_Telecom_Provider
{
    class Program
    {
        static void Main(string[] args)
        {
            //Effettua chiamate
            /*            int i = 0;
                        string confirm = "y";
                        List<Telefonata> listaChiamate = new List<Telefonata>();
                        do
                        {
                            Console.WriteLine("Inserisci numero da chiamare");
                            string numeroDestinatario = Console.ReadLine();
                            Console.WriteLine("Quanto è durata la chiamata?");
                            int durataChiamata = int.Parse(Console.ReadLine());
                            listaChiamate.Add(new Telefonata(numeroDestinatario, durataChiamata) { });
                            i++;
                            Console.WriteLine("\npremi y per effettuare un'altra chiamata");
                            confirm = Console.ReadLine();
                        } while (confirm == "y");*/

            //Stampa di tutte le chiamate
            /*            i = 0;
                        foreach (Telefonata chiamata in listaChiamate)
                        {
                            Console.WriteLine($"Chiamata {i + 1}:\nDestinatario: {listaChiamate[i].numeroDestinatario}.\t" +
                                $" Durata: {listaChiamate[i].durataChiamata} minuti.");
                            i++;
                        }*/

            /* Console.WriteLine("Inserisci numero SIM1");
             string numeroTelefonico = Console.ReadLine();
             Console.WriteLine("Inserisci credito residuo SIM1");
             int creditoResiduo = int.Parse(Console.ReadLine());
             List<Telefonata> registroSim1 = new List<Telefonata>();
             registroSim1.Add(new Telefonata(numeroChiamato1, durata1)
             { });
             Sim schedaSim1 = new Sim(numeroTelefonico, creditoResiduo, registroSim1);
        */

            string operation = "";

            List<Telefonata> empty = new List<Telefonata>();
            var simVoid = new Sim("0", 0, empty);
            var sim1 = simVoid.registraNuovaSim();
            do
            {
                Console.WriteLine("\nScegli tra le seguenti operazioni:" +
                    "\n0: Effettua una ricarica telefonica" +
                    "\n1: Effettua chiamate verso altri numeri" +
                    "\n2: Stampa il dettaglio delle chiamate e dei costi" +
                    "\n3: Stampa dati sim e registro chiamate" +
                    "\nQuit: USCIRE");
                Console.WriteLine("------------------------------------------------");
                operation = Console.ReadLine().Trim();
                switch (operation)
                {
                    case "0":
                        sim1.creditoSim = sim1.ricaricaTelefonica(sim1.creditoSim);
                        break;

                    case "1":
                        List<Telefonata> listaChiamate = sim1.effettuaChiamate(sim1);
                        break;

                    case "2":
                        listaChiamate = sim1.listaTelefonate;
                        sim1.stampaChiamate(listaChiamate);
                        break;

                    case "3":
                        listaChiamate = sim1.ottieniChiamate(sim1);
                        List<string> registroChiamate = new List<string>();
                        registroChiamate = sim1.creaRegistroChiamate(listaChiamate);
                        sim1.stampaDatiSim(sim1.numeroSim, sim1.creditoSim, registroChiamate);
                        break;

                    default:
                        break;

                }
            } while (operation.ToLower() != "quit");


        }
    }
}