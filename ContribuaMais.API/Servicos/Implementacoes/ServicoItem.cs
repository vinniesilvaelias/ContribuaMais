using ContribuaMais.API.Dados.Interfaces;
using ContribuaMais.API.Models.Dados;

namespace ContribuaMais.API.Servicos.Implementacoes
{
    public class ServicoItem : ServicoBase<Item>
    {
        public ServicoItem(IRepositorio<Item> repositorio) : base(repositorio)
        {
        }
    }
}
