namespace ARM_Engineer.Parts
{
    partial class Parts
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
            this.Add_parts = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitMeasurement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agregat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uzel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chainge = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.dataBaseEngineerDataSet = new ARM_Engineer.DataBaseEngineerDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new ARM_Engineer.DataBaseEngineerDataSetTableAdapters.TableTableAdapter();
            this.Update_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseEngineerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_parts
            // 
            this.Add_parts.Location = new System.Drawing.Point(56, 8);
            this.Add_parts.Name = "Add_parts";
            this.Add_parts.Size = new System.Drawing.Size(74, 23);
            this.Add_parts.TabIndex = 0;
            this.Add_parts.Text = "Добавть";
            this.Add_parts.UseVisualStyleBackColor = true;
            this.Add_parts.Click += new System.EventHandler(this.Add_parts_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.Articul,
            this.UnitMeasurement,
            this.Agregat,
            this.Uzel});
            this.dataGridView1.Location = new System.Drawing.Point(56, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 401);
            this.dataGridView1.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Name
            // 
            this.Name.HeaderText = "Наименование";
            this.Name.Name = "Name";
            // 
            // Articul
            // 
            this.Articul.HeaderText = "Артикул";
            this.Articul.Name = "Articul";
            // 
            // UnitMeasurement
            // 
            this.UnitMeasurement.HeaderText = "Ед.измерения";
            this.UnitMeasurement.Name = "UnitMeasurement";
            // 
            // Agregat
            // 
            this.Agregat.HeaderText = "Агрегат";
            this.Agregat.Name = "Agregat";
            // 
            // Uzel
            // 
            this.Uzel.HeaderText = "Узел";
            this.Uzel.Name = "Uzel";
            // 
            // Chainge
            // 
            this.Chainge.Location = new System.Drawing.Point(136, 8);
            this.Chainge.Name = "Chainge";
            this.Chainge.Size = new System.Drawing.Size(75, 23);
            this.Chainge.TabIndex = 2;
            this.Chainge.Text = "Изменить";
            this.Chainge.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(217, 8);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // dataBaseEngineerDataSet
            // 
            this.dataBaseEngineerDataSet.DataSetName = "DataBaseEngineerDataSet";
            this.dataBaseEngineerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.dataBaseEngineerDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // Update_button
            // 
            this.Update_button.Location = new System.Drawing.Point(709, 12);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(75, 23);
            this.Update_button.TabIndex = 3;
            this.Update_button.Text = "Обновить";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // Parts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 481);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Chainge);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Add_parts);
            this.Name = "Parts";
            this.Load += new System.EventHandler(this.Parts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseEngineerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add_parts;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articul;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitMeasurement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Agregat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uzel;
        private System.Windows.Forms.Button Chainge;
        private System.Windows.Forms.Button Delete;
        private DataBaseEngineerDataSet dataBaseEngineerDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private DataBaseEngineerDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.Button Update_button;
    }
}