namespace appSesion06
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDeCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDeAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarAlumnosMatriculadosEnUnCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosConToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1044, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingresoToolStripMenuItem
            // 
            this.ingresoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoDeCursoToolStripMenuItem,
            this.ingresoDeAlumnoToolStripMenuItem});
            this.ingresoToolStripMenuItem.Name = "ingresoToolStripMenuItem";
            this.ingresoToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.ingresoToolStripMenuItem.Text = "Ingreso";
            // 
            // ingresoDeCursoToolStripMenuItem
            // 
            this.ingresoDeCursoToolStripMenuItem.Name = "ingresoDeCursoToolStripMenuItem";
            this.ingresoDeCursoToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.ingresoDeCursoToolStripMenuItem.Text = "Ingreso de Curso";
            this.ingresoDeCursoToolStripMenuItem.Click += new System.EventHandler(this.ingresoDeCursoToolStripMenuItem_Click);
            // 
            // ingresoDeAlumnoToolStripMenuItem
            // 
            this.ingresoDeAlumnoToolStripMenuItem.Name = "ingresoDeAlumnoToolStripMenuItem";
            this.ingresoDeAlumnoToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.ingresoDeAlumnoToolStripMenuItem.Text = "Ingreso de Alumno";
            this.ingresoDeAlumnoToolStripMenuItem.Click += new System.EventHandler(this.ingresoDeAlumnoToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarAlumnosMatriculadosEnUnCursoToolStripMenuItem,
            this.cursosConToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // listarAlumnosMatriculadosEnUnCursoToolStripMenuItem
            // 
            this.listarAlumnosMatriculadosEnUnCursoToolStripMenuItem.Name = "listarAlumnosMatriculadosEnUnCursoToolStripMenuItem";
            this.listarAlumnosMatriculadosEnUnCursoToolStripMenuItem.Size = new System.Drawing.Size(352, 26);
            this.listarAlumnosMatriculadosEnUnCursoToolStripMenuItem.Text = "Listar Alumnos Matriculados en un Curso";
            this.listarAlumnosMatriculadosEnUnCursoToolStripMenuItem.Click += new System.EventHandler(this.listarAlumnosMatriculadosEnUnCursoToolStripMenuItem_Click);
            // 
            // cursosConToolStripMenuItem
            // 
            this.cursosConToolStripMenuItem.Name = "cursosConToolStripMenuItem";
            this.cursosConToolStripMenuItem.Size = new System.Drawing.Size(352, 26);
            this.cursosConToolStripMenuItem.Text = "Cursos con  mas alumnos";
            this.cursosConToolStripMenuItem.Click += new System.EventHandler(this.cursosConToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 552);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoDeCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoDeAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarAlumnosMatriculadosEnUnCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosConToolStripMenuItem;
    }
}