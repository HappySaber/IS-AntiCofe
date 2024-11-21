using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anticafe
{
    public class Boardgames
    {
        private string name;
        private int cost;
        public Boardgames(string name, int cost)
        {
            this.name = name;
            this.cost = cost;
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public int Cost
        {
            set
            {
                cost = value;
            }
            get
            {
                return cost;
            }
        }
    }
}
