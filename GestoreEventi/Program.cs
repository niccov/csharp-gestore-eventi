namespace GestoreEventi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Evento evento = new Evento();
            Console.Write("Inserisci il titolo dell'evento: ");
            evento.Titolo = Console.ReadLine();

            Console.Write("Inserisci la data dell'evento (dd/MM/yyyy): ");
            evento.Data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.Write("Inserisci la capienza massima: ");
            evento.capienzaMassima = int.Parse(Console.ReadLine());

            Console.Write("Quanti posti vuoi prenotare? ");
            int postiDaPrenotare = int.Parse(Console.ReadLine());

            Console.WriteLine();

            evento.PrenotaPosti(postiDaPrenotare);
            Console.WriteLine($"Numero di posti prenotati = {postiDaPrenotare}");
            Console.WriteLine($"Numero di posti disponibili = {evento.CapienzaMassima - postiDaPrenotare}");


            while (true)
            {
                Console.WriteLine();
                Console.Write("Vuoi disdire dei posti? (Sì/No): ");
                string risposta = Console.ReadLine().Trim().ToLower();

                if (risposta == "no")
                {
                    break;
                }   
                else if (risposta == "sì" || risposta == "si")
                {
                    Console.Write("Indica il numero di posti da disdire: ");
                    int postiDaDisdire = int.Parse(Console.ReadLine());

                    evento.DisdiciPosti(postiDaDisdire);
                    Console.WriteLine();
                    Console.WriteLine($"Disdetti {postiDaDisdire} posti.");
                }
                else
                {
                    Console.WriteLine("Risposta non valida. Rispondi con 'Sì' o 'No'.");
                }

                Console.WriteLine();
                Console.WriteLine($"Posti prenotati dopo le disdette: {evento.postiPrenotati}");
                Console.WriteLine($"Posti disponibili dopo le disdette: {evento.CapienzaMassima - evento.postiPrenotati}");
            }

            Console.WriteLine();

            Console.Write("Inserisci il nome del tuo programma eventi: ");
            string titoloProgramma = Console.ReadLine();

            ProgrammaEventi programma = new ProgrammaEventi(titoloProgramma);

            Console.Write("Indica il numero di eventi da inserire: ");
            int numeroEventiDaAggiungere = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < numeroEventiDaAggiungere; i++)
            {
                Console.Write($"Inserisci il nome del {i + 1} evento: ");
                string titoloEvento = Console.ReadLine();
                

                Console.Write("Inserisci la data dell'evento (dd/MM/yyyy): ");
                DateTime dataEvento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
               

                Console.Write("Inserisci il numero di posti totali: ");
                int capienzaMassima = int.Parse(Console.ReadLine());

                Console.WriteLine();

                
            }

            Console.WriteLine($"Il numero di eventi nel programma è: {numeroEventiDaAggiungere}");
            Console.WriteLine("Ecco il tuo programma eventi: ");
            Console.WriteLine(titoloProgramma);
            Console.WriteLine(ProgrammaEventi.StampaEventi(ProgrammaEventi.eventi));

        }
    }
}