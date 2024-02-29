using ContribuaMais.API.Dados.Interfaces;
using ContribuaMais.API.Models.Dados;
using ContribuaMais.API.Models.TiposBase;
using Microsoft.EntityFrameworkCore;

namespace ContribuaMais.API.Dados.Repositorios
{
    public class RepositorioDoacao : RepositorioBase<Doacao>
    {
        public RepositorioDoacao(ContribuaMaisContexto contexto) :base(contexto)
        {
        }
        
        public override IList<Doacao> ConsulteLista()
        {
            var lista = _contexto
                        .Set<Doacao>()
                        .Include(d => d.Item)
                        .Include(d => d.Doador)
                        .Include(d => d.Campanha)
                        .ToList();

            return lista;
        }

        public override Doacao Consulte(int codigo)
        {
            var doacao = _contexto
                        .Set<Doacao>()
                        .Include(d => d.Item)
                        .Include(d => d.Doador)
                        .Include(d => d.Campanha)
                        .FirstOrDefault(d => d.Codigo == codigo);

            return doacao;
        }

        public override Doacao Consulte(Guid id)
        {
            var doacao = _contexto
                        .Set<Doacao>()
                        .Include(d => d.Item)
                        .Include(d => d.Doador)
                        .Include(d => d.Campanha)
                        .FirstOrDefault(d => d.Id == id);

            return doacao;
        }
    }
}