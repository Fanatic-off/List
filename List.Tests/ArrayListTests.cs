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

        [TestCase(new int[] { 1, 2, 3 }, 1, new int[] { 1, 3 })]
        [TestCase(new int[] { 34, 678, 94, 15 }, 1, new int[] { 34, 94, 15 })]
        [TestCase(new int[] { 33, 66, 2345, 213, -12 }, 1, new int[] { 33, 2345, 213, -12 })]
        public void RemoveByIndexTests(int[] arrayActual, int value, int[] arrayExpected)
        {
            ArrayList arrayListExpected = new ArrayList(arrayExpected);
            ArrayList arrayListActual = new ArrayList(arrayActual);

            arrayListActual.RemoveByIndex(value);

            Assert.AreEqual(arrayListExpected, arrayListActual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 1, new int[] { 1, 2 })]
        [TestCase(new int[] { 34, 678, 94, 15 }, 2, new int[] { 34, 678 })]
        [TestCase(new int[] { 33, 66, 2345, 213, -12 }, 3, new int[] { 33, 66 })]
        public void RemoveSeveralElementsFromTheEndTests(int[] arrayActual, int value, int[] arrayExpected)
        {
            ArrayList arrayListExpected = new ArrayList(arrayExpected);
            ArrayList arrayListActual = new ArrayList(arrayActual);

            arrayListActual.RemoveSeveralElementsFromTheEnd(value);

            Assert.AreEqual(arrayListExpected, arrayListActual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 1, new int[] { 2, 3 })]
        [TestCase(new int[] { 34, 678, 94, 15 }, 2, new int[] { 94, 15 })]
        [TestCase(new int[] { 33, 66, 2345, 213, -12 }, 3, new int[] { 213, -12 })]
        public void RemoveSeveralElementsFromTheBeginTests(int[] arrayActual, int value, int[] arrayExpected)
        {
            ArrayList arrayListExpected = new ArrayList(arrayExpected);
            ArrayList arrayListActual = new ArrayList(arrayActual);

            arrayListActual.RemoveSeveralElementsFromTheBegin(value);

            Assert.AreEqual(arrayListExpected, arrayListActual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 1, 1, new int[] { 1, 3 })]
        [TestCase(new int[] { 34, 678, 94, 15 }, 1, 2, new int[] { 34, 15 })]
        [TestCase(new int[] { 33, 66, 2345, 213, -12 }, 0, 3, new int[] { 213, -12 })]
        public void RemoveSeveralElementsByIndexTests(int[] arrayActual, int index, int number, int[] arrayExpected)
        {
            ArrayList arrayListExpected = new ArrayList(arrayExpected);
            ArrayList arrayListActual = new ArrayList(arrayActual);

            arrayListActual.RemoveSeveralElementsByIndex(index, number);

            Assert.AreEqual(arrayListExpected, arrayListActual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 1, 2)]
        [TestCase(new int[] { 34, 678, 94, 15 }, 2, 94)]
        [TestCase(new int[] { 33, 66, 2345, 213, -12 }, 4, -12)]
        public void AccessByIndexTests(int[] arrayActual, int index, int expected)
        {
            ArrayList arrayListActual = new ArrayList(arrayActual);
          
            int actual = arrayListActual.AccessByIndex(index);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 1, 0)]
        [TestCase(new int[] { 34, 678, 94, 15 }, 94, 2)]
        [TestCase(new int[] { 33, 66, 2345, 213, -12 }, -12, 4)]
        public void AccessFirstIndexByValueTests(int[] arrayActual, int value, int expected)
        {
            ArrayList arrayListActual = new ArrayList(arrayActual);

            int actual = arrayListActual.AccessFirstIndexByValue(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 0, 5, new int[] { 5, 2, 3 })]
        [TestCase(new int[] { 34, 678, 94, 15 }, 2, 2, new int[] { 34, 678, 2, 15 })]
        [TestCase(new int[] { 33, 66, 2345, 213, -12 }, 4, 1, new int[] { 33, 66, 2345, 213, 1 })]
        public void ChangeValueByIndexTests(int[] arrayActual, int index, int value, int[] arrayExpected)
        {
            ArrayList arrayListExpected = new ArrayList(arrayExpected);
            ArrayList arrayListActual = new ArrayList(arrayActual);

            arrayListActual.ChangeValueByIndex(index, value);

            Assert.AreEqual(arrayListExpected, arrayListActual);
        }

        [TestCase(new int[] { 0, 2, 3 }, new int[] { 3, 2, 0 })]
        [TestCase(new int[] { 2347, 678, 94, 1 }, new int[] { 1, 94, 678, 2347 })]
        [TestCase(new int[] { 33, 66, -35, 213, -12 }, new int[] { -12, 213, -35, 66, 33 })]
        public void ReverseTests(int[] arrayActual, int[] arrayExpected)
        {
            ArrayList arrayListExpected = new ArrayList(arrayExpected);
            ArrayList arrayListActual = new ArrayList(arrayActual);

            arrayListActual.Reverse();

            Assert.AreEqual(arrayListExpected, arrayListActual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 3)]
        [TestCase(new int[] { 2347, 678, 94, 15 }, 2347)]
        [TestCase(new int[] { 33, 66, 9999, 213, -12 }, 9999)]
        public void SearchMaxValueTests(int[] arrayActual, int expected)
        {
            ArrayList arrayListActual = new ArrayList(arrayActual);

            int actual = arrayListActual.SearchMaxValue();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0, 2, 3 }, 0)]
        [TestCase(new int[] { 2347, 678, 94, 1 }, 1)]
        [TestCase(new int[] { 33, 66, -35, 213, -12 }, -35)]
        public void SearchMinValueTests(int[] arrayActual, int expected)
        {
            ArrayList arrayListActual = new ArrayList(arrayActual);

            int actual = arrayListActual.SearchMinValue();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 2)]
        [TestCase(new int[] { 2347, 678, 94, 15 }, 0)]
        [TestCase(new int[] { 33, 66, 9999, 213, -12 }, 2)]
        public void SearchIndexOfMaxValueTests(int[] arrayActual, int expected)
        {
            ArrayList arrayListActual = new ArrayList(arrayActual);

            int actual = arrayListActual.SearchIndexOfMaxValue();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 0)]
        [TestCase(new int[] { 2347, 678, 94, 15 }, 3)]
        [TestCase(new int[] { 33, 66, -9999, 213, -12 }, 2)]
        public void SearchIndexOfMinValueTests(int[] arrayActual, int expected)
        {
            ArrayList arrayListActual = new ArrayList(arrayActual);

            int actual = arrayListActual.SearchIndexOfMinValue();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 4, 3 }, new int[] { 1, 3, 4 })]
        [TestCase(new int[] { 2347, 678, 94, 15 }, new int[] { 15, 94, 678, 2347 })]
        [TestCase(new int[] { 33, 66, -9999, 213, -12 }, new int[] { -9999, -12, 33, 66, 213 })]
        public void SortTests(int[] arrayActual, int[] arrayExpected)
        {
            ArrayList arrayListExpected = new ArrayList(arrayExpected);
            ArrayList arrayListActual = new ArrayList(arrayActual);

            arrayListActual.Sort();

            Assert.AreEqual(arrayListExpected, arrayListActual);
        }

        [TestCase(new int[] { 1, 4, 3 }, new int[] { 4, 3, 1 })]
        [TestCase(new int[] { 2347, 678, 94, 151 }, new int[] { 2347, 678, 151, 94 })]
        [TestCase(new int[] { 33, 66, -9999, 213, -12 }, new int[] { 213, 66, 33, -12, -9999 })]
        public void SortReverseTests(int[] arrayActual, int[] arrayExpected)
        {
            ArrayList arrayListExpected = new ArrayList(arrayExpected);
            ArrayList arrayListActual = new ArrayList(arrayActual);

            arrayListActual.SortReverse();

            Assert.AreEqual(arrayListExpected, arrayListActual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 1, 0)]
        [TestCase(new int[] { 2347, 678, 94, 15 }, 15, 3)]
        [TestCase(new int[] { 33, 66, -9999, 213, -12 }, -9999, 2)]
        public void RemoveByValueTests(int[] arrayActual, int value, int expected)
        {
            ArrayList arrayListActual = new ArrayList(arrayActual);

            int actual = arrayListActual.RemoveByValue(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 1, new int[] { 2, 3 })]
        [TestCase(new int[] { 2347, 678, 94, 15 }, 15, new int[] { 2347, 678, 94 })]
        [TestCase(new int[] { 33, 66, -9999, 213, -12 }, -9999, new int[] { 33, 66, 213, -12 })]
        public void RemoveByValueCarrentArrayTests(int[] arrayActual, int value, int[] arrayExpected)
        {
            ArrayList arrayListExpected = new ArrayList(arrayExpected);
            ArrayList arrayListActual = new ArrayList(arrayActual);

            arrayListActual.RemoveByValue(value);

            Assert.AreEqual(arrayListExpected, arrayListActual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 1, 1)]
        [TestCase(new int[] { 2347, 678, 94, 15, 15 }, 15, 2)]
        [TestCase(new int[] { -9999, 33, 66, -9999, 213, -12, -9999 }, -9999, 3)]
        public void RemoveAllindexByValueTests(int[] arrayActual, int value, int expected)
        {
            ArrayList arrayListActual = new ArrayList(arrayActual);

            int actual = arrayListActual.RemoveByValueAllIndex(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 5, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 2347, 678, 94, 15, 15 }, 15, new int[] { 2347, 678, 94 })]
        [TestCase(new int[] { -9999, 33, 66, -9999, 213, -12, -9999 }, -9999, new int[] { 33, 66, 213, -12 })]
        public void RemoveAllindexByValueCurrentArrayTests(int[] arrayActual, int value, int[] arrayExpected)
        {
            ArrayList arrayListExpected = new ArrayList(arrayExpected);
            ArrayList arrayListActual = new ArrayList(arrayActual);

            arrayListActual.RemoveByValueAllIndex(value);

            Assert.AreEqual(arrayListExpected, arrayListActual);
        }

        [TestCase(new int[] { 1, 2 }, new int[] { 1 }, new int[] { 1, 2, 1 })]
        [TestCase(new int[] { 123, 23, 45 }, new int[] { 123, 55 }, new int[] { 123, 23, 45, 123, 55 })]
        [TestCase(new int[] { -343, 672, 0, -2 }, new int[] { 33, 77, -99 }, new int[] { -343, 672, 0, -2, 33, 77, -99 })]
        public void AddArrayListTests(int[] arrayActual, int[] arrayAdd, int[] arrayExpected)
        {
            ArrayList arrayListExpected = new ArrayList(arrayExpected);
            ArrayList arrayListActual = new ArrayList(arrayActual);
            ArrayList arrayListAdd = new ArrayList(arrayAdd);

            arrayListActual.AddArrayList(arrayListAdd);

            Assert.AreEqual(arrayListExpected, arrayListActual);
        }

        [TestCase(new int[] { 1, 2 }, new int[] { 1 }, new int[] { 1, 1, 2 })]
        [TestCase(new int[] { 155, 23, 45 }, new int[] { 123, 55 }, new int[] { 123, 55, 155, 23, 45 })]
        [TestCase(new int[] { -343, 672, 0, -2 }, new int[] { 33, 77, -99 }, new int[] { 33, 77, -99, -343, 672, 0, -2 })]
        public void AddArrayListToBeginTests(int[] arrayActual, int[] arrayAdd, int[] arrayExpected)
        {
            ArrayList arrayListExpected = new ArrayList(arrayExpected);
            ArrayList arrayListActual = new ArrayList(arrayActual);
            ArrayList arrayListAdd = new ArrayList(arrayAdd);

            arrayListActual.AddArrayListToBegin(arrayListAdd);

            Assert.AreEqual(arrayListExpected, arrayListActual);
        }

        [TestCase(new int[] { 1, 2 }, new int[] { 1 }, 0, new int[] { 1, 1, 2 })]
        [TestCase(new int[] { 155, 23, 45 }, new int[] { 123, 55 }, 2, new int[] { 155, 23, 123, 55, 45 })]
        [TestCase(new int[] { -343, 672, 0, -2 }, new int[] { 33, 77, -99 }, 3, new int[] { -343, 672, 0, 33, 77, -99, -2 })]
        public void AddArrayListByIndexTests(int[] arrayActual, int[] arrayAdd, int index, int[] arrayExpected)
        {
            ArrayList arrayListExpected = new ArrayList(arrayExpected);
            ArrayList arrayListActual = new ArrayList(arrayActual);
            ArrayList arrayListAdd = new ArrayList(arrayAdd);

            arrayListActual.AddArrayListByIndex(arrayListAdd, index);

            Assert.AreEqual(arrayListExpected, arrayListActual);
        }



    }
}