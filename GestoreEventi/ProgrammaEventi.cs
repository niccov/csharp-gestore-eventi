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
        public static List<Evento> eventi;

        public ProgrammaEventi(string titolo)
        {
            Titolo = titolo;
            eventi = new List<Evento>();
        }

        public void AggiungiEvento(Evento evento)
        {
            eventi.Add(evento);
        }


       

        public static string StampaEventi(List<Evento> listaEventi)
        {
            if (listaEventi.Count == 0)
                return "Nessun evento presente.";

            string result = "";
            foreach (var evento in listaEventi)
            {
                result += evento.ToString() + "\n";
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
