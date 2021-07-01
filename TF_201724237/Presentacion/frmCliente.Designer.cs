namespace SI33_Plantilla
{
    partial class frmCliente
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
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.txtDNIcliente = new System.Windows.Forms.TextBox();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.btnInsertarCliente = new System.Windows.Forms.Button();
            this.btnGrabarCliente = new System.Windows.Forms.Button();
            this.btnLeerCliente = new System.Windows.Forms.Button();
            this.dtgvCliente = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Documento de Identidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Direccion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teléfono:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLeerCliente);
            this.groupBox1.Controls.Add(this.btnGrabarCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnInsertarCliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTelefonoCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDireccionCliente);
            this.groupBox1.Controls.Add(this.txtDNIcliente);
            this.groupBox1.Controls.Add(this.txtApellidoCliente);
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 210);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(195, 52);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(138, 20);
            this.txtNombreCliente.TabIndex = 0;
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(195, 90);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(138, 20);
            this.txtApellidoCliente.TabIndex = 1;
            // 
            // txtDNIcliente
            // 
            this.txtDNIcliente.Location = new System.Drawing.Point(195, 127);
            this.txtDNIcliente.MaxLength = 8;
            this.txtDNIcliente.Name = "txtDNIcliente";
            this.txtDNIcliente.Size = new System.Drawing.Size(100, 20);
            this.txtDNIcliente.TabIndex = 2;
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Location = new System.Drawing.Point(429, 48);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(181, 20);
            this.txtDireccionCliente.TabIndex = 3;
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.Location = new System.Drawing.Point(429, 105);
            this.txtTelefonoCliente.MaxLength = 9;
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.Size = new System.Drawing.Size(128, 20);
            this.txtTelefonoCliente.TabIndex = 4;
            // 
            // btnInsertarCliente
            // 
            this.btnInsertarCliente.Location = new System.Drawing.Point(85, 177);
            this.btnInsertarCliente.Name = "btnInsertarCliente";
            this.btnInsertarCliente.Size = new System.Drawing.Size(124, 23);
            this.btnInsertarCliente.TabIndex = 8;
            this.btnInsertarCliente.Text = "Insertar";
            this.btnInsertarCliente.UseVisualStyleBackColor = true;
            this.btnInsertarCliente.Click += new System.EventHandler(this.btnInsertarCliente_Click);
            // 
            // btnGrabarCliente
            // 
            this.btnGrabarCliente.Location = new System.Drawing.Point(270, 177);
            this.btnGrabarCliente.Name = "btnGrabarCliente";
            this.btnGrabarCliente.Size = new System.Drawing.Size(124, 23);
            this.btnGrabarCliente.TabIndex = 9;
            this.btnGrabarCliente.Text = "Grabar";
            this.btnGrabarCliente.UseVisualStyleBackColor = true;
            this.btnGrabarCliente.Click += new System.EventHandler(this.btnGrabarCliente_Click);
            // 
            // btnLeerCliente
            // 
            this.btnLeerCliente.Location = new System.Drawing.Point(444, 177);
            this.btnLeerCliente.Name = "btnLeerCliente";
            this.btnLeerCliente.Size = new System.Drawing.Size(124, 23);
            this.btnLeerCliente.TabIndex = 10;
            this.btnLeerCliente.Text = "Leer";
            this.btnLeerCliente.UseVisualStyleBackColor = true;
            this.btnLeerCliente.Click += new System.EventHandler(this.btnLeerCliente_Click);
            // 
            // dtgvCliente
            // 
            this.dtgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCliente.Location = new System.Drawing.Point(12, 228);
            this.dtgvCliente.Name = "dtgvCliente";
            this.dtgvCliente.Size = new System.Drawing.Size(628, 117);
            this.dtgvCliente.TabIndex = 8;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 348);
            this.Controls.Add(this.dtgvCliente);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLeerCliente;
        private System.Windows.Forms.Button btnGrabarCliente;
        private System.Windows.Forms.Button btnInsertarCliente;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.TextBox txtDNIcliente;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.DataGridView dtgvCliente;
    }
}