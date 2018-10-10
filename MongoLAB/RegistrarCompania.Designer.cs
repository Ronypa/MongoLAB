namespace MongoLAB
{
    partial class RegistrarCompania
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.webBox = new System.Windows.Forms.TextBox();
            this.fundacionBox = new System.Windows.Forms.TextBox();
            this.registrarCompa = new System.Windows.Forms.Button();
            this.nombreBox = new System.Windows.Forms.TextBox();
            this.WebCompa = new System.Windows.Forms.Label();
            this.AnnoCompa = new System.Windows.Forms.Label();
            this.NombreCompa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 25);
            this.label1.TabIndex = 58;
            this.label1.Text = "Registro de Compañías";
            // 
            // webBox
            // 
            this.webBox.Location = new System.Drawing.Point(182, 152);
            this.webBox.Name = "webBox";
            this.webBox.Size = new System.Drawing.Size(186, 20);
            this.webBox.TabIndex = 51;
            // 
            // fundacionBox
            // 
            this.fundacionBox.Location = new System.Drawing.Point(182, 112);
            this.fundacionBox.Name = "fundacionBox";
            this.fundacionBox.Size = new System.Drawing.Size(186, 20);
            this.fundacionBox.TabIndex = 50;
            // 
            // registrarCompa
            // 
            this.registrarCompa.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.registrarCompa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarCompa.Location = new System.Drawing.Point(438, 247);
            this.registrarCompa.Name = "registrarCompa";
            this.registrarCompa.Size = new System.Drawing.Size(162, 34);
            this.registrarCompa.TabIndex = 49;
            this.registrarCompa.Text = "Registrar";
            this.registrarCompa.UseVisualStyleBackColor = false;
            this.registrarCompa.Click += new System.EventHandler(this.registrarCompa_Click);
            // 
            // nombreBox
            // 
            this.nombreBox.Location = new System.Drawing.Point(182, 72);
            this.nombreBox.Name = "nombreBox";
            this.nombreBox.Size = new System.Drawing.Size(186, 20);
            this.nombreBox.TabIndex = 48;
            // 
            // WebCompa
            // 
            this.WebCompa.AutoSize = true;
            this.WebCompa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebCompa.Location = new System.Drawing.Point(0, 156);
            this.WebCompa.Name = "WebCompa";
            this.WebCompa.Size = new System.Drawing.Size(40, 16);
            this.WebCompa.TabIndex = 41;
            this.WebCompa.Text = "Web:";
            // 
            // AnnoCompa
            // 
            this.AnnoCompa.AutoSize = true;
            this.AnnoCompa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnnoCompa.Location = new System.Drawing.Point(0, 116);
            this.AnnoCompa.Name = "AnnoCompa";
            this.AnnoCompa.Size = new System.Drawing.Size(115, 16);
            this.AnnoCompa.TabIndex = 40;
            this.AnnoCompa.Text = "Año de fundación:";
            // 
            // NombreCompa
            // 
            this.NombreCompa.AutoSize = true;
            this.NombreCompa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreCompa.Location = new System.Drawing.Point(0, 76);
            this.NombreCompa.Name = "NombreCompa";
            this.NombreCompa.Size = new System.Drawing.Size(60, 16);
            this.NombreCompa.TabIndex = 39;
            this.NombreCompa.Text = "Nombre:";
            // 
            // RegistrarCompania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBox);
            this.Controls.Add(this.fundacionBox);
            this.Controls.Add(this.registrarCompa);
            this.Controls.Add(this.nombreBox);
            this.Controls.Add(this.WebCompa);
            this.Controls.Add(this.AnnoCompa);
            this.Controls.Add(this.NombreCompa);
            this.Name = "RegistrarCompania";
            this.Size = new System.Drawing.Size(600, 281);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox webBox;
        private System.Windows.Forms.TextBox fundacionBox;
        private System.Windows.Forms.Button registrarCompa;
        private System.Windows.Forms.TextBox nombreBox;
        private System.Windows.Forms.Label WebCompa;
        private System.Windows.Forms.Label AnnoCompa;
        private System.Windows.Forms.Label NombreCompa;
    }
}
