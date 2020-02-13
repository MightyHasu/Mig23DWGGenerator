﻿namespace Mig23DWGGenerator
{
    class RoofPanel : AbstractPart

    {
        private const string PRE_LEFT = "KL";
        private const string PRE_RIGHT = "KD";
        private const string PRE_MID = "KS";
        private const string PRE_SINGLE = "KE";
        private string _name;
        private int _width;
        private int _depth;


        public RoofPanel(int width, int depth, bool isLeft, bool isRight, bool isMiddle, bool isSingle)
        {
            _width = width;
            _depth = depth;

            if (isLeft)
            {
                _name = PRE_LEFT + " W" + _width.ToString() + " D" + _depth.ToString();
            }
            else if (isRight)
            {
                _name = PRE_RIGHT + " W" + _width.ToString() + " D" + _depth.ToString();
            }
            else if (isMiddle)
            {
                _name = PRE_MID + " W" + _width.ToString() + " D" + _depth.ToString();
            }
            else
            {
                _name = PRE_SINGLE + " W" + _width.ToString() + " D" + _depth.ToString();
            }
        }

        public override string GetName()
        {
            return _name;
        }
    }
}