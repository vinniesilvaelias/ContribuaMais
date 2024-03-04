using ContribuaMais.API.Models.Dados;
using Microsoft.EntityFrameworkCore;

namespace ContribuaMais.API.Dados.Repositorios
{
    public class RepositorioProjetoSocial : RepositorioBase<ProjetoSocial>
    {
        public RepositorioProjetoSocial(ContribuaMaisContexto contexto) : base(contexto)
        {
        }

        public override IList<ProjetoSocial>? ConsulteLista()
        {
            var lista = _contexto
                        .Set<ProjetoSocial>()
                        .Include(ps => ps.Campanhas)
                        .Include(ps => ps.PessoaResponsavel)
                            .ThenInclude(p => p.Endereco)
                        .Include(ps => ps.PessoaResponsavel)
                            .ThenInclude(p => p.Contato)
                        .Include(ps => ps.PessoaResponsavel)
                            .ThenInclude(p => p.DocumentosPessoais)
                        .Include(ps => ps.PessoaResponsavel)
                        .ToList();

            return lista;
        }

        public override ProjetoSocial? Consulte(int codigo)
        {
            var projetoSocial = _contexto
                        .Set<ProjetoSocial>()
                        .Include(ps => ps.Campanhas)
                        .Include(ps => ps.PessoaResponsavel)
                            .ThenInclude(p => p.Endereco)
                        .Include(ps => ps.PessoaResponsavel)
                            .ThenInclude(p => p.Contato)
                        .Include(ps => ps.PessoaResponsavel)
                            .ThenInclude(p => p.DocumentosPessoais)
                        .Include(ps => ps.PessoaResponsavel)
                        .FirstOrDefault(d => d.Codigo == codigo);

            return projetoSocial;
        }

        public override ProjetoSocial? Consulte(Guid id)
        {
            var ProjetoSocial = _contexto
                        .Set<ProjetoSocial>()
                        .Include(ps => ps.Campanhas)
                        .Include(ps => ps.PessoaResponsavel)
                            .ThenInclude(p => p.Endereco)
                        .Include(ps => ps.PessoaResponsavel)
                            .ThenInclude(p => p.Contato)
                        .Include(ps => ps.PessoaResponsavel)
                            .ThenInclude(p => p.DocumentosPessoais)
                        .Include(ps => ps.PessoaResponsavel)
                        .FirstOrDefault(d => d.Id == id);

            return ProjetoSocial;
        }
    }
}
