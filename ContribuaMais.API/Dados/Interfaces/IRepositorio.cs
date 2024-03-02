using ContribuaMais.API.Dados.Repositorios;
using ContribuaMais.API.Models.TiposBase;
using Microsoft.EntityFrameworkCore;

namespace ContribuaMais.API.Dados.Interfaces
{
    public interface IRepositorio<TEntidade>
        where TEntidade : class
    {
        void Atualize(TEntidade entidade);
        void AtualizeLista(IList<TEntidade> entidades);
        void Cadastre(TEntidade entidade);
        void CadastreLista(IList<TEntidade> entidades);
        TEntidade? Consulte(Guid id);
        IList<TEntidade>? ConsulteLista();
        TEntidade? Consulte(int codigo);
        TEntidade? Exclua(Guid id);
        TEntidade? Exclua(int codigo);
    }
}
