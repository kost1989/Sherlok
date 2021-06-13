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
    public partial class edit_matpuan : Form
    {
        public edit_matpuan()
        {
            InitializeComponent();
        }

        private void edit_matpuan_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "edit_matpuan1.names". При необходимости она может быть перемещена или удалена.
            this.namesTableAdapter.Fill(this.edit_matpuan1.names);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "edit_matpuan1.typename". При необходимости она может быть перемещена или удалена.
            this.typenameTableAdapter.Fill(this.edit_matpuan1.typename);

        }

        private void save_to_base_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.namesBindingSource.EndEdit();
            this.namesTableAdapter.Update(this.edit_matpuan1.names);
            this.namesTableAdapter.Fill(this.edit_matpuan1.names);
        }

        private void end_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void load_from_base_Click(object sender, EventArgs e)
        {
            try
            {
                this.namesBindingSource.EndEdit();
            }
            catch (Exception)
            {
            }
            this.namesTableAdapter.Fill(this.edit_matpuan1.names);
        }

        private void help_button_Click(object sender, EventArgs e)
        {
            Commands.help_start.start();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridView1.BeginEdit(true);
                // Ячейка выбора файла -----------------------------------------------------------------------------------------------------
                if (e.ColumnIndex == 10)
                {
                    openFileDialog1.ShowDialog();
                    if (openFileDialog1.FileName.ToString() != "openFileDialog1") dataGridView1.CurrentCell.Value = openFileDialog1.FileName.ToString();


                    //System.Windows.Forms.MessageBox.Show(Convert.ToString(openFileDialog1.FileName.Length.ToString()));
                }
            }
            catch (Exception)
            {
            }
            
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            if (anError.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Нельзя переходить на новую строку не заполнив предыдущую (есть пустые значения)");
            }
            else
            {
                if (anError.Context == DataGridViewDataErrorContexts.CurrentCellChange)
                {
                    MessageBox.Show("Cell change!");
                }
                else
                {
                    if (anError.Context == DataGridViewDataErrorContexts.Parsing)
                    {
                        MessageBox.Show("parsing error!");
                    }
                    else
                    {
                        if (anError.Context == DataGridViewDataErrorContexts.LeaveControl)
                        {
                            MessageBox.Show("leave control error!");
                        }
                        else
                        {
                            MessageBox.Show("Не верный формат");
                        }
                    }
                }
            }



            if ((anError.Exception) is ConstraintException)
            {
                DataGridView view = (DataGridView)sender;
                view.Rows[anError.RowIndex].ErrorText = "an error";
                view.Rows[anError.RowIndex].Cells[anError.ColumnIndex].ErrorText = "an error";

                anError.ThrowException = false;
            }
        }
    }
}
