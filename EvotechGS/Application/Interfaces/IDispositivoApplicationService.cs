using EvotechGS.Application.Dtos;
using EvotechGS.Domain.Entities;


namespace EvotechGS.Application.Interfaces
{
    public interface IDispositivoApplicationService
    {
        IEnumerable<DispositivoEntity> ObterTodosDispositivos();
        DispositivoEntity? ObterDispositivoPorId(int id);
        DispositivoEntity? SalvarDispositivo(DispositivoDto entity);
        DispositivoEntity? AtualizarDispositivo(int id, DispositivoDto entity);
        DispositivoEntity? DeletarDispositivo(int id);
    }
}
