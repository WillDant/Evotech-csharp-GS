using EvotechGS.Application.Dtos;
using EvotechGS.Domain.Entities;

namespace EvotechGS.Application.Interfaces
{
    public interface IUsuarioApplicationContext
    {
        IEnumerable<UsuarioDto> ObterTodosUsuarios();
        UsuarioEntity? ObterUsuarioPorId(int id);
        UsuarioEntity? SalvarUsuario(UsuarioDto entity);
        UsuarioEntity? AtualizarUsuario(int id, UsuarioDto entity);
        UsuarioEntity? DeletarUsuario(int id);
    }
}
