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
            this.toolStripButtonLogin = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLogout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCargar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelMensaje = new System.Windows.Forms.ToolStripLabel();
            this.flowLayoutFondo = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonLogin,
            this.toolStripButtonLogout,
            this.toolStripSeparator1,
            this.toolStripButtonCargar,
            this.toolStripButtonAgregar,
            this.toolStripSeparator2,
            this.toolStripLabelMensaje});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(798, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonLogin
            // 
            this.toolStripButtonLogin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonLogin.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLogin.Image")));
            this.toolStripButtonLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLogin.Name = "toolStripButtonLogin";
            this.toolStripButtonLogin.Size = new System.Drawing.Size(79, 22);
            this.toolStripButtonLogin.Text = "Iniciar sesión";
            this.toolStripButtonLogin.Click += new System.EventHandler(this.IniciarSesion);
            // 
            // toolStripButtonLogout
            // 
            this.toolStripButtonLogout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonLogout.Enabled = false;
            this.toolStripButtonLogout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLogout.Image")));
            this.toolStripButtonLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLogout.Name = "toolStripButtonLogout";
            this.toolStripButtonLogout.Size = new System.Drawing.Size(79, 22);
            this.toolStripButtonLogout.Text = "Cerrar sesión";
            this.toolStripButtonLogout.Click += new System.EventHandler(this.CerrarSesion);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelMensaje
            // 
            this.toolStripLabelMensaje.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabelMensaje.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.toolStripLabelMensaje.Name = "toolStripLabelMensaje";
            this.toolStripLabelMensaje.Size = new System.Drawing.Size(290, 22);
            this.toolStripLabelMensaje.Text = "Se debe iniciar sesión para obtener acceso a los datos.";
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
        private System.Windows.Forms.ToolStripButton toolStripButtonLogin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabelMensaje;
        private System.Windows.Forms.ToolStripButton toolStripButtonLogout;
    }
}

