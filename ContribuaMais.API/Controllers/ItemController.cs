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
        protected override void Imprima(DtoItem dto)
        {
            Console.Clear();
            Console.WriteLine(dto.Decricao);
            Console.WriteLine(dto.Tipo.ToString());

        }

        protected override Item Converta(DtoItem dto)
        {
            var objeto = Entidades.Where(x => x.Codigo == dto.Codigo).FirstOrDefault();

            if (objeto == null)
            {
                objeto = new Item
                {
                    Codigo = dto.Codigo,
                    Decricao = dto.Decricao,
                    Tipo = dto.Tipo
                };
            }

            return objeto;
        }

        protected override DtoItem Converta(Item objeto)
        {
            var dto = Dtos.Where(x => x.Codigo == objeto.Codigo).FirstOrDefault();

            if (dto == null)
            {
                dto = new DtoItem
                {
                    Codigo = Dtos.Count + 1,
                    Decricao = objeto.Decricao,
                    Tipo = objeto.Tipo
                };
            }

            return dto;
        }

        protected override void MockEntidades()
        {
            Entidades = Dtos.Select(Converta).ToList();
        }

        protected override void MockDtos()
        {
            Dtos = new List<DtoItem>
            {
                new DtoItem
                {
                    Codigo = 1,
                    Decricao = "Dinheiro",
                    Tipo = EnumTipoItem.DINHEIRO
                },
                new DtoItem
                {
                    Codigo = 2,
                    Decricao = "Roupas de frio infantil",
                    Tipo = EnumTipoItem.VESTUARIO
                },
                new DtoItem
                {
                    Codigo = 3,
                    Decricao = "Sangue",
                    Tipo = EnumTipoItem.SAUDE
                },
            };
        }
    }
}
