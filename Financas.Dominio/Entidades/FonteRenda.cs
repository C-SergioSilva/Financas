using Financas.Dominio.Identidade;

namespace Financas.Dominio.Entidades
{
    public class FonteRenda : EntidadeBase
    {
        public int IdFonteRenda { get; set; }
        public string Descricao { get; set; }
        public ICollection<Receita> Receitas { get; set; }

    }
}
