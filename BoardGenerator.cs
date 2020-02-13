using System;
using System.Collections.Generic;
using System.Text;

namespace Mig23DWGGenerator
{
       class BoardGenerator
    {
        private List<Board> _boards;

        public BoardGenerator() 
        {
            _boards = new List<Board>();
        }       

        public List<Board> GetBoards()
        {
            return _boards;
        }

        public void GenerateBaord(String name, List<AbstractPart> parts)
        {
            Board board = new Board(name, parts);
            _boards.Add(board);
        }
    }
}
