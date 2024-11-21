using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anticafe
{
    public class TableManager
    {
        private List<Table> tables;
        public TableManager()
        {
            tables = new List<Table>();
        }
        public TableManager(List<Table> tables)
        {
            this.tables = tables;
        }
        public void ReplaceTable(Table table, int index)
        {
            tables[index] = table;
        }
        public int CountTable
        {
            get
            {
                return tables.Count;
            }
        }
        public int CountFreeTable()
        {
            int count = 0;
            foreach (var table in tables)
                if (table.Free_occ == "free")
                    count++;
            return count;
        }
        public int CountOccTable()
        {
            int count = 0;
            foreach (var table in tables)
                if (table.Free_occ == "occ")
                    count++;
            return count;
        }
        public string FreeTables()
        {
            string count = "";
            foreach (var table in tables)
                if (table.Free_occ == "free")
                    count += table.Number + " ";
            return count;
        }
        public void AddTable()
        {
            if (tables.Count != 0)
                tables.Add(new Table(tables.Last().Number + 1, "free"));
            else
                tables.Add(new Table(1, "free"));
        }
        public void DeleteTable(string number)
        {
            if (int.TryParse(number, out int result) == true)
                for (int table = 0; table < tables.Count; table++)
                    if (tables[table].Number == int.Parse(number))
                        tables.Remove(tables[table]);
        }
        public void FreeTable()
        {
            for (int table = 0; table < tables.Count; table++)
                tables[table].Free_occ = "free";
        }
        public List<Table> GetListTable()
        {
            return tables;
        }
    }
}
