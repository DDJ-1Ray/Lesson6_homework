
using Microsoft.VisualStudio.TestTools.UnitTesting;

using _8._10;

namespace UnitTestProject6
{
    [TestClass]
    public class OrderServiceTest
    {
        [TestMethod]
        public void AddOrderTest1()
        {
            OrderService orderService = new OrderService(1);
            Order order1 = new Order(1,"1ray");
            Assert.IsTrue(orderService.AddOrder(order1));
        }
        [TestMethod]
        public void AddOrderTest2()
        {
            OrderService orderService = new OrderService(1);
            Order order1 = new Order(1, "1ray");
            Order order2 = new Order(1, "1ray");
            orderService.AddOrder(order1);
            Assert.IsFalse(orderService.AddOrder(order2));
        }
        [TestMethod]
        public void AddOrderTest3()
        {
            OrderService orderService = new OrderService(1);
            Order order1 = null;
            Assert.IsFalse(orderService.AddOrder(order1));
        }
        [TestMethod]
        public void ReMoveOrderTest1()
        {
            OrderService orderService = new OrderService(1);
            Order order1 = new Order(1, "1ray");
            orderService.AddOrder(order1);
            Assert.IsTrue(orderService.ReMoveOrder(order1));
        }
        [TestMethod]
        public void ReMoveOrderTest2()
        {
            OrderService orderService = new OrderService(1);
            Order order1 = new Order(1, "1ray");
            Assert.IsFalse(orderService.ReMoveOrder(order1));
        }
        [TestMethod]
        public void PrintOrderTest1()
        {
            OrderService orderService = new OrderService(1);
            Assert.IsFalse(orderService.PrintOrder());
            //orderService.AddNewOrder(1);
        }
        [TestMethod]
        public void PrintOrderTest2()
        {
            OrderService orderService = new OrderService(1);
            Order order1 = new Order(1, "1ray");
            orderService.AddOrder(order1);
            Assert.IsTrue(orderService.PrintOrder());
            //orderService.AddNewOrder(1);
        }
        [TestMethod]
        public void ReOrderListTest1()
        {
            OrderService orderService = new OrderService(1);
            Order order1 = new Order(1, "1ray");
            Order order2 = new Order(2,"2ray");
            Order order3 = new Order(3, "2ray");
            orderService.AddOrder(order3);
            orderService.AddOrder(order2);
            orderService.AddOrder(order1);
            Order[] result = { order1,order2,order3};
            orderService.ReOrderList_ForTest(1);
            Order[] list = { orderService.orderlist[0], orderService.orderlist[1], orderService.orderlist[2] };
            CollectionAssert.AreEqual(list, result);


        }
        [TestMethod]
        public void ReOrderListTest2()
        {
            OrderService orderService = new OrderService(1);
            Order order1 = new Order(1, "1ray");
            Order order2 = new Order(2, "2ray");
            Order order3 = new Order(3, "2ray");
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.AddOrder(order3);
            Order[] result = { order3, order2, order1 };
            orderService.ReOrderList_ForTest(2);
            Order[] list = { orderService.orderlist[0], orderService.orderlist[1], orderService.orderlist[2] };
            CollectionAssert.AreEqual(list, result);
        }
        [TestMethod]
        public void ReOrderListTest3()
        {
            OrderService orderService = new OrderService(1);
            Order order1 = new Order(1, "1ray");
            Order order2 = new Order(2, "2ray");
            Order order3 = new Order(3, "2ray");
            order1.allprice = 100;
            order2.allprice = 150;
            order3.allprice = 200;
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.AddOrder(order3);
            Order[] result = { order3, order2, order1 };
            orderService.ReOrderList_ForTest(3);
            Order[] list = { orderService.orderlist[0], orderService.orderlist[1], orderService.orderlist[2] };
            CollectionAssert.AreEqual(list, result);
        }
        [TestMethod]
        public void ReOrderListTest4()
        {
            OrderService orderService = new OrderService(1);
            Order order1 = new Order(1, "1ray");
            Order order2 = new Order(2, "2ray");
            Order order3 = new Order(3, "2ray");
            order1.allprice = 100;
            order2.allprice = 150;
            order3.allprice = 200;
            orderService.AddOrder(order3);
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            Order[] result = { order1, order2, order3 };
            orderService.ReOrderList_ForTest(4);
            Order[] list = { orderService.orderlist[0], orderService.orderlist[1], orderService.orderlist[2] };
            CollectionAssert.AreEqual(list, result);
        }
        [TestMethod]
        public void ExportTest1()
        {
            OrderService orderService = new OrderService(1);
            Assert.IsFalse(orderService.Export());
        }
        [TestMethod]
        public void ExportTest2()
        {
            OrderService orderService = new OrderService(1);
            Order order = new Order(1, "1ray");
            orderService.AddOrder(order);
            Assert.IsTrue(orderService.Export());
        }
        [TestMethod]
        public void ImportTest1()
        {
            OrderService orderService = new OrderService(1);
            Order order = new Order(1, "1ray");
            orderService.AddOrder(order);
            orderService.Export();
            Assert.IsTrue(orderService.Import());
        }
        [TestMethod]
        public void ImportTest2()
        {
            OrderService orderService = new OrderService(1);
            Order order = new Order(1, "1ray");
            //orderService.AddOrder(order);
            orderService.Export();
            Assert.IsTrue(orderService.Import());
        }



    }
}
