namespace Mig23DWGGenerator
{
    class FoundFixer : AbstractPart

    {
        private const string PRE_FIX = "RAZ";
        private string _name;
        private int _depth;


        public FoundFixer(int depth)
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