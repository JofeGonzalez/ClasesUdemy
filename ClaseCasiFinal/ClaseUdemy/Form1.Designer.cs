namespace ClaseUdemy
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ExaminarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbDatos = new System.Windows.Forms.ListBox();
            this.BorrarBtn = new System.Windows.Forms.Button();
            this.cbArchivos = new System.Windows.Forms.ComboBox();
            this.FiltrarBtn = new System.Windows.Forms.Button();
            this.ErrorDatos = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ruta";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 1;
            // 
            // ExaminarBtn
            // 
            this.ExaminarBtn.Location = new System.Drawing.Point(222, 16);
            this.ExaminarBtn.Name = "ExaminarBtn";
            this.ExaminarBtn.Size = new System.Drawing.Size(60, 19);
            this.ExaminarBtn.TabIndex = 2;
            this.ExaminarBtn.Text = "Examinar";
            this.ExaminarBtn.UseVisualStyleBackColor = true;
            this.ExaminarBtn.Click += new System.EventHandler(this.ExaminarBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbDatos);
            this.groupBox1.Controls.Add(this.BorrarBtn);
            this.groupBox1.Controls.Add(this.cbArchivos);
            this.groupBox1.Controls.Add(this.FiltrarBtn);
            this.groupBox1.Location = new System.Drawing.Point(3, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 197);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda de Archivos";
            // 
            // lbDatos
            // 
            this.lbDatos.FormattingEnabled = true;
            this.lbDatos.Location = new System.Drawing.Point(12, 102);
            this.lbDatos.Name = "lbDatos";
            this.lbDatos.Size = new System.Drawing.Size(267, 82);
            this.lbDatos.TabIndex = 6;
            this.lbDatos.DoubleClick += new System.EventHandler(this.SeleccionarArchivo);
            // 
            // BorrarBtn
            // 
            this.BorrarBtn.Location = new System.Drawing.Point(162, 77);
            this.BorrarBtn.Name = "BorrarBtn";
            this.BorrarBtn.Size = new System.Drawing.Size(60, 19);
            this.BorrarBtn.TabIndex = 5;
            this.BorrarBtn.Text = "Borrar";
            this.BorrarBtn.UseVisualStyleBackColor = true;
            this.BorrarBtn.Click += new System.EventHandler(this.BorrarBtn_Click);
            // 
            // cbArchivos
            // 
            this.cbArchivos.FormattingEnabled = true;
            this.cbArchivos.Location = new System.Drawing.Point(49, 39);
            this.cbArchivos.Name = "cbArchivos";
            this.cbArchivos.Size = new System.Drawing.Size(201, 21);
            this.cbArchivos.TabIndex = 0;
            // 
            // FiltrarBtn
            // 
            this.FiltrarBtn.Location = new System.Drawing.Point(83, 77);
            this.FiltrarBtn.Name = "FiltrarBtn";
            this.FiltrarBtn.Size = new System.Drawing.Size(60, 19);
            this.FiltrarBtn.TabIndex = 4;
            this.FiltrarBtn.Text = "Filtrar";
            this.FiltrarBtn.UseVisualStyleBackColor = true;
            this.FiltrarBtn.Click += new System.EventHandler(this.FiltrarBtn_Click);
            // 
            // ErrorDatos
            // 
            this.ErrorDatos.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 245);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ExaminarBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ExaminarBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbDatos;
        private System.Windows.Forms.Button BorrarBtn;
        private System.Windows.Forms.ComboBox cbArchivos;
        private System.Windows.Forms.Button FiltrarBtn;
        private System.Windows.Forms.ErrorProvider ErrorDatos;
    }
}

