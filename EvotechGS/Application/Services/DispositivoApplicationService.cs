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
    }
}
