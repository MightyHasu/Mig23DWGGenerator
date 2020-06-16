using System;
using System.Collections.Generic;
using System.Text;

namespace Mig23DWGGenerator
{
    class Board
    {
        private List<AbstractPart> _partsList;
        private string _name;
        private int heightIndex;
        private int widthIndex;
        private int depthIndex;
        private int fHeightIndex;
        private int doorIndex;
        private int roofIndex;
        private bool isLOpened;
        private bool isROpened;
        private bool isTopOpened;
        private bool isBackOpened;
        private bool isLMounted;
        private bool isRMounted;
        private bool hasCircuitBreaker;

        public Board(string name, List<AbstractPart> partsList, 
            int heightIndex, int widthIndex, int depthIndex, 
            int fHeightIndex, int doorIndex, int roofIndex, 
            bool isLOpened, bool isROpened, bool isTopOpened, 
            bool isBackOpened, bool isLMounted, bool isRMounted, 
            bool hasCircuitBreaker)
        {
            _name = name;
            _partsList = partsList;
            this.heightIndex = heightIndex;
            this.widthIndex = widthIndex;
            this.depthIndex = depthIndex;
            this.fHeightIndex = fHeightIndex;
            this.doorIndex = doorIndex;
            this.roofIndex = roofIndex;
            this.isLOpened = isLOpened;
            this.isROpened = isROpened;
            this.isTopOpened = isTopOpened;
            this.isBackOpened = isBackOpened;
            this.isLMounted = isLMounted;
            this.isRMounted = isRMounted;
            this.hasCircuitBreaker = hasCircuitBreaker;

        }

        public string GetName()
        {
            return _name;
        }      

        public List<AbstractPart> GetPartsList()
        {
            return _partsList;
        }

        public int GetHeightIndex()
        {
            return heightIndex;
        }

        public int GetWidthIndex()
        {
            return widthIndex;
        }

        public int GetDepthIndex()
        {
            return depthIndex;
        }

        public int GetFHeightIndex()
        {
            return fHeightIndex;
        }

        public int GetDoorIndex()
        {
            return doorIndex;
        }

        public int GetRoofIndex()
        {
            return roofIndex;
        }

        public bool GetIsLOpened()
        {
            return isLOpened;
        }

        public bool GetIsROpened()
        {
            return isROpened;
        }

        public bool GetIsTopOpened()
        {
            return isTopOpened;
        }

        public bool GetIsBackOpened()
        {
            return isBackOpened;
        }

        public bool GetIsLMounted()
        {
            return isLMounted;
        }

        public bool GetIsRMounted()
        {
            return isRMounted;
        }

        public bool GetHasCircuitBreaker()
        {
            return hasCircuitBreaker;
        }
    }
}
