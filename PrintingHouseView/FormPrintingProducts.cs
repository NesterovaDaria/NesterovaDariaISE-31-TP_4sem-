using PrintingHouseBusinessLogic.BindingModels;
using PrintingHouseBusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace PrintingHouseView
{
    public partial class FormPrintingProducts : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IPrintingProductLogic logic;
        public FormPrintingProducts(IPrintingProductLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void FormPrintingProducts_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                Program.ConfigGrid(logic.Read(null), dataGridViewPrintingProducts);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
        private void ButtonPrintingProductsAdd(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormPrintingProduct>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        private void ButtonPrintingProductsChange(object sender, EventArgs e)
        {
            if (dataGridViewPrintingProducts.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<FormPrintingProduct>();
                form.Id = Convert.ToInt32(dataGridViewPrintingProducts.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }
        private void ButtonPrintingProductsDelete(object sender, EventArgs e)
        {
            if (dataGridViewPrintingProducts.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridViewPrintingProducts.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        logic.Delete(new PrintingProductBindingModel { Id = id });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }
        private void ButtonPrintingProductsUpdate(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
