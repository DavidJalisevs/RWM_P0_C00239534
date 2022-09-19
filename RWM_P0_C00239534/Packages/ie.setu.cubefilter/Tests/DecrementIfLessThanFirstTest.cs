using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class DecrementIfLessThanFirstTest
    {
        [Test]
        public void DecrementIfLessThanFirstSimple()
        {
            int[] input = { 10, 9, 12, 5, 5, 999 };
            int[] output = DecrementIfLessThanFirst.DecrementIfLessThanFirstPass(input);
            int[] expected = { 10, 8, 12, 4, 4, 999 };

            CollectionAssert.AreEqual(expected, output);
        }



        [Test]
        public void Module3Simple()
        {
            int[] input = { 10, 9, 12, 5, 5, 8 };
            int[] output = CubeFilter.Module3(input);
            int[] expected = { 1, 0, 0, 2, 2, 2 };

            CollectionAssert.AreEqual(expected, output);
        }






    }
}
