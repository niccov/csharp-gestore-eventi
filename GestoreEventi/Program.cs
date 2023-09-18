namespace GestoreEventi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Evento evento = new Evento();
            Console.Write("Inserisci il titolo dell'evento: ");
            evento.Titolo = Console.ReadLine();

            Console.Write("Inserisci la data dell'evento (formato dd/MM/yyyy): ");
            evento.Data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.Write("Inserisci la capienza massima: ");
            evento.capienzaMassima = int.Parse(Console.ReadLine());

        }
    }
}