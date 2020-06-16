using System;
using System.Collections.Generic;
using System.Text;

namespace Mig23DWGGenerator.Parts
{
    class MPFixer : AbstractPart
    {
        private const string PRE_FIX_MPF = "VMP";
        private string _name;
        private int _width;
        private int _height;

        public MPFixer(int width)
        {
            _width = width;
            
            _name = PRE_FIX_MPF + " " + "W" + _width.ToString();
        }

        public override string GetName()
        {
            return _name;
        }
    }
}
