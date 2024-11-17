using EvotechGS.Domain.Entities;
using EvotechGS.Domain.Interfaces;

namespace EvotechGS.Infrastructure.Data.Repositories
{
    public class DispositivoRepository : IDispositivoRepository
    {
        private readonly Contexto _contexto;
        public DispositivoRepository(Contexto contexto)
        {
            _contexto = contexto;
        }
        // Listar todos os dispositivos
        public List<DispositivoEntity> ListarDispositivos()
        {
            return _contexto.Dispositivos.ToList();
        }
        // Listar um dispositivo
        public DispositivoEntity? ObterDispositivoPorId(int id)
        {
            var dispositivo = _contexto.Dispositivos.FirstOrDefault(x => x.Id == id);
            return dispositivo;
        }

        // Salvar um dispositivo
        public DispositivoEntity? SalvarDispositivo(DispositivoEntity model)
        {
            _contexto.Dispositivos.Add(model);
            _contexto.SaveChanges();
            return model;
        }

        // Atualizar um dispositivo
        public DispositivoEntity? AtualizarDispositivo(int id, DispositivoEntity model)
        {
            var dispositivo = _contexto
            .Dispositivos
            .FirstOrDefault(x => x.Id == id);

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
            .Dispositivos
            .FirstOrDefault(x => x.Id == id);
            if (dispositivo is not null)
            {
                _contexto.Dispositivos.Remove(dispositivo);
                _contexto.SaveChanges();
                return dispositivo;
            }
            return new DispositivoEntity();
        }
    }
}
