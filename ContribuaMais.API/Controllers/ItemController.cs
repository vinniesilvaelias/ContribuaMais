//using ContribuaMais.API.Models.Dados;
//using Microsoft.AspNetCore.Mvc;

//namespace ContribuaMais.API.Controllers
//{
//    [ApiController]
//    [Route("[controller]")]
//    public class ItemController : ControllerBase
//    {
//        public IList<Item> Itens { get; set; } = new List<Item>();

//        #region GET

//        [HttpGet]
//        public IList<Item> ObtenhaItens()
//        {
//            MockItens();
//            return Itens;
//        }

//        [HttpGet]
//        public Item ObtenhaPorCodigo(int codigo)
//        {
//            var item = Itens.Where(x => x.Codigo == codigo).FirstOrDefault();
//            return item;
//        }

//        #endregion

//        #region POST

//        [HttpPost]
//        public void Adicione([FromBody] Item item)
//        {
//            Itens.Add(item);
//        }

//        #endregion

//        #region DELETE
        
//        [HttpDelete]
//        public Item Exclua(int codigo)
//        {
//            var item = ObtenhaPorCodigo(codigo);
//            Itens.Remove(item);
//            return item;
//        }

//        #endregion

//        #region PUT

//        [HttpPut]
//        public void Atualize(Item item)
//        {
//            Exclua(item.Codigo);
//            Adicione(item);
//        }

//        #endregion

//        private void MockItens()
//        {
//            Itens = new List<Item>
//            {
//                new Item
//                {
//                    Codigo = 1,
//                    Descricao = "Roupa de cama",
//                },
//                new Item
//                {
//                    Codigo = 2,
//                    Descricao = "Dinheiro",
//                },
//                new Item
//                {
//                    Codigo = 3,
//                    Descricao = "Comida",
//                },
//                new Item
//                {
//                    Codigo = 4,
//                    Descricao = "Papel higiênico",
//                }
//            };
//        }
//    }
//}
