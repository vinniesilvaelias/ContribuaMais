//using ContribuaMais.API.Models;
//using ContribuaMais.API.Models.Dados;
//using ContribuaMais.API.Models.Enumeradores;
//using Microsoft.AspNetCore.Mvc;

//namespace ContribuaMais.API.Controllers
//{
//    [ApiController]
//    [Route("[controller]")]
//    public class CampanhaController : ControladorBase<Campanha>
//    {
//        protected override void MockItens()
//        {
//            Itens = new List<Campanha>
//            {
//                new Campanha
//                {
//                    Descricao = "Campanha do Agazalho",
//                    Inicio = DateTime.Now,
//                    Fim = DateTime.Now.AddMonths(1),
//                    Objetivo = new Item
//                    {
//                        Descricao = "Roupas de frio",
//                        Quantidade = 1000
//                    },
//                    TotalArrecadado = 0,
//                    //Arrecadado =  new ItemArrecadado
//                    //{
//                    //    Item = new Item
//                    //    {
//                    //        Descricao = "Roupas de frio",
//                    //        Quantidade = 1000
//                    //    },
//                    //    QuantidadeArrecadada = 0
//                    //},
//                    EstaAtiva = true
//                },
//                new Campanha
//                {
//                    Descricao = "Campanha dinheiro",
//                    Inicio = DateTime.Now,
//                    Fim = DateTime.Now.AddMonths(1),
//                    Objetivo = new Item
//                    {
//                        Descricao = "Comida",
//                        Quantidade = 1000
//                    },
//                    TotalArrecadado = 0,
//                    //Arrecadado =  new ItemArrecadado
//                    //{
//                    //    Item = new Item
//                    //    {
//                    //        Descricao = "Comida",
//                    //        Quantidade = 1000
//                    //    },
//                    //    QuantidadeArrecadada = 0
//                    //},
//                    EstaAtiva = true
//                }
//            };
//        }

//        protected override void Imprima(Campanha EntidadeBase)
//        {
//            Console.Clear();
//            Console.WriteLine(EntidadeBase.Descricao);
//            Console.WriteLine(EntidadeBase.Objetivo.Descricao);
//            Console.WriteLine(EntidadeBase.Objetivo.Quantidade);
//            Console.WriteLine(EntidadeBase.TotalArrecadado);
//            //Console.WriteLine(EntidadeBase.Arrecadado.QuantidadeArrecadada);
//            Console.WriteLine(EntidadeBase.Inicio);
//            Console.WriteLine(EntidadeBase.Fim);
//        }
//    }
//}
