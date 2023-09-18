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
        private List<Evento> eventi;

        public ProgrammaEventi(string titolo)
        {
            Titolo = titolo;
            eventi = new List<Evento>();
        }

        public void AggiungiEvento(Evento evento)
        {
            eventi.Add(evento);
        }


        public List<Evento> EventiInData(DateTime data)
        {
            List<Evento> eventiInData = new List<Evento>();

            foreach (Evento evento in eventi)
            {
                if (evento.Data.Date == data.Date)
                {
                    eventiInData.Add(evento);
                }
            }

            return eventiInData;
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

        public override string ToString()
        {
            string result = $"Nome programma evento: {Titolo}\n";

            foreach (var evento in eventi)
            {
                result += evento.ToString() + "\n";
            }

            return result;
        }
    }
}
