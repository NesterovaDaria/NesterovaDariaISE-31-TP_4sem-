namespace PrintingHouseView
{
    partial class FormMain
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.компонентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатнаяпродукцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокКлиентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокИсполнителейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокИзделийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокИзделийСКомпонентамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокЗаказовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.buttonOrderIsPaid = new System.Windows.Forms.Button();
            this.buttonUpdateList = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonStartWork = new System.Windows.Forms.Button();
            this.buttonMessages = new System.Windows.Forms.Button();
            this.создатьБекапToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.toolStripMenuItem1,
            this.отчётыToolStripMenuItem,
            this.создатьБекапToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1092, 28);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.компонентыToolStripMenuItem,
            this.печатнаяпродукцияToolStripMenuItem,
            this.списокКлиентовToolStripMenuItem,
            this.списокИсполнителейToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // компонентыToolStripMenuItem
            // 
            this.компонентыToolStripMenuItem.Name = "компонентыToolStripMenuItem";
            this.компонентыToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.компонентыToolStripMenuItem.Text = "Компоненты печати";
            this.компонентыToolStripMenuItem.Click += new System.EventHandler(this.КомпонентыToolStripMenuItem_Click);
            // 
            // печатнаяпродукцияToolStripMenuItem
            // 
            this.печатнаяпродукцияToolStripMenuItem.Name = "печатнаяпродукцияToolStripMenuItem";
            this.печатнаяпродукцияToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.печатнаяпродукцияToolStripMenuItem.Text = "Печатная продукция";
            this.печатнаяпродукцияToolStripMenuItem.Click += new System.EventHandler(this.ПечатнаяпродукцияToolStripMenuItem_Click);
            // 
            // списокКлиентовToolStripMenuItem
            // 
            this.списокКлиентовToolStripMenuItem.Name = "списокКлиентовToolStripMenuItem";
            this.списокКлиентовToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.списокКлиентовToolStripMenuItem.Text = "Список клиентов";
            this.списокКлиентовToolStripMenuItem.Click += new System.EventHandler(this.списокКлиентовToolStripMenuItem_Click);
            // 
            // списокИсполнителейToolStripMenuItem
            // 
            this.списокИсполнителейToolStripMenuItem.Name = "списокИсполнителейToolStripMenuItem";
            this.списокИсполнителейToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.списокИсполнителейToolStripMenuItem.Text = "Список исполнителей";
            this.списокИсполнителейToolStripMenuItem.Click += new System.EventHandler(this.списокИсполнителейToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 24);
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокИзделийToolStripMenuItem,
            this.списокИзделийСКомпонентамиToolStripMenuItem,
            this.списокЗаказовToolStripMenuItem});
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.отчётыToolStripMenuItem.Text = "Отчёты";
            // 
            // списокИзделийToolStripMenuItem
            // 
            this.списокИзделийToolStripMenuItem.Name = "списокИзделийToolStripMenuItem";
            this.списокИзделийToolStripMenuItem.Size = new System.Drawing.Size(324, 26);
            this.списокИзделийToolStripMenuItem.Text = "Список изделий";
            this.списокИзделийToolStripMenuItem.Click += new System.EventHandler(this.списокИзделийToolStripMenuItem_Click);
            // 
            // списокИзделийСКомпонентамиToolStripMenuItem
            // 
            this.списокИзделийСКомпонентамиToolStripMenuItem.Name = "списокИзделийСКомпонентамиToolStripMenuItem";
            this.списокИзделийСКомпонентамиToolStripMenuItem.Size = new System.Drawing.Size(324, 26);
            this.списокИзделийСКомпонентамиToolStripMenuItem.Text = "Список изделий с компонентами";
            this.списокИзделийСКомпонентамиToolStripMenuItem.Click += new System.EventHandler(this.списокИзделийСКомпонентамиToolStripMenuItem_Click);
            // 
            // списокЗаказовToolStripMenuItem
            // 
            this.списокЗаказовToolStripMenuItem.Name = "списокЗаказовToolStripMenuItem";
            this.списокЗаказовToolStripMenuItem.Size = new System.Drawing.Size(324, 26);
            this.списокЗаказовToolStripMenuItem.Text = "Список заказов";
            this.списокЗаказовToolStripMenuItem.Click += new System.EventHandler(this.списокЗаказовToolStripMenuItem_Click);
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMain.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(0, 33);
            this.dataGridViewMain.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.RowHeadersWidth = 51;
            this.dataGridViewMain.Size = new System.Drawing.Size(849, 420);
            this.dataGridViewMain.TabIndex = 1;
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonCreateOrder.Location = new System.Drawing.Point(879, 65);
            this.buttonCreateOrder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(197, 28);
            this.buttonCreateOrder.TabIndex = 2;
            this.buttonCreateOrder.Text = "Создать заказ";
            this.buttonCreateOrder.UseVisualStyleBackColor = true;
            this.buttonCreateOrder.Click += new System.EventHandler(this.ButtonCreateOrder_Click);
            // 
            // buttonOrderIsPaid
            // 
            this.buttonOrderIsPaid.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonOrderIsPaid.Location = new System.Drawing.Point(879, 212);
            this.buttonOrderIsPaid.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOrderIsPaid.Name = "buttonOrderIsPaid";
            this.buttonOrderIsPaid.Size = new System.Drawing.Size(197, 28);
            this.buttonOrderIsPaid.TabIndex = 5;
            this.buttonOrderIsPaid.Text = "Заказ оплачен";
            this.buttonOrderIsPaid.UseVisualStyleBackColor = true;
            this.buttonOrderIsPaid.Click += new System.EventHandler(this.ButtonOrderIsPaid_Click);
            // 
            // buttonUpdateList
            // 
            this.buttonUpdateList.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonUpdateList.Location = new System.Drawing.Point(879, 285);
            this.buttonUpdateList.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdateList.Name = "buttonUpdateList";
            this.buttonUpdateList.Size = new System.Drawing.Size(197, 28);
            this.buttonUpdateList.TabIndex = 6;
            this.buttonUpdateList.Text = "Обновить список";
            this.buttonUpdateList.UseVisualStyleBackColor = true;
            this.buttonUpdateList.Click += new System.EventHandler(this.ButtonUpd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonDel.Location = new System.Drawing.Point(879, 351);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(197, 23);
            this.buttonDel.TabIndex = 7;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonStartWork
            // 
            this.buttonStartWork.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonStartWork.Location = new System.Drawing.Point(879, 140);
            this.buttonStartWork.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStartWork.Name = "buttonStartWork";
            this.buttonStartWork.Size = new System.Drawing.Size(197, 28);
            this.buttonStartWork.TabIndex = 8;
            this.buttonStartWork.Text = "Взять в работу";
            this.buttonStartWork.UseVisualStyleBackColor = true;
            this.buttonStartWork.Click += new System.EventHandler(this.buttonStartWork_Click);
            // 
            // buttonMessages
            // 
            this.buttonMessages.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonMessages.Location = new System.Drawing.Point(879, 412);
            this.buttonMessages.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMessages.Name = "buttonMessages";
            this.buttonMessages.Size = new System.Drawing.Size(197, 28);
            this.buttonMessages.TabIndex = 9;
            this.buttonMessages.Text = "Сообщения";
            this.buttonMessages.UseVisualStyleBackColor = true;
            this.buttonMessages.Click += new System.EventHandler(this.buttonMessages_Click);
            // 
            // создатьБекапToolStripMenuItem
            // 
            this.создатьБекапToolStripMenuItem.Name = "создатьБекапToolStripMenuItem";
            this.создатьБекапToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.создатьБекапToolStripMenuItem.Text = "Создать бекап";
            this.создатьБекапToolStripMenuItem.Click += new System.EventHandler(this.создатьБекапToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 453);
            this.Controls.Add(this.buttonMessages);
            this.Controls.Add(this.buttonStartWork);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonUpdateList);
            this.Controls.Add(this.buttonOrderIsPaid);
            this.Controls.Add(this.buttonCreateOrder);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Типография";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem компонентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печатнаяпродукцияToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Button buttonCreateOrder;
        private System.Windows.Forms.Button buttonOrderIsPaid;
        private System.Windows.Forms.Button buttonUpdateList;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокИзделийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокИзделийСКомпонентамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокЗаказовToolStripMenuItem;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ToolStripMenuItem списокКлиентовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокИсполнителейToolStripMenuItem;
        private System.Windows.Forms.Button buttonStartWork;
        private System.Windows.Forms.Button buttonMessages;
        private System.Windows.Forms.ToolStripMenuItem создатьБекапToolStripMenuItem;
    }
}