using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Anticafe
{
    internal partial class ChangeMenu : Form
    {
        private readonly Action<List<Boardgames>> action;
        private readonly List<Boardgames> boardgame;
        private static string[] header = new string[2] { "Наименование игры", "Стоимость" };
        public ChangeMenu(Action<List<Boardgames>> action, List<Boardgames> boardG)
        {
            InitializeComponent();
            this.action = action;
            boardgame = boardG;
            PrintMenu();
        }
        public void PrintMenu()
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add(header[0], header[0].Length);
            listView1.Columns.Add(header[1], header[1].Length);
            listView1.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView1.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView1.Size = new Size(500, 500);
            for (int boardG = 0; boardG < boardgame.Count; boardG++)
            {
                string[] menu = new string[2];
                menu[0] = boardgame[boardG].Name;
                menu[1] = boardgame[boardG].Cost.ToString();
                listView1.Items.Add(new ListViewItem(menu));
            }
        }
        private async void Add_Click(object sender, EventArgs e)
        {
            if ((textBoxAdd_1.Text != "") && (textBoxAdd_2.Text != ""))
            {
                for (int boardG = 0; boardG < boardgame.Count; boardG++)
                    if (boardgame[boardG].Name == textBoxAdd_1.Text)
                    {
                        labelAdd.Text = "Данная игра уже есть";
                        await Task.Delay(1000);
                        labelAdd.Text = "";
                        return;
                    }
                if (int.TryParse(textBoxAdd_2.Text, out int result) == true && result >= 0 )
                {
                    boardgame.Add(new Boardgames(textBoxAdd_1.Text, int.Parse(textBoxAdd_2.Text)));
                    PrintMenu();
                }
                else
                {
                    labelAdd.Text = "Стоимость введена неверно";
                    await Task.Delay(1000);
                    labelAdd.Text = "";
                    return;
                }
            }
        }
        private void ChangeMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            action(boardgame);
            Close();
        }

        private void Delete_Menu_Click(object sender, EventArgs e)
        {
            if (Delete_textBox.Text != "")
                for (int boardG = 0; boardG < boardgame.Count; boardG++)
                    if (boardgame[boardG].Name == Delete_textBox.Text)
                        boardgame.RemoveAt(boardG);
            PrintMenu();
        }

        private async void Change_Menu_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                int index = listView1.SelectedIndices[0];
                if ((textBoxEdit_1.Text != "") && (textBoxEdit_2.Text != ""))
                {
                    if ((int.TryParse(textBoxEdit_2.Text, out int result) == true) && (result >= 0))
                    {
                        boardgame[index].Name = textBoxEdit_1.Text;
                        boardgame[index].Cost = int.Parse(textBoxEdit_2.Text);
                        PrintMenu();
                    }
                    else
                    {
                        labelEdit.Text = "Стоимость введена неверно";
                        await Task.Delay(1000);
                        labelEdit.Text = "";
                        return;
                    }
                }
            }
            else
                MessageBox.Show("Выделите фирму");
        }
    }
}
