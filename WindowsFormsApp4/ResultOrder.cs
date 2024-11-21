using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Anticafe
{
    internal partial class ResultOrder : Form
    {
        private readonly Action<int> action;
        private readonly Order order;
        private readonly int index;
        private readonly List<Boardgames> boardgame;
        private static string[] header = new string[3] { "Название игры", "Стоимость","" };

        public ResultOrder(Action<int> action, Order order, int index, List<Boardgames> menu)
        {
            InitializeComponent();
            this.action = action;
            this.order = order;
            this.index = index;
            boardgame = menu;
            PrintMenu();
        }
        public void PrintMenu()
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add(header[0], header[0].Length);
            listView1.Columns.Add(header[1], header[1].Length);
            listView1.Columns.Add(header[2], header[2].Length);
            listView1.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView1.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView1.Columns[2].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView1.Size = new Size(500, 500);
            for (int boardG = 0; boardG < boardgame.Count; boardG++)
            {
                for (int i = 0; i < order.List_boardgame.Count; i++)
                {
                    if (boardgame[boardG].Name == order.List_boardgame[i])
                    {
                        string[] menu = new string[3];
                        menu[0] = boardgame[boardG].Name;
                        menu[1] = boardgame[boardG].Cost.ToString();
                        menu[2] = order.Count_boardgame[i].ToString();
                        listView1.Items.Add(new ListViewItem(menu));
                    }
                }
            }
        }
        private void ResultOrder_Load(object sender, EventArgs e)
        {
            number_order.Text = order.Number_order.ToString();
            number_table.Text = order.Number_table.ToString();
            number_guests.Text = order.Count_guest.ToString();
            result.Text = order.Result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            action(index);
            Close();
        }
    }
}


