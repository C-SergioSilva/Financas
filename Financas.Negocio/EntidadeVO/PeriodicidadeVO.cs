namespace Financas.Negocio.EntidadeVO
{
    public class PeriodicidadeVO
    {
        public int IdPeriodicidade { get; set; }
        public string Descricao { get; set; }
        public ICollection<BalanceteContabilVO> Balancetes { get; set; } = new List<BalanceteContabilVO>();
    }
}
