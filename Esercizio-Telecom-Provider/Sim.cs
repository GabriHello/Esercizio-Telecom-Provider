using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_Telecom_Provider
{
    class Sim
    {

        List<Telefonata> listaTelefonate = new List<Telefonata>();
        public string numeroSim { get; }
        public float creditoSim { get; }
        public Sim(string numeroSim, float creditoSim, List<Telefonata> listaTelefonate)
        {
            this.numeroSim = numeroSim;
            this.creditoSim = creditoSim;
            this.listaTelefonate = listaTelefonate;
        }


        public int calcoloDurata()
        {
            Console.WriteLine("\nInserisci i minuti di durata della chiamata");
            int durata = int.Parse(Console.ReadLine());
            return durata;
        }

        public Telefonata datiTelefonata()
        {
            Console.WriteLine("Inserisci il numero chiamato");
            string numeroDestinatario = Console.ReadLine();
            int durata = calcoloDurata();
            Telefonata chiamata = new Telefonata(numeroDestinatario, durata);
            return chiamata;
        }

       

        public void stampaDatiSim()
        {
            Console.WriteLine("\nNumero della sim: " + numeroSim);
            Console.WriteLine("\nIl credito residuo è di " + creditoSim + " euro.");

            Console.WriteLine("\nHai effettuato le seguenti chiamate");
            int i = 0;
            foreach (Telefonata telefonata in listaTelefonate)
            {
                Console.WriteLine($"Chiamata {++i}:" + "\nHai chiamato il numero: "
                    + telefonata.numeroDestinatario + " per una durata di "
                    + telefonata.durataChiamata + " minuti.");
            }
        }





    }
}
