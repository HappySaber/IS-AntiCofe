using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anticafe
{
    public class OrderManager
    {
        private List<Order> orders;
        public OrderManager()
        {
            orders = new List<Order>();
        }
        public OrderManager(List<Order> orders)
        {
            this.orders = orders;
        }
        public void AddOrder(Order order)
        {
            orders.Add(order);
        }
        public void ReplaceOrder(Order order, int index)
        {
            orders[index] = order;
        }
        public int CountGuests()
        {
            int count = 0;
            foreach (var order in orders)
                count += order.Count_guest;
            return count;
        }
        public void DeleteAllOrder()
        {
            orders.Clear();
        }
        public List<Order> GetListOrder()
        {
            return orders;
        }
        public int GetFreeNumberOrderNow(int count_table)
        {
            int count = 0;
            bool flag = false;
            for (int tab = 1; tab <= count_table; tab++)
            {
                flag = false;
                for (int ord = 0; ord < orders.Count; ord++)
                {
                    if (orders[ord].Number_order == tab)
                        flag = true;
                }
                if (!flag)
                    return tab;
            }
            return count;
        }
        public void DeleteOrderToIndex(int index)
        {
            orders.RemoveAt(index);
        }
    }
}
