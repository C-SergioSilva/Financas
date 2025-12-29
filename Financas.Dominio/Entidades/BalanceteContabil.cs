using Financas.Dominio.Identidade;

namespace Financas.Dominio.Entidades
{
    public class BalanceteContabil : EntidadeBase
    {
        public int IdBalancete { get; set; }
        public decimal TotalDespesa { get; set; }
        public decimal TotalReceita { get; set; }
        public decimal ResultadoGeral { get; set; }
        public string PeriodoInicial { get; set; }
        public string PeriodoFinal { get; set; }
        public Periodicidade Periodicidade { get; set; }
        public int IdPeriodicidade { get; set; }
    }
}
