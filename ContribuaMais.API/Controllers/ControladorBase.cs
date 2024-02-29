using AutoMapper;
using ContribuaMais.API.Models.TiposBase;
using ContribuaMais.API.Servicos.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ContribuaMais.API.Controllers
{
    [ApiController]
    public abstract class ControladorBase<TDto, TEntidade> : ControllerBase
        where TEntidade : EntidadeBase
    {
        protected readonly IServico<TEntidade> _servico;
        protected readonly IMapper _mapper;

        protected ControladorBase(
            IServico<TEntidade> servico, 
            IMapper mapper)
        {
            _servico = servico;
            _mapper = mapper;
        }

        #region GET

        [HttpGet("consultelista")]
        public IList<TDto> ConsulteLista()
        {
            var lista = _servico
                        .ConsulteLista()
                        .Select(_mapper.Map<TDto>)
                        .ToList();

            return lista;
        }

        [HttpGet]
        public TDto ConsultePorCodigo(int codigo)
        {
            var entidade = _servico.Consulte(codigo);

            var dto = _mapper.Map<TDto>(entidade);

            return dto;
        }

        #endregion

        #region POST

        [HttpPost]
        public void Adicione([FromBody] TDto dto)
        {
            var entidade = _mapper.Map<TEntidade>(dto);

            _servico.Cadastre(entidade);
        }

        #endregion

        #region DELETE

        [HttpDelete]
        public TDto Exclua(int codigo)
        {
            var entidade = _servico.Exclua(codigo);

            var dto = _mapper.Map<TDto>(entidade);

            return dto;
        }

        #endregion

        #region PUT

        [HttpPut]
        public void Atualize(TDto dto)
        {
            var entidade = _mapper.Map<TEntidade>(dto);

            _servico.Atualize(entidade);
        }

        #endregion
    }
}