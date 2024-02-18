//using ContribuaMais.API.Models.Dados;
//using Microsoft.AspNetCore.Mvc;

//namespace ContribuaMais.API.Controllers
//{
//    [ApiController]
//    [Route("[controller]")]
//    public class ProjetoSocialController : ControladorBase<ProjetoSocial>
//    {
//        protected override void Imprima(ProjetoSocial EntidadeBase)
//        {
//            Console.WriteLine(EntidadeBase.Nome);
//            Console.WriteLine(EntidadeBase.Cnpj);
//        }

//        protected override void MockItens()
//        {
//            Itens = new List<ProjetoSocial>
//            {
//                new ProjetoSocial
//                {
//                    Nome = "OVG",
//                    Cnpj = "11111111"
//                },
//                new ProjetoSocial
//                {
//                    Nome = "Teletom",
//                    Cnpj = "222222"
//                },
//                new ProjetoSocial
//                {
//                    Nome = "Criança Esperança",
//                    Cnpj = "3333333"
//                },
//            };
//        }
//    }
//}
