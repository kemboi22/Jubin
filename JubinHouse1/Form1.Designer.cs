namespace JubinHouse1
{
    partial class Form1
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
            this.Branches = new System.Windows.Forms.Button();
            this.Agents = new System.Windows.Forms.Button();
            this.Architects = new System.Windows.Forms.Button();
            this.Clients = new System.Windows.Forms.Button();
            this.Projects = new System.Windows.Forms.Button();
            this.Finances = new System.Windows.Forms.Button();
            this.Suppliers = new System.Windows.Forms.Button();
            this.States = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Branches
            // 
            this.Branches.Location = new System.Drawing.Point(283, 51);
            this.Branches.Name = "Branches";
            this.Branches.Size = new System.Drawing.Size(261, 46);
            this.Branches.TabIndex = 0;
            this.Branches.Text = "See All Branches";
            this.Branches.UseVisualStyleBackColor = true;
            this.Branches.Click += new System.EventHandler(this.Branches_Click);
            // 
            // Agents
            // 
            this.Agents.Location = new System.Drawing.Point(283, 249);
            this.Agents.Name = "Agents";
            this.Agents.Size = new System.Drawing.Size(261, 46);
            this.Agents.TabIndex = 1;
            this.Agents.Text = "See All Agents";
            this.Agents.UseVisualStyleBackColor = true;
            this.Agents.Click += new System.EventHandler(this.Agents_Click);
            // 
            // Architects
            // 
            this.Architects.Location = new System.Drawing.Point(283, 315);
            this.Architects.Name = "Architects";
            this.Architects.Size = new System.Drawing.Size(261, 46);
            this.Architects.TabIndex = 2;
            this.Architects.Text = "See All Architects";
            this.Architects.UseVisualStyleBackColor = true;
            this.Architects.Click += new System.EventHandler(this.Architects_Click);
            // 
            // Clients
            // 
            this.Clients.Location = new System.Drawing.Point(283, 185);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(261, 46);
            this.Clients.TabIndex = 3;
            this.Clients.Text = "See All Clients";
            this.Clients.UseVisualStyleBackColor = true;
            this.Clients.Click += new System.EventHandler(this.Clients_Click);
            // 
            // Projects
            // 
            this.Projects.Location = new System.Drawing.Point(283, 118);
            this.Projects.Name = "Projects";
            this.Projects.Size = new System.Drawing.Size(261, 46);
            this.Projects.TabIndex = 4;
            this.Projects.Text = "See All Projects";
            this.Projects.UseVisualStyleBackColor = true;
            this.Projects.Click += new System.EventHandler(this.Projects_Click);
            // 
            // Finances
            // 
            this.Finances.Location = new System.Drawing.Point(283, 383);
            this.Finances.Name = "Finances";
            this.Finances.Size = new System.Drawing.Size(261, 46);
            this.Finances.TabIndex = 5;
            this.Finances.Text = "See All Finances Information";
            this.Finances.UseVisualStyleBackColor = true;
            this.Finances.Click += new System.EventHandler(this.Finances_Click);
            // 
            // Suppliers
            // 
            this.Suppliers.Location = new System.Drawing.Point(283, 452);
            this.Suppliers.Name = "Suppliers";
            this.Suppliers.Size = new System.Drawing.Size(261, 46);
            this.Suppliers.TabIndex = 6;
            this.Suppliers.Text = "See All Suppliers";
            this.Suppliers.UseVisualStyleBackColor = true;
            this.Suppliers.Click += new System.EventHandler(this.Suppliers_Click);
            // 
            // States
            // 
            this.States.Location = new System.Drawing.Point(283, 526);
            this.States.Name = "States";
            this.States.Size = new System.Drawing.Size(261, 46);
            this.States.TabIndex = 7;
            this.States.Text = "See All States";
            this.States.UseVisualStyleBackColor = true;
            this.States.Click += new System.EventHandler(this.States_Click);
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.Red;
            this.Quit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Quit.Location = new System.Drawing.Point(283, 598);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(261, 46);
            this.Quit.TabIndex = 8;
            this.Quit.Text = "Quit Application";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 667);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.States);
            this.Controls.Add(this.Suppliers);
            this.Controls.Add(this.Finances);
            this.Controls.Add(this.Projects);
            this.Controls.Add(this.Clients);
            this.Controls.Add(this.Architects);
            this.Controls.Add(this.Agents);
            this.Controls.Add(this.Branches);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "DASHBOARD";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button Branches;
        private System.Windows.Forms.Button Agents;
        private System.Windows.Forms.Button Architects;
        private System.Windows.Forms.Button Clients;
        private System.Windows.Forms.Button Projects;
        private System.Windows.Forms.Button Finances;
        private System.Windows.Forms.Button Suppliers;
        private System.Windows.Forms.Button States;
        private System.Windows.Forms.Button Quit;

        #endregion
    }
}