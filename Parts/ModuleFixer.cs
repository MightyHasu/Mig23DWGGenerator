namespace Mig23DWGGenerator
{
    class ModuleFixer : AbstractPart

    {
        private const string PRE_FIX = "PM F 01";
        private string _name;


        public ModuleFixer()
        {
            _name = PRE_FIX;

        }

        public override string GetName()
        {
            return _name;
        }
    }
}