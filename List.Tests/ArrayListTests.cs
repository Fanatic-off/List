using NUnit.Framework;

namespace List.Tests
{
    public class ArrayListTests
    {
        [TestCase(new int[] { 1, 2, 3 }, 4, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { 34, 678, 94, 15 }, 125, new int[] { 34, 678, 94, 15, 125 })]
        [TestCase(new int[] { 33, 66, 2345, 213, -12 }, -314, new int[] { 33, 66, 2345, 213, -12, -314 })]
        public void AddTests(int[] arrayActual, int value, int[] arrayExpected)
        {
            ArrayList arrayListExpected = new ArrayList(arrayExpected);
            ArrayList arrayListActual = new ArrayList(arrayActual);

            arrayListActual.Add(value);

            Assert.AreEqual(arrayListExpected, arrayListActual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 4, new int[] { 4, 1, 2, 3 })]
        [TestCase(new int[] { 34, 678, 94, 15 }, 125, new int[] { 125, 34, 678, 94, 15 })]
        [TestCase(new int[] { 33, 66, 2345, 213, -12 }, -314, new int[] { -314, 33, 66, 2345, 213, -12 })]
        public void AddToStartTests(int[] arrayActual, int value, int[] arrayExpected)
        {
            ArrayList arrayListExpected = new ArrayList(arrayExpected);
            ArrayList arrayListActual = new ArrayList(arrayActual);

            arrayListActual.AddToStart(value);
            string actual = arrayListActual.ToString();
            string expected = arrayListExpected.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 0, 4, new int[] { 4, 1, 2, 3 })]
        [TestCase(new int[] { 34, 678, 94, 15 }, 4, 125, new int[] { 34, 678, 94, 15, 125 })]
        [TestCase(new int[] { 33, 66, 2345, 213, -12 }, 2, -314, new int[] { 33, 66, -314, 2345, 213, -12 })]
        public void AddValueByIndexTests(int[] arrayActual, int index, int value, int[] arrayExpected)
        {
            ArrayList arrayListExpected = new ArrayList(arrayExpected);
            ArrayList arrayListActual = new ArrayList(arrayActual);

            arrayListActual.AddValueByIndex(index, value);
            string actual = arrayListActual.ToString();
            string expected = arrayListExpected.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2})]
        [TestCase(new int[] { 34, 678, 94, 15 }, new int[] { 34, 678, 94 })]
        [TestCase(new int[] { 33, 66, 2345, 213, -12 }, new int[] { 33, 66, 2345, 213 })]
        public void RemoveTests(int[] arrayActual, int[] arrayExpected)
        {
            ArrayList arrayListExpected = new ArrayList(arrayExpected);
            ArrayList arrayListActual = new ArrayList(arrayActual);

            arrayListActual.Remove();

            Assert.AreEqual(arrayListExpected, arrayListActual);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 2, 3 })]
        [TestCase(new int[] { 34, 678, 94, 15 }, new int[] { 678, 94, 15 })]
        [TestCase(new int[] { 33, 66, 2345, 213, -12 }, new int[] { 66, 2345, 213, -12 })]
        public void RemoveFromBeginingTests(int[] arrayActual, int[] arrayExpected)
        {
            ArrayList arrayListExpected = new ArrayList(arrayExpected);
            ArrayList arrayListActual = new ArrayList(arrayActual);

            arrayListActual.RemoveFromBegining();
            string actual = arrayListActual.ToString();
            string expected = arrayListExpected.ToString();

            Assert.AreEqual(expected, actual);
        }

        //[TestCase(new int[] { 1, 2, 3 }, 1, new int[] { 2, 3 })]
        //[TestCase(new int[] { 34, 678, 94, 15 }, 1, new int[] { 678, 94, 15 })]
        //[TestCase(new int[] { 33, 66, 2345, 213, -12 }, 1, new int[] { 66, 2345, 213, -12 })]
        //public void RemoveByIndexTests(int[] arrayActual, int value, int[] arrayExpected)
        //{
        //    ArrayList arrayListExpected = new ArrayList(arrayExpected);
        //    ArrayList arrayListActual = new ArrayList(arrayActual);

        //    arrayListActual.RemoveByIndex(value);

        //    Assert.AreEqual(arrayListExpected, arrayListActual);
        //}

        [TestCase(new int[] { 1, 2, 3 }, 1, new int[] { 1, 2 })]
        [TestCase(new int[] { 34, 678, 94, 15 }, 1, new int[] { 34, 678, 94 })]
        [TestCase(new int[] { 33, 66, 2345, 213, -12 }, 1, new int[] { 33, 66, 2345, 213 })]
        public void RemoveNumberFromTheEndElementsTests(int[] arrayActual, int value, int[] arrayExpected)
        {
            ArrayList arrayListExpected = new ArrayList(arrayExpected);
            ArrayList arrayListActual = new ArrayList(arrayActual);

            arrayListActual.RemoveNumberFromTheEndElements(value);

            Assert.AreEqual(arrayListExpected, arrayListActual);
        }

        //[TestCase(new int[] { 1, 2, 3 }, 1, new int[] { 2, 3 })]
        //[TestCase(new int[] { 34, 678, 94, 15 }, 1, new int[] { 678, 94, 15 })]
        //[TestCase(new int[] { 33, 66, 2345, 213, -12 }, 1, new int[] { 66, 2345, 213, -12 })]
        //public void RemoveNumberFromTheBeginingElementsTests(int[] arrayActual, int value, int[] arrayExpected)
        //{
        //    ArrayList arrayListExpected = new ArrayList(arrayExpected);
        //    ArrayList arrayListActual = new ArrayList(arrayActual);

        //    arrayListActual.RemoveNumberFromTheBeginingElements(value);

        //    Assert.AreEqual(arrayListExpected, arrayListActual);
        //}

        //[TestCase(new int[] { 1, 2, 3 }, 1, 1, new int[] { 1, 3 })]
        //[TestCase(new int[] { 34, 678, 94, 15 }, 1, 2, new int[] { 34, 15 })]
        //[TestCase(new int[] { 33, 66, 2345, 213, -12 }, 0, 3, new int[] { 213, -12 })]
        //public void RemoveNumberByIndexElementsTests(int[] arrayActual, int index, int number, int[] arrayExpected)
        //{
        //    ArrayList arrayListExpected = new ArrayList(arrayExpected);
        //    ArrayList arrayListActual = new ArrayList(arrayActual);

        //    arrayListActual.RemoveNumberByIndexElements(index, number);

        //    Assert.AreEqual(arrayListExpected, arrayListActual);
        //}



    }
}