namespace PatientManagementSystem_WindowsApplication
{
    partial class patient_discharge
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dischage_patient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(221, 426);
            this.treeView1.TabIndex = 0;
            // 
            // dischage_patient
            // 
            this.dischage_patient.Location = new System.Drawing.Point(280, 186);
            this.dischage_patient.Name = "dischage_patient";
            this.dischage_patient.Size = new System.Drawing.Size(236, 39);
            this.dischage_patient.TabIndex = 1;
            this.dischage_patient.Text = "Dischage Selected Patient";
            this.dischage_patient.UseVisualStyleBackColor = true;
            this.dischage_patient.Click += new System.EventHandler(this.dischage_patient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(280, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Patient Discharge";
            // 
            // patient_discharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dischage_patient);
            this.Controls.Add(this.treeView1);
            this.Name = "patient_discharge";
            this.Text = "Patient Discharge";
            this.Load += new System.EventHandler(this.patient_discharge_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TreeView treeView1;
        private Button dischage_patient;
        private Label label1;
    }
}