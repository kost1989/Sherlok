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
    public partial class a : Form
    {
        public a()
        {
            InitializeComponent();
        }

        private void warehouse_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "warehouse_to_main.main". При необходимости она может быть перемещена или удалена.
            this.mainTableAdapter1.Fill(this.warehouse_to_main.main);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "edit_stanok.stanky". При необходимости она может быть перемещена или удалена.
            this.stankyTableAdapter.Fill(this.edit_stanok.stanky);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "warehouse_dataset.main". При необходимости она может быть перемещена или удалена.
            this.mainTableAdapter.Fill(this.warehouse_dataset.main);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "main_add.main". При необходимости она может быть перемещена или удалена.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button2.Enabled = true;
            //MessageBox.Show(dataGridView1.CurrentRow.Cells[8].Value.ToString());
            stankyBindingSource.Filter = "typestanky = '" + dataGridView1.CurrentRow.Cells[6].Value + "'";
            mainBindingSource1.Filter = "`idmain` = '" + dataGridView1.CurrentRow.Cells[5].Value + "'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.CurrentRow.Cells[5].Value = comboBox1.SelectedValue;
                dataGridView2.CurrentRow.Cells[4].Value = 1;
                dataGridView2.CurrentRow.Cells[10].Value = DateTime.Today;


                this.Validate();
                this.mainBindingSource1.EndEdit();
                this.mainTableAdapter1.Update(this.warehouse_to_main.main);


                this.mainTableAdapter1.Fill(this.warehouse_to_main.main);
                this.mainTableAdapter.Fill(this.warehouse_dataset.main);
                button2.Enabled = false;
            }
            catch (Exception)
            {
                button2.Enabled = false;
                MessageBox.Show("Произошла ошибка. Выберете повторно позицию и станок к ней.", "Шерлок", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
