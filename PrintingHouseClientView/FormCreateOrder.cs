using PrintingHouseBusinessLogic.BindingModels;
using PrintingHouseBusinessLogic.Interfaces;
using PrintingHouseBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PrintingHouseClientView
{
    public partial class FormCreateOrder : Form
    {
        public FormCreateOrder()
        {
            InitializeComponent();
            if (Program.Client.FIO == "")
            {
                Console.WriteLine("FIO= null");
            }
            else
            {
                Console.WriteLine("FIO= " + Program.Client.FIO);
            }
        }

        private void FormCreateOrder_Load(object sender, EventArgs e)
        {
            try
            {
                comboBoxProduct.DisplayMember = "PrintingProductName";
                comboBoxProduct.ValueMember = "Id";
                comboBoxProduct.DataSource = APIClient.GetRequest<List<PrintingProductViewModel>>("api/main/getprintingProductlist");
                comboBoxProduct.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalcSum()
        {
            if (comboBoxProduct.SelectedValue != null && !string.IsNullOrEmpty(textBoxCount.Text))
            {
                try
                {
                    int id = Convert.ToInt32(comboBoxProduct.SelectedValue);
                    PrintingProductViewModel product = APIClient.GetRequest<PrintingProductViewModel>($"api/main/getprintingProduct?productId={id}");
                    int count = Convert.ToInt32(textBoxCount.Text);
                    textBoxSum.Text = (count * product.Price).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TextBoxCount_TextChanged(object sender, EventArgs e)
        {
            CalcSum();
        }

        private void ComboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcSum();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (Program.Client.FIO == "")
            {
                Console.WriteLine("FIO= null");
            }
            else
            {
                Console.WriteLine("FIO= " + Program.Client.FIO);
            }
            if (string.IsNullOrEmpty(textBoxCount.Text))
            {
                MessageBox.Show("Заполните поле Количество", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBoxProduct.SelectedValue == null)
            {
                MessageBox.Show("Выберите изделие", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (Program.Client.FIO == "")
                {
                    Console.WriteLine("FIO= null");
                }
                else
                    Console.WriteLine("FIO= "+Program.Client.FIO);
                APIClient.PostRequest("api/main/createorder", new CreateOrderBindingModel
                {
                    ClientId = Program.Client.Id,
                    ClientFIO = Program.Client.FIO.ToString(),
                    PrintingProductId = Convert.ToInt32(comboBoxProduct.SelectedValue),
                    //DateCreate = DateTime.Now.Date,
                    Count = Convert.ToInt32(textBoxCount.Text),
                    Sum = Convert.ToDecimal(textBoxSum.Text)
                }) ;

                MessageBox.Show("Заказ создан", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}