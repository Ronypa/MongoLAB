namespace MongoLAB
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
            this.registrarPelicula1 = new MongoLAB.RegistrarPelicula();
            this.panel1 = new System.Windows.Forms.Panel();
            this.registroPeliBtn = new System.Windows.Forms.Button();
            this.registroCompaBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.consultaFranquiBtn = new System.Windows.Forms.Button();
            this.consultarAnnoBtn = new System.Windows.Forms.Button();
            this.consultaCompaBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // registrarPelicula1
            // 
            this.registrarPelicula1.Location = new System.Drawing.Point(311, 6);
            this.registrarPelicula1.Name = "registrarPelicula1";
            this.registrarPelicula1.Size = new System.Drawing.Size(619, 481);
            this.registrarPelicula1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.consultaCompaBtn);
            this.panel1.Controls.Add(this.consultarAnnoBtn);
            this.panel1.Controls.Add(this.consultaFranquiBtn);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.registroCompaBtn);
            this.panel1.Controls.Add(this.registroPeliBtn);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 481);
            this.panel1.TabIndex = 1;
            // 
            // registroPeliBtn
            // 
            this.registroPeliBtn.Location = new System.Drawing.Point(15, 12);
            this.registroPeliBtn.Name = "registroPeliBtn";
            this.registroPeliBtn.Size = new System.Drawing.Size(245, 60);
            this.registroPeliBtn.TabIndex = 0;
            this.registroPeliBtn.Text = "Registrar Película";
            this.registroPeliBtn.UseVisualStyleBackColor = true;
            // 
            // registroCompaBtn
            // 
            this.registroCompaBtn.Location = new System.Drawing.Point(15, 78);
            this.registroCompaBtn.Name = "registroCompaBtn";
            this.registroCompaBtn.Size = new System.Drawing.Size(245, 60);
            this.registroCompaBtn.TabIndex = 1;
            this.registroCompaBtn.Text = "Registrar Compañía";
            this.registroCompaBtn.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 144);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(245, 60);
            this.button3.TabIndex = 2;
            this.button3.Text = "Consultar por título";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // consultaFranquiBtn
            // 
            this.consultaFranquiBtn.Location = new System.Drawing.Point(15, 210);
            this.consultaFranquiBtn.Name = "consultaFranquiBtn";
            this.consultaFranquiBtn.Size = new System.Drawing.Size(245, 60);
            this.consultaFranquiBtn.TabIndex = 3;
            this.consultaFranquiBtn.Text = "Consultar por Franquicia";
            this.consultaFranquiBtn.UseVisualStyleBackColor = true;
            // 
            // consultarAnnoBtn
            // 
            this.consultarAnnoBtn.Location = new System.Drawing.Point(15, 276);
            this.consultarAnnoBtn.Name = "consultarAnnoBtn";
            this.consultarAnnoBtn.Size = new System.Drawing.Size(245, 60);
            this.consultarAnnoBtn.TabIndex = 4;
            this.consultarAnnoBtn.Text = "Consultar por año";
            this.consultarAnnoBtn.UseVisualStyleBackColor = true;
            // 
            // consultaCompaBtn
            // 
            this.consultaCompaBtn.Location = new System.Drawing.Point(15, 342);
            this.consultaCompaBtn.Name = "consultaCompaBtn";
            this.consultaCompaBtn.Size = new System.Drawing.Size(245, 60);
            this.consultaCompaBtn.TabIndex = 5;
            this.consultaCompaBtn.Text = "Consultar por compañía";
            this.consultaCompaBtn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 60);
            this.button2.TabIndex = 6;
            this.button2.Text = "Consultar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 499);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.registrarPelicula1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RegistrarPelicula registrarPelicula1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button consultarAnnoBtn;
        private System.Windows.Forms.Button consultaFranquiBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button registroCompaBtn;
        private System.Windows.Forms.Button registroPeliBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button consultaCompaBtn;
    }
}

