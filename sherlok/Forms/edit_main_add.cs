using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sherlok.Forms
{
    public partial class edit_main_add : Form
    {
        // Индекс таблицы
        Int32 ind = new Int32();
        // Соответствие чертежей
        byte sootvm = 0;
        byte sootvp = 0;

        public edit_main_add()
        {
            InitializeComponent();

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void edit_main_add_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "edit_stanok.typename". При необходимости она может быть перемещена или удалена.
            this.typenameTableAdapter.Fill(this.edit_stanok.typename);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "main_add.main". При необходимости она может быть перемещена или удалена.
            this.mainTableAdapter.Fill(this.main_add.main);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "editor_main.stanky". При необходимости она может быть перемещена или удалена.
            this.stankyTableAdapter.Fill(this.editor_main.stanky);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "editor_main.names". При необходимости она может быть перемещена или удалена.
            this.namesTableAdapter.Fill(this.editor_main.names);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "editor_main.names". При необходимости она может быть перемещена или удалена.
            this.dataTable1TableAdapter1.Fill(this.editor_main.DataTable1);
            try
            {
                ind = editor_main.DataTable1.Rows[0].Field<Int32>(editor_main.DataTable1.Expr1Column) + 1;
            }
            catch (Exception)
            {
                ind = 1;
            }
            index_label.Text = ind.ToString();
            name_combobox.Focus();
            name_combobox.SelectAll();
            name_combobox.DroppedDown = true;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (matrix_checkbox.Checked == true && puanson_checkbox.Checked == true)
                {
                    this.mainTableAdapter.Insert(ind, ++name_combobox.SelectedIndex, number_textbox.Text, 1, double.Parse(matrix_iznos.Text), dateTimePicker3.Value.Date, 3, 0);
                    this.mainTableAdapter.Insert(++ind, name_combobox.SelectedIndex, number_textbox.Text, 2, double.Parse(puanson_iznos.Text), dateTimePicker3.Value.Date, 3, 0);
                }
                if (matrix_checkbox.Checked == true && puanson_checkbox.Checked == false) this.mainTableAdapter.Insert(ind, ++name_combobox.SelectedIndex, number_textbox.Text, 1, double.Parse(matrix_iznos.Text), dateTimePicker3.Value.Date, 3, 0);
                if (matrix_checkbox.Checked == false && puanson_checkbox.Checked == true) this.mainTableAdapter.Insert(ind, ++name_combobox.SelectedIndex, number_textbox.Text, 2, double.Parse(puanson_iznos.Text), dateTimePicker3.Value.Date, 3, 0);

                this.Close();
            }
            catch (Exception)
            {
                --name_combobox.SelectedIndex;
                MessageBox.Show("Ошибка ввода данных (Пример ввода: 25,4)", "Шерлок", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void matrix_chertezh_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            sootvm++;
        }

        private void puanson_chertezh_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            sootvp++;
        }
    }
}
