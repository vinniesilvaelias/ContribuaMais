using ContribuaMais.API.Dados.Interfaces;
using ContribuaMais.API.Models.TiposBase;

namespace ContribuaMais.API.Dados.Repositorios
{
    public class RepositorioGenerico<TEntidade> : IRepositorio<TEntidade>
        where TEntidade : EntidadeBase
    {
        private ContribuaMaisContexto _contexto;

        public RepositorioGenerico(ContribuaMaisContexto contexto)
        {
            _contexto  = contexto;
        }
        public void Atualize(TEntidade entidade)
        {
            _contexto.Update(entidade);
            _contexto.SaveChanges();
        }

        public void Cadastre(TEntidade entidade)
        {
            _contexto.Add(entidade);
            _contexto.SaveChanges();
        }

        public TEntidade Consulte(Guid id)
        {
            var entidade = _contexto.Find<TEntidade>(id);

            return entidade;
        }

        public TEntidade Consulte(int codigo)
        {

            var entidade = _contexto.Set<TEntidade>().
                Where(x => x.Codigo == codigo)
                .FirstOrDefault();

            return entidade;
        }

        public IList<TEntidade> ConsulteLista()
        {
            var lista = _contexto
                .Set<TEntidade>()
                .ToList();

            return lista;
        }

        public TEntidade Exclua(Guid id)
        {
            var entidade = _contexto.Find<TEntidade>(id);

            _contexto.Remove(entidade);

            _contexto.SaveChanges();
            return entidade;
        }

        public TEntidade Exclua(int codigo)
        {
            var entidade = _contexto.Set<TEntidade>()
                .FirstOrDefault(x => x.Codigo == codigo);

            _contexto.Remove(entidade);

            _contexto.SaveChanges();

            return entidade;

        }
    }
}
