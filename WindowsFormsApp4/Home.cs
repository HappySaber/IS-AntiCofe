using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Anticafe
{
    public partial class Home : Form
    {
        MainContr mainContr;
        string count = "";
        ContrBD bd = new ContrBD("D:\\Учёба\\2 курс\\ООП\\курсовая\\WindowsFormsApp4\\WindowsFormsApp4\\BD.xml");
        string[] header = new string[2] { "Номер стола", "Состояние стола" };
        private void Home_Load(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Загружать значения из xml файла?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                mainContr = new MainContr("D:\\Учёба\\2 курс\\ООП\\курсовая\\WindowsFormsApp4\\WindowsFormsApp4\\BD.xml");
            if (dialogResult == DialogResult.No)
                mainContr = new MainContr();
            Date.Text = mainContr.Date();
            countTable1.Text = mainContr.CountTable().ToString();
            countTable2.Text = mainContr.CountFreeTable().ToString();
            countTable3.Text = mainContr.CountOccTable().ToString();
            countTable4.Text = mainContr.CountGuests().ToString();
            PrintTable();
        }
        public Home()
        {
            InitializeComponent();
        }
        public void PrintTable()
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add(header[0], header[0].Length);
            listView1.Columns.Add(header[1], header[1].Length);
            listView1.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView1.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView1.Size = new Size(230, 200);
            for (int table = 0; table < mainContr.CountTable(); table++)
            {
                string[] tables = new string[2];
                tables[0] = mainContr.GetListTable()[table].Number.ToString();
                if (mainContr.GetListTable()[table].Free_occ == "free")
                    tables[1] = "свободен";
                else
                    tables[1] = "занят (номер заказа: " + mainContr.GetOrderToNumberTable(table) + ")";
                listView1.Items.Add(new ListViewItem(tables));
            }
        }
        private void SearchTable_Click(object sender, EventArgs e)
        {
            if (count == "")
            {
                count = mainContr.FreeTables();
                FreeTable.Text = count;
            }
            else if (count == mainContr.FreeTables())
            {
                count = "";
                FreeTable.Text = count;
            }
            else
            {
                count = mainContr.FreeTables();
                FreeTable.Text = count;
            }
        }
        private void AddTable_Click(object sender, EventArgs e)
        {
            mainContr.AddTable();
            countTable1.Text = mainContr.CountTable().ToString();
            countTable2.Text = mainContr.CountFreeTable().ToString();
            PrintTable();
        }
        private void ChangeMenu_Click(object sender, EventArgs e)
        {
            ChangeMenu changeMenu = new ChangeMenu(mainContr.EditMenu, mainContr.GetListBoardgame());
            changeMenu.ShowDialog();
        }
        private void addOrder_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int index = listView1.SelectedIndices[0];
                if (mainContr.GetListTable()[index].Free_occ == "free")
                {
                    AddOrder addOrder = new AddOrder(mainContr.AddOrder, mainContr.GetListTable()[index].Number, mainContr.GetFreeNumberOrderNow(), mainContr.GetListBoardgame());
                    addOrder.ShowDialog();
                }
                else
                    MessageBox.Show("Стол уже имеет заказ, добавление нового заказа невозможно");
            }
            else
                MessageBox.Show("Выделите стол");
            PrintTable();
            countTable2.Text = mainContr.CountFreeTable().ToString();
            countTable3.Text = mainContr.CountOccTable().ToString();
            countTable4.Text = mainContr.CountGuests().ToString();
        }
        private void changeOrder_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int index = listView1.SelectedIndices[0];
                if (mainContr.GetListTable()[index].Free_occ == "occ")
                {
                    for (int i = 0; i < mainContr.GetListOrder().Count; i++)
                        if (mainContr.GetListOrder()[i].Number_table == mainContr.GetListTable()[index].Number)
                        {
                            ChangeOrder changeOrder = new ChangeOrder(mainContr.ChangeOrder, mainContr.GetListOrder()[i], i, mainContr.GetListBoardgame());
                            changeOrder.ShowDialog();
                        }
                }
                else
                    MessageBox.Show("Стол не имеет заказ, изменение заказа невозможно");
            }
            else
                MessageBox.Show("Выделите столик");
            countTable4.Text = mainContr.CountGuests().ToString();
        }

        private void resultOrder_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int index = listView1.SelectedIndices[0];
                if (mainContr.GetListTable()[index].Free_occ == "occ")
                {
                    for (int i = 0; i < mainContr.GetListOrder().Count; i++)
                        if (mainContr.GetListOrder()[i].Number_table == mainContr.GetListTable()[index].Number)
                        {
                            ResultOrder resultOrder = new ResultOrder(mainContr.DeleteOrder, mainContr.GetListOrder()[i], i, mainContr.GetListBoardgame());
                            resultOrder.ShowDialog();
                        }
                }
                else
                    MessageBox.Show("Стол не имеет заказ, изменение заказа невозможно");
            }
            else
                MessageBox.Show("Выделите столик");
            PrintTable();
            countTable2.Text = mainContr.CountFreeTable().ToString();
            countTable3.Text = mainContr.CountOccTable().ToString();
            countTable4.Text = mainContr.CountGuests().ToString();
        }

        private void DeleteTable_Click(object sender, EventArgs e)
        {
            if (mainContr.DeleteTable(Delete_Table.Text, false) == true)
            {
                DialogResult dialogResult = MessageBox.Show("У этого стола есть заказ. Удалить стол вместе с заказом?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    mainContr.DeleteTable(Delete_Table.Text, true);
                }
            }
            countTable1.Text = mainContr.CountTable().ToString();
            countTable2.Text = mainContr.CountFreeTable().ToString();
            countTable3.Text = mainContr.CountOccTable().ToString();
            countTable4.Text = mainContr.CountGuests().ToString();
            PrintTable();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Сохранить изменения в xml файле?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                bd.SaveToFile(mainContr.GetListTable(), mainContr.GetListBoardgame(), mainContr.GetListOrder());
        }

        private async void delete_Order_Click(object sender, EventArgs e)
        {
            mainContr.DeleteOrders();
            check_Do.Text = "Сделано";
            await Task.Delay(1000);
            check_Do.Text = "";
            countTable2.Text = mainContr.CountFreeTable().ToString();
            countTable3.Text = mainContr.CountOccTable().ToString();
            countTable4.Text = mainContr.CountGuests().ToString();
            PrintTable();
        }
    }
}