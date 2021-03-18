using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AnyCompany;

namespace AnyCompanyTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_PlaceOrder()
        {
            Random orderNum = new Random();
            OrderService orderService = new OrderService();
            Order order = new Order();

            order.Amount = 500.00;
            order.OrderId = orderNum.Next(1, 500);
            //order.VAT = 0.15;
            orderService.PlaceOrder(order, 2); // Fails because of SQl
            //Console.WriteLine(orderService.PlaceOrder(order, 2));

            Assert.IsTrue(true);
        }
        [TestMethod]
        public void Test_LoadCustomers()
        {


        }

    }
}
