using Financas.Dominio.Identidade;

namespace Financas.Dominio.Entidades
{
    public class Receita : EntidadeBase
    {

        public int IdReceita { get; set; }

        public string Descricao { get; set; }
        public decimal Valor { get; set; }

        public int IdFonteRenda { get; set; }
        public FonteRenda FonteRenda { get; set; }

        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }

    }
}
