using System;

namespace CopyOfQueue
{
    class Program
    {
        static void Main()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            foreach (int item in queue.GetValue())
            {
                Console.WriteLine(item);
            }

            queue.Dequeue();

            Console.WriteLine();

            foreach (int item in queue.GetValue())
            {
                Console.WriteLine(item);
            }

            var copy = new Queue<int>(queue);

            Console.WriteLine();

            foreach (int item in copy.GetValue())
            {
                Console.WriteLine(item);
            }
        }
    }
}
