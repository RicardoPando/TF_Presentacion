namespace SI33_Plantilla
{
    partial class frmProveedor
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRazonSocialProveedor = new System.Windows.Forms.TextBox();
            this.txtRUCproveedor = new System.Windows.Forms.TextBox();
            this.txtDireccionProveedor = new System.Windows.Forms.TextBox();
            this.txtTelefonoProveedor = new System.Windows.Forms.TextBox();
            this.cmbxPaisOrigen = new System.Windows.Forms.ComboBox();
            this.txtTiempoEntrega = new System.Windows.Forms.TextBox();
            this.txtCostoMaterial = new System.Windows.Forms.TextBox();
            this.btnInsertarProveedor = new System.Windows.Forms.Button();
            this.btnGrabarProveedor = new System.Windows.Forms.Button();
            this.btnLeerProveedor = new System.Windows.Forms.Button();
            this.dtgvProveedor = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Razon Social:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "RUC :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pais de Origen:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Direccion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tiempo de Entrega:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(225, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Costo de Material:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLeerProveedor);
            this.groupBox1.Controls.Add(this.btnGrabarProveedor);
            this.groupBox1.Controls.Add(this.btnInsertarProveedor);
            this.groupBox1.Controls.Add(this.txtCostoMaterial);
            this.groupBox1.Controls.Add(this.txtTiempoEntrega);
            this.groupBox1.Controls.Add(this.cmbxPaisOrigen);
            this.groupBox1.Controls.Add(this.txtTelefonoProveedor);
            this.groupBox1.Controls.Add(this.txtDireccionProveedor);
            this.groupBox1.Controls.Add(this.txtRUCproveedor);
            this.groupBox1.Controls.Add(this.txtRazonSocialProveedor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 187);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proovedor";
            // 
            // txtRazonSocialProveedor
            // 
            this.txtRazonSocialProveedor.Location = new System.Drawing.Point(111, 34);
            this.txtRazonSocialProveedor.Name = "txtRazonSocialProveedor";
            this.txtRazonSocialProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtRazonSocialProveedor.TabIndex = 7;
            // 
            // txtRUCproveedor
            // 
            this.txtRUCproveedor.Location = new System.Drawing.Point(74, 67);
            this.txtRUCproveedor.Name = "txtRUCproveedor";
            this.txtRUCproveedor.Size = new System.Drawing.Size(137, 20);
            this.txtRUCproveedor.TabIndex = 8;
            // 
            // txtDireccionProveedor
            // 
            this.txtDireccionProveedor.Location = new System.Drawing.Point(93, 100);
            this.txtDireccionProveedor.Name = "txtDireccionProveedor";
            this.txtDireccionProveedor.Size = new System.Drawing.Size(118, 20);
            this.txtDireccionProveedor.TabIndex = 9;
            // 
            // txtTelefonoProveedor
            // 
            this.txtTelefonoProveedor.Location = new System.Drawing.Point(495, 71);
            this.txtTelefonoProveedor.Name = "txtTelefonoProveedor";
            this.txtTelefonoProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonoProveedor.TabIndex = 10;
            // 
            // cmbxPaisOrigen
            // 
            this.cmbxPaisOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxPaisOrigen.FormattingEnabled = true;
            this.cmbxPaisOrigen.Items.AddRange(new object[] {
            "China",
            "Estados Unidos"});
            this.cmbxPaisOrigen.Location = new System.Drawing.Point(310, 41);
            this.cmbxPaisOrigen.Name = "cmbxPaisOrigen";
            this.cmbxPaisOrigen.Size = new System.Drawing.Size(121, 21);
            this.cmbxPaisOrigen.TabIndex = 11;
            // 
            // txtTiempoEntrega
            // 
            this.txtTiempoEntrega.Location = new System.Drawing.Point(331, 71);
            this.txtTiempoEntrega.Name = "txtTiempoEntrega";
            this.txtTiempoEntrega.Size = new System.Drawing.Size(100, 20);
            this.txtTiempoEntrega.TabIndex = 12;
            // 
            // txtCostoMaterial
            // 
            this.txtCostoMaterial.Location = new System.Drawing.Point(323, 100);
            this.txtCostoMaterial.Name = "txtCostoMaterial";
            this.txtCostoMaterial.Size = new System.Drawing.Size(108, 20);
            this.txtCostoMaterial.TabIndex = 13;
            // 
            // btnInsertarProveedor
            // 
            this.btnInsertarProveedor.Location = new System.Drawing.Point(111, 143);
            this.btnInsertarProveedor.Name = "btnInsertarProveedor";
            this.btnInsertarProveedor.Size = new System.Drawing.Size(131, 38);
            this.btnInsertarProveedor.TabIndex = 14;
            this.btnInsertarProveedor.Text = "Insertar";
            this.btnInsertarProveedor.UseVisualStyleBackColor = true;
            this.btnInsertarProveedor.Click += new System.EventHandler(this.btnInsertarProveedor_Click);
            // 
            // btnGrabarProveedor
            // 
            this.btnGrabarProveedor.Location = new System.Drawing.Point(262, 143);
            this.btnGrabarProveedor.Name = "btnGrabarProveedor";
            this.btnGrabarProveedor.Size = new System.Drawing.Size(131, 38);
            this.btnGrabarProveedor.TabIndex = 15;
            this.btnGrabarProveedor.Text = "Grabar";
            this.btnGrabarProveedor.UseVisualStyleBackColor = true;
            this.btnGrabarProveedor.Click += new System.EventHandler(this.btnGrabarProveedor_Click);
            // 
            // btnLeerProveedor
            // 
            this.btnLeerProveedor.Location = new System.Drawing.Point(410, 143);
            this.btnLeerProveedor.Name = "btnLeerProveedor";
            this.btnLeerProveedor.Size = new System.Drawing.Size(131, 38);
            this.btnLeerProveedor.TabIndex = 16;
            this.btnLeerProveedor.Text = "Leer";
            this.btnLeerProveedor.UseVisualStyleBackColor = true;
            this.btnLeerProveedor.Click += new System.EventHandler(this.btnLeerProveedor_Click);
            // 
            // dtgvProveedor
            // 
            this.dtgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProveedor.Location = new System.Drawing.Point(12, 199);
            this.dtgvProveedor.Name = "dtgvProveedor";
            this.dtgvProveedor.Size = new System.Drawing.Size(636, 156);
            this.dtgvProveedor.TabIndex = 8;
            // 
            // frmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 363);
            this.Controls.Add(this.dtgvProveedor);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmProveedor";
            this.Text = "frmProveedor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLeerProveedor;
        private System.Windows.Forms.Button btnGrabarProveedor;
        private System.Windows.Forms.Button btnInsertarProveedor;
        private System.Windows.Forms.TextBox txtCostoMaterial;
        private System.Windows.Forms.TextBox txtTiempoEntrega;
        private System.Windows.Forms.ComboBox cmbxPaisOrigen;
        private System.Windows.Forms.TextBox txtTelefonoProveedor;
        private System.Windows.Forms.TextBox txtDireccionProveedor;
        private System.Windows.Forms.TextBox txtRUCproveedor;
        private System.Windows.Forms.TextBox txtRazonSocialProveedor;
        private System.Windows.Forms.DataGridView dtgvProveedor;
    }
}