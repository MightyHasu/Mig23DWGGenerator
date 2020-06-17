using System;
using System.Collections.Generic;
using System.Text;

namespace Mig23DWGGenerator.Parts
{
    class AdditionalVerticalDoorProfile : AbstractPart
    {
        private const string PRE_FIX_ADDITIONAL_VERTICAL_DOOR_PROFILE = "UV H";        
        private string _name;        
        private int _height;

        public AdditionalVerticalDoorProfile(int height)
        {            
            _height = height;           
            _name = PRE_FIX_ADDITIONAL_VERTICAL_DOOR_PROFILE + _height.ToString();                        
        }

        public override string GetName()
        {
            return _name;
        }
    }
}
