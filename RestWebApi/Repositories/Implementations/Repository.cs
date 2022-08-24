using Models.Implementations;
using Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Repositories.Implementations
{
    internal class Repository : IRepository
    {
        private readonly ApplicationDbContext _context;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Order>> GetOrders()
        {
            try
            {
                return await _context.Orders.ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<Order> GetOrderById(int orderNumber)
        {
            try
            {
                return await _context.Orders.FirstOrDefaultAsync(o => o.OrderNumber == orderNumber);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            
        }

        public async Task<bool> CreateOrder(Order orderToCreate)
        {
            try
            {
                await _context.Orders.AddAsync(orderToCreate);
                return await _context.SaveChangesAsync() >= 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public async Task<bool> DeleteOrder(int orderNumberToDelete)
        {
            try
            {
                Order findedOrder = GetOrderById(orderNumberToDelete);

                if(findedOrder != null)
                {
                    _context.Orders.Remove(findedOrder);
                    _context.SaveChangesAsync();
                    return true;
                }
                else return false;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public async Task<bool> UpdateOrder(Order orderToUpdate)
        {
            try
            {
                _context.Orders.Update(orderToUpdate);
                await _context.SaveChangesAsync();
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}