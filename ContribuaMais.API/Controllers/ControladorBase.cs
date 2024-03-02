using AutoMapper;
using ContribuaMais.API.Extencoes;
using ContribuaMais.API.Models.Dtos;
using ContribuaMais.API.Models.TiposBase;
using ContribuaMais.API.Servicos.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ContribuaMais.API.Controllers
{
    [ApiController]
    public abstract class ControladorBase<TDto, TEntidade> : ControllerBase
        where TEntidade : EntidadeBase
        where TDto : DtoBase
    {
        protected readonly IServico<TEntidade> _servico;

        protected readonly IMapper _mapper;
        
        const int QUANTIDADE_POR_PAGINA = 2;

        protected ControladorBase(
            IServico<TEntidade> servico, 
            IMapper mapper)
        {
            _servico = servico;
            _mapper = mapper;
        }

        #region GET

        [HttpGet("consultelista")]
        public IActionResult ConsulteLista()
        {
            var lista = _servico
                        .ConsulteLista()
                        .Select(_mapper.Map<TDto>)
                        .OrderBy(x => x.Codigo)
                        .ToList();

            return lista.PossuiValor() ? Ok(lista) : NoContent();
        }

        [HttpGet]
        public IActionResult ConsultePorCodigo(int codigo)
        {
            var entidade = _servico.Consulte(codigo);

            if (!entidade.PossuiValor())
            {
                return NotFound();
            }

            var dto = _mapper.Map<TDto>(entidade);

            return Ok(dto);
        }

        [HttpGet("consultepaginado")]
        public IActionResult ConsultePaginado(int pagina = 1, int quantidade = 10)
        {
            var lista = _servico
                .ConsulteLista()
                .Skip((pagina - 1) * QUANTIDADE_POR_PAGINA)
                .Take(quantidade)
                .Select(_mapper.Map<TDto>)
                .ToList();

            return lista.PossuiValor() ? Ok(lista) : NotFound();
        }

        #endregion

        #region POST

        [HttpPost]
        public IActionResult Cadastre([FromBody] TDto dto)
        {
            var entidade = _mapper.Map<TEntidade>(dto);

            if (!entidade.PossuiValor())
            {
                return NotFound();
            }

            _servico.Cadastre(entidade);

            return CreatedAtAction(nameof(ConsultePorCodigo), new { entidade.Codigo }, dto);
        }

        [HttpPost("cadastrelista")]
        public IActionResult CadastreLista([FromBody] IList<TDto> listaDto) 
        {
            if (!listaDto.PossuiValor())
            {
                return NoContent();
            }

            var lista = listaDto
                        .Select(_mapper.Map<TEntidade>)
                        .ToList();

            _servico.CadastreLista(lista);

            return Ok(lista);
        }

        #endregion

        #region DELETE

        [HttpDelete]
        public IActionResult Exclua(int codigo)
        {
            var entidade = _servico.Exclua(codigo);

            if (!entidade.PossuiValor())
            {
                return NotFound();
            }

            var dto = _mapper.Map<TDto>(entidade);

            return Ok(dto);
        }

        #endregion

        #region PUT

        [HttpPut]
        public IActionResult Atualize(TDto dto)
        {
            var entidade = _mapper.Map<TEntidade>(dto);

            if (!entidade.PossuiValor())
            {
                return NotFound();
            }

            _servico.Atualize(entidade);

            return Ok(entidade);
        }

        #endregion
    }
}