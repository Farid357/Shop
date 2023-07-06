namespace Shop.Model
{
    public class Car
    {
        public Car(int id, string name, string shortDescription, string longDescription, string icon, Category category, int price)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            ShortDescription = shortDescription ?? throw new ArgumentNullException(nameof(shortDescription));
            LongDescription = longDescription ?? throw new ArgumentNullException(nameof(longDescription));
            Icon = icon ?? throw new ArgumentNullException(nameof(icon));
            Category = category;
            Price = price;
        }

        public int Id { get; }

        public string Name { get; }

        public string ShortDescription { get; }

        public string LongDescription { get; }

        public string Icon { get; }

        public Category Category { get; }

        public int Price { get; }
    }
}