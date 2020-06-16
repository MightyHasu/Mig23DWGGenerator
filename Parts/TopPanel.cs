namespace Mig23DWGGenerator
{
    class TopPanel : AbstractPart

    {
        private const string PRE_TOP_OPENED_OPENED_BACK = "TO";
        private const string PRE_TOP_CLOSED_OPENED_BACK = "TZ";
        private const string PRE_TOP_CLOSED_CLOSED_BACK = "TZT";
        private string _name;
        private int _width;
        private int _depth;
        

        public TopPanel(int width, int depth, bool isOpenedBack, bool isTopPanelOpened)
        {
            _width = width;
            _depth = depth;
            
            if (!isTopPanelOpened&&!isOpenedBack)
            {
                _name = PRE_TOP_CLOSED_CLOSED_BACK + " " + "W" + _width.ToString() + " " + "D" + _depth.ToString();
            }
            else if (isTopPanelOpened)
            {
                _name = PRE_TOP_OPENED_OPENED_BACK + " " + "W" + _width.ToString() + " " + "D" + _depth.ToString();
            }
            else
            {
                _name = PRE_TOP_CLOSED_OPENED_BACK + " " + "W" + _width.ToString() + " " + "D" + _depth.ToString();
            }            
        }

        public override string GetName()
        {
            return _name;
        }
    }
}