using System;
using System.Collections.Generic;

namespace CircularBuffer
{
    
    public class Circularbuffer<T>
    {
        private int size;
        private int currentIndex = 0;
        private int? oldestIndex = null;
        private T[] array;

        public int arrayGetSize()
        {
            return size;
        }

        public void arrayCreate(int size)
        {
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
                if (oldestIndex > size)
                {
                    oldestIndex = 0;
                }
            }
          
            
            if (currentIndex < size)
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
            if (value < size)
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
            Console.Write(array[oldestIndex]);
            Console.WriteLine();
        }

 
        
        
    }


}