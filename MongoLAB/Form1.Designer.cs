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
            this.panel1 = new System.Windows.Forms.Panel();
            this.consultaCompaBtn = new System.Windows.Forms.Button();
            this.consultarAnnoBtn = new System.Windows.Forms.Button();
            this.consultaFranquiBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.registroCompaBtn = new System.Windows.Forms.Button();
            this.registroPeliBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.consultaPeliAnno = new MongoLAB.ConsultaPeliAnno();
            this.consultaPeliNombre = new MongoLAB.ConsultaPeliNombre();
            this.registrarCompania = new MongoLAB.RegistrarCompania();
            this.registrarPelicula = new MongoLAB.RegistrarPelicula();
            this.consultaPeliFranquicia = new MongoLAB.ConsultaPeliFranquicia();
            this.consultaPeliCompania = new MongoLAB.ConsultaPeliCompania();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
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
            // consultaCompaBtn
            // 
            this.consultaCompaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.consultaCompaBtn.Location = new System.Drawing.Point(15, 342);
            this.consultaCompaBtn.Name = "consultaCompaBtn";
            this.consultaCompaBtn.Size = new System.Drawing.Size(245, 60);
            this.consultaCompaBtn.TabIndex = 5;
            this.consultaCompaBtn.Text = "Consultar por compañía";
            this.consultaCompaBtn.UseVisualStyleBackColor = true;
            this.consultaCompaBtn.Click += new System.EventHandler(this.consultaCompaBtn_Click);
            // 
            // consultarAnnoBtn
            // 
            this.consultarAnnoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.consultarAnnoBtn.Location = new System.Drawing.Point(15, 276);
            this.consultarAnnoBtn.Name = "consultarAnnoBtn";
            this.consultarAnnoBtn.Size = new System.Drawing.Size(245, 60);
            this.consultarAnnoBtn.TabIndex = 4;
            this.consultarAnnoBtn.Text = "Consultar por año";
            this.consultarAnnoBtn.UseVisualStyleBackColor = true;
            this.consultarAnnoBtn.Click += new System.EventHandler(this.consultarAnnoBtn_Click);
            // 
            // consultaFranquiBtn
            // 
            this.consultaFranquiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.consultaFranquiBtn.Location = new System.Drawing.Point(15, 210);
            this.consultaFranquiBtn.Name = "consultaFranquiBtn";
            this.consultaFranquiBtn.Size = new System.Drawing.Size(245, 60);
            this.consultaFranquiBtn.TabIndex = 3;
            this.consultaFranquiBtn.Text = "Consultar por Franquicia";
            this.consultaFranquiBtn.UseVisualStyleBackColor = true;
            this.consultaFranquiBtn.Click += new System.EventHandler(this.consultaFranquiBtn_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.Location = new System.Drawing.Point(15, 144);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(245, 60);
            this.button3.TabIndex = 2;
            this.button3.Text = "Consultar por título";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // registroCompaBtn
            // 
            this.registroCompaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registroCompaBtn.Location = new System.Drawing.Point(15, 78);
            this.registroCompaBtn.Name = "registroCompaBtn";
            this.registroCompaBtn.Size = new System.Drawing.Size(245, 60);
            this.registroCompaBtn.TabIndex = 1;
            this.registroCompaBtn.Text = "Registrar Compañía";
            this.registroCompaBtn.UseVisualStyleBackColor = true;
            this.registroCompaBtn.Click += new System.EventHandler(this.registroCompaBtn_Click);
            // 
            // registroPeliBtn
            // 
            this.registroPeliBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registroPeliBtn.Location = new System.Drawing.Point(15, 12);
            this.registroPeliBtn.Name = "registroPeliBtn";
            this.registroPeliBtn.Size = new System.Drawing.Size(245, 60);
            this.registroPeliBtn.TabIndex = 0;
            this.registroPeliBtn.Text = "Registrar Película";
            this.registroPeliBtn.UseVisualStyleBackColor = true;
            this.registroPeliBtn.Click += new System.EventHandler(this.registroPeliBtn_Click);
            // 
            // consultaPeliAnno
            // 
            this.consultaPeliAnno.Location = new System.Drawing.Point(311, 6);
            this.consultaPeliAnno.Name = "consultaPeliAnno";
            this.consultaPeliAnno.Size = new System.Drawing.Size(619, 481);
            this.consultaPeliAnno.TabIndex = 5;
            // 
            // consultaPeliNombre
            // 
            this.consultaPeliNombre.Location = new System.Drawing.Point(311, 6);
            this.consultaPeliNombre.Name = "consultaPeliNombre";
            this.consultaPeliNombre.Size = new System.Drawing.Size(619, 481);
            this.consultaPeliNombre.TabIndex = 3;
            // 
            // registrarCompania
            // 
            this.registrarCompania.Location = new System.Drawing.Point(311, 6);
            this.registrarCompania.Name = "registrarCompania";
            this.registrarCompania.Size = new System.Drawing.Size(619, 481);
            this.registrarCompania.TabIndex = 2;
            // 
            // registrarPelicula
            // 
            this.registrarPelicula.Location = new System.Drawing.Point(311, 6);
            this.registrarPelicula.Name = "registrarPelicula";
            this.registrarPelicula.Size = new System.Drawing.Size(619, 481);
            this.registrarPelicula.TabIndex = 0;
            // 
            // consultaPeliFranquicia
            // 
            this.consultaPeliFranquicia.Location = new System.Drawing.Point(311, 6);
            this.consultaPeliFranquicia.Name = "consultaPeliFranquicia";
            this.consultaPeliFranquicia.Size = new System.Drawing.Size(619, 481);
            this.consultaPeliFranquicia.TabIndex = 4;
            // 
            // consultaPeliCompania
            // 
            this.consultaPeliCompania.Location = new System.Drawing.Point(311, 6);
            this.consultaPeliCompania.Name = "consultaPeliCompania";
            this.consultaPeliCompania.Size = new System.Drawing.Size(619, 481);
            this.consultaPeliCompania.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 499);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.consultaPeliFranquicia);
            this.Controls.Add(this.consultaPeliCompania);
            this.Controls.Add(this.consultaPeliAnno);
            this.Controls.Add(this.consultaPeliNombre);
            this.Controls.Add(this.registrarCompania);
            this.Controls.Add(this.registrarPelicula);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RegistrarPelicula registrarPelicula;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button consultarAnnoBtn;
        private System.Windows.Forms.Button consultaFranquiBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button registroCompaBtn;
        private System.Windows.Forms.Button registroPeliBtn;
        private System.Windows.Forms.Button consultaCompaBtn;
        private RegistrarCompania registrarCompania;
        private ConsultaPeliNombre consultaPeliNombre;
        private ConsultaPeliFranquicia consultaPeliFranquicia;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ConsultaPeliAnno consultaPeliAnno;
        private ConsultaPeliCompania consultaPeliCompania;
    }
}

