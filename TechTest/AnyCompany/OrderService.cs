using System;
using System.Text.RegularExpressions;

namespace AnyCompany
{
    public class OrderService
    {
        private readonly OrderRepository orderRepository = new OrderRepository();

        public bool PlaceOrder(Order order, int customerId)
        {
            Customer customer = CustomerRepository.Load(customerId);

            if (order.Amount == 0)
                return false;

            if (customer.Country == "UK")
                order.VAT = 0.2d;
            else
                order.VAT = 0;

            orderRepository.Save(order);

            return true;
        }
    }
    public class OrderServiceWrapper
    {
        public OrderService orderService;

        public OrderServiceWrapper()
        {
            orderService = new OrderService();
        
            return;
        }

    }
}
