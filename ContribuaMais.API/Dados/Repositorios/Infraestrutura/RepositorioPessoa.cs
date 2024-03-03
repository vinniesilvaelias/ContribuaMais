using ContribuaMais.API.Models.Dados;
using ContribuaMais.API.Models.Dados.Infraestrutura;
using Microsoft.EntityFrameworkCore;

namespace ContribuaMais.API.Dados.Repositorios.Infraestrutura
{
    public class RepositorioPessoa : RepositorioBase<Pessoa>
    {
        public RepositorioPessoa(ContribuaMaisContexto contexto) : base(contexto)
        {
        }

        public override IList<Pessoa> ConsulteLista()
        {
            var lista = _contexto
                        .Set<Pessoa>()
                        .Include(d => d.Endereco)
                        .Include(d => d.DocumentosPessoais)
                        .Include(d => d.Contato)
                        .ToList();

            return lista;
        }

        public override Pessoa? Consulte(int codigo)
        {
            var Pessoa = _contexto
                        .Set<Pessoa>()
                        .Include(d => d.Endereco)
                        .Include(d => d.DocumentosPessoais)
                        .Include(d => d.Contato)
                        .FirstOrDefault(d => d.Codigo == codigo);

            return Pessoa;
        }

        public override Pessoa? Consulte(Guid id)
        {
            var Pessoa = _contexto
                        .Set<Pessoa>()
                        .Include(d => d.Endereco)
                        .Include(d => d.DocumentosPessoais)
                        .Include(d => d.Contato)
                        .FirstOrDefault(d => d.Id == id);

            return Pessoa;
        }
    }
}
