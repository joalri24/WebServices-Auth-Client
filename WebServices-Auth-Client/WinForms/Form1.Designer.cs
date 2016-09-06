namespace WinForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.flowLayoutFondo = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStripButtonCargar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonCargar,
            this.toolStripButtonAgregar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(798, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // flowLayoutFondo
            // 
            this.flowLayoutFondo.AutoScroll = true;
            this.flowLayoutFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutFondo.Location = new System.Drawing.Point(0, 25);
            this.flowLayoutFondo.Name = "flowLayoutFondo";
            this.flowLayoutFondo.Size = new System.Drawing.Size(798, 332);
            this.flowLayoutFondo.TabIndex = 1;
            // 
            // toolStripButtonCargar
            // 
            this.toolStripButtonCargar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCargar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCargar.Image")));
            this.toolStripButtonCargar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCargar.Name = "toolStripButtonCargar";
            this.toolStripButtonCargar.Size = new System.Drawing.Size(46, 22);
            this.toolStripButtonCargar.Text = "Cargar";
            this.toolStripButtonCargar.Click += new System.EventHandler(this.ObtenerHeroes);
            // 
            // toolStripButtonAgregar
            // 
            this.toolStripButtonAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAgregar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAgregar.Image")));
            this.toolStripButtonAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAgregar.Name = "toolStripButtonAgregar";
            this.toolStripButtonAgregar.Size = new System.Drawing.Size(53, 22);
            this.toolStripButtonAgregar.Text = "Agregar";
            this.toolStripButtonAgregar.Click += new System.EventHandler(this.AgregarHero);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 357);
            this.Controls.Add(this.flowLayoutFondo);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Web Services Prueba";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutFondo;
        private System.Windows.Forms.ToolStripButton toolStripButtonCargar;
        private System.Windows.Forms.ToolStripButton toolStripButtonAgregar;
    }
}

