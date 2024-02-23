using ContribuaMais.API.Dados.Interfaces;
using ContribuaMais.API.Dados.Repositorios;
using ContribuaMais.API.Models.Interfaces;
using ContribuaMais.API.Models.TiposBase;
using Microsoft.AspNetCore.Mvc;

namespace ContribuaMais.API.Controllers
{
    [ApiController]
    public abstract class ControladorBase<TDto, TEntidade> 
        : ControllerBase
        where TDto : IDto, new()
        where TEntidade : EntidadeBase, new()
    {
        protected readonly IRepositorio<TEntidade> _repositorio;

        protected ControladorBase(IRepositorio<TEntidade> repositorio)
        {
            _repositorio = repositorio;
        }

        #region GET

        [HttpGet("consultelista")]
        public IList<TDto> ConsulteLista()
        {
            var lista = _repositorio
                .ConsulteLista()
                .Select(Converta)
                .ToList();

            return lista;
        }

        [HttpGet]
        public TDto ConsultePorCodigo(int codigo)
        {
            var dto = Converta(_repositorio.Consulte(codigo));

            return dto;
        }

        #endregion

        #region POST

        [HttpPost]
        public void Adicione([FromBody] TDto dto)
        {
            var entidade = Converta(dto);

            _repositorio.Cadastre(entidade);
        }

        #endregion

        #region DELETE

        [HttpDelete]
        public TDto Exclua(int codigo)
        {
            var dto = Converta(_repositorio.Exclua((codigo)));

            return dto;
        }

        #endregion

        #region PUT

        [HttpPut]
        public void Atualize(TDto DtoBase)
        {
            var objeto = Converta(DtoBase);

            _repositorio.Atualize(objeto);
        }

        #endregion

        protected abstract TEntidade Converta(TDto dto);
        protected abstract TDto Converta(TEntidade objeto);
    }
}
