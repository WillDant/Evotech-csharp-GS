using EvotechGS.Domain.Entities;
using EvotechGS.Domain.Interfaces;
using EvotechGS.Infrastructure.Data.AppData;

namespace EvotechGS.Infrastructure.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ApplicationContext _context;

        public UsuarioRepository(ApplicationContext context)
        {
            _context = context;
        }

        // Listar todos os usuários
        public IEnumerable<UsuarioEntity> ObterTodosUsuarios()
        {
            return _context.Usuario.ToList();
        }

        // Listar um usuário
        public UsuarioEntity? ObterUsuarioPorId(int id)
        {
            var usuario = _context.Usuario.FirstOrDefault(x => x.id_usuario == id);
            return usuario;
        }

        // Salvar um usuário
        public UsuarioEntity? SalvarUsuario(UsuarioEntity model)
        {
            _context.Usuario.Add(model);
            _context.SaveChanges();
            return model;
        }

        // Atualizar um usuário
        public UsuarioEntity? AtualizarUsuario(int id, UsuarioEntity model)
        {
            var usuario = _context
            .Usuario
            .FirstOrDefault(x => x.id_usuario == id);

            if (usuario is not null)
            {
                usuario.nm_usuario = model.nm_usuario;
                usuario.email = model.email;
                usuario.senha = model.senha;
                usuario.telefone = model.telefone;

                _context.SaveChanges();
                return usuario;
            }
            return model;
        }

        // Deletar um usuário
        public UsuarioEntity? DeletarUsuario(int id)
        {
            var usuario = _context
            .Usuario
            .FirstOrDefault(x => x.id_usuario == id);

            if (usuario is not null)
            {
                _context.Usuario.Remove(usuario);
                _context.SaveChanges();
                return usuario;
            }
            return new UsuarioEntity();
        }
    }
}
