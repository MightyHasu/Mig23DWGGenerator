using System;
using System.Collections.Generic;
using System.Text;

namespace Mig23DWGGenerator.Parts
{
    class FoundWidth : AbstractPart
    {
        private const string PRE_FIX = "RE";
        private string _name;
        private int _width;
        private int _height;

        public FoundWidth(int width, int height)
        {
            _width = width;
            _height = height;
            _name = PRE_FIX + " W" + _width.ToString() + " H" + _height.ToString();
        }

        public override string GetName()
        {
            return _name;
        }
    }
}
