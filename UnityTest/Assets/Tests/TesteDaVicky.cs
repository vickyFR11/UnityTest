using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Julia;

namespace Tests
{
    public class TesteDaVicky
    {
        public Script julia;

        public TesteDaVicky() {
            julia = new Script();
        }

        [Test]
        public void TesteDaVickySimplePasses()
        {
            Equals(julia.getVicky(), "Vicky");
        }

        [Test]
        public void ChangesPositionWhenValuesPassed()
        {
            Vector3 expectedVector = new Vector3(10, 10, 10);

            Vector3 position = julia.ChangesPosition(10, 10, 10);

            Assert.AreEqual(position, expectedVector);
        }

        [UnityTest]
        public IEnumerator TesteDaVickyWithEnumeratorPasses()
        {
            yield return null;
        }

        public bool IsTestFinished
        {
            get { return true; }
        }
    }
}
