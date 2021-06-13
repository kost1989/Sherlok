namespace sherlok.Forms
{
    partial class edit_matpuan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit_matpuan));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.typenameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editmatpuan1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.edit_matpuan1 = new sherlok.edit_matpuan();
            this.namesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.end_button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.help_button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.load_from_base = new System.Windows.Forms.ToolStripButton();
            this.save_to_base = new System.Windows.Forms.ToolStripButton();
            this.button_error_check = new System.Windows.Forms.ToolStripButton();
            this.typenameTableAdapter = new sherlok.edit_matpuanTableAdapters.typenameTableAdapter();
            this.namesTableAdapter = new sherlok.edit_matpuanTableAdapters.namesTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.idnamesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namesnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typenamecol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.resourceudarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resourcemonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mstartiznosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mcriticaliznosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pstartiznosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcriticaliznosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sootvchertezhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chertezhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typenameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editmatpuan1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_matpuan1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namesBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idnamesDataGridViewTextBoxColumn,
            this.namesnameDataGridViewTextBoxColumn,
            this.typenamecol,
            this.resourceudarDataGridViewTextBoxColumn,
            this.resourcemonthDataGridViewTextBoxColumn,
            this.mstartiznosDataGridViewTextBoxColumn,
            this.mcriticaliznosDataGridViewTextBoxColumn,
            this.pstartiznosDataGridViewTextBoxColumn,
            this.pcriticaliznosDataGridViewTextBoxColumn,
            this.sootvchertezhDataGridViewTextBoxColumn,
            this.chertezhDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.namesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1457, 855);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // typenameBindingSource
            // 
            this.typenameBindingSource.DataMember = "typename";
            this.typenameBindingSource.DataSource = this.editmatpuan1BindingSource;
            // 
            // editmatpuan1BindingSource
            // 
            this.editmatpuan1BindingSource.DataSource = this.edit_matpuan1;
            this.editmatpuan1BindingSource.Position = 0;
            // 
            // edit_matpuan1
            // 
            this.edit_matpuan1.DataSetName = "edit_matpuan";
            this.edit_matpuan1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // namesBindingSource
            // 
            this.namesBindingSource.DataMember = "names";
            this.namesBindingSource.DataSource = this.editmatpuan1BindingSource;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.end_button,
            this.toolStripSeparator2,
            this.help_button,
            this.toolStripSeparator1,
            this.load_from_base,
            this.save_to_base,
            this.button_error_check});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(1481, 54);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // end_button
            // 
            this.end_button.Image = global::sherlok.Properties.Resources.cross32;
            this.end_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.end_button.Name = "end_button";
            this.end_button.Size = new System.Drawing.Size(57, 51);
            this.end_button.Text = "Закрыть";
            this.end_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.end_button.ToolTipText = "Закрыть";
            this.end_button.Click += new System.EventHandler(this.end_button_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AutoSize = false;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(20, 39);
            // 
            // help_button
            // 
            this.help_button.Enabled = false;
            this.help_button.Image = global::sherlok.Properties.Resources.help1;
            this.help_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.help_button.Name = "help_button";
            this.help_button.Size = new System.Drawing.Size(60, 51);
            this.help_button.Text = "Помощь";
            this.help_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.help_button.ToolTipText = "Помощь";
            this.help_button.Click += new System.EventHandler(this.help_button_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(20, 39);
            // 
            // load_from_base
            // 
            this.load_from_base.Image = global::sherlok.Properties.Resources.application_get;
            this.load_from_base.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.load_from_base.Name = "load_from_base";
            this.load_from_base.Size = new System.Drawing.Size(154, 51);
            this.load_from_base.Text = "Загрузить данные из базы";
            this.load_from_base.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.load_from_base.ToolTipText = "Загрузить данные из базы";
            this.load_from_base.Click += new System.EventHandler(this.load_from_base_Click);
            // 
            // save_to_base
            // 
            this.save_to_base.Image = global::sherlok.Properties.Resources.table_save;
            this.save_to_base.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.save_to_base.Name = "save_to_base";
            this.save_to_base.Size = new System.Drawing.Size(148, 51);
            this.save_to_base.Text = "Сохранить в базу данных";
            this.save_to_base.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.save_to_base.ToolTipText = "Сохранить в базу данных";
            this.save_to_base.Click += new System.EventHandler(this.save_to_base_Click);
            // 
            // button_error_check
            // 
            this.button_error_check.Enabled = false;
            this.button_error_check.Image = global::sherlok.Properties.Resources.building_error;
            this.button_error_check.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_error_check.Name = "button_error_check";
            this.button_error_check.Size = new System.Drawing.Size(129, 51);
            this.button_error_check.Text = "Проверка на ошибки";
            this.button_error_check.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // typenameTableAdapter
            // 
            this.typenameTableAdapter.ClearBeforeFill = true;
            // 
            // namesTableAdapter
            // 
            this.namesTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // idnamesDataGridViewTextBoxColumn
            // 
            this.idnamesDataGridViewTextBoxColumn.DataPropertyName = "idnames";
            this.idnamesDataGridViewTextBoxColumn.HeaderText = "Номер П/П";
            this.idnamesDataGridViewTextBoxColumn.Name = "idnamesDataGridViewTextBoxColumn";
            this.idnamesDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // namesnameDataGridViewTextBoxColumn
            // 
            this.namesnameDataGridViewTextBoxColumn.DataPropertyName = "namesname";
            this.namesnameDataGridViewTextBoxColumn.FillWeight = 440F;
            this.namesnameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.namesnameDataGridViewTextBoxColumn.Name = "namesnameDataGridViewTextBoxColumn";
            this.namesnameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.namesnameDataGridViewTextBoxColumn.Width = 440;
            // 
            // typenamecol
            // 
            this.typenamecol.DataPropertyName = "typename";
            this.typenamecol.DataSource = this.typenameBindingSource;
            this.typenamecol.DisplayMember = "typenamecol";
            this.typenamecol.FillWeight = 150F;
            this.typenamecol.HeaderText = "Тип";
            this.typenamecol.Name = "typenamecol";
            this.typenamecol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.typenamecol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.typenamecol.ValueMember = "idtypename";
            this.typenamecol.Width = 150;
            // 
            // resourceudarDataGridViewTextBoxColumn
            // 
            this.resourceudarDataGridViewTextBoxColumn.DataPropertyName = "resource_udar";
            this.resourceudarDataGridViewTextBoxColumn.HeaderText = "Ресурс (Удар)";
            this.resourceudarDataGridViewTextBoxColumn.Name = "resourceudarDataGridViewTextBoxColumn";
            this.resourceudarDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // resourcemonthDataGridViewTextBoxColumn
            // 
            this.resourcemonthDataGridViewTextBoxColumn.DataPropertyName = "resource_month";
            this.resourcemonthDataGridViewTextBoxColumn.HeaderText = "Ресурс (Месяцы)";
            this.resourcemonthDataGridViewTextBoxColumn.Name = "resourcemonthDataGridViewTextBoxColumn";
            this.resourcemonthDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // mstartiznosDataGridViewTextBoxColumn
            // 
            this.mstartiznosDataGridViewTextBoxColumn.DataPropertyName = "m_start_iznos";
            this.mstartiznosDataGridViewTextBoxColumn.FillWeight = 80F;
            this.mstartiznosDataGridViewTextBoxColumn.HeaderText = "Начальный размер (Матрица)";
            this.mstartiznosDataGridViewTextBoxColumn.Name = "mstartiznosDataGridViewTextBoxColumn";
            this.mstartiznosDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mstartiznosDataGridViewTextBoxColumn.Width = 80;
            // 
            // mcriticaliznosDataGridViewTextBoxColumn
            // 
            this.mcriticaliznosDataGridViewTextBoxColumn.DataPropertyName = "m_critical_iznos";
            this.mcriticaliznosDataGridViewTextBoxColumn.FillWeight = 80F;
            this.mcriticaliznosDataGridViewTextBoxColumn.HeaderText = "Минимальный размер (Матрицы)";
            this.mcriticaliznosDataGridViewTextBoxColumn.Name = "mcriticaliznosDataGridViewTextBoxColumn";
            this.mcriticaliznosDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mcriticaliznosDataGridViewTextBoxColumn.Width = 80;
            // 
            // pstartiznosDataGridViewTextBoxColumn
            // 
            this.pstartiznosDataGridViewTextBoxColumn.DataPropertyName = "p_start_iznos";
            this.pstartiznosDataGridViewTextBoxColumn.FillWeight = 80F;
            this.pstartiznosDataGridViewTextBoxColumn.HeaderText = "Начальный размер (Пуансон)";
            this.pstartiznosDataGridViewTextBoxColumn.Name = "pstartiznosDataGridViewTextBoxColumn";
            this.pstartiznosDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pstartiznosDataGridViewTextBoxColumn.Width = 80;
            // 
            // pcriticaliznosDataGridViewTextBoxColumn
            // 
            this.pcriticaliznosDataGridViewTextBoxColumn.DataPropertyName = "p_critical_iznos";
            this.pcriticaliznosDataGridViewTextBoxColumn.FillWeight = 80F;
            this.pcriticaliznosDataGridViewTextBoxColumn.HeaderText = "Минимальный размер (Пуансон)";
            this.pcriticaliznosDataGridViewTextBoxColumn.Name = "pcriticaliznosDataGridViewTextBoxColumn";
            this.pcriticaliznosDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pcriticaliznosDataGridViewTextBoxColumn.Width = 80;
            // 
            // sootvchertezhDataGridViewTextBoxColumn
            // 
            this.sootvchertezhDataGridViewTextBoxColumn.DataPropertyName = "sootv_chertezh";
            this.sootvchertezhDataGridViewTextBoxColumn.FillWeight = 80F;
            this.sootvchertezhDataGridViewTextBoxColumn.HeaderText = "Соответствие чертежу";
            this.sootvchertezhDataGridViewTextBoxColumn.Name = "sootvchertezhDataGridViewTextBoxColumn";
            this.sootvchertezhDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sootvchertezhDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sootvchertezhDataGridViewTextBoxColumn.Width = 80;
            // 
            // chertezhDataGridViewTextBoxColumn
            // 
            this.chertezhDataGridViewTextBoxColumn.DataPropertyName = "chertezh";
            this.chertezhDataGridViewTextBoxColumn.HeaderText = "Путь к чертежу";
            this.chertezhDataGridViewTextBoxColumn.Name = "chertezhDataGridViewTextBoxColumn";
            this.chertezhDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // edit_matpuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 924);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "edit_matpuan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактор формы матриц и пуансонов";
            this.Load += new System.EventHandler(this.edit_matpuan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typenameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editmatpuan1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_matpuan1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namesBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton end_button;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton help_button;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton load_from_base;
        private System.Windows.Forms.ToolStripButton save_to_base;
        private System.Windows.Forms.ToolStripButton button_error_check;
        private System.Windows.Forms.BindingSource editmatpuan1BindingSource;
        private sherlok.edit_matpuan edit_matpuan1;
        private System.Windows.Forms.BindingSource typenameBindingSource;
        private edit_matpuanTableAdapters.typenameTableAdapter typenameTableAdapter;
        private System.Windows.Forms.BindingSource namesBindingSource;
        private edit_matpuanTableAdapters.namesTableAdapter namesTableAdapter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnamesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namesnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn typenamecol;
        private System.Windows.Forms.DataGridViewTextBoxColumn resourceudarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resourcemonthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mstartiznosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mcriticaliznosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pstartiznosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcriticaliznosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sootvchertezhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chertezhDataGridViewTextBoxColumn;
    }
}