using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = GenerateRandomQueue(10);

            queue.Print(Console.WriteLine);

            queue.Sort(x => x.Age);

            Console.WriteLine("After sorting");

            queue.Print(Console.WriteLine);
        }

        public static Queue<User> GenerateRandomQueue(int size)
        {
            var queue = new Queue<User>();
            var rand = new Random();

            for (var i = 0; i < size; i++)
            {
                queue.Enqueue(new User
                {
                    Name = $"User {i + 1}",
                    Age = rand.Next(18, 50)
                });   
            }

            return queue;
        }

        public static Queue<User> GetTestQueue()
        {
            var queue = new Queue<User>();

            queue.Enqueue(new User { Age = 32});
            queue.Enqueue(new User { Age = 48});
            queue.Enqueue(new User { Age = 43});
            queue.Enqueue(new User { Age = 23});
            queue.Enqueue(new User { Age = 46});

            return queue;
        }
    }
}
