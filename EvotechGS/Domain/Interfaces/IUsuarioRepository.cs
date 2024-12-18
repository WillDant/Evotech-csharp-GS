﻿using EvotechGS.Domain.Entities;


namespace EvotechGS.Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        IEnumerable<UsuarioEntity> ObterTodosUsuarios();
        UsuarioEntity? ObterUsuarioPorId(int id);
        UsuarioEntity? SalvarUsuario(UsuarioEntity entity);
        UsuarioEntity? AtualizarUsuario(int id, UsuarioEntity entity);
        UsuarioEntity? DeletarUsuario(int id);
    }
}
