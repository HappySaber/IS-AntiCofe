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
    internal partial class ChangeOrder : Form
    {
        private readonly Action<Order, int> action;
        private readonly Order order;
        private readonly int index;
        private readonly List<Boardgames> menu;
        public ChangeOrder(Action<Order, int> action, Order order, int index, List<Boardgames> menu)
        {
            InitializeComponent();
            this.action = action;
            this.order = order;
            this.index = index;
            this.menu = menu;
            Component1 formComp;
            for (int i = 0; i < menu.Count; i++)
            {
                for (int j = 0; j < order.List_boardgame.Count; j++)
                    if (menu[i].Name == order.List_boardgame[j])
                    {
                        formComp = new Component1(i + 1, menu[i].Name, menu[i].Cost.ToString(), order.Count_boardgame[j]);
                        formComp.addPanelInForm(this);
                    }
                formComp = new Component1(i + 1, menu[i].Name, menu[i].Cost.ToString(), 0);
                formComp.addPanelInForm(this);
            }
        }
        private void ChangeOrder_Load(object sender, EventArgs e)
        {
            number_order.Text = order.Number_order.ToString();
            number_table.Text = order.Number_table.ToString();
            maskedTextBox1.Text = order.Count_guest.ToString();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {
                if ((int.TryParse(maskedTextBox1.Text, out int result) == true) && (result > 0))
                {
                    int count_guest = result;

                    List<string> list_boardgame = new List<string>();
                    List<int> count_boardgame = new List<int>();
                    int result_sum = 0;
                    Control.ControlCollection coll = Controls;
                    int i = 0;
                    foreach (Control item in coll)
                    {
                        if (item.GetType() == typeof(Panel))
                        {
                            Control.ControlCollection collP = item.Controls;
                            if (int.TryParse(((MaskedTextBox)collP[0]).ValidateText().ToString(), out int res) == true && res > 0 && res == 1)
                            {
                                list_boardgame.Add(menu[i].Name);
                                count_boardgame.Add(int.Parse(((MaskedTextBox)collP[0]).ValidateText().ToString()));
                                result_sum += int.Parse(((MaskedTextBox)collP[0]).ValidateText().ToString()) * menu[i].Cost;
                                i++;
                            }
                            else if (res != 0)
                            {
                                MessageBox.Show("Количество введено неверно");
                                return;
                            }
                        }
                    }
                    if (result_sum != 0)
                    {
                        Order change_order = new Order(order.Number_order, order.Number_table, count_guest, list_boardgame, count_boardgame, result_sum);
                        action(change_order, index);
                        Close();
                    }
                    else 
                        MessageBox.Show("В заказ не добавлено ни одной игры");
                }
                else
                    MessageBox.Show("Неправильно введено количество гостей");
            }
            else
                MessageBox.Show("Введите количество гостей");
        }
    }
}

