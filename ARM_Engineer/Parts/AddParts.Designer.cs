namespace ARM_Engineer.Parts
{
    partial class AddParts
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
            this.Names = new System.Windows.Forms.Label();
            this.Articul = new System.Windows.Forms.Label();
            this.UnitMeasurement = new System.Windows.Forms.Label();
            this.Agregat_Label = new System.Windows.Forms.Label();
            this.Uzel_Label = new System.Windows.Forms.Label();
            this.OK_button = new System.Windows.Forms.Button();
            this.Cancle_button = new System.Windows.Forms.Button();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Articul_textBox = new System.Windows.Forms.TextBox();
            this.UnitMeasurement_tetxBox = new System.Windows.Forms.TextBox();
            this.Agregat_textBox = new System.Windows.Forms.TextBox();
            this.Uzel_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Names
            // 
            this.Names.AutoSize = true;
            this.Names.Location = new System.Drawing.Point(12, 30);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(83, 13);
            this.Names.TabIndex = 0;
            this.Names.Text = "Наименование";
            // 
            // Articul
            // 
            this.Articul.AutoSize = true;
            this.Articul.Location = new System.Drawing.Point(12, 83);
            this.Articul.Name = "Articul";
            this.Articul.Size = new System.Drawing.Size(48, 13);
            this.Articul.TabIndex = 1;
            this.Articul.Text = "Артикул";
            this.Articul.Click += new System.EventHandler(this.Articul_Click);
            // 
            // UnitMeasurement
            // 
            this.UnitMeasurement.AutoSize = true;
            this.UnitMeasurement.Location = new System.Drawing.Point(12, 127);
            this.UnitMeasurement.Name = "UnitMeasurement";
            this.UnitMeasurement.Size = new System.Drawing.Size(109, 13);
            this.UnitMeasurement.TabIndex = 2;
            this.UnitMeasurement.Text = "Единица измерения";
            // 
            // Agregat_Label
            // 
            this.Agregat_Label.AutoSize = true;
            this.Agregat_Label.Location = new System.Drawing.Point(9, 171);
            this.Agregat_Label.Name = "Agregat_Label";
            this.Agregat_Label.Size = new System.Drawing.Size(48, 13);
            this.Agregat_Label.TabIndex = 3;
            this.Agregat_Label.Text = "Агренат";
            this.Agregat_Label.UseMnemonic = false;
            // 
            // Uzel_Label
            // 
            this.Uzel_Label.AutoSize = true;
            this.Uzel_Label.Location = new System.Drawing.Point(12, 215);
            this.Uzel_Label.Name = "Uzel_Label";
            this.Uzel_Label.Size = new System.Drawing.Size(33, 13);
            this.Uzel_Label.TabIndex = 4;
            this.Uzel_Label.Text = "Узел";
            this.Uzel_Label.UseMnemonic = false;
            this.Uzel_Label.Click += new System.EventHandler(this.Uzel_Label_Click);
            // 
            // OK_button
            // 
            this.OK_button.Location = new System.Drawing.Point(302, 266);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(76, 23);
            this.OK_button.TabIndex = 5;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // Cancle_button
            // 
            this.Cancle_button.Location = new System.Drawing.Point(384, 266);
            this.Cancle_button.Name = "Cancle_button";
            this.Cancle_button.Size = new System.Drawing.Size(76, 23);
            this.Cancle_button.TabIndex = 6;
            this.Cancle_button.Text = "Отмена";
            this.Cancle_button.UseVisualStyleBackColor = true;
            this.Cancle_button.Click += new System.EventHandler(this.Cancle_button_Click);
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(12, 46);
            this.Name_textBox.Multiline = true;
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(267, 25);
            this.Name_textBox.TabIndex = 7;
            this.Name_textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Articul_textBox
            // 
            this.Articul_textBox.Location = new System.Drawing.Point(12, 99);
            this.Articul_textBox.Multiline = true;
            this.Articul_textBox.Name = "Articul_textBox";
            this.Articul_textBox.Size = new System.Drawing.Size(267, 25);
            this.Articul_textBox.TabIndex = 8;
            // 
            // UnitMeasurement_tetxBox
            // 
            this.UnitMeasurement_tetxBox.Location = new System.Drawing.Point(12, 143);
            this.UnitMeasurement_tetxBox.Multiline = true;
            this.UnitMeasurement_tetxBox.Name = "UnitMeasurement_tetxBox";
            this.UnitMeasurement_tetxBox.Size = new System.Drawing.Size(267, 25);
            this.UnitMeasurement_tetxBox.TabIndex = 9;
            // 
            // Agregat_textBox
            // 
            this.Agregat_textBox.Location = new System.Drawing.Point(12, 187);
            this.Agregat_textBox.Multiline = true;
            this.Agregat_textBox.Name = "Agregat_textBox";
            this.Agregat_textBox.Size = new System.Drawing.Size(267, 25);
            this.Agregat_textBox.TabIndex = 10;
            // 
            // Uzel_textBox
            // 
            this.Uzel_textBox.Location = new System.Drawing.Point(12, 231);
            this.Uzel_textBox.Multiline = true;
            this.Uzel_textBox.Name = "Uzel_textBox";
            this.Uzel_textBox.Size = new System.Drawing.Size(267, 25);
            this.Uzel_textBox.TabIndex = 11;
            // 
            // AddParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 301);
            this.Controls.Add(this.Uzel_textBox);
            this.Controls.Add(this.Agregat_textBox);
            this.Controls.Add(this.UnitMeasurement_tetxBox);
            this.Controls.Add(this.Articul_textBox);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.Cancle_button);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.Uzel_Label);
            this.Controls.Add(this.Agregat_Label);
            this.Controls.Add(this.UnitMeasurement);
            this.Controls.Add(this.Articul);
            this.Controls.Add(this.Names);
            this.Name = "AddParts";
            this.Load += new System.EventHandler(this.AddParts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Names;
        private System.Windows.Forms.Label Articul;
        private System.Windows.Forms.Label UnitMeasurement;
        private System.Windows.Forms.Label Agregat_Label;
        private System.Windows.Forms.Label Uzel_Label;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.Button Cancle_button;
        protected internal System.Windows.Forms.TextBox Name_textBox;
        protected internal System.Windows.Forms.TextBox Articul_textBox;
        protected internal System.Windows.Forms.TextBox UnitMeasurement_tetxBox;
        protected internal System.Windows.Forms.TextBox Agregat_textBox;
        protected internal System.Windows.Forms.TextBox Uzel_textBox;
    }
}