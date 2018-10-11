namespace MongoLAB
{
    partial class ConsultaPeliCompania
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
            this.nombreCompaBox = new System.Windows.Forms.TextBox();
            this.buscarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.peliDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // peliDGV
            // 
            this.peliDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.peliDGV.Location = new System.Drawing.Point(3, 105);
            this.peliDGV.Name = "peliDGV";
            this.peliDGV.Size = new System.Drawing.Size(601, 209);
            this.peliDGV.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(217, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Buscar película por compañía";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre:";
            // 
            // nombreCompaBox
            // 
            this.nombreCompaBox.Location = new System.Drawing.Point(87, 67);
            this.nombreCompaBox.Name = "nombreCompaBox";
            this.nombreCompaBox.Size = new System.Drawing.Size(194, 20);
            this.nombreCompaBox.TabIndex = 11;
            // 
            // buscarBtn
            // 
            this.buscarBtn.Location = new System.Drawing.Point(296, 65);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(75, 23);
            this.buscarBtn.TabIndex = 10;
            this.buscarBtn.Text = "Buscar";
            this.buscarBtn.UseVisualStyleBackColor = true;
            this.buscarBtn.Click += new System.EventHandler(this.buscarBtn_Click);
            // 
            // ConsultaPeliCompania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.peliDGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombreCompaBox);
            this.Controls.Add(this.buscarBtn);
            this.Name = "ConsultaPeliCompania";
            this.Size = new System.Drawing.Size(607, 317);
            ((System.ComponentModel.ISupportInitialize)(this.peliDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView peliDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreCompaBox;
        private System.Windows.Forms.Button buscarBtn;
    }
}
