using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Business;
using System.Linq;

namespace Tests
{
    public class SacarCaixaEletronico
    {
        private CaixaEletronico caixaEletronico { get; set; }
        [SetUp]
        public void Setup()
        {
            List<Nota> notasCaixa = new List<Nota>();
            notasCaixa.Add(new Nota(100));
            notasCaixa.Add(new Nota(50));
            notasCaixa.Add(new Nota(20));
            notasCaixa.Add(new Nota(10));
            
            caixaEletronico = new CaixaEletronico(notasCaixa);
        }

        [Test]
        [TestCase(10)]
        public void SacarDez_RetornaUmaNotaDez(int valor)
        {
            var notasRetorno = caixaEletronico.Sacar(valor);
            var notasEsperadas = new List<Nota>
            {
                new Nota(valor)
            };

            Assert.IsTrue(Enumerable.SequenceEqual(notasRetorno, notasEsperadas));
        }

        [Test]
        [TestCase(10)]
        [TestCase(20)]
        [TestCase(50)]
        [TestCase(100)]
        public void SacarValorExataNota_RetornaUmaNotaCorrespondente(int valor)
        {
            var notasRetorno = caixaEletronico.Sacar(valor);
            var notasEsperadas = new List<Nota>
            {
                new Nota(valor)
            };

            Assert.IsTrue(Enumerable.SequenceEqual(notasRetorno, notasEsperadas));
        }

        [Test]
        [TestCase(80)]
        public void SacarOitenta_RetornaUmaCinquentaUmaVinteUmaDez(int valor)
        {
            var notasRetorno = caixaEletronico.Sacar(valor);
            var notasEsperadas = new List<Nota>
            {
                new Nota(50),
                new Nota(20),
                new Nota(10)
            };
            notasRetorno.Sort((x, y) => x.valor.CompareTo(y.valor));
            notasEsperadas.Sort((x, y) => x.valor.CompareTo(y.valor));
            Assert.IsTrue(Enumerable.SequenceEqual(notasRetorno, notasEsperadas));
        }

        [Test]
        [TestCase(180)]
        public void SacarCentoOitenta_RetornaUmaCemUmaCinquentaUmaVinteUmaDez(int valor)
        {
            var notasRetorno = caixaEletronico.Sacar(valor);
            var notasEsperadas = new List<Nota>
            {
                new Nota(100),
                new Nota(50),
                new Nota(20),
                new Nota(10)
            };
            notasRetorno.Sort((x, y) => x.valor.CompareTo(y.valor));
            notasEsperadas.Sort((x, y) => x.valor.CompareTo(y.valor));
            Assert.IsTrue(Enumerable.SequenceEqual(notasRetorno, notasEsperadas));
        }

        [Test]
        [TestCase(240)]
        public void SacarDuzentosQuarenta_RetornaDuasCemDuasVinte(int valor)
        {
            var notasRetorno = caixaEletronico.Sacar(valor);
            var notasEsperadas = new List<Nota>
            {
                new Nota(100),
                new Nota(100),
                new Nota(20),
                new Nota(20)
            };
            notasRetorno.Sort((x, y) => x.valor.CompareTo(y.valor));
            notasEsperadas.Sort((x, y) => x.valor.CompareTo(y.valor));
            Assert.IsTrue(Enumerable.SequenceEqual(notasRetorno, notasEsperadas));
        }

        [Test]
        [TestCase(0)]
        public void SacarZero_RetornaErro(int valor)
        {
            string MENSAGEM_VALOR_INVALIDO = "Valor inválido.";
            var ex = Assert.Throws<Exception>(() => caixaEletronico.Sacar(valor));
            Assert.IsTrue(ex.Message == MENSAGEM_VALOR_INVALIDO);
        }

        [Test]
        [TestCase(15)]
        public void SacarQuinze_RetornaErroValorIndisponivel(int valor)
        {
            string MENSAGEM_VALOR_INDISPONÍVEL = "Não foi possível sacar o valor desejado.";
            var ex = Assert.Throws<Exception>(() => caixaEletronico.Sacar(valor));
            Assert.IsTrue(ex.Message == MENSAGEM_VALOR_INDISPONÍVEL);
        }
    }
}
