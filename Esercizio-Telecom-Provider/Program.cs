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
            Console.WriteLine("Hello World!\n\n");


            /*string numeroChiamato1 = "33312340101";
            int durata1 = 15;*/
            /*Telefonata chiamata1 = new Telefonata(numeroChiamato1, durata1);*/



            /*int ciao = telefonata1.MinutiChiamata();
            Console.WriteLine($"\n La chiamata è durata {ciao} minuti");*/
            int i = 0;
            string confirm = "y";
            List<Telefonata> listaChiamate = new List<Telefonata>();

            do
            {
                Console.WriteLine("Inserisci numero da chiamare");
                string numeroDestinatario = Console.ReadLine();
                Console.WriteLine("Quanto è durata la chiamata?");
                int durataChiamata = int.Parse(Console.ReadLine());

                listaChiamate.Add( new Telefonata (numeroDestinatario, durataChiamata));
                i++;

                Console.WriteLine("\npremi y per effettuare un'altra chiamata");
                confirm = Console.ReadLine();
            } while (confirm == "y");

            i = 0;
            foreach(Telefonata chiamata in listaChiamate)
            {
                Console.WriteLine($"Chiamata {i+1}:\nDestinatario: {listaChiamate[i].numeroDestinatario}.\t" +
                    $" Durata: {listaChiamate[i].durataChiamata} minuti.");
                i++;
            }
           /* Console.WriteLine("Inserisci numero SIM1");
            string numeroTelefonico = Console.ReadLine();
            Console.WriteLine("Inserisci credito residuo SIM1");
            int creditoResiduo = int.Parse(Console.ReadLine());
            List<Telefonata> registroSim1 = new List<Telefonata>();
            registroSim1.Add(new Telefonata(numeroChiamato1, durata1)
            { });
            Sim schedaSim1 = new Sim(numeroTelefonico, creditoResiduo, registroSim1);
*/



            //Richiesta stampa dati sim
            Console.WriteLine("Vuoi stampare i dati della sim1? Immetti" +
                " 'Y' per confermare");
            string conferma = Console.ReadLine().Trim();
            /*if (conferma.ToLower() == "y")
            schedaSim1.stampaDatiSim();*/
        }
    }
}
