using ContribuaMais.API.Models.TiposBase;
using Microsoft.AspNetCore.Mvc;

namespace ContribuaMais.API.Controllers
{
    [ApiController]
    public abstract class ControladorBase<T> 
        : ControllerBase
        where T : DtoBase
    {
        public IList<T> Itens { get; set; }

        #region GET

        [HttpGet]
        public IList<T> ObtenhaItens()
        {
            MockItens();
            return Itens;
        }

        [HttpGet]
        public DtoBase ObtenhaPorCodigo(int codigo)
        {
            var DtoBase = Itens.Where(x => x.Codigo == codigo).FirstOrDefault();
            return DtoBase;
        }

        #endregion

        #region POST

        [HttpPost]
        public void Adicione([FromBody] T DtoBase)
        {
            Itens.Add(DtoBase);
        }

        #endregion

        #region DELETE

        [HttpDelete]
        public T Exclua(int codigo)
        {
            var objeto = ObtenhaPorCodigo(codigo);

            Itens.Remove((T)objeto);

            return (T)objeto;
        }

        #endregion

        #region PUT

        [HttpPut]
        public void Atualize(T DtoBase)
        {
            Exclua(DtoBase.Codigo);
            Adicione(DtoBase);
        }

        #endregion

        protected abstract void MockItens();
        protected abstract void Imprima(T DtoBase);
    }
}
