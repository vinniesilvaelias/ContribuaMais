using ContribuaMais.API.Dados.Interfaces;
using ContribuaMais.API.Models.Dados;
using ContribuaMais.API.Models.Dtos;
using ContribuaMais.API.Models.Enumeradores;
using Microsoft.AspNetCore.Mvc;

namespace ContribuaMais.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControladorBase<DtoItem, Item>
    {
        public ItemController(IRepositorio<Item> repositorio) : base(repositorio)
        {
        }

        protected override Item Converta(DtoItem dto)
        {
            var objeto = new Item
                {
                    Codigo = dto.Codigo,
                    Decricao = dto.Decricao,
                    Tipo = dto.Tipo
                };

            return objeto;
        }

        protected override DtoItem Converta(Item objeto)
        {
            var dto = new DtoItem
            {
                Codigo = 1,
                Decricao = objeto.Decricao,
                Tipo = objeto.Tipo
            };

            return dto;
        }
    }
}
