using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    public class DoubleLinkedList
    {
        public int Length { get; private set; }

        private DoubleNode _root;
        private DoubleNode _tail;

        private void CreateEmptyList()
        {
            Length = 0;
            _root = null;
            _tail = _root;
        }
        private void CreateListWithOneElement(int value)
        {
            Length = 1;
            _root = new DoubleNode(value);
            _tail = _root;
        }
    }
}
