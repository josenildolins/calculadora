using Avanade.Calculadora.DomainService;
using System;
using Xunit;

namespace Avanade.Calculadora.App.Teste
{
    public class OperacoesShould
    {
        [Fact]
        public void somarShouldReturnTwo()
        {
            OperacoesDomainService sut = new();
            Double usuarioInput = 1;
            Double usuarioInput2 = 1;
            var result = sut.Somar(usuarioInput, usuarioInput2);

            Assert.Equal(2,result);
        }

        [Fact]
        public void somarShouldReturnFalse()
        {
            OperacoesDomainService sut = new();
            Double usuarioInput = 1;
            Double usuarioInput2 = 1;
            var result = sut.Somar(usuarioInput, usuarioInput2);

            Assert.False(result.Equals(3));
        }

        [Fact]
        public void subtrairShouldReturnZero()
        {
            OperacoesDomainService sut = new();
            Double usuarioInput = 1;
            Double usuarioInput2 = 1;
            var result = sut.Subtrair(usuarioInput, usuarioInput2);

            Assert.Equal(0, result);
        }

        [Fact]
        public void subtrairShouldReturnFalse()
        {
            OperacoesDomainService sut = new();
            Double usuarioInput = 1;
            Double usuarioInput2 = 1;
            var result = sut.Subtrair(usuarioInput, usuarioInput2);

            Assert.False(result.Equals(2));
        }

        [Fact]
        public void DividirShouldReturntwo()
        {
            OperacoesDomainService sut = new();
            Double usuarioInput = 4;
            Double usuarioInput2 = 2;
            var result = sut.Dividir(usuarioInput, usuarioInput2);

            Assert.Equal(2, result);
        }


        [Fact]
        public void DividirShouldReturnFalse()
        {
            OperacoesDomainService sut = new();
            Double usuarioInput = 4;
            Double usuarioInput2 = 2;
            var result = sut.Dividir(usuarioInput, usuarioInput2);

            Assert.False(result.Equals(1));
        }

        [Fact]
        public void MultiplicarShouldReturntwo()
        {
            OperacoesDomainService sut = new();
            Double usuarioInput = 1;
            Double usuarioInput2 = 2;
            var result = sut.Multiplicar(usuarioInput, usuarioInput2);

            Assert.Equal(2, result);
        }

        [Fact]
        public void MultiplicarShouldReturnFalse()
        {
            OperacoesDomainService sut = new();
            Double usuarioInput = 1;
            Double usuarioInput2 = 2;
            var result = sut.Multiplicar(usuarioInput, usuarioInput2);

            Assert.False(result.Equals(3));
        }
    }
}
