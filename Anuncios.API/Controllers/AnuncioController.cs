using Anuncios.Data.Repository.Interface;
using Anuncios.Model.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

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

        /// <summary>
        /// Retorna os relatórios de todos os anúncios.
        /// </summary>
        /// <param name="cliente">Filtra por clientes.</param>
        /// <param name="data">Filtra por data.</param>
        /// <remarks>
        /// Exemplo de request:
        ///     GET /api/Anuncio
        /// </remarks>
        /// <response code="200">Retorna todos os anúncios.</response>
        /// <response code="500">Erro interno no Servidor.</response>
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [HttpGet]
        public IActionResult GetAll([FromQuery] string cliente, DateTime data)
        {
            if (cliente != null)
            {
                var anuncios = _anuncioRepo.GetCliente(cliente);
                return Ok(anuncios);
            }
            else if (data != null)
            {
                var anuncios = _anuncioRepo.GetData(data);
                return Ok(anuncios);
            }
            else
            {
                List<Anuncio> anuncios = _anuncioRepo.GetAll();
                return Ok(anuncios);
            }
        }

        /// <summary>
        /// Retorna um anúncio pelo identificador.
        /// </summary>
        /// <param name="id">Identificador do anúncio.</param>
        /// <remarks>
        /// Exemplo de request:
        ///     GET /api/Anuncio/1
        /// </remarks>
        /// <response code="200">Retorna um anúncio.</response>
        /// <response code="500">Erro interno no Servidor.</response>
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var anuncio = _anuncioRepo.Get(id);
            return Ok(anuncio);
        }

        /// <summary>
        /// Cadastra um novo anúncio.
        /// </summary>
        /// <remarks>
        /// Exemplo de request:
        ///     POST /api/Anuncio
        ///     
        ///         {
        ///             "nomeAnuncio": "Exemplo de anúncio",
        ///             "cliente": "Vinicius Nascimento",
        ///             "dataInicio": "2021-04-17",
        ///             "dataFim": "2021-05-16",
        ///             "investDia": 50.60
        ///         }
        /// </remarks>
        /// <response code="200">Anúncio cadastrado com sucesso.</response>
        /// <response code="500">Erro interno no Servidor.</response>
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [HttpPost]
        public IActionResult Post([FromBody] Anuncio anuncio)
        {
            _anuncioRepo.Insert(anuncio);

            var anuncios = _anuncioRepo.GetAll();
            return Ok(anuncios);
        }

        /// <summary>
        /// Deleta um anúncio.
        /// </summary>
        /// <param name="id">Identificador do anúncio.</param>
        /// <remarks>
        /// Exemplo de request:
        ///     DELETE /api/Anuncio
        /// </remarks>
        /// <response code="200">Deleta um anúncio.</response>
        /// <response code="500">Erro interno no Servidor.</response>
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var anuncio = _anuncioRepo.Get(id);
                _anuncioRepo.Delete(anuncio);

                var anuncios = _anuncioRepo.GetAll();
                return Ok(anuncios);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

    }
}
