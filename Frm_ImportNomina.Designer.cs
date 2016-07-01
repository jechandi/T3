namespace T3
{
    partial class Frm_ImportNomina
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ImportNomina));
            this.panel1 = new System.Windows.Forms.Panel();
            this.L_Saldo = new System.Windows.Forms.Label();
            this.MCont = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.L_Haber = new System.Windows.Forms.Label();
            this.ACont = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.L_Debe = new System.Windows.Forms.Label();
            this.FCont = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DateMaxPicker = new System.Windows.Forms.DateTimePicker();
            this.DateMinPicker = new System.Windows.Forms.DateTimePicker();
            this._Bt_Gen_Comprobante = new System.Windows.Forms.Button();
            this._Bt_Importar = new System.Windows.Forms.Button();
            this._Dg_Grid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Dg_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.L_Saldo);
            this.panel1.Controls.Add(this.MCont);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.L_Haber);
            this.panel1.Controls.Add(this.ACont);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.L_Debe);
            this.panel1.Controls.Add(this.FCont);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DateMaxPicker);
            this.panel1.Controls.Add(this.DateMinPicker);
            this.panel1.Controls.Add(this._Bt_Gen_Comprobante);
            this.panel1.Controls.Add(this._Bt_Importar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 78);
            this.panel1.TabIndex = 0;
            // 
            // L_Saldo
            // 
            this.L_Saldo.AutoSize = true;
            this.L_Saldo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Saldo.Location = new System.Drawing.Point(946, 54);
            this.L_Saldo.Name = "L_Saldo";
            this.L_Saldo.Size = new System.Drawing.Size(15, 14);
            this.L_Saldo.TabIndex = 14;
            this.L_Saldo.Text = "0";
            // 
            // MCont
            // 
            this.MCont.AutoSize = true;
            this.MCont.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCont.Location = new System.Drawing.Point(441, 54);
            this.MCont.Name = "MCont";
            this.MCont.Size = new System.Drawing.Size(156, 14);
            this.MCont.TabIndex = 17;
            this.MCont.Text = "Mes de Contabilización:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(900, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 14);
            this.label8.TabIndex = 13;
            this.label8.Text = "Saldo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "Fecha de Culminacion";
            // 
            // L_Haber
            // 
            this.L_Haber.AutoSize = true;
            this.L_Haber.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Haber.Location = new System.Drawing.Point(946, 32);
            this.L_Haber.Name = "L_Haber";
            this.L_Haber.Size = new System.Drawing.Size(15, 14);
            this.L_Haber.TabIndex = 12;
            this.L_Haber.Text = "0";
            // 
            // ACont
            // 
            this.ACont.AutoSize = true;
            this.ACont.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACont.Location = new System.Drawing.Point(442, 32);
            this.ACont.Name = "ACont";
            this.ACont.Size = new System.Drawing.Size(155, 14);
            this.ACont.TabIndex = 16;
            this.ACont.Text = "Año de Contabilización:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(897, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "Haber: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fecha de Inicio";
            // 
            // L_Debe
            // 
            this.L_Debe.AutoSize = true;
            this.L_Debe.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Debe.Location = new System.Drawing.Point(946, 10);
            this.L_Debe.Name = "L_Debe";
            this.L_Debe.Size = new System.Drawing.Size(15, 14);
            this.L_Debe.TabIndex = 10;
            this.L_Debe.Text = "0";
            // 
            // FCont
            // 
            this.FCont.AutoSize = true;
            this.FCont.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FCont.Location = new System.Drawing.Point(429, 10);
            this.FCont.Name = "FCont";
            this.FCont.Size = new System.Drawing.Size(168, 14);
            this.FCont.TabIndex = 15;
            this.FCont.Text = "Fecha de Contabilización:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(902, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Debe: ";
            // 
            // DateMaxPicker
            // 
            this.DateMaxPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateMaxPicker.Location = new System.Drawing.Point(126, 42);
            this.DateMaxPicker.Name = "DateMaxPicker";
            this.DateMaxPicker.Size = new System.Drawing.Size(94, 18);
            this.DateMaxPicker.TabIndex = 6;
            // 
            // DateMinPicker
            // 
            this.DateMinPicker.CustomFormat = "";
            this.DateMinPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateMinPicker.Location = new System.Drawing.Point(126, 18);
            this.DateMinPicker.Name = "DateMinPicker";
            this.DateMinPicker.Size = new System.Drawing.Size(94, 18);
            this.DateMinPicker.TabIndex = 5;
            this.DateMinPicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // _Bt_Gen_Comprobante
            // 
            this._Bt_Gen_Comprobante.Cursor = System.Windows.Forms.Cursors.Hand;
            this._Bt_Gen_Comprobante.Enabled = false;
            this._Bt_Gen_Comprobante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._Bt_Gen_Comprobante.Image = ((System.Drawing.Image)(resources.GetObject("_Bt_Gen_Comprobante.Image")));
            this._Bt_Gen_Comprobante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._Bt_Gen_Comprobante.Location = new System.Drawing.Point(229, 43);
            this._Bt_Gen_Comprobante.Name = "_Bt_Gen_Comprobante";
            this._Bt_Gen_Comprobante.Size = new System.Drawing.Size(152, 23);
            this._Bt_Gen_Comprobante.TabIndex = 3;
            this._Bt_Gen_Comprobante.Text = "Generar Comprobante";
            this._Bt_Gen_Comprobante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._Bt_Gen_Comprobante.UseVisualStyleBackColor = true;
            this._Bt_Gen_Comprobante.Click += new System.EventHandler(this.button1_Click);
            // 
            // _Bt_Importar
            // 
            this._Bt_Importar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._Bt_Importar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._Bt_Importar.Image = ((System.Drawing.Image)(resources.GetObject("_Bt_Importar.Image")));
            this._Bt_Importar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._Bt_Importar.Location = new System.Drawing.Point(229, 13);
            this._Bt_Importar.Name = "_Bt_Importar";
            this._Bt_Importar.Size = new System.Drawing.Size(152, 23);
            this._Bt_Importar.TabIndex = 2;
            this._Bt_Importar.Text = "Importar datos nomina";
            this._Bt_Importar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._Bt_Importar.UseVisualStyleBackColor = true;
            this._Bt_Importar.Click += new System.EventHandler(this._Bt_Importar_Click_1);
            // 
            // _Dg_Grid
            // 
            this._Dg_Grid.AllowUserToAddRows = false;
            this._Dg_Grid.AllowUserToDeleteRows = false;
            this._Dg_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._Dg_Grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this._Dg_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._Dg_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._Dg_Grid.Location = new System.Drawing.Point(0, 78);
            this._Dg_Grid.MultiSelect = false;
            this._Dg_Grid.Name = "_Dg_Grid";
            this._Dg_Grid.ReadOnly = true;
            this._Dg_Grid.Size = new System.Drawing.Size(1101, 460);
            this._Dg_Grid.TabIndex = 2;
            // 
            // Frm_ImportNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 538);
            this.Controls.Add(this._Dg_Grid);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ImportNomina";
            this.Text = "Importar Nomina";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_ImportNomina_FormClosed);
            this.Load += new System.EventHandler(this.Frm_ImportNomina_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Dg_Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView _Dg_Grid;
        private System.Windows.Forms.Button _Bt_Importar;
        private System.Windows.Forms.Button _Bt_Gen_Comprobante;
        private System.Windows.Forms.DateTimePicker DateMinPicker;
        private System.Windows.Forms.DateTimePicker DateMaxPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label L_Saldo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label L_Haber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label L_Debe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MCont;
        private System.Windows.Forms.Label ACont;
        private System.Windows.Forms.Label FCont;

    }
}