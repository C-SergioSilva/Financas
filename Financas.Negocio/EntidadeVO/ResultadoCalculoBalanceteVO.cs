namespace Financas.Negocio.EntidadeVO
{
    public class ResultadoCalculoBalanceteVO
    {
        public decimal TotalReceitas { get; set; }
        public decimal TotalDespesas { get; set; }
        public decimal ResultadoGeral { get; set; }
        public string PeriodoInicial { get; set; }
        public string PeriodoFinal { get; set; }
    }
}
