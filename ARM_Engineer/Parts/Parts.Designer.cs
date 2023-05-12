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
            this.Chainge = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            //this.dataBaseEngineerDataSet = new ARM_Engineer.DataBaseEngineerDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
          //  this.tableTableAdapter = new ARM_Engineer.DataBaseEngineerDataSetTableAdapters.TableTableAdapter();
            this.Update_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
           // ((System.ComponentModel.ISupportInitialize)(this.dataBaseEngineerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            //this.dataBaseEngineerDataSet.DataSetName = "DataBaseEngineerDataSet";
            //this.dataBaseEngineerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
           // this.tableBindingSource.DataSource = this.dataBaseEngineerDataSet;
            // 
            // tableTableAdapter
            // 
           // this.tableTableAdapter.ClearBeforeFill = true;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(755, 409);
            this.dataGridView1.TabIndex = 4;
            // 
            // Parts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 481);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Chainge);
            this.Controls.Add(this.Add_parts);
            this.Name = "Parts";
            this.Load += new System.EventHandler(this.Parts_Load);
            //((System.ComponentModel.ISupportInitialize)(this.dataBaseEngineerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add_parts;
        private System.Windows.Forms.Button Chainge;
        private System.Windows.Forms.Button Delete;
       
        private System.Windows.Forms.BindingSource tableBindingSource;
    
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}