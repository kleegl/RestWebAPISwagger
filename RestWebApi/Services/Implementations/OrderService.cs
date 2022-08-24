using Repositories.Interfaces;

namespace RestWebApi.Services.Implementations
{
    internal class OrderService
    {
        private readonly IOrderRepository _iOrderRepository;
        public OrderService(IOrderRepository iOrderRepository)
        {
            _iOrderRepository = iOrderRepository;
        }

        public void Test()
        {
            throw new NotImplementedException();
        }
    }
}
