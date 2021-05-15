using Anuncios.Data.Repository.Interface;
using Anuncios.Model.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anuncios.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnuncioController : ControllerBase
    {
        private readonly IAnunciosRepository _anuncioRepo;

        public AnuncioController(IAnunciosRepository anuncioRepo)
        {
            _anuncioRepo = anuncioRepo;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Anuncio> anuncios = _anuncioRepo.GetAll();
            return Ok(anuncios);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var anuncio = _anuncioRepo.Get(id);
            return Ok(anuncio);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Anuncio anuncio)
        {
            _anuncioRepo.Insert(anuncio);

            var anuncios = _anuncioRepo.GetAll();
            return Ok(anuncio);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Anuncio anuncio)
        {
            _anuncioRepo.Update(anuncio);

            var anuncios = _anuncioRepo.GetAll();
            return Ok(anuncios);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var anuncio = _anuncioRepo.Get(id);
            _anuncioRepo.Delete(anuncio);

            var anuncios = _anuncioRepo.GetAll();
            return Ok(anuncios);
        }

    }
}
