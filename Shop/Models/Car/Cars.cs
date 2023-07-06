namespace Shop.Model;

public class Cars : ICars
{
    private readonly List<Car> _all;
        
    public Cars(ICategories categories)
    {
        Categories = categories;
        Category category = categories.GetCategory(CategoryType.Electric);
            
        _all = new List<Car>
        {
            new Car(0, "Tesla", string.Empty, string.Empty, "https://github.com/Farid357/Shop/blob/main/Shop/wwwroot/Images/Tesla.png", category, 45000),
            new Car(0, "Mercedes", string.Empty, string.Empty, "https://github.com/Farid357/Shop/blob/main/Shop/wwwroot/Images/Mercedes.png", category, 30000),
        };
    }

    public ICategories Categories { get; }
      
    public IReadOnlyList<Car> All => _all;

    public Car GetCar(int id)
    {
        return _all.First(car => car.Id == id);
    }
}