namespace Mig23DWGGenerator
{
    class FoundDepth : AbstractPart
    {
        private const string PRE_FIX = "RE";
        private string _name;
        private int _foundDepth;
        private int _foundHeight;

        public FoundDepth(int foundDepth, int foundHeight)
        {
            _foundDepth = foundDepth;
            _foundHeight = foundHeight;
            _name = PRE_FIX + " D" + _foundDepth.ToString() + " H" + _foundHeight.ToString();
        }

        public override string GetName()
        {
            return _name;
        }
    }
}