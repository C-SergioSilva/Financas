namespace Financas.Dominio.Entidades
{
    public class ResultadoCalculoBalancete
    {
        public decimal TotalReceitas { get; set; }
        public decimal TotalDespesas { get; set; }
        public decimal ResultadoGeral { get; set; }
        public string PeriodoInicial { get; set; }
        public string PeriodoFinal { get; set; }
    }
}
