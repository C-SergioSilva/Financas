using Financas.Dominio.Identidade;

namespace Financas.Dominio.Entidades
{
    public class Cartao : EntidadeBase
    {
        public int IdCartao { get; set; }
        public string NomeTitular { get; set; }
        public string NomeDependente { get; set; }
        public string Bandeira { get; set; }
        public decimal Limite { get; set; }
        public string Numero { get; set; }
        public string CpfTitular { get; set; }

    }
}
