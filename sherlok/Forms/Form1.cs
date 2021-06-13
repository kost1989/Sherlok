using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql;
using DataGridViewAutoFilter;

namespace sherlok.Forms
{
    public partial class Form1 : Form
    {

        #region ПЕРЕМЕННЫЕ

        short iznos_number = 6; // НОМЕР СТОЛБЦА ИЗНОСА
        short status_number = 3; // НОМЕР СТОЛБЦА СТАТУСА
        short exdate_value = 5; // НОМЕР СТОЛБЦА РЕСУРСА В МЕСЯЦ
        short exdate_calculate = 12; // НОМЕР СТОЛБЦА ЭКСПЛУАТАЦИИ В МЕСЯЦ
        Int32 current_table_index = 0; // НОМЕР ТЕКУЩЕЙ СТРОКИ
        bool iznos_timer_lock = false; // БЛОКИРОВКА ИСПОЛЬЗОВАНИЯ ТАЙМЕРА АНИМАЦИИ ПРЕДУПРЕЖДЕНИЯ!
        string iznos_text_value; // СПИСОК МАТРИЦ И ПУАНСОНОВ С ИЗНОСОМ
        
        #endregion

        // ФОРМА

        #region ЗАГРУЗКА ФОРМЫ

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Загрузка параметров ----------------------------------------------------------------------------------

            if (Properties.Settings.Default.paint_status == "1")
            {
                status_button_check.Checked = true;
                статусToolStripMenuItem1.Checked = true;
            }

            if (Properties.Settings.Default.paint_iznos == "1")
            {
                iznos_button_check.Checked = true;
                износToolStripMenuItem1.Checked = true;
            }
            this.Text = "Шерлок - " + Properties.Settings.Default.version;

            // Заливаем таблицу с базой данных ----------------------------------------------------------------------
            fill_table();
            // Автообновление ---------------------------------------------------------------------------------------
            auto_update.Enabled = true;
            progress_au.Enabled = true;

            // Раскраска статусов -----------------------------------------------------------------------------------
            paint_status();
            paint_iznos();
            paint_exdate();
            if (iznos_text_value != "")
            {
                toolStripStatusLabel1.Image = sherlok.Properties.Resources.warning;
                toolStripStatusLabel1.Text = "Есть проблемы";
                toolStripStatusLabel1.ToolTipText = iznos_text_value;
                notify_sherlok.ShowBalloonTip(15, "Шерлок", iznos_text_value, ToolTipIcon.Warning);
            }
            // Оповещаем пользователя о большом износе --------------------------------------------------------------

            // ------------------------------------------------------------------------------------------------------
            Properties.Settings.Default.start = true;
        }

        #endregion

