namespace MongoLAB
{
    partial class ConsultaPeliAnno
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
            this.peliDGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inicioBox = new System.Windows.Forms.TextBox();
            this.buscarBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.finalBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.peliDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // peliDGV
            // 
            this.peliDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.peliDGV.Location = new System.Drawing.Point(3, 104);
            this.peliDGV.Name = "peliDGV";
            this.peliDGV.Size = new System.Drawing.Size(601, 209);
            this.peliDGV.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(162, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Buscar película por rango de años";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Desde:";
            // 
            // inicioBox
            // 
            this.inicioBox.Location = new System.Drawing.Point(47, 66);
            this.inicioBox.Name = "inicioBox";
            this.inicioBox.Size = new System.Drawing.Size(104, 20);
            this.inicioBox.TabIndex = 11;
            // 
            // buscarBtn
            // 
            this.buscarBtn.Location = new System.Drawing.Point(414, 64);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(75, 23);
            this.buscarBtn.TabIndex = 10;
            this.buscarBtn.Text = "Buscar";
            this.buscarBtn.UseVisualStyleBackColor = true;
            this.buscarBtn.Click += new System.EventHandler(this.buscarBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Hasta:";
            // 
            // finalBox
            // 
            this.finalBox.Location = new System.Drawing.Point(234, 66);
            this.finalBox.Name = "finalBox";
            this.finalBox.Size = new System.Drawing.Size(104, 20);
            this.finalBox.TabIndex = 15;
            // 
            // ConsultaPeliAnno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.finalBox);
            this.Controls.Add(this.peliDGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inicioBox);
            this.Controls.Add(this.buscarBtn);
            this.Name = "ConsultaPeliAnno";
            this.Size = new System.Drawing.Size(607, 316);
            ((System.ComponentModel.ISupportInitialize)(this.peliDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView peliDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inicioBox;
        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox finalBox;
    }
}
