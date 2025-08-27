using System;
using Xunit;
using UniTest;

namespace Unitest.Tests
{
    public class JeringozoTests
    {
        //ENCRIPTAR
        
        [Fact]
        public void Encriptar_CuandoTextoVacio_RetornaVacio()
        {
            string input = "";
            string expected = "";

            string actual = Jeringozo.Encriptar(input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("rhythm")]
        [InlineData("bcd")]
        public void Encriptar_CuandoNoHayVocales_RetornaMismoTexto(string input)
        {
            string expected = input;
            string actual = Jeringozo.Encriptar(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("hola", "hopolapa")]
        [InlineData("HOLA", "HOPOLAPA")]
        [InlineData("árbol", "ápárbopol")]
        [InlineData("e", "epe")]
        public void Encriptar_CasosComunes_RetornaTextoEnJeringozo(string input, string expected)
        {
            string actual = Jeringozo.Encriptar(input);
            Assert.Equal(expected, actual);
        }

        //DESENCRIPTAR
        [Fact]
        public void Desencriptar_CuandoTextoVacio_RetornaVacio()
        {
            string input = "";
            string expected = "";

            string actual = Jeringozo.Desencriptar(input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("rhythm")]
        [InlineData("bcd")]
        public void Desencriptar_CuandoNoHayVocales_RetornaMismoTexto(string input)
        {
            string expected = input;
            string actual = Jeringozo.Desencriptar(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("hopolapa", "hola")]
        [InlineData("HOPOLAPA", "HOLA")]
        [InlineData("ápárbopol", "árbol")]
        [InlineData("epe", "e")]
        public void Desencriptar_CasosComunes_RetornaTextoOriginal(string input, string expected)
        {
            string actual = Jeringozo.Desencriptar(input);
            Assert.Equal(expected, actual);
        }
    }
}


