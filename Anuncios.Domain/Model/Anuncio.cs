using Anuncios.Domain.Interface;
using System;

namespace Anuncios.Model.Domain
{
    public class Anuncio : IBaseEntity
    {
        public int Id { get; set; }
        public string NomeAnuncio { get; set; }
        public string Cliente { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public double InvestDia { get; set; }

    }
}
