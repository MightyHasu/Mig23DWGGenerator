using Mig23DWGGenerator.Parts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Mig23DWGGenerator
{
    public partial class Form1 : Form
    {
        private Queue<Board> qtBoards;
        private List<Board> boardList;
        private Order order;
        public Form1()
        {
            InitializeComponent();
            boardList = new List<Board>();
            qtBoards = new Queue<Board>();
        }  

        private void buttonCreateBoard_Click_1(object sender, EventArgs e)
        {
            string _boardName = "";
            string _orderName = "";
            int _height = 0;
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
                string regex = "[a-z + A-Z + 0-9 + \\s]";
                Regex rx = new Regex(regex);
                if (rx.IsMatch(boardName.Text))
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
                string regex = "[a-z + A-Z + 0-9 + \\s]"; 
                Regex rx = new Regex(regex);
                if (rx.IsMatch(orderNumber.Text))
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
            }
            catch (FormatException)
            {
                MessageBox.Show("Unable to parse height");
                return;
            }
            //ШИРИНА
            try
            {
                _width = int.Parse(width.Text);
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

            //ГЕНЕРАТОР НА ДЕТАЙЛИ
            try
            {
                partList.AddRange(partGenerator.GenerateParts(_height, _width, _depth, _isLeftSingleDoor, _isRightSingleDoor, _isDoubleDoor,
                                                            _foundHeight, _isSingleRoof, _isLeftRoof, _isRightRoof,
                                                            _isMiddleRoof, _isBackOpened, _isLeftPanelOpened,
                                                            _isRightPanelOpened, _isMountedLeft, _isMountedRight, _isTopOpened, _hasCircuitBreaker));

                Board board = new Board(_boardName, partList);
                qtBoards.Enqueue(board);
                boardList.Add(board);

                listBoards.Items.Add(_boardName);
                MessageBox.Show(_boardName + " създадено!");
                orderNumber.ReadOnly = true;
                ClearForm();
            }
            catch (Exception)
            {
                MessageBox.Show("Не може да се създаде таблото!!!");
                return;
            }
            
        }

        private void isLeftPanelOpened_CheckedChanged(object sender, EventArgs e)
        {
            isFixedLeft.Checked = true;
        }

        private void isRightPanelOpened_CheckedChanged(object sender, EventArgs e)
        {
            isFixedRight.Checked = true;
        }   

        private void buttonBack_Click(object sender, EventArgs e)
        {
            try
            {
                Board tempBoard = qtBoards.Dequeue();
                string removedBoardName = listBoards.Items.IndexOf(listBoards.Items.Count - 1).ToString();
                listBoards.Items.RemoveAt(listBoards.Items.Count-1);
                MessageBox.Show(removedBoardName + " изтрито !!!"); 
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
    }    
}
