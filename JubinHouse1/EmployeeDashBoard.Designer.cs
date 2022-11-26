using System.ComponentModel;

namespace JubinHouse1
{
    partial class EmployeeDashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.Projects = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Projects
            // 
            this.Projects.Location = new System.Drawing.Point(269, 45);
            this.Projects.Name = "Projects";
            this.Projects.Size = new System.Drawing.Size(307, 59);
            this.Projects.TabIndex = 0;
            this.Projects.Text = "PROJECTS";
            this.Projects.UseVisualStyleBackColor = true;
            this.Projects.Click += new System.EventHandler(this.Projects_Click);
            // 
            // EmployeeDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Projects);
            this.Name = "EmployeeDashBoard";
            this.Text = "EmployeeDashBoard";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button Projects;

        #endregion
    }
}