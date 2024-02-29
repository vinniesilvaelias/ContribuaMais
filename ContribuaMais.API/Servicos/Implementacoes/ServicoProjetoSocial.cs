using ContribuaMais.API.Dados.Interfaces;
using ContribuaMais.API.Models.Dados;

namespace ContribuaMais.API.Servicos.Implementacoes
{
    public class ServicoProjetoSocial : ServicoBase<ProjetoSocial>
    {
        public ServicoProjetoSocial(IRepositorio<ProjetoSocial> repositorio) : base(repositorio)
        {
        }
    }
}
