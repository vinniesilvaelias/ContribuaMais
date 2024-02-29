using ContribuaMais.API.Dados;
using ContribuaMais.API.Models.Interfaces;
using ContribuaMais.API.Models.TiposBase;

namespace ContribuaMais.API.Servicos.Interfaces
{
    public interface IServico<TEntidade> 
        where TEntidade : class
    {
        void Cadastre(TEntidade entidade);
        void CadastreLista(IList<TEntidade> entidades);
        TEntidade Consulte(Guid id);
        TEntidade Consulte(int codigo);
        IList<TEntidade> ConsulteLista();
        void Atualize(TEntidade entidade);
        void AtualizeLista(IList<TEntidade> entidade);
        TEntidade Exclua(Guid id);
        TEntidade Exclua(int codigo);
        IList<TEntidade> ExcluaLista(IList<Guid> id);
    }
}
