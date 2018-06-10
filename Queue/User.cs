namespace Queue
{
    public class User
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"User name - {Name}, Age - {Age}";
        }
    }
}
