using EvotechGS.Application.Dtos;
using EvotechGS.Application.Interfaces;
using EvotechGS.Domain.Entities;
using EvotechGS.Domain.Interfaces;

namespace EvotechGS.Application.Services
{
    public class DispositivoApplicationService: IDispositivoApplicationService
    {
        private readonly IDispositivoRepository _dispositivoRepository;

        public DispositivoApplicationService(IDispositivoRepository dispositivoRepository)
        {
            _dispositivoRepository = dispositivoRepository;
        }

        public DispositivoEntity? DeletarDispositivo(int id)
        {
            return _dispositivoRepository.DeletarDispositivo(id);
        }

        public DispositivoEntity? ObterDispositivoPorId(int id)
        {
            return _dispositivoRepository.ObterDispositivoPorId(id);
        }

        public IEnumerable<DispositivoEntity> ObterTodosDispositivos()
        {
            return _dispositivoRepository.ObterTodosDispositivos() ?? Enumerable.Empty<DispositivoEntity>();
        }

        public DispositivoEntity? SalvarDispositivo(DispositivoDto entity)
        {
            var dispositivo = new DispositivoEntity
            {
                nm_dispositivo = entity.nm_dispositivo,
                potencia = entity.potencia,
            };
            return _dispositivoRepository.SalvarDispositivo(dispositivo);
        }

        public DispositivoEntity? AtualizarDispositivo(int id, DispositivoDto entity)
        {
            var dispositivo = new DispositivoEntity
            {
                id_dispositivo = id,
                nm_dispositivo = entity.nm_dispositivo,
                potencia = entity.potencia,
            };
            return _dispositivoRepository.AtualizarDispositivo(id, dispositivo);
        }

    }
}
