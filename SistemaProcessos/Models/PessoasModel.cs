namespace SistemaProcessos.Models
{
    public class PessoasModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public bool Cliente { get; set; }

        public string? Cpf_cnpj { get; set; }

        public string? Endereco { get; set; }

        public string? Email { get; set; }

    }
}
