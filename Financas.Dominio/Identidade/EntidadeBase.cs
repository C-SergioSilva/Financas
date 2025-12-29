namespace Financas.Dominio.Identidade
{
    public class EntidadeBase
    {
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public bool Deletado { get; set; }
    }
}
