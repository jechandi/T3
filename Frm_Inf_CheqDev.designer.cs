﻿namespace T3
{
    partial class Frm_Inf_CheqDev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Inf_CheqDev));
            this.panel1 = new System.Windows.Forms.Panel();
            this._Bt_Consultar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._Rb_SinFiltro = new System.Windows.Forms.RadioButton();
            this._Cb_Cliente = new System.Windows.Forms.ComboBox();
            this._Rb_Cliente = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._Cb_Vendedor = new System.Windows.Forms.ComboBox();
            this._Rb_Vendedor = new System.Windows.Forms.RadioButton();
            this._Rpv_Main = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._Bt_Consultar);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 112);
            this.panel1.TabIndex = 3;
            // 
            // _Bt_Consultar
            // 
            this._Bt_Consultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._Bt_Consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this._Bt_Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._Bt_Consultar.Image = ((System.Drawing.Image)(resources.GetObject("_Bt_Consultar.Image")));
            this._Bt_Consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._Bt_Consultar.Location = new System.Drawing.Point(435, 56);
            this._Bt_Consultar.Name = "_Bt_Consultar";
            this._Bt_Consultar.Size = new System.Drawing.Size(170, 47);
            this._Bt_Consultar.TabIndex = 48;
            this._Bt_Consultar.Text = "Consultar";
            this._Bt_Consultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._Bt_Consultar.UseVisualStyleBackColor = true;
            this._Bt_Consultar.Click += new System.EventHandler(this._Bt_Consultar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._Rb_SinFiltro);
            this.groupBox2.Controls.Add(this._Cb_Cliente);
            this.groupBox2.Controls.Add(this._Rb_Cliente);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this._Cb_Vendedor);
            this.groupBox2.Controls.Add(this._Rb_Vendedor);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 100);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrado";
            // 
            // _Rb_SinFiltro
            // 
            this._Rb_SinFiltro.AutoSize = true;
            this._Rb_SinFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._Rb_SinFiltro.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Rb_SinFiltro.Location = new System.Drawing.Point(341, 11);
            this._Rb_SinFiltro.Name = "_Rb_SinFiltro";
            this._Rb_SinFiltro.Size = new System.Drawing.Size(68, 16);
            this._Rb_SinFiltro.TabIndex = 38;
            this._Rb_SinFiltro.Text = "Sin filtrar";
            this._Rb_SinFiltro.UseVisualStyleBackColor = true;
            this._Rb_SinFiltro.CheckedChanged += new System.EventHandler(this._Rb_SinFiltro_CheckedChanged);
            // 
            // _Cb_Cliente
            // 
            this._Cb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._Cb_Cliente.Enabled = false;
            this._Cb_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._Cb_Cliente.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Cb_Cliente.FormattingEnabled = true;
            this._Cb_Cliente.Location = new System.Drawing.Point(32, 32);
            this._Cb_Cliente.Name = "_Cb_Cliente";
            this._Cb_Cliente.Size = new System.Drawing.Size(377, 20);
            this._Cb_Cliente.TabIndex = 31;
            this._Cb_Cliente.DropDown += new System.EventHandler(this._Cb_Cliente_DropDown);
            // 
            // _Rb_Cliente
            // 
            this._Rb_Cliente.AutoSize = true;
            this._Rb_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._Rb_Cliente.Location = new System.Drawing.Point(13, 34);
            this._Rb_Cliente.Name = "_Rb_Cliente";
            this._Rb_Cliente.Size = new System.Drawing.Size(13, 12);
            this._Rb_Cliente.TabIndex = 29;
            this._Rb_Cliente.UseVisualStyleBackColor = true;
            this._Rb_Cliente.CheckedChanged += new System.EventHandler(this._Rb_Cliente_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 30;
            this.label5.Text = "Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 33;
            this.label6.Text = "Vendedor";
            // 
            // _Cb_Vendedor
            // 
            this._Cb_Vendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._Cb_Vendedor.Enabled = false;
            this._Cb_Vendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._Cb_Vendedor.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Cb_Vendedor.FormattingEnabled = true;
            this._Cb_Vendedor.Location = new System.Drawing.Point(31, 70);
            this._Cb_Vendedor.Name = "_Cb_Vendedor";
            this._Cb_Vendedor.Size = new System.Drawing.Size(378, 20);
            this._Cb_Vendedor.TabIndex = 34;
            this._Cb_Vendedor.DropDown += new System.EventHandler(this._Cb_Vendedor_DropDown);
            // 
            // _Rb_Vendedor
            // 
            this._Rb_Vendedor.AutoSize = true;
            this._Rb_Vendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._Rb_Vendedor.Location = new System.Drawing.Point(12, 73);
            this._Rb_Vendedor.Name = "_Rb_Vendedor";
            this._Rb_Vendedor.Size = new System.Drawing.Size(13, 12);
            this._Rb_Vendedor.TabIndex = 32;
            this._Rb_Vendedor.UseVisualStyleBackColor = true;
            this._Rb_Vendedor.CheckedChanged += new System.EventHandler(this._Rb_Vendedor_CheckedChanged);
            // 
            // _Rpv_Main
            // 
            this._Rpv_Main.ActiveViewIndex = -1;
            this._Rpv_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._Rpv_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this._Rpv_Main.Location = new System.Drawing.Point(0, 112);
            this._Rpv_Main.Name = "_Rpv_Main";
            this._Rpv_Main.SelectionFormula = "";
            this._Rpv_Main.ShowParameterPanelButton = false;
            this._Rpv_Main.Size = new System.Drawing.Size(753, 339);
            this._Rpv_Main.TabIndex = 22;
            this._Rpv_Main.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this._Rpv_Main.ViewTimeSelectionFormula = "";
            // 
            // Frm_Inf_CheqDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 451);
            this.Controls.Add(this._Rpv_Main);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Inf_CheqDev";
            this.Text = "Relación de Cheques Devueltos";
            this.Load += new System.EventHandler(this.Frm_Inf_CheqDev_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button _Bt_Consultar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton _Rb_SinFiltro;
        private System.Windows.Forms.ComboBox _Cb_Cliente;
        private System.Windows.Forms.RadioButton _Rb_Cliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox _Cb_Vendedor;
        private System.Windows.Forms.RadioButton _Rb_Vendedor;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer _Rpv_Main;
    }
}