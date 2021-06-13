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
    public partial class edit_main : Form
    {
        int[] y = new int[2];

        private DateTimePicker dtp = new DateTimePicker();

        public edit_main()
        {
            InitializeComponent();
        }

        private void edit_main_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "editor_main.stanky". При необходимости она может быть перемещена или удалена.
            this.stankyTableAdapter.Fill(this.editor_main.stanky);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "editor_main.status". При необходимости она может быть перемещена или удалена.
            this.statusTableAdapter.Fill(this.editor_main.status);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "editor_main.type". При необходимости она может быть перемещена или удалена.
            this.typeTableAdapter.Fill(this.editor_main.type);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "editor_main.names". При необходимости она может быть перемещена или удалена.
            this.namesTableAdapter.Fill(this.editor_main.names);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "editor_main.main". При необходимости она может быть перемещена или удалена.
            this.mainTableAdapter.Fill(this.editor_main.main);
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "dd.MM.yyyy";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Ячейка выбора даты ------------------------------------------------------------------------------------------------------
                if (e.ColumnIndex >= 7 && e.ColumnIndex <= 10)
                {
                    //DateTimePicker dtp = new DateTimePicker();
                    dtp.Format = DateTimePickerFormat.Custom;
                    dtp.CustomFormat = "dd.MM.yyyy";

                    if (y[0] != 0 && y[1] != 0)
                    {
                        try
                        {
                            dtp.Value = System.DateTime.Parse(dataGridView1.CurrentCell.Value.ToString());
                            dataGridView1.Controls.Clear();
                            dtp.Visible = false;
                        }
                        catch
                        {
                            dtp.Visible = false;
                        }
                    }

                    try
                    {
                        dtp.Value = System.DateTime.Parse(dataGridView1.CurrentCell.Value.ToString());
                        //dtp.Text = dataGridView1.CurrentCell.Value.ToString();
                        dataGridView1.Controls.Add(dtp);
                        //dtp.Format = DateTimePickerFormat.Short;
                        Rectangle Rectangle1 = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                        dtp.Size = new Size(Rectangle1.Width, Rectangle1.Height);
                        dtp.Location = new Point(Rectangle1.X, Rectangle1.Y);
                        dtp.CloseUp += new EventHandler(dtp_CloseUp);
                        dtp.TextChanged += new EventHandler(dtp_OnTextChange);
                        dtp.ValueChanged += new EventHandler(dtp_OnValueChange);
                        dtp.Visible = true;
                        dtp.Value = System.DateTime.Parse(dataGridView1.CurrentCell.Value.ToString());
                    }
                    catch
                    {
                        dataGridView1.Controls.Add(dtp);
                        Rectangle Rectangle1 = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                        dtp.Size = new Size(Rectangle1.Width, Rectangle1.Height);
                        dtp.Location = new Point(Rectangle1.X, Rectangle1.Y);
                        dtp.CloseUp += new EventHandler(dtp_CloseUp);
                        dtp.TextChanged += new EventHandler(dtp_OnTextChange);
                        dtp.ValueChanged += new EventHandler(dtp_OnValueChange);
                        dtp.Visible = true;
                    }


                }
                else
                {
                    if (y[1] >= 7 && y[1] <= 10 && y[0] != 0)
                    {
                        //DateTimePicker dtp = new DateTimePicker();
                        dtp.Format = DateTimePickerFormat.Custom;
                        dtp.CustomFormat = "dd.MM.yyyy";                        
                        dtp.Value = System.DateTime.Parse(dataGridView1[y[0], y[1]].Value.ToString());
                        dataGridView1.Controls.Clear();
                        dtp.Visible = false;
                    }
                }
                
                if (e.ColumnIndex >= 1 && e.ColumnIndex <= 6 || e.ColumnIndex == 11)
                {
                    dataGridView1.BeginEdit(true);
                }
                y[0] = dataGridView1.CurrentCell.ColumnIndex;
                y[1] = dataGridView1.CurrentRow.Index;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void dtp_OnTextChange(object sender, EventArgs e)
        {
            //DateTimePicker dtp = new DateTimePicker();
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "dd.MM.yyyy";
            //dtp.Text = dtp.Value.ToShortDateString();
            //dtp.Value = System.DateTime.Parse(dtp.Text);

            dataGridView1.CurrentCell.Value = dtp.Value.ToShortDateString();
            //System.Windows.Forms.MessageBox.Show(dtp.Value.ToShortDateString());
            
        }

        void dtp_CloseUp(object sender, EventArgs e)
        {
            //DateTimePicker dtp = new DateTimePicker();
            
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "dd.MM.yyyy";

            //dtp.Value = System.DateTime.Parse(dtp.Text.ToString());

            
            dataGridView1.CurrentCell.Value = dtp.Value.ToShortDateString();
            //System.Windows.Forms.MessageBox.Show(dataGridView1.CurrentCell.Value.ToString());
            dtp.Visible = false;
        }

        private void dtp_OnValueChange(object sender, EventArgs e)
        {
            //DateTimePicker dtp = new DateTimePicker();
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "dd.MM.yyyy";
            dataGridView1.CurrentCell.Value = dtp.Value.ToShortDateString();
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(Convert.ToString(ex));
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

        private void end_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void load_from_base_Click(object sender, EventArgs e)
        {
            this.mainTableAdapter.Fill(this.editor_main.main);
        }

        private void save_to_base_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mainBindingSource.EndEdit();
            this.mainTableAdapter.Update(this.editor_main.main);
            this.mainTableAdapter.Fill(this.editor_main.main);
        }

        private void help_button_Click(object sender, EventArgs e)
        {
            Commands.help_start.start();
        }

        private void button_error_check_Click(object sender, EventArgs e)
        {

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            Forms.edit_main_add_full form = new Forms.edit_main_add_full();
            form.ShowDialog();;
        }

    }
}
