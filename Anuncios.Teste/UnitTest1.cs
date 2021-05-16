using Anuncios.Model.Domain;
using System;
using Xunit;

namespace Anuncios.Teste
{
    public class AnuncioTeste
    {
        private readonly Anuncio _sut;

        public AnuncioTeste()
        {
            _sut = new Anuncio();
        }

        /// <summary>
        /// Testa a visualização.
        /// </summary>
        [Theory]
        [InlineData(87, 1)]
        public void TestaVisualizacao(double expected, double valorInvest)
        {
            _sut.InvestDia = valorInvest;
            _sut.Calcular();
            Assert.Equal(expected, actual: _sut.MaxVisualizacao);
        }
    }
}
