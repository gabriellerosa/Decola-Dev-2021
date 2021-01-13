using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Repository;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Infra.Repository.Detran
{
    public class DetranSPVerificadorPontosCarteiraRepository : IDetranVerificadorPontosCarteiraRepository
    {
        private readonly ILogger _Logger;

       
        public Task<IEnumerable<PontosCarteiraVeiculo>> ConsultarPontosCarteira(Veiculo veiculo)
        {
           // _Logger.LogDebug($"Consultando pontos na carteira do veículo placa {veiculo.Placa} para o estado de SP.");
            return Task.FromResult<IEnumerable<PontosCarteiraVeiculo>>(new List<PontosCarteiraVeiculo>() { new PontosCarteiraVeiculo() });
        }
    }
}
