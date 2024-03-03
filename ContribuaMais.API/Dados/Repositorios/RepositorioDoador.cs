using ContribuaMais.API.Models.Dados;
using Microsoft.EntityFrameworkCore;

namespace ContribuaMais.API.Dados.Repositorios
{
    public class RepositorioDoador : RepositorioBase<Doador>
    {
        public RepositorioDoador(ContribuaMaisContexto contexto) : base(contexto)
        {
        }

        public override IList<Doador>? ConsulteLista()
        {
            var lista = _contexto
                        .Set<Doador>()
                        .Include(d => d.Pessoa)
                            .ThenInclude(p => p.Endereco)
                        .Include(d => d.Pessoa)
                            .ThenInclude(p => p.DocumentosPessoais)
                        .Include(d => d.Pessoa)
                            .ThenInclude(p => p.Contato)
                        .ToList();

            return lista;
        }

        public override Doador? Consulte(int codigo)
        {
            var doador = _contexto
                        .Set<Doador>()
                        .Include(d => d.Pessoa)
                        .FirstOrDefault(d => d.Codigo == codigo);

            return doador;
        }

        public override Doador? Consulte(Guid id)
        {
            var doador = _contexto
                        .Set<Doador>()
                        .Include(d => d.Pessoa)
                        .FirstOrDefault(d => d.Id == id);

            return doador;
        }
    }
}
