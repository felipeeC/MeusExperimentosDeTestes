using Experimentos;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExperimentosTests {
    class ExperimenmtosComNumerosTests {
        [Test]
        public void TestSoma() {
            var servico = new ExperimentosComNumeros();
            Assert.AreEqual(3, servico.Soma(1, 2));
            Assert.AreEqual(4, servico.Soma(2, 2));
            Assert.AreEqual(7, servico.Soma(5, 2));

        }

        [Test]
        public void TestaSeDoisMaisDoisEh4() {
            var servico = new ExperimentosComNumeros();
            Assert.AreEqual(4, servico.Soma(2, 2));
        }



    }
}
