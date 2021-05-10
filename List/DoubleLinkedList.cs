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
        public DoubleLinkedList()
        {
            CreateEmptyList();
        }
        public DoubleLinkedList(int value)
        {
            CreateListWithOneElement(value);
        }
        public DoubleLinkedList(int[] array)
        {
            if (array is null)
            {
                throw new NullReferenceException();
            }
            if (array.Length > 0)
            {
                CreateListWithOneElement(array[0]);
                for (int i = 1; i < array.Length; i++)
                {
                    if (i == 1)
                    {
                        _root.Next = new DoubleNode(array[1]);
                    }
                    Add(array[i]);
                }
            }
            else
            {
                CreateEmptyList();
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
        public void Remove()
        {
            RemoveByIndex(Length - 1);
        }
        public void RemoveAtFirstIndex()
        {
            RemoveByIndex(0);
        }
        public void RemoveByIndex(int index)
        {
            CheckIndex(index);
            CheckArrayIsNotEmpty();
            if (Length == 1)
            {
                CreateEmptyList();
            }
            else if (index == 0)
            {
                _root = _root.Next;
                _root.Prev = null;
            }
            else if (index == Length - 1)
            {
                _tail = _tail.Prev;
                _tail.Next = null;
            }
            else
            {
                GetNodeByIndex(index).Prev.Next = GetNodeByIndex(index).Next;
                GetNodeByIndex(index).Next.Prev = GetNodeByIndex(index).Prev;
            }
            Length = Length == 0 ? 0 : --Length;
        }
        public void RemoveLastValues(int count)
        {
            CheckCountArgumentIsValid(count);
            CheckListHasEnoughElementsOrNotEmpty(count);
            if (Length == count)
            {
                CreateEmptyList();
            }
            if (count > 0)
            {
                int index = Length - count;
                _tail = GetNodeByIndex(index).Prev;
                _tail.Next = null;
                Length -= count;
            }
        }
        public void RemoveFirstValues(int count)
        {
            RemoveValuesByIndex(0, count);
        }
        public void RemoveValuesByIndex(int index, int count)
        {
            CheckCountArgumentIsValid(count);
            CheckIndex(index);
            CheckListHasEnoughElementsOrNotEmpty(count);
            if (Length - index < count)
            {
                throw new Exception($"Removing more elements than left in array from index {index}");
            }
            if (Length == count)
            {
                CreateEmptyList();
            }
            if (index == 0)
            {
                _root = GetNodeByIndex(count);
                _root.Prev = null;
                Length -= count;
            }
            else
            {
                if (Length - index == count)
                {
                    _tail = GetNodeByIndex(index).Prev;
                    _tail.Next = null;
                }
                else if (count > 0)
                {
                    int lastIndex = index + count;
                    GetNodeByIndex(lastIndex).Prev = GetNodeByIndex(index).Prev;
                    GetNodeByIndex(index).Prev.Next = GetNodeByIndex(lastIndex);
                }
                Length -= count;
            }
        }
        public int GetLength()
        {
            return this.Length;
        }
        public int GetFirstIndexByValue(int value)
        {
            for (int i = 0; i < Length; i++)
            {
                if (value == GetNodeByIndex(i).Value)
                {
                    return i;
                }
            }
            return -1;
        }
        public void Reverse()
        {
            DoubleNode current = _root;
            DoubleNode tmp = null;
            while (!(current is null))
            {
                tmp = current.Prev;
                current.Prev = current.Next;
                current.Next = tmp;
                current = current.Prev;
            }
            if (!(tmp is null))
            {
                _tail = GetNodeByIndex(0);
                _root = tmp.Prev;
            }
        }
        public int GetMaxValue()
        {
            return this[GetIndexOfMaxValue()];
        }
        public int GetIndexOfMaxValue()
        {
            CheckArrayIsNotEmpty();

            int max = GetNodeByIndex(0).Value;
            int maxIndex = 0;
            for (int i = 1; i < Length; i++)
            {
                if (GetNodeByIndex(i).Value > max)
                {
                    max = GetNodeByIndex(i).Value;
                    maxIndex = i;
                }
            }
            return maxIndex;
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
        private void CheckCountArgumentIsValid(int count)
        {
            if (count < 0)
            {
                throw new ArgumentException("Invalid input");
            }
        }
        private void CheckListHasEnoughElementsOrNotEmpty(int count)
        {
            if (count > Length ||
                Length == 0)
            {
                throw new Exception("Removing more elements than left in array");
            }
        }
        private void CheckArgumentIsNotNull(DoubleLinkedList list)
        {
            if (list is null)
            {
                throw new NullReferenceException();
            }
        }
        private DoubleLinkedList CopyList(DoubleLinkedList list)
        {
            DoubleLinkedList copy = new DoubleLinkedList();
            for (int i = 0; i < list.GetLength(); i++)
            {
                copy.Add(list[i]);
            }
            return copy;
        }
    }
}
