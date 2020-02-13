using System;

namespace Mig23DWGGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.doorType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.ComboBox();
            this.depth = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.foundHeight = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RoofType = new System.Windows.Forms.ComboBox();
            this.boardName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.listBoards = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.isRightPanelOpened = new System.Windows.Forms.CheckBox();
            this.isLeftPanelOpened = new System.Windows.Forms.CheckBox();
            this.isTopPanelOpened = new System.Windows.Forms.CheckBox();
            this.isBackOpened = new System.Windows.Forms.CheckBox();
            this.isFixedRight = new System.Windows.Forms.CheckBox();
            this.isFixedLeft = new System.Windows.Forms.CheckBox();
            this.buttonCreateBoard = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.orderNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.hasCicrcuitBreaker = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // doorType
            // 
            this.doorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doorType.FormattingEnabled = true;
            this.doorType.Items.AddRange(new object[] {
            "Лява врата",
            "Дясна врата",
            "Двойна врата"});
            this.doorType.Location = new System.Drawing.Point(11, 435);
            this.doorType.Name = "doorType";
            this.doorType.Size = new System.Drawing.Size(168, 21);
            this.doorType.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ВРАТА";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(11, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ШИРИНА";
            // 
            // width
            // 
            this.width.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.width.FormattingEnabled = true;
            this.width.Items.AddRange(new object[] {
            "700",
            "750",
            "800",
            "850",
            "900",
            "950",
            "1000",
            "1100",
            "1200"});
            this.width.Location = new System.Drawing.Point(11, 322);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(168, 21);
            this.width.TabIndex = 4;
            // 
            // depth
            // 
            this.depth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.depth.FormattingEnabled = true;
            this.depth.Items.AddRange(new object[] {
            "300"});
            this.depth.Location = new System.Drawing.Point(11, 360);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(168, 21);
            this.depth.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(11, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ДЪЛБОЧИНА";
            // 
            // height
            // 
            this.height.Cursor = System.Windows.Forms.Cursors.Default;
            this.height.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.height.FormattingEnabled = true;
            this.height.Items.AddRange(new object[] {
            "2000"});
            this.height.Location = new System.Drawing.Point(11, 286);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(168, 21);
            this.height.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(11, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ВИСОЧИНА";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 170);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // foundHeight
            // 
            this.foundHeight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.foundHeight.FormattingEnabled = true;
            this.foundHeight.Items.AddRange(new object[] {
            "0",
            "50",
            "100",
            "150",
            "200",
            "250",
            "300"});
            this.foundHeight.Location = new System.Drawing.Point(11, 397);
            this.foundHeight.Name = "foundHeight";
            this.foundHeight.Size = new System.Drawing.Size(168, 21);
            this.foundHeight.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(11, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "ВИСОЧИНА НА ОСНОВАТА";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(11, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "КОЗИРКА";
            // 
            // RoofType
            // 
            this.RoofType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoofType.FormattingEnabled = true;
            this.RoofType.Items.AddRange(new object[] {
            "Без козирка",
            "Единична",
            "Отворена отляво",
            "Отворена отдясно",
            "Отворена от двете страни"});
            this.RoofType.Location = new System.Drawing.Point(11, 474);
            this.RoofType.Name = "RoofType";
            this.RoofType.Size = new System.Drawing.Size(168, 21);
            this.RoofType.TabIndex = 12;
            this.RoofType.SelectedIndexChanged += new System.EventHandler(this.RoofType_SelectedIndexChanged);
            // 
            // boardName
            // 
            this.boardName.BackColor = System.Drawing.SystemColors.Window;
            this.boardName.Location = new System.Drawing.Point(11, 247);
            this.boardName.Name = "boardName";
            this.boardName.Size = new System.Drawing.Size(168, 20);
            this.boardName.TabIndex = 21;
            this.toolTip1.SetToolTip(this.boardName, "Името може да съдържа само букви и цифри");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(8, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "НАИМЕНОВАНИЕ НА ТАБЛОТО";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(11, 536);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(62, 23);
            this.buttonBack.TabIndex = 23;
            this.buttonBack.Text = "НАЗАД";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.Location = new System.Drawing.Point(361, 536);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(123, 23);
            this.buttonCreateOrder.TabIndex = 24;
            this.buttonCreateOrder.Text = "СЪЗДАЙ ПОРЪЧКА";
            this.buttonCreateOrder.UseVisualStyleBackColor = true;
            // 
            // listBoards
            // 
            this.listBoards.FormattingEnabled = true;
            this.listBoards.Location = new System.Drawing.Point(210, 344);
            this.listBoards.Name = "listBoards";
            this.listBoards.Size = new System.Drawing.Size(220, 173);
            this.listBoards.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(207, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "СПИСЪК НА ВЪВЕДЕНИЕ ТАБЛА";
            // 
            // isRightPanelOpened
            // 
            this.isRightPanelOpened.AutoSize = true;
            this.isRightPanelOpened.Location = new System.Drawing.Point(210, 207);
            this.isRightPanelOpened.Name = "isRightPanelOpened";
            this.isRightPanelOpened.Size = new System.Drawing.Size(119, 17);
            this.isRightPanelOpened.TabIndex = 28;
            this.isRightPanelOpened.Text = "Отворено отдясно";
            this.isRightPanelOpened.UseVisualStyleBackColor = true;
            this.isRightPanelOpened.CheckedChanged += new System.EventHandler(this.isRightPanelOpened_CheckedChanged);
            // 
            // isLeftPanelOpened
            // 
            this.isLeftPanelOpened.AutoSize = true;
            this.isLeftPanelOpened.Location = new System.Drawing.Point(210, 188);
            this.isLeftPanelOpened.Name = "isLeftPanelOpened";
            this.isLeftPanelOpened.Size = new System.Drawing.Size(113, 17);
            this.isLeftPanelOpened.TabIndex = 29;
            this.isLeftPanelOpened.Text = "Отворено отляво";
            this.isLeftPanelOpened.UseVisualStyleBackColor = true;
            this.isLeftPanelOpened.CheckedChanged += new System.EventHandler(this.isLeftPanelOpened_CheckedChanged);
            // 
            // isTopPanelOpened
            // 
            this.isTopPanelOpened.AutoSize = true;
            this.isTopPanelOpened.Location = new System.Drawing.Point(210, 226);
            this.isTopPanelOpened.Name = "isTopPanelOpened";
            this.isTopPanelOpened.Size = new System.Drawing.Size(112, 17);
            this.isTopPanelOpened.TabIndex = 30;
            this.isTopPanelOpened.Text = "Отворено отгоре";
            this.isTopPanelOpened.UseVisualStyleBackColor = true;
            // 
            // isBackOpened
            // 
            this.isBackOpened.AutoSize = true;
            this.isBackOpened.Location = new System.Drawing.Point(210, 245);
            this.isBackOpened.Name = "isBackOpened";
            this.isBackOpened.Size = new System.Drawing.Size(72, 17);
            this.isBackOpened.TabIndex = 31;
            this.isBackOpened.Text = "Без гръб";
            this.isBackOpened.UseVisualStyleBackColor = true;
            // 
            // isFixedRight
            // 
            this.isFixedRight.AutoSize = true;
            this.isFixedRight.Location = new System.Drawing.Point(210, 283);
            this.isFixedRight.Name = "isFixedRight";
            this.isFixedRight.Size = new System.Drawing.Size(210, 17);
            this.isFixedRight.TabIndex = 32;
            this.isFixedRight.Text = "Отвори за присъединяване отдясно";
            this.isFixedRight.UseVisualStyleBackColor = true;
            // 
            // isFixedLeft
            // 
            this.isFixedLeft.AutoSize = true;
            this.isFixedLeft.Location = new System.Drawing.Point(210, 264);
            this.isFixedLeft.Name = "isFixedLeft";
            this.isFixedLeft.Size = new System.Drawing.Size(204, 17);
            this.isFixedLeft.TabIndex = 33;
            this.isFixedLeft.Text = "Отвори за присъединяване отляво";
            this.isFixedLeft.UseVisualStyleBackColor = true;
            // 
            // buttonCreateBoard
            // 
            this.buttonCreateBoard.Location = new System.Drawing.Point(166, 536);
            this.buttonCreateBoard.Name = "buttonCreateBoard";
            this.buttonCreateBoard.Size = new System.Drawing.Size(107, 23);
            this.buttonCreateBoard.TabIndex = 34;
            this.buttonCreateBoard.Text = "СЪЗДАЙ ТАБЛО";
            this.buttonCreateBoard.UseVisualStyleBackColor = true;
            this.buttonCreateBoard.Click += new System.EventHandler(this.buttonCreateBoard_Click_1);
            // 
            // orderNumber
            // 
            this.orderNumber.BackColor = System.Drawing.SystemColors.Window;
            this.orderNumber.Location = new System.Drawing.Point(11, 208);
            this.orderNumber.Name = "orderNumber";
            this.orderNumber.Size = new System.Drawing.Size(168, 20);
            this.orderNumber.TabIndex = 36;
            this.toolTip1.SetToolTip(this.orderNumber, "Името може да съдържа само букви и цифри");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(8, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "НОМЕР НА ПОРЪЧКА";
            // 
            // hasCicrcuitBreaker
            // 
            this.hasCicrcuitBreaker.AutoSize = true;
            this.hasCicrcuitBreaker.Location = new System.Drawing.Point(210, 302);
            this.hasCicrcuitBreaker.Name = "hasCicrcuitBreaker";
            this.hasCicrcuitBreaker.Size = new System.Drawing.Size(128, 17);
            this.hasCicrcuitBreaker.TabIndex = 37;
            this.hasCicrcuitBreaker.Text = "С главен прекъсвач";
            this.hasCicrcuitBreaker.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 571);
            this.Controls.Add(this.hasCicrcuitBreaker);
            this.Controls.Add(this.orderNumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonCreateBoard);
            this.Controls.Add(this.isFixedLeft);
            this.Controls.Add(this.isFixedRight);
            this.Controls.Add(this.isBackOpened);
            this.Controls.Add(this.isTopPanelOpened);
            this.Controls.Add(this.isLeftPanelOpened);
            this.Controls.Add(this.isRightPanelOpened);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listBoards);
            this.Controls.Add(this.buttonCreateOrder);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.boardName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RoofType);
            this.Controls.Add(this.foundHeight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.height);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.width);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doorType);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "MIG 23 DWG Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }    

        #endregion

        private System.Windows.Forms.ComboBox doorType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox width;
        private System.Windows.Forms.ComboBox depth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox height;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox foundHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox RoofType;
        private System.Windows.Forms.TextBox boardName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonCreateOrder;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBoards;
        private System.Windows.Forms.CheckBox isFixedLeft;
        private System.Windows.Forms.CheckBox isFixedRight;
        private System.Windows.Forms.CheckBox isBackOpened;
        private System.Windows.Forms.CheckBox isTopPanelOpened;
        private System.Windows.Forms.CheckBox isLeftPanelOpened;
        private System.Windows.Forms.CheckBox isRightPanelOpened;
        private System.Windows.Forms.Button buttonCreateBoard;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox orderNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox hasCicrcuitBreaker;
    }
}

