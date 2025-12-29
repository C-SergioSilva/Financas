namespace Financas.Negocio.EntidadeVO
{
    public class TipoPagamentoVO
    {
        public int IdTipoPagamentoVO { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Descricao { get; set; }
        public bool Deletado { get; set; }
        public ICollection<DespesaVO> DespesasVO { get; set; }

    }
}
