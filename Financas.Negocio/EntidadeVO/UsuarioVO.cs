namespace Financas.Negocio.EntidadeVO
{
    public class UsuarioVO
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public PerfilVO PerfilVO { get; set; }
        public int IdPerfilVO { get; set; }

        public ICollection<DespesaVO> DespesasVO { get; set; }
        public ICollection<ReceitaVO> ReceitasVO { get; set; }
    }
}
