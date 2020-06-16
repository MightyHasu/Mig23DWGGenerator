using System;
using System.Collections.Generic;
using System.Text;

namespace Mig23DWGGenerator.Parts
{
    class SingleDoor : AbstractPart

    {
        private const string PRE_FIX_LEFT_DOOR = "VEL";
        private const string PRE_FIX_RIGHT_DOOR = "VED";
        private string _name;
        private int _width;
        //private int _height;

        public SingleDoor(int width, int height, bool isLeft)
        {
            _width = width;
            //_height = height;
            if (isLeft)
            {
                _name = PRE_FIX_LEFT_DOOR + " " + "W"+_width.ToString();
            } else
            {
                _name = PRE_FIX_RIGHT_DOOR + " " + "W" + _width.ToString();
            }            
        }

        public override string GetName()
        {
            return _name;
        }
    }
}
