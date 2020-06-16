namespace Mig23DWGGenerator
{
    internal class DoubleDoorLeft : AbstractPart
    {
        private const string PRE_FIX_LEFT_DOOR = "VLJ";        
        private string _name;
        private int _width;
        private int _height;

        public DoubleDoorLeft(int width, int height)
        {
            _width = width;
            _height = height;            
            _name = PRE_FIX_LEFT_DOOR + " W" + _width.ToString() + " H" + _height.ToString();
        }

        public override string GetName()
        {
            return _name;
        }
    }
}