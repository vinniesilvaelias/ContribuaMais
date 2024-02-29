using ContribuaMais.API.Dados.Interfaces;
using ContribuaMais.API.Models.Dados;

namespace ContribuaMais.API.Servicos.Implementacoes
{
    public class ServicoDoacao : ServicoBase<Doacao>
    {
        public ServicoDoacao(IRepositorio<Doacao> repositorio) : base(repositorio)
        {
        }
    }
}