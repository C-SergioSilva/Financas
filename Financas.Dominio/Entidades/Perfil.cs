using Financas.Dominio.Identidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financas.Dominio.Entidades
{
    public class Perfil : EntidadeBase
    {
        public int IdPerfil { get; set; }
        public string Descricao { get; set; }
        public ICollection<Usuario> Usuarios { get; set; }
    }
}
