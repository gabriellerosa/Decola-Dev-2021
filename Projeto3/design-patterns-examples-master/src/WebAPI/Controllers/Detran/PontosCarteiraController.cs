using AutoMapper;
using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Services;
using DesignPatternSamples.WebAPI.Models;
using DesignPatternSamples.WebAPI.Models.Detran;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.WebAPI.Controllers.Detran
{
    [Route("api/Detran/[controller]")]
    [ApiController]
    public class PontosCarteiraController : ControllerBase
    {
        private readonly IMapper _Mapper;
        private readonly IDetranVerificadorPontosCarteiraService _DetranVerificadorPontosCarteiraServices;

        public PontosCarteiraController(IMapper mapper, IDetranVerificadorPontosCarteiraService detranVerificadorPontosCarteiraServices)
        {
            _Mapper = mapper;
            _DetranVerificadorPontosCarteiraServices = detranVerificadorPontosCarteiraServices;
        }

        [HttpGet()]
        [ProducesResponseType(typeof(SuccessResultModel<IEnumerable<PontosCarteiraVeiculoModel>>), StatusCodes.Status200OK)]
        public async Task<ActionResult> Get([FromQuery]VeiculoModel model)
        {
            var pontosCarteira = await _DetranVerificadorPontosCarteiraServices.ConsultarPontosCarteira(_Mapper.Map<Veiculo>(model));

            //var result = new SuccessResultModel<IEnumerable<PontosCarteiraVeiculoModel>>(_Mapper.Map<IEnumerable<PontosCarteiraVeiculoModel>>(pontosCarteira));

            var result = new SuccessResultModel<PontosCarteiraVeiculo>(new PontosCarteiraVeiculo { DataOcorrencia = System.DateTime.Now, Descricao="teste", Pontos=1});
            
            
            
            return Ok(result);
        }
    }
}