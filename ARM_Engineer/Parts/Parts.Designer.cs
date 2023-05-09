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
            this.Add_parts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_parts
            // 
            this.Add_parts.Location = new System.Drawing.Point(699, 12);
            this.Add_parts.Name = "Add_parts";
            this.Add_parts.Size = new System.Drawing.Size(74, 23);
            this.Add_parts.TabIndex = 0;
            this.Add_parts.Text = "Добавть";
            this.Add_parts.UseVisualStyleBackColor = true;
            this.Add_parts.Click += new System.EventHandler(this.Add_parts_Click);
            // 
            // Parts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Add_parts);
            this.Name = "Parts";
            this.Text = "Parts";
            this.Load += new System.EventHandler(this.Parts_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add_parts;
    }
}