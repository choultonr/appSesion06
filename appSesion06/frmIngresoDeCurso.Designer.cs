namespace appSesion06
{
    partial class frmIngresoDeCurso
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
            this.btnIngresarCurso = new System.Windows.Forms.Button();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIngresarCurso
            // 
            this.btnIngresarCurso.Location = new System.Drawing.Point(180, 202);
            this.btnIngresarCurso.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresarCurso.Name = "btnIngresarCurso";
            this.btnIngresarCurso.Size = new System.Drawing.Size(148, 28);
            this.btnIngresarCurso.TabIndex = 9;
            this.btnIngresarCurso.Text = "Ingresar Curso";
            this.btnIngresarCurso.UseVisualStyleBackColor = true;
            this.btnIngresarCurso.Click += new System.EventHandler(this.btnIngresarCurso_Click);
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(61, 143);
            this.txtNombreCurso.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(265, 22);
            this.txtNombreCurso.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre Del Curso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(61, 62);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(265, 22);
            this.txtCodigo.TabIndex = 5;
            // 
            // frmIngresoDeCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 273);
            this.Controls.Add(this.btnIngresarCurso);
            this.Controls.Add(this.txtNombreCurso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo);
            this.Name = "frmIngresoDeCurso";
            this.Text = "frmIngresoDeCurso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarCurso;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}