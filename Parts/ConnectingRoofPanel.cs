namespace Mig23DWGGenerator
{
    class ConnectingRoofPanel : AbstractPart

    {
        private const string PRE_FIX = "KP";       
        private string _name;        
        private int _depth;


        public ConnectingRoofPanel(int depth)
        {           
            _depth = depth;            
            _name = PRE_FIX + " D" + _depth.ToString();
           
        }

        public override string GetName()
        {
            return _name;
        }
    }
}