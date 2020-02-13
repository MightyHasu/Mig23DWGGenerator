using Mig23DWGGenerator.Parts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mig23DWGGenerator
{
    class PartGenerator
    {
        private SingleDoor sd;        
        private DoubleDoorLeft ddl;
        private DoubleDoorRight ddr;
        private TopPanel topPanel;
        private BotPanel botPanel;
        private RoofPanel roofPanel;
        private ConnectingRoofPanel connectingRoofPanel;
        private RoofFixer roofFixer;
        private FoundWidth foundWidth;
        private FoundDepth foundDepth;
        private FoundFixer foundFixer;
        //private FoundCap foundCap;
        private SinglePen singlePen;
        private ModuleFixer moduleFixer;
        private FrontSidePanel frontSidePanel;
        private RearSidePanel rearSidePanel;
        private CircuitBreakerMP circuitBreakerMP;

        public PartGenerator() { }
        
        public List<AbstractPart> GenerateParts(int height, int width, int depth, bool isLeftSingleDoor, bool isRightSingleDoor, 
            bool isDoubleDoor, int foundHeight, bool isSingleRoof,
            bool isLeftRoof, bool isRightRoof, bool isMiddleRoof, bool isBackOpened, bool isLeftPanelOpened, bool isRightPanelOpened, 
            bool isMountedLeft, bool isMountedRight, bool isTopOpened, bool hasCircuitBreaker)
        {            
            List<AbstractPart> parts = new List<AbstractPart>();

            //ЧЕЛНА КОЛОНА ЛЯВА            
            frontSidePanel = new FrontSidePanel(height, isMountedLeft);
            parts.Add(frontSidePanel);            

            //ЧЕЛНА КОЛОНА ДЯСНА                      
            frontSidePanel = new FrontSidePanel(height, isMountedRight);
            parts.Add(frontSidePanel);
            

            //КОЛОНА ЗАДНА ЛЯВА           
            rearSidePanel = new RearSidePanel(height, depth, isMountedLeft, isLeftPanelOpened, isBackOpened);
            parts.Add(rearSidePanel);

            //КОЛОНА ЗАДНА ДЯСНА
            rearSidePanel = new RearSidePanel(height, depth, isMountedRight, isRightPanelOpened, isBackOpened);          
           

            //РАЗПЪНКА, ПЕН ЕДИНИЧНА ЗА ШИНИ, ПЛАНКА МОДУЛИ
            for (int i = 0; i < 2; i++)
            {
                foundFixer = new FoundFixer(depth);
                singlePen = new SinglePen();
                moduleFixer = new ModuleFixer();

                parts.Add(foundFixer);
                parts.Add(singlePen);
                parts.Add(moduleFixer);
            }

            //ОСНОВА
            if (foundHeight>0)
            {
                foundWidth = new FoundWidth(width, foundHeight);
                foundDepth = new FoundDepth(depth, foundHeight);
                parts.Add(foundDepth);
                parts.Add(foundWidth);
            }

            //ВРАТИ
            if (isLeftSingleDoor||isRightSingleDoor)
            {
                sd = new SingleDoor(width, height, isLeftSingleDoor);
                parts.Add(sd);
            } 
            else
            {
                ddl = new DoubleDoorLeft(width, height);
                ddr = new DoubleDoorRight(width, height);
                parts.Add(ddl);
                parts.Add(ddr);
            }

            //ПЛАНКА АПАРАТУРА ШРАК 250А
            if (hasCircuitBreaker)
            {
                circuitBreakerMP = new CircuitBreakerMP();
                parts.Add(circuitBreakerMP);
            }

            //ТАВАН
            topPanel = new TopPanel(width, depth, isBackOpened, isTopOpened);
            parts.Add(topPanel);

            //ПОКРИВ
            if (isSingleRoof||isLeftRoof||isRightRoof||isMiddleRoof)
            {
                roofPanel = new RoofPanel(width, depth, isLeftRoof, isRightRoof, isMiddleRoof, isSingleRoof);
                parts.Add(roofPanel);

                for (int i = 0; i < 2; i++)
                {
                    RoofFixer roofFixer= new RoofFixer(depth);
                    parts.Add(roofFixer);
                }

                if (!isSingleRoof)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        connectingRoofPanel = new ConnectingRoofPanel(depth);
                        parts.Add(connectingRoofPanel);
                    }
                }             
                
            }     
            
            return parts;
        }
    }
}
