using EvotechGS.Application.Dtos;
using EvotechGS.Application.Interfaces;
using EvotechGS.Domain.Entities;
using EvotechGS.Domain.Interfaces;
using EvotechGS.Infrastructure.Data.Repositories;

namespace EvotechGS.Application.Services
{
    public class UsuarioApplicationService : IUsuarioApplicationService
    {
        private readonly IUsuarioRepository _usuarioRepository;


        public UsuarioApplicationService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        //Deletar Usuario
        public UsuarioEntity? DeletarUsuario(int id)
        {
            return _usuarioRepository.DeletarUsuario(id);
        }

        //Atualizar Usuario
        public UsuarioEntity? AtualizarUsuario(int id, UsuarioDto entity)
        {
            var usuario = new UsuarioEntity
            {
                id_usuario = id,
                nm_usuario = entity.nm_usuario,
                email = entity.email,
                senha = entity.senha,
                telefone = entity.telefone
            };
            return _usuarioRepository.AtualizarUsuario(id, usuario);
        }

        //Obter Usuario por Id
        public UsuarioEntity? ObterUsuarioPorId(int id)
        {
            return _usuarioRepository.ObterUsuarioPorId(id);
        }

        //Obter todos os Usuarios
        public IEnumerable<UsuarioEntity> ObterTodosUsuarios()
        {
            return _usuarioRepository.ObterTodosUsuarios();
        }

        // Salvar Usuario
        public UsuarioEntity? SalvarUsuario(UsuarioDto entity)
        {
            var usuario = new UsuarioEntity
            {
                nm_usuario = entity.nm_usuario,
                email = entity.email,
                senha = entity.senha,
                telefone = entity.telefone
            };
            return _usuarioRepository.SalvarUsuario(usuario);
        }

    }



}
