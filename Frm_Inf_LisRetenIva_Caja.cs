using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
namespace T3
{
    public partial class Frm_Inf_LisRetenIva_Caja : Form
    {
        public Frm_Inf_LisRetenIva_Caja()
        {
            InitializeComponent();
        }
        private void _Mtd_Buscar()
        {
            string _Str_TipoFact = "";
            string _Str_TipoNd = "";
            string _Str_Cadena = "SELECT ctipdocfact,ctipdocnotdeb FROM TCONFIGCXC WHERE ccompany='" + Frm_Padre._Str_Comp + "'";
            DataSet _Ds = Program._MyClsCnn._mtd_conexion._Mtd_RetornarDataset(_Str_Cadena);
            if (_Ds.Tables[0].Rows.Count > 0)
            {
                _Str_TipoFact = _Ds.Tables[0].Rows[0][0].ToString().Trim();
                _Str_TipoNd = _Ds.Tables[0].Rows[0][1].ToString().Trim();
            }

            string _Str_Sql = "SELECT * FROM VST_INF_RETENCIONIVA WHERE cgroupcomp='" + Frm_Padre._Str_GroupComp + "' AND ccompany='" + Frm_Padre._Str_Comp + "' AND ccaja='" + _Txt_Caja.Text.Trim() + "' AND (ctipodocument='" + _Str_TipoFact + "' OR  ctipodocument='" + _Str_TipoNd + "')";
            if (_Txt_Caja_2.Text.Trim().Length > 0)
            {
                _Str_Sql = "SELECT * FROM VST_INF_RETENCIONIVA WHERE cgroupcomp='" + Frm_Padre._Str_GroupComp + "' AND ccompany='" + Frm_Padre._Str_Comp + "' AND (convert(numeric(18,0),ccaja) BETWEEN " + _Txt_Caja.Text + " AND " + _Txt_Caja_2.Text + ") AND (ctipodocument='" + _Str_TipoFact + "' OR  ctipodocument='" + _Str_TipoNd + "') ORDER BY convert(numeric(18,0),ccaja)";
                _Ds = Program._MyClsCnn._mtd_conexion._Mtd_RetornarDataset(_Str_Sql);
                if (_Ds.Tables[0].Rows.Count > 0)
                {
                    Report.rInfRetencionIva2 _My_Reporte = new T3.Report.rInfRetencionIva2();
                    _My_Reporte.SetDataSource(_Ds.Tables[0]);
                    Section _sec = _My_Reporte.ReportDefinition.Sections["Section1"];
                    TextObject tex1 = _sec.ReportObjects["cabecera"] as TextObject;
                    tex1.Text = Program._MyClsCnn._mtd_conexion._Mtd_RetornarDataset("SELECT rtrim(cname) FROM TCOMPANY WHERE ccompany='" + Frm_Padre._Str_Comp + "'").Tables[0].Rows[0][0].ToString();
                    this._Rpv_Main.ReportSource = _My_Reporte;
                    _Rpv_Main.RefreshReport();
                }
                else
                {
                    this._Rpv_Main.ReportSource = null;
                    MessageBox.Show("No existen Retenciones de IVA.", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                _Ds = Program._MyClsCnn._mtd_conexion._Mtd_RetornarDataset(_Str_Sql);
                if (_Ds.Tables[0].Rows.Count > 0)
                {
                    Report.rInfRetencionIva _My_Reporte = new T3.Report.rInfRetencionIva();
                    _My_Reporte.SetDataSource(_Ds.Tables[0]);
                    Section _sec = _My_Reporte.ReportDefinition.Sections["Section1"];
                    TextObject tex1 = _sec.ReportObjects["cabecera"] as TextObject;
                    tex1.Text = Program._MyClsCnn._mtd_conexion._Mtd_RetornarDataset("SELECT rtrim(cname) FROM TCOMPANY WHERE ccompany='" + Frm_Padre._Str_Comp + "'").Tables[0].Rows[0][0].ToString();
                    this._Rpv_Main.ReportSource = _My_Reporte;
                    _Rpv_Main.RefreshReport();
                }
                else
                {
                    this._Rpv_Main.ReportSource = null;
                    MessageBox.Show("No existen Retenciones de IVA.", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void _Bt_Caja_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Frm_Busqueda2 _Frm = new Frm_Busqueda2(52, _Txt_Caja, 0, " AND EXISTS(SELECT * FROM VST_INF_RETENCIONIVA WHERE cgroupcomp='" + Frm_Padre._Str_GroupComp + "' AND ccompany='" + Frm_Padre._Str_Comp + "' AND TCAJACXC.ccaja=VST_INF_RETENCIONIVA.ccaja)");
            Cursor = Cursors.Default;
            _Frm.ShowDialog();
            this._Rpv_Main.ReportSource = null;
            _Txt_Caja_2.Text = "";
        }

        private void _Bt_Consultar_Click(object sender, EventArgs e)
        {
            if (_Txt_Caja.Text.Trim().Length > 0)
            {
                _Er_Error.Dispose();
                Cursor = Cursors.WaitCursor;
                _Mtd_Buscar();
                Cursor = Cursors.Default;
            }
            else
            { _Er_Error.SetError(_Bt_Caja, "Informaci�n requerida!!!"); }
        }

        private void Frm_Inf_LisRetenIva_Caja_Load(object sender, EventArgs e)
        {

        }

        private void _Bt_Caja_2_Click(object sender, EventArgs e)
        {
            if (_Txt_Caja.Text.Trim().Length > 0)
            {
                Cursor = Cursors.WaitCursor;
                Frm_Busqueda2 _Frm = new Frm_Busqueda2(52, _Txt_Caja_2, 0, " AND EXISTS(SELECT * FROM VST_INF_RETENCIONIVA WHERE cgroupcomp='" + Frm_Padre._Str_GroupComp + "' AND ccompany='" + Frm_Padre._Str_Comp + "' AND TCAJACXC.ccaja=VST_INF_RETENCIONIVA.ccaja) AND convert(numeric(18,0),ccaja)>" + _Txt_Caja.Text.Trim());
                Cursor = Cursors.Default;
                _Frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe ingresar datos en 'Caja Desde'.", "Requerimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void _Bt_Limpiar_Click(object sender, EventArgs e)
        {
            this._Rpv_Main.ReportSource = null;
            _Txt_Caja_2.Text = "";
        }
    }
}