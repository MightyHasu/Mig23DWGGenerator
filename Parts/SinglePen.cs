namespace Mig23DWGGenerator
{
    class SinglePen : AbstractPart

    {
        private const string PRE_FIX = "PEN100F";
        private string _name;      


        public SinglePen()
        {            
            _name = PRE_FIX;

        }

        public override string GetName()
        {
            return _name;
        }
    }
}