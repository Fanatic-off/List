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
        public int this[int index]
        {
            get
            {
                CheckIndex(index);
                return GetNodeByIndex(index).Value;
            }
            set
            {
                CheckIndex(index);
                GetNodeByIndex(index).Value = value;
            }
        }
        public void Add(int value)
        {
            AddAtIndex(value, Length);
        }
        public void AddAtFirstIndex(int value)
        {
            AddAtIndex(value, 0);
        }
        public void AddAtIndex(int value, int index)
        {
            if (index > Length || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            DoubleNode temp = new DoubleNode(value);
            if (Length == 0)
            {
                CreateListWithOneElement(value);
            }
            else if (index == 0)
            {
                temp.Prev = null;
                temp.Next = _root;
                _root.Prev = temp;
                _root = temp;
                Length++;
            }
            else if (index == Length)
            {
                temp.Next = null;
                temp.Prev = _tail;
                _tail.Next = temp;
                _tail = temp;
                Length++;
            }
            else
            {
                temp.Next = GetNodeByIndex(index);
                temp.Prev = GetNodeByIndex(index).Prev;
                temp.Next.Prev = temp;
                temp.Prev.Next = temp;
                Length++;
            }
        }
        public override bool Equals(object obj)
        {
            DoubleLinkedList list = (DoubleLinkedList)obj;
            if (Length != list.Length)
            {
                return false;
            }
            if (Length == 0 && list.Length == 0)
            {
                return true;
            }
            DoubleNode currentThis = _root;
            DoubleNode currentList = list._root;
            if (currentThis.Value != currentList.Value)
            {
                return false;
            }
            while (!(currentThis.Next is null))
            {
                currentList = currentList.Next;
                currentThis = currentThis.Next;
                if (currentThis.Value != currentList.Value)
                {
                    return false;
                }
            }
            return true;
        }
        public override string ToString()
        {
            string s = "";
            if (Length != 0)
            {
                DoubleNode current = _root;
                s += current.Value;
                while (!(current.Next is null))
                {
                    current = current.Next;
                    s += " " + current.Value;
                }
                return s;
            }
            return s;
        }
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
        private DoubleNode GetNodeByIndex(int index)
        {
            if (index < Length / 2)
            {
                DoubleNode current = _root;
                for (int i = 1; i <= index; i++)
                {
                    current = current.Next;
                }
                return current;
            }
            else
            {
                DoubleNode current = _tail;
                for (int i = Length - 2; i >= index; i--)
                {
                    current = current.Prev;
                }
                return current;
            }
        }
        private void CheckIndex(int index)
        {
            if (index >= Length || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
        }
        private void CheckArrayIsNotEmpty()
        {
            if (Length == 0)
            {
                throw new Exception("This array is empty");
            }
        }
    }
}
