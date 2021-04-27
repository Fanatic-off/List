using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    public class LinkedList
    {
        public int Length { get; private set; }
        public int this[int index]
        {
            get
            {
                Node current=_root;

                for(int i=1;i<=index; i++)
                {
                    current = current.Next;
                }
                return current.Value;
            }

            set
            {
                Node current = _root;

                for (int i = 1; i <= index; i++)
                {
                    current = current.Next;
                }

                current.Value = value;
            }
        }

        private Node _root;
        private Node _tail;

        public LinkedList()
        {
            CreateEmpyList();
        }

        public LinkedList(int value)
        {
            CreateListByOneValue(value);
        }

        public LinkedList(int[] values)
        {
            if (values.Length != 0)
            {
                _root = new Node(values[0]);
                _tail = _root;
                for (int i = 1; i < values.Length; i++)
                {
                    _tail.Next = new Node(values[i]);
                    _tail = _tail.Next;
                }
                Length = values.Length;
            }
            else
            {
                CreateEmpyList();
            }
        }

        public void Add(int value)
        {
            Length++;
            _tail.Next = new Node(value);
            _tail = _tail.Next;
        }

        public void AddToRoot(int value)
        {
            Length++;
            Node tmp = _root;
            _root = new Node(value);
            _root.Next = tmp;
        }

        public void AddByIndex(int value, int index)
        {
            Length++;
            Node current = _root;

            if (Length == 0)
            {
                CreateListByOneValue(value);
            }
            if (index == 0)
            {
                AddToRoot(value);
            }
            else
            {
                current = SearchCurrentNodeByIndex(index - 1);
                Node tmpRoot = current;
                Node tmpTail = current.Next;
                current = new Node(value);
                tmpRoot.Next = current;
                current.Next = tmpTail;
            }
        }

        public void RemoveLast()
        {
            Length--;
            _tail = SearchCurrentNodeByIndex(Length - 1);
            _tail.Next = null;
        }

        public void RemoveFirst()
        {
            _root = _root.Next;
        }

        public void RemoveByIndex(int index)
        {
            Node current = _root;

            SearchCurrentNodeByIndex(index);

            current.Next = current.Next.Next;

            Length--;
        }

        public void RemoveLastSeveralElements(int number)
        {
            if (number < Length)
            {
                for(int i = 0; i < number; i++)
                {
                    RemoveLast();
                }
            }
        }

        public void RemoveFirstSeveralElements(int number)
        {
            if (number < Length)
            {
                for(int i = 0; i < number; i++)
                {
                    RemoveFirst();
                }
            }
        }

        public void RemoveByIndexSeveralElements(int index, int number)
        {

            if ((number < Length)&&
                (index < Length - 1)&&
                (index != 0))
            {
                for(int i = 0; i < number; i++)
                {
                    RemoveByIndex(index);
                }
            }
            if (index == 0)
            {
                RemoveFirst();
            }
        }

        public int GetIndexByValue(int value)
        {
            Node current = _root;
            int index = 0;

            do
            {
                if (current.Value == value)
                {
                    return index;
                }
                current = current.Next;
                index++;
            }
            while (!(current.Next is null));
            return -1;
        }

        public void ChangeValueByIndex(int index, int value)
        {
            Node current = _root;

            current = SearchCurrentNodeByIndex(index);
            current.Value = value;
        }

        public void Reverse()
        {
            Node current = _root;
            Node previous = null;
            Node tmpNext = null;

            while (current != null)
            {
                tmpNext = current.Next;
                current.Next = previous;
                previous = current;
                current = tmpNext;
            }
            _root = previous;
        }

        public int SearchMaxValue()
        {
            Node current = _root;
            int max = current.Value;

            for (int i = 0; i < Length; i++)
            {
                if (max < current.Value)
                {
                    max = current.Value;
                }
                current = current.Next;
            }
            return max;
        }

        public int SearchMinValue()
        {
            Node current = _root;
            int min = current.Value;

            for (int i = 0; i < Length; i++)
            {
                if (current.Value < min)
                {
                    min = current.Value;
                }
                current = current.Next;
            }
            return min;
        }

        public int SearchIndexOfMaxValue()
        {
            int max = _root.Value;
            int index = 0;
            Node tmp = _root.Next;
            for (int i = 1; i < Length; i++)
            {
                if (max < tmp.Value)
                {
                    max = tmp.Value;
                    index = i;
                }
                tmp = tmp.Next;
            }
            return index;
        }

        public int SearchIndexOfMinValue()
        {
            int min = SearchMinValue();
            return GetIndexByValue(min);
        }

        public void Sort()
        {
            Node current = _root;
            int tmp;
            for (int i = 0; i < Length; i++)
            {
                Node tmpNode = current.Next;
                for (int j = i + 1; j < Length; j++)
                {
                    if (current.Value > tmpNode.Value)
                    {
                        tmp = current.Value;
                        current.Value = tmpNode.Value;
                        tmpNode.Value = tmp;
                    }
                    tmpNode = tmpNode.Next;
                }
                current = current.Next;
            }   
            //while (tmpNext != null) 
            //{
            //    tmpNext = current.Next;
            //    value = current.Value;
            //    min = SearchMinValue(current);
            //    minIndex = GetIndexByValue(min);
            //    current.Value = min;
            //    ChangeValueByIndex(minIndex, value);
            //    current = current.Next;
            //}
        }
        public void SortReverse()
        {
            Node current = _root;
            int tmp;
            for (int i = 0; i < Length; i++)
            {
                Node tmpNode = current.Next;
                for (int j = i + 1; j < Length; j++)
                {
                    if (tmpNode.Value > current.Value)
                    {
                        tmp = current.Value;
                        current.Value = tmpNode.Value;
                        tmpNode.Value = tmp;
                    }
                    tmpNode = tmpNode.Next;
                }
                current = current.Next;
            }

        }

        private int[] SearchIndexAndValueMaximumElement()
        {
            int indexMaxElement = 0;
            int maxElement = _root.Value;
            Node current = _root;
            for (int i = 0; i < Length; i++)
            {
                if (current.Value > maxElement)
                {
                    maxElement = current.Value;
                    indexMaxElement = i;
                }
                current = current.Next;
            }
            return new int[] { indexMaxElement, maxElement };

        }
        private int[] SearchIndexAndValueMinimumElement()
        {
            int indexMinElement = 0;
            int minElement = _root.Value;
            Node current = _root;
            for (int i = 0; i < Length; i++)
            {
                if (current.Value < minElement)
                {
                    minElement = current.Value;
                    indexMinElement = i;
                }
                current = current.Next;
            }
            return new int[] { indexMinElement, minElement };

        }

        public override string ToString()
        {
            if (Length != 0)
            {
                Node current = _root;
                string s = current.Value + " ";

                while (!(current.Next is null))
                {
                    current = current.Next;
                    s += current.Value + " ";
                }

                return s;
            }
            else
            {
                return String.Empty;
            }
        }
        public override bool Equals(object obj)
        {
            LinkedList list = (LinkedList)obj;
            if (this.Length != list.Length)
            {
                return false;
            }
            if (this.Length == 0)
            {
                return true;
            }
            if (this._tail.Value != list._tail.Value)
            {
                return false;
            }
            if (!(this._tail.Next is null) || !(list._tail.Next is null))
            {
                return false;
            }
            Node currentThis = this._root;
            Node currentList = list._root;
            do
            {
                if (currentThis.Value != currentList.Value)
                {
                    return false;
                }
                currentList = currentList.Next;
                currentThis = currentThis.Next;
            }
            while (!(currentThis.Next is null));

            return true;
        }
        private Node SearchCurrentNodeByIndex(int index)
        {
            Node current = _root;

            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current;
        }
        private void CreateEmpyList()
        {
            Length = 0;
            _root = null;
            _tail = _root;
        }

        private void CreateListByOneValue(int value)
        {
            Length = 1;
            _root = new Node(value);
            _tail = _root;
        }
    }
}

