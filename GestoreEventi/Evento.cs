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

        public int CapienzaMassima
        {
            get { return capienzaMassima; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("La capienza massima deve essere un numero positivo.");
                capienzaMassima = value;
            }
        }

        public Evento()
        {
            // Costruttore vuoto
        }

        public void PrenotaPosti(int postiDaPrenotare)
        {
            if (data < DateTime.Now)
            {
                throw new InvalidOperationException("L'evento è già passato.");
            }
            if (postiDaPrenotare <= 0)
            {
                throw new ArgumentException("Il numero di posti da prenotare deve essere positivo.");
            }
            if (postiPrenotati + postiDaPrenotare > capienzaMassima)
            {
                throw new InvalidOperationException("Non ci sono abbastanza posti disponibili.");
            }

            postiPrenotati += postiDaPrenotare;
        }

        public void DisdiciPosti(int postiDaDisdire)
        {
            if (data < DateTime.Now)
            {
                throw new InvalidOperationException("L'evento è già passato.");
            }
            if (postiDaDisdire <= 0)
            {
                throw new ArgumentException("Il numero di posti da disdire deve essere positivo.");
            }
            if (postiDaDisdire > postiPrenotati)
            {
                throw new InvalidOperationException("Non ci sono abbastanza posti prenotati da disdire.");
            }

            postiPrenotati -= postiDaDisdire;
        }

        public override string ToString()
        {
            return data.ToString("dd/MM/yyyy") + " - " + titolo;
        }

    }

}

