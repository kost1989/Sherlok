namespace sherlok.Forms
{
    partial class edit_main_add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit_main_add));
            this.label1 = new System.Windows.Forms.Label();
            this.index_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name_combobox = new System.Windows.Forms.ComboBox();
            this.editor_main = new sherlok.editor_main();
            this.namesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editormainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matrix_checkbox = new System.Windows.Forms.CheckBox();
            this.puanson_checkbox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.number_textbox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.puanson_iznos = new System.Windows.Forms.TextBox();
            this.matrix_iznos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.stankyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.add_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.namesTableAdapter = new sherlok.editor_mainTableAdapters.namesTableAdapter();
            this.stankyTableAdapter = new sherlok.editor_mainTableAdapters.stankyTableAdapter();
            this.dataTable1TableAdapter1 = new sherlok.editor_mainTableAdapters.DataTable1TableAdapter();
            this.index_bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.edit_stanok = new sherlok.edit_stanok();
            this.typenameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typenameTableAdapter = new sherlok.edit_stanokTableAdapters.typenameTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.main_add = new sherlok.main_add();
            this.mainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainTableAdapter = new sherlok.main_addTableAdapters.mainTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.editor_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editormainBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stankyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.index_bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_stanok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typenameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Индекс:";
            // 
            // index_label
            // 
            this.index_label.AutoSize = true;
            this.index_label.Location = new System.Drawing.Point(102, 9);
            this.index_label.Name = "index_label";
            this.index_label.Size = new System.Drawing.Size(40, 13);
            this.index_label.TabIndex = 1;
            this.index_label.Text = "INDEX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Наименование:";
            // 
            // name_combobox
            // 
            this.name_combobox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.editor_main, "main.Наименование", true));
            this.name_combobox.DataSource = this.namesBindingSource;
            this.name_combobox.DisplayMember = "namesname";
            this.name_combobox.FormattingEnabled = true;
            this.name_combobox.Location = new System.Drawing.Point(105, 26);
            this.name_combobox.Name = "name_combobox";
            this.name_combobox.Size = new System.Drawing.Size(274, 21);
            this.name_combobox.TabIndex = 40;
            this.name_combobox.ValueMember = "idnames";
            // 
            // editor_main
            // 
            this.editor_main.DataSetName = "editor_main";
            this.editor_main.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // namesBindingSource
            // 
            this.namesBindingSource.DataMember = "names";
            this.namesBindingSource.DataSource = this.editormainBindingSource;
            // 
            // editormainBindingSource
            // 
            this.editormainBindingSource.DataSource = this.editor_main;
            this.editormainBindingSource.Position = 0;
            // 
            // matrix_checkbox
            // 
            this.matrix_checkbox.AutoSize = true;
            this.matrix_checkbox.Location = new System.Drawing.Point(105, 53);
            this.matrix_checkbox.Name = "matrix_checkbox";
            this.matrix_checkbox.Size = new System.Drawing.Size(70, 17);
            this.matrix_checkbox.TabIndex = 41;
            this.matrix_checkbox.Text = "Матрица";
            this.matrix_checkbox.UseVisualStyleBackColor = true;
            // 
            // puanson_checkbox
            // 
            this.puanson_checkbox.AutoSize = true;
            this.puanson_checkbox.Location = new System.Drawing.Point(181, 53);
            this.puanson_checkbox.Name = "puanson_checkbox";
            this.puanson_checkbox.Size = new System.Drawing.Size(69, 17);
            this.puanson_checkbox.TabIndex = 42;
            this.puanson_checkbox.Text = "Пуансон";
            this.puanson_checkbox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Номер:";
            // 
            // number_textbox
            // 
            this.number_textbox.Location = new System.Drawing.Point(105, 77);
            this.number_textbox.Name = "number_textbox";
            this.number_textbox.Size = new System.Drawing.Size(70, 20);
            this.number_textbox.TabIndex = 43;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.puanson_iznos);
            this.groupBox2.Controls.Add(this.matrix_iznos);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(385, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 85);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Текущий размер";
            // 
            // puanson_iznos
            // 
            this.puanson_iznos.Location = new System.Drawing.Point(72, 46);
            this.puanson_iznos.MaxLength = 10;
            this.puanson_iznos.Name = "puanson_iznos";
            this.puanson_iznos.Size = new System.Drawing.Size(100, 20);
            this.puanson_iznos.TabIndex = 46;
            // 
            // matrix_iznos
            // 
            this.matrix_iznos.Location = new System.Drawing.Point(72, 19);
            this.matrix_iznos.MaxLength = 10;
            this.matrix_iznos.Name = "matrix_iznos";
            this.matrix_iznos.Size = new System.Drawing.Size(100, 20);
            this.matrix_iznos.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Пуансон:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Матрица:";
            // 
            // stankyBindingSource
            // 
            this.stankyBindingSource.DataMember = "stanky";
            this.stankyBindingSource.DataSource = this.editormainBindingSource;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Заказаны:";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(105, 108);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 44;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(524, 138);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(87, 23);
            this.add_button.TabIndex = 47;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.Location = new System.Drawing.Point(617, 138);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(87, 23);
            this.cancel_button.TabIndex = 18;
            this.cancel_button.Text = "Отмена (ESC)";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // namesTableAdapter
            // 
            this.namesTableAdapter.ClearBeforeFill = true;
            // 
            // stankyTableAdapter
            // 
            this.stankyTableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1TableAdapter1
            // 
            this.dataTable1TableAdapter1.ClearBeforeFill = true;
            // 
            // index_bindingSource
            // 
            this.index_bindingSource.DataSource = this.dataTable1BindingSource;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.editormainBindingSource;
            // 
            // edit_stanok
            // 
            this.edit_stanok.DataSetName = "edit_stanok";
            this.edit_stanok.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typenameBindingSource
            // 
            this.typenameBindingSource.DataMember = "typename";
            this.typenameBindingSource.DataSource = this.edit_stanok;
            // 
            // typenameTableAdapter
            // 
            this.typenameTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(333, 111);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(371, 21);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "*Добавление позиции, автоматически переводит в статус \"На складе\"";
            // 
            // main_add
            // 
            this.main_add.DataSetName = "main_add";
            this.main_add.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mainBindingSource
            // 
            this.mainBindingSource.DataMember = "main";
            this.mainBindingSource.DataSource = this.main_add;
            // 
            // mainTableAdapter
            // 
            this.mainTableAdapter.ClearBeforeFill = true;
            // 
            // edit_main_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel_button;
            this.ClientSize = new System.Drawing.Size(711, 168);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.number_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.puanson_checkbox);
            this.Controls.Add(this.matrix_checkbox);
            this.Controls.Add(this.name_combobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.index_label);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "edit_main_add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить";
            this.Load += new System.EventHandler(this.edit_main_add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editor_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editormainBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stankyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.index_bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_stanok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typenameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label index_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox name_combobox;
        private System.Windows.Forms.CheckBox matrix_checkbox;
        private System.Windows.Forms.CheckBox puanson_checkbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox number_textbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox puanson_iznos;
        private System.Windows.Forms.TextBox matrix_iznos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button cancel_button;
        private editor_main editor_main;
        private System.Windows.Forms.BindingSource editormainBindingSource;
        private System.Windows.Forms.BindingSource namesBindingSource;
        private editor_mainTableAdapters.namesTableAdapter namesTableAdapter;
        private System.Windows.Forms.BindingSource stankyBindingSource;
        private editor_mainTableAdapters.stankyTableAdapter stankyTableAdapter;
        private editor_mainTableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;
        private System.Windows.Forms.BindingSource index_bindingSource;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private main_add main_add;
        private System.Windows.Forms.BindingSource mainBindingSource;
        private main_addTableAdapters.mainTableAdapter mainTableAdapter;
        private sherlok.edit_stanok edit_stanok;
        private System.Windows.Forms.BindingSource typenameBindingSource;
        private edit_stanokTableAdapters.typenameTableAdapter typenameTableAdapter;
        private System.Windows.Forms.TextBox textBox1;

    }
}