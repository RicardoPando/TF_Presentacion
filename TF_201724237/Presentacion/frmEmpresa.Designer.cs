namespace SI33_Plantilla
{
    partial class frmEmpresa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtRUCempresa = new System.Windows.Forms.TextBox();
            this.txtDireccionEmpresa = new System.Windows.Forms.TextBox();
            this.txtTelefonoEmpresa = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInsertarEmpresa = new System.Windows.Forms.Button();
            this.btnGrabarEmpresa = new System.Windows.Forms.Button();
            this.btnLeerEmpresa = new System.Windows.Forms.Button();
            this.dtgvEmpresa = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Razon Social:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "RUC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono:";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(189, 51);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(100, 20);
            this.txtRazonSocial.TabIndex = 4;
            // 
            // txtRUCempresa
            // 
            this.txtRUCempresa.Location = new System.Drawing.Point(189, 114);
            this.txtRUCempresa.Name = "txtRUCempresa";
            this.txtRUCempresa.Size = new System.Drawing.Size(100, 20);
            this.txtRUCempresa.TabIndex = 5;
            // 
            // txtDireccionEmpresa
            // 
            this.txtDireccionEmpresa.Location = new System.Drawing.Point(417, 51);
            this.txtDireccionEmpresa.Name = "txtDireccionEmpresa";
            this.txtDireccionEmpresa.Size = new System.Drawing.Size(100, 20);
            this.txtDireccionEmpresa.TabIndex = 6;
            // 
            // txtTelefonoEmpresa
            // 
            this.txtTelefonoEmpresa.Location = new System.Drawing.Point(417, 118);
            this.txtTelefonoEmpresa.Name = "txtTelefonoEmpresa";
            this.txtTelefonoEmpresa.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonoEmpresa.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLeerEmpresa);
            this.groupBox1.Controls.Add(this.txtTelefonoEmpresa);
            this.groupBox1.Controls.Add(this.btnGrabarEmpresa);
            this.groupBox1.Controls.Add(this.txtDireccionEmpresa);
            this.groupBox1.Controls.Add(this.btnInsertarEmpresa);
            this.groupBox1.Controls.Add(this.txtRUCempresa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtRazonSocial);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 222);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empresa";
            // 
            // btnInsertarEmpresa
            // 
            this.btnInsertarEmpresa.Location = new System.Drawing.Point(85, 180);
            this.btnInsertarEmpresa.Name = "btnInsertarEmpresa";
            this.btnInsertarEmpresa.Size = new System.Drawing.Size(160, 36);
            this.btnInsertarEmpresa.TabIndex = 0;
            this.btnInsertarEmpresa.Text = "Insertar";
            this.btnInsertarEmpresa.UseVisualStyleBackColor = true;
            this.btnInsertarEmpresa.Click += new System.EventHandler(this.btnInsertarEmpresa_Click);
            // 
            // btnGrabarEmpresa
            // 
            this.btnGrabarEmpresa.Location = new System.Drawing.Point(251, 180);
            this.btnGrabarEmpresa.Name = "btnGrabarEmpresa";
            this.btnGrabarEmpresa.Size = new System.Drawing.Size(160, 36);
            this.btnGrabarEmpresa.TabIndex = 1;
            this.btnGrabarEmpresa.Text = "Grabar";
            this.btnGrabarEmpresa.UseVisualStyleBackColor = true;
            this.btnGrabarEmpresa.Click += new System.EventHandler(this.btnGrabarEmpresa_Click);
            // 
            // btnLeerEmpresa
            // 
            this.btnLeerEmpresa.Location = new System.Drawing.Point(417, 180);
            this.btnLeerEmpresa.Name = "btnLeerEmpresa";
            this.btnLeerEmpresa.Size = new System.Drawing.Size(160, 36);
            this.btnLeerEmpresa.TabIndex = 2;
            this.btnLeerEmpresa.Text = "Leer";
            this.btnLeerEmpresa.UseVisualStyleBackColor = true;
            this.btnLeerEmpresa.Click += new System.EventHandler(this.btnLeerEmpresa_Click);
            // 
            // dtgvEmpresa
            // 
            this.dtgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEmpresa.Location = new System.Drawing.Point(12, 234);
            this.dtgvEmpresa.Name = "dtgvEmpresa";
            this.dtgvEmpresa.Size = new System.Drawing.Size(615, 133);
            this.dtgvEmpresa.TabIndex = 9;
            // 
            // frmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 372);
            this.Controls.Add(this.dtgvEmpresa);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEmpresa";
            this.Text = "frmEmpresa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmpresa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtRUCempresa;
        private System.Windows.Forms.TextBox txtDireccionEmpresa;
        private System.Windows.Forms.TextBox txtTelefonoEmpresa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLeerEmpresa;
        private System.Windows.Forms.Button btnGrabarEmpresa;
        private System.Windows.Forms.Button btnInsertarEmpresa;
        private System.Windows.Forms.DataGridView dtgvEmpresa;
    }
}