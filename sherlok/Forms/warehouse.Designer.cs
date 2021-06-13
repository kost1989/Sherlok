namespace sherlok.Forms
{
    partial class a
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.namesname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typecol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zakazanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expluatation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouse_dataset = new sherlok.warehouse_dataset();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.stankyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editstanokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.edit_stanok = new sherlok.edit_stanok();
            this.mainTableAdapter = new sherlok.warehouse_datasetTableAdapters.mainTableAdapter();
            this.stankyTableAdapter = new sherlok.edit_stanokTableAdapters.stankyTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idmainDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznosDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zakazanaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peretochkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueperetochkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expluatationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spisanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.warehouse_to_main = new sherlok.warehouse_to_main();
            this.sootvchertezhDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chertezhDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainTableAdapter1 = new sherlok.warehouse_to_mainTableAdapters.mainTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stankyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editstanokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_stanok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_to_main)).BeginInit();
            this.SuspendLayout();
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
            this.namesname,
            this.numberDataGridViewTextBoxColumn,
            this.typecol,
            this.iznosDataGridViewTextBoxColumn,
            this.zakazanaDataGridViewTextBoxColumn,
            this.idmainDataGridViewTextBoxColumn,
            this.typename,
            this.stanok,
            this.status,
            this.expluatation});
            this.dataGridView1.DataSource = this.mainBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(945, 436);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // namesname
            // 
            this.namesname.DataPropertyName = "namesname";
            this.namesname.FillWeight = 440F;
            this.namesname.HeaderText = "Наименование";
            this.namesname.Name = "namesname";
            this.namesname.ReadOnly = true;
            this.namesname.Width = 440;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typecol
            // 
            this.typecol.DataPropertyName = "typecol";
            this.typecol.HeaderText = "Тип";
            this.typecol.Name = "typecol";
            this.typecol.ReadOnly = true;
            // 
            // iznosDataGridViewTextBoxColumn
            // 
            this.iznosDataGridViewTextBoxColumn.DataPropertyName = "iznos";
            this.iznosDataGridViewTextBoxColumn.HeaderText = "Фактический размер";
            this.iznosDataGridViewTextBoxColumn.Name = "iznosDataGridViewTextBoxColumn";
            this.iznosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zakazanaDataGridViewTextBoxColumn
            // 
            this.zakazanaDataGridViewTextBoxColumn.DataPropertyName = "zakazana";
            this.zakazanaDataGridViewTextBoxColumn.HeaderText = "Заказана";
            this.zakazanaDataGridViewTextBoxColumn.Name = "zakazanaDataGridViewTextBoxColumn";
            this.zakazanaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idmainDataGridViewTextBoxColumn
            // 
            this.idmainDataGridViewTextBoxColumn.DataPropertyName = "idmain";
            this.idmainDataGridViewTextBoxColumn.HeaderText = "idmain";
            this.idmainDataGridViewTextBoxColumn.Name = "idmainDataGridViewTextBoxColumn";
            this.idmainDataGridViewTextBoxColumn.ReadOnly = true;
            this.idmainDataGridViewTextBoxColumn.Visible = false;
            // 
            // typename
            // 
            this.typename.DataPropertyName = "typename";
            this.typename.HeaderText = "typename";
            this.typename.Name = "typename";
            this.typename.ReadOnly = true;
            this.typename.Visible = false;
            // 
            // stanok
            // 
            this.stanok.DataPropertyName = "stanok";
            this.stanok.HeaderText = "stanok";
            this.stanok.Name = "stanok";
            this.stanok.ReadOnly = true;
            this.stanok.Visible = false;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Visible = false;
            // 
            // expluatation
            // 
            this.expluatation.DataPropertyName = "expluatation";
            this.expluatation.HeaderText = "expluatation";
            this.expluatation.Name = "expluatation";
            this.expluatation.ReadOnly = true;
            this.expluatation.Visible = false;
            // 
            // mainBindingSource
            // 
            this.mainBindingSource.DataMember = "main";
            this.mainBindingSource.DataSource = this.warehouse_dataset;
            // 
            // warehouse_dataset
            // 
            this.warehouse_dataset.DataSetName = "warehouse_dataset";
            this.warehouse_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(854, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Закрыть (ESC)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Номер П/П";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер П/П";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Номер";
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Износ";
            this.dataGridViewTextBoxColumn3.HeaderText = "Износ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Переточка";
            this.dataGridViewTextBoxColumn4.HeaderText = "Переточка";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Заказан";
            this.dataGridViewTextBoxColumn5.HeaderText = "Заказан";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Соответствие чертежу";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Соответствие чертежу";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Чертеж";
            this.dataGridViewTextBoxColumn6.HeaderText = "Чертеж";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn7.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Тип";
            this.dataGridViewTextBoxColumn8.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Станок";
            this.dataGridViewTextBoxColumn9.HeaderText = "Станок";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Статус";
            this.dataGridViewTextBoxColumn10.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Дата списания";
            this.dataGridViewTextBoxColumn11.HeaderText = "Дата списания";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "chertezh";
            this.dataGridViewTextBoxColumn12.HeaderText = "chertezh";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.GreenYellow;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(745, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "В работу";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mainBindingSource, "stanok", true));
            this.comboBox1.DataSource = this.stankyBindingSource;
            this.comboBox1.DisplayMember = "namestanky";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 454);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(727, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "idstanky";
            // 
            // stankyBindingSource
            // 
            this.stankyBindingSource.DataMember = "stanky";
            this.stankyBindingSource.DataSource = this.editstanokBindingSource;
            // 
            // editstanokBindingSource
            // 
            this.editstanokBindingSource.DataSource = this.edit_stanok;
            this.editstanokBindingSource.Position = 0;
            // 
            // edit_stanok
            // 
            this.edit_stanok.DataSetName = "edit_stanok";
            this.edit_stanok.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mainTableAdapter
            // 
            this.mainTableAdapter.ClearBeforeFill = true;
            // 
            // stankyTableAdapter
            // 
            this.stankyTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmainDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn13,
            this.numberDataGridViewTextBoxColumn1,
            this.typeDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn14,
            this.stanokDataGridViewTextBoxColumn,
            this.iznosDataGridViewTextBoxColumn1,
            this.zakazanaDataGridViewTextBoxColumn1,
            this.peretochkaDataGridViewTextBoxColumn,
            this.valueperetochkaDataGridViewTextBoxColumn,
            this.expluatationDataGridViewTextBoxColumn,
            this.spisanDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.mainBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(1349, 141);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1456, 286);
            this.dataGridView2.TabIndex = 4;
            // 
            // idmainDataGridViewTextBoxColumn1
            // 
            this.idmainDataGridViewTextBoxColumn1.DataPropertyName = "idmain";
            this.idmainDataGridViewTextBoxColumn1.HeaderText = "idmain";
            this.idmainDataGridViewTextBoxColumn1.Name = "idmainDataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn13.HeaderText = "name";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // numberDataGridViewTextBoxColumn1
            // 
            this.numberDataGridViewTextBoxColumn1.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn1.HeaderText = "number";
            this.numberDataGridViewTextBoxColumn1.Name = "numberDataGridViewTextBoxColumn1";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "status";
            this.dataGridViewTextBoxColumn14.HeaderText = "status";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // stanokDataGridViewTextBoxColumn
            // 
            this.stanokDataGridViewTextBoxColumn.DataPropertyName = "stanok";
            this.stanokDataGridViewTextBoxColumn.HeaderText = "stanok";
            this.stanokDataGridViewTextBoxColumn.Name = "stanokDataGridViewTextBoxColumn";
            // 
            // iznosDataGridViewTextBoxColumn1
            // 
            this.iznosDataGridViewTextBoxColumn1.DataPropertyName = "iznos";
            this.iznosDataGridViewTextBoxColumn1.HeaderText = "iznos";
            this.iznosDataGridViewTextBoxColumn1.Name = "iznosDataGridViewTextBoxColumn1";
            // 
            // zakazanaDataGridViewTextBoxColumn1
            // 
            this.zakazanaDataGridViewTextBoxColumn1.DataPropertyName = "zakazana";
            this.zakazanaDataGridViewTextBoxColumn1.HeaderText = "zakazana";
            this.zakazanaDataGridViewTextBoxColumn1.Name = "zakazanaDataGridViewTextBoxColumn1";
            // 
            // peretochkaDataGridViewTextBoxColumn
            // 
            this.peretochkaDataGridViewTextBoxColumn.DataPropertyName = "peretochka";
            this.peretochkaDataGridViewTextBoxColumn.HeaderText = "peretochka";
            this.peretochkaDataGridViewTextBoxColumn.Name = "peretochkaDataGridViewTextBoxColumn";
            // 
            // valueperetochkaDataGridViewTextBoxColumn
            // 
            this.valueperetochkaDataGridViewTextBoxColumn.DataPropertyName = "value_peretochka";
            this.valueperetochkaDataGridViewTextBoxColumn.HeaderText = "value_peretochka";
            this.valueperetochkaDataGridViewTextBoxColumn.Name = "valueperetochkaDataGridViewTextBoxColumn";
            // 
            // expluatationDataGridViewTextBoxColumn
            // 
            this.expluatationDataGridViewTextBoxColumn.DataPropertyName = "expluatation";
            this.expluatationDataGridViewTextBoxColumn.HeaderText = "expluatation";
            this.expluatationDataGridViewTextBoxColumn.Name = "expluatationDataGridViewTextBoxColumn";
            // 
            // spisanDataGridViewTextBoxColumn
            // 
            this.spisanDataGridViewTextBoxColumn.DataPropertyName = "spisan";
            this.spisanDataGridViewTextBoxColumn.HeaderText = "spisan";
            this.spisanDataGridViewTextBoxColumn.Name = "spisanDataGridViewTextBoxColumn";
            // 
            // mainBindingSource1
            // 
            this.mainBindingSource1.DataMember = "main";
            this.mainBindingSource1.DataSource = this.warehouse_to_main;
            // 
            // warehouse_to_main
            // 
            this.warehouse_to_main.DataSetName = "warehouse_to_main";
            this.warehouse_to_main.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sootvchertezhDataGridViewCheckBoxColumn1
            // 
            this.sootvchertezhDataGridViewCheckBoxColumn1.Name = "sootvchertezhDataGridViewCheckBoxColumn1";
            // 
            // chertezhDataGridViewTextBoxColumn1
            // 
            this.chertezhDataGridViewTextBoxColumn1.Name = "chertezhDataGridViewTextBoxColumn1";
            // 
            // mainTableAdapter1
            // 
            this.mainTableAdapter1.ClearBeforeFill = true;
            // 
            // a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(968, 488);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "a";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "warehouse";
            this.Load += new System.EventHandler(this.warehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stankyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editstanokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_stanok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_to_main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private warehouse_dataset warehouse_dataset;
        private System.Windows.Forms.BindingSource mainBindingSource;
        private warehouse_datasetTableAdapters.mainTableAdapter mainTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource editstanokBindingSource;
        private sherlok.edit_stanok edit_stanok;
        private System.Windows.Forms.BindingSource stankyBindingSource;
        private edit_stanokTableAdapters.stankyTableAdapter stankyTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private warehouse_to_main warehouse_to_main;
        private System.Windows.Forms.BindingSource mainBindingSource1;
        private warehouse_to_mainTableAdapters.mainTableAdapter mainTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmainDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznosDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zakazanaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn peretochkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueperetochkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expluatationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spisanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sootvchertezhDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn chertezhDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namesname;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typecol;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zakazanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typename;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanok;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn expluatation;
    }
}