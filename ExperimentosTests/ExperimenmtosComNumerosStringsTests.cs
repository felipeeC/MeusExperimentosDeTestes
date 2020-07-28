
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;


namespace ExperimentosTests.Application.UnitTests {
    class ExperimenmtosComNumerosStringsTests {
        //[Test]
        //public void TesteRetornarPercentual() {
        //    var servico = new VoterService(null);
        //    Assert.AreEqual("200,0000000000000000000000000%", servico.calculaPercentual(200, 100, 25));
        //}

        [Test]
        public void TesteRetornarPercentual() {
            var servico = new ExperimentosComNumerosStrings();
            Assert.AreEqual("200,0000000000000000000000000%", servico.CalculaEFormataPercentual(200, 100, 25));
        }
    }
} 
