using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<User>();

            while (true)
            {
                Console.WriteLine("1 - Crate Queue");
                Console.WriteLine("2 - Display Queue");
                Console.WriteLine("3 - Sort queue by user age");
                Console.WriteLine("4 - Sort queue by user name");
                Console.WriteLine("5 - Add user to queue");
                Console.WriteLine("6 - Get user from queue");
                Console.WriteLine("7 - Exit");

                var line = int.Parse(Console.ReadLine());

                switch (line)
                {
                    case 1:
                        queue = GenerateRandomQueue(5);
                        break;
                    case 2:
                        queue.Print(Console.WriteLine);
                        break;
                    case 3:
                        queue.Sort(x => x.Age);
                        break;
                    case 4:
                        queue.Sort(x => x.Name);
                        break;
                    case 5:
                        Console.WriteLine("Input user name");
                        var userName = Console.ReadLine();

                        Console.WriteLine("Input user age");
                        var age = int.Parse(Console.ReadLine());

                        queue.Enqueue(new User
                        {
                            Age = age,
                            Name = userName
                        });

                        break;
                    case 6:
                        queue.Dequeue();
                        break;
                    case 7:
                        return;
                }
            }
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
