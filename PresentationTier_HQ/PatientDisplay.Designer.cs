namespace PresentationTier_HQ
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
            this.dgvPatientResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientResults)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPatientResults
            // 
            this.dgvPatientResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientResults.Location = new System.Drawing.Point(12, 12);
            this.dgvPatientResults.Name = "dgvPatientResults";
            this.dgvPatientResults.Size = new System.Drawing.Size(250, 246);
            this.dgvPatientResults.TabIndex = 0;
            // 
            // PatientDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 270);
            this.Controls.Add(this.dgvPatientResults);
            this.Name = "PatientDisplay";
            this.Text = "Patient Results";
            this.Load += new System.EventHandler(this.PatientDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPatientResults;
    }
}