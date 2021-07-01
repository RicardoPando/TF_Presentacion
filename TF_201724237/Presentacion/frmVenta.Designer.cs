namespace SI33_Plantilla
{
    partial class frmVenta
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
            this.cmbxDNIventa = new System.Windows.Forms.ComboBox();
            this.cmbxRUCventa = new System.Windows.Forms.ComboBox();
            this.cmbxCodigoProducto = new System.Windows.Forms.ComboBox();
            this.txtCantidadVenta = new System.Windows.Forms.TextBox();
            this.dtpkFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.rdbtnEfectivo = new System.Windows.Forms.RadioButton();
            this.rdbtnTarjeta = new System.Windows.Forms.RadioButton();
            this.rdbtnSi = new System.Windows.Forms.RadioButton();
            this.rdbtnNo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInsertarVenta = new System.Windows.Forms.Button();
            this.btnActualizarVenta = new System.Windows.Forms.Button();
            this.btnEliminarVenta = new System.Windows.Forms.Button();
            this.btnLeerBaseDatos = new System.Windows.Forms.Button();
            this.btnGuardarBaseDatos = new System.Windows.Forms.Button();
            this.dtgvVenta = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "RUC Empresa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo de Prodcuto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(525, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Forma de Pago:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(525, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Requiere envio:";
            // 
            // cmbxDNIventa
            // 
            this.cmbxDNIventa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxDNIventa.FormattingEnabled = true;
            this.cmbxDNIventa.Location = new System.Drawing.Point(121, 39);
            this.cmbxDNIventa.Name = "cmbxDNIventa";
            this.cmbxDNIventa.Size = new System.Drawing.Size(121, 21);
            this.cmbxDNIventa.TabIndex = 7;
            // 
            // cmbxRUCventa
            // 
            this.cmbxRUCventa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxRUCventa.FormattingEnabled = true;
            this.cmbxRUCventa.Location = new System.Drawing.Point(134, 96);
            this.cmbxRUCventa.Name = "cmbxRUCventa";
            this.cmbxRUCventa.Size = new System.Drawing.Size(121, 21);
            this.cmbxRUCventa.TabIndex = 8;
            // 
            // cmbxCodigoProducto
            // 
            this.cmbxCodigoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxCodigoProducto.FormattingEnabled = true;
            this.cmbxCodigoProducto.Items.AddRange(new object[] {
            "OP-11",
            "OP-12",
            "OP-13",
            "OP-14",
            "OP-15",
            "OP-16",
            "OP-17",
            "OP-18",
            "OP-19",
            "OP-110",
            "OP-111",
            "OP-112",
            ""});
            this.cmbxCodigoProducto.Location = new System.Drawing.Point(161, 154);
            this.cmbxCodigoProducto.Name = "cmbxCodigoProducto";
            this.cmbxCodigoProducto.Size = new System.Drawing.Size(121, 21);
            this.cmbxCodigoProducto.TabIndex = 9;
            // 
            // txtCantidadVenta
            // 
            this.txtCantidadVenta.Location = new System.Drawing.Point(370, 114);
            this.txtCantidadVenta.Name = "txtCantidadVenta";
            this.txtCantidadVenta.Size = new System.Drawing.Size(106, 20);
            this.txtCantidadVenta.TabIndex = 10;
            // 
            // dtpkFechaVenta
            // 
            this.dtpkFechaVenta.Location = new System.Drawing.Point(320, 36);
            this.dtpkFechaVenta.Name = "dtpkFechaVenta";
            this.dtpkFechaVenta.Size = new System.Drawing.Size(200, 20);
            this.dtpkFechaVenta.TabIndex = 11;
            // 
            // rdbtnEfectivo
            // 
            this.rdbtnEfectivo.AutoSize = true;
            this.rdbtnEfectivo.Location = new System.Drawing.Point(613, 81);
            this.rdbtnEfectivo.Name = "rdbtnEfectivo";
            this.rdbtnEfectivo.Size = new System.Drawing.Size(64, 17);
            this.rdbtnEfectivo.TabIndex = 12;
            this.rdbtnEfectivo.TabStop = true;
            this.rdbtnEfectivo.Text = "Efectivo";
            this.rdbtnEfectivo.UseVisualStyleBackColor = true;
            // 
            // rdbtnTarjeta
            // 
            this.rdbtnTarjeta.AutoSize = true;
            this.rdbtnTarjeta.Location = new System.Drawing.Point(683, 81);
            this.rdbtnTarjeta.Name = "rdbtnTarjeta";
            this.rdbtnTarjeta.Size = new System.Drawing.Size(58, 17);
            this.rdbtnTarjeta.TabIndex = 13;
            this.rdbtnTarjeta.TabStop = true;
            this.rdbtnTarjeta.Text = "Tarjeta";
            this.rdbtnTarjeta.UseVisualStyleBackColor = true;
            // 
            // rdbtnSi
            // 
            this.rdbtnSi.AutoSize = true;
            this.rdbtnSi.Location = new System.Drawing.Point(613, 144);
            this.rdbtnSi.Name = "rdbtnSi";
            this.rdbtnSi.Size = new System.Drawing.Size(34, 17);
            this.rdbtnSi.TabIndex = 14;
            this.rdbtnSi.TabStop = true;
            this.rdbtnSi.Text = "Si";
            this.rdbtnSi.UseVisualStyleBackColor = true;
            // 
            // rdbtnNo
            // 
            this.rdbtnNo.AutoSize = true;
            this.rdbtnNo.Location = new System.Drawing.Point(683, 144);
            this.rdbtnNo.Name = "rdbtnNo";
            this.rdbtnNo.Size = new System.Drawing.Size(39, 17);
            this.rdbtnNo.TabIndex = 15;
            this.rdbtnNo.TabStop = true;
            this.rdbtnNo.Text = "No";
            this.rdbtnNo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuardarBaseDatos);
            this.groupBox1.Controls.Add(this.btnLeerBaseDatos);
            this.groupBox1.Controls.Add(this.btnEliminarVenta);
            this.groupBox1.Controls.Add(this.btnActualizarVenta);
            this.groupBox1.Controls.Add(this.btnInsertarVenta);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 248);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venta";
            // 
            // btnInsertarVenta
            // 
            this.btnInsertarVenta.Location = new System.Drawing.Point(42, 219);
            this.btnInsertarVenta.Name = "btnInsertarVenta";
            this.btnInsertarVenta.Size = new System.Drawing.Size(132, 23);
            this.btnInsertarVenta.TabIndex = 0;
            this.btnInsertarVenta.Text = "Insertar";
            this.btnInsertarVenta.UseVisualStyleBackColor = true;
            this.btnInsertarVenta.Click += new System.EventHandler(this.btnInsertarVenta_Click);
            // 
            // btnActualizarVenta
            // 
            this.btnActualizarVenta.Location = new System.Drawing.Point(183, 219);
            this.btnActualizarVenta.Name = "btnActualizarVenta";
            this.btnActualizarVenta.Size = new System.Drawing.Size(132, 23);
            this.btnActualizarVenta.TabIndex = 1;
            this.btnActualizarVenta.Text = "Actualizar";
            this.btnActualizarVenta.UseVisualStyleBackColor = true;
            this.btnActualizarVenta.Click += new System.EventHandler(this.btnActualizarVenta_Click);
            // 
            // btnEliminarVenta
            // 
            this.btnEliminarVenta.Location = new System.Drawing.Point(321, 219);
            this.btnEliminarVenta.Name = "btnEliminarVenta";
            this.btnEliminarVenta.Size = new System.Drawing.Size(132, 23);
            this.btnEliminarVenta.TabIndex = 2;
            this.btnEliminarVenta.Text = "Eliminar";
            this.btnEliminarVenta.UseVisualStyleBackColor = true;
            this.btnEliminarVenta.Click += new System.EventHandler(this.btnEliminarVenta_Click);
            // 
            // btnLeerBaseDatos
            // 
            this.btnLeerBaseDatos.Location = new System.Drawing.Point(459, 219);
            this.btnLeerBaseDatos.Name = "btnLeerBaseDatos";
            this.btnLeerBaseDatos.Size = new System.Drawing.Size(132, 23);
            this.btnLeerBaseDatos.TabIndex = 3;
            this.btnLeerBaseDatos.Text = "Leer en Base de Datos";
            this.btnLeerBaseDatos.UseVisualStyleBackColor = true;
            this.btnLeerBaseDatos.Click += new System.EventHandler(this.btnLeerBaseDatos_Click);
            // 
            // btnGuardarBaseDatos
            // 
            this.btnGuardarBaseDatos.Location = new System.Drawing.Point(597, 219);
            this.btnGuardarBaseDatos.Name = "btnGuardarBaseDatos";
            this.btnGuardarBaseDatos.Size = new System.Drawing.Size(132, 23);
            this.btnGuardarBaseDatos.TabIndex = 4;
            this.btnGuardarBaseDatos.Text = "Guardar en Base de Datos";
            this.btnGuardarBaseDatos.UseVisualStyleBackColor = true;
            this.btnGuardarBaseDatos.Click += new System.EventHandler(this.btnGuardarBaseDatos_Click);
            // 
            // dtgvVenta
            // 
            this.dtgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvVenta.Location = new System.Drawing.Point(12, 260);
            this.dtgvVenta.Name = "dtgvVenta";
            this.dtgvVenta.Size = new System.Drawing.Size(743, 138);
            this.dtgvVenta.TabIndex = 17;
            this.dtgvVenta.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvVenta_CellEnter);
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 401);
            this.Controls.Add(this.dtgvVenta);
            this.Controls.Add(this.rdbtnNo);
            this.Controls.Add(this.rdbtnSi);
            this.Controls.Add(this.rdbtnTarjeta);
            this.Controls.Add(this.rdbtnEfectivo);
            this.Controls.Add(this.dtpkFechaVenta);
            this.Controls.Add(this.txtCantidadVenta);
            this.Controls.Add(this.cmbxCodigoProducto);
            this.Controls.Add(this.cmbxRUCventa);
            this.Controls.Add(this.cmbxDNIventa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmVenta";
            this.Text = "frmVenta";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbxDNIventa;
        private System.Windows.Forms.ComboBox cmbxRUCventa;
        private System.Windows.Forms.ComboBox cmbxCodigoProducto;
        private System.Windows.Forms.TextBox txtCantidadVenta;
        private System.Windows.Forms.DateTimePicker dtpkFechaVenta;
        private System.Windows.Forms.RadioButton rdbtnEfectivo;
        private System.Windows.Forms.RadioButton rdbtnTarjeta;
        private System.Windows.Forms.RadioButton rdbtnSi;
        private System.Windows.Forms.RadioButton rdbtnNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardarBaseDatos;
        private System.Windows.Forms.Button btnLeerBaseDatos;
        private System.Windows.Forms.Button btnEliminarVenta;
        private System.Windows.Forms.Button btnActualizarVenta;
        private System.Windows.Forms.Button btnInsertarVenta;
        private System.Windows.Forms.DataGridView dtgvVenta;
    }
}