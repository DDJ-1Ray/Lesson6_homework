using System;

namespace _8._10
{
    [Serializable]
    public class OrderItem
    {
        public string itemname;
        public int orderitemid;
        public int count;
        public int price;
        public OrderItem(int id)
        {
            orderitemid = id;
        }
        public OrderItem() { }
        public OrderItem(int id, string itemname, int count, int price)
        {
            orderitemid = id;
            this.itemname = itemname;
            this.count = count;
            this.price = price;
        }
        public int OrderItemId
        {
            get => orderitemid;
        }
        public override bool Equals(object obj)
        {
            OrderItem ord = obj as OrderItem;
            return ord != null && ord.OrderItemId == orderitemid;
        }
        public override string ToString()
        {
            return "訂單明細號:" + orderitemid + "貨品名稱:" + itemname + "貨品數目:" + count + "貨品价格";
        }
    }


}
