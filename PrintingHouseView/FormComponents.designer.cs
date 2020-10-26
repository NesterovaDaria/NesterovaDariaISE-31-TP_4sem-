namespace PrintingHouseView
{
    partial class FormComponents
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
            this.dataGridViewComponents = new System.Windows.Forms.DataGridView();
            this.buttonComponentsAdd = new System.Windows.Forms.Button();
            this.buttonComponentsChange = new System.Windows.Forms.Button();
            this.buttonComponentsDelete = new System.Windows.Forms.Button();
            this.buttonComponentsUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComponents)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewComponents
            // 
            this.dataGridViewComponents.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewComponents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComponents.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewComponents.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewComponents.Name = "dataGridViewComponents";
            this.dataGridViewComponents.Size = new System.Drawing.Size(467, 431);
            this.dataGridViewComponents.TabIndex = 0;
            // 
            // buttonComponentsAdd
            // 
            this.buttonComponentsAdd.Location = new System.Drawing.Point(504, 59);
            this.buttonComponentsAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonComponentsAdd.Name = "buttonComponentsAdd";
            this.buttonComponentsAdd.Size = new System.Drawing.Size(100, 28);
            this.buttonComponentsAdd.TabIndex = 1;
            this.buttonComponentsAdd.Text = "Добавить";
            this.buttonComponentsAdd.UseVisualStyleBackColor = true;
            this.buttonComponentsAdd.Click += new System.EventHandler(this.ButtonComponentsAdd_Click);
            // 
            // buttonComponentsChange
            // 
            this.buttonComponentsChange.Location = new System.Drawing.Point(504, 114);
            this.buttonComponentsChange.Margin = new System.Windows.Forms.Padding(4);
            this.buttonComponentsChange.Name = "buttonComponentsChange";
            this.buttonComponentsChange.Size = new System.Drawing.Size(100, 28);
            this.buttonComponentsChange.TabIndex = 2;
            this.buttonComponentsChange.Text = "Изменить";
            this.buttonComponentsChange.UseVisualStyleBackColor = true;
            this.buttonComponentsChange.Click += new System.EventHandler(this.ButtonComponentsChange_Click);
            // 
            // buttonComponentsDelete
            // 
            this.buttonComponentsDelete.Location = new System.Drawing.Point(504, 174);
            this.buttonComponentsDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonComponentsDelete.Name = "buttonComponentsDelete";
            this.buttonComponentsDelete.Size = new System.Drawing.Size(100, 28);
            this.buttonComponentsDelete.TabIndex = 3;
            this.buttonComponentsDelete.Text = "Удалить";
            this.buttonComponentsDelete.UseVisualStyleBackColor = true;
            this.buttonComponentsDelete.Click += new System.EventHandler(this.ButtonComponentsDelete_Click);
            // 
            // buttonComponentsUpdate
            // 
            this.buttonComponentsUpdate.Location = new System.Drawing.Point(504, 228);
            this.buttonComponentsUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonComponentsUpdate.Name = "buttonComponentsUpdate";
            this.buttonComponentsUpdate.Size = new System.Drawing.Size(100, 28);
            this.buttonComponentsUpdate.TabIndex = 4;
            this.buttonComponentsUpdate.Text = "Обновить";
            this.buttonComponentsUpdate.UseVisualStyleBackColor = true;
            this.buttonComponentsUpdate.Click += new System.EventHandler(this.ButtonComponentsUpdate_Click);
            // 
            // FormComponents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 432);
            this.Controls.Add(this.buttonComponentsUpdate);
            this.Controls.Add(this.buttonComponentsDelete);
            this.Controls.Add(this.buttonComponentsChange);
            this.Controls.Add(this.buttonComponentsAdd);
            this.Controls.Add(this.dataGridViewComponents);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormComponents";
            this.Text = "Компоненты печати";
            this.Load += new System.EventHandler(this.FormComponents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComponents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewComponents;
        private System.Windows.Forms.Button buttonComponentsAdd;
        private System.Windows.Forms.Button buttonComponentsChange;
        private System.Windows.Forms.Button buttonComponentsDelete;
        private System.Windows.Forms.Button buttonComponentsUpdate;
    }
}