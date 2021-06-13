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
    public partial class item_form : Form
    {
        public item_form()
        {
            InitializeComponent();
        }

        private void item_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "editor_main.names". При необходимости она может быть перемещена или удалена.
            this.namesTableAdapter.Fill(this.editor_main.names);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mp_view_c.item_view_mp". При необходимости она может быть перемещена или удалена.
            this.item_view_mpTableAdapter.Fill(this.mp_view_c.item_view_mp);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "item_datasetMP.main". При необходимости она может быть перемещена или удалена.
            this.mainTableAdapter1.Fill(this.item_datasetMP.main);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "editor_main.main". При необходимости она может быть перемещена или удалена.
            this.mainTableAdapter.Fill(this.editor_main.main);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "journal.m_p_journal". При необходимости она может быть перемещена или удалена.
            this.m_p_journalTableAdapter.Fill(this.journal.m_p_journal);
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rotary_technologyDataSet.main_view". При необходимости она может быть перемещена или удалена.
            this.main_viewTableAdapter.Fill(this.rotary_technologyDataSet.main_view);
            
            mainviewBindingSource.Filter = "`Индекс в MAIN` = '" + Properties.Settings.Default.for_item_form + "'";
            mainBindingSource.Filter = "`Номер П/П` = '" + Properties.Settings.Default.for_item_form + "'";
            mpjournalBindingSource.Filter = "index_part = '" + Properties.Settings.Default.for_item_form + "'";
            itemviewmpBindingSource.Filter = "Name = '" + dataGridView1.Rows[0].Cells[15].Value + "'";
            namesBindingSource.Filter = "idnames = '" + dataGridView1.Rows[0].Cells[15].Value + "'";
            label1.Text = dataGridView5.Rows[0].Cells[5].Value + " / " + dataGridView5.Rows[0].Cells[6].Value;
            label2.Text = dataGridView5.Rows[0].Cells[7].Value + " / " + dataGridView5.Rows[0].Cells[8].Value;
            label3.Text = dataGridView5.Rows[0].Cells[3].Value + " / " + dataGridView5.Rows[0].Cells[4].Value;
            label4.Text = dataGridView3.Rows[0].Cells[5].Value.ToString();
            
            // Загрузка параметров

            if ((int)dataGridView3.Rows[0].Cells[1].Value == 1)
            {
                inwork_button.Enabled = false;
                to_warehouse_button.Enabled = false;
            }
            if ((int)dataGridView3.Rows[0].Cells[1].Value == 2)
            {
                inwork_button.Enabled = false;
                peretochka_button.Enabled = false;
                spisat_button.Enabled = false;
            }
            if ((int)dataGridView3.Rows[0].Cells[1].Value == 3)
            {
                peretochka_button.Enabled = false;
                spisat_button.Enabled = false;
                to_warehouse_button.Enabled = false;
            }
            if ((int)dataGridView3.Rows[0].Cells[1].Value == 4)
            {
                inwork_button.Enabled = false;
                peretochka_button.Enabled = false;
                spisat_button.Enabled = false;
                to_warehouse_button.Enabled = false;
            }
            dataGridView2.Sort(dataGridView2.Columns[3], ListSortDirection.Descending);
            
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void peretochka_button_Click(object sender, EventArgs e)
        {
            if (comments_box.Text != "" && comments_box.Text != " ")
            {
                this.m_p_journalTableAdapter.Insert((int)dataGridView1.Rows[0].Cells[13].Value + 1, (int)dataGridView1.Rows[0].Cells[14].Value, 2, "Отправлен в переточку   - фактический размер    = " + dataGridView1.Rows[0].Cells[8].Value + ". Причина: " + comments_box.Text, DateTime.Today);
                this.dataGridView3.Rows[0].Cells[1].Value = 2;
                this.dataGridView3.Rows[0].Cells[5].Value = (int)this.dataGridView3.Rows[0].Cells[5].Value + 1;
                this.dataGridView3.Rows[0].Cells[3].Value = DateTime.Today;
                this.Validate();
                this.mainBindingSource.EndEdit();
                this.mainTableAdapter.Update(this.editor_main.main);
                this.Close();
            }
            else
            {
                MessageBox.Show("Не введён комментарий", "Шерлок", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void inwork_button_Click(object sender, EventArgs e)
        {
            try
            {
                this.m_p_journalTableAdapter.Insert((int)dataGridView1.Rows[0].Cells[13].Value + 1, (int)dataGridView1.Rows[0].Cells[14].Value, 1, "Отправлен в работу      - фактический размер    = " + dataGridView3.Rows[0].Cells[2].Value, DateTime.Today);
                if ((int)dataGridView3.Rows[0].Cells[1].Value == 2) this.dataGridView3.Rows[0].Cells[3].Value = DateTime.Today;
                this.dataGridView3.Rows[0].Cells[1].Value = 1;
                this.dataGridView3.Rows[0].Cells[6].Value = DateTime.Today;
                //this.dataGridView3.Rows[0].Cells[2].Value = double.Parse(comments_box.Text);
                this.Validate();
                this.mainBindingSource.EndEdit();
                this.mainTableAdapter.Update(this.editor_main.main);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Неизвестная ошибка", "Шерлок", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void spisat_button_Click(object sender, EventArgs e)
        {
            if (comments_box.Text != "" && comments_box.Text != " ")
            {
                this.m_p_journalTableAdapter.Insert((int)dataGridView1.Rows[0].Cells[13].Value + 1, (int)dataGridView1.Rows[0].Cells[14].Value, 4, "Отправлен на списание   - фактический размер    = " + dataGridView1.Rows[0].Cells[8].Value + ". Причина: " + comments_box.Text, DateTime.Today);
                this.dataGridView3.Rows[0].Cells[1].Value = 4;
                this.dataGridView3.Rows[0].Cells[4].Value = DateTime.Today;
                this.Validate();
                this.mainBindingSource.EndEdit();
                this.mainTableAdapter.Update(this.editor_main.main);
                this.Close();
            }
            else
            {
                MessageBox.Show("Не введён комментарий", "Шерлок", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void to_warehouse_button_Click(object sender, EventArgs e)
        {
            if (comments_box.Text != "")
            {
                try
                {
                    this.m_p_journalTableAdapter.Insert((int)dataGridView1.Rows[0].Cells[13].Value + 1, (int)dataGridView1.Rows[0].Cells[14].Value, 3, "Отправлен на склад      - фактический размер    = " + comments_box.Text, DateTime.Today);
                    if ((int)dataGridView3.Rows[0].Cells[1].Value == 2) this.dataGridView3.Rows[0].Cells[3].Value = DateTime.Today;
                    this.dataGridView3.Rows[0].Cells[1].Value = 3;
                    this.dataGridView3.Rows[0].Cells[2].Value = double.Parse(comments_box.Text);
                    this.Validate();
                    this.mainBindingSource.EndEdit();
                    this.mainTableAdapter.Update(this.editor_main.main);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка ввода данных (Пример ввода: 25,4)", "Шерлок", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Не введен фактический размер", "Шерлок", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView2_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView2.Columns[2].Width == 770)
            {
                groupBox2.Size = new Size(1715, 373);
                dataGridView2.Size = new Size(1700, 342);
                dataGridView2.Columns[2].Width = 1530;
            }
            else
            {
                groupBox2.Size = new Size(955, 294);
                dataGridView2.Size = new Size(940, 266);
                dataGridView2.Columns[2].Width = 770;
            }
        }

        private void openfile_button_Click(object sender, EventArgs e)
        {
            try
            {
                string commandText = dataGridView5.Rows[0].Cells[10].Value.ToString();
                var proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = commandText;
                proc.StartInfo.UseShellExecute = true;
                proc.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Чертеж отсутствует", "Шерлок", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
