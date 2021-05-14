using System;
using Anuncios.Domain.Interface;

namespace Anuncios.Model.Domain
{
    public class Anuncios : IBaseEntity
    {
        public int Id { get; set; }
        public string NomeAnuncio { get; set; }
        public string Cliente { get; set; }
        public int DiaInicio { get; set; }
        public int MesInicio { get; set; }
        public int AnoInicio { get; set; }
        public int DiaFim { get; set; }
        public int MesFim { get; set; }
        public int AnoFim { get; set; }
        public double InvestimentoDia { get; set; }

    }
}
