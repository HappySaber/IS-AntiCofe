using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml;

namespace Anticafe
{
    internal class ContrBD
    {
        private string source;
        public List<Table> tables = new List<Table>();
        public List<Boardgames> menu = new List<Boardgames>();
        public List<Order> order = new List<Order>();
        public ContrBD(string sources)
        {
            source = sources;
        }
        public void LoadFromFile()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(source);
            XmlElement root = doc.DocumentElement;
            foreach (XmlNode TablesNode in root.ChildNodes[0].ChildNodes[0])
            {
                int i = int.Parse(TablesNode.Attributes.GetNamedItem("number").Value);
                string free_occ = TablesNode.ChildNodes[0].InnerText;
                Table table = new Table(i, free_occ);
                tables.Add(table);
            }
            foreach (XmlNode MenuNode in root.ChildNodes[1].ChildNodes[0])
            {
                string i = MenuNode.Attributes.GetNamedItem("name").Value;
                int cost = int.Parse(MenuNode.ChildNodes[0].InnerText);
                Boardgames boardG = new Boardgames(i, cost);
                menu.Add(boardG);
            }
            int number_order = 0;
            foreach (XmlNode OrderNode in root.ChildNodes[2].ChildNodes[0])
            {
                int i = ++number_order;
                if (i > tables.Count)
                    break;
                int number_table = int.Parse(OrderNode.ChildNodes[0].InnerText);
                int count_guest = int.Parse(OrderNode.ChildNodes[1].InnerText);
                List<string> list_boardgame = new List<string>();
                foreach (XmlNode dishNode in OrderNode.ChildNodes[2])
                    list_boardgame.Add(dishNode.InnerText);
                List<int> count_boardgame = new List<int>();
                foreach (XmlNode countNode in OrderNode.ChildNodes[3])
                    count_boardgame.Add(Int32.Parse(countNode.InnerText));
                int result = Int32.Parse(OrderNode.ChildNodes[4].InnerText);
                Order orders = new Order(i, number_table, count_guest, list_boardgame, count_boardgame, result);
                order.Add(orders);
            }
            checkEnter();
        }
        public void SaveToFile(List<Table> t, List<Boardgames> m, List<Order> o)
        {
            tables = t;
            menu = m;
            order = o;
            XmlDocument doc = new XmlDocument();
            doc.Load(source);
            for (int table_or_menu_order = 0; table_or_menu_order < 3; table_or_menu_order++)
            {
                XmlNode root = doc.DocumentElement.ChildNodes[table_or_menu_order];
                string node = root.ChildNodes[0].Name;
                root.RemoveChild(root.ChildNodes[0]);
                XmlNode nodesNode = doc.CreateElement(node);
                root.AppendChild(nodesNode);
                if (table_or_menu_order == 0)
                    foreach (Table table in tables)
                    {
                        XmlElement nodeNode = doc.CreateElement(node);
                        nodesNode.AppendChild(nodeNode);
                        XmlAttribute attr = doc.CreateAttribute("number");
                        attr.Value = table.Number.ToString();
                        nodeNode.SetAttributeNode(attr);
                        XmlNode free_occNode = doc.CreateElement("free_occ");
                        nodeNode.AppendChild(free_occNode);
                        nodeNode.ChildNodes[0].InnerText = table.Free_occ;
                    }
                else if (table_or_menu_order == 1)
                    foreach (Boardgames boardG in menu)
                    {
                        XmlElement nodeNode = doc.CreateElement(node);
                        nodesNode.AppendChild(nodeNode);
                        XmlAttribute attr = doc.CreateAttribute("name");
                        nodeNode.SetAttributeNode(attr);
                        attr.Value = boardG.Name;
                        XmlNode costNode = doc.CreateElement("cost");
                        nodeNode.AppendChild(costNode);
                        nodeNode.ChildNodes[0].InnerText = boardG.Cost.ToString();
                    }
                else if (table_or_menu_order == 2)
                    foreach (Order ord in order)
                    {
                        XmlElement nodeNode = doc.CreateElement(node);
                        nodesNode.AppendChild(nodeNode);
                        XmlAttribute attr = doc.CreateAttribute("number");
                        attr.Value = ord.Number_order.ToString();
                        nodeNode.SetAttributeNode(attr);
                        XmlNode number_tableNode = doc.CreateElement("number_table");
                        nodeNode.AppendChild(number_tableNode);
                        nodeNode.ChildNodes[0].InnerText = ord.Number_table.ToString();
                        XmlNode count_guestNode = doc.CreateElement("count_guest");
                        nodeNode.AppendChild(count_guestNode);
                        nodeNode.ChildNodes[1].InnerText = ord.Count_guest.ToString();

                        XmlElement list_boardgameNode = doc.CreateElement("array");
                        nodeNode.AppendChild(list_boardgameNode);
                        attr = doc.CreateAttribute("name");
                        attr.Value = "list_boardgame";
                        list_boardgameNode.SetAttributeNode(attr);
                        for (int i = 0; i < ord.List_boardgame.Count; i++)
                        {
                            XmlNode itemNode = doc.CreateElement("item");
                            list_boardgameNode.AppendChild(itemNode);
                            list_boardgameNode.ChildNodes[i].InnerText = ord.List_boardgame[i];
                        }

                        XmlElement count_boardgameNode = doc.CreateElement("array");
                        nodeNode.AppendChild(count_boardgameNode);
                        attr = doc.CreateAttribute("name");
                        attr.Value = "count_boardgame";
                        count_boardgameNode.SetAttributeNode(attr);
                        for (int i = 0; i < ord.Count_boardgame.Count; i++)
                        {
                            XmlNode itemNode = doc.CreateElement("item");
                            count_boardgameNode.AppendChild(itemNode);
                            count_boardgameNode.ChildNodes[i].InnerText = ord.Count_boardgame[i].ToString();
                        }
                        XmlNode resultNode = doc.CreateElement("result");
                        nodeNode.AppendChild(resultNode);
                        nodeNode.ChildNodes[4].InnerText = ord.Result.ToString();
                    }
            }
            doc.Save(source);
        }
        public void checkEnter()
        {
            bool flag_num_table = false;
            for (int i = 0; i < tables.Count; i++)
                tables[i].Free_occ = "free";
            for (int ord = 0; ord < order.Count; ord++)
            {
                for (int tab = 0; tab < tables.Count; tab++)
                    if (order[ord].Number_table == tables[tab].Number)
                    {
                        flag_num_table = true;
                        tables[tab].Free_occ = "occ";
                        break;
                    }
                if (!flag_num_table)
                    for (int t = 0; t < tables.Count; t++)
                        if (tables[t].Free_occ == "free")
                        {
                            order[ord].Number_table = tables[t].Number;
                            if (tables[t].Free_occ == "free")
                                tables[t].Free_occ = "occ";
                            break;
                        }
                flag_num_table = false;
                order[ord].Result = 0;
                if (order[ord].List_boardgame.Count != order[ord].Count_boardgame.Count)
                    if (order[ord].List_boardgame.Count > order[ord].Count_boardgame.Count)
                    {
                        int x = order[ord].List_boardgame.Count - order[ord].Count_boardgame.Count;
                        for (int i = 0; i < x; i++)
                            order[ord].Count_boardgame.Add(1);
                    }
                    else
                    {
                        int x = order[ord].Count_boardgame.Count - order[ord].List_boardgame.Count;
                        for (int i = 0; i < x; i++)
                            order[ord].Count_boardgame.RemoveAt(order[ord].Count_boardgame.Count - 1);
                    }
                for (int d = 0; d < order[ord].List_boardgame.Count; d++)
                {
                    for (int boardG = 0; boardG < menu.Count; boardG++)

                        if (order[ord].List_boardgame[d] == menu[boardG].Name)
                        {
                            flag_num_table = true;
                            order[ord].Result += order[ord].Count_boardgame[d] * menu[boardG].Cost;
                            break;
                        }
                    if (!flag_num_table)
                    {
                        order[ord].List_boardgame[d] = menu[0].Name;
                        order[ord].Result += order[ord].Count_boardgame[d] * menu[0].Cost;
                    }
                }
            }
        }
    }
}
