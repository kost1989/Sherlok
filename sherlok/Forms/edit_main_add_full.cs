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
    public partial class edit_main_add_full : Form
    {

        private DateTimePicker dtp = new DateTimePicker();

        int[] y = new int[2];
        
        public edit_main_add_full()
        {
            InitializeComponent();
        }

        

        private void edit_main_add_full_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rotary_technologyDataSet1.typename". При необходимости она может быть перемещена или удалена.
            this.typenameTableAdapter.Fill(this.rotary_technologyDataSet1.typename);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rotary_technologyDataSet1.type". При необходимости она может быть перемещена или удалена.
            this.typeTableAdapter.Fill(this.rotary_technologyDataSet1.type);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rotary_technologyDataSet1.status". При необходимости она может быть перемещена или удалена.
            this.statusTableAdapter.Fill(this.rotary_technologyDataSet1.status);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rotary_technologyDataSet1.stanky". При необходимости она может быть перемещена или удалена.
            this.stankyTableAdapter.Fill(this.rotary_technologyDataSet1.stanky);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rotary_technologyDataSet1.names". При необходимости она может быть перемещена или удалена.
            this.namesTableAdapter.Fill(this.rotary_technologyDataSet1.names);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rotary_technologyDataSet1.main". При необходимости она может быть перемещена или удалена.
            this.mainTableAdapter.Fill(this.rotary_technologyDataSet1.main);            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rotary_technologyDataSet1.max_main_index". При необходимости она может быть перемещена или удалена.
            this.max_main_indexTableAdapter.Fill(this.rotary_technologyDataSet1.max_main_index);


        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Ячейка выбора даты ------------------------------------------------------------------------------------------------------
                if (e.ColumnIndex >= 8 && e.ColumnIndex <= 13)
                {
                    //DateTimePicker dtp = new DateTimePicker();
                    dtp.Format = DateTimePickerFormat.Custom;
                    dtp.CustomFormat = "dd.MM.yyyy";

                    if (y[0] != 0 && y[1] != 0)
                    {
                        try
                        {
                            dtp.Value = System.DateTime.Parse(dataGridView2.CurrentCell.Value.ToString());
                            dataGridView2.Controls.Clear();
                            dtp.Visible = false;
                        }
                        catch
                        {
                            dtp.Visible = false;
                        }
                    }
                    try
                    {
                        dtp.Value = System.DateTime.Parse(dataGridView2.CurrentCell.Value.ToString());
                        dataGridView2.Controls.Add(dtp);
                        //dtp.Format = DateTimePickerFormat.Short;
                        Rectangle Rectangle1 = dataGridView2.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                        dtp.Size = new Size(Rectangle1.Width, Rectangle1.Height);
                        dtp.Location = new Point(Rectangle1.X, Rectangle1.Y);
                        dtp.CloseUp += new EventHandler(dtp_CloseUp);
                        dtp.TextChanged += new EventHandler(dtp_OnTextChange);
                        dtp.ValueChanged += new EventHandler(dtp_OnValueChange);
                        dtp.Visible = true;
                        dtp.Value = System.DateTime.Parse(dataGridView2.CurrentCell.Value.ToString());
                    }
                    catch
                    {
                        dataGridView2.Controls.Add(dtp);
                        Rectangle Rectangle1 = dataGridView2.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
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
                    if (y[1] >= 8 && y[1] <= 13 && y[0] != 0)
                    {
                        dtp.Format = DateTimePickerFormat.Custom;
                        dtp.CustomFormat = "dd.MM.yyyy";
                        dtp.Value = System.DateTime.Parse(dataGridView2[y[0], y[1]].Value.ToString());
                        dataGridView2.Controls.Clear();
                        dtp.Visible = false;
                    }
                }

                if (e.ColumnIndex >= 1 && e.ColumnIndex <= 5)
                {
                    dataGridView2.BeginEdit(true);
                }
                y[0] = dataGridView2.CurrentCell.ColumnIndex;
                y[1] = dataGridView2.CurrentRow.Index;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void dtp_OnTextChange(object sender, EventArgs e)
        {
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "dd.MM.yyyy";
            dataGridView2.CurrentCell.Value = dtp.Value.ToShortDateString();
        }

        void dtp_CloseUp(object sender, EventArgs e)
        {
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "dd.MM.yyyy";
            dataGridView2.CurrentCell.Value = dtp.Value.ToShortDateString();
            dtp.Visible = false;
        }

        private void dtp_OnValueChange(object sender, EventArgs e)
        {
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "dd.MM.yyyy";
            dataGridView2.CurrentCell.Value = dtp.Value.ToShortDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int indx = (int)dataGridView1.Rows[0].Cells[0].Value;
                int nam = (int)dataGridView2.Rows[0].Cells[0].Value;
                int stat = (int)dataGridView2.Rows[0].Cells[2].Value;
                int stan = (int)dataGridView2.Rows[0].Cells[3].Value;
                int perm = int.Parse(dataGridView2.Rows[0].Cells[6].Value.ToString());
                if (dataGridView2.Rows[0].Cells[10].Value == null)
                {
                    this.mainTableAdapter.Insert(++indx, nam, dataGridView2.Rows[0].Cells[1].Value.ToString(), 1, stat, stan, double.Parse(dataGridView2.Rows[0].Cells[4].Value.ToString()), DateTime.Parse(dataGridView2.Rows[0].Cells[8].Value.ToString()), null, perm, DateTime.Parse(dataGridView2.Rows[0].Cells[12].Value.ToString()));
                }
                else
                {
                    this.mainTableAdapter.Insert(++indx, nam, dataGridView2.Rows[0].Cells[1].Value.ToString(), 1, stat, stan, double.Parse(dataGridView2.Rows[0].Cells[4].Value.ToString()), DateTime.Parse(dataGridView2.Rows[0].Cells[8].Value.ToString()), DateTime.Parse(dataGridView2.Rows[0].Cells[10].Value.ToString()), perm, DateTime.Parse(dataGridView2.Rows[0].Cells[12].Value.ToString()));
                }

                try
                {
                    int perp = int.Parse(dataGridView2.Rows[0].Cells[7].Value.ToString());
                    if (dataGridView2.Rows[0].Cells[11].Value == null)
                    {
                        this.mainTableAdapter.Insert(++indx, nam, dataGridView2.Rows[0].Cells[1].Value.ToString(), 2, stat, stan, double.Parse(dataGridView2.Rows[0].Cells[5].Value.ToString()), DateTime.Parse(dataGridView2.Rows[0].Cells[9].Value.ToString()), null, perp, DateTime.Parse(dataGridView2.Rows[0].Cells[13].Value.ToString()));
                    }
                    else
                    {
                        this.mainTableAdapter.Insert(++indx, nam, dataGridView2.Rows[0].Cells[1].Value.ToString(), 2, stat, stan, double.Parse(dataGridView2.Rows[0].Cells[5].Value.ToString()), DateTime.Parse(dataGridView2.Rows[0].Cells[9].Value.ToString()), DateTime.Parse(dataGridView2.Rows[0].Cells[11].Value.ToString()), perp, DateTime.Parse(dataGridView2.Rows[0].Cells[13].Value.ToString()));
                    }
                }
                catch (Exception)
                {

                }

                this.max_main_indexTableAdapter.Fill(this.rotary_technologyDataSet1.max_main_index);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Некорректный ввод " + ex, "Шерлок", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
