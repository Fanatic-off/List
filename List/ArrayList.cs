﻿using System;
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

        public void Add(int value)
        {
            ChekAndUpSize();

            _array[Lenght] = value;
            Lenght++;
        }

        private void ChekAndUpSize()
        {
            if (Lenght == _array.Length)
            {
                UpSize();
            }
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
    }
}
