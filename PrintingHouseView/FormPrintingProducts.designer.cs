namespace PrintingHouseView
{
    partial class FormPrintingProducts
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
            this.dataGridViewPrintingProducts = new System.Windows.Forms.DataGridView();
            this.buttonPrintingProductsAdd = new System.Windows.Forms.Button();
            this.buttonPrintingProductsChange = new System.Windows.Forms.Button();
            this.buttonPrintingProductsDelete = new System.Windows.Forms.Button();
            this.buttonPrintingProductsUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrintingProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPrintingProducts
            // 
            this.dataGridViewPrintingProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrintingProducts.Location = new System.Drawing.Point(5, 13);
            this.dataGridViewPrintingProducts.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPrintingProducts.Name = "dataGridViewPrintingProducts";
            this.dataGridViewPrintingProducts.Size = new System.Drawing.Size(743, 521);
            this.dataGridViewPrintingProducts.TabIndex = 0;
            // 
            // buttonPrintingProductsAdd
            // 
            this.buttonPrintingProductsAdd.Location = new System.Drawing.Point(754, 129);
            this.buttonPrintingProductsAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPrintingProductsAdd.Name = "buttonPrintingProductsAdd";
            this.buttonPrintingProductsAdd.Size = new System.Drawing.Size(129, 48);
            this.buttonPrintingProductsAdd.TabIndex = 1;
            this.buttonPrintingProductsAdd.Text = "Добавить";
            this.buttonPrintingProductsAdd.UseVisualStyleBackColor = true;
            this.buttonPrintingProductsAdd.Click += new System.EventHandler(this.ButtonPrintingProductsAdd);
            // 
            // buttonPrintingProductsChange
            // 
            this.buttonPrintingProductsChange.Location = new System.Drawing.Point(756, 185);
            this.buttonPrintingProductsChange.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPrintingProductsChange.Name = "buttonPrintingProductsChange";
            this.buttonPrintingProductsChange.Size = new System.Drawing.Size(127, 54);
            this.buttonPrintingProductsChange.TabIndex = 2;
            this.buttonPrintingProductsChange.Text = "Изменить";
            this.buttonPrintingProductsChange.UseVisualStyleBackColor = true;
            this.buttonPrintingProductsChange.Click += new System.EventHandler(this.ButtonPrintingProductsChange);
            // 
            // buttonPrintingProductsDelete
            // 
            this.buttonPrintingProductsDelete.Location = new System.Drawing.Point(756, 247);
            this.buttonPrintingProductsDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPrintingProductsDelete.Name = "buttonPrintingProductsDelete";
            this.buttonPrintingProductsDelete.Size = new System.Drawing.Size(127, 55);
            this.buttonPrintingProductsDelete.TabIndex = 3;
            this.buttonPrintingProductsDelete.Text = "Удалить";
            this.buttonPrintingProductsDelete.UseVisualStyleBackColor = true;
            this.buttonPrintingProductsDelete.Click += new System.EventHandler(this.ButtonPrintingProductsDelete);
            // 
            // buttonPrintingProductsUpdate
            // 
            this.buttonPrintingProductsUpdate.Location = new System.Drawing.Point(757, 310);
            this.buttonPrintingProductsUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPrintingProductsUpdate.Name = "buttonPrintingProductsUpdate";
            this.buttonPrintingProductsUpdate.Size = new System.Drawing.Size(126, 49);
            this.buttonPrintingProductsUpdate.TabIndex = 4;
            this.buttonPrintingProductsUpdate.Text = "Обновить";
            this.buttonPrintingProductsUpdate.UseVisualStyleBackColor = true;
            // 
            // FormPrintingProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 554);
            this.Controls.Add(this.buttonPrintingProductsUpdate);
            this.Controls.Add(this.buttonPrintingProductsDelete);
            this.Controls.Add(this.buttonPrintingProductsChange);
            this.Controls.Add(this.buttonPrintingProductsAdd);
            this.Controls.Add(this.dataGridViewPrintingProducts);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrintingProducts";
            this.Text = "Печатная продукция";
            this.Load += new System.EventHandler(this.FormPrintingProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrintingProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewPrintingProducts;
        private System.Windows.Forms.Button buttonPrintingProductsAdd;
        private System.Windows.Forms.Button buttonPrintingProductsChange;
        private System.Windows.Forms.Button buttonPrintingProductsDelete;
        private System.Windows.Forms.Button buttonPrintingProductsUpdate;
    }
}