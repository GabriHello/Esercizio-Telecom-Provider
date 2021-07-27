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
        public decimal creditoSim { get; set; }


        public Sim(string numeroSim, decimal creditoSim, List<Telefonata> listaTelefonate)
        {
            this.numeroSim = numeroSim;
            this.creditoSim = creditoSim;
            this.listaTelefonate = listaTelefonate;
        }

        public Sim registraNuovaSim()
        {
            Console.WriteLine("Stai registrando una sim.\n" +
                "Numero: ");
            string numeroSim = Console.ReadLine();
            Console.WriteLine("\nCredito Residuo");
            decimal creditoSim = decimal.Parse(Console.ReadLine());
            Console.WriteLine("\nRegistro chiamate VUOTO");
            List<Telefonata> listaTelefonate = new List<Telefonata>();
            var nuovaSim = new Sim(numeroSim, creditoSim, listaTelefonate);
            return nuovaSim;
        }

        public List<string> creaRegistroChiamate(List<Telefonata> listaChiamate)
        {
            int indicericerca = 0;
            List<string> registroChiamate = new List<string>();
            int[] contatori = new int[listaChiamate.Count];
            registroChiamate.Add(new string(listaChiamate[0].numeroDestinatario) { });
            string tempCall = "";
            
            for(int i = 0; i<listaChiamate.Count; i++)
            {
                contatori[i] = 1;
            }

            for(int i = 1; i < listaChiamate.Count; i++)
            {
                tempCall = "";
                if(registroChiamate.Contains(listaChiamate[i].numeroDestinatario))
                {
                    tempCall = listaChiamate[i].numeroDestinatario;
                    indicericerca = registroChiamate.IndexOf(tempCall);
                    contatori[indicericerca]++;
                }
                else 
                    registroChiamate.Add(new string(listaChiamate[i].numeroDestinatario));
                
            }

            for(int i = 0; i<registroChiamate.Count; i++)
            {
                if (contatori[i] > 1) registroChiamate[i] += $"({contatori[i]})";
            }

            return registroChiamate;
        }

        public void stampaDatiSim(string numeroSim, decimal creditoSim,
            List<string> registroChiamate)
        {
            int i = 0;
            /*foreach (Telefonata telefonata in registroChiamate)
            {
                creditoSim -= telefonata.costoChiamata;
            }*/

            Console.WriteLine("\nNumero della sim: " + numeroSim);
            Console.WriteLine("\nIl credito residuo è di " + creditoSim + " euro.");

            Console.WriteLine("\nRegistro chiamate:");
            i = 0;
            foreach (string telefonata in registroChiamate)
            {
                Console.WriteLine($"{++i}:\t" + telefonata);
            }
        }


        //Effettuare chiamate: possibile solo se il credito è superiore a 0.
        public List<Telefonata> effettuaChiamate(Sim scheda)
        {

            int i = 0;
            string confirm = "y";

            List<Telefonata> listaChiamate = new List<Telefonata>();


            if (scheda.creditoSim > 0) //controllo credito
            {
                do
                {
                    Console.WriteLine("Inserisci numero da chiamare");
                    string numeroDestinatario = Console.ReadLine();
                    Console.WriteLine("Quanto è durata la chiamata?");
                    int durataChiamata = int.Parse(Console.ReadLine());

                    decimal costoChiamata = durataChiamata * 0.2m;


                    listaChiamate.Add(new Telefonata(numeroDestinatario, durataChiamata, costoChiamata) { });

                    scheda.creditoSim -= costoChiamata;
                    Console.WriteLine($"Credito residuo: {scheda.creditoSim}");

                    if (scheda.creditoSim <= 0)
                    {
                        Console.WriteLine("Hai finito il credito!!! Impossibile eseguire altre chiamate\n");
                        confirm = "n";
                    }
                    else
                    {
                        Console.WriteLine("\npremi y per effettuare un'altra chiamata");
                        confirm = Console.ReadLine();
                    }

                    i++;

                } while (confirm == "y");
            }
            else Console.WriteLine("\nSpiacenti: Credito insufficiente!" +
                " scegli un'altra operazione");

            return listaChiamate;
        }


        public void stampaChiamate(List<Telefonata> listaChiamate)
        {
            //Stampa di tutte le chiamate
            int i = 0;
            foreach (Telefonata chiamata in listaChiamate)
            {
                Console.WriteLine($"Chiamata {i + 1}:\nDestinatario: {listaChiamate[i].numeroDestinatario}.\t" +
                    $" Durata: {listaChiamate[i].durataChiamata} minuti.\tCosto: {listaChiamate[i].costoChiamata}");
                i++;
            }
        }

        public decimal ricaricaTelefonica(decimal creditoSim)
        {
            Console.WriteLine("\nEsegui ricarica telefonica: immetti la quantità " +
                "di denaro da erogare:\n");
            creditoSim += decimal.Parse(Console.ReadLine());
            Console.WriteLine($"\nRicarica andata a buon fine.\nCredito residuo: {creditoSim}");
            return creditoSim;
        }

    }
}