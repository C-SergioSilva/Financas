using AutoMapper;
using Financas.Dominio.Entidades;
using Financas.Dominio.Interfaces;
using Financas.Negocio.EntidadeVO;
using Financas.Negocio.Interfaces;

namespace Financas.Negocio.Negocios
{
    public class NegocioPerfil : INegocioPerfil
    {
        protected readonly IMapper map;

        protected readonly IRepositorioPerfil repositorio;

        public NegocioPerfil(IMapper map, IRepositorioPerfil repositorio)
        {
            this.map = map;
            this.repositorio = repositorio;
        }

        public async Task<PerfilVO> AdicionarSalvar(PerfilVO perfilVO)
        {
            try
            {
                var perfilMap = map.Map<Perfil>(perfilVO);
                var perfil = await repositorio.AdicionarSalvar(perfilMap);
                var perfilRetorno = map.Map<PerfilVO>(perfil);

                return perfilRetorno;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<PerfilVO> AtualizarPerfil(PerfilVO perfilVO)
        {
            try
            {
                var perfilMap = map.Map<Perfil>(perfilVO);
                var perfil = await repositorio.AtualizarPerfil(perfilMap);
                var perfilRetorno = map.Map<PerfilVO>(perfil);

                return perfilRetorno;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<PerfilVO> ObterPerfilPorId(int Id)
        {
            try
            {
                var perfil = await repositorio.ObterPerfilPorId(Id);
                var perfilMap = map.Map<PerfilVO>(perfil);

                return perfilMap;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<IEnumerable<PerfilVO>> ObterTodos()
        {
            try
            {
                var lPerfil = await repositorio.ObterTodos();

                var perfilMap = map.Map<IEnumerable<PerfilVO>>(lPerfil);
                return perfilMap;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task StatusDeletado(int Id)
        {
            try
            {
                var perfil = await repositorio.ObterPerfilPorId(Id);

                perfil.Deletado = true;

                await repositorio.StatusDeletado(perfil);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
