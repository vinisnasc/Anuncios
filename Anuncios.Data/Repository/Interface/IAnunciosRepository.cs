using Anuncios.Model.Domain;
using System;
using System.Collections.Generic;

namespace Anuncios.Data.Repository.Interface
{
    public interface IAnunciosRepository : IBaseRepository<Anuncio>
    {
        List<Anuncio> GetCliente(string cliente);
        List<Anuncio> GetData(DateTime date);
    }
}
