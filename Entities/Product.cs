namespace Entities
{
    public class Product
    {
        private int id;
        private string name;

        public Product(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id
        {
            get => id;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
                else if (id != value)
                {
                    id = value;
                }
            }
        }

        public string Name
        {
            get => name;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }
                else if (name != value)
                {
                    name = value;
                }
            }
        }
    }
}