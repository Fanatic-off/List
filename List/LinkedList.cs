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
            Length = 0;
            _root = null;
            _tail = null;
        }

        public LinkedList(int value)
        {
            Length = 1;
            _root = new Node(value);
            _tail = _root;
        }

        public LinkedList(int[] values)
        {
            //if(values is null)

            Length = values.Length;

            if (values.Length != 0)
            {
                _root = new Node(values[0]);
                _tail = _root;

                for (int i = 1; i < values.Length; i++)
                {
                    _tail.Next = new Node(values[i]);
                    _tail = _tail.Next;
                }
            }
            else
            {
                _root = null;
                _tail = null;
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

            if(this.Length!=list.Length)
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

    }
}