        #region ОБРАБОТКИ СОБЫТИЙ В ФОРМЕ

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                refresh_table();
                if (iznos_text_value != "")
                {
                    toolStripStatusLabel1.Image = sherlok.Properties.Resources.warning;
                    toolStripStatusLabel1.Text = "Присутствует большой износ";
                    toolStripStatusLabel1.ToolTipText = iznos_text_value;
                    notify_sherlok.ShowBalloonTip(15, "Шерлок", iznos_text_value, ToolTipIcon.Warning);
                }
            }

            if (e.KeyCode==Keys.W && e.Control)
            {
                Forms.a form = new Forms.a();
                form.ShowDialog();
            }

            if (e.KeyCode == Keys.A && e.Control)
            {
                Forms.edit_main_add form = new Forms.edit_main_add();
                form.ShowDialog();
            }


            if (e.KeyCode == Keys.Q && e.Control)
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите закрыть программу?", "Шерлок", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes)
                {
                    notify_sherlok.Visible = false;
                    Properties.Settings.Default.start = false;
                    Properties.Settings.Default.Save();
                    Environment.Exit(0);
                }
                else if (dialogResult == DialogResult.No)
                {
                    //MessageBox.Show("Так точно!", "Шерлок", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
               
            }

        }

        #endregion

        // ФУНКЦИИ ОТОБРАЖЕНИЯ ИНФОРМАЦИИ

        #region ЗАКРАСКА СТАТУСА

        private void paint_status()
        {
            if (статусToolStripMenuItem1.Checked == true || status_button_check.Checked == true)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    //dataGridView1.Rows[i].Selected = false;
                            if (dataGridView1.Rows[i].Cells[status_number].Value.ToString().Contains("В работе"))
                            {
                                dataGridView1.Rows[i].Cells[status_number].Style.BackColor = Color.LightGreen;
                                dataGridView1.Rows[i].Cells[status_number].Style.ForeColor = Color.Black;
                                dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(230, 255, 234);
                                
                            }
                            if (dataGridView1.Rows[i].Cells[status_number].Value.ToString().Contains("В переточке"))
                            {
                                dataGridView1.Rows[i].Cells[status_number].Style.BackColor = Color.LightCoral;
                                dataGridView1.Rows[i].Cells[status_number].Style.ForeColor = Color.Black;
                                dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 234, 230);
                            }
                            if (dataGridView1.Rows[i].Cells[status_number].Value.ToString().Contains("На складе"))
                            {
                                dataGridView1.Rows[i].Cells[status_number].Style.BackColor = Color.LightGoldenrodYellow;
                                dataGridView1.Rows[i].Cells[status_number].Style.ForeColor = Color.Black;
                                dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 251, 230);
                            }
                            if (dataGridView1.Rows[i].Cells[status_number].Value.ToString().Contains("Списан"))
                            {
                                dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                            }
                }

            }
            else
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView1.ColumnCount - 1; j++)
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                        {

                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                            dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                        }
                }
            }
        }

        #endregion

        #region ЗАКРАСКА ИЗНОСА

        private void paint_iznos()
        {
            iznos_text_value = "";
            if (износToolStripMenuItem1.Checked == true || iznos_button_check.Checked == true)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                        if (dataGridView1.Rows[i].Cells[iznos_number].Value.ToString() != "")
                        {

                            if ((int)dataGridView1.Rows[i].Cells[iznos_number].Value >= 80)
                            {
                                if (Convert.ToString(dataGridView1.Rows[i].Cells[status_number].Value) != "Списан")
                                {
                                    dataGridView1.Rows[i].Cells[iznos_number].Style.BackColor = Color.FromArgb(255, 0, 0);
                                    dataGridView1.Rows[i].Cells[iznos_number].Style.ForeColor = Color.Yellow;
                                    iznos_text_value += Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) + " №" + Convert.ToString(dataGridView1.Rows[i].Cells[0].Value) + " " + Convert.ToString(dataGridView1.Rows[i].Cells[1].Value) + " - " + Convert.ToString(dataGridView1.Rows[i].Cells[6].Value) + "%" + '\n';
                                    if (iznos_timer_lock == false) timer_warning_iznos.Enabled = true;
                                }
                            }
                            if ((int)dataGridView1.Rows[i].Cells[iznos_number].Value >= (double)65.0 && (int)dataGridView1.Rows[i].Cells[iznos_number].Value < 80)
                            {
                                if (Convert.ToString(dataGridView1.Rows[i].Cells[status_number].Value) != "Списан")
                                {
                                    dataGridView1.Rows[i].Cells[iznos_number].Style.BackColor = Color.FromArgb(222, 98, 35);
                                    dataGridView1.Rows[i].Cells[iznos_number].Style.ForeColor = Color.Yellow;
                                    iznos_text_value += Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) + " №" + Convert.ToString(dataGridView1.Rows[i].Cells[0].Value) + " " + Convert.ToString(dataGridView1.Rows[i].Cells[1].Value) + " - " + Convert.ToString(dataGridView1.Rows[i].Cells[6].Value) + "%" + '\n';
                                    if (iznos_timer_lock == false) timer_warning_iznos.Enabled = true;
                                }
                            }
                            if ((int)dataGridView1.Rows[i].Cells[iznos_number].Value >= 50 && (int)dataGridView1.Rows[i].Cells[iznos_number].Value < 65)
                            {
                                if (Convert.ToString(dataGridView1.Rows[i].Cells[status_number].Value) != "Списан")
                                {
                                    dataGridView1.Rows[i].Cells[iznos_number].Style.BackColor = Color.FromArgb(227, 217, 23);
                                    dataGridView1.Rows[i].Cells[iznos_number].Style.ForeColor = Color.Black;
                                    iznos_text_value += Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) + " №" + Convert.ToString(dataGridView1.Rows[i].Cells[0].Value) + " " + Convert.ToString(dataGridView1.Rows[i].Cells[1].Value) + " - " + Convert.ToString(dataGridView1.Rows[i].Cells[6].Value) + "%" + '\n';
                                    if (iznos_timer_lock == false) timer_warning_iznos.Enabled = true;
                                }
                            }
                        }
                }
            }
        }

        #endregion

        #region ЗАКРАСКА ЭКСПЛУАТАЦИИ

        private void paint_exdate()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                if (dataGridView1.Rows[i].Cells[exdate_calculate].Value.ToString() != "" && dataGridView1.Rows[i].Cells[exdate_value].Value.ToString() != "")
                {
                    

                    if ((double.Parse(dataGridView1.Rows[i].Cells[exdate_value].Value.ToString()) - double.Parse(dataGridView1.Rows[i].Cells[exdate_calculate].Value.ToString())) >= 0.75 && (((double.Parse(dataGridView1.Rows[i].Cells[exdate_value].Value.ToString()) - double.Parse(dataGridView1.Rows[i].Cells[exdate_calculate].Value.ToString())) <= 1)))
                    {
                        if (Convert.ToString(dataGridView1.Rows[i].Cells[status_number].Value) != "Списан")
                        {
                            dataGridView1.Rows[i].Cells[exdate_calculate].Style.BackColor = Color.FromArgb(227, 217, 23);
                            dataGridView1.Rows[i].Cells[exdate_calculate].Style.ForeColor = Color.Black;
                            iznos_text_value += Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) + " №" + Convert.ToString(dataGridView1.Rows[i].Cells[0].Value) + " " + Convert.ToString(dataGridView1.Rows[i].Cells[1].Value) + " -  Осталось " + Math.Round((double.Parse(dataGridView1.Rows[i].Cells[exdate_value].Value.ToString()) - double.Parse(dataGridView1.Rows[i].Cells[exdate_calculate].Value.ToString())), 1) + " мес." + '\n';
                            //if (iznos_timer_lock == false) timer_warning_iznos.Enabled = true;
                        }
                    }
                    if ((double.Parse(dataGridView1.Rows[i].Cells[exdate_value].Value.ToString()) - double.Parse(dataGridView1.Rows[i].Cells[exdate_calculate].Value.ToString())) >= 0.5 && (((double.Parse(dataGridView1.Rows[i].Cells[exdate_value].Value.ToString()) - double.Parse(dataGridView1.Rows[i].Cells[exdate_calculate].Value.ToString())) < 0.75)))
                    {
                        if (Convert.ToString(dataGridView1.Rows[i].Cells[status_number].Value) != "Списан")
                        {
                            dataGridView1.Rows[i].Cells[exdate_calculate].Style.BackColor = Color.FromArgb(222, 98, 35);
                            dataGridView1.Rows[i].Cells[exdate_calculate].Style.ForeColor = Color.Yellow;
                            iznos_text_value += Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) + " №" + Convert.ToString(dataGridView1.Rows[i].Cells[0].Value) + " " + Convert.ToString(dataGridView1.Rows[i].Cells[1].Value) + " -  Осталось " + Math.Round((double.Parse(dataGridView1.Rows[i].Cells[exdate_value].Value.ToString()) - double.Parse(dataGridView1.Rows[i].Cells[exdate_calculate].Value.ToString())), 1) + " мес." + '\n';
                            //if (iznos_timer_lock == false) timer_warning_iznos.Enabled = true;
                        }
                    }
                    if ((double.Parse(dataGridView1.Rows[i].Cells[exdate_value].Value.ToString()) - double.Parse(dataGridView1.Rows[i].Cells[exdate_calculate].Value.ToString())) < 0.5)
                    {
                        if (Convert.ToString(dataGridView1.Rows[i].Cells[status_number].Value) != "Списан")
                        {
                            dataGridView1.Rows[i].Cells[exdate_calculate].Style.BackColor = Color.FromArgb(255, 0, 0);
                            dataGridView1.Rows[i].Cells[exdate_calculate].Style.ForeColor = Color.Yellow;
                            iznos_text_value += Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) + " №" + Convert.ToString(dataGridView1.Rows[i].Cells[0].Value) + " " + Convert.ToString(dataGridView1.Rows[i].Cells[1].Value) + " -  Осталось " + Math.Round((double.Parse(dataGridView1.Rows[i].Cells[exdate_value].Value.ToString()) - double.Parse(dataGridView1.Rows[i].Cells[exdate_calculate].Value.ToString())), 1) + " мес." + '\n';
                            //if (iznos_timer_lock == false) timer_warning_iznos.Enabled = true;
                        }
                    }
                }
            }
        }

        #endregion

        #region ЗАПОЛНЕНИЕ ТАБЛИЦЫ ФОРМ ИЗ БАЗЫ ДАННЫХ MySQL

        private void fill_table()
        {
            Properties.Settings.Default.refreshing = true;
            // Запоминаем положение курсора =========================================================================
            int[] y = new int[2];
            try
            {
                y[0] = dataGridView1.CurrentCell.ColumnIndex;
                y[1] = dataGridView1.CurrentRow.Index;
            }
            catch
            {
            }

            // Заполняем таблицу ====================================================================================
            try
            {
                this.main_viewTableAdapter.Fill(this.rotary_technologyDataSet.main_view);
            }
            catch (Exception)
            {
                MessageBox.Show("Отсутствует соединение с базой", "Шерлок", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Возвращаем положение курсора =========================================================================
            try
            {
                this.dataGridView1.CurrentCell = this.dataGridView1[y[0], current_table_index];
            }
            catch
            {
            }
            Properties.Settings.Default.refreshing = false;
        }

        #endregion

        #region ОБНОВЛЕНИЕ ТАБЛИЦЫ

        public void refresh_table()
        {
            if (auto_update.Enabled == true)
            {
                auto_update.Enabled = false;
                fill_table();
                paint_iznos();
                paint_status();
                paint_exdate();
                toolStripProgressBar1.Value = 0;
                auto_update.Enabled = true;
            }
            else
            {
                fill_table();
                paint_iznos();
                paint_status();
                paint_exdate();
                toolStripProgressBar1.Value = 0;
            }
        }

        #endregion

        #region ЭЛЕМЕНТЫ УПРАВЛЕНИЯ ТАБЛИЦОЙ БАЗЫ ДАННЫХ

        private void dataGridView1_BindingContextChanged(object sender, EventArgs e)
        {
            dataGridView1.BindingContextChanged += new EventHandler(dataGridView1_BindingContextChanged);
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (Properties.Settings.Default.start == true && Properties.Settings.Default.refreshing == false) refresh_table();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Properties.Settings.Default.for_item_form = (int)dataGridView1.CurrentRow.Cells[14].Value;
            Forms.item_form form = new Forms.item_form();
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            current_table_index = dataGridView1.CurrentRow.Index;
        }

        #endregion

        // ТАЙМЕРЫ

        #region ТАЙМЕР АВТОМАТИЧЕСКОГО ОБНОВЛЕНИЯ ДАННЫХ В ТАБЛИЦЕ

        private void auto_update_Tick(object sender, EventArgs e)
        {
            progress_au.Enabled = false;
            fill_table();
            // Окраска таблицы ======================================================================================
            // Статус -----------------------------------------------------------------------------------------------
            paint_status();
            // Износ ------------------------------------------------------------------------------------------------
            paint_iznos();
            // Месяцы эксплуатации ----------------------------------------------------------------------------------
            paint_exdate();
            // Обнуление прогрес бара -------------------------------------------------------------------------------
            toolStripProgressBar1.Value = 0;
            progress_au.Enabled = true;
            
        }

        #endregion

        #region ТАЙМЕР ОБНОВЛЕНИЯ PROGRESS BAR

        private void progress_au_Tick(object sender, EventArgs e)
        {
            if (toolStripProgressBar1.Value < 59) toolStripProgressBar1.Value++;
        }

        #endregion

        #region ТАЙМЕР ПОКАЗА ИЗНОСА В ОБЛАСТИ УВЕДОМЛЕНИЙ КАЖДЫЙ ЧАС

        private void timer_warning_iznos_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Image = sherlok.Properties.Resources.warning;
            toolStripStatusLabel1.Text = "Присутствует большой износ";
            toolStripStatusLabel1.ToolTipText = iznos_text_value;
            notify_sherlok.ShowBalloonTip(15, "Шерлок", iznos_text_value, ToolTipIcon.Warning);
            iznos_timer_lock = false;   
        }

        #endregion

        // РЕАКЦИИ НА СОБЫТИИ

        #region РЕАКЦИЯ НА СОБЫТИЕ - Нажатие на шапку таблицы

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            paint_status();
            paint_iznos();
        }

        #endregion

        #region РЕАКЦИЯ НА СОБЫТИЕ - Правай кнопка клавиши мыши в таблице

        private void показатьПозицииНаСкладеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.a form = new Forms.a();
            form.ShowDialog();
        }

        private void статусToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.for_item_form = (int)dataGridView1.CurrentRow.Cells[14].Value;
            Forms.item_form form = new Forms.item_form();
            form.ShowDialog();
        }

        #endregion

        // КНОПКИ

        #region КНОПКИ НА ОСНОВНОЙ ПАНЕЛИ

        private void refresh_button_Click(object sender, EventArgs e)
        {
            refresh_table();
            if (iznos_text_value != "")
            {
                toolStripStatusLabel1.Image = sherlok.Properties.Resources.warning;
                toolStripStatusLabel1.Text = "Присутствует большой износ";
                toolStripStatusLabel1.ToolTipText = iznos_text_value;
                notify_sherlok.ShowBalloonTip(15, "Шерлок", iznos_text_value, ToolTipIcon.Warning);
            }
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            auto_update.Enabled = false;
            progress_au.Enabled = false;
            //toolStripProgressBar1.Value = 0;

        }

        private void start_autoupdate_Click(object sender, EventArgs e)
        {
            auto_update.Enabled = true;
            progress_au.Enabled = true;
            //toolStripProgressBar1.Value = 0;
        }

        private void end_button_Click(object sender, EventArgs e)
        {
            notify_sherlok.Visible = false;
            Properties.Settings.Default.start = false;
            Properties.Settings.Default.Save();
            Environment.Exit(0);
        }

        private void status_button_check_Click(object sender, EventArgs e)
        {
            if (status_button_check.Checked == false)
            {
                status_button_check.Checked = true;
                статусToolStripMenuItem1.Checked = true;
                Properties.Settings.Default.paint_status = "1";
            }
            else
            {
                status_button_check.Checked = false;
                статусToolStripMenuItem1.Checked = false;
                Properties.Settings.Default.paint_status = "0";
            }


        }

        private void iznos_button_check_Click(object sender, EventArgs e)
        {
            if (iznos_button_check.Checked == false)
            {
                iznos_button_check.Checked = true;
                износToolStripMenuItem1.Checked = true;
                Properties.Settings.Default.paint_iznos = "1";
            }
            else
            {
                iznos_button_check.Checked = false;
                износToolStripMenuItem1.Checked = false;
                Properties.Settings.Default.paint_iznos = "0";
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Commands.calc_start.start();
        }

        private void Добавить_Click(object sender, EventArgs e)
        {
            Forms.edit_main_add form = new Forms.edit_main_add();
            form.ShowDialog();
        }

        private void warehouse_button_Click_1(object sender, EventArgs e)
        {
            Forms.a form = new Forms.a();
            form.ShowDialog();
        }

        #endregion

        #region КНОПКИ НА ВЕРХНЕЙ ПАНЕЛИ

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            Environment.Exit(0);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.AboutBox form = new Forms.AboutBox();
            form.ShowDialog();
        }

        private void таблицаMAINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.edit_main form = new Forms.edit_main();
            form.ShowDialog();
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Commands.help_start.start();
        }

        private void статусToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (статусToolStripMenuItem1.Checked == true)
            {
                status_button_check.Checked = true;
                Properties.Settings.Default.paint_status = "1";
            }
            else
            {
                status_button_check.Checked = false;
                Properties.Settings.Default.paint_status = "0";
            }
        }

        private void износToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (износToolStripMenuItem1.Checked == true)
            {
                iznos_button_check.Checked = true;
                Properties.Settings.Default.paint_iznos = "1";
            }
            else
            {
                iznos_button_check.Checked = false;
                Properties.Settings.Default.paint_iznos = "0";
            }
        }

        private void таблицаСтанковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.edit_stanok form = new Forms.edit_stanok();
            form.ShowDialog();
        }

        private void таблицаМатрицИПуансоновToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.edit_matpuan form = new Forms.edit_matpuan();
            form.ShowDialog();
        }

        #endregion

        #region КОНПКИ НА НИЖНЕЙ ПАНЕЛИ

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(toolStripStatusLabel1.ToolTipText, "Шерлок", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

    }
}
