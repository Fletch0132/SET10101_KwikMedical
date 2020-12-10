namespace WindowsFormsApp1
{
    partial class PatientDisplay
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
            this.dgvPatientDisplay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPatientDisplay
            // 
            this.dgvPatientDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientDisplay.Location = new System.Drawing.Point(12, 12);
            this.dgvPatientDisplay.Name = "dgvPatientDisplay";
            this.dgvPatientDisplay.Size = new System.Drawing.Size(289, 329);
            this.dgvPatientDisplay.TabIndex = 0;
            // 
            // PatientDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 396);
            this.Controls.Add(this.dgvPatientDisplay);
            this.Name = "PatientDisplay";
            this.Text = "PatientDisplay";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPatientDisplay;
    }
}