using ContribuaMais.API.Dados.Interfaces;
using ContribuaMais.API.Models.Dados;
using ContribuaMais.API.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace ContribuaMais.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CampanhaController : ControladorBase<DtoCampanha, Campanha>
    {
        public CampanhaController(IRepositorio<Campanha> repositorio) : base(repositorio)
        {
        }

        protected override Campanha Converta(DtoCampanha dto)
        {
               var campanha = new Campanha
               {
                    Codigo = dto.Codigo,
                    Descricao = dto.Descricao,
                    Inicio = dto.Inicio,
                    Fim = dto.Fim,
                    Objetivo = dto.Objetivo,
                    Arrecadado = dto.Arrecadado,
                    Id = Guid.NewGuid()
               };

            return campanha;
        }

        protected override DtoCampanha Converta(Campanha objeto)
        {
            if (objeto is null)
            {
                return new DtoCampanha();
            }

            var dto = new DtoCampanha
            {
                Codigo = objeto.Codigo,
                Descricao = objeto.Descricao,
                Inicio = objeto.Inicio,
                Fim = objeto.Fim,
                Objetivo = objeto.Objetivo,
                Arrecadado = objeto.Arrecadado,
            };

            return dto;
        }
    }
}
