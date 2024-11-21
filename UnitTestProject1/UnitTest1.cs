/*using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Reflection;
using Ресторан;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ChangeDish()
        {
            MainContr mainContr = new MainContr();
            List<Dish> dishes = new List<Dish>();
            dishes.Add(new Dish("пюре", 80));
            dishes.Add(new Dish("сок", 40));
            dishes.Add(new Dish("салат", 140));
            mainContr.EditMenu(dishes);
            Assert.AreEqual(3, mainContr.GetListDish().Count);
            Assert.AreEqual(mainContr.GetListDish()[1].Name, "сок");
            Assert.AreEqual(mainContr.GetListDish()[1].Cost, 40);
            dishes[1] = new Dish("вишневый сок", 50);
            mainContr.EditMenu(dishes);
            Assert.AreEqual(3, mainContr.GetListDish().Count);
            Assert.AreEqual(mainContr.GetListDish()[1].Name, "вишневый сок");
            Assert.AreEqual(mainContr.GetListDish()[1].Cost, 50);
            dishes.RemoveAt(1);
            mainContr.EditMenu(dishes);
            Assert.AreEqual(2, mainContr.GetListDish().Count);
            Assert.AreNotEqual(mainContr.GetListDish()[1].Name, "вишневый сок");
            Assert.AreNotEqual(mainContr.GetListDish()[1].Cost, 50);
        }
        [TestMethod]
        public void AddOrder()
        {
            MainContr mainContr = new MainContr();
            List<Dish> dishes = new List<Dish>();
            dishes.Add(new Dish("пюре", 80));
            dishes.Add(new Dish("сок", 40));
            dishes.Add(new Dish("салат", 140));
            mainContr.EditMenu(dishes);
            mainContr.AddTable();
            Assert.AreEqual("free", mainContr.GetListTable()[0].Free_occ);

            int index_table = 0;
            int count_guests = 2;
            List<int> count_dish = new List<int>(dishes.Count) { 0, 1, 2 };
            mainContr.AddOrder(index_table, count_guests, count_dish);

            Assert.AreEqual(1, mainContr.GetListOrder().Count);
            Assert.AreEqual(mainContr.GetListOrder()[0].Count_guest, 2);
            Assert.AreEqual(mainContr.GetListOrder()[0].List_dish[0], "сок");
            Assert.AreEqual(mainContr.GetListOrder()[0].Count_dish[0], 1);
            Assert.AreEqual(mainContr.GetListOrder()[0].Count_dish.Count, mainContr.GetListOrder()[0].List_dish.Count);
            Assert.AreEqual("occ", mainContr.GetListTable()[0].Free_occ);
        }
        [TestMethod]
        public void ChangeOrder()
        {
            MainContr mainContr = new MainContr();
            List<Dish> dishes = new List<Dish>();
            dishes.Add(new Dish("пюре", 80));
            dishes.Add(new Dish("сок", 40));
            dishes.Add(new Dish("салат", 140));
            mainContr.EditMenu(dishes);
            mainContr.AddTable();
            int index_table = 0;
            int count_guests = 2;
            List<int> count_dish = new List<int>(dishes.Count) { 0, 1, 2 };
            mainContr.AddOrder(index_table, count_guests, count_dish);

            count_guests = 3;
            count_dish[1] = 12;
            mainContr.ChangeOrder(index_table, count_guests, count_dish, 0);

            Assert.AreEqual(1, mainContr.GetListOrder().Count);
            Assert.AreEqual(mainContr.GetListOrder()[0].Count_guest, 3);
            Assert.AreEqual(mainContr.GetListOrder()[0].List_dish[0], "сок");
            Assert.AreEqual(mainContr.GetListOrder()[0].Count_dish[0], 12);
        }
        [TestMethod]
        public void DeleteOrder()
        {
            MainContr mainContr = new MainContr();
            List<Dish> dishes = new List<Dish>();
            dishes.Add(new Dish("пюре", 80));
            dishes.Add(new Dish("сок", 40));
            dishes.Add(new Dish("салат", 140));
            mainContr.EditMenu(dishes);
            mainContr.AddTable();
            int index_table = 0;
            int count_guests = 2;
            List<int> count_dish = new List<int>(dishes.Count) { 0, 1, 2 };
            mainContr.AddOrder(index_table, count_guests, count_dish);

            Assert.AreEqual("occ", mainContr.GetListTable()[0].Free_occ);
            mainContr.DeleteOrder(0);

            Assert.AreEqual("free", mainContr.GetListTable()[0].Free_occ);
            Assert.AreEqual(0, mainContr.GetListOrder().Count);
        }
    }
}
*/