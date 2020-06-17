using System;
using System.Collections.Generic;
using System.Text;

namespace Mig23DWGGenerator.Parts
{
    class AdditionalHorizontalDoorProfile : AbstractPart
    {
        private const string PRE_FIX_ADDITIONAL_HORIZONTAL_DOOR_PROFILE = "UV W";
        private string _name;
        private int _width;

        public AdditionalHorizontalDoorProfile(int width)
        {
            
            _width = width;
            _name = PRE_FIX_ADDITIONAL_HORIZONTAL_DOOR_PROFILE + _width.ToString();       
           
        }

        public override string GetName()
        {
            return _name;
        }
    }
}
