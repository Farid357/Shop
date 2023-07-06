namespace Shop.Model
{
    public readonly struct Category
    {
        public Category(int id, string name, string description)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description ?? throw new ArgumentNullException(nameof(description));
        }

        public int Id { get; }

        public string Name { get; }

        public string Description { get; }
    }
}