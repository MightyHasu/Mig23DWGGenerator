
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Reflection;
using Microsoft.Office.Interop.Excel;



namespace Mig23DWGGenerator
{
    public partial class Form1 : Form
    {
        //private Queue<Board> qtBoards;
        //private List<Board> boardList;
        private Dictionary<string, Board> boardDict;
        private Order order;
        private string selectedBoard;
        
        public Form1()
        {
            InitializeComponent();
            //boardList = new List<Board>();
            //qtBoards = new Queue<Board>();
            boardDict = new Dictionary<string, Board>();
            
        }  

        //СЪЗДАВАНЕ НА ТАБЛО
        private void buttonCreateBoard_Click_1(object sender, EventArgs e)
        {
            string _boardName = "";
            string _orderName = "";
            int _height = 0;
            int heightIndex = 0;
            int widhtIndex = 0;
            int depthIndex = 0;
            int fHeightIndex = 0;
            int doorIndex = 0;
            int roofIndex = 0;
            int _width = 0;
            int _depth = 0;
            bool _isLeftSingleDoor = false;
            bool _isRightSingleDoor = false;
            bool _isDoubleDoor = false;
            int _foundHeight = 0;
            bool _isSingleRoof = false;
            bool _isMiddleRoof = false;
            bool _isLeftRoof = false;
            bool _isRightRoof = false;
            bool _isBackOpened = false;
            bool _isTopOpened = false;
            bool _isLeftPanelOpened = false;
            bool _isRightPanelOpened = false;
            bool _isMountedLeft = false;
            bool _isMountedRight = false;
            bool _hasCircuitBreaker = false;
            List<AbstractPart> partList = new List<AbstractPart>();
            PartGenerator partGenerator = new PartGenerator();

            //ИМЕ ТАБЛО
            try
            {
                //string regex = "^[a-z + A-Z + 0-9] + -? + _? + \\s? [a-z + A-Z + 0-9] +$";
                if (Regex.Match(boardName.Text, @"^[\w]+[\s]?[\w]+$").Success)
                {
                    _boardName = boardName.Text;
                }
                else
                {
                    MessageBox.Show("Невалидно наименование!" +
                     "\nИмето може да съдържа само букви и цифри!");
                    return;
                }          
            }
            catch (Exception)
            {
                MessageBox.Show("Невалидно наименование!" +
                     "\nИмето може да съдържа само букви и цифри!");
                return;
            }
            //НОМЕР ПОРЪЧКА
            try
            {                
                if (Regex.Match(orderNumber.Text, @"^[\w]+[\s]?[\w]+$").Success)
                {
                    _orderName = orderNumber.Text;
                }
                else
                {
                    MessageBox.Show("Невалиден номер на поръчката!" +
                     "\nНомера може да съдържа само букви и цифри!");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Невалиден номер на поръчката!" +
                    "\nНомера може да съдържа само букви и цифри!");                
                return;
            }
            //ВИСОЧИНА
            try
            {
                _height = int.Parse(height.Text);
                heightIndex = height.SelectedIndex;
            }
            catch (FormatException)
            {
                MessageBox.Show("Unable to parse height");
                return;
            }
            //ШИРИНА
            //TODO WHEN DOOR IS BIGGER THEN 800, DISABLE SINGLE DOORS PICKS
            try
            {
                _width = int.Parse(width.Text);
                widhtIndex = width.SelectedIndex;                
            }
            catch (FormatException)
            {
                MessageBox.Show("Unable to parse width");
                return;
            }
            //ДЪЛБОЧИНА
            try
            {
                _depth = int.Parse(depth.Text);
                depthIndex = depth.SelectedIndex;
            }
            catch (FormatException)
            {
                MessageBox.Show("Unable to parse depth");
                return;
            }
            //ВИСОЧИНА НА ОСНОВАТА
            try
            {
                _foundHeight = int.Parse(foundHeight.Text);
                fHeightIndex = foundHeight.SelectedIndex;
            }
            catch (FormatException)
            {
                MessageBox.Show("Unable to parse foundation height");
            }

            //ТИП ВРАТА
            switch (doorType.SelectedIndex)
            {
                case 0: _isLeftSingleDoor = true;
                    break;
                case 1: _isRightSingleDoor = true;
                    break;
                case 2: _isDoubleDoor = true;
                    break;
                default:
                    MessageBox.Show("Изберете тип врата!");
                    return;
            }
            doorIndex = doorType.SelectedIndex;

            //ТИП КОЗИРКА
            switch (RoofType.SelectedIndex)
            {
                case 0:
                    break;
                case 1: _isSingleRoof = true;
                    break;
                case 2: _isLeftRoof = true;
                    break;
                case 3: _isRightRoof = true;
                    break;
                case 4: _isMiddleRoof = true;
                    break;
                default:
                    MessageBox.Show("Изберете тип козирка!");
                    return;                    
            }
            roofIndex = RoofType.SelectedIndex;

            //ОТОВРЕНО ОТЛЯВО
            if (isLeftPanelOpened.Checked)
            {
                _isLeftPanelOpened = true;
            }

            //ОТВОРЕНО ОТДЯСНО
            if (isRightPanelOpened.Checked)
            {
                _isRightPanelOpened = true;
            }
            //БЕЗ ГРЪБ
            if (isBackOpened.Checked)
            {
                _isBackOpened = true;
            }
            //ОТВОРЕНО ОТГОРЕ
            if (isTopPanelOpened.Checked)
            {
                _isTopOpened = true;
            }
            //ПРИСЪЕДИНЯВАНЕ ОТЛЯВО
            if (isFixedLeft.Checked)
            {
                _isMountedLeft = true;
            }
            //ПРИСЪЕДИНЯВАНЕ ОДЯСНО
            if (isFixedRight.Checked)
            {
                _isMountedRight = true;
            }
            //С ГЛАВЕН 
            if (hasCicrcuitBreaker.Checked)
            {
                _hasCircuitBreaker = true;
            }
            //ГЕНЕРИРАНЕ НА ТАБЛО
            try
            {
                //ПРОВЕРКА ЗА ПОВТАРЯЩИ СЕ ТАБЛА            
                if (!listBoards.Items.Contains(_boardName))
                {
                    partList.AddRange(partGenerator.GenerateParts(_height, _width, _depth, _isLeftSingleDoor, _isRightSingleDoor, _isDoubleDoor,
                                                           _foundHeight, _isSingleRoof, _isLeftRoof, _isRightRoof,
                                                           _isMiddleRoof, _isBackOpened, _isLeftPanelOpened,
                                                           _isRightPanelOpened, _isMountedLeft, _isMountedRight, _isTopOpened, _hasCircuitBreaker));

                    Board board = new Board(_boardName, partList, heightIndex, widhtIndex, depthIndex, fHeightIndex, doorIndex, roofIndex, 
                        _isLeftPanelOpened, _isRightPanelOpened, _isTopOpened, _isBackOpened, _isMountedLeft, _isMountedRight, _hasCircuitBreaker);
                    //qtBoards.Enqueue(board);
                    //boardList.Add(board);                
                    listBoards.Items.Add(_boardName);
                    boardDict.Add(board.GetName(), board);
                    MessageBox.Show(_boardName + " създадено!");
                    orderNumber.ReadOnly = true;
                    boardName.Text = "";
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Вече има табло с това име! Желате ли да запишете промените?", "Внимание", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        boardDict.Remove(_boardName);
                        listBoards.Items.Remove(_boardName);
                        Board board = new Board(_boardName, partList, heightIndex, widhtIndex, depthIndex, fHeightIndex, doorIndex, roofIndex,
                        _isLeftPanelOpened, _isRightPanelOpened, _isTopOpened, _isBackOpened, _isMountedLeft, _isMountedRight, _hasCircuitBreaker);
                        listBoards.Items.Add(_boardName);
                        boardDict.Add(board.GetName(), board);
                        MessageBox.Show(_boardName.ToString() + " създадено!");
                        orderNumber.ReadOnly = true;
                        boardName.Text = "";
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }                                   
                }               
            }
            catch (Exception)
            {
                MessageBox.Show("Не може да се създаде таблото!!!");
                return;
            }            
        }

