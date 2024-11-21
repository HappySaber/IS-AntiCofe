using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anticafe
{
    public class Table
    {
        private int number;
        private string free_occ;

        public Table(int number, string free_occ)
        {
            this.number = number;
            this.free_occ = free_occ;
        }
        public int Number
        {
            set
            {
                number = value;
            }
            get
            {
                return number;
            }
        }
        public string Free_occ
        {
            set
            {
                free_occ = value;
            }
            get
            {
                return free_occ;
            }
        }
    }
}
