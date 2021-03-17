using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    public class ArrayList
    {
        public int Lenght { get; private set; }
        
        private int[] _array;

        public ArrayList()
        {
            Lenght = 0;

            _array = new int[10];
        }



        public void Add(int value)
        {
            ChekAndUpSize();

            _array[Lenght] = value;
            Lenght++;
        }

        public void AddToStart(int value)
        {
            ChekAndUpSize();

            int[] tmpArray = new int[Lenght];

            for (int i = 0; i < _array.Length; i++)
            {
                tmpArray[i + 1] = _array[i];
            }
            tmpArray[0] = value;
        }

        public void AddValueByIndex(int index, int value)
        {
            ChekAndUpSize();

            int[] tmpArray = new int[Lenght];
            for (int i = 0; i < index; i++)
            {
                tmpArray[i] = _array[i];
            }

            for (int i = index - 1; i < _array.Length; i++)
            {
                tmpArray[i + 1] = _array[i];
            }

            tmpArray[index - 1] = value;
            _array = tmpArray;
        }

        public void Remove()
        {
            if(1 < Lenght)
            {
                Lenght--;
            }
        }

        public void RemoveFromBegining()
        {
            if (1 < Lenght)
            {
                for (int i = 0; i < _array.Length; i++) 
                {
                    _array[i] = _array[i + 1];
                }
            }
        }

        public void RemoveByIndex(int index)
        {
            if(1 < Lenght)
            {
                for (int i = index; i < _array.Length; i++)
                {
                    _array[i] = _array[i + 1];
                }
            }
        }

        public void RemoveNumberFromTheEndElements(int number)
        {
            if (number < Lenght)
            {
               for(int i =0; i < number; i++)
                {
                    Lenght--;
                }
            }
        }

        public void RemoveNumberFromTheBeginingElements(int number)
        {
            if (number < Lenght)
            {
                for (int i = 0; i < _array.Length; i++)
                {
                    _array[i] = _array[number + i];
                }
            }
        }

        public void RemoveNumberByIndexElements(int index, int number)
        {
            if (number < Lenght)
            {
                for (int i = index; i < _array.Length; i++)
                {
                    _array[i] = _array[number + i];
                }
            }
        }

        public int AccessByIndex(int index)
        {
            return _array[index - 1];
        }   

        public int AccessFirstIndexByValue(int value)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if(value == _array[i])
                {
                    return i + 1;
                }
            }
            return -1;
        }

        private void ChekAndUpSize()
        {
            if (Lenght == _array.Length)
            {
                UpSize();
            }
        }

        private void UpSize()
        {
            int newLenght = (int)(_array.Length * 1.33 + 1);
            int[] tmpArray = new int[newLenght];
            
            for (int i = 0; i < _array.Length; i++) 
            {
                tmpArray[i] = _array[i];
            }
            _array = tmpArray;
        }
    }
}
