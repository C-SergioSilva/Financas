namespace Financas.Dominio.Entidades
{
    public class Periodicidade
    {
        public int IdPeriodicidade { get; set; }
        public string Descricao { get; set; }
        public ICollection<BalanceteContabil> Balancetes { get; set; } = new List<BalanceteContabil>();

    } 
}
