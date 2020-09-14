using System;
using System.Collections.Generic;

namespace CircularBuffer
{
    
    public class Circularbuffer<T>
    {
        private int Size;
        private int currentIndex = 0;
        private int? oldestIndex = null;
        private T[] array;

        public int arrayGetSize()
        {
            return Size;
        }

        public void arrayCreate(int size)
        {
            Size = size;
            array = new T[size + 1];
        }

        public void addOne(T value)
        {
            if (oldestIndex == null)
            {
                oldestIndex = 0;
            }
            else
            {
                if (oldestIndex == currentIndex)
                {
                    oldestIndex++;
                }
                if (oldestIndex > Size)
                {
                    oldestIndex = 0;
                }
            }
          
            
            if (currentIndex < Size)
            {
                array[currentIndex] = value;
                currentIndex++;
            }
            else
            {
                currentIndex = 0;
                array[currentIndex] = value;
                
            }
            
        }

        public T returnArraySpecific(int value)
        {
            if (value < Size)
            {
                return array[value];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }


        public void forEachRead()
        {
            foreach(T obj in array)
                {
                Console.Write(obj);
                Console.WriteLine();
            }
        }

        public void oldestRead()
        {
            if (oldestIndex == null)
            {
                Console.Write("No items in array");
                Console.WriteLine();
            }
            else
            {
                Console.Write(array[(int)oldestIndex]);
                Console.WriteLine();
            }
        }

 
        
        
    }


}