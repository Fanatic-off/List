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

        public ArrayList(int lenght = 10)
        {
            Lenght = 0;
            _array = new int[lenght];
        }

        public ArrayList(int[] array)
        {
            Lenght = array.Length;
            _array = new int[(int)(array.Length * 1.33)];
            CopyArray(array);
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
            int[] result = new int[Lenght + 1];
            result[0] = value;
            for (int i = 0; i < Lenght; i++)
            {
                result[i + 1] = _array[i];
            }
            CopyArray(result);
        }

        public void AddValueByIndex(int index, int value)
        {
            int[] result = new int[Lenght + 1];
            for(int i = 0; i < Lenght; i++)
            {
                if (i < index)
                {
                    result[i] = _array[i];
                }
                else
                {
                    result[i + 1] = _array[i];
                }
            }
            result[index] = value;
            CopyArray(result);
        }

        public void Remove()
        {
            if (0 < Lenght)
            {
                Lenght--;
            }
        }

        public void RemoveFromBegining()
        {
            int[] result = new int[Lenght = Lenght - 1];
            if (1 < _array.Length)
            {
                UpSize();
                for (int i = 0; i < Lenght; i++)
                {
                    result[i] = _array[i + 1];
                }
            }
            else
            {
                throw new Exception("Array's lenght less 1");
            }
            CopyArray(result);
        }

        public void RemoveByIndex(int index)
        {
            int[] result = new int[Lenght = Lenght - 1];
            if (1 < Lenght)
            {
                UpSize();
                for (int i = 0; i < Lenght; i++)
                {
                    if (i < index)
                    {
                        result[i] = _array[i];
                    }
                    else
                    {
                        result[i] = _array[i + 1];
                    }
                }
                CopyArray(result);
            }
        }

        public void RemoveSeveralElementsFromTheEnd(int number)
        {
            if (number < Lenght)
            {
                for (int i = 0; i < number; i++)
                {
                    Lenght--;
                }
            }
        }

        public void RemoveSeveralElementsFromTheBegin(int number)
        {
            if (number < Lenght)
            {
                int[] result = new int[Lenght = Lenght - number];
                for (int i = 0; i < Lenght; i++)
                {
                    result[i] = _array[i + number];
                }
                CopyArray(result);
            }
        }

        public void RemoveSeveralElementsByIndex(int index, int number)
        {
            if (number < Lenght)
            {
                int[] result = new int[Lenght = Lenght - number];
                for (int i = 0; i < Lenght; i++)
                {
                    if (i < index)
                    {
                        result[i] = _array[i];
                    }
                    else
                    {
                        result[i] = _array[i + number];
                    }
                }
                CopyArray(result);
            }
        }

        public int AccessByIndex(int index)
        {
            if (0 <= index && index <= Lenght)
            {
                return _array[index];
            }
            return -1;
        }   

        public int AccessFirstIndexByValue(int value)
        {
            for (int i = 0; i < Lenght; i++)
            {
                if(value == _array[i])
                {
                    return i;
                }
            }
            return -1;
        }

        public void ChangeValueByIndex(int index, int value)
        {
            if ((0 <= index) && (index < Lenght))
            {
                _array[index] = value;
            }
            else
            {
                throw new Exception("Invalid index");
            }
        }

        public void Reverse()
        {
            int[] result = new int[Lenght];
            for(int i = 0; i < Lenght; i++)
            {
                result[Lenght - i - 1] = _array[i];
            }
            CopyArray(result);
        }

        public int SearchMaxValue()
        {
            int Max = _array[0];
            for (int i = 0; i < Lenght; i++)
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
            for (int i = 0; i < Lenght; i++)
            {
                if (_array[i] < Min)
                {
                    Min = _array[i];
                }
            }
            return Min;
        }

        public int SearchIndexOfMaxValue()
        {
            int Max = _array[0];
            int index = 0;
            for (int i = 0; i < Lenght; i++)
            {
                if (Max < _array[i])
                {
                    Max = _array[i];
                    index = i;
                }
            }
            return index;
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

        public override bool Equals(object obj)
        {
            ArrayList arrayList = (ArrayList)obj;
            bool b = true;
            for (int i = 0; i < arrayList.Lenght; i++)
            {
                if (arrayList._array[i] != this._array[i])
                {
                    b = false;
                }
            }
            return Lenght == arrayList.Lenght && b;
        }

        public override string ToString()
        {
            String result = "";
            for (int i = 0; i < _array.Length; i++)
            {
                result += _array[i] + " "; 
            }
            return result;
        }

        private void CopyArray(int[] array)
        {
            _array = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                _array[i] = array[i];
                Lenght = array.Length;
            }
        }

        private void UpSize()
        {
            int newLenght = (int)(_array.Length * 1.33 + 1);
            int[] result = new int[newLenght];
            for (int i = 0; i < _array.Length; i++) 
            {
                result[i] = _array[i];
            }
            _array = result;
        }
    }
}
