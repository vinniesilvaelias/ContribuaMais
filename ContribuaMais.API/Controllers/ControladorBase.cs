using ContribuaMais.API.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ContribuaMais.API.Controllers
{
    [ApiController]
    public abstract class ControladorBase<TDto, TEntidade> 
        : ControllerBase
        where TDto : IDto, new()
        where TEntidade : IEntidadeBase, new()
    {
        public IList<TEntidade> Entidades { get; set; } = new List<TEntidade>();
        public IList<TDto> Dtos { get; set; } = new List<TDto>();

        #region GET

        [HttpGet("consultelista")]
        public IList<TDto> ConsulteLista()
        {
            MockDtos();
            
            MockEntidades();
            
            return Dtos;
        }

        [HttpGet]
        public TDto ConsultePorCodigo(int codigo)
        {
            MockDtos();

            MockEntidades();

            var dto = Dtos.Where(x => x.Codigo == codigo).FirstOrDefault();

            return dto ?? new TDto();
        }

        #endregion

        #region POST

        [HttpPost]
        public void Adicione([FromBody] TDto dto)
        {
            Dtos.Add(dto);

            var objeto = Converta(dto);

            objeto.Id = Guid.NewGuid();

            Entidades.Add(objeto);
        }

        #endregion

        #region DELETE

        [HttpDelete]
        public TDto Exclua(int codigo)
        {
            MockDtos();

            MockEntidades();

            var dto = ConsultePorCodigo(codigo);
            
            var objeto = Converta(dto);

            Dtos.Remove(dto);

            Entidades.Remove(objeto);

            return dto;
        }

        #endregion

        #region PUT

        [HttpPut]
        public void Atualize(TDto DtoBase)
        {
            MockDtos();

            MockEntidades();

            Exclua(DtoBase.Codigo);

            Adicione(DtoBase);
        }

        #endregion

        protected abstract void MockEntidades();
        protected abstract void MockDtos();
        protected abstract void Imprima(TDto dto);
        protected abstract TEntidade Converta(TDto dto);
        protected abstract TDto Converta(TEntidade objeto);
    }
}