        //ОТВОРЕНО ОТЛЯВО
        private void isLeftPanelOpened_CheckedChanged(object sender, EventArgs e)
        {
            if (isLeftPanelOpened.Checked)
            {
                isFixedLeft.Checked = true;
            }            
        }

        //ОТВОРЕНО ОТДЯСНО
        private void isRightPanelOpened_CheckedChanged(object sender, EventArgs e)
        {
            if (isRightPanelOpened.Checked)
            {
                isFixedRight.Checked = true;
            }            
        }

        //ИЗТРИВАНЕ НА ТАБЛО
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedBoard.Length>0)
                {
                    boardDict.Remove(selectedBoard);
                    listBoards.Items.Remove(listBoards.SelectedItem);
                    MessageBox.Show(selectedBoard + " изтрито !!!");
                    ClearForm();
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Няма записани табла!!!");
                return;
                throw;
            }
        }

        //ИЗБИРАНЕ НА ОПЦИЯ С КОЗИРКА
        private void RoofType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RoofType.SelectedIndex != 0)
            {
                isTopPanelOpened.Checked = false;
                isTopPanelOpened.Enabled = false;
                isBackOpened.Checked = false;
                isBackOpened.Enabled = false;
            }            
        }

        //ИЗЧИСТВАНЕ НА ФОРМАТА
        private void ClearForm()
        {
            boardName.Text = "";
            height.SelectedItem = null;
            width.SelectedItem = null;
            depth.SelectedItem = null;
            foundHeight.SelectedItem = null;
            doorType.SelectedItem = null;
            RoofType.SelectedItem = null;
            isBackOpened.Checked = false;
            isBackOpened.Enabled = true;
            isTopPanelOpened.Checked = false;
            isTopPanelOpened.Enabled = true;
            isLeftPanelOpened.Checked = false;
            isRightPanelOpened.Checked = false;
            isFixedRight.Checked = false;
            isFixedLeft.Checked = false;
            hasCicrcuitBreaker.Checked = false;
        }

        //МАРКИРАНЕ НА ТАБЛО
        private void listBoards_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedBoardName = listBoards.GetItemText(listBoards.SelectedItem);
                Board selectedBoard;
                if (!boardDict.TryGetValue(selectedBoardName, out selectedBoard))
                {
                    MessageBox.Show("Параметрите не могат да бъдат заредени");
                    return;
                }
                ClearForm();
                boardName.Text = selectedBoard.GetName();
                height.SelectedIndex = selectedBoard.GetHeightIndex();
                width.SelectedIndex = selectedBoard.GetWidthIndex();
                depth.SelectedIndex = selectedBoard.GetDepthIndex();
                foundHeight.SelectedIndex = selectedBoard.GetFHeightIndex();
                doorType.SelectedIndex = selectedBoard.GetDoorIndex();
                RoofType.SelectedIndex = selectedBoard.GetRoofIndex();
                isLeftPanelOpened.Checked = selectedBoard.GetIsLOpened();
                isRightPanelOpened.Checked = selectedBoard.GetIsROpened();
                isTopPanelOpened.Checked = selectedBoard.GetIsTopOpened();
                isBackOpened.Checked = selectedBoard.GetIsBackOpened();
                isFixedLeft.Checked = selectedBoard.GetIsLMounted();
                isFixedRight.Checked = selectedBoard.GetIsRMounted();
                hasCicrcuitBreaker.Checked = selectedBoard.GetHasCircuitBreaker();
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)        {            

            Microsoft.Office.Interop.Excel.Application oXL;
            Microsoft.Office.Interop.Excel.Workbook oWB;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;
            Microsoft.Office.Interop.Excel.Range oRng;            

            try
            {
                System.Globalization.CultureInfo oldCI = System.Threading.Thread.CurrentThread.CurrentCulture;
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

                //Start Excel and get Application object.
                oXL = new Microsoft.Office.Interop.Excel.Application();                
                //oXL.Visible = true;

                //Get a new workbook.
                oWB = (Microsoft.Office.Interop.Excel.Workbook)(oXL.Workbooks.Add(Missing.Value));
                oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oWB.ActiveSheet;

                //Format A1:D1 as bold, vertical alignment = center.
                oSheet.Range["A1"].EntireColumn.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                oSheet.Range["B1"].EntireColumn.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                oSheet.Range["C1"].EntireColumn.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                oSheet.Range["A1:A1"].Font.Bold = true;

                //ЗАГЛАВИЯ
                oSheet.Cells[1, 1] = orderNumber.Text;
                oSheet.Cells[2, 1] = "#";
                oSheet.Cells[2, 2] = "Номер детайл";
                oSheet.Cells[2, 3] = "Количество";

                //ПОДГОТОВКА НА СПИСЪКА С ЧАСТИ
                Dictionary<string, int> allPartsDict = new Dictionary<string, int>();
                foreach (var board in boardDict)
                {
                    List<AbstractPart> parts = board.Value.GetPartsList();
                    foreach (var part in parts)
                    {
                        if (!allPartsDict.ContainsKey(part.GetName()))
                        {
                            allPartsDict.Add(part.GetName(), 1);
                        }
                        else
                        {
                            allPartsDict[part.GetName()] += 1;
                        }
                    }
                }

                //ПИСАНЕ В ТАБЛИЦАТА
                int rowCounter = 3;
                int cycleCounter = 1;
                foreach (var part in allPartsDict)
                {
                    oSheet.Cells[rowCounter, 1] = cycleCounter.ToString();
                    oSheet.Cells[rowCounter, 2] = part.Key;
                    oSheet.Cells[rowCounter, 3] = part.Value;
                    cycleCounter++;
                    rowCounter++;
                }

                //Размер на колоните
                oRng = oSheet.UsedRange;                
                oRng.Columns.AutoFit();

                //SAVING
                SaveFileDialog sfd = new SaveFileDialog();

                sfd.FileName = orderNumber.Text + ".xlsx";
                sfd.DefaultExt = "xlsx";
                sfd.Filter = "xlsx files (*.xlsx)|*.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string path = sfd.FileName;
                    oWB.SaveAs(path);
                }

                //ex.SaveAs(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)  + "\\"+  orderNumber.Text+ ".xlsx");

                //FileInfo excelFile = new FileInfo(@"C:\Users\Mighty\Desktop\"+orderNumber.Text+".xlsx");
                //oWB.SaveAs(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\" + orderNumber.Text + ".xlsx");


                //Make sure Excel is visible and give the user control
                //of Microsoft Excel's lifetime.
                //oXL.Visible = true;
                //oXL.UserControl = true;


                //CLEAR ALL
                ClearForm();
                boardDict = new Dictionary<string, Board>();
                listBoards.Items.Clear();
                orderNumber.Clear();
                orderNumber.ReadOnly = false;
            }
            catch (Exception theException)
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Line: ");
                errorMessage = String.Concat(errorMessage, theException.Source);

                MessageBox.Show(errorMessage, "Error");
            }
        } 
    }    
}
