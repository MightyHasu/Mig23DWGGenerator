namespace Mig23DWGGenerator
{
    class FoundCap : AbstractPart

    {
        private const string PRE_FIX = "RE KAPACHKA";
        private string _name;
        private int _depth;


        public FoundCap(int depth)
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