using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class Evento
    {

        public string titolo;
        public DateTime data;
        public int capienzaMassima;
        public int postiPrenotati;

        public string Titolo
        {
            get { return titolo; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Il titolo non può essere vuoto o nullo.");
                }
                    
                titolo = value;
            }
        }

        public DateTime Data
        {
            get { return data; }
            set
            {
                if (value < DateTime.Now)
                {
                    throw new ArgumentException("La data non può essere nel passato.");
                }
                    
                data = value;
            }
        }

        public Evento(string titolo, DateTime data, int capienzaMassima)
        {
            Titolo = titolo;
            Data = data;
            if (capienzaMassima <= 0)
            {
                throw new ArgumentException("La capienza massima deve essere un numero positivo.");
            }
                
            this.capienzaMassima = capienzaMassima;
            this.postiPrenotati = 0;
        }

        
    }

}

