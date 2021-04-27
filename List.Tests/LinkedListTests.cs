using NUnit.Framework;

namespace List.Tests
{
    public class LinkedListTests
    {
        [TestCase(new int[] { 1, 2, 3 }, 4, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { 5, 8, 22 }, 436, new int[] { 5, 8, 22, 436 })]
        [TestCase(new int[] { 33, -567, 9021 }, -55, new int[] { 33, -567, 9021, -55 })]
        public void AddTests(int[] arrayActual, int value, int[] arrayExpected)
        {
            LinkedList expected = new LinkedList(arrayExpected);
            LinkedList actual = new LinkedList(arrayActual);

            actual.Add(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 4, new int[] { 4, 1, 2, 3 })]
        [TestCase(new int[] { 5, 8, 22 }, 436, new int[] { 436, 5, 8, 22 })]
        [TestCase(new int[] { 33, -567, 9021 }, -55, new int[] { -55, 33, -567, 9021 })]
        public void AddToRootTests(int[] arrayActual, int value, int[] arrayExpected)
        {
            LinkedList expected = new LinkedList(arrayExpected);
            LinkedList actual = new LinkedList(arrayActual);

            actual.AddToRoot(value);

            Assert.AreEqual(expected, actual);
        }

        //[TestCase(new int[] { 1, 2, 3 }, 4, 0, new int[] { 4, 1, 2, 3 })]
        [TestCase(new int[] { 5, 8, 22 }, 436, 2, new int[] { 5, 8, 436, 22 })]
        [TestCase(new int[] { 33, -567, 9021 }, -55, 3, new int[] { 33, -567, 9021, -55 })]
        public void AddByIndexTests(int[] arrayActual, int value, int index, int[] arrayExpected)
        {
            LinkedList expected = new LinkedList(arrayExpected);
            LinkedList actual = new LinkedList(arrayActual);

            actual.AddByIndex(value, index);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2 })]
        [TestCase(new int[] { 5, 8, 22 }, new int[] { 5, 8 })]
        [TestCase(new int[] { 33, -567, 9021, 34, -66, -3243 }, new int[] { 33, -567, 9021, 34, -66 })]
        public void RemoveLastTests(int[] arrayActual, int[] arrayExpected)
        {
            LinkedList expected = new LinkedList(arrayExpected);
            LinkedList actual = new LinkedList(arrayActual);

            actual.RemoveLast();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 5 }, 0, new int[] { 1, 2, 3, 5 })]
        [TestCase(new int[] { 5, 8, 22 }, 1, new int[] { 5, 8 })]
        [TestCase(new int[] { 33, -567, 9021, 34, -66, -3243 }, 4, new int[] { 33, -567 })]
        public void RemoveLastSeveralElementsTests(int[] arrayActual, int number, int[] arrayExpected)
        {
            LinkedList expected = new LinkedList(arrayExpected);
            LinkedList actual = new LinkedList(arrayActual);

            actual.RemoveLastSeveralElements(number);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 5 }, 0, new int[] { 1, 2, 3, 5 })]
        //[TestCase(new int[] { 5, 8, 22 }, 1, new int[] { 8, 22 })]
        //[TestCase(new int[] { 33, -567, 9021, 34, -66, -3243 },4, new int[] { -66, -3243 })]
        public void RemoveFirstSeveralElementsTests(int[] arrayActual, int number, int[] arrayExpected)
        {
            LinkedList expected = new LinkedList(arrayExpected);
            LinkedList actual = new LinkedList(arrayActual);

            actual.RemoveFirstSeveralElements(number);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 5 }, 0, 1, new int[] { 2, 3, 5 })]
        [TestCase(new int[] { 5, 8, 22 }, 1, 1, new int[] { 5, 22 })]
        [TestCase(new int[] { 33, -567, 9021, 34, -66, -3243 }, 2, 3, new int[] { 33, -567, -3243 })]
        public void RemoveByIndexSeveralElementsTests(int[] arrayActual, int index, int number, int[] arrayExpected)
        {
            LinkedList expected = new LinkedList(arrayExpected);
            LinkedList actual = new LinkedList(arrayActual);

            actual.RemoveByIndexSeveralElements(index, number);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 5 }, 1, 0)]
        [TestCase(new int[] { 5, 8, 22 }, 8, 1)]
        [TestCase(new int[] { 33, -567, 9021, 34, -66, -3243 }, 9021, 2)]
        public void GetIndexByValueTests(int[] arrayActual, int value, int expected)
        {
            LinkedList actualList = new LinkedList(arrayActual);

            int actual = actualList.GetIndexByValue(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 5 }, 0, 0, new int[] { 0, 2, 3, 5 })]
        [TestCase(new int[] { 5, 8, 22 }, 1, 1, new int[] { 5, 1, 22 })]
        [TestCase(new int[] { 33, -567, 9021, 34, -66, -3243 }, 2, 55, new int[] { 33, -567, 55, 34, -66, -3243 })]
        public void ChangeValueByIndexTests(int[] arrayActual, int index, int value, int[] arrayExpected)
        {
            LinkedList expected = new LinkedList(arrayExpected);
            LinkedList actual = new LinkedList(arrayActual);

            actual.ChangeValueByIndex(index, value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 5 }, 5)]
        [TestCase(new int[] { 5, 8, 22 }, 22)]
        [TestCase(new int[] { 33, -567, 9021, 34, -66, -3243 }, 9021)]
        public void SearchMaxValueTests(int[] arrayActual, int expected)
        {
            LinkedList actualList = new LinkedList(arrayActual);

            int actual = actualList.SearchMaxValue();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 5 }, 1)]
        [TestCase(new int[] { 5, 8, 22 }, 5)]
        [TestCase(new int[] { 33, -567, 9021, 34, -66, -3243 }, -3243)]
        public void SearchMinValueTests(int[] arrayActual, int expected)
        {
            LinkedList actualList = new LinkedList(arrayActual);

            int actual = actualList.SearchMinValue();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 5 }, 3)]
        [TestCase(new int[] { 5, 8, 22 }, 2)]
        [TestCase(new int[] { 33, -567, 34, -66, -3243, 90213 }, 5)]
        public void SearchIndexOfMaxValueTests(int[] arrayActual, int expected)
        {
            LinkedList actualList = new LinkedList(arrayActual);

            int actual = actualList.SearchIndexOfMaxValue();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 5 }, new int[] { 5, 3, 2, 1 })]
        [TestCase(new int[] { 5, 8, 22 }, new int[] { 22, 8, 5 })]
        [TestCase(new int[] { 33, -567, 34, -66, -3243, 90213 }, new int[] { 90213, -3243, -66, 34, -567, 33 })]
        public void ReverseTests(int[] arrayActual, int[] arrayExpected)
        {
            LinkedList expected = new LinkedList(arrayExpected);
            LinkedList actual = new LinkedList(arrayActual);

            actual.Reverse();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 5 }, 0)]
        [TestCase(new int[] { 5, -7, 22 }, 1)]
        [TestCase(new int[] { 33, -567, 34, -66, -3243, 90213 }, 4)]
        public void SearchIndexOfMinValueTests(int[] arrayActual, int expected)
        {
            LinkedList actualList = new LinkedList(arrayActual);

            int actual = actualList.SearchIndexOfMinValue();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 5 }, new int[] { 1, 2, 3, 5 })]
        [TestCase(new int[] { 5, -7, 22 }, new int[] { -7, 5, 22 })]
        [TestCase(new int[] { 33, -567, 34, -66, -3243, 90213 }, new int[] { -3243, -567, -66, 33, 34, 90213 })]
        public void SortTests(int[] arrayActual, int[] arrayExpected)
        {
            LinkedList actual = new LinkedList(arrayActual);
            LinkedList expected = new LinkedList(arrayExpected);

            actual.Sort();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 5 }, new int[] { 5, 3, 2, 1 })]
        [TestCase(new int[] { 5, -7, 22 }, new int[] { 22, 5, -7 })]
        [TestCase(new int[] { 33, -567, 34, -66, 90213 }, new int[] { 90213, 34, 33, -66, -567 })]
        public void SortReverseTests(int[] arrayActual, int[] arrayExpected)
        {
            LinkedList actual = new LinkedList(arrayActual);
            LinkedList expected = new LinkedList(arrayExpected);

            actual.SortReverse();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 5 }, 1, 0)]
        [TestCase(new int[] { 5, 8, 22 }, 8, 1)]
        [TestCase(new int[] { 33, -567, 9021, 34, -66, -3243 }, 9021, 2)]
        public void RemoveByValueTests(int[] arrayActual, int value, int expected)
        {
            LinkedList actualList = new LinkedList(arrayActual);

            int actual = actualList.RemoveByValue(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 5 }, 1, new int[] { 2, 3, 5 })]
        [TestCase(new int[] { 5, 8, 22 }, 8, new int[] { 5, 22 })]
        [TestCase(new int[] { 33, -567, 9021, 34, -66, -3243 }, 9021, new int[] { 33, -567,  34, -66, -3243 })]
        public void RemoveByValueChekListTests(int[] arrayActual, int value, int[] arrayExpected)
        {
            LinkedList actual = new LinkedList(arrayActual);
            LinkedList expected = new LinkedList(arrayExpected);

            actual.RemoveByValue(value);

            Assert.AreEqual(expected, actual);
        }



    }
}
