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








    }
}
