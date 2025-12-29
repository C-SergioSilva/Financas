namespace Financas.Negocio.EntidadeVO
{
    public class FonteRendaVO
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Descricao { get; set; }
        public bool Deletado { get; set; }
        public ICollection<ReceitaVO> ReceitasVO { get; set; }

    }
}
