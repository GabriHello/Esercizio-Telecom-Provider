using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_Telecom_Provider
{
    class Telefonata
    {
        /*string numeroDestinatario;
      int durataChiamata;*/

        public string numeroDestinatario { get; }
        public int durataChiamata { get; }
        public Telefonata(string numeroDestinatario, int duratachiamata)
        {
            //Se io inserisco numero e durata nel costruttore, sono costretto a usarli entrambi (una chiamata ha destinatario E durata)
            /*this.numeroDestinatario = numeroDestinatario;
            this.durataChiamata = durataChiamata;*/

            this.numeroDestinatario = numeroDestinatario;
            this.durataChiamata = durataChiamata;
     
        }

/*        public Telefonata chiamaUnNumero()
        {
*//*            Console.WriteLine("Inserisci numero da chiamare");
            string numeroDestinatario = Console.ReadLine();
            Console.WriteLine("Quanto è durata la chiamata?");
            int durataChiamata = int.Parse(Console.ReadLine());
            *//*
            var chiamata = new Telefonata();
            return chiamata;
        }*/


        //Possiamo scriverli come proprietà con get set 
        /*public int MinutiChiamata()
        {
            *//*durataChiamata = 10203;*//*
            return durataChiamata;
        }
        public string NumeroChiamato()
        {
            return numeroDestinatario;
        }*/
        /*public string numeroDestinatario { get; set; }
        public int durataChiamata { get; set; }*/

    }
}
