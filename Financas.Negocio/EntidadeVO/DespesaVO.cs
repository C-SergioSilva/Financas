namespace Financas.Negocio.EntidadeVO
{
    public class DespesaVO
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }

        public int IdTipoPagamentoVO { get; set; }
        public TipoPagamentoVO TipoPagamentoVO { get; set; }
        public int IdUsuarioVO { get; set; }
        public UsuarioVO UsuarioVO { get; set; }
        
    }
}
