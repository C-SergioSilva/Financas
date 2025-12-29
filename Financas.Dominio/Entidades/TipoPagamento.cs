using Financas.Dominio.Identidade;

namespace Financas.Dominio.Entidades
{
    public class TipoPagamento : EntidadeBase
    {
        public int IdTipoPagamento { get; set; }
        public string Descricao { get; set; }
        public ICollection<Despesa> Despesas { get; set; }

    }
}
