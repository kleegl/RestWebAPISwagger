using Models.Implementations;
using Repositories.Interfaces;

namespace Repositories.Implementations
{
    internal class Repository : IRepository
    {
        private readonly ApplicationDbContext _context;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Order> GetOrders()
        {
            return _context.Orders.ToList();
        }
    }
}