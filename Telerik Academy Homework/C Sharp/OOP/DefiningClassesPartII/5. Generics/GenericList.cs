using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.Generics
{
    class GenericList<T>
    {
        const int DefaultCapacity = 10;

        private T[] elements;
        private int count = 0;

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public void Add(T element)
        {
            if (count >= elements.Length)
            {
                Grow();
            }
            this.elements[count] = element;
            count++;
        }

        public T this[int index]
        {
            get
            {
                if (index >= count)
                {
                    throw new IndexOutOfRangeException(String.Format("Invalid index: {0}.", index));
                }
                T result = elements[index];
                return result;
            }
        }

        public void Remove(int index)
        {
            if (index >= count)
            {
                throw new IndexOutOfRangeException(String.Format("Invalid index: {0}.", index));
            }
            this.elements[index] = null;
            count--;
        }

        public T this[int index]
        {
            set
            {
                if (index >= count)
                {
                    throw new IndexOutOfRangeException(String.Format("Invalid index: {0}.", index));
                }
                T result = elements[index];
            }
        }

        public void Clear()
        {
            elements = new T[DefaultCapacity];
        }

        public override string ToString(int val)
        {
            foreach (var item in elements)
            {
                if (item.IndexOf(val) == 0)
                {
                    return item.ToString();
                }
            }
        }

        private void Grow()
        {
            T[] newArr = new T[elements.Length * 2];
            Array.Copy(elements, newArr, elements.Length);
            elements = newArr;
        }

        

    }
}
