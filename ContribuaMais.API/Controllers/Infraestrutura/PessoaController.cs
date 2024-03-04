using AutoMapper;
using ContribuaMais.API.Models.Dados.Dtos.Infraestrutura;
using ContribuaMais.API.Models.Dados.Infraestrutura;
using ContribuaMais.API.Servicos.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ContribuaMais.API.Controllers.Infraestrutura
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControladorBase<DtoPessoa, Pessoa>
    {
        public PessoaController(IServico<Pessoa> servico, IMapper mapper) : base(servico, mapper)
        {
        }
    }
}
