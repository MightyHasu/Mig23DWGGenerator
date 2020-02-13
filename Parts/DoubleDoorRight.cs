using System;
using System.Collections.Generic;
using System.Text;

namespace Mig23DWGGenerator.Parts
{
    class DoubleDoorRight : AbstractPart
    {
        private const string PRE_FIX_LEFT_DOOR = "VDM";
        private string _name;
        private int _width;
        //private int _height;

        public DoubleDoorRight(int width, int height)
        {
            _width = width;
            //_height = height;            
            _name = PRE_FIX_LEFT_DOOR + " " + "W" + _width.ToString();
        }

        public override string GetName()
        {
            return _name;
        }
    }
}
