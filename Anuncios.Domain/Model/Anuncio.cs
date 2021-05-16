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
        public double InvestTotal { get; set; }
        public double MaxVisualizacao { get; set; }
        public double MaxCliques { get; set; }
        public double MaxComp { get; set; }

        public void Calcular()
        {
            TimeSpan dias = DataFim.Subtract(DataInicio);

            InvestTotal = dias.Days * InvestDia;

            double vis = InvestTotal * 30;
            double nvis = vis;
            MaxVisualizacao = vis;

            for (int i = 0; i < 4; i++)
            {
                double clique = nvis * 0.12;
                double comp = clique * 0.15;
                nvis = comp * 40;
                MaxVisualizacao += nvis;
                MaxCliques += clique;
                MaxComp += comp;
            }

            MaxVisualizacao = Math.Round(MaxVisualizacao);
            MaxCliques = Math.Round(MaxCliques + 0.12 * nvis);
            MaxComp = Math.Round(MaxComp);
        }
    }
}
