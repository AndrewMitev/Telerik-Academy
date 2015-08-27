using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class GenericList<T> where T : IComparable<T>
    {
        private T[] array;

        private int Count { set; get; }
        private long Capacity {set; get; }
        private static readonly int DEFAULT_SIZE = 4;

        public GenericList(int size)
        {
            array = new T[size];
            this.Count = 0;
            this.Capacity = size;
        }

        public void Add(T element)
        {
            if (this.Count == this.Capacity)
            {
                T[] newArray = new T[this.Capacity * 2];
                this.Capacity *= 2;
                Array.Copy(this.array, newArray, this.Count);
                this.array = newArray;
            }

            this.array[this.Count] = element;
            this.Count++;
        }

        public T GetElementAt(int index)
        {
            if (index >= 0 && index < this.Count)
            {
                return this.array[index];
            }
            else
            {
                throw new ArgumentOutOfRangeException("Invalid index!");
            }
        }

        public void RemoveElementAt(int index)
        {
 
            if (index >= 0 && index < this.Count)
            {
                T[] newArray = new T[this.Count - 1];

                for (int i = 0; i < this.Count - 1; i++)
                {
                    int j = i;

                    if (j >= index)
                    {
                        newArray[i] = this.array[i + 1];
                    }
                    else
                    {
                        newArray[i] = this.array[i];
                    }
                }

                this.Count--;
                this.array = newArray;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Invalid index!");
            }
        }

        public void InsertElementAt(T element, int position)
        {
            if (this.Count == this.Capacity)
            {
                Console.WriteLine("Shortage of space! Sorry.");
                return;
            }

            if (position < 0 || position > Count)
            {
                Console.WriteLine("Invalid index");
                return;
            }

            T[] newArray = new T[Count + 1];

            for (int i = 0, j = 0; i < Count; i++, j++)
			{
                if (i == position)
                {
                    newArray[j] = element;
                    j++;
                }

                newArray[j] = this.array[i];
			}

            Count++;
            this.array = newArray;
        }

        public void Clear()
        { 
            this.array = new T[DEFAULT_SIZE];
        }
        //returns required index
        public int FindByValue(T value)
        {
            for (int i = 0; i < Count; i++)
            {
                if (this.array[i].CompareTo(value) == 0)
                {
                    return i;
                }
            }

            return -1;
        }

        public T Max()
        {
            T element = this.array[0];

            foreach (T item in this.array)
            {
                if (element.CompareTo(item) < 0)
                {
                    element = item;
                }
            }

            return element;
        }

        public T Min()
        {
            T element = this.array[0];

            foreach (T item in this.array)
            {
                if (element.CompareTo(item) > 0)
                {
                    element = item;
                }
            }

            return element;
        }

        public override string ToString()
        {
            return String.Join(" ", this.array);
        }

 
    }
}