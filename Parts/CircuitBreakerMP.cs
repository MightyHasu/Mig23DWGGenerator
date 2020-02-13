namespace Mig23DWGGenerator
{
    class CircuitBreakerMP : AbstractPart

    {
        private const string PRE_FIX = "PAP F 01";
        private string _name;


        public CircuitBreakerMP()
        {
            _name = PRE_FIX;
        }

        public override string GetName()
        {
            return _name;
        }
    }
}