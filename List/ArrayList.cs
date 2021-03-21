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

        }

        public ArrayList(int lenght)
        {
            Lenght = 0;

            _array = new int[lenght=10];
        }

        public ArrayList(int[] array)
        {
            _array = array;

            Lenght = array.Length;
        }

        public void Add(int value)
        {
            if (Lenght == _array.Length)
            {
                UpSize();
            }

            _array[Lenght] = value;
            Lenght++;
        }

        public void AddToStart(int value)
        {
            if (Lenght == _array.Length)
            {
                UpSize();
            }

            int[] tmpArray = new int[_array.Length];

            for (int i = 0; i < _array.Length; i++)
            {
                tmpArray[i + 1] = _array[i];
            }
            tmpArray[0] = value;
        }

        public void AddValueByIndex(int index, int value)
        {
            if (Lenght == _array.Length)
            {
                UpSize();
            }

            int[] tmpArray = new int[_array.Length];
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

        public void AccessValueByIndex(int index, int value)
        {
            if ((index <= _array.Length) && (index > 0))
            {
                _array[index - 1] = value;
            }
            else
            {
                throw new Exception("Invalid index");
            }
        }

        public void Reverse()
        {
            int[] tmpArray = new int[_array.Length];

            for(int i = 0; i < _array.Length; i++)
            {
                tmpArray[tmpArray.Length - i] = _array[i];
            }
            _array = tmpArray;
        }

        public int SearchMaxValue()
        {
            int Max = _array[0];
            for (int i = 0; i < _array.Length; i++)
            {
                if (Max < _array[i])
                {
                    Max = _array[i];
                }
            }
            return Max;
        }

        public int SearchMinValue()
        {
            int Min = _array[0];

            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] < Min)
                {
                    Min = _array[i];
                }
            }
            return Min;
        }

        public int SearchIndexByMaxValue()
        {
            int Max = _array[0];
            int tmp = 0;

            for (int i = 0; i < _array.Length; i++)
            {
                if (Max < _array[i])
                {
                    Max = _array[i];
                    tmp = i;
                }
            }
            return tmp + 1;
        }

        public int SearchIndexByMinValue()
        {
            int Min = _array[0];
            int tmp = 0;

            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] < Min)
                {
                    Min = _array[i];
                    tmp = i;
                }
            }
            return tmp + 1;
        }

        public void Sort()
        {
            int[] tmpArray = new int[_array.Length];
            int Min = _array[0];

            for(int i = 0; i < _array.Length; i++)
            {
                for(int j = i; j < _array.Length; j++)
                {
                    if (_array[j] < Min)
                    {
                        Min = _array[j];
                        tmpArray[i] = Min;
                    }
                }
            }
            _array = tmpArray;
        }

        public void SortReverse()
        {
            int[] tmpArray = new int[_array.Length];
            int Max = _array[0];

            for (int i = 0; i < _array.Length; i++)
            {
                for (int j = i; j < _array.Length; j++)
                {
                    if (Max < _array[j])
                    {
                        Max = _array[j];
                        tmpArray[i] = Max;
                    }
                }
            }
            _array = tmpArray;

        }

        public int RemoveFirstValue(int value)
        {
            for (int i = 0; i < Lenght; i++)
            {
                if (_array[i] == value)
                {
                    _array[i] = 0;
                    return i + 1;
                }
            }
            return -1;
        }

        public int RemoveAllValue(int value)
        {
            int count = 0;

            for (int i = 0; i < Lenght; i++)
            {
                if (_array[i] == value)
                {
                    _array[i] = 0;
                    count++;
                }
            }

            return count;
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
