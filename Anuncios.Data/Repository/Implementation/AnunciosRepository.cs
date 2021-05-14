using Anuncios.Data.Repository.Interface;
using Anuncios.Model.Domain;

namespace Anuncios.Data.Repository.Implementation
{
    public class AnuncioRepository : BaseRepository<Anuncio>, IAnunciosRepository
    {
        public AnuncioRepository(Context contexto) : base(contexto) { }
    }
}
