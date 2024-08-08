using DataAccess.Data;
using DataAccess.Repository.IRepository;

namespace DataAccess.Repository;

public class UnitOfWork : IUnitOfWork
{
    private DataContext _context;
    /*public ICategoryRepository Category { get; private set; }
    public IProductRepository Product { get; set; }
    public ICompanyRepository Company { get; set; }
    public IShoppingCartRepository ShoppingCart { get; set; }
    public IApplicationUserRepository ApplicationUser { get; set; }*/

    public UnitOfWork(DataContext context)
    {
        _context = context;
        /*Category = new CategoryRepository(_context);
        Product = new ProductRepository(_context);
        Company = new CompanyRepository(_context);
        ShoppingCart = new ShoppingCartRepository(_context);
        ApplicationUser = new ApplicationUserRepository(_context);*/
    }

    public void Save()
    {
        _context.SaveChanges();
    }
}

