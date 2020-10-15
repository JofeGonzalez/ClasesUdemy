namespace ClaseUdemy
{
    partial class Form2
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
            this.ImgBtn = new System.Windows.Forms.Button();
            this.RutaTxt = new System.Windows.Forms.TextBox();
            this.ImgPB = new System.Windows.Forms.PictureBox();
            this.MoverBtn = new System.Windows.Forms.Button();
            this.CopiarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPB)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgBtn
            // 
            this.ImgBtn.Location = new System.Drawing.Point(12, 23);
            this.ImgBtn.Name = "ImgBtn";
            this.ImgBtn.Size = new System.Drawing.Size(75, 23);
            this.ImgBtn.TabIndex = 0;
            this.ImgBtn.Text = "Imagen";
            this.ImgBtn.UseVisualStyleBackColor = true;
            this.ImgBtn.Click += new System.EventHandler(this.ImgBtn_Click);
            // 
            // RutaTxt
            // 
            this.RutaTxt.Location = new System.Drawing.Point(102, 25);
            this.RutaTxt.Name = "RutaTxt";
            this.RutaTxt.Size = new System.Drawing.Size(168, 20);
            this.RutaTxt.TabIndex = 1;
            // 
            // ImgPB
            // 
            this.ImgPB.Location = new System.Drawing.Point(12, 70);
            this.ImgPB.Name = "ImgPB";
            this.ImgPB.Size = new System.Drawing.Size(258, 181);
            this.ImgPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgPB.TabIndex = 2;
            this.ImgPB.TabStop = false;
            // 
            // MoverBtn
            // 
            this.MoverBtn.Location = new System.Drawing.Point(57, 265);
            this.MoverBtn.Name = "MoverBtn";
            this.MoverBtn.Size = new System.Drawing.Size(75, 23);
            this.MoverBtn.TabIndex = 3;
            this.MoverBtn.Text = "Mover";
            this.MoverBtn.UseVisualStyleBackColor = true;
            this.MoverBtn.Click += new System.EventHandler(this.MoverBtn_Click);
            // 
            // CopiarBtn
            // 
            this.CopiarBtn.Location = new System.Drawing.Point(150, 265);
            this.CopiarBtn.Name = "CopiarBtn";
            this.CopiarBtn.Size = new System.Drawing.Size(75, 23);
            this.CopiarBtn.TabIndex = 4;
            this.CopiarBtn.Text = "Copiar";
            this.CopiarBtn.UseVisualStyleBackColor = true;
            this.CopiarBtn.Click += new System.EventHandler(this.CopiarBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 300);
            this.Controls.Add(this.CopiarBtn);
            this.Controls.Add(this.MoverBtn);
            this.Controls.Add(this.ImgPB);
            this.Controls.Add(this.RutaTxt);
            this.Controls.Add(this.ImgBtn);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.ImgPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ImgBtn;
        private System.Windows.Forms.TextBox RutaTxt;
        private System.Windows.Forms.PictureBox ImgPB;
        private System.Windows.Forms.Button MoverBtn;
        private System.Windows.Forms.Button CopiarBtn;
    }
}