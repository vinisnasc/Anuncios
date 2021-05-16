using Anuncios.Data.Repository.Interface;
using Anuncios.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Anuncios.Data.Repository.Implementation
{
    public class AnuncioRepository : BaseRepository<Anuncio>, IAnunciosRepository
    {
        public AnuncioRepository(Context contexto) : base(contexto) { }

        public List<Anuncio> GetCliente(string cliente)
        {
            return _context.Set<Anuncio>().Where(x => x.Cliente.Equals(cliente)).ToList();
        }

        public List<Anuncio> GetData(DateTime data)
        {
            var resultados = _context.Set<Anuncio>().ToList();

            List<Anuncio> anuncios = new List<Anuncio>();

            foreach (Anuncio a in resultados)
            {
                if (data >= a.DataInicio && data <= a.DataFim)
                    anuncios.Add(a);
            }

            return anuncios;
        }

        public override void Insert(Anuncio anuncio)
        {
            anuncio.Calcular();
            _context.Set<Anuncio>().Add(anuncio);
            _context.SaveChanges();
        }

        public bool VerificaIntervalo(DateTime dataInicio, DateTime dataFim, DateTime dataInterv)
        {
            return (dataInterv >= dataInicio && dataInterv <= dataFim);            
        }


    }


}
