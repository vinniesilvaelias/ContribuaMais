using ContribuaMais.API.Models.Enumeradores;

namespace ContribuaMais.API.Models.Dtos
{
    public class DtoItem : DtoBase
    {
        public string Decricao { get; set; }
        public EnumTipoItem Tipo { get; set; }
    }
}
