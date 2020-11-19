using PrintingHouseBusinessLogic.BindingModels;
using PrintingHouseBusinessLogic.BusinessLogics;
using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;
using Unity;

namespace PrintingHouseView
{
    public partial class FormReportPrintingComponents : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ReportLogic logic;
        public FormReportPrintingComponents(ReportLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }
        private void ButtonToPdf_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog { Filter = "pdf|*.pdf" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        logic.SaveProductComponentsToPdfFile(new ReportBindingModel
                        {
                            FileName = dialog.FileName,
                        });

                        MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void reportViewer_Load(object sender, EventArgs e)
        {
            try
            {
                var dataSource = logic.GetProductComponent();
                Console.WriteLine(dataSource.Count);
                foreach (var data in dataSource)
                {
                    Console.WriteLine(data.PrintingProductName + " " + data.ComponentName + " " + data.Count);
                }
                ReportDataSource source = new ReportDataSource("DataSet", dataSource);
                reportViewer.LocalReport.DataSources.Add(source);
                reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormReportPrintingComponents_Load(object sender, EventArgs e)
        {

            this.reportViewer.RefreshReport();
        }

        private void FormReportPrintingComponents_Load_1(object sender, EventArgs e)
        {

            this.reportViewer.RefreshReport();
        }
    }
}