namespace SistemaProcessos.Models
{
    public class ProcessosModel
    {
        public int Id { get; set; }

        public int Advogado_id { get; set; }

        public int Cliente_id { get; set; }

        public string Numero_processo { get; set; }

        public DateTime Proximo_prazo { get; set; }

        public bool Arquivo { get; set; }
    }
}
