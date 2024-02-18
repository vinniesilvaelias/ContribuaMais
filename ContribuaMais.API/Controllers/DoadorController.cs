//using ContribuaMais.API.Models.Dados;
//using Microsoft.AspNetCore.Mvc;

//namespace ContribuaMais.API.Controllers
//{
//    [ApiController]
//    [Route("[controller]")]
//    public class DoadorController : ControladorBase<Doador>
//    {
//        protected override void Imprima(Doador EntidadeBase)
//        {
//            Console.WriteLine(EntidadeBase.Codigo);
//            Console.WriteLine(EntidadeBase.Nome);
//            Console.WriteLine(EntidadeBase.Cpf);
//            Console.WriteLine(EntidadeBase.Endereco);
//        }

//        protected override void MockItens()
//        {
//            Itens = new List<Doador> 
//            {
//                new Doador
//                {
//                    Codigo = 1,
//                    Nome = "Joao",
//                    Endereco = "Rua A",
//                    Cpf = "111111"
//                },
//                new Doador
//                {
//                    Codigo = 2,
//                    Nome = "Maria",
//                    Endereco = "Rua B",
//                    Cpf = "222222"
//                },
//                new Doador
//                {
//                    Codigo = 3,
//                    Nome = "Jose",
//                    Endereco = "Rua C",
//                    Cpf = "333333"
//                },
//            };
//        }
//    }
//}
