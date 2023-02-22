namespace Cadastro
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; } //? = aceita nulo
        public DateOnly DataNascimento { get; set; }
        public DateTime CadastradoEm { get; set; }
        public decimal Desconto { get; set; }
    }
}