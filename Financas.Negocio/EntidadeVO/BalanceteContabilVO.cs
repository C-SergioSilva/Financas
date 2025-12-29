

namespace Financas.Negocio.EntidadeVO
{
    public class BalanceteContabilVO
    {
        public int IdBalancete { get; set; }
        public decimal TotalDespesa { get; set; }
        public decimal TotalReceita { get; set; }
        public decimal ResultadoGeral { get; set; }
        public string PeriodoInicial { get; set; }
        public string PeriodoFinal { get; set; }
        public PeriodicidadeVO Periodicidade { get; set; }  
        public int IdPeriodicidade { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public bool Deletado { get; set; }
    }
}
