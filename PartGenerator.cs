using Mig23DWGGenerator.Parts;
using System.Collections.Generic;


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
        private FoundCap foundCap;
        private SinglePen singlePen;
        private ModuleFixer moduleFixer;
        private FrontSidePanel frontSidePanel;
        private RearSidePanel rearSidePanel;
        private CircuitBreakerMP circuitBreakerMP;
        private MPFixer mpFixer;
        private AdditionalVerticalDoorProfile additionalVerticalDoorProfile;
        private AdditionalHorizontalDoorProfile additionalHorizontalDoorProfile;

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
            rearSidePanel = new RearSidePanel(height, width, depth, isMountedLeft, isLeftPanelOpened, isBackOpened);
            parts.Add(rearSidePanel);

            //КОЛОНА ЗАДНА ДЯСНА
            rearSidePanel = new RearSidePanel(height, width, depth, isMountedRight, isRightPanelOpened, isBackOpened);
            parts.Add(rearSidePanel);
           

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

            //ВИНКЕЛ ЗА МОНТАЖНА ПЛОЧА ЗА ТАБЛО С ГРЪБ
            if (!isBackOpened)
            {
                for (int i = 0; i < 2; i++)
                {
                    mpFixer = new MPFixer(width);
                    parts.Add(mpFixer);
                }
            }

            //ОСНОВА
            if (foundHeight>0)
            {
                for (int i = 0; i < 2; i++)
                {
                    foundWidth = new FoundWidth(width, foundHeight);
                    foundDepth = new FoundDepth(depth, foundHeight);
                    parts.Add(foundDepth);
                    parts.Add(foundWidth);
                }
                foundCap = new FoundCap(depth);
                parts.Add(foundCap);
            }

            //ВРАТИ
            if (isLeftSingleDoor||isRightSingleDoor)
            {
                sd = new SingleDoor(width, height, isLeftSingleDoor);
                parts.Add(sd);

                for (int i = 0; i < 3; i++)
                {
                    additionalHorizontalDoorProfile = new AdditionalHorizontalDoorProfile(width);
                    parts.Add(additionalHorizontalDoorProfile);
                }

                for (int i = 0; i < 2; i++)
                {
                    additionalVerticalDoorProfile = new AdditionalVerticalDoorProfile(height);
                    parts.Add(additionalVerticalDoorProfile);
                }
                
            } 
            else
            {
                ddl = new DoubleDoorLeft(width, height);
                ddr = new DoubleDoorRight(width, height);
                parts.Add(ddl);
                parts.Add(ddr);

                for (int i = 0; i < 6; i++)
                {
                    additionalHorizontalDoorProfile = new AdditionalHorizontalDoorProfile(width);
                    parts.Add(additionalHorizontalDoorProfile);
                }
                

                for (int i = 0; i < 4; i++)
                {
                    additionalVerticalDoorProfile = new AdditionalVerticalDoorProfile(height);
                    parts.Add(additionalVerticalDoorProfile);
                }

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

            //ДЪНО
            botPanel = new BotPanel(width, depth, isBackOpened);
            parts.Add(botPanel);

            //ПОКРИВ
            if (isSingleRoof||isLeftRoof||isRightRoof||isMiddleRoof)
            {
                roofPanel = new RoofPanel(width, depth, isLeftRoof, isRightRoof, isMiddleRoof, isSingleRoof);
                parts.Add(roofPanel);

                for (int i = 0; i < 2; i++)
                {
                    roofFixer = new RoofFixer(depth);
                    parts.Add(roofFixer);
                }

                if (!isSingleRoof)
                {                    
                    connectingRoofPanel = new ConnectingRoofPanel(depth);
                    parts.Add(connectingRoofPanel);                   
                }             
                
            }     
            
            return parts;
        }
    }
}
