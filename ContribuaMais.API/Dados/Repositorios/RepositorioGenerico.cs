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
        }

        public TEntidade Consulte(Guid id)
        {
            var entidade = _contexto.Find<TEntidade>(id);

            return entidade;
        }

        public TEntidade Consulte(int codigo)
        {

            var entidade = _contexto.Find<TEntidade>(codigo);

            return entidade;
        }

        public TEntidade Exclua(Guid id)
        {
            var entidade = _contexto.Find<TEntidade>(id);

            _contexto.Remove(entidade);

            return entidade;
        }
    }
}
