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
    public partial class edit_stanok : Form
    {
        public edit_stanok()
        {
            InitializeComponent();
        }

        private void edit_stanok_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "edit_stanok1.typename". При необходимости она может быть перемещена или удалена.
            this.typenameTableAdapter.Fill(this.edit_stanok1.typename);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "edit_stanok1.stanky". При необходимости она может быть перемещена или удалена.
            this.stankyTableAdapter.Fill(this.edit_stanok1.stanky);

        }

        private void end_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridView1.BeginEdit(true);
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

        private void save_to_base_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stankyBindingSource.EndEdit();
            this.stankyTableAdapter.Update(this.edit_stanok1.stanky);
            this.stankyTableAdapter.Fill(this.edit_stanok1.stanky);
        }

        private void load_from_base_Click(object sender, EventArgs e)
        {
            try
            {
                this.stankyBindingSource.EndEdit();
            }
            catch (Exception)
            {
            }
            this.stankyTableAdapter.Fill(this.edit_stanok1.stanky);
        }

        private void help_button_Click(object sender, EventArgs e)
        {
            Commands.help_start.start();
        }
    }
}
