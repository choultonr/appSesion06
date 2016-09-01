namespace appSesion06
{
    partial class frmListarAlumnosMatriculados
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAlumnos = new System.Windows.Forms.ListBox();
            this.lbCursos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(691, 497);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Alumnos Matriculados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cursos";
            // 
            // lbAlumnos
            // 
            this.lbAlumnos.FormattingEnabled = true;
            this.lbAlumnos.ItemHeight = 16;
            this.lbAlumnos.Location = new System.Drawing.Point(423, 102);
            this.lbAlumnos.Margin = new System.Windows.Forms.Padding(4);
            this.lbAlumnos.Name = "lbAlumnos";
            this.lbAlumnos.Size = new System.Drawing.Size(367, 340);
            this.lbAlumnos.TabIndex = 6;
            // 
            // lbCursos
            // 
            this.lbCursos.FormattingEnabled = true;
            this.lbCursos.ItemHeight = 16;
            this.lbCursos.Location = new System.Drawing.Point(26, 102);
            this.lbCursos.Margin = new System.Windows.Forms.Padding(4);
            this.lbCursos.Name = "lbCursos";
            this.lbCursos.Size = new System.Drawing.Size(337, 340);
            this.lbCursos.TabIndex = 5;
            this.lbCursos.SelectedIndexChanged += new System.EventHandler(this.lbCursos_SelectedIndexChanged);
            // 
            // frmListarAlumnosMatriculados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 566);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAlumnos);
            this.Controls.Add(this.lbCursos);
            this.Name = "frmListarAlumnosMatriculados";
            this.Text = "frmListarAlumnosMatriculados";
            this.Load += new System.EventHandler(this.frmListarAlumnosMatriculados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbAlumnos;
        private System.Windows.Forms.ListBox lbCursos;
    }
}