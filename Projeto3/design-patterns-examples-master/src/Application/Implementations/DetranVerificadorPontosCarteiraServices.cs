using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Repository;
using DesignPatternSamples.Application.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Application.Implementations
{
    public class DetranVerificadorPontosCarteiraServices : IDetranVerificadorPontosCarteiraService
    {
        private readonly IDetranVerificadorPontosCarteiraFactory _Factory;

        public DetranVerificadorPontosCarteiraServices(IDetranVerificadorPontosCarteiraFactory factory)
        {
            _Factory = factory;
        }

        public Task<IEnumerable<PontosCarteiraVeiculo>> ConsultarPontosCarteira(Veiculo veiculo)
        {
            IDetranVerificadorPontosCarteiraRepository repository = _Factory.Create(veiculo.UF);
            return repository.ConsultarPontosCarteira(veiculo);
        }
    }
}
