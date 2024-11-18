using EvotechGS.Domain.Entities;

namespace EvotechGS.Domain.Interfaces
{
    public interface IDispositivoRepository
    {
        IEnumerable<DispositivoEntity> ObterTodosDispositivos();
        DispositivoEntity? ObterDispositivoPorId(int id);
        DispositivoEntity? SalvarDispositivo(DispositivoEntity entity);
        DispositivoEntity? AtualizarDispositivo(DispositivoEntity entity);
        DispositivoEntity? DeletarDispositivo(int id);
    }
}
