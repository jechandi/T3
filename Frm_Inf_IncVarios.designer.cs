﻿namespace T3
{
    partial class Frm_Inf_IncVarios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Inf_IncVarios));
            this.panel1 = new System.Windows.Forms.Panel();
            this._Rb_Act = new System.Windows.Forms.RadioButton();
            this._Rb_Efec = new System.Windows.Forms.RadioButton();
            this._Rb_Dev = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this._Cmb_User = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this._Cmb_Grupo = new System.Windows.Forms.ComboBox();
            this._Bt_Consultar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this._Cmb_Generacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this._Cmb_Mes = new System.Windows.Forms.ComboBox();
            this._Rpt_Report = new Microsoft.Reporting.WinForms.ReportViewer();
            this._Er_Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Er_Error)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._Rb_Act);
            this.panel1.Controls.Add(this._Rb_Efec);
            this.panel1.Controls.Add(this._Rb_Dev);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this._Cmb_User);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this._Cmb_Grupo);
            this.panel1.Controls.Add(this._Bt_Consultar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this._Cmb_Generacion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this._Cmb_Mes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 139);
            this.panel1.TabIndex = 0;
            // 
            // _Rb_Act
            // 
            this._Rb_Act.AutoSize = true;
            this._Rb_Act.Location = new System.Drawing.Point(444, 110);
            this._Rb_Act.Name = "_Rb_Act";
            this._Rb_Act.Size = new System.Drawing.Size(140, 17);
            this._Rb_Act.TabIndex = 186;
            this._Rb_Act.TabStop = true;
            this._Rb_Act.Text = "Incentivo por Activación";
            this._Rb_Act.UseVisualStyleBackColor = true;
            // 
            // _Rb_Efec
            // 
            this._Rb_Efec.AutoSize = true;
            this._Rb_Efec.Location = new System.Drawing.Point(444, 87);
            this._Rb_Efec.Name = "_Rb_Efec";
            this._Rb_Efec.Size = new System.Drawing.Size(143, 17);
            this._Rb_Efec.TabIndex = 185;
            this._Rb_Efec.TabStop = true;
            this._Rb_Efec.Text = "Incentivo por Efectividad";
            this._Rb_Efec.UseVisualStyleBackColor = true;
            // 
            // _Rb_Dev
            // 
            this._Rb_Dev.AutoSize = true;
            this._Rb_Dev.Checked = true;
            this._Rb_Dev.Location = new System.Drawing.Point(444, 64);
            this._Rb_Dev.Name = "_Rb_Dev";
            this._Rb_Dev.Size = new System.Drawing.Size(144, 17);
            this._Rb_Dev.TabIndex = 184;
            this._Rb_Dev.TabStop = true;
            this._Rb_Dev.Text = "Incentivo por Devolución";
            this._Rb_Dev.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 183;
            this.label4.Text = "Usuarios:";
            // 
            // _Cmb_User
            // 
            this._Cmb_User.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._Cmb_User.Enabled = false;
            this._Cmb_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._Cmb_User.Font = new System.Drawing.Font("Verdana", 6.75F);
            this._Cmb_User.FormattingEnabled = true;
            this._Cmb_User.Location = new System.Drawing.Point(15, 107);
            this._Cmb_User.Name = "_Cmb_User";
            this._Cmb_User.Size = new System.Drawing.Size(423, 20);
            this._Cmb_User.TabIndex = 182;
            this._Cmb_User.DropDown += new System.EventHandler(this._Cmb_User_DropDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 181;
            this.label3.Text = "Grupo a incentivar:";
            // 
            // _Cmb_Grupo
            // 
            this._Cmb_Grupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._Cmb_Grupo.Enabled = false;
            this._Cmb_Grupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._Cmb_Grupo.Font = new System.Drawing.Font("Verdana", 6.75F);
            this._Cmb_Grupo.FormattingEnabled = true;
            this._Cmb_Grupo.Location = new System.Drawing.Point(15, 66);
            this._Cmb_Grupo.Name = "_Cmb_Grupo";
            this._Cmb_Grupo.Size = new System.Drawing.Size(423, 20);
            this._Cmb_Grupo.TabIndex = 180;
            this._Cmb_Grupo.SelectedIndexChanged += new System.EventHandler(this._Cmb_Grupo_SelectedIndexChanged);
            this._Cmb_Grupo.DropDown += new System.EventHandler(this._Cmb_Grupo_DropDown);
            // 
            // _Bt_Consultar
            // 
            this._Bt_Consultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._Bt_Consultar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this._Bt_Consultar.Image = ((System.Drawing.Image)(resources.GetObject("_Bt_Consultar.Image")));
            this._Bt_Consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._Bt_Consultar.Location = new System.Drawing.Point(607, 83);
            this._Bt_Consultar.Name = "_Bt_Consultar";
            this._Bt_Consultar.Size = new System.Drawing.Size(118, 44);
            this._Bt_Consultar.TabIndex = 179;
            this._Bt_Consultar.Text = "Consultar";
            this._Bt_Consultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._Bt_Consultar.UseVisualStyleBackColor = true;
            this._Bt_Consultar.Click += new System.EventHandler(this._Bt_Consultar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(180, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Generación:";
            // 
            // _Cmb_Generacion
            // 
            this._Cmb_Generacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._Cmb_Generacion.Enabled = false;
            this._Cmb_Generacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._Cmb_Generacion.Font = new System.Drawing.Font("Verdana", 6.75F);
            this._Cmb_Generacion.FormattingEnabled = true;
            this._Cmb_Generacion.Location = new System.Drawing.Point(183, 25);
            this._Cmb_Generacion.Name = "_Cmb_Generacion";
            this._Cmb_Generacion.Size = new System.Drawing.Size(255, 20);
            this._Cmb_Generacion.TabIndex = 12;
            this._Cmb_Generacion.SelectedIndexChanged += new System.EventHandler(this._Cmb_Generacion_SelectedIndexChanged);
            this._Cmb_Generacion.DropDown += new System.EventHandler(this._Cmb_Generacion_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mes y año de ventas:";
            // 
            // _Cmb_Mes
            // 
            this._Cmb_Mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._Cmb_Mes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._Cmb_Mes.Font = new System.Drawing.Font("Verdana", 6.75F);
            this._Cmb_Mes.FormattingEnabled = true;
            this._Cmb_Mes.Location = new System.Drawing.Point(15, 25);
            this._Cmb_Mes.Name = "_Cmb_Mes";
            this._Cmb_Mes.Size = new System.Drawing.Size(148, 20);
            this._Cmb_Mes.TabIndex = 9;
            this._Cmb_Mes.SelectedIndexChanged += new System.EventHandler(this._Cmb_Mes_SelectedIndexChanged);
            this._Cmb_Mes.DropDown += new System.EventHandler(this._Cmb_Mes_DropDown);
            // 
            // _Rpt_Report
            // 
            this._Rpt_Report.Dock = System.Windows.Forms.DockStyle.Fill;
            this._Rpt_Report.Location = new System.Drawing.Point(0, 139);
            this._Rpt_Report.Name = "_Rpt_Report";
            this._Rpt_Report.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this._Rpt_Report.ServerReport.ReportServerUrl = new System.Uri("", System.UriKind.Relative);
            this._Rpt_Report.ShowParameterPrompts = false;
            this._Rpt_Report.Size = new System.Drawing.Size(844, 411);
            this._Rpt_Report.TabIndex = 7;
            // 
            // _Er_Error
            // 
            this._Er_Error.ContainerControl = this;
            // 
            // Frm_Inf_IncVarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 550);
            this.Controls.Add(this._Rpt_Report);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Inf_IncVarios";
            this.Text = "Informe - Incentivos Varios";
            this.Load += new System.EventHandler(this.Frm_Inf_IncVarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Er_Error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer _Rpt_Report;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _Cmb_Mes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox _Cmb_Generacion;
        private System.Windows.Forms.Button _Bt_Consultar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox _Cmb_Grupo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox _Cmb_User;
        private System.Windows.Forms.ErrorProvider _Er_Error;
        private System.Windows.Forms.RadioButton _Rb_Dev;
        private System.Windows.Forms.RadioButton _Rb_Act;
        private System.Windows.Forms.RadioButton _Rb_Efec;
    }
}