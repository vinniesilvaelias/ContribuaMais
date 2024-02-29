using ContribuaMais.API.Dados.Interfaces;
using ContribuaMais.API.Models.Dados;

namespace ContribuaMais.API.Servicos.Implementacoes
{
    public class ServicoDoador : ServicoBase<Doador>
    {
        public ServicoDoador(IRepositorio<Doador> repositorio) : base(repositorio)
        {
        }
    }
}
