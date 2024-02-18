namespace ContribuaMais.API.Models.Dtos
{
    public class DtoCampanha : DtoBase
    {
        public string Descricao { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public bool EstaAtiva { get; set; }
        public decimal Objetivo { get; set; }
        public decimal Arrecadado { get; set; }
    }
}
