using ContribuaMais.API.Dados.Interfaces;
using ContribuaMais.API.Models.TiposBase;

namespace ContribuaMais.API.Dados.Repositorios
{
    public class RepositorioBase<TEntidade> : IRepositorio<TEntidade>
        where TEntidade : class
    {
        private ContribuaMaisContexto _contexto;

        public RepositorioBase(ContribuaMaisContexto contexto)
        {
            _contexto  = contexto;
        }
        public void Atualize(TEntidade entidade)
        {
            _contexto.Update(entidade);
            
            _contexto.SaveChanges();
        }

        public void AtualizeLista(IList<TEntidade> entidades)
        {
            _contexto.UpdateRange(entidades);
            
            _contexto.SaveChanges();
        }

        public void Cadastre(TEntidade entidade)
        {
            _contexto.Add(entidade);
            
            _contexto.SaveChanges();
        }

        public void CadastreLista(IList<TEntidade> entidades)
        {
            _contexto.AddRange(entidades);

            _contexto.SaveChanges();
        }

        public TEntidade Consulte(Guid id)
        {
            var entidade = _contexto.Find<TEntidade>(id);

            return entidade;
        }

        public TEntidade Consulte(int codigo)
        {
            var entidade = _contexto
                           .Set<TEntidade>()
                           .FirstOrDefault(x => x.Codigo == codigo);

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
            var entidade = Consulte(id);

            _contexto.Remove(entidade);

            _contexto.SaveChanges();

            return entidade;
        }

        public TEntidade Exclua(int codigo)
        {
            var entidade = Consulte(codigo);
            
            if (entidade is not null)
            {
                _contexto.Remove(entidade);

                _contexto.SaveChanges();
            }

            return entidade;
        }
    }
}