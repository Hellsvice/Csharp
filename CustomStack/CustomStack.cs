using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_07_05
{
    // HF: írdd át a CustomStack - ek, úgy, hogy csak char-t lehessen bele tenni -> CustomStackChar
    class CustomStack<T>
    {
        public int Top { get; private set; }

        public int Capacity { get; private set; }

        public int Count
        {
            get
            {
                return this.Top + 1;
            }
        }

        private T[] items;

        public CustomStack(int capacity) 
        {
            this.Capacity = capacity;
            this.Top = -1;
            this.items = new T[capacity];
        }

        // Új elem felvétele
        public void Push(T item)
        {
            // Ha tele van
            if (this.Top == this.Capacity - 1)
            {
                throw new CustomStackFullException("A stack tele van");
            }
            else
            {
                this.items[++Top] = item;
            }
        }

        // Kiolvas egy elemet, de nem törli -> Nem fogjuk használni
        public T Peak()
        {
            // Ha a stack üres
            if(this.Top == -1)
            {
                throw new CustomStackEmptyException("A stack üres");
            }
            else
            {
                return this.items[this.Top];
            }
        }

        // Kiolvas egy elemet, és "törli" a stack-ből -> valójában csak a top indexet állítjuk át
        public T Pop()
        {
            // Ha a stack üres
            if (this.Top == -1)
            {
                throw new CustomStackEmptyException("A stack üres");
            }
            else
            {
                T element = this.items[this.Top];
                this.Top--;
                return element;
            }
        }

        public bool isEmpty()
        {
            //if (this.Top == -1)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return this.Top == -1;
        }
    }
}
