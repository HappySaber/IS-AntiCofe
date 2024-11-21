using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anticafe
{
    public class BoardgamesManager
    {
        private List<Boardgames> boardgame;
        public BoardgamesManager()
        {
            boardgame = new List<Boardgames>();
        }
        public BoardgamesManager(List<Boardgames> boardgame)
        {
            this.boardgame = boardgame;
        }
        public void AddBoardgame(Boardgames boardG)
        {
            boardgame.Add(boardG);
        }
        public void ReplaceBoardgame(Boardgames boardG, int index)
        {
            boardgame[index] = boardG;
        }
        public List<Boardgames> GetListBoardgame()
        {
            return boardgame;
        }
        public void UpdateMenu(List<Boardgames> boardgame)
        {
            this.boardgame = boardgame;
        }
        public bool SearchBoardgame(Boardgames boardG)
        {
            for (int i = 0; i < boardgame.Count; i++)
            {
                if (boardgame[i].Name == boardG.Name && boardgame[i].Cost == boardG.Cost)
                    return true;
            }
            return false;
        }
    }
}

