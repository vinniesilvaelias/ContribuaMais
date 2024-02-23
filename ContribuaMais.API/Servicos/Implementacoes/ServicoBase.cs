using ContribuaMais.API.Dados.Interfaces;
using ContribuaMais.API.Models.Interfaces;
using ContribuaMais.API.Models.TiposBase;
using ContribuaMais.API.Servicos.Interfaces;

namespace ContribuaMais.API.Servicos.Implementacoes
{
    public class ServicoBase<TEntidade> : IServico<TEntidade>
        where TEntidade : EntidadeBase
    {
        protected readonly IRepositorio<TEntidade> _repositorio;

        public ServicoBase(IRepositorio<TEntidade> repositorio)
        {
            _repositorio = repositorio;
        }
        public void Atualize(TEntidade entidade)
        {
            _repositorio.Atualize(entidade);
        }

        public void AtualizeLista(IList<TEntidade> entidade)
        {
            _repositorio.AtualizeLista(entidade);
        }

        public void Cadastre(TEntidade entidade)
        {
            _repositorio.Cadastre(entidade);
        }

        public void Cadastre(IList<TEntidade> entidades)
        {
            _repositorio.CadastreLista(entidades);
        }

        public void CadastreLista(IList<TEntidade> entidades)
        {
            throw new NotImplementedException();
        }

        public TEntidade Consulte(Guid id)
        {
            throw new NotImplementedException();
        }

        public TEntidade Consulte(int codigo)
        {
            throw new NotImplementedException();
        }

        public IList<TEntidade> ConsulteLista()
        {
            throw new NotImplementedException();
        }

        public TEntidade Exclua(Guid id)
        {
            throw new NotImplementedException();
        }

        public TEntidade Exclua(int codigo)
        {
            throw new NotImplementedException();
        }

        public IList<TEntidade> ExcluaLista(IList<Guid> id)
        {
            throw new NotImplementedException();
        }
    }
}
