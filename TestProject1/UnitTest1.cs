using Anticafe;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MainContr mainContr = new MainContr();
            List<Boardgames> bGames = new List<Boardgames>();
            bGames.Add(new Boardgames("DnD", 80));
            bGames.Add(new Boardgames("Монополия", 40));
            bGames.Add(new Boardgames("Манчкин", 70));
            mainContr.EditMenu(bGames);
            Assert.AreEqual(3, mainContr.GetListBoardgame().Count);
            Assert.AreEqual(mainContr.GetListBoardgame()[1].Name, "Монополия");
            Assert.AreEqual(mainContr.GetListBoardgame()[1].Cost, 40);
            bGames[1] = new Boardgames("Монополия Россия", 50);
            mainContr.EditMenu(bGames);
            Assert.AreEqual(3, mainContr.GetListBoardgame().Count);
            Assert.AreEqual(mainContr.GetListBoardgame()[1].Name, "Монополия Россия");
            Assert.AreEqual(mainContr.GetListBoardgame()[1].Cost, 50);
            bGames.RemoveAt(1);
            mainContr.EditMenu(bGames);
            Assert.AreEqual(2, mainContr.GetListBoardgame().Count);
            Assert.AreNotEqual(mainContr.GetListBoardgame()[1].Name, "Монополия Россия");
            Assert.AreNotEqual(mainContr.GetListBoardgame()[1].Cost, 50);
        }
        [TestMethod]
        public void AddOrder()
        {
            MainContr mainContr = new MainContr();
            List<Boardgames> bGames = new List<Boardgames>();
            bGames.Add(new Boardgames("DnD", 80));
            bGames.Add(new Boardgames("Монополия", 40));
            bGames.Add(new Boardgames("Манчкин", 70));
            mainContr.EditMenu(bGames);
            mainContr.AddTable();
            Assert.AreEqual("free", mainContr.GetListTable()[0].Free_occ);

            

            Assert.AreEqual(1, mainContr.GetListOrder().Count);
            Assert.AreEqual(mainContr.GetListOrder()[0].Count_guest, 2);
            Assert.AreEqual(mainContr.GetListOrder()[0].List_boardgame[0], "Монополия");
            Assert.AreEqual(mainContr.GetListOrder()[0].Count_boardgame[0], 1);
            Assert.AreEqual(mainContr.GetListOrder()[0].Count_boardgame.Count, mainContr.GetListOrder()[0].List_boardgame.Count);
            Assert.AreEqual("occ", mainContr.GetListTable()[0].Free_occ);
        }
        [TestMethod]
        public void ChangeOrder()
        {
            MainContr mainContr = new MainContr();
            List<Boardgames> bGames = new List<Boardgames>();
            bGames.Add(new Boardgames("DnD", 80));
            bGames.Add(new Boardgames("Монополия", 40));
            bGames.Add(new Boardgames("Манчкин", 70));
            mainContr.EditMenu(bGames);
            mainContr.AddTable();
            int index_table = 0;
            int count_guests = 2;
            List<int> count_dish = new List<int>(bGames.Count) { 0, 1, 2 };
            mainContr.AddOrder(index_table, count_guests, count_dish);

            count_guests = 3;
            count_dish[1] = 12;
            mainContr.ChangeOrder(index_table, count_guests, count_dish, 0);

            Assert.AreEqual(1, mainContr.GetListOrder().Count);
            Assert.AreEqual(mainContr.GetListOrder()[0].Count_guest, 3);
            Assert.AreEqual(mainContr.GetListOrder()[0].List_boardgame[0], "Монополия");
            Assert.AreEqual(mainContr.GetListOrder()[0].Count_boardgame[0], 12);
        }
        [TestMethod]
        public void DeleteOrder()
        {
            MainContr mainContr = new MainContr();
            List<Boardgames> bGames = new List<Boardgames>();
            bGames.Add(new Boardgames("DnD", 80));
            bGames.Add(new Boardgames("Монополия", 40));
            bGames.Add(new Boardgames("Манчкин", 70));
            mainContr.EditMenu(bGames);
            mainContr.EditMenu(bGames);
            mainContr.AddTable();
            int index_table = 0;
            int count_guests = 2;
            List<int> count_dish = new List<int>(bGames.Count) { 0, 1, 2 };
            mainContr.AddOrder(index_table, count_guests, count_dish);

            Assert.AreEqual("occ", mainContr.GetListTable()[0].Free_occ);
            mainContr.DeleteOrder(0);

            Assert.AreEqual("free", mainContr.GetListTable()[0].Free_occ);
            Assert.AreEqual(0, mainContr.GetListOrder().Count);
        }
    }

}