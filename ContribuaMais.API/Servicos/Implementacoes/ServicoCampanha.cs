﻿using ContribuaMais.API.Dados.Interfaces;
using ContribuaMais.API.Models.Dados;

namespace ContribuaMais.API.Servicos.Implementacoes
{
    public class ServicoCampanha : ServicoBase<Campanha>
    {
        public ServicoCampanha(IRepositorio<Campanha> repositorio) : base(repositorio)
        {
        }
    }
}
