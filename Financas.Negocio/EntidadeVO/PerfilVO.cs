namespace Financas.Negocio.EntidadeVO
{
    public class PerfilVO
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public bool Deletado { get; set; }

        public ICollection<UsuarioVO> UsuariosVO { get; set; }
    }
}
