using ContribuaMais.API.Dados.Interfaces;
using ContribuaMais.API.Models.Dados;
using ContribuaMais.API.Models.Dtos;
using ContribuaMais.API.Models.Enumeradores;
using ContribuaMais.API.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ContribuaMais.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DoacaoController : ControladorBase<DtoDoacao, Doacao>
    {
        public DoacaoController(IRepositorio<Doacao> repositorio) : base(repositorio)
        {
        }

        public IList<DtoDoador> DtoDoadores { get; set; }
        public IList<DtoItem> DtoItens { get; set; }
        public IList<DtoCampanha> DtoCampanhas { get; set; }
        public IList<DtoDoacao> DtoDoacoes { get; set; }

        public IList<Doador> Doadores { get; set; }
        public IList<Item> Itens { get; set; }
        public IList<Campanha> Campanhas { get; set; }
        public IList<Doacao> Doacoes { get; set; }

        protected override Doacao Converta(DtoDoacao dto)
        {
            var objeto = Entidades.Where(x => x.Codigo == dto.Codigo).FirstOrDefault();

            if (objeto == null)
            {
                objeto = new Doacao
                {
                    Id = Guid.NewGuid(),
                    Codigo = dto.Codigo,
                    Item = Itens.Where(x => x.Codigo == dto.Item.Codigo).FirstOrDefault() ?? new Item { Codigo = dto.Item.Codigo },
                    Doador = Doadores.Where(x => x.Codigo == dto.Doador.Codigo).FirstOrDefault() ?? new Doador { Codigo = dto.Item.Codigo },
                    Campanha = Campanhas.Where(x => x.Codigo == dto.Campanha.Codigo).FirstOrDefault() ?? new Campanha { Codigo = dto.Item.Codigo },
                    FoiEfetivada = false,
                    Quantidade = 0
                };
            }

            return objeto;
        }

        protected override DtoDoacao Converta(Doacao objeto)
        {
            var dto = Dtos.Where(x => x.Codigo == objeto.Codigo).FirstOrDefault();

            if (objeto == null)
            {
                dto = new DtoDoacao
                {
                    Codigo = objeto.Codigo,
                    Item = DtoItens.Where(x => x.Codigo == objeto.Item.Codigo).FirstOrDefault() ?? new DtoItem { Codigo = objeto.Item.Codigo },
                    Doador = DtoDoadores.Where(x => x.Codigo == objeto.Doador.Codigo).FirstOrDefault() ?? new DtoDoador { Codigo = objeto.Item.Codigo },
                    Campanha = DtoCampanhas.Where(x => x.Codigo == objeto.Campanha.Codigo).FirstOrDefault() ?? new DtoCampanha { Codigo = objeto.Item.Codigo },
                    FoiEfetivada = false,
                    Quantidade = 0
                };
            }

            return dto;
        }

        protected override void Imprima(DtoDoacao dto)
        {
            throw new NotImplementedException();
        }

        protected override void MockDtos()
        {
            DtoItens = new List<DtoItem> 
            {
                new DtoItem
                {
                    Codigo = 1,
                    Decricao = "Dinheiro",
                    Tipo = EnumTipoItem.DINHEIRO
                },
            };

            DtoCampanhas = new List<DtoCampanha>
            {
                new DtoCampanha
                    {
                        Codigo = 1,
                        Descricao = "Natal sem fome",
                        Inicio = DateTime.Now,
                        Fim = DateTime.Now.AddMonths(3),
                        Objetivo = 1000,
                        Arrecadado = 150
                    }
            };

            DtoDoadores = new List<DtoDoador> 
            {
                new DtoDoador
                {
                    Codigo = 1,
                    Nome = "João",
                    Cpf = "1111111111",
                    Endereco = "Rua A"
                }
            };

            Dtos = new List<DtoDoacao>
            {
                new DtoDoacao
                {
                    Codigo = 1,
                    Item = new DtoItem
                    {
                        Codigo = 1,
                        Decricao = "Dinheiro",
                        Tipo = EnumTipoItem.DINHEIRO
                    },
                    Campanha = new DtoCampanha
                    {
                        Codigo = 1,
                        Descricao = "Natal sem fome",
                        Inicio = DateTime.Now,
                        Fim = DateTime.Now.AddMonths(3),
                        Objetivo = 1000,
                        Arrecadado = 150
                    },
                    Doador = new DtoDoador
                    {
                        Codigo = 1,
                        Nome = "João",
                        Cpf = "1111111111"
                    },
                },
                new DtoDoacao
                {
                    Codigo = 2,
                    Item = new DtoItem
                    {
                        Codigo = 1,
                        Decricao = "Dinheiro",
                        Tipo = EnumTipoItem.DINHEIRO
                    },
                    Campanha = new DtoCampanha
                    {
                        Codigo = 1,
                        Descricao = "Natal sem fome",
                        Inicio = DateTime.Now,
                        Fim = DateTime.Now.AddMonths(3),
                        Objetivo = 1000,
                        Arrecadado = 150
                    },
                    Doador = new DtoDoador
                    {
                        Codigo = 1,
                        Nome = "João",
                        Cpf = "1111111111"
                    },
                },
                new DtoDoacao
                {
                    Codigo = 3,
                    Item = new DtoItem
                    {
                        Codigo = 1,
                        Decricao = "Dinheiro",
                        Tipo = EnumTipoItem.DINHEIRO
                    },
                    Campanha = new DtoCampanha
                    {
                        Codigo = 1,
                        Descricao = "Natal sem fome",
                        Inicio = DateTime.Now,
                        Fim = DateTime.Now.AddMonths(3),
                        Objetivo = 1000,
                        Arrecadado = 150
                    },
                    Doador = new DtoDoador
                    {
                        Codigo = 1,
                        Nome = "João",
                        Cpf = "1111111111"
                    },
                },
            };
        }

        protected override void MockEntidades()
        {
            Itens = new List<Item>
            {
                new Item
                {
                    Codigo = 1,
                    Decricao = "Dinheiro",
                    Tipo = EnumTipoItem.DINHEIRO
                },
            };

            Campanhas = new List<Campanha>
            {
                new Campanha
                    {
                        Codigo = 1,
                        Descricao = "Natal sem fome",
                        Inicio = DateTime.Now,
                        Fim = DateTime.Now.AddMonths(3),
                        Objetivo = 1000,
                        Arrecadado = 150
                    }
            };

            Doadores = new List<Doador>
            {
                new Doador
                {
                    Codigo = 1,
                    Nome = "João",
                    Cpf = "1111111111"
                }
            };

            Entidades = Dtos.Select(Converta).ToList();
        }
    }
}
