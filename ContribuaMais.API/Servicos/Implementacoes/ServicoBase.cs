using ContribuaMais.API.Dados;
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
            _repositorio.CadastreLista(entidades);
        }

        public TEntidade Consulte(Guid id)
        {
            var entidade =  _repositorio.Consulte(id);

            return entidade;
        }

        public TEntidade Consulte(int codigo)
        {
            var entidade = _repositorio.Consulte(codigo);

            return entidade;
        }

        public IList<TEntidade> ConsulteLista()
        {
            var lista = _repositorio.ConsulteLista();

            return lista;
        }

        public TEntidade Exclua(Guid id)
        {
            var entidade = _repositorio.Exclua(id);

            return entidade;
        }

        public TEntidade Exclua(int codigo)
        {
            var entidade = _repositorio.Exclua(codigo);

            return entidade;
        }

        public IList<TEntidade> ExcluaLista(IList<Guid> lista)
        {
            var listaExclusao = lista
                                .ToList()
                                .Select(Exclua)
                                .ToList();

            return listaExclusao;
        }
    }
}
