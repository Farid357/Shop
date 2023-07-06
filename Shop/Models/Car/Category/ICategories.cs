namespace Shop.Model;

public interface ICategories
{
    Category GetCategory(CategoryType type);
}