using EvotechGS.Domain.Entities;
using EvotechGS.Domain.Interfaces;
using EvotechGS.Infrastructure.Data.AppData;

namespace EvotechGS.Infrastructure.Data.Repositories
{
    public class DispositivoRepository : IDispositivoRepository
    {
        private readonly ApplicationContext _contexto;
        public DispositivoRepository(ApplicationContext contexto)
        {
            _contexto = contexto;
        }
        // Listar todos os dispositivos
        public IEnumerable<DispositivoEntity> ObterTodosDispositivos()
        {
            return _contexto.Dispositivo.ToList();
        }
        // Listar um dispositivo
        public DispositivoEntity? ObterDispositivoPorId(int id)
        {
            var dispositivo = _contexto.Dispositivo.FirstOrDefault(x => x.id_dispositivo == id);
            return dispositivo;
        }

        // Salvar um dispositivo
        public DispositivoEntity? SalvarDispositivo(DispositivoEntity model)
        {
            _contexto.Dispositivo.Add(model);
            _contexto.SaveChanges();
            return model;
        }

        // Atualizar um dispositivo
        public DispositivoEntity? AtualizarDispositivo(int id, DispositivoEntity model)
        {
            var dispositivo = _contexto
            .Dispositivo
            .FirstOrDefault(x => x.id_dispositivo == id);

            if (dispositivo is not null)
            {
                dispositivo.nm_dispositivo = model.nm_dispositivo;
                dispositivo.potencia = model.potencia;
                _contexto.SaveChanges();
                return dispositivo;
            }

            return model;
        }
        public DispositivoEntity? DeletarDispositivo(int id)
        {
            var dispositivo = _contexto
            .Dispositivo
            .FirstOrDefault(x => x.id_dispositivo == id);
            if (dispositivo is not null)
            {
                _contexto.Dispositivo.Remove(dispositivo);
                _contexto.SaveChanges();
                return dispositivo;
            }
            return new DispositivoEntity();
        }
    }
}
