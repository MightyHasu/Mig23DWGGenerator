namespace Mig23DWGGenerator
{
    class FrontSidePanel : AbstractPart

    {
        private const string PRE_FIX_WITH_HOLES = "KCHO";
        private const string PRE_FIX_WITHOUT_HOLES = "KCHZ";
        private string _name;        
        private int _height;

        public FrontSidePanel(int height, bool hasMountingHoles)
        {            
            _height = height;
            if (hasMountingHoles)
            {
                _name = PRE_FIX_WITH_HOLES + " " + "H" + _height.ToString();
            }

            _name = PRE_FIX_WITHOUT_HOLES + " " + "H" + _height.ToString();
        }

        public override string GetName()
        {
            return _name;
        }
    }
}