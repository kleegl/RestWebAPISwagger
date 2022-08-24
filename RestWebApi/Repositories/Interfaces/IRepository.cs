using Models.Implementations;

namespace Repositories.Interfaces
{
    internal interface IRepository
    {
        public Task<List<Order>> GetOrders();
        
        public Task<Order> GetOrderById(int orderNumber);

        public Task<bool> CreateOrder(Order orderToCreate);

        public Task<bool> UpdateOrder(Order orderToUpdate);

        public Task<bool> DeleteOrder(int orderNumberToDelete);

    }
}