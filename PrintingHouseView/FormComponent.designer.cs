namespace PrintingHouseView
{
    partial class FormComponent
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxComponentName = new System.Windows.Forms.TextBox();
            this.labelComponentName = new System.Windows.Forms.Label();
            this.buttonComponentSave = new System.Windows.Forms.Button();
            this.buttonComponentCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxComponentName
            // 
            this.textBoxComponentName.Location = new System.Drawing.Point(119, 14);
            this.textBoxComponentName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxComponentName.Name = "textBoxComponentName";
            this.textBoxComponentName.Size = new System.Drawing.Size(235, 22);
            this.textBoxComponentName.TabIndex = 0;
            // 
            // labelComponentName
            // 
            this.labelComponentName.AutoSize = true;
            this.labelComponentName.Location = new System.Drawing.Point(31, 17);
            this.labelComponentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComponentName.Name = "labelComponentName";
            this.labelComponentName.Size = new System.Drawing.Size(76, 17);
            this.labelComponentName.TabIndex = 1;
            this.labelComponentName.Text = "Название:";
            // 
            // buttonComponentSave
            // 
            this.buttonComponentSave.Location = new System.Drawing.Point(133, 55);
            this.buttonComponentSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonComponentSave.Name = "buttonComponentSave";
            this.buttonComponentSave.Size = new System.Drawing.Size(100, 28);
            this.buttonComponentSave.TabIndex = 2;
            this.buttonComponentSave.Text = "Сохранить";
            this.buttonComponentSave.UseVisualStyleBackColor = true;
            this.buttonComponentSave.Click += new System.EventHandler(this.ButtonComponentSave_Click);
            // 
            // buttonComponentCancel
            // 
            this.buttonComponentCancel.Location = new System.Drawing.Point(255, 55);
            this.buttonComponentCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonComponentCancel.Name = "buttonComponentCancel";
            this.buttonComponentCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonComponentCancel.TabIndex = 3;
            this.buttonComponentCancel.Text = "Отмена";
            this.buttonComponentCancel.UseVisualStyleBackColor = true;
            this.buttonComponentCancel.Click += new System.EventHandler(this.ButtonComponentCancel_Click);
            // 
            // FormComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 98);
            this.Controls.Add(this.buttonComponentCancel);
            this.Controls.Add(this.buttonComponentSave);
            this.Controls.Add(this.labelComponentName);
            this.Controls.Add(this.textBoxComponentName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormComponent";
            this.Text = "Компонент печати";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxComponentName;
        private System.Windows.Forms.Label labelComponentName;
        private System.Windows.Forms.Button buttonComponentSave;
        private System.Windows.Forms.Button buttonComponentCancel;
    }
}

