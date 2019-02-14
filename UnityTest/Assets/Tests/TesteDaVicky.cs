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
        // A Test behaves as an ordinary method
        [Test]
        public void TesteDaVickySimplePasses()
        {
            var julia = new Julia.Script();
            Equals(julia.getVicky(), "Vicky");
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator TesteDaVickyWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }

        public bool IsTestFinished
        {
            get { return true; }
        }
    }
}
