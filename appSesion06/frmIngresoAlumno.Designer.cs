namespace appSesion06
{
    partial class frmIngresoAlumno
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
            this.txtCursos = new System.Windows.Forms.Label();
            this.lbCursos = new System.Windows.Forms.ListBox();
            this.btnIngresarAlumno = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtNombreCompleto = new System.Windows.Forms.Label();
            this.txtTIU = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCursos
            // 
            this.txtCursos.AutoSize = true;
            this.txtCursos.Location = new System.Drawing.Point(493, 27);
            this.txtCursos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtCursos.Name = "txtCursos";
            this.txtCursos.Size = new System.Drawing.Size(52, 17);
            this.txtCursos.TabIndex = 18;
            this.txtCursos.Text = "Cursos";
            // 
            // lbCursos
            // 
            this.lbCursos.FormattingEnabled = true;
            this.lbCursos.ItemHeight = 16;
            this.lbCursos.Location = new System.Drawing.Point(497, 61);
            this.lbCursos.Margin = new System.Windows.Forms.Padding(4);
            this.lbCursos.Name = "lbCursos";
            this.lbCursos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbCursos.Size = new System.Drawing.Size(306, 356);
            this.lbCursos.TabIndex = 17;
            // 
            // btnIngresarAlumno
            // 
            this.btnIngresarAlumno.Location = new System.Drawing.Point(135, 187);
            this.btnIngresarAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresarAlumno.Name = "btnIngresarAlumno";
            this.btnIngresarAlumno.Size = new System.Drawing.Size(148, 28);
            this.btnIngresarAlumno.TabIndex = 16;
            this.btnIngresarAlumno.Text = "Matricula";
            this.btnIngresarAlumno.UseVisualStyleBackColor = true;
            this.btnIngresarAlumno.Click += new System.EventHandler(this.btnIngresarAlumno_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(17, 128);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(266, 22);
            this.textBox2.TabIndex = 15;
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.AutoSize = true;
            this.txtNombreCompleto.Location = new System.Drawing.Point(13, 89);
            this.txtNombreCompleto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(121, 17);
            this.txtNombreCompleto.TabIndex = 14;
            this.txtNombreCompleto.Text = "Nombre Completo";
            // 
            // txtTIU
            // 
            this.txtTIU.AutoSize = true;
            this.txtTIU.Location = new System.Drawing.Point(13, 27);
            this.txtTIU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTIU.Name = "txtTIU";
            this.txtTIU.Size = new System.Drawing.Size(30, 17);
            this.txtTIU.TabIndex = 13;
            this.txtTIU.Text = "TIU";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 61);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 22);
            this.textBox1.TabIndex = 12;
            // 
            // frmIngresoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 533);
            this.Controls.Add(this.txtCursos);
            this.Controls.Add(this.lbCursos);
            this.Controls.Add(this.btnIngresarAlumno);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.txtTIU);
            this.Controls.Add(this.textBox1);
            this.Name = "frmIngresoAlumno";
            this.Text = "frmIngresoAlumno";
            this.Load += new System.EventHandler(this.frmIngresoAlumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtCursos;
        private System.Windows.Forms.ListBox lbCursos;
        private System.Windows.Forms.Button btnIngresarAlumno;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtNombreCompleto;
        private System.Windows.Forms.Label txtTIU;
        private System.Windows.Forms.TextBox textBox1;
    }
}