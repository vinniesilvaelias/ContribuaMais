using ContribuaMais.API.Dados.Interfaces;
using ContribuaMais.API.Models.TiposBase;
using Microsoft.EntityFrameworkCore;

namespace ContribuaMais.API.Dados.Repositorios
{
    public class RepositorioBase<TEntidade> : IRepositorio<TEntidade>
        where TEntidade : EntidadeBase, new()
    {
        protected ContribuaMaisContexto _contexto;

        public RepositorioBase(ContribuaMaisContexto contexto)
        {
            _contexto  = contexto;
        }

        public virtual void Atualize(TEntidade entidade)
        {
            _contexto.Update(entidade);
            
            _contexto.SaveChanges();
        }

        public virtual void AtualizeLista(IList<TEntidade> entidades)
        {
            _contexto.UpdateRange(entidades);
            
            _contexto.SaveChanges();
        }

        public virtual void Cadastre(TEntidade entidade)
        {
            entidade.Id = Guid.NewGuid();

            _contexto.Add(entidade);
            
            _contexto.SaveChanges();
        }

        public virtual void CadastreLista(IList<TEntidade> entidades)
        {
            _contexto.AddRange(entidades);

            _contexto.SaveChanges();
        }

        public virtual TEntidade? Consulte(Guid id)
        {
            var entidade = _contexto.Find<TEntidade>(id);

            return entidade;
        }

        public virtual TEntidade? Consulte(int codigo)
        {
            var entidade = _contexto
                           .Set<TEntidade>()
                           .FirstOrDefault(x => x.Codigo == codigo);

            return entidade;
        }

        public virtual IList<TEntidade>? ConsulteLista()
        {
            var lista = _contexto
                .Set<TEntidade>()
                .ToList();

            return lista;
        }

        public virtual TEntidade? Exclua(Guid id)
        {
            var entidade = Consulte(id);

            _contexto.Remove(entidade);

            _contexto.SaveChanges();

            return entidade;
        }

        public virtual TEntidade? Exclua(int codigo)
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