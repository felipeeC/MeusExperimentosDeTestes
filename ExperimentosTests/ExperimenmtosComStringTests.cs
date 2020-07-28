using Experimentos;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExperimentosTests {
    class ExperimenmtosComStringTests {

        [Test]
        public void TesteDeixarLetraMaiuscula() {
            var servico = new ExperimentosComString();
            Assert.AreEqual("Amem Senhor", servico.CapitalizarString("amem senhor"));
        }

        [Test]
        public void TesteConcatenarLetraALetra() {
            var servico = new ExperimentosComString();
            Assert.AreEqual("Amem          Senhor Rapaiz", servico.CapitalizarString2("amem          senhor rapaiz"));
        }
    }
}
