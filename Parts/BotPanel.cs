namespace Mig23DWGGenerator
{
    class BotPanel : AbstractPart

    {
        private const string PRE_BOT_OPENED_BACK = "DOT"; // ДЪНО ЗА ТАБЛО БЕЗ ГРЪБ
        private const string PRE_BOT_CLOSED_BACK = "DZT"; // ДЪНО ЗА ТАБЛО С ГРЪБ       
        private string _name;
        private int _width;
        private int _depth;


        public BotPanel(int width, int depth, bool isOpenedBack)
        {
            _width = width;
            _depth = depth;

            if (isOpenedBack)
            {
                _name = PRE_BOT_OPENED_BACK + " W" + _width.ToString() + " D" + _depth.ToString();
            }
            else
            {
                _name = PRE_BOT_CLOSED_BACK + " W" + _width.ToString() + " D" + _depth.ToString();
            }
        }

        public override string GetName()
        {
            return _name;
        }
    }
}