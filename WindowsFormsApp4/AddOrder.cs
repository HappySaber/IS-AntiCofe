using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anticafe
{
    internal partial class AddOrder : Form
    {
        private readonly Action<Order> action;
        private readonly int number_table;
        private readonly int number_order;
        private readonly List<Boardgames> menu;
        public AddOrder(Action<Order> action, int number_table, int number_order, List<Boardgames> menu)
        {
            InitializeComponent();
            this.action = action;
            this.number_table = number_table;
            this.number_order = number_order;
            this.menu = menu;

            for (int i = 0; i < menu.Count; i++)
            {
                Component1 formComp = new Component1(i + 1, menu[i].Name, menu[i].Cost.ToString(), 0);
                formComp.addPanelInForm(this);
            }
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            numberOrder.Text = number_order.ToString();
            numberTable.Text = number_table.ToString();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {

                if ((int.TryParse(textBox1.Text, out int result) == true) && (result > 1))
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

                            if (int.TryParse(((MaskedTextBox)collP[0]).ValidateText().ToString(), out int res) == true && (res > 0 && res==1))
                            {
                                
                                list_boardgame.Add(menu[i].Name);
                                count_boardgame.Add(int.Parse(((MaskedTextBox)collP[0]).ValidateText().ToString()));
                                result_sum += int.Parse(((MaskedTextBox)collP[0]).ValidateText().ToString()) * menu[i].Cost;
                                i++;
                            }
                            else if (res != 0)
                            {
                                MessageBox.Show("Компания не может одновременно взять столько игр одного типа");
                                return;
                            }
                        }
                    }
                    if (result_sum != 0)
                    {
                        Order order = new Order(number_order, number_table, count_guest, list_boardgame, count_boardgame, result_sum);
                        action(order);
                        Close();
                    }
                    else 
                        MessageBox.Show("В заказ не добавлено ни одной игры"); 
                }
                else
                    MessageBox.Show("Неправильно введено количество гостей, ты не можешь играть один");  
            }
            else
                MessageBox.Show("Введите количество гостей");
        }
    }
}

