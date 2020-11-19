namespace PrintingHouseView
{
    partial class FormReportPrintingComponents
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
            this.buttonToPdf = new System.Windows.Forms.Button();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // buttonToPdf
            // 
            this.buttonToPdf.Location = new System.Drawing.Point(808, 1);
            this.buttonToPdf.Margin = new System.Windows.Forms.Padding(4);
            this.buttonToPdf.Name = "buttonToPdf";
            this.buttonToPdf.Size = new System.Drawing.Size(100, 28);
            this.buttonToPdf.TabIndex = 5;
            this.buttonToPdf.Text = "В pdf";
            this.buttonToPdf.UseVisualStyleBackColor = true;
            this.buttonToPdf.Click += new System.EventHandler(this.ButtonToPdf_Click);
            // 
            // reportViewer
            // 
            this.reportViewer.LocalReport.ReportEmbeddedResource = "PrintingHouseView.Report1.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(12, 44);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(896, 375);
            this.reportViewer.TabIndex = 6;
            this.reportViewer.Load += new System.EventHandler(this.reportViewer_Load);
            // 
            // FormReportPrintingComponents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 431);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.buttonToPdf);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormReportPrintingComponents";
            this.Text = "Компоненты для печати";
            this.Load += new System.EventHandler(this.FormReportPrintingComponents_Load_1);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonToPdf;
        private System.Windows.Forms.BindingSource ReportPrintingComponentViewModelBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
    }
}

