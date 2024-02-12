using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Personajes;

namespace Test
{
    public class codigoED
    {
        private Personaje1 p1;

        // A Test behaves as an ordinary method
        [SetUp]
        public void SetUp() {
            //Arrage
            this.p1 = new Personaje1();
            //Debug.Log("Empezando la prueba");
        }

        [TearDown]
        public void TearDown()
        {
            Debug.Log("Terminando la prueba");
        }

        [TestCase(10)]
        [TestCase(51)]
        [TestCase(101)]
        [TestCase(15)]
        public void test1(int fuerza)
        {
            //Acc
            int actual = p1.getFuerza(fuerza);

            //Assert
            Assert.AreEqual(fuerza, actual);

        }
        [Test]
        public void test2()
        {
            //Arrage
            var a = 10;
            var b = 20;

            //Act
            var result = a + b;
            Debug.Log("Pasando el test2");

            //Asserts
            Assert.AreEqual(30, result, "Algo ha fallado en este test");

        }
    }
}
