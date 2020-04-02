using System;
using System.Collections.Generic;



namespace _8._10
{
    [Serializable]
    public class Order
    {
        public List<OrderItem> orderitemlist = new List<OrderItem>();
        public int orderid;
        public string clientname;
        public int allprice;
        public int OrderId
        {
            get => orderid;
        }
        public Order() { }
        public Order(int id, string clientname)
        {
            orderid = id;
            allprice = 0;
            this.clientname = clientname;
        }
        public bool AddOrderItem(OrderItem orderItem)
        {
            try
            {
                foreach (OrderItem orditem in orderitemlist)
                {
                    if (orditem.Equals(orderItem))
                    {
                        Console.WriteLine("已有訂單,不能重复增加");
                        return false;
                    }

                }
                orderitemlist.Add(orderItem);
                allprice += orderItem.price;
                return true;

            }
            catch (System.ArrayTypeMismatchException e)
            {
                Console.WriteLine("訂單號:" + OrderId + "的數組越界");
                return false;
            }
        }

        public override bool Equals(object obj)
        {
            Order ord = obj as Order;
            return ord != null && ord.OrderId == orderid;
        }
        public override string ToString()
        {
            string str = "訂單號:" + orderid + "用戶名:" + clientname + "總金額:" + allprice + "\n";
            foreach (OrderItem x in orderitemlist)
            {
                str = str + x.ToString() + "\n";
            }
            return str;
        }
    }
}