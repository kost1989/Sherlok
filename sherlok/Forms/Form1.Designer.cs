namespace sherlok.Forms
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.probel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.probel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.окраскаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статусToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.износToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.базаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаMAINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаСтанковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаМатрицИПуансоновToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.номерDataGridViewTextBoxColumn1 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn1 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.типDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.статусDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.ресурсударыDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ресурсмесяцыDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Износ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.станокDataGridViewTextBoxColumn1 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.типСтанкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказанDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.переточкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Эксплуатация = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Индекс = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.статусToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьПозицииНаСкладеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rotary_technologyDataSet = new sherlok.rotary_technologyDataSet();
            this.auto_update = new System.Windows.Forms.Timer(this.components);
            this.progress_au = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Добавить = new System.Windows.Forms.ToolStripButton();
            this.warehouse_button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.status_button_check = new System.Windows.Forms.ToolStripButton();
            this.iznos_button_check = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.start_autoupdate = new System.Windows.Forms.ToolStripButton();
            this.refresh_button = new System.Windows.Forms.ToolStripButton();
            this.stop_button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.calculator_button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.end_button = new System.Windows.Forms.ToolStripButton();
            this.notify_sherlok = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer_warning_iznos = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewAutoFilterTextBoxColumn1 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn2 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn3 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn4 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn5 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn6 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn7 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn8 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn9 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn10 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn11 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn12 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn13 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn14 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn15 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn16 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn17 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn18 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn19 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn20 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn21 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn22 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn23 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn24 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn25 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn26 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn27 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn28 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn29 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn30 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn31 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn32 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn33 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn34 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn35 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn36 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn37 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn38 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn39 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn40 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn41 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn42 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn43 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn44 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn45 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn46 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn47 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn48 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn49 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn50 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn51 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn52 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn53 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn54 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn55 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn56 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn57 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn58 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn59 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn60 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn61 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn62 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn63 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn64 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn65 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn66 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn67 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn68 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn69 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn70 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn71 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn72 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn73 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn74 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn75 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn76 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn77 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn78 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn79 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn80 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn81 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn82 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn83 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn84 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn85 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn86 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn87 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn88 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn89 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn90 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn91 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn92 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn93 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn94 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn95 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Тип = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Статус = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ресурсударыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ресурсмесяцыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.станокDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Номер = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.main_viewTableAdapter = new sherlok.rotary_technologyDataSetTableAdapters.main_viewTableAdapter();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotary_technologyDataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.probel2,
            this.probel1,
            this.toolStripStatusLabel2,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 897);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.ShowItemToolTips = true;
            this.statusStrip1.Size = new System.Drawing.Size(1733, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.AutoToolTip = true;
            this.toolStripStatusLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripStatusLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(300, 17);
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // probel2
            // 
            this.probel2.AutoSize = false;
            this.probel2.Name = "probel2";
            this.probel2.Size = new System.Drawing.Size(1097, 17);
            this.probel2.Text = "                                                                ";
            // 
            // probel1
            // 
            this.probel1.Name = "probel1";
            this.probel1.Size = new System.Drawing.Size(10, 17);
            this.probel1.Text = "|";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel2.Text = "Обновление базы:";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Maximum = 59;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(214, 16);
            this.toolStripProgressBar1.Step = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.видToolStripMenuItem,
            this.управлениеToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1733, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = global::sherlok.Properties.Resources.cross16;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.окраскаToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // окраскаToolStripMenuItem
            // 
            this.окраскаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.статусToolStripMenuItem1,
            this.износToolStripMenuItem1});
            this.окраскаToolStripMenuItem.Image = global::sherlok.Properties.Resources.bullet_picture;
            this.окраскаToolStripMenuItem.Name = "окраскаToolStripMenuItem";
            this.окраскаToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.окраскаToolStripMenuItem.Text = "Окраска";
            // 
            // статусToolStripMenuItem1
            // 
            this.статусToolStripMenuItem1.CheckOnClick = true;
            this.статусToolStripMenuItem1.Image = global::sherlok.Properties.Resources.address_bar_green;
            this.статусToolStripMenuItem1.Name = "статусToolStripMenuItem1";
            this.статусToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.статусToolStripMenuItem1.Text = "Статус";
            this.статусToolStripMenuItem1.Click += new System.EventHandler(this.статусToolStripMenuItem1_Click);
            // 
            // износToolStripMenuItem1
            // 
            this.износToolStripMenuItem1.CheckOnClick = true;
            this.износToolStripMenuItem1.Image = global::sherlok.Properties.Resources.address_bar_red;
            this.износToolStripMenuItem1.Name = "износToolStripMenuItem1";
            this.износToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.износToolStripMenuItem1.Text = "Износ";
            this.износToolStripMenuItem1.Click += new System.EventHandler(this.износToolStripMenuItem1_Click);
            // 
            // управлениеToolStripMenuItem
            // 
            this.управлениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.базаДанныхToolStripMenuItem});
            this.управлениеToolStripMenuItem.Name = "управлениеToolStripMenuItem";
            this.управлениеToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.управлениеToolStripMenuItem.Text = "Управление";
            // 
            // базаДанныхToolStripMenuItem
            // 
            this.базаДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицаMAINToolStripMenuItem,
            this.таблицаСтанковToolStripMenuItem,
            this.таблицаМатрицИПуансоновToolStripMenuItem});
            this.базаДанныхToolStripMenuItem.Image = global::sherlok.Properties.Resources.application_view_detail;
            this.базаДанныхToolStripMenuItem.Name = "базаДанныхToolStripMenuItem";
            this.базаДанныхToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.базаДанныхToolStripMenuItem.Text = "База данных";
            // 
            // таблицаMAINToolStripMenuItem
            // 
            this.таблицаMAINToolStripMenuItem.Name = "таблицаMAINToolStripMenuItem";
            this.таблицаMAINToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.таблицаMAINToolStripMenuItem.Text = "Главная таблица";
            this.таблицаMAINToolStripMenuItem.Click += new System.EventHandler(this.таблицаMAINToolStripMenuItem_Click);
            // 
            // таблицаСтанковToolStripMenuItem
            // 
            this.таблицаСтанковToolStripMenuItem.Name = "таблицаСтанковToolStripMenuItem";
            this.таблицаСтанковToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.таблицаСтанковToolStripMenuItem.Text = "Таблица станков";
            this.таблицаСтанковToolStripMenuItem.Click += new System.EventHandler(this.таблицаСтанковToolStripMenuItem_Click);
            // 
            // таблицаМатрицИПуансоновToolStripMenuItem
            // 
            this.таблицаМатрицИПуансоновToolStripMenuItem.Name = "таблицаМатрицИПуансоновToolStripMenuItem";
            this.таблицаМатрицИПуансоновToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.таблицаМатрицИПуансоновToolStripMenuItem.Text = "Таблица матриц и пуансонов";
            this.таблицаМатрицИПуансоновToolStripMenuItem.Click += new System.EventHandler(this.таблицаМатрицИПуансоновToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Enabled = false;
            this.помощьToolStripMenuItem.Image = global::sherlok.Properties.Resources.help;
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = global::sherlok.Properties.Resources.bubble_16;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерDataGridViewTextBoxColumn1,
            this.наименованиеDataGridViewTextBoxColumn1,
            this.типDataGridViewTextBoxColumn,
            this.статусDataGridViewTextBoxColumn,
            this.ресурсударыDataGridViewTextBoxColumn1,
            this.ресурсмесяцыDataGridViewTextBoxColumn1,
            this.Износ,
            this.станокDataGridViewTextBoxColumn1,
            this.типСтанкаDataGridViewTextBoxColumn,
            this.заказанDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.переточкаDataGridViewTextBoxColumn,
            this.Эксплуатация,
            this.dataGridViewTextBoxColumn10,
            this.Индекс});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.mainviewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 85);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1733, 809);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.BindingContextChanged += new System.EventHandler(this.dataGridView1_BindingContextChanged);
            // 
            // номерDataGridViewTextBoxColumn1
            // 
            this.номерDataGridViewTextBoxColumn1.DataPropertyName = "Номер";
            this.номерDataGridViewTextBoxColumn1.HeaderText = "Номер";
            this.номерDataGridViewTextBoxColumn1.Name = "номерDataGridViewTextBoxColumn1";
            this.номерDataGridViewTextBoxColumn1.ReadOnly = true;
            this.номерDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // наименованиеDataGridViewTextBoxColumn1
            // 
            this.наименованиеDataGridViewTextBoxColumn1.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn1.FillWeight = 440F;
            this.наименованиеDataGridViewTextBoxColumn1.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn1.Name = "наименованиеDataGridViewTextBoxColumn1";
            this.наименованиеDataGridViewTextBoxColumn1.ReadOnly = true;
            this.наименованиеDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.наименованиеDataGridViewTextBoxColumn1.Width = 440;
            // 
            // типDataGridViewTextBoxColumn
            // 
            this.типDataGridViewTextBoxColumn.DataPropertyName = "Тип";
            this.типDataGridViewTextBoxColumn.FillWeight = 80F;
            this.типDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.типDataGridViewTextBoxColumn.Name = "типDataGridViewTextBoxColumn";
            this.типDataGridViewTextBoxColumn.ReadOnly = true;
            this.типDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.типDataGridViewTextBoxColumn.Width = 80;
            // 
            // статусDataGridViewTextBoxColumn
            // 
            this.статусDataGridViewTextBoxColumn.DataPropertyName = "Статус";
            this.статусDataGridViewTextBoxColumn.FillWeight = 80F;
            this.статусDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.статусDataGridViewTextBoxColumn.Name = "статусDataGridViewTextBoxColumn";
            this.статусDataGridViewTextBoxColumn.ReadOnly = true;
            this.статусDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.статусDataGridViewTextBoxColumn.Width = 80;
            // 
            // ресурсударыDataGridViewTextBoxColumn1
            // 
            this.ресурсударыDataGridViewTextBoxColumn1.DataPropertyName = "Ресурс (удары)";
            this.ресурсударыDataGridViewTextBoxColumn1.HeaderText = "Ресурс (удары)";
            this.ресурсударыDataGridViewTextBoxColumn1.Name = "ресурсударыDataGridViewTextBoxColumn1";
            this.ресурсударыDataGridViewTextBoxColumn1.ReadOnly = true;
            this.ресурсударыDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ресурсударыDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ресурсмесяцыDataGridViewTextBoxColumn1
            // 
            this.ресурсмесяцыDataGridViewTextBoxColumn1.DataPropertyName = "Ресурс (месяцы)";
            this.ресурсмесяцыDataGridViewTextBoxColumn1.HeaderText = "Ресурс (месяцы)";
            this.ресурсмесяцыDataGridViewTextBoxColumn1.Name = "ресурсмесяцыDataGridViewTextBoxColumn1";
            this.ресурсмесяцыDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Износ
            // 
            this.Износ.DataPropertyName = "Рассчитанный износ";
            this.Износ.HeaderText = "Износ";
            this.Износ.Name = "Износ";
            this.Износ.ReadOnly = true;
            this.Износ.Width = 50;
            // 
            // станокDataGridViewTextBoxColumn1
            // 
            this.станокDataGridViewTextBoxColumn1.DataPropertyName = "Станок";
            this.станокDataGridViewTextBoxColumn1.FillWeight = 250F;
            this.станокDataGridViewTextBoxColumn1.HeaderText = "Станок";
            this.станокDataGridViewTextBoxColumn1.Name = "станокDataGridViewTextBoxColumn1";
            this.станокDataGridViewTextBoxColumn1.ReadOnly = true;
            this.станокDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.станокDataGridViewTextBoxColumn1.Width = 250;
            // 
            // типСтанкаDataGridViewTextBoxColumn
            // 
            this.типСтанкаDataGridViewTextBoxColumn.DataPropertyName = "Тип станка";
            this.типСтанкаDataGridViewTextBoxColumn.FillWeight = 120F;
            this.типСтанкаDataGridViewTextBoxColumn.HeaderText = "Тип станка";
            this.типСтанкаDataGridViewTextBoxColumn.Name = "типСтанкаDataGridViewTextBoxColumn";
            this.типСтанкаDataGridViewTextBoxColumn.ReadOnly = true;
            this.типСтанкаDataGridViewTextBoxColumn.Width = 120;
            // 
            // заказанDataGridViewTextBoxColumn
            // 
            this.заказанDataGridViewTextBoxColumn.DataPropertyName = "Заказан";
            this.заказанDataGridViewTextBoxColumn.FillWeight = 70F;
            this.заказанDataGridViewTextBoxColumn.HeaderText = "Заказан";
            this.заказанDataGridViewTextBoxColumn.Name = "заказанDataGridViewTextBoxColumn";
            this.заказанDataGridViewTextBoxColumn.ReadOnly = true;
            this.заказанDataGridViewTextBoxColumn.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Дата ввода в эксплуатацию";
            this.dataGridViewTextBoxColumn3.FillWeight = 80F;
            this.dataGridViewTextBoxColumn3.HeaderText = "В работу";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // переточкаDataGridViewTextBoxColumn
            // 
            this.переточкаDataGridViewTextBoxColumn.DataPropertyName = "Переточка";
            this.переточкаDataGridViewTextBoxColumn.FillWeight = 70F;
            this.переточкаDataGridViewTextBoxColumn.HeaderText = "Переточка";
            this.переточкаDataGridViewTextBoxColumn.Name = "переточкаDataGridViewTextBoxColumn";
            this.переточкаDataGridViewTextBoxColumn.ReadOnly = true;
            this.переточкаDataGridViewTextBoxColumn.Width = 70;
            // 
            // Эксплуатация
            // 
            this.Эксплуатация.DataPropertyName = "Эксплуатация";
            this.Эксплуатация.FillWeight = 90F;
            this.Эксплуатация.HeaderText = "Эксплуатация";
            this.Эксплуатация.Name = "Эксплуатация";
            this.Эксплуатация.ReadOnly = true;
            this.Эксплуатация.Width = 90;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Дата списания";
            this.dataGridViewTextBoxColumn10.FillWeight = 75F;
            this.dataGridViewTextBoxColumn10.HeaderText = "Дата списания";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 75;
            // 
            // Индекс
            // 
            this.Индекс.DataPropertyName = "Индекс в MAIN";
            this.Индекс.HeaderText = "Индекс";
            this.Индекс.Name = "Индекс";
            this.Индекс.ReadOnly = true;
            this.Индекс.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.статусToolStripMenuItem,
            this.показатьПозицииНаСкладеToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(265, 48);
            // 
            // статусToolStripMenuItem
            // 
            this.статусToolStripMenuItem.Image = global::sherlok.Properties.Resources.information16;
            this.статусToolStripMenuItem.Name = "статусToolStripMenuItem";
            this.статусToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.статусToolStripMenuItem.Text = "Информация выбранной позиции";
            this.статусToolStripMenuItem.Click += new System.EventHandler(this.статусToolStripMenuItem_Click);
            // 
            // показатьПозицииНаСкладеToolStripMenuItem
            // 
            this.показатьПозицииНаСкладеToolStripMenuItem.Image = global::sherlok.Properties.Resources.house16;
            this.показатьПозицииНаСкладеToolStripMenuItem.Name = "показатьПозицииНаСкладеToolStripMenuItem";
            this.показатьПозицииНаСкладеToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.показатьПозицииНаСкладеToolStripMenuItem.Text = "Показать позиции на складе";
            this.показатьПозицииНаСкладеToolStripMenuItem.Click += new System.EventHandler(this.показатьПозицииНаСкладеToolStripMenuItem_Click);
            // 
            // mainviewBindingSource
            // 
            this.mainviewBindingSource.DataMember = "main_view";
            this.mainviewBindingSource.DataSource = this.rotary_technologyDataSet;
            // 
            // rotary_technologyDataSet
            // 
            this.rotary_technologyDataSet.DataSetName = "rotary_technologyDataSet";
            this.rotary_technologyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // auto_update
            // 
            this.auto_update.Interval = 60000;
            this.auto_update.Tick += new System.EventHandler(this.auto_update_Tick);
            // 
            // progress_au
            // 
            this.progress_au.Interval = 1000;
            this.progress_au.Tick += new System.EventHandler(this.progress_au_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Добавить,
            this.warehouse_button,
            this.toolStripSeparator4,
            this.status_button_check,
            this.iznos_button_check,
            this.toolStripSeparator2,
            this.start_autoupdate,
            this.refresh_button,
            this.stop_button,
            this.toolStripSeparator3,
            this.calculator_button,
            this.toolStripSeparator1,
            this.end_button});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1733, 54);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Добавить
            // 
            this.Добавить.AutoSize = false;
            this.Добавить.Image = global::sherlok.Properties.Resources.table_add;
            this.Добавить.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Добавить.Name = "Добавить";
            this.Добавить.Size = new System.Drawing.Size(75, 51);
            this.Добавить.Text = "Добавить";
            this.Добавить.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Добавить.ToolTipText = "Добавить новую позицию (Ctrl + A)";
            this.Добавить.Click += new System.EventHandler(this.Добавить_Click);
            // 
            // warehouse_button
            // 
            this.warehouse_button.AutoSize = false;
            this.warehouse_button.Image = global::sherlok.Properties.Resources.house;
            this.warehouse_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.warehouse_button.Name = "warehouse_button";
            this.warehouse_button.Size = new System.Drawing.Size(75, 51);
            this.warehouse_button.Text = "На складе";
            this.warehouse_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.warehouse_button.ToolTipText = "Показать позиции на складе (Ctrl + W)";
            this.warehouse_button.Click += new System.EventHandler(this.warehouse_button_Click_1);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.AutoSize = false;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(20, 39);
            // 
            // status_button_check
            // 
            this.status_button_check.AutoSize = false;
            this.status_button_check.Image = global::sherlok.Properties.Resources.address_bar_green1;
            this.status_button_check.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.status_button_check.Name = "status_button_check";
            this.status_button_check.Size = new System.Drawing.Size(75, 51);
            this.status_button_check.Text = "Статус";
            this.status_button_check.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.status_button_check.ToolTipText = "Окрасить статус";
            this.status_button_check.Click += new System.EventHandler(this.status_button_check_Click);
            // 
            // iznos_button_check
            // 
            this.iznos_button_check.AutoSize = false;
            this.iznos_button_check.Image = global::sherlok.Properties.Resources.address_bar_red1;
            this.iznos_button_check.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.iznos_button_check.Name = "iznos_button_check";
            this.iznos_button_check.Size = new System.Drawing.Size(75, 51);
            this.iznos_button_check.Text = "Износ";
            this.iznos_button_check.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iznos_button_check.ToolTipText = "Окрасить критический износ";
            this.iznos_button_check.Click += new System.EventHandler(this.iznos_button_check_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AutoSize = false;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(20, 39);
            // 
            // start_autoupdate
            // 
            this.start_autoupdate.AutoSize = false;
            this.start_autoupdate.Image = global::sherlok.Properties.Resources.arrow_right;
            this.start_autoupdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.start_autoupdate.Name = "start_autoupdate";
            this.start_autoupdate.Size = new System.Drawing.Size(75, 51);
            this.start_autoupdate.Text = "Запустить";
            this.start_autoupdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.start_autoupdate.ToolTipText = "Запустить автообновление";
            this.start_autoupdate.Click += new System.EventHandler(this.start_autoupdate_Click);
            // 
            // refresh_button
            // 
            this.refresh_button.AutoSize = false;
            this.refresh_button.Image = global::sherlok.Properties.Resources.arrow_refresh;
            this.refresh_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(75, 51);
            this.refresh_button.Text = "Обновить";
            this.refresh_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.refresh_button.ToolTipText = "Обновить таблицу сейчас (F5)";
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // stop_button
            // 
            this.stop_button.AutoSize = false;
            this.stop_button.Image = global::sherlok.Properties.Resources.stop;
            this.stop_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(75, 51);
            this.stop_button.Text = "Остановить";
            this.stop_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.stop_button.ToolTipText = "Остановить автообновление";
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.AutoSize = false;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(20, 39);
            // 
            // calculator_button
            // 
            this.calculator_button.Image = ((System.Drawing.Image)(resources.GetObject("calculator_button.Image")));
            this.calculator_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.calculator_button.Name = "calculator_button";
            this.calculator_button.Size = new System.Drawing.Size(81, 51);
            this.calculator_button.Text = "Калькулятор";
            this.calculator_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.calculator_button.ToolTipText = "Запустить калькулятор";
            this.calculator_button.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(20, 39);
            // 
            // end_button
            // 
            this.end_button.AutoSize = false;
            this.end_button.Image = global::sherlok.Properties.Resources.cross32;
            this.end_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.end_button.Name = "end_button";
            this.end_button.Size = new System.Drawing.Size(75, 51);
            this.end_button.Text = "Выход";
            this.end_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.end_button.ToolTipText = "Выход из программы (Ctrl + Q)";
            this.end_button.Click += new System.EventHandler(this.end_button_Click);
            // 
            // notify_sherlok
            // 
            this.notify_sherlok.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.notify_sherlok.BalloonTipText = "Есть проблемы";
            this.notify_sherlok.BalloonTipTitle = "Шерлок";
            this.notify_sherlok.Icon = ((System.Drawing.Icon)(resources.GetObject("notify_sherlok.Icon")));
            this.notify_sherlok.Text = "Шерлок";
            this.notify_sherlok.Visible = true;
            // 
            // timer_warning_iznos
            // 
            this.timer_warning_iznos.Interval = 3600000;
            this.timer_warning_iznos.Tick += new System.EventHandler(this.timer_warning_iznos_Tick);
            // 
            // dataGridViewAutoFilterTextBoxColumn1
            // 
            this.dataGridViewAutoFilterTextBoxColumn1.DataPropertyName = "Номер";
            this.dataGridViewAutoFilterTextBoxColumn1.HeaderText = "Номер";
            this.dataGridViewAutoFilterTextBoxColumn1.Name = "dataGridViewAutoFilterTextBoxColumn1";
            this.dataGridViewAutoFilterTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn2
            // 
            this.dataGridViewAutoFilterTextBoxColumn2.DataPropertyName = "Наименование";
            this.dataGridViewAutoFilterTextBoxColumn2.FillWeight = 350F;
            this.dataGridViewAutoFilterTextBoxColumn2.HeaderText = "Наименование";
            this.dataGridViewAutoFilterTextBoxColumn2.Name = "dataGridViewAutoFilterTextBoxColumn2";
            this.dataGridViewAutoFilterTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn2.Width = 350;
            // 
            // dataGridViewAutoFilterTextBoxColumn3
            // 
            this.dataGridViewAutoFilterTextBoxColumn3.DataPropertyName = "Тип";
            this.dataGridViewAutoFilterTextBoxColumn3.FillWeight = 80F;
            this.dataGridViewAutoFilterTextBoxColumn3.HeaderText = "Тип";
            this.dataGridViewAutoFilterTextBoxColumn3.Name = "dataGridViewAutoFilterTextBoxColumn3";
            this.dataGridViewAutoFilterTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn3.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn4
            // 
            this.dataGridViewAutoFilterTextBoxColumn4.DataPropertyName = "Статус";
            this.dataGridViewAutoFilterTextBoxColumn4.FillWeight = 80F;
            this.dataGridViewAutoFilterTextBoxColumn4.HeaderText = "Статус";
            this.dataGridViewAutoFilterTextBoxColumn4.Name = "dataGridViewAutoFilterTextBoxColumn4";
            this.dataGridViewAutoFilterTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn4.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn5
            // 
            this.dataGridViewAutoFilterTextBoxColumn5.DataPropertyName = "Станок";
            this.dataGridViewAutoFilterTextBoxColumn5.FillWeight = 150F;
            this.dataGridViewAutoFilterTextBoxColumn5.HeaderText = "Станок";
            this.dataGridViewAutoFilterTextBoxColumn5.Name = "dataGridViewAutoFilterTextBoxColumn5";
            this.dataGridViewAutoFilterTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Тип";
            this.dataGridViewTextBoxColumn1.FillWeight = 80F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn6
            // 
            this.dataGridViewAutoFilterTextBoxColumn6.DataPropertyName = "Номер";
            this.dataGridViewAutoFilterTextBoxColumn6.HeaderText = "Номер";
            this.dataGridViewAutoFilterTextBoxColumn6.Name = "dataGridViewAutoFilterTextBoxColumn6";
            this.dataGridViewAutoFilterTextBoxColumn6.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn7
            // 
            this.dataGridViewAutoFilterTextBoxColumn7.DataPropertyName = "Наименование";
            this.dataGridViewAutoFilterTextBoxColumn7.FillWeight = 350F;
            this.dataGridViewAutoFilterTextBoxColumn7.HeaderText = "Наименование";
            this.dataGridViewAutoFilterTextBoxColumn7.Name = "dataGridViewAutoFilterTextBoxColumn7";
            this.dataGridViewAutoFilterTextBoxColumn7.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn7.Width = 350;
            // 
            // dataGridViewAutoFilterTextBoxColumn8
            // 
            this.dataGridViewAutoFilterTextBoxColumn8.DataPropertyName = "Тип";
            this.dataGridViewAutoFilterTextBoxColumn8.FillWeight = 80F;
            this.dataGridViewAutoFilterTextBoxColumn8.HeaderText = "Тип";
            this.dataGridViewAutoFilterTextBoxColumn8.Name = "dataGridViewAutoFilterTextBoxColumn8";
            this.dataGridViewAutoFilterTextBoxColumn8.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn8.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn9
            // 
            this.dataGridViewAutoFilterTextBoxColumn9.DataPropertyName = "Статус";
            this.dataGridViewAutoFilterTextBoxColumn9.FillWeight = 80F;
            this.dataGridViewAutoFilterTextBoxColumn9.HeaderText = "Статус";
            this.dataGridViewAutoFilterTextBoxColumn9.Name = "dataGridViewAutoFilterTextBoxColumn9";
            this.dataGridViewAutoFilterTextBoxColumn9.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn9.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Статус";
            this.dataGridViewTextBoxColumn2.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Тип станка";
            this.dataGridViewTextBoxColumn4.FillWeight = 120F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Тип станка";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewAutoFilterTextBoxColumn10
            // 
            this.dataGridViewAutoFilterTextBoxColumn10.DataPropertyName = "Станок";
            this.dataGridViewAutoFilterTextBoxColumn10.FillWeight = 150F;
            this.dataGridViewAutoFilterTextBoxColumn10.HeaderText = "Станок";
            this.dataGridViewAutoFilterTextBoxColumn10.Name = "dataGridViewAutoFilterTextBoxColumn10";
            this.dataGridViewAutoFilterTextBoxColumn10.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Износ";
            this.dataGridViewTextBoxColumn5.FillWeight = 50F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Износ";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Переточка";
            this.dataGridViewTextBoxColumn6.FillWeight = 70F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Переточка";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 70;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Заказан";
            this.dataGridViewTextBoxColumn7.FillWeight = 70F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Заказан";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 70;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Дата списания";
            this.dataGridViewTextBoxColumn8.FillWeight = 70F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Дата списания";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            this.dataGridViewTextBoxColumn8.Width = 70;
            // 
            // dataGridViewAutoFilterTextBoxColumn11
            // 
            this.dataGridViewAutoFilterTextBoxColumn11.DataPropertyName = "Номер";
            this.dataGridViewAutoFilterTextBoxColumn11.HeaderText = "Номер";
            this.dataGridViewAutoFilterTextBoxColumn11.Name = "dataGridViewAutoFilterTextBoxColumn11";
            this.dataGridViewAutoFilterTextBoxColumn11.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn12
            // 
            this.dataGridViewAutoFilterTextBoxColumn12.DataPropertyName = "Наименование";
            this.dataGridViewAutoFilterTextBoxColumn12.FillWeight = 350F;
            this.dataGridViewAutoFilterTextBoxColumn12.HeaderText = "Наименование";
            this.dataGridViewAutoFilterTextBoxColumn12.Name = "dataGridViewAutoFilterTextBoxColumn12";
            this.dataGridViewAutoFilterTextBoxColumn12.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn12.Width = 350;
            // 
            // dataGridViewAutoFilterTextBoxColumn13
            // 
            this.dataGridViewAutoFilterTextBoxColumn13.DataPropertyName = "Тип";
            this.dataGridViewAutoFilterTextBoxColumn13.FillWeight = 80F;
            this.dataGridViewAutoFilterTextBoxColumn13.HeaderText = "Тип";
            this.dataGridViewAutoFilterTextBoxColumn13.Name = "dataGridViewAutoFilterTextBoxColumn13";
            this.dataGridViewAutoFilterTextBoxColumn13.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn13.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn13.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn14
            // 
            this.dataGridViewAutoFilterTextBoxColumn14.DataPropertyName = "Статус";
            this.dataGridViewAutoFilterTextBoxColumn14.FillWeight = 80F;
            this.dataGridViewAutoFilterTextBoxColumn14.HeaderText = "Статус";
            this.dataGridViewAutoFilterTextBoxColumn14.Name = "dataGridViewAutoFilterTextBoxColumn14";
            this.dataGridViewAutoFilterTextBoxColumn14.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn14.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn15
            // 
            this.dataGridViewAutoFilterTextBoxColumn15.DataPropertyName = "Станок";
            this.dataGridViewAutoFilterTextBoxColumn15.FillWeight = 150F;
            this.dataGridViewAutoFilterTextBoxColumn15.HeaderText = "Станок";
            this.dataGridViewAutoFilterTextBoxColumn15.Name = "dataGridViewAutoFilterTextBoxColumn15";
            this.dataGridViewAutoFilterTextBoxColumn15.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn15.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn15.Width = 150;
            // 
            // dataGridViewAutoFilterTextBoxColumn16
            // 
            this.dataGridViewAutoFilterTextBoxColumn16.DataPropertyName = "Номер";
            this.dataGridViewAutoFilterTextBoxColumn16.HeaderText = "Номер";
            this.dataGridViewAutoFilterTextBoxColumn16.Name = "dataGridViewAutoFilterTextBoxColumn16";
            this.dataGridViewAutoFilterTextBoxColumn16.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn16.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn17
            // 
            this.dataGridViewAutoFilterTextBoxColumn17.DataPropertyName = "Наименование";
            this.dataGridViewAutoFilterTextBoxColumn17.FillWeight = 350F;
            this.dataGridViewAutoFilterTextBoxColumn17.HeaderText = "Наименование";
            this.dataGridViewAutoFilterTextBoxColumn17.Name = "dataGridViewAutoFilterTextBoxColumn17";
            this.dataGridViewAutoFilterTextBoxColumn17.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn17.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn17.Width = 350;
            // 
            // dataGridViewAutoFilterTextBoxColumn18
            // 
            this.dataGridViewAutoFilterTextBoxColumn18.DataPropertyName = "Тип";
            this.dataGridViewAutoFilterTextBoxColumn18.FillWeight = 80F;
            this.dataGridViewAutoFilterTextBoxColumn18.HeaderText = "Тип";
            this.dataGridViewAutoFilterTextBoxColumn18.Name = "dataGridViewAutoFilterTextBoxColumn18";
            this.dataGridViewAutoFilterTextBoxColumn18.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn18.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn18.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn19
            // 
            this.dataGridViewAutoFilterTextBoxColumn19.DataPropertyName = "Статус";
            this.dataGridViewAutoFilterTextBoxColumn19.FillWeight = 80F;
            this.dataGridViewAutoFilterTextBoxColumn19.HeaderText = "Статус";
            this.dataGridViewAutoFilterTextBoxColumn19.Name = "dataGridViewAutoFilterTextBoxColumn19";
            this.dataGridViewAutoFilterTextBoxColumn19.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn19.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn19.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn20
            // 
            this.dataGridViewAutoFilterTextBoxColumn20.DataPropertyName = "Станок";
            this.dataGridViewAutoFilterTextBoxColumn20.FillWeight = 150F;
            this.dataGridViewAutoFilterTextBoxColumn20.HeaderText = "Станок";
            this.dataGridViewAutoFilterTextBoxColumn20.Name = "dataGridViewAutoFilterTextBoxColumn20";
            this.dataGridViewAutoFilterTextBoxColumn20.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn20.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn20.Width = 150;
            // 
            // dataGridViewAutoFilterTextBoxColumn21
            // 
            this.dataGridViewAutoFilterTextBoxColumn21.DataPropertyName = "Номер";
            this.dataGridViewAutoFilterTextBoxColumn21.HeaderText = "Номер";
            this.dataGridViewAutoFilterTextBoxColumn21.Name = "dataGridViewAutoFilterTextBoxColumn21";
            this.dataGridViewAutoFilterTextBoxColumn21.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn21.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn22
            // 
            this.dataGridViewAutoFilterTextBoxColumn22.DataPropertyName = "Наименование";
            this.dataGridViewAutoFilterTextBoxColumn22.FillWeight = 350F;
            this.dataGridViewAutoFilterTextBoxColumn22.HeaderText = "Наименование";
            this.dataGridViewAutoFilterTextBoxColumn22.Name = "dataGridViewAutoFilterTextBoxColumn22";
            this.dataGridViewAutoFilterTextBoxColumn22.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn22.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn22.Width = 350;
            // 
            // dataGridViewAutoFilterTextBoxColumn23
            // 
            this.dataGridViewAutoFilterTextBoxColumn23.DataPropertyName = "Тип";
            this.dataGridViewAutoFilterTextBoxColumn23.FillWeight = 80F;
            this.dataGridViewAutoFilterTextBoxColumn23.HeaderText = "Тип";
            this.dataGridViewAutoFilterTextBoxColumn23.Name = "dataGridViewAutoFilterTextBoxColumn23";
            this.dataGridViewAutoFilterTextBoxColumn23.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn23.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn23.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn24
            // 
            this.dataGridViewAutoFilterTextBoxColumn24.DataPropertyName = "Статус";
            this.dataGridViewAutoFilterTextBoxColumn24.FillWeight = 80F;
            this.dataGridViewAutoFilterTextBoxColumn24.HeaderText = "Статус";
            this.dataGridViewAutoFilterTextBoxColumn24.Name = "dataGridViewAutoFilterTextBoxColumn24";
            this.dataGridViewAutoFilterTextBoxColumn24.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn24.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn24.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn25
            // 
            this.dataGridViewAutoFilterTextBoxColumn25.DataPropertyName = "Станок";
            this.dataGridViewAutoFilterTextBoxColumn25.FillWeight = 150F;
            this.dataGridViewAutoFilterTextBoxColumn25.HeaderText = "Станок";
            this.dataGridViewAutoFilterTextBoxColumn25.Name = "dataGridViewAutoFilterTextBoxColumn25";
            this.dataGridViewAutoFilterTextBoxColumn25.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn25.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn25.Width = 150;
            // 
            // dataGridViewAutoFilterTextBoxColumn26
            // 
            this.dataGridViewAutoFilterTextBoxColumn26.DataPropertyName = "Номер";
            this.dataGridViewAutoFilterTextBoxColumn26.HeaderText = "Номер";
            this.dataGridViewAutoFilterTextBoxColumn26.Name = "dataGridViewAutoFilterTextBoxColumn26";
            this.dataGridViewAutoFilterTextBoxColumn26.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn26.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn27
            // 
            this.dataGridViewAutoFilterTextBoxColumn27.DataPropertyName = "Наименование";
            this.dataGridViewAutoFilterTextBoxColumn27.FillWeight = 350F;
            this.dataGridViewAutoFilterTextBoxColumn27.HeaderText = "Наименование";
            this.dataGridViewAutoFilterTextBoxColumn27.Name = "dataGridViewAutoFilterTextBoxColumn27";
            this.dataGridViewAutoFilterTextBoxColumn27.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn27.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn27.Width = 350;
            // 
            // dataGridViewAutoFilterTextBoxColumn28
            // 
            this.dataGridViewAutoFilterTextBoxColumn28.DataPropertyName = "Тип";
            this.dataGridViewAutoFilterTextBoxColumn28.FillWeight = 80F;
            this.dataGridViewAutoFilterTextBoxColumn28.HeaderText = "Тип";
            this.dataGridViewAutoFilterTextBoxColumn28.Name = "dataGridViewAutoFilterTextBoxColumn28";
            this.dataGridViewAutoFilterTextBoxColumn28.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn28.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn28.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn29
            // 
            this.dataGridViewAutoFilterTextBoxColumn29.DataPropertyName = "Статус";
            this.dataGridViewAutoFilterTextBoxColumn29.FillWeight = 80F;
            this.dataGridViewAutoFilterTextBoxColumn29.HeaderText = "Статус";
            this.dataGridViewAutoFilterTextBoxColumn29.Name = "dataGridViewAutoFilterTextBoxColumn29";
            this.dataGridViewAutoFilterTextBoxColumn29.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn29.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn29.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn30
            // 
            this.dataGridViewAutoFilterTextBoxColumn30.DataPropertyName = "Станок";
            this.dataGridViewAutoFilterTextBoxColumn30.FillWeight = 150F;
            this.dataGridViewAutoFilterTextBoxColumn30.HeaderText = "Станок";
            this.dataGridViewAutoFilterTextBoxColumn30.Name = "dataGridViewAutoFilterTextBoxColumn30";
            this.dataGridViewAutoFilterTextBoxColumn30.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn30.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn30.Width = 150;
            // 
            // dataGridViewAutoFilterTextBoxColumn31
            // 
            this.dataGridViewAutoFilterTextBoxColumn31.DataPropertyName = "Номер";
            this.dataGridViewAutoFilterTextBoxColumn31.HeaderText = "Номер";
            this.dataGridViewAutoFilterTextBoxColumn31.Name = "dataGridViewAutoFilterTextBoxColumn31";
            this.dataGridViewAutoFilterTextBoxColumn31.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn31.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn32
            // 
            this.dataGridViewAutoFilterTextBoxColumn32.DataPropertyName = "Наименование";
            this.dataGridViewAutoFilterTextBoxColumn32.FillWeight = 350F;
            this.dataGridViewAutoFilterTextBoxColumn32.HeaderText = "Наименование";
            this.dataGridViewAutoFilterTextBoxColumn32.Name = "dataGridViewAutoFilterTextBoxColumn32";
            this.dataGridViewAutoFilterTextBoxColumn32.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn32.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn32.Width = 350;
            // 
            // dataGridViewAutoFilterTextBoxColumn33
            // 
            this.dataGridViewAutoFilterTextBoxColumn33.DataPropertyName = "Тип";
            this.dataGridViewAutoFilterTextBoxColumn33.FillWeight = 80F;
            this.dataGridViewAutoFilterTextBoxColumn33.HeaderText = "Тип";
            this.dataGridViewAutoFilterTextBoxColumn33.Name = "dataGridViewAutoFilterTextBoxColumn33";
            this.dataGridViewAutoFilterTextBoxColumn33.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn33.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn33.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn34
            // 
            this.dataGridViewAutoFilterTextBoxColumn34.DataPropertyName = "Статус";
            this.dataGridViewAutoFilterTextBoxColumn34.FillWeight = 80F;
            this.dataGridViewAutoFilterTextBoxColumn34.HeaderText = "Статус";
            this.dataGridViewAutoFilterTextBoxColumn34.Name = "dataGridViewAutoFilterTextBoxColumn34";
            this.dataGridViewAutoFilterTextBoxColumn34.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn34.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn34.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn35
            // 
            this.dataGridViewAutoFilterTextBoxColumn35.DataPropertyName = "Станок";
            this.dataGridViewAutoFilterTextBoxColumn35.FillWeight = 150F;
            this.dataGridViewAutoFilterTextBoxColumn35.HeaderText = "Станок";
            this.dataGridViewAutoFilterTextBoxColumn35.Name = "dataGridViewAutoFilterTextBoxColumn35";
            this.dataGridViewAutoFilterTextBoxColumn35.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn35.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn35.Width = 150;
            // 
            // dataGridViewAutoFilterTextBoxColumn36
            // 
            this.dataGridViewAutoFilterTextBoxColumn36.DataPropertyName = "Номер";
            this.dataGridViewAutoFilterTextBoxColumn36.HeaderText = "Номер";
            this.dataGridViewAutoFilterTextBoxColumn36.Name = "dataGridViewAutoFilterTextBoxColumn36";
            this.dataGridViewAutoFilterTextBoxColumn36.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn36.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn37
            // 
            this.dataGridViewAutoFilterTextBoxColumn37.DataPropertyName = "Наименование";
            this.dataGridViewAutoFilterTextBoxColumn37.FillWeight = 350F;
            this.dataGridViewAutoFilterTextBoxColumn37.HeaderText = "Наименование";
            this.dataGridViewAutoFilterTextBoxColumn37.Name = "dataGridViewAutoFilterTextBoxColumn37";
            this.dataGridViewAutoFilterTextBoxColumn37.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn37.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn37.Width = 350;
            // 
            // dataGridViewAutoFilterTextBoxColumn38
            // 
            this.dataGridViewAutoFilterTextBoxColumn38.DataPropertyName = "Тип";
            this.dataGridViewAutoFilterTextBoxColumn38.FillWeight = 80F;
            this.dataGridViewAutoFilterTextBoxColumn38.HeaderText = "Тип";
            this.dataGridViewAutoFilterTextBoxColumn38.Name = "dataGridViewAutoFilterTextBoxColumn38";
            this.dataGridViewAutoFilterTextBoxColumn38.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn38.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn38.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn39
            // 
            this.dataGridViewAutoFilterTextBoxColumn39.DataPropertyName = "Статус";
            this.dataGridViewAutoFilterTextBoxColumn39.FillWeight = 80F;
            this.dataGridViewAutoFilterTextBoxColumn39.HeaderText = "Статус";
            this.dataGridViewAutoFilterTextBoxColumn39.Name = "dataGridViewAutoFilterTextBoxColumn39";
            this.dataGridViewAutoFilterTextBoxColumn39.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn39.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn39.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn40
            // 
            this.dataGridViewAutoFilterTextBoxColumn40.DataPropertyName = "Станок";
            this.dataGridViewAutoFilterTextBoxColumn40.FillWeight = 150F;
            this.dataGridViewAutoFilterTextBoxColumn40.HeaderText = "Станок";
            this.dataGridViewAutoFilterTextBoxColumn40.Name = "dataGridViewAutoFilterTextBoxColumn40";
            this.dataGridViewAutoFilterTextBoxColumn40.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn40.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn40.Width = 150;
            // 
            // dataGridViewAutoFilterTextBoxColumn41
            // 
            this.dataGridViewAutoFilterTextBoxColumn41.DataPropertyName = "Номер";
            this.dataGridViewAutoFilterTextBoxColumn41.HeaderText = "Номер";
            this.dataGridViewAutoFilterTextBoxColumn41.Name = "dataGridViewAutoFilterTextBoxColumn41";
            this.dataGridViewAutoFilterTextBoxColumn41.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn41.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn42
            // 
            this.dataGridViewAutoFilterTextBoxColumn42.DataPropertyName = "Наименование";
            this.dataGridViewAutoFilterTextBoxColumn42.FillWeight = 350F;
            this.dataGridViewAutoFilterTextBoxColumn42.HeaderText = "Наименование";
            this.dataGridViewAutoFilterTextBoxColumn42.Name = "dataGridViewAutoFilterTextBoxColumn42";
            this.dataGridViewAutoFilterTextBoxColumn42.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn42.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn42.Width = 350;
            // 
            // dataGridViewAutoFilterTextBoxColumn43
            // 
            this.dataGridViewAutoFilterTextBoxColumn43.DataPropertyName = "Тип";
            this.dataGridViewAutoFilterTextBoxColumn43.FillWeight = 80F;
            this.dataGridViewAutoFilterTextBoxColumn43.HeaderText = "Тип";
            this.dataGridViewAutoFilterTextBoxColumn43.Name = "dataGridViewAutoFilterTextBoxColumn43";
            this.dataGridViewAutoFilterTextBoxColumn43.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn43.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn43.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn44
            // 
            this.dataGridViewAutoFilterTextBoxColumn44.DataPropertyName = "Статус";
            this.dataGridViewAutoFilterTextBoxColumn44.FillWeight = 80F;
            this.dataGridViewAutoFilterTextBoxColumn44.HeaderText = "Статус";
            this.dataGridViewAutoFilterTextBoxColumn44.Name = "dataGridViewAutoFilterTextBoxColumn44";
            this.dataGridViewAutoFilterTextBoxColumn44.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn44.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn44.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn45
            // 
            this.dataGridViewAutoFilterTextBoxColumn45.DataPropertyName = "Станок";
            this.dataGridViewAutoFilterTextBoxColumn45.FillWeight = 150F;
            this.dataGridViewAutoFilterTextBoxColumn45.HeaderText = "Станок";
            this.dataGridViewAutoFilterTextBoxColumn45.Name = "dataGridViewAutoFilterTextBoxColumn45";
            this.dataGridViewAutoFilterTextBoxColumn45.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn45.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn45.Width = 150;
            // 
            // dataGridViewAutoFilterTextBoxColumn46
            // 
            this.dataGridViewAutoFilterTextBoxColumn46.DataPropertyName = "Номер";
            this.dataGridViewAutoFilterTextBoxColumn46.HeaderText = "Номер";
            this.dataGridViewAutoFilterTextBoxColumn46.Name = "dataGridViewAutoFilterTextBoxColumn46";
            this.dataGridViewAutoFilterTextBoxColumn46.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn46.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn47
            // 
            this.dataGridViewAutoFilterTextBoxColumn47.DataPropertyName = "Наименование";
            this.dataGridViewAutoFilterTextBoxColumn47.FillWeight = 350F;
            this.dataGridViewAutoFilterTextBoxColumn47.HeaderText = "Наименование";
            this.dataGridViewAutoFilterTextBoxColumn47.Name = "dataGridViewAutoFilterTextBoxColumn47";
            this.dataGridViewAutoFilterTextBoxColumn47.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn47.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn47.Width = 350;
            // 
            // dataGridViewAutoFilterTextBoxColumn48
            // 
            this.dataGridViewAutoFilterTextBoxColumn48.DataPropertyName = "Тип";
            this.dataGridViewAutoFilterTextBoxColumn48.FillWeight = 80F;
            this.dataGridViewAutoFilterTextBoxColumn48.HeaderText = "Тип";
            this.dataGridViewAutoFilterTextBoxColumn48.Name = "dataGridViewAutoFilterTextBoxColumn48";
            this.dataGridViewAutoFilterTextBoxColumn48.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn48.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn48.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn49
            // 
            this.dataGridViewAutoFilterTextBoxColumn49.DataPropertyName = "Статус";
            this.dataGridViewAutoFilterTextBoxColumn49.FillWeight = 80F;
            this.dataGridViewAutoFilterTextBoxColumn49.HeaderText = "Статус";
            this.dataGridViewAutoFilterTextBoxColumn49.Name = "dataGridViewAutoFilterTextBoxColumn49";
            this.dataGridViewAutoFilterTextBoxColumn49.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn49.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn49.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn50
            // 
            this.dataGridViewAutoFilterTextBoxColumn50.DataPropertyName = "Станок";
            this.dataGridViewAutoFilterTextBoxColumn50.FillWeight = 150F;
            this.dataGridViewAutoFilterTextBoxColumn50.HeaderText = "Станок";
            this.dataGridViewAutoFilterTextBoxColumn50.Name = "dataGridViewAutoFilterTextBoxColumn50";
            this.dataGridViewAutoFilterTextBoxColumn50.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn50.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn50.Width = 150;
            // 
            // dataGridViewAutoFilterTextBoxColumn51
            // 
            this.dataGridViewAutoFilterTextBoxColumn51.DataPropertyName = "Номер";
            this.dataGridViewAutoFilterTextBoxColumn51.HeaderText = "Номер";
            this.dataGridViewAutoFilterTextBoxColumn51.Name = "dataGridViewAutoFilterTextBoxColumn51";
            this.dataGridViewAutoFilterTextBoxColumn51.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn51.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn52
            // 
            this.dataGridViewAutoFilterTextBoxColumn52.DataPropertyName = "Наименование";
            this.dataGridViewAutoFilterTextBoxColumn52.FillWeight = 350F;
            this.dataGridViewAutoFilterTextBoxColumn52.HeaderText = "Наименование";
            this.dataGridViewAutoFilterTextBoxColumn52.Name = "dataGridViewAutoFilterTextBoxColumn52";
            this.dataGridViewAutoFilterTextBoxColumn52.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn52.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn52.Width = 350;
            // 
            // dataGridViewAutoFilterTextBoxColumn53
            // 
            this.dataGridViewAutoFilterTextBoxColumn53.DataPropertyName = "Тип";
            this.dataGridViewAutoFilterTextBoxColumn53.FillWeight = 80F;
            this.dataGridViewAutoFilterTextBoxColumn53.HeaderText = "Тип";
            this.dataGridViewAutoFilterTextBoxColumn53.Name = "dataGridViewAutoFilterTextBoxColumn53";
            this.dataGridViewAutoFilterTextBoxColumn53.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn53.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn53.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn54
            // 
            this.dataGridViewAutoFilterTextBoxColumn54.DataPropertyName = "Статус";
            this.dataGridViewAutoFilterTextBoxColumn54.FillWeight = 80F;
            this.dataGridViewAutoFilterTextBoxColumn54.HeaderText = "Статус";
            this.dataGridViewAutoFilterTextBoxColumn54.Name = "dataGridViewAutoFilterTextBoxColumn54";
            this.dataGridViewAutoFilterTextBoxColumn54.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn54.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn54.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn55
            // 
            this.dataGridViewAutoFilterTextBoxColumn55.DataPropertyName = "Станок";
            this.dataGridViewAutoFilterTextBoxColumn55.FillWeight = 150F;
            this.dataGridViewAutoFilterTextBoxColumn55.HeaderText = "Станок";
            this.dataGridViewAutoFilterTextBoxColumn55.Name = "dataGridViewAutoFilterTextBoxColumn55";
            this.dataGridViewAutoFilterTextBoxColumn55.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn55.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn55.Width = 150;
            // 
            // dataGridViewAutoFilterTextBoxColumn56
            // 
            this.dataGridViewAutoFilterTextBoxColumn56.DataPropertyName = "Номер";
            this.dataGridViewAutoFilterTextBoxColumn56.HeaderText = "Номер";
            this.dataGridViewAutoFilterTextBoxColumn56.Name = "dataGridViewAutoFilterTextBoxColumn56";
            this.dataGridViewAutoFilterTextBoxColumn56.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn56.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn57
            // 
            this.dataGridViewAutoFilterTextBoxColumn57.DataPropertyName = "Наименование";
            this.dataGridViewAutoFilterTextBoxColumn57.FillWeight = 350F;
            this.dataGridViewAutoFilterTextBoxColumn57.HeaderText = "Наименование";
            this.dataGridViewAutoFilterTextBoxColumn57.Name = "dataGridViewAutoFilterTextBoxColumn57";
            this.dataGridViewAutoFilterTextBoxColumn57.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn57.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn57.Width = 350;
            // 
            // dataGridViewAutoFilterTextBoxColumn58
            // 
            this.dataGridViewAutoFilterTextBoxColumn58.DataPropertyName = "Тип";
            this.dataGridViewAutoFilterTextBoxColumn58.FillWeight = 80F;
            this.dataGridViewAutoFilterTextBoxColumn58.HeaderText = "Тип";
            this.dataGridViewAutoFilterTextBoxColumn58.Name = "dataGridViewAutoFilterTextBoxColumn58";
            this.dataGridViewAutoFilterTextBoxColumn58.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn58.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn58.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn59
            // 
            this.dataGridViewAutoFilterTextBoxColumn59.DataPropertyName = "Статус";
            this.dataGridViewAutoFilterTextBoxColumn59.FillWeight = 80F;
            this.dataGridViewAutoFilterTextBoxColumn59.HeaderText = "Статус";
            this.dataGridViewAutoFilterTextBoxColumn59.Name = "dataGridViewAutoFilterTextBoxColumn59";
            this.dataGridViewAutoFilterTextBoxColumn59.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn59.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn59.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn60
            // 
            this.dataGridViewAutoFilterTextBoxColumn60.DataPropertyName = "Станок";
            this.dataGridViewAutoFilterTextBoxColumn60.FillWeight = 150F;
            this.dataGridViewAutoFilterTextBoxColumn60.HeaderText = "Станок";
            this.dataGridViewAutoFilterTextBoxColumn60.Name = "dataGridViewAutoFilterTextBoxColumn60";
            this.dataGridViewAutoFilterTextBoxColumn60.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn60.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn60.Width = 150;
            // 
            // dataGridViewAutoFilterTextBoxColumn61
            // 
            this.dataGridViewAutoFilterTextBoxColumn61.DataPropertyName = "Номер";
            this.dataGridViewAutoFilterTextBoxColumn61.HeaderText = "Номер";
            this.dataGridViewAutoFilterTextBoxColumn61.Name = "dataGridViewAutoFilterTextBoxColumn61";
            this.dataGridViewAutoFilterTextBoxColumn61.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn61.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn62
            // 
            this.dataGridViewAutoFilterTextBoxColumn62.DataPropertyName = "Наименование";
            this.dataGridViewAutoFilterTextBoxColumn62.FillWeight = 350F;
            this.dataGridViewAutoFilterTextBoxColumn62.HeaderText = "Наименование";
            this.dataGridViewAutoFilterTextBoxColumn62.Name = "dataGridViewAutoFilterTextBoxColumn62";
            this.dataGridViewAutoFilterTextBoxColumn62.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn62.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn62.Width = 350;
            // 
            // dataGridViewAutoFilterTextBoxColumn63
            // 
            this.dataGridViewAutoFilterTextBoxColumn63.DataPropertyName = "Тип";
            this.dataGridViewAutoFilterTextBoxColumn63.FillWeight = 80F;
            this.dataGridViewAutoFilterTextBoxColumn63.HeaderText = "Тип";
            this.dataGridViewAutoFilterTextBoxColumn63.Name = "dataGridViewAutoFilterTextBoxColumn63";
            this.dataGridViewAutoFilterTextBoxColumn63.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn63.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn63.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn64
            // 
            this.dataGridViewAutoFilterTextBoxColumn64.DataPropertyName = "Статус";
            this.dataGridViewAutoFilterTextBoxColumn64.FillWeight = 80F;
            this.dataGridViewAutoFilterTextBoxColumn64.HeaderText = "Статус";
            this.dataGridViewAutoFilterTextBoxColumn64.Name = "dataGridViewAutoFilterTextBoxColumn64";
            this.dataGridViewAutoFilterTextBoxColumn64.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn64.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn64.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn65
            // 
            this.dataGridViewAutoFilterTextBoxColumn65.DataPropertyName = "Станок";
            this.dataGridViewAutoFilterTextBoxColumn65.FillWeight = 150F;
            this.dataGridViewAutoFilterTextBoxColumn65.HeaderText = "Станок";
            this.dataGridViewAutoFilterTextBoxColumn65.Name = "dataGridViewAutoFilterTextBoxColumn65";
            this.dataGridViewAutoFilterTextBoxColumn65.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn65.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn65.Width = 150;
            // 
            // dataGridViewAutoFilterTextBoxColumn66
            // 
            this.dataGridViewAutoFilterTextBoxColumn66.DataPropertyName = "Номер";
            this.dataGridViewAutoFilterTextBoxColumn66.HeaderText = "Номер";
            this.dataGridViewAutoFilterTextBoxColumn66.Name = "dataGridViewAutoFilterTextBoxColumn66";
            this.dataGridViewAutoFilterTextBoxColumn66.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn66.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn67
            // 
            this.dataGridViewAutoFilterTextBoxColumn67.DataPropertyName = "Наименование";
            this.dataGridViewAutoFilterTextBoxColumn67.FillWeight = 350F;
            this.dataGridViewAutoFilterTextBoxColumn67.HeaderText = "Наименование";
            this.dataGridViewAutoFilterTextBoxColumn67.Name = "dataGridViewAutoFilterTextBoxColumn67";
            this.dataGridViewAutoFilterTextBoxColumn67.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn67.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn67.Width = 350;
            // 
            // dataGridViewAutoFilterTextBoxColumn68
            // 
            this.dataGridViewAutoFilterTextBoxColumn68.DataPropertyName = "Тип";
            this.dataGridViewAutoFilterTextBoxColumn68.FillWeight = 80F;
            this.dataGridViewAutoFilterTextBoxColumn68.HeaderText = "Тип";
            this.dataGridViewAutoFilterTextBoxColumn68.Name = "dataGridViewAutoFilterTextBoxColumn68";
            this.dataGridViewAutoFilterTextBoxColumn68.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn68.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn68.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn69
            // 
            this.dataGridViewAutoFilterTextBoxColumn69.DataPropertyName = "Статус";
            this.dataGridViewAutoFilterTextBoxColumn69.FillWeight = 80F;
            this.dataGridViewAutoFilterTextBoxColumn69.HeaderText = "Статус";
            this.dataGridViewAutoFilterTextBoxColumn69.Name = "dataGridViewAutoFilterTextBoxColumn69";
            this.dataGridViewAutoFilterTextBoxColumn69.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn69.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn69.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn70
            // 
            this.dataGridViewAutoFilterTextBoxColumn70.DataPropertyName = "Станок";
            this.dataGridViewAutoFilterTextBoxColumn70.FillWeight = 150F;
            this.dataGridViewAutoFilterTextBoxColumn70.HeaderText = "Станок";
            this.dataGridViewAutoFilterTextBoxColumn70.Name = "dataGridViewAutoFilterTextBoxColumn70";
            this.dataGridViewAutoFilterTextBoxColumn70.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn70.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn70.Width = 150;
            // 
            // dataGridViewAutoFilterTextBoxColumn71
            // 
            this.dataGridViewAutoFilterTextBoxColumn71.DataPropertyName = "Номер";
            this.dataGridViewAutoFilterTextBoxColumn71.HeaderText = "Номер";
            this.dataGridViewAutoFilterTextBoxColumn71.Name = "dataGridViewAutoFilterTextBoxColumn71";
            this.dataGridViewAutoFilterTextBoxColumn71.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn71.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn72
            // 
            this.dataGridViewAutoFilterTextBoxColumn72.DataPropertyName = "Наименование";
            this.dataGridViewAutoFilterTextBoxColumn72.FillWeight = 350F;
            this.dataGridViewAutoFilterTextBoxColumn72.HeaderText = "Наименование";
            this.dataGridViewAutoFilterTextBoxColumn72.Name = "dataGridViewAutoFilterTextBoxColumn72";
            this.dataGridViewAutoFilterTextBoxColumn72.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn72.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn72.Width = 350;
            // 
            // dataGridViewAutoFilterTextBoxColumn73
            // 
            this.dataGridViewAutoFilterTextBoxColumn73.DataPropertyName = "Тип";
            this.dataGridViewAutoFilterTextBoxColumn73.FillWeight = 80F;
            this.dataGridViewAutoFilterTextBoxColumn73.HeaderText = "Тип";
            this.dataGridViewAutoFilterTextBoxColumn73.Name = "dataGridViewAutoFilterTextBoxColumn73";
            this.dataGridViewAutoFilterTextBoxColumn73.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn73.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn73.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn74
            // 
            this.dataGridViewAutoFilterTextBoxColumn74.DataPropertyName = "Статус";
            this.dataGridViewAutoFilterTextBoxColumn74.FillWeight = 80F;
            this.dataGridViewAutoFilterTextBoxColumn74.HeaderText = "Статус";
            this.dataGridViewAutoFilterTextBoxColumn74.Name = "dataGridViewAutoFilterTextBoxColumn74";
            this.dataGridViewAutoFilterTextBoxColumn74.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn74.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn74.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn75
            // 
            this.dataGridViewAutoFilterTextBoxColumn75.DataPropertyName = "Станок";
            this.dataGridViewAutoFilterTextBoxColumn75.FillWeight = 150F;
            this.dataGridViewAutoFilterTextBoxColumn75.HeaderText = "Станок";
            this.dataGridViewAutoFilterTextBoxColumn75.Name = "dataGridViewAutoFilterTextBoxColumn75";
            this.dataGridViewAutoFilterTextBoxColumn75.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn75.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn75.Width = 150;
            // 
            // dataGridViewAutoFilterTextBoxColumn76
            // 
            this.dataGridViewAutoFilterTextBoxColumn76.DataPropertyName = "Номер";
            this.dataGridViewAutoFilterTextBoxColumn76.HeaderText = "Номер";
            this.dataGridViewAutoFilterTextBoxColumn76.Name = "dataGridViewAutoFilterTextBoxColumn76";
            this.dataGridViewAutoFilterTextBoxColumn76.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn76.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn77
            // 
            this.dataGridViewAutoFilterTextBoxColumn77.DataPropertyName = "Наименование";
            this.dataGridViewAutoFilterTextBoxColumn77.FillWeight = 350F;
            this.dataGridViewAutoFilterTextBoxColumn77.HeaderText = "Наименование";
            this.dataGridViewAutoFilterTextBoxColumn77.Name = "dataGridViewAutoFilterTextBoxColumn77";
            this.dataGridViewAutoFilterTextBoxColumn77.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn77.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn77.Width = 350;
            // 
            // dataGridViewAutoFilterTextBoxColumn78
            // 
            this.dataGridViewAutoFilterTextBoxColumn78.DataPropertyName = "Тип";
            this.dataGridViewAutoFilterTextBoxColumn78.FillWeight = 80F;
            this.dataGridViewAutoFilterTextBoxColumn78.HeaderText = "Тип";
            this.dataGridViewAutoFilterTextBoxColumn78.Name = "dataGridViewAutoFilterTextBoxColumn78";
            this.dataGridViewAutoFilterTextBoxColumn78.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn78.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn78.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn79
            // 
            this.dataGridViewAutoFilterTextBoxColumn79.DataPropertyName = "Статус";
            this.dataGridViewAutoFilterTextBoxColumn79.FillWeight = 80F;
            this.dataGridViewAutoFilterTextBoxColumn79.HeaderText = "Статус";
            this.dataGridViewAutoFilterTextBoxColumn79.Name = "dataGridViewAutoFilterTextBoxColumn79";
            this.dataGridViewAutoFilterTextBoxColumn79.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn79.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn79.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn80
            // 
            this.dataGridViewAutoFilterTextBoxColumn80.DataPropertyName = "Станок";
            this.dataGridViewAutoFilterTextBoxColumn80.FillWeight = 150F;
            this.dataGridViewAutoFilterTextBoxColumn80.HeaderText = "Станок";
            this.dataGridViewAutoFilterTextBoxColumn80.Name = "dataGridViewAutoFilterTextBoxColumn80";
            this.dataGridViewAutoFilterTextBoxColumn80.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn80.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn80.Width = 150;
            // 
            // dataGridViewAutoFilterTextBoxColumn81
            // 
            this.dataGridViewAutoFilterTextBoxColumn81.DataPropertyName = "Номер";
            this.dataGridViewAutoFilterTextBoxColumn81.HeaderText = "Номер";
            this.dataGridViewAutoFilterTextBoxColumn81.Name = "dataGridViewAutoFilterTextBoxColumn81";
            this.dataGridViewAutoFilterTextBoxColumn81.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn81.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn82
            // 
            this.dataGridViewAutoFilterTextBoxColumn82.DataPropertyName = "Наименование";
            this.dataGridViewAutoFilterTextBoxColumn82.FillWeight = 350F;
            this.dataGridViewAutoFilterTextBoxColumn82.HeaderText = "Наименование";
            this.dataGridViewAutoFilterTextBoxColumn82.Name = "dataGridViewAutoFilterTextBoxColumn82";
            this.dataGridViewAutoFilterTextBoxColumn82.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn82.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn82.Width = 350;
            // 
            // dataGridViewAutoFilterTextBoxColumn83
            // 
            this.dataGridViewAutoFilterTextBoxColumn83.DataPropertyName = "Тип";
            this.dataGridViewAutoFilterTextBoxColumn83.FillWeight = 80F;
            this.dataGridViewAutoFilterTextBoxColumn83.HeaderText = "Тип";
            this.dataGridViewAutoFilterTextBoxColumn83.Name = "dataGridViewAutoFilterTextBoxColumn83";
            this.dataGridViewAutoFilterTextBoxColumn83.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn83.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn83.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn84
            // 
            this.dataGridViewAutoFilterTextBoxColumn84.DataPropertyName = "Статус";
            this.dataGridViewAutoFilterTextBoxColumn84.FillWeight = 80F;
            this.dataGridViewAutoFilterTextBoxColumn84.HeaderText = "Статус";
            this.dataGridViewAutoFilterTextBoxColumn84.Name = "dataGridViewAutoFilterTextBoxColumn84";
            this.dataGridViewAutoFilterTextBoxColumn84.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn84.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn84.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn85
            // 
            this.dataGridViewAutoFilterTextBoxColumn85.DataPropertyName = "Станок";
            this.dataGridViewAutoFilterTextBoxColumn85.FillWeight = 150F;
            this.dataGridViewAutoFilterTextBoxColumn85.HeaderText = "Станок";
            this.dataGridViewAutoFilterTextBoxColumn85.Name = "dataGridViewAutoFilterTextBoxColumn85";
            this.dataGridViewAutoFilterTextBoxColumn85.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn85.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn85.Width = 150;
            // 
            // dataGridViewAutoFilterTextBoxColumn86
            // 
            this.dataGridViewAutoFilterTextBoxColumn86.DataPropertyName = "Номер";
            this.dataGridViewAutoFilterTextBoxColumn86.HeaderText = "Номер";
            this.dataGridViewAutoFilterTextBoxColumn86.Name = "dataGridViewAutoFilterTextBoxColumn86";
            this.dataGridViewAutoFilterTextBoxColumn86.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn86.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn87
            // 
            this.dataGridViewAutoFilterTextBoxColumn87.DataPropertyName = "Наименование";
            this.dataGridViewAutoFilterTextBoxColumn87.FillWeight = 350F;
            this.dataGridViewAutoFilterTextBoxColumn87.HeaderText = "Наименование";
            this.dataGridViewAutoFilterTextBoxColumn87.Name = "dataGridViewAutoFilterTextBoxColumn87";
            this.dataGridViewAutoFilterTextBoxColumn87.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn87.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn87.Width = 350;
            // 
            // dataGridViewAutoFilterTextBoxColumn88
            // 
            this.dataGridViewAutoFilterTextBoxColumn88.DataPropertyName = "Тип";
            this.dataGridViewAutoFilterTextBoxColumn88.FillWeight = 80F;
            this.dataGridViewAutoFilterTextBoxColumn88.HeaderText = "Тип";
            this.dataGridViewAutoFilterTextBoxColumn88.Name = "dataGridViewAutoFilterTextBoxColumn88";
            this.dataGridViewAutoFilterTextBoxColumn88.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn88.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn88.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn89
            // 
            this.dataGridViewAutoFilterTextBoxColumn89.DataPropertyName = "Статус";
            this.dataGridViewAutoFilterTextBoxColumn89.FillWeight = 80F;
            this.dataGridViewAutoFilterTextBoxColumn89.HeaderText = "Статус";
            this.dataGridViewAutoFilterTextBoxColumn89.Name = "dataGridViewAutoFilterTextBoxColumn89";
            this.dataGridViewAutoFilterTextBoxColumn89.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn89.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn89.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn90
            // 
            this.dataGridViewAutoFilterTextBoxColumn90.DataPropertyName = "Станок";
            this.dataGridViewAutoFilterTextBoxColumn90.FillWeight = 150F;
            this.dataGridViewAutoFilterTextBoxColumn90.HeaderText = "Станок";
            this.dataGridViewAutoFilterTextBoxColumn90.Name = "dataGridViewAutoFilterTextBoxColumn90";
            this.dataGridViewAutoFilterTextBoxColumn90.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn90.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn90.Width = 150;
            // 
            // dataGridViewAutoFilterTextBoxColumn91
            // 
            this.dataGridViewAutoFilterTextBoxColumn91.DataPropertyName = "Номер";
            this.dataGridViewAutoFilterTextBoxColumn91.HeaderText = "Номер";
            this.dataGridViewAutoFilterTextBoxColumn91.Name = "dataGridViewAutoFilterTextBoxColumn91";
            this.dataGridViewAutoFilterTextBoxColumn91.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn91.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn92
            // 
            this.dataGridViewAutoFilterTextBoxColumn92.DataPropertyName = "Наименование";
            this.dataGridViewAutoFilterTextBoxColumn92.FillWeight = 350F;
            this.dataGridViewAutoFilterTextBoxColumn92.HeaderText = "Наименование";
            this.dataGridViewAutoFilterTextBoxColumn92.Name = "dataGridViewAutoFilterTextBoxColumn92";
            this.dataGridViewAutoFilterTextBoxColumn92.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn92.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn92.Width = 350;
            // 
            // dataGridViewAutoFilterTextBoxColumn93
            // 
            this.dataGridViewAutoFilterTextBoxColumn93.DataPropertyName = "Тип";
            this.dataGridViewAutoFilterTextBoxColumn93.FillWeight = 80F;
            this.dataGridViewAutoFilterTextBoxColumn93.HeaderText = "Тип";
            this.dataGridViewAutoFilterTextBoxColumn93.Name = "dataGridViewAutoFilterTextBoxColumn93";
            this.dataGridViewAutoFilterTextBoxColumn93.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn93.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn93.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn94
            // 
            this.dataGridViewAutoFilterTextBoxColumn94.DataPropertyName = "Статус";
            this.dataGridViewAutoFilterTextBoxColumn94.FillWeight = 80F;
            this.dataGridViewAutoFilterTextBoxColumn94.HeaderText = "Статус";
            this.dataGridViewAutoFilterTextBoxColumn94.Name = "dataGridViewAutoFilterTextBoxColumn94";
            this.dataGridViewAutoFilterTextBoxColumn94.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn94.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn94.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn95
            // 
            this.dataGridViewAutoFilterTextBoxColumn95.DataPropertyName = "Станок";
            this.dataGridViewAutoFilterTextBoxColumn95.FillWeight = 150F;
            this.dataGridViewAutoFilterTextBoxColumn95.HeaderText = "Станок";
            this.dataGridViewAutoFilterTextBoxColumn95.Name = "dataGridViewAutoFilterTextBoxColumn95";
            this.dataGridViewAutoFilterTextBoxColumn95.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn95.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn95.Width = 150;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Соответствие чертежу";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Соответствие чертежу";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Чертеж";
            this.dataGridViewTextBoxColumn9.HeaderText = "Чертеж";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            this.наименованиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // номерDataGridViewTextBoxColumn
            // 
            this.номерDataGridViewTextBoxColumn.DataPropertyName = "Номер";
            this.номерDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.номерDataGridViewTextBoxColumn.Name = "номерDataGridViewTextBoxColumn";
            this.номерDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Тип
            // 
            this.Тип.DataPropertyName = "Тип";
            this.Тип.HeaderText = "Тип";
            this.Тип.Name = "Тип";
            this.Тип.ReadOnly = true;
            // 
            // Статус
            // 
            this.Статус.DataPropertyName = "Статус";
            this.Статус.HeaderText = "Статус";
            this.Статус.Name = "Статус";
            this.Статус.ReadOnly = true;
            // 
            // ресурсударыDataGridViewTextBoxColumn
            // 
            this.ресурсударыDataGridViewTextBoxColumn.DataPropertyName = "Ресурс (удары)";
            this.ресурсударыDataGridViewTextBoxColumn.HeaderText = "Ресурс (удары)";
            this.ресурсударыDataGridViewTextBoxColumn.Name = "ресурсударыDataGridViewTextBoxColumn";
            this.ресурсударыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ресурсмесяцыDataGridViewTextBoxColumn
            // 
            this.ресурсмесяцыDataGridViewTextBoxColumn.DataPropertyName = "Ресурс (месяцы)";
            this.ресурсмесяцыDataGridViewTextBoxColumn.HeaderText = "Ресурс (месяцы)";
            this.ресурсмесяцыDataGridViewTextBoxColumn.Name = "ресурсмесяцыDataGridViewTextBoxColumn";
            this.ресурсмесяцыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // станокDataGridViewTextBoxColumn
            // 
            this.станокDataGridViewTextBoxColumn.DataPropertyName = "Станок";
            this.станокDataGridViewTextBoxColumn.HeaderText = "Станок";
            this.станокDataGridViewTextBoxColumn.Name = "станокDataGridViewTextBoxColumn";
            this.станокDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Наименование";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Номер
            // 
            this.Номер.DataPropertyName = "Номер";
            this.Номер.HeaderText = "Номер";
            this.Номер.Name = "Номер";
            // 
            // main_viewTableAdapter
            // 
            this.main_viewTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1733, 919);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шерлок";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotary_technologyDataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Тип;
        private System.Windows.Forms.DataGridViewTextBoxColumn Статус;
        private System.Windows.Forms.DataGridViewTextBoxColumn ресурсударыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ресурсмесяцыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn станокDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Номер;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private rotary_technologyDataSet rotary_technologyDataSet;
        private System.Windows.Forms.BindingSource mainviewBindingSource;
        private rotary_technologyDataSetTableAdapters.main_viewTableAdapter main_viewTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem управлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem базаДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаMAINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаСтанковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаМатрицИПуансоновToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.Timer auto_update;
        private System.Windows.Forms.ToolStripMenuItem окраскаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статусToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem износToolStripMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel probel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Timer progress_au;
        private System.Windows.Forms.ToolStripStatusLabel probel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton refresh_button;
        private System.Windows.Forms.ToolStripButton stop_button;
        private System.Windows.Forms.ToolStripButton start_autoupdate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton end_button;
        private System.Windows.Forms.ToolStripButton status_button_check;
        private System.Windows.Forms.ToolStripButton iznos_button_check;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton calculator_button;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn1;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn2;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn3;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn5;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn6;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn7;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn8;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn9;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn10;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn11;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn12;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn13;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn14;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn15;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn16;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn17;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn18;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn19;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn20;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn21;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn22;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn23;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn24;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn25;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn26;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn27;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn28;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn29;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn30;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn31;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn32;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn33;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn34;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn35;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn36;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn37;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn38;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn39;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn40;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn41;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn42;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn43;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn44;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn45;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn46;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn47;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn48;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn49;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn50;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn51;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn52;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn53;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn54;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn55;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn56;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn57;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn58;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn59;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn60;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn61;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn62;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn63;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn64;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn65;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn66;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn67;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn68;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn69;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn70;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn71;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn72;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn73;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn74;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn75;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn76;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn77;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn78;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn79;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn80;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn81;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn82;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn83;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn84;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn85;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn86;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn87;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn88;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn89;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn90;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn91;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn92;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn93;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn94;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn95;
        private System.Windows.Forms.NotifyIcon notify_sherlok;
        private System.Windows.Forms.Timer timer_warning_iznos;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem статусToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьПозицииНаСкладеToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton Добавить;
        private System.Windows.Forms.ToolStripButton warehouse_button;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn номерDataGridViewTextBoxColumn1;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn наименованиеDataGridViewTextBoxColumn1;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn типDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn статусDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ресурсударыDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ресурсмесяцыDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Износ;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn станокDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn типСтанкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn заказанDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn переточкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Эксплуатация;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Индекс;
  
    }
}

