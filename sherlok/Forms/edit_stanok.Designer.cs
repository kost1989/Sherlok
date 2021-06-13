namespace sherlok.Forms
{
    partial class edit_stanok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit_stanok));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.end_button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.help_button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.load_from_base = new System.Windows.Forms.ToolStripButton();
            this.save_to_base = new System.Windows.Forms.ToolStripButton();
            this.button_error_check = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.typenameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.edit_stanok1 = new sherlok.edit_stanok();
            this.stankyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stankyTableAdapter = new sherlok.edit_stanokTableAdapters.stankyTableAdapter();
            this.typenameTableAdapter = new sherlok.edit_stanokTableAdapters.typenameTableAdapter();
            this.idstankyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namestankyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typestankyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typenameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_stanok1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stankyBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(686, 54);
            this.toolStrip1.TabIndex = 7;
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idstankyDataGridViewTextBoxColumn,
            this.namestankyDataGridViewTextBoxColumn,
            this.typestankyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stankyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(661, 855);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // typenameBindingSource
            // 
            this.typenameBindingSource.DataMember = "typename";
            this.typenameBindingSource.DataSource = this.edit_stanok1;
            // 
            // edit_stanok1
            // 
            this.edit_stanok1.DataSetName = "edit_stanok";
            this.edit_stanok1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stankyBindingSource
            // 
            this.stankyBindingSource.DataMember = "stanky";
            this.stankyBindingSource.DataSource = this.edit_stanok1;
            // 
            // stankyTableAdapter
            // 
            this.stankyTableAdapter.ClearBeforeFill = true;
            // 
            // typenameTableAdapter
            // 
            this.typenameTableAdapter.ClearBeforeFill = true;
            // 
            // idstankyDataGridViewTextBoxColumn
            // 
            this.idstankyDataGridViewTextBoxColumn.DataPropertyName = "idstanky";
            this.idstankyDataGridViewTextBoxColumn.HeaderText = "Индекс";
            this.idstankyDataGridViewTextBoxColumn.Name = "idstankyDataGridViewTextBoxColumn";
            this.idstankyDataGridViewTextBoxColumn.ReadOnly = true;
            this.idstankyDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // namestankyDataGridViewTextBoxColumn
            // 
            this.namestankyDataGridViewTextBoxColumn.DataPropertyName = "namestanky";
            this.namestankyDataGridViewTextBoxColumn.FillWeight = 350F;
            this.namestankyDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.namestankyDataGridViewTextBoxColumn.Name = "namestankyDataGridViewTextBoxColumn";
            this.namestankyDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.namestankyDataGridViewTextBoxColumn.Width = 350;
            // 
            // typestankyDataGridViewTextBoxColumn
            // 
            this.typestankyDataGridViewTextBoxColumn.DataPropertyName = "typestanky";
            this.typestankyDataGridViewTextBoxColumn.DataSource = this.typenameBindingSource;
            this.typestankyDataGridViewTextBoxColumn.DisplayMember = "typenamecol";
            this.typestankyDataGridViewTextBoxColumn.FillWeight = 150F;
            this.typestankyDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.typestankyDataGridViewTextBoxColumn.Name = "typestankyDataGridViewTextBoxColumn";
            this.typestankyDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.typestankyDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.typestankyDataGridViewTextBoxColumn.ValueMember = "idtypename";
            this.typestankyDataGridViewTextBoxColumn.Width = 150;
            // 
            // edit_stanok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 924);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "edit_stanok";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактор формы станков";
            this.Load += new System.EventHandler(this.edit_stanok_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typenameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_stanok1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stankyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton end_button;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton help_button;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton load_from_base;
        private System.Windows.Forms.ToolStripButton save_to_base;
        private System.Windows.Forms.ToolStripButton button_error_check;
        private System.Windows.Forms.DataGridView dataGridView1;
        private sherlok.edit_stanok edit_stanok1;
        private System.Windows.Forms.BindingSource stankyBindingSource;
        private edit_stanokTableAdapters.stankyTableAdapter stankyTableAdapter;
        private System.Windows.Forms.BindingSource typenameBindingSource;
        private edit_stanokTableAdapters.typenameTableAdapter typenameTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstankyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namestankyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn typestankyDataGridViewTextBoxColumn;
    }
}