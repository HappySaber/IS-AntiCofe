using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Anticafe
{
    public class MainContr
    {
        private string source;
        private BoardgamesManager boardgameMan;
        private OrderManager orderMan;
        private TableManager tableMan;
        public MainContr(string sources)
        {
            source = sources;
            ContrBD bd = new ContrBD(source);
            bd.LoadFromFile();
            tableMan = new TableManager(bd.tables);
            boardgameMan = new BoardgamesManager(bd.menu);
            orderMan = new OrderManager(bd.order);
        }
        public MainContr()
        {
            tableMan = new TableManager();
            boardgameMan = new BoardgamesManager();
            orderMan = new OrderManager();
        }
        public string Date()
        {
            return DateTime.Now.ToShortDateString();
        }
        public int CountTable()
        {
            return tableMan.CountTable;
        }
        public int CountFreeTable()
        {
            return tableMan.CountFreeTable();
        }
        public int CountOccTable()
        {
            return tableMan.CountOccTable();
        }
        public int CountGuests()
        {
            return orderMan.CountGuests();
        }
        public string FreeTables()
        {
            return tableMan.FreeTables();
        }
        public void AddTable()
        {
            tableMan.AddTable();
        }
        public bool DeleteTable(string number, bool flag)
        {
            if (int.TryParse(number, out int result) == true)
                for (int i = 0; i < GetListOrder().Count; i++)
                    if (GetListOrder()[i].Number_table == result)
                    {
                        if (flag == true)
                            orderMan.DeleteOrderToIndex(i);
                        else
                            return true;
                    }
            tableMan.DeleteTable(number);
            return false;
        }
        public void DeleteOrders()
        {
            tableMan.FreeTable();
            orderMan.DeleteAllOrder();
        }
        public List<Table> GetListTable()
        {
            return tableMan.GetListTable();
        }
        public List<Order> GetListOrder()
        {
            return orderMan.GetListOrder();
        }
        public List<Boardgames> GetListBoardgame()
        {
            return boardgameMan.GetListBoardgame();
        }
        public void EditMenu(List<Boardgames> boardG)
        {
            boardgameMan.UpdateMenu(boardG);
        }
        public void AddOrder(Order order)
        {
            orderMan.AddOrder(order);
            for (int i = 0; i < tableMan.GetListTable().Count; i++)
                if (tableMan.GetListTable()[i].Number == order.Number_table)
                    tableMan.ReplaceTable(new Table(order.Number_table, "occ"), i);

        }
        public void ChangeOrder(Order order, int index)
        {
            orderMan.ReplaceOrder(order, index);
        }
        public string GetOrderToNumberTable(int table)
        {
            for (int order = 0; order < orderMan.GetListOrder().Count; order++)
                if (GetListOrder()[order].Number_table == GetListTable()[table].Number)
                    return GetListOrder()[order].Number_order.ToString();
            return "";
        }
        public int GetFreeNumberOrderNow()
        {
            return orderMan.GetFreeNumberOrderNow(tableMan.CountTable);
        }
        public void DeleteOrder(int index)
        {
            for (int i = 0; i < tableMan.GetListTable().Count; i++)
                if (tableMan.GetListTable()[i].Number == orderMan.GetListOrder()[index].Number_table)
                    tableMan.ReplaceTable(new Table(orderMan.GetListOrder()[index].Number_table, "free"), i);
            orderMan.DeleteOrderToIndex(index);
        }
        public void AddOrder(int index, int count, List<int> count_boardgame)
        {
            List<string> list_boardgame = new List<string>();
            List<int> countDish = new List<int>();
            int result_sum = 0;
            for (int i = 0; i < GetListBoardgame().Count; i++)
                if (count_boardgame[i] != 0)
                {
                    list_boardgame.Add(GetListBoardgame()[i].Name);
                    countDish.Add(count_boardgame[i]);
                    result_sum += count_boardgame[i] * GetListBoardgame()[i].Cost;
                }
            Order order = new Order(GetListTable()[index].Number, GetFreeNumberOrderNow(), count, list_boardgame, countDish, result_sum);
            AddOrder(order);
        }
        public void ChangeOrder(int index, int count, List<int> count_boardgame, int j)
        {
            List<string> list_boardgame = new List<string>();
            List<int> countDish = new List<int>();
            int result_sum = 0;
            for (int i = 0; i < GetListBoardgame().Count; i++)
                if (count_boardgame[i] != 0)
                {
                    list_boardgame.Add(GetListBoardgame()[i].Name);
                    countDish.Add(count_boardgame[i]);
                    result_sum += count_boardgame[i] * GetListBoardgame()[i].Cost;
                }
            Order order = new Order(GetListTable()[index].Number, GetFreeNumberOrderNow(), count, list_boardgame, countDish, result_sum);
            ChangeOrder(order, j);
        }
    }
}
