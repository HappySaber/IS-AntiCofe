using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anticafe
{
    public class Order
    {
        private int number_order;
        private int number_table;
        private int count_guest;
        private List<string> list_boardgame;
        private List<int> count_boardgame;
        private int result;
        public Order(int number_order, int number_table, int count_guest, List<string> list_boardgame, List<int> count_boardgame, int result)
        {
            this.number_order = number_order;
            this.number_table = number_table;
            this.count_guest = count_guest;
            this.list_boardgame = list_boardgame;
            this.count_boardgame = count_boardgame;
            this.result = result;
        }
        public int Number_order
        {
            set
            {
                number_order = value;
            }
            get
            {
                return number_order;
            }
        }
        public int Number_table
        {
            set
            {
                number_table = value;
            }
            get
            {
                return number_table;
            }
        }
        public int Count_guest
        {
            set
            {
                count_guest = value;
            }
            get
            {
                return count_guest;
            }
        }
        public List<string> List_boardgame
        {
            set
            {
                list_boardgame = value;
            }
            get
            {
                return list_boardgame;
            }
        }
        public List<int> Count_boardgame
        {
            set
            {
                count_boardgame = value;
            }
            get
            {
                return count_boardgame;
            }
        }
        public int Result
        {
            set
            {
                result = value;
            }
            get
            {
                return result;
            }
        }
    }
}
