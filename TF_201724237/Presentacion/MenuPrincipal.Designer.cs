namespace SI33_Plantilla
{
    partial class MenuPrincipal
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
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReportes = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.Location = new System.Drawing.Point(97, 109);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(138, 54);
            this.btnEmpresa.TabIndex = 0;
            this.btnEmpresa.Text = "Empresa:";
            this.btnEmpresa.UseVisualStyleBackColor = true;
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(97, 49);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(138, 54);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.Text = "Cliente:";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.Location = new System.Drawing.Point(97, 229);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(138, 54);
            this.btnVenta.TabIndex = 2;
            this.btnVenta.Text = "Venta:";
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnProveedor
            // 
            this.btnProveedor.Location = new System.Drawing.Point(97, 169);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(138, 54);
            this.btnProveedor.TabIndex = 3;
            this.btnProveedor.Text = "Proveedor:";
            this.btnProveedor.UseVisualStyleBackColor = true;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReportes);
            this.groupBox1.Controls.Add(this.btnVenta);
            this.groupBox1.Controls.Add(this.btnProveedor);
            this.groupBox1.Controls.Add(this.btnEmpresa);
            this.groupBox1.Controls.Add(this.btnCliente);
            this.groupBox1.Location = new System.Drawing.Point(230, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 371);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu Principal";
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(97, 289);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(138, 54);
            this.btnReportes.TabIndex = 4;
            this.btnReportes.Text = "Reportes:";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmpresa;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReportes;
    }
}