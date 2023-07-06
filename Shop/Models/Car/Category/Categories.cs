namespace Shop.Model;

public class Categories : ICategories
{
    private readonly Dictionary<CategoryType, Category> _all;

    public Categories()
    {
        _all = new Dictionary<CategoryType, Category>
        {
            {CategoryType.Electric, new Category(0, "Электромобиль", "Современный вид транспорта")},
            {CategoryType.Classic, new Category(0, "Классический", "Мвшина с двигателем внутреннего сгорания")},
        };
    }

    public Category GetCategory(CategoryType type)
    {
        return _all[type];
    }
}