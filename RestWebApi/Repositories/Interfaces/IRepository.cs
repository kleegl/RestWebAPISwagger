using Models.Implementations;

namespace Repositories.Interfaces
{
    internal interface IRepository
    {
        public List<Order> GetOrders();

    }
}