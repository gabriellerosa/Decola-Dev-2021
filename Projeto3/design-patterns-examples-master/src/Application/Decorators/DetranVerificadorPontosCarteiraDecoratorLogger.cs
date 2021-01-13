using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Services;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace DesignPatternSamples.Application.Decorators
{
    public class DetranVerificadorPontosCarteiraDecoratorLogger : IDetranVerificadorPontosCarteiraService
    {
        private readonly IDetranVerificadorPontosCarteiraService _Inner;
        private readonly ILogger<DetranVerificadorPontosCarteiraDecoratorLogger> _Logger;

        public DetranVerificadorPontosCarteiraDecoratorLogger(
            IDetranVerificadorPontosCarteiraService inner,
            ILogger<DetranVerificadorPontosCarteiraDecoratorLogger> logger)
        {
            _Inner = inner;
            _Logger = logger;
        }

        public async Task<IEnumerable<PontosCarteiraVeiculo>> ConsultarPontosCarteira(Veiculo veiculo)
        {
            Stopwatch watch = Stopwatch.StartNew();
            _Logger.LogInformation($"Iniciando a execução do método ConsultarPontosCarteira({veiculo})");
            var result = await _Inner.ConsultarPontosCarteira(veiculo);
            watch.Stop(); 
            _Logger.LogInformation($"Encerrando a execução do método ConsultarPontosCarteira({veiculo}) {watch.ElapsedMilliseconds}ms");
            return result;
        }
    }
}