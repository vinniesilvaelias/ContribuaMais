using ContribuaMais.API.Models.TiposBase;

namespace ContribuaMais.API.Dados.Interfaces
{
    public interface IRepositorio<TEntidade>
        where TEntidade : EntidadeBase
    {
        void Atualize(TEntidade entidade);
        void Cadastre(TEntidade entidade);
        TEntidade Consulte(Guid id);
        IList<TEntidade> ConsulteLista();
        TEntidade Consulte(int codigo);
        TEntidade Exclua(Guid id);
        TEntidade Exclua(int codigo);
    }
}
