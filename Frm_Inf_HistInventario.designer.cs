﻿namespace T3
{
    partial class Frm_Inf_HistInventario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Inf_HistInventario));
            this.panel1 = new System.Windows.Forms.Panel();
            this._Cmb_AnoContable = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this._Txt_CodFabrica = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._Bt_Find = new System.Windows.Forms.Button();
            this._Bt_Restablecer = new System.Windows.Forms.Button();
            this._Chbox_Marcas = new System.Windows.Forms.CheckBox();
            this._Txt_Producto = new System.Windows.Forms.TextBox();
            this._Chbox_Subgrupos = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this._Chbox_Grupos = new System.Windows.Forms.CheckBox();
            this._Chbox_Proveedores = new System.Windows.Forms.CheckBox();
            this._Cmb_Proveedor = new System.Windows.Forms.ComboBox();
            this._Cmb_Marca = new System.Windows.Forms.ComboBox();
            this._Cmb_Grupo = new System.Windows.Forms.ComboBox();
            this._Cmb_Subgrupo = new System.Windows.Forms.ComboBox();
            this._Rpt_Report = new Microsoft.Reporting.WinForms.ReportViewer();
            this._Er_Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Er_Error)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._Cmb_AnoContable);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this._Txt_CodFabrica);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this._Bt_Find);
            this.panel1.Controls.Add(this._Bt_Restablecer);
            this.panel1.Controls.Add(this._Chbox_Marcas);
            this.panel1.Controls.Add(this._Txt_Producto);
            this.panel1.Controls.Add(this._Chbox_Subgrupos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this._Chbox_Grupos);
            this.panel1.Controls.Add(this._Chbox_Proveedores);
            this.panel1.Controls.Add(this._Cmb_Proveedor);
            this.panel1.Controls.Add(this._Cmb_Marca);
            this.panel1.Controls.Add(this._Cmb_Grupo);
            this.panel1.Controls.Add(this._Cmb_Subgrupo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 209);
            this.panel1.TabIndex = 0;
            // 
            // _Cmb_AnoContable
            // 
            this._Cmb_AnoContable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._Cmb_AnoContable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._Cmb_AnoContable.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Cmb_AnoContable.FormattingEnabled = true;
            this._Cmb_AnoContable.Location = new System.Drawing.Point(160, 6);
            this._Cmb_AnoContable.Name = "_Cmb_AnoContable";
            this._Cmb_AnoContable.Size = new System.Drawing.Size(175, 20);
            this._Cmb_AnoContable.TabIndex = 0;
            this._Cmb_AnoContable.SelectedIndexChanged += new System.EventHandler(this._Cmb_AnoContable_SelectedIndexChanged);
            this._Cmb_AnoContable.DropDown += new System.EventHandler(this._Cmb_AnoContable_DropDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 12);
            this.label3.TabIndex = 101;
            this.label3.Text = "Año / Mes Contable:";
            // 
            // _Txt_CodFabrica
            // 
            this._Txt_CodFabrica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._Txt_CodFabrica.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Txt_CodFabrica.Location = new System.Drawing.Point(160, 50);
            this._Txt_CodFabrica.Name = "_Txt_CodFabrica";
            this._Txt_CodFabrica.Size = new System.Drawing.Size(100, 18);
            this._Txt_CodFabrica.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 99;
            this.label2.Text = "Código Fábrica:";
            // 
            // _Bt_Find
            // 
            this._Bt_Find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._Bt_Find.Image = ((System.Drawing.Image)(resources.GetObject("_Bt_Find.Image")));
            this._Bt_Find.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._Bt_Find.Location = new System.Drawing.Point(475, 7);
            this._Bt_Find.Name = "_Bt_Find";
            this._Bt_Find.Size = new System.Drawing.Size(104, 33);
            this._Bt_Find.TabIndex = 8;
            this._Bt_Find.Text = "Consultar";
            this._Bt_Find.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._Bt_Find.UseVisualStyleBackColor = true;
            this._Bt_Find.Click += new System.EventHandler(this._Bt_Find_Click);
            // 
            // _Bt_Restablecer
            // 
            this._Bt_Restablecer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._Bt_Restablecer.Image = ((System.Drawing.Image)(resources.GetObject("_Bt_Restablecer.Image")));
            this._Bt_Restablecer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._Bt_Restablecer.Location = new System.Drawing.Point(475, 52);
            this._Bt_Restablecer.Name = "_Bt_Restablecer";
            this._Bt_Restablecer.Size = new System.Drawing.Size(104, 33);
            this._Bt_Restablecer.TabIndex = 9;
            this._Bt_Restablecer.Text = "Restablecer";
            this._Bt_Restablecer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._Bt_Restablecer.UseVisualStyleBackColor = true;
            this._Bt_Restablecer.Click += new System.EventHandler(this._Bt_Restablecer_Click);
            // 
            // _Chbox_Marcas
            // 
            this._Chbox_Marcas.AutoSize = true;
            this._Chbox_Marcas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._Chbox_Marcas.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Chbox_Marcas.Location = new System.Drawing.Point(13, 150);
            this._Chbox_Marcas.Name = "_Chbox_Marcas";
            this._Chbox_Marcas.Size = new System.Drawing.Size(51, 16);
            this._Chbox_Marcas.TabIndex = 96;
            this._Chbox_Marcas.Text = "Marca";
            this._Chbox_Marcas.UseVisualStyleBackColor = true;
            this._Chbox_Marcas.CheckedChanged += new System.EventHandler(this._Chbox_Marcas_CheckedChanged);
            // 
            // _Txt_Producto
            // 
            this._Txt_Producto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._Txt_Producto.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Txt_Producto.Location = new System.Drawing.Point(160, 29);
            this._Txt_Producto.Name = "_Txt_Producto";
            this._Txt_Producto.Size = new System.Drawing.Size(100, 18);
            this._Txt_Producto.TabIndex = 2;
            // 
            // _Chbox_Subgrupos
            // 
            this._Chbox_Subgrupos.AutoSize = true;
            this._Chbox_Subgrupos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._Chbox_Subgrupos.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Chbox_Subgrupos.Location = new System.Drawing.Point(13, 124);
            this._Chbox_Subgrupos.Name = "_Chbox_Subgrupos";
            this._Chbox_Subgrupos.Size = new System.Drawing.Size(68, 16);
            this._Chbox_Subgrupos.TabIndex = 95;
            this._Chbox_Subgrupos.Text = "Subgrupo";
            this._Chbox_Subgrupos.UseVisualStyleBackColor = true;
            this._Chbox_Subgrupos.CheckedChanged += new System.EventHandler(this._Chbox_Subgrupos_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 85;
            this.label1.Text = "Código específico:";
            // 
            // _Chbox_Grupos
            // 
            this._Chbox_Grupos.AutoSize = true;
            this._Chbox_Grupos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._Chbox_Grupos.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Chbox_Grupos.Location = new System.Drawing.Point(13, 98);
            this._Chbox_Grupos.Name = "_Chbox_Grupos";
            this._Chbox_Grupos.Size = new System.Drawing.Size(51, 16);
            this._Chbox_Grupos.TabIndex = 94;
            this._Chbox_Grupos.Text = "Grupo";
            this._Chbox_Grupos.UseVisualStyleBackColor = true;
            this._Chbox_Grupos.CheckedChanged += new System.EventHandler(this._Chbox_Grupos_CheckedChanged);
            // 
            // _Chbox_Proveedores
            // 
            this._Chbox_Proveedores.AutoSize = true;
            this._Chbox_Proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._Chbox_Proveedores.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Chbox_Proveedores.Location = new System.Drawing.Point(13, 74);
            this._Chbox_Proveedores.Name = "_Chbox_Proveedores";
            this._Chbox_Proveedores.Size = new System.Drawing.Size(73, 16);
            this._Chbox_Proveedores.TabIndex = 93;
            this._Chbox_Proveedores.Text = "Proveedor";
            this._Chbox_Proveedores.UseVisualStyleBackColor = true;
            this._Chbox_Proveedores.CheckedChanged += new System.EventHandler(this._Chbox_Proveedores_CheckedChanged);
            // 
            // _Cmb_Proveedor
            // 
            this._Cmb_Proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._Cmb_Proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._Cmb_Proveedor.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Cmb_Proveedor.FormattingEnabled = true;
            this._Cmb_Proveedor.Location = new System.Drawing.Point(161, 73);
            this._Cmb_Proveedor.Name = "_Cmb_Proveedor";
            this._Cmb_Proveedor.Size = new System.Drawing.Size(304, 20);
            this._Cmb_Proveedor.TabIndex = 4;
            this._Cmb_Proveedor.SelectedIndexChanged += new System.EventHandler(this._Cmb_Proveedor_SelectedIndexChanged);
            this._Cmb_Proveedor.DropDown += new System.EventHandler(this._Cmb_Proveedor_DropDown);
            // 
            // _Cmb_Marca
            // 
            this._Cmb_Marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._Cmb_Marca.Enabled = false;
            this._Cmb_Marca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._Cmb_Marca.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Cmb_Marca.FormattingEnabled = true;
            this._Cmb_Marca.Location = new System.Drawing.Point(161, 149);
            this._Cmb_Marca.Name = "_Cmb_Marca";
            this._Cmb_Marca.Size = new System.Drawing.Size(304, 20);
            this._Cmb_Marca.TabIndex = 7;
            this._Cmb_Marca.SelectedIndexChanged += new System.EventHandler(this._Cmb_Marca_SelectedIndexChanged);
            this._Cmb_Marca.DropDown += new System.EventHandler(this._Cmb_Marca_DropDown);
            // 
            // _Cmb_Grupo
            // 
            this._Cmb_Grupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._Cmb_Grupo.Enabled = false;
            this._Cmb_Grupo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._Cmb_Grupo.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Cmb_Grupo.FormattingEnabled = true;
            this._Cmb_Grupo.Location = new System.Drawing.Point(161, 97);
            this._Cmb_Grupo.Name = "_Cmb_Grupo";
            this._Cmb_Grupo.Size = new System.Drawing.Size(304, 20);
            this._Cmb_Grupo.TabIndex = 5;
            this._Cmb_Grupo.SelectedIndexChanged += new System.EventHandler(this._Cmb_Grupo_SelectedIndexChanged);
            this._Cmb_Grupo.DropDown += new System.EventHandler(this._Cmb_Grupo_DropDown);
            // 
            // _Cmb_Subgrupo
            // 
            this._Cmb_Subgrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._Cmb_Subgrupo.Enabled = false;
            this._Cmb_Subgrupo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._Cmb_Subgrupo.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Cmb_Subgrupo.FormattingEnabled = true;
            this._Cmb_Subgrupo.Location = new System.Drawing.Point(161, 123);
            this._Cmb_Subgrupo.Name = "_Cmb_Subgrupo";
            this._Cmb_Subgrupo.Size = new System.Drawing.Size(304, 20);
            this._Cmb_Subgrupo.TabIndex = 6;
            this._Cmb_Subgrupo.SelectedIndexChanged += new System.EventHandler(this._Cmb_Subgrupo_SelectedIndexChanged);
            this._Cmb_Subgrupo.DropDown += new System.EventHandler(this._Cmb_Subgrupo_DropDown);
            // 
            // _Rpt_Report
            // 
            this._Rpt_Report.Dock = System.Windows.Forms.DockStyle.Fill;
            this._Rpt_Report.Location = new System.Drawing.Point(0, 209);
            this._Rpt_Report.Name = "_Rpt_Report";
            this._Rpt_Report.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this._Rpt_Report.ServerReport.ReportServerUrl = new System.Uri("", System.UriKind.Relative);
            this._Rpt_Report.ShowParameterPrompts = false;
            this._Rpt_Report.Size = new System.Drawing.Size(904, 352);
            this._Rpt_Report.TabIndex = 6;
            // 
            // _Er_Error
            // 
            this._Er_Error.ContainerControl = this;
            // 
            // Frm_Inf_HistInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 561);
            this.Controls.Add(this._Rpt_Report);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Inf_HistInventario";
            this.Text = "Informe - Histórico de inventario";
            this.Load += new System.EventHandler(this.Frm_Inf_Productos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Er_Error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer _Rpt_Report;
        private System.Windows.Forms.ErrorProvider _Er_Error;
        private System.Windows.Forms.Button _Bt_Find;
        private System.Windows.Forms.Button _Bt_Restablecer;
        private System.Windows.Forms.CheckBox _Chbox_Marcas;
        private System.Windows.Forms.TextBox _Txt_Producto;
        private System.Windows.Forms.CheckBox _Chbox_Subgrupos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox _Chbox_Grupos;
        private System.Windows.Forms.CheckBox _Chbox_Proveedores;
        private System.Windows.Forms.ComboBox _Cmb_Proveedor;
        private System.Windows.Forms.ComboBox _Cmb_Marca;
        private System.Windows.Forms.ComboBox _Cmb_Grupo;
        private System.Windows.Forms.ComboBox _Cmb_Subgrupo;
        private System.Windows.Forms.TextBox _Txt_CodFabrica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox _Cmb_AnoContable;
    }
}