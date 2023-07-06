namespace Shop.Model;

public interface ICars
{
    ICategories Categories { get; }
        
    IReadOnlyList<Car> All { get; }

    Car GetCar(int id);
}