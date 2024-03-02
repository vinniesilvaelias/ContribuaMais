using System.Collections;

namespace ContribuaMais.API.Extencoes
{
    public static class Extencao
    {
        public static bool PossuiValor<TEntidade>(this IList<TEntidade> lista)
        {
            return lista is null || lista.Count > 0;
        }

        public static bool PossuiValor<TEntidade>(this TEntidade entidade)
        {
            return entidade != null;
        }
    }
}
