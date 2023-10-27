namespace BethanysPieShop.Models
{
    public class CategoryRepository: ICategoryRepository
    {
        private readonly BethanyPieShopDbContext _bethanysPieShopDbContext;

        public CategoryRepository(BethanyPieShopDbContext bethanysPieShopDbContext)
        {
            _bethanysPieShopDbContext = bethanysPieShopDbContext;
        }

        public IEnumerable<Category> AllCategories => _bethanysPieShopDbContext.Categories.OrderBy(p => p.CategoryName);
    }
}
