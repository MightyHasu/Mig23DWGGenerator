using System;
using System.Collections.Generic;
using System.Text;

namespace Mig23DWGGenerator
{
    class Board
    {
        private List<AbstractPart> _partsList;
        private string _name;
        public Board(string name, List<AbstractPart> partsList)
        {
            SetName(name);
            SetPartsList(partsList);
        }

        public string GetName()
        {
            return _name;
        }

        private void SetName(string name)
        {
            _name = name;
        }

        public List<AbstractPart> GetPartsList()
        {
            return _partsList;
        }

        private void SetPartsList(List<AbstractPart> partsList)
        {
            _partsList = partsList;
        }
    }
}
