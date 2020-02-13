using System;
using System.Collections.Generic;
using System.Text;

namespace Mig23DWGGenerator
{
    class Order
    {
        private string _name;
        private List<Board> _boards;

        public Order(string name, List<Board> boards)
        {
            SetName(name);
            SetBoards(boards);
        }

        private void SetBoards(List<Board> boards)
        {
            _boards = boards;
        }

        private void SetName(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public List<Board> GetBoards()
        {
            return _boards;
        }
    }
}
