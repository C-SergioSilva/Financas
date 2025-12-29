using Financas.Dominio.Identidade;

namespace Financas.Dominio.Entidades
{
    public class Despesa : EntidadeBase
    {
        public int IdDespesa { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }

        public int IdTipoPagamento { get; set; }
        public TipoPagamento TipoPagamento { get; set; }

        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }


    }
}
