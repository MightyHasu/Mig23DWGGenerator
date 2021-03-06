﻿namespace Mig23DWGGenerator
{
    class RearSidePanel : AbstractPart

    {
        private const string PRE_FIX_OPENED_BACK_WITH_MOUNTING_HOLES = "KZSO"; //КОЛОНА ЗАДНА ЗАТВОРЕНА С ОТВОРИ ЗА ПРИСЪЕДИНЯВАНЕ БЕЗ ГРЪБ
        private const string PRE_FIX_OPENED_BACK_OPENED = "KZO"; //КОЛОНА ЗАДНА ОТВОРЕНА БЕЗ ГРЪБ
        private const string PRE_FIX_OPENED_BACK_CLOSED = "KZZ"; //КОЛОНА ЗАДНА ЗАТВОРЕНА БЕЗ ГРЪБ

        private const string PRE_FIX_CLOSED_BACK_WITH_MOUNTING_HOLES = "KZGSO";  //КОЛОНА ЗАДНА ЗАТВОРЕНА С ОТВОРИ ЗА ПРИСЪЕДИНЯВАНЕ С ГРЪБ      
        private const string PRE_FIX_CLOSED_BACK_OPENED = "KZGO"; //КОЛОНКА ЗАДНА С ГРЪБ ОТВОРЕНА 
        private const string PRE_FIX_CLOSED_BACK_CLOSED = "KZGZ"; //КОЛОНКА ЗАДНА С ГРЪБ ЗАТВОРЕНА БЕЗ ОТВОРИ
        private string _name;
        private int _height;
        private int _depth;
        private int _width;

        public RearSidePanel(int height, int width, int depth, bool hasMountingHoles, bool isSideOpened, bool isBackOpened)
        {
            _height = height;
            _depth = depth;
            _width = width;

            if (isBackOpened)
            {
                if (hasMountingHoles && !isSideOpened)
                {
                    _name = PRE_FIX_OPENED_BACK_WITH_MOUNTING_HOLES + " H" + _height.ToString() + " W" + _width.ToString() + " D"+_depth.ToString();
                }
                else if (isSideOpened)
                {
                    _name = PRE_FIX_OPENED_BACK_OPENED + " H" + _height.ToString() + " W" + _width.ToString() + " D" + _depth.ToString();
                }
                else
                {
                    _name = PRE_FIX_OPENED_BACK_CLOSED + " H" + _height.ToString() + " W" + _width.ToString() + " D" + _depth.ToString();
                }
            }
            else
            {
                if (hasMountingHoles && !isSideOpened)
                {
                    _name = PRE_FIX_CLOSED_BACK_WITH_MOUNTING_HOLES + " H" + _height.ToString() + " W" + _width.ToString() + " D" + _depth.ToString();
                }
                else if (isSideOpened)
                {
                    _name = PRE_FIX_CLOSED_BACK_OPENED + " H" + _height.ToString() + " W" + _width.ToString() + " D" + _depth.ToString();
                }
                else
                {
                    _name = PRE_FIX_CLOSED_BACK_CLOSED + " H" + _height.ToString() + " W" + _width.ToString() + " D" + _depth.ToString();
                }
            }
        }

        public override string GetName()
        {
            return _name;
        }
    }
}