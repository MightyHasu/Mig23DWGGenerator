namespace Mig23DWGGenerator
{
    class RoofFixer : AbstractPart

    {
        private const string PRE_FIX = "RM";
        private string _name;
        private int _depth;


        public RoofFixer(int depth)
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