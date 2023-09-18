using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class ProgrammaEventi
    {
        public string Titolo { get; private set; }
        private List<string> eventi;

        public ProgrammaEventi(string titolo)
        {
            Titolo = titolo;
            eventi = new List<string>();
        }

        public void AggiungiEvento(string titoloEvento)
        {
            eventi.Add(titoloEvento);
        }


       

        public static string StampaEventi(List<string> listaEventi)
        {
            if (listaEventi.Count == 0)
                return "Nessun evento presente.";

            string result = "";
            foreach (var evento in listaEventi)
            {
                Console.WriteLine(evento);
            }
            return result;
        }

        public int NumeroEventi()
        {
            return eventi.Count;
        }

        public void SvuotaEventi()
        {
            eventi.Clear();
        }

        
    }
}
