using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyOfQueue
{
    class Queue<T>
    {
        private List<T> list;
        private int Count { get; set; }

        public Queue()
        { 
            list = new List<T>();
            Count = 0;
        }

        public Queue(Queue<T> obj) //Конструктор копирования
        {
            list = obj.list;
            Count = obj.Count;
        }

        public void Enqueue(T item)
        {
            list.Add(item);
            Count++;
        }

        public void Dequeue()
        {
            if (list.Count > 0)
            {
                list.Remove(list.First());
                Count--;
            }
            else throw new NullReferenceException("Очередь пуста");
        }

        public List<T> GetValue()
        {
            return list;
        }
    }
}
