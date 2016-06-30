using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace T3_Popup
{   
    public partial class Frm_Popup : Form
    {
        string _Str_GrupoComp = "";
        string _Str_Compa�ia = "";
        string _Str_Usuario = "";
        public Frm_Popup(string[] _P_Str_Argumentos)
        {
            InitializeComponent();
            string[] _Str_Split = _P_Str_Argumentos[0].Split(new char[] { '-' });
            _Str_GrupoComp = _Str_Split[0].ToString();
            _Str_Compa�ia = _Str_Split[1].ToString();
            _Str_Usuario = _Str_Split[2].ToString();
        }
        DataSet _Ds_DD = new DataSet();
        PopupNotifier _Pop_Popup = new PopupNotifier();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private DataSet _Mtd_DataSets(string _P_Str_Cadena)
        {
            DataSet _Ds = new DataSet();
            SqlConnection _Sql_Conex = new SqlConnection(CLASES._Cls_Conexion._Mtd_Conexion_()._g_Str_Stringconex);
            SqlDataAdapter _Sql_Adap = new SqlDataAdapter(_P_Str_Cadena, _Sql_Conex);
            _Sql_Conex.Open();
            _Sql_Adap.Fill(_Ds);
            _Sql_Conex.Close();
            return _Ds;
        }
        private void Frm_Popup_Activated(object sender, EventArgs e)
        {
            this.Hide();
        }
        int _Int_0 = 0, _Int_1 = 0, _Int_2 = 0, _Int_3 = 0, _Int_4 = 0;
        int _Int_5 = 0, _Int_6 = 0, _Int_7 = 0, _Int_8 = 0, _Int_9 = 0;
        int _Int_10 = 0, _Int_11 = 0, _Int_12 = 0, _Int_13 = 0, _Int_14 = 0;
        int _Int_15 = 0, _Int_16 = 0, _Int_17 = 0, _Int_18 = 0, _Int_19 = 0;
        int _Int_20 = 0, _Int_21 = 0, _Int_22 = 0, _Int_23 = 0, _Int_24 = 0;
        int _Int_25 = 0, _Int_26 = 0, _Int_27 = 0, _Int_28 = 0, _Int_29 = 0;
        int _Int_30 = 0, _Int_31 = 0, _Int_32 = 0, _Int_33 = 0, _Int_34 = 0;
        int _Int_35 = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                string _Str_Sql = "SELECT TTABS.ctabs " +
    "FROM TUSER INNER JOIN " +
    "TTABS ON TUSER.cgroup = TTABS.cgroup " +
    "WHERE TUSER.cdelete = 0 and TUSER.cuser='" + _Str_Usuario + "'";
                _Ds_DD = _Mtd_DataSets(_Str_Sql);
                foreach (DataRow _Row in _Ds_DD.Tables[0].Rows)
                {
                    DataSet _Ds = new DataSet();
                    string _Str_Cadena = "";
                    int _Int_Tabs = Convert.ToInt32(_Row[0].ToString());
                    switch (_Int_Tabs)
                    {
                        //---------------------TABS N�MERO 0
                        case 0:
                            _Str_Cadena = "select * from TPROSPECTO where c_solicitud='1' and cdelete='0' and cgroupcomp='" + _Str_GrupoComp + "'";
                            _Ds = _Mtd_DataSets(_Str_Cadena);
                            if (_Ds.Tables[0].Rows.Count > _Int_0)
                            {
                                _Pop_Popup.TitleText = "Prospectos";
                                _Pop_Popup.ContentText = "Existen " + _Ds.Tables[0].Rows.Count.ToString().Trim() + " " + _Pop_Popup.TitleText.Trim() + " Sin ver";
                                barra _Cls_Popup = new barra();
                                _Cls_Popup.cuadro1("Aviso", _Pop_Popup.ContentText);
                                _Int_0 = _Ds.Tables[0].Rows.Count;
                            }
                            break;
                        //---------------------TABS N�MERO 0
                        //---------------------TABS N�MERO 1
                        case 1:
                            _Str_Cadena = "SELECT * FROM TCOTPEDFACM INNER JOIN TCLIENTE ON TCOTPEDFACM.ccliente = TCLIENTE.ccliente INNER JOIN TVENDEDOR ON TCOTPEDFACM.ccompany = TVENDEDOR.ccompany AND TCOTPEDFACM.cvendedor = TVENDEDOR.cvendedor WHERE (TCOTPEDFACM.cstatus = 2) AND (TCOTPEDFACM.ccliente>0) AND (TCOTPEDFACM.cfactura <= 0) AND (TCOTPEDFACM.ccompany ='" + _Str_Compa�ia + "')" + " AND (TCLIENTE.cgroupcomp ='" + _Str_GrupoComp + "')";
                            _Ds = _Mtd_DataSets(_Str_Cadena);
                            if (_Ds.Tables[0].Rows.Count > _Int_1)
                            {
                                _Pop_Popup.TitleText = "Pedidos Bloqueados";
                                _Pop_Popup.ContentText = "Existen " + _Ds.Tables[0].Rows.Count.ToString().Trim() + " " + _Pop_Popup.TitleText.Trim() + " Sin ver";
                                barra _Cls_Popup = new barra();
                                _Cls_Popup.cuadro1("Aviso", _Pop_Popup.ContentText);
                                _Int_1 = _Ds.Tables[0].Rows.Count;
                            }
                            break;
                        //---------------------TABS N�MERO 1
                        //---------------------TABS N�MERO 2
                        case 2:
                            _Str_Cadena = "SELECT * FROM TCLIENTE WHERE (c_estatus_cob = 'B') AND (cgroupcomp ='" + _Str_GrupoComp + "')";
                            _Ds = _Mtd_DataSets(_Str_Cadena);
                            if (_Ds.Tables[0].Rows.Count > _Int_2)
                            {
                                _Pop_Popup.TitleText = "Clientes Bloqueados";
                                _Pop_Popup.ContentText = "Existen " + _Ds.Tables[0].Rows.Count.ToString().Trim() + " " + _Pop_Popup.TitleText.Trim() + " Sin ver";
                                barra _Cls_Popup = new barra();
                                _Cls_Popup.cuadro1("Aviso", _Pop_Popup.ContentText);
                                _Int_2 = _Ds.Tables[0].Rows.Count;
                            }
                            break;
                        //---------------------TABS N�MERO 2
                        //---------------------TABS N�MERO 3
                        case 3:
                            _Str_Cadena = "SELECT * FROM TNOTACREDIT WHERE (cactivo = '0') AND (ccompany ='" + _Str_Compa�ia + "')";
                            _Ds = _Mtd_DataSets(_Str_Cadena);
                            if (_Ds.Tables[0].Rows.Count > _Int_3)
                            {
                                _Pop_Popup.TitleText = "Notas Cr�dito por Aprobar";
                                _Pop_Popup.ContentText = "Existen " + _Ds.Tables[0].Rows.Count.ToString().Trim() + " " + _Pop_Popup.TitleText.Trim() + " Sin ver";
                                barra _Cls_Popup = new barra();
                                _Cls_Popup.cuadro1("Aviso", _Pop_Popup.ContentText);
                                _Int_3 = _Ds.Tables[0].Rows.Count;
                            }
                            break;
                        //---------------------TABS N�MERO 3
                        //---------------------TABS N�MERO 4
                        case 4:
                            _Str_Cadena = "SELECT * FROM TCLIENTE WHERE c_zonificado='0' and cgroupcomp = '" + _Str_GrupoComp + "'";
                            _Ds = _Mtd_DataSets(_Str_Cadena);
                            if (_Ds.Tables[0].Rows.Count > _Int_4)
                            {
                                _Pop_Popup.TitleText = "Clientes sin zonificaci�n";
                                _Pop_Popup.ContentText = "Existen " + _Ds.Tables[0].Rows.Count.ToString().Trim() + " " + _Pop_Popup.TitleText.Trim() + " Sin ver";
                                barra _Cls_Popup = new barra();
                                _Cls_Popup.cuadro1("Aviso", _Pop_Popup.ContentText);
                                _Int_4 = _Ds.Tables[0].Rows.Count;
                            }
                            break;
                        //---------------------TABS N�MERO 4
                        //---------------------TABS N�MERO 5
                        case 5:
                            _Str_Cadena = "SELECT * FROM TPRODUCTO WHERE  (cpuntoreorden >=cexisrealu1) AND (cpuntoreorden>0)";
                            _Ds = _Mtd_DataSets(_Str_Cadena);
                            if (_Ds.Tables[0].Rows.Count > _Int_5)
                            {
                                _Pop_Popup.TitleText = "Punto de Reorden";
                                _Pop_Popup.ContentText = "Existen " + _Ds.Tables[0].Rows.Count.ToString().Trim() + " " + _Pop_Popup.TitleText.Trim() + " Sin ver";
                                barra _Cls_Popup = new barra();
                                _Cls_Popup.cuadro1("Aviso", _Pop_Popup.ContentText);
                                _Int_5 = _Ds.Tables[0].Rows.Count;
                            }
                            break;
                        //---------------------TABS N�MERO 5
                        //---------------------TABS N�MERO 6
                        case 6:
                            _Str_Cadena = "SELECT * FROM vst_pedidosbloqueados WHERE (ccompany ='" + _Str_Compa�ia + "')" + " AND (cgroupcomp ='" + _Str_GrupoComp + "')";
                            _Ds = _Mtd_DataSets(_Str_Cadena);
                            if (_Ds.Tables[0].Rows.Count > _Int_6)
                            {
                                _Pop_Popup.TitleText = "Pedidos Bloqueados";
                                _Pop_Popup.ContentText = "Existen " + _Ds.Tables[0].Rows.Count.ToString().Trim() + " " + _Pop_Popup.TitleText.Trim() + " Sin ver";
                                barra _Cls_Popup = new barra();
                                _Cls_Popup.cuadro1("Aviso", _Pop_Popup.ContentText);
                                _Int_6 = _Ds.Tables[0].Rows.Count;
                            }
                            break;
                        //---------------------TABS N�MERO 6
                        //---------------------TABS N�MERO 7
                        case 7:
                            _Str_Cadena = "SELECT * FROM TBAKORDERM WHERE  (ccompany ='" + _Str_Compa�ia + "')";
                            _Ds = _Mtd_DataSets(_Str_Cadena);
                            if (_Ds.Tables[0].Rows.Count > _Int_7)
                            {
                                _Pop_Popup.TitleText = "Back order";
                                _Pop_Popup.ContentText = "Existen " + _Ds.Tables[0].Rows.Count.ToString().Trim() + " " + _Pop_Popup.TitleText.Trim() + " Sin ver";
                                barra _Cls_Popup = new barra();
                                _Cls_Popup.cuadro1("Aviso", _Pop_Popup.ContentText);
                                _Int_7 = _Ds.Tables[0].Rows.Count;
                            }
                            break;
                        //---------------------TABS N�MERO 7
                        //---------------------TABS N�MERO 8
                        case 8:
                            _Str_Cadena = "SELECT * " +
    "FROM TPREORDENCM INNER JOIN " +
    "TPROVEEDOR ON TPREORDENCM.cproveedor = TPROVEEDOR.cproveedor AND " +
    "TPREORDENCM.cdelete = TPROVEEDOR.cdelete " +
    "WHERE (TPREORDENCM.cdelete = 0) AND (TPREORDENCM.cstatus = 5) AND (TPREORDENCM.ccompany = '" + _Str_Compa�ia + "')";
                            _Ds = _Mtd_DataSets(_Str_Cadena);
                            if (_Ds.Tables[0].Rows.Count > _Int_8)
                            {
                                _Pop_Popup.TitleText = "P.O.C. por Vendedor";
                                _Pop_Popup.ContentText = "Existen " + _Ds.Tables[0].Rows.Count.ToString().Trim() + " " + _Pop_Popup.TitleText.Trim() + " Sin ver";
                                barra _Cls_Popup = new barra();
                                _Cls_Popup.cuadro1("Aviso", _Pop_Popup.ContentText);
                                _Int_8 = _Ds.Tables[0].Rows.Count;
                            }
                            break;
                        //---------------------TABS N�MERO 8
                        //---------------------TABS N�MERO 9-- Se usa la vista vst_tabordencompra
                        case 9:
                            _Str_Cadena = _Str_Cadena = "SELECT cnumoc AS [Id O.C.],Fecha,Proveedor,Cajas,Monto " +
    "FROM vst_tabordencompra " +
    "WHERE (ccompany = '" + _Str_Compa�ia + "') AND (cocaprovee=1) AND (centroinvent=0) AND (ccerrada=0) AND (cefectividad<=(Select cmaxefectivioc from TCONFIGCOMP where ccompany='" + _Str_Compa�ia + "'))";
                            _Ds = _Mtd_DataSets(_Str_Cadena);
                            if (_Ds.Tables[0].Rows.Count > _Int_9)
                            {
                                _Pop_Popup.TitleText = "O.C. por llegar";
                                _Pop_Popup.ContentText = "Existen " + _Ds.Tables[0].Rows.Count.ToString().Trim() + " " + _Pop_Popup.TitleText.Trim() + " Sin ver";
                                barra _Cls_Popup = new barra();
                                _Cls_Popup.cuadro1("Aviso", _Pop_Popup.ContentText);
                                _Int_9 = _Ds.Tables[0].Rows.Count;
                            }
                            break;
                        //---------------------TABS N�MERO 9
                        //---------------------TABS N�MERO 10
                        case 10:
                            _Str_Cadena = "SELECT * " +
    "FROM TRECEPCIONM INNER JOIN " +
    "TPROVEEDOR ON TRECEPCIONM.cproveedor = TPROVEEDOR.cproveedor " +
    "WHERE (TRECEPCIONM.cgroupcomp = '" + _Str_GrupoComp + "') AND (TPROVEEDOR.cdelete = 0) AND (TRECEPCIONM.ccerrada = 0) AND (TRECEPCIONM.cevaluado = 0)";
                            _Ds = _Mtd_DataSets(_Str_Cadena);
                            if (_Ds.Tables[0].Rows.Count > _Int_10)
                            {
                                _Pop_Popup.TitleText = "Recepciones de Transportes";
                                _Pop_Popup.ContentText = "Existen " + _Ds.Tables[0].Rows.Count.ToString().Trim() + " " + _Pop_Popup.TitleText.Trim() + " Sin ver";
                                barra _Cls_Popup = new barra();
                                _Cls_Popup.cuadro1("Aviso", _Pop_Popup.ContentText);
                                _Int_10 = _Ds.Tables[0].Rows.Count;
                            }
                            break;
                        //---------------------TABS N�MERO 10
                        //---------------------TABS N�MERO 11
                        case 11:
                            _Str_Cadena = "SELECT * " +
    "FROM TRECEPCIONM INNER JOIN " +
    "TPROVEEDOR ON TRECEPCIONM.cproveedor = TPROVEEDOR.cproveedor " +
    "WHERE (TRECEPCIONM.cgroupcomp = '" + _Str_GrupoComp + "') AND (TPROVEEDOR.cdelete = 0) AND (TRECEPCIONM.ccerrada = 0)";
                            _Ds = _Mtd_DataSets(_Str_Cadena);
                            if (_Ds.Tables[0].Rows.Count > _Int_11)
                            {
                                _Pop_Popup.TitleText = "Recepciones de Transportes";
                                _Pop_Popup.ContentText = "Existen " + _Ds.Tables[0].Rows.Count.ToString().Trim() + " " + _Pop_Popup.TitleText.Trim() + " Sin ver";
                                barra _Cls_Popup = new barra();
                                _Cls_Popup.cuadro1("Aviso", _Pop_Popup.ContentText);
                                _Int_11 = _Ds.Tables[0].Rows.Count;
                            }
                            break;
                        //---------------------TABS N�MERO 11
                        //---------------------TABS N�MERO 12
                        case 12:
                            _Str_Cadena = "Select * from vst_ordendecompragerente where ccompany='" + _Str_Compa�ia + "' and cgroupcomp='" + _Str_GrupoComp + "'";
                            _Ds = _Mtd_DataSets(_Str_Cadena);
                            if (_Ds.Tables[0].Rows.Count > _Int_12)
                            {
                                _Pop_Popup.TitleText = "O.C por Cerrar";
                                _Pop_Popup.ContentText = "Existen " + _Ds.Tables[0].Rows.Count.ToString().Trim() + " " + _Pop_Popup.TitleText.Trim() + " Sin ver";
                                barra _Cls_Popup = new barra();
                                _Cls_Popup.cuadro1("Aviso", _Pop_Popup.ContentText);
                                _Int_12 = _Ds.Tables[0].Rows.Count;
                            }
                            break;
                        //---------------------TABS N�MERO 12
                        //---------------------TABS N�MERO 13
                        case 13:
                            _Str_Cadena = "Select * from vst_consultanotarecepcionmaestra where cdelete='0' and cgroupcomp='" + _Str_GrupoComp + "' and ccompany='" + _Str_Compa�ia + "' and cimpreso='0'";
                            _Ds = _Mtd_DataSets(_Str_Cadena);
                            if (_Ds.Tables[0].Rows.Count > _Int_13)
                            {
                                _Pop_Popup.TitleText = "N.R. por Imprimir";
                                _Pop_Popup.ContentText = "Existen " + _Ds.Tables[0].Rows.Count.ToString().Trim() + " " + _Pop_Popup.TitleText.Trim() + " Sin ver";
                                barra _Cls_Popup = new barra();
                                _Cls_Popup.cuadro1("Aviso", _Pop_Popup.ContentText);
                                _Int_13 = _Ds.Tables[0].Rows.Count;
                            }
                            break;
                        //---------------------TABS N�MERO 13
                        //---------------------TABS N�MERO 14
                        case 14:
                            _Str_Cadena = "Select * from TNOTADEBITOCP where cdelete='0' and ccompany='" + _Str_Compa�ia + "' and cgroupcomp='" + _Str_GrupoComp + "' and cimpresa='0' and cactivo='0'";
                            _Ds = _Mtd_DataSets(_Str_Cadena);
                            if (_Ds.Tables[0].Rows.Count > _Int_14)
                            {
                                _Pop_Popup.TitleText = "N.D. por Imprimir";
                                _Pop_Popup.ContentText = "Existen " + _Ds.Tables[0].Rows.Count.ToString().Trim() + " " + _Pop_Popup.TitleText.Trim() + " Sin ver";
                                barra _Cls_Popup = new barra();
                                _Cls_Popup.cuadro1("Aviso", _Pop_Popup.ContentText);
                                _Int_14 = _Ds.Tables[0].Rows.Count;
                            }
                            break;
                        //---------------------TABS N�MERO 14
                        //---------------------TABS N�MERO 15
                        case 15:
                            _Str_Cadena = "Select * from TNOTACREDICP where cdelete='0' and ccompany='" + _Str_Compa�ia + "' and cgroupcomp='" + _Str_GrupoComp + "' and cimpresa='0' and cactivo='0'";
                            _Ds = _Mtd_DataSets(_Str_Cadena);
                            if (_Ds.Tables[0].Rows.Count > _Int_15)
                            {
                                _Pop_Popup.TitleText = "N.C. por Imprimir";
                                _Pop_Popup.ContentText = "Existen " + _Ds.Tables[0].Rows.Count.ToString().Trim() + " " + _Pop_Popup.TitleText.Trim() + " Sin ver";
                                barra _Cls_Popup = new barra();
                                _Cls_Popup.cuadro1("Aviso", _Pop_Popup.ContentText);
                                _Int_15 = _Ds.Tables[0].Rows.Count;
                            }
                            break;
                        //---------------------TABS N�MERO 15
                        //---------------------TABS N�MERO 16
                        case 16:
                            _Str_Cadena = "SELECT * " +
     "FROM vst_tabdeevaluacionespendientes WHERE cgroupcomp = '" + _Str_GrupoComp + "'";
                            _Ds = _Mtd_DataSets(_Str_Cadena);
                            if (_Ds.Tables[0].Rows.Count > _Int_16)
                            {
                                _Pop_Popup.TitleText = "Recepciones sin firma";
                                _Pop_Popup.ContentText = "Existen " + _Ds.Tables[0].Rows.Count.ToString().Trim() + " " + _Pop_Popup.TitleText.Trim() + " Sin ver";
                                barra _Cls_Popup = new barra();
                                _Cls_Popup.cuadro1("Aviso", _Pop_Popup.ContentText);
                                _Int_16 = _Ds.Tables[0].Rows.Count;
                            }
                            break;
                        //---------------------TABS N�MERO 16
                        //---------------------TABS N�MERO 17
                        case 17:
                            _Str_Cadena = "select * from VST_PAGOSCXPM where cgroupcomp='" + _Str_GrupoComp + "' and ccompany='" + _Str_Compa�ia + "' and ccancelado=0 and canulado=0";
                            _Ds = _Mtd_DataSets(_Str_Cadena);
                            if (_Ds.Tables[0].Rows.Count > _Int_17)
                            {
                                _Pop_Popup.TitleText = "Pagos Pendientes";
                                _Pop_Popup.ContentText = "Existen " + _Ds.Tables[0].Rows.Count.ToString().Trim() + " " + _Pop_Popup.TitleText.Trim() + " Sin ver";
                                barra _Cls_Popup = new barra();
                                _Cls_Popup.cuadro1("Aviso", _Pop_Popup.ContentText);
                                _Int_17 = _Ds.Tables[0].Rows.Count;
                            }
                            break;
                        //---------------------TABS N�MERO 17
                        //---------------------TABS N�MERO 18
                        case 18:
                            if (new CLASES._Cls_Varios_Metodos(true)._Mtd_ObtenerUsuarioFirma(_Str_Usuario) == "1")
                            {
                                if (new CLASES._Cls_Varios_Metodos(true)._Mtd_UsuarioProceso(_Str_Usuario, "F_EMISION_CHEQUE_CONT"))
                                {
                                    _Str_Cadena = "select * from VST_EMICHEQTRANSM WHERE (cgroupcomp='" + _Str_GrupoComp + "' AND ccompany='" + _Str_Compa�ia + "') AND (cfuserfirmante1=0 AND cfusersolicitante=1)";
                                    _Ds = _Mtd_DataSets(_Str_Cadena);
                                    if (_Ds.Tables[0].Rows.Count > _Int_18)
                                    {
                                        _Pop_Popup.TitleText = "Cheques / Transferencias pendientes";
                                        _Pop_Popup.ContentText = "Existen " + _Ds.Tables[0].Rows.Count.ToString().Trim() + " " + _Pop_Popup.TitleText.Trim() + " Sin ver";
                                        barra _Cls_Popup = new barra();
                                        _Cls_Popup.cuadro1("Aviso", _Pop_Popup.ContentText);
                                        _Int_18 = _Ds.Tables[0].Rows.Count;
                                    }
                                }
                            }
                            break;
                        //---------------------TABS N�MERO 18
                        //---------------------TABS N�MERO 19
                        case 19:
                            if (new CLASES._Cls_Varios_Metodos(true)._Mtd_ObtenerUsuarioFirma(_Str_Usuario) == "1")
                            {
                                if (new CLASES._Cls_Varios_Metodos(true)._Mtd_UsuarioProceso(_Str_Usuario, "F_EMISION_CHEQUE_FIRMA"))
                                {
                                    _Str_Cadena = "select * from VST_EMICHEQTRANSM WHERE (cgroupcomp='" + _Str_GrupoComp + "' AND ccompany='" + _Str_Compa�ia + "') AND (cfuseraprobador=0 AND cfusersolicitante=1 AND cfuserfirmante1=1)";
                                    _Ds = _Mtd_DataSets(_Str_Cadena);
                                    if (_Ds.Tables[0].Rows.Count > _Int_19)
                                    {
                                        _Pop_Popup.TitleText = "Cheques / Transferencias pendientes";
                                        _Pop_Popup.ContentText = "Existen " + _Ds.Tables[0].Rows.Count.ToString().Trim() + " " + _Pop_Popup.TitleText.Trim() + " Sin ver";
                                        barra _Cls_Popup = new barra();
                                        _Cls_Popup.cuadro1("Aviso", _Pop_Popup.ContentText);
                                        _Int_19 = _Ds.Tables[0].Rows.Count;
                                    }
                                }
                            }
                            break;
                        //---------------------TABS N�MERO 19
                        //---------------------TABS N�MERO 20
                        case 20:
                            if (new CLASES._Cls_Varios_Metodos(true)._Mtd_ObtenerUsuarioFirma(_Str_Usuario) == "1")
                            {
                                if (new CLASES._Cls_Varios_Metodos(true)._Mtd_UsuarioProceso(_Str_Usuario, "F_EMISION_CHEQUE_IMP"))
                                {
                                    _Str_Cadena = "select * from VST_EMICHEQTRANSM WHERE cgroupcomp='" + _Str_GrupoComp + "' AND ccompany='" + _Str_Compa�ia + "' and cfusersolicitante=1 AND cfuserfirmante1=1 AND cfuseraprobador=1 AND cimpimiocheq=0";
                                    _Ds = _Mtd_DataSets(_Str_Cadena);
                                    if (_Ds.Tables[0].Rows.Count > _Int_20)
                                    {
                                        _Pop_Popup.TitleText = "Cheques por imprimir";
                                        _Pop_Popup.ContentText = "Existen " + _Ds.Tables[0].Rows.Count.ToString().Trim() + " " + _Pop_Popup.TitleText.Trim() + " Sin ver";
                                        barra _Cls_Popup = new barra();
                                        _Cls_Popup.cuadro1("Aviso", _Pop_Popup.ContentText);
                                        _Int_20 = _Ds.Tables[0].Rows.Count;
                                    }
                                }
                            }
                            break;
                        //---------------------TABS N�MERO 20
                        //---------------------TABS N�MERO 21
                        case 21:
                            _Str_Cadena = "SELECT * FROM vst_tabdecomprobantnr where cgroupcomp='" + _Str_GrupoComp + "' and ccompany='" + _Str_Compa�ia + "'";
                            _Ds = _Mtd_DataSets(_Str_Cadena);
                            if (_Ds.Tables[0].Rows.Count > _Int_21)
                            {
                                _Pop_Popup.TitleText = "Comprobante N.R.";
                                _Pop_Popup.ContentText = "Existen " + _Ds.Tables[0].Rows.Count.ToString().Trim() + " " + _Pop_Popup.TitleText.Trim() + " Sin ver";
                                barra _Cls_Popup = new barra();
                                _Cls_Popup.cuadro1("Aviso", _Pop_Popup.ContentText);
                                _Int_21 = _Ds.Tables[0].Rows.Count;
                            }
                            break;
                        //---------------------TABS N�MERO 21
                        //---------------------TABS N�MERO 22
                        case 22:
                            _Str_Cadena = "Select * from TCLIENTE where cdelete='0' and cgroupcomp='" + _Str_GrupoComp + "' AND NOT EXISTS(SELECT ccliente, c_rif, c_nomb_comer FROM  vst_zonaporcliente WHERE (cdelete='0') AND (cgroupcomp = '" + _Str_GrupoComp + "') AND (ccompany = '" + _Str_Compa�ia + "') AND TCLIENTE.ccliente=vst_zonaporcliente.ccliente)";
                            _Ds = _Mtd_DataSets(_Str_Cadena);
                            if (_Ds.Tables[0].Rows.Count > _Int_22)
                            {
                                _Pop_Popup.TitleText = "Clientes sin Zona";
                                _Pop_Popup.ContentText = "Existen " + _Ds.Tables[0].Rows.Count.ToString().Trim() + " " + _Pop_Popup.TitleText.Trim() + " Sin ver";
                                barra _Cls_Popup = new barra();
                                _Cls_Popup.cuadro1("Aviso", _Pop_Popup.ContentText);
                                _Int_22 = _Ds.Tables[0].Rows.Count;
                            }
                            break;
                        //---------------------TABS N�MERO 22
                        //---------------------TABS N�MERO 23
                        case 23:
                            _Str_Cadena = "SELECT * FROM vst_asciifactura where cgroupcomp='" + _Str_GrupoComp + "' and not exists(Select * from TNOTARECEPC where TNOTARECEPC.cgroupcomp=vst_asciifactura.cgroupcomp and TNOTARECEPC.cidrecepcion=vst_asciifactura.cidrecepcion and TNOTARECEPC.cnumdocu=vst_asciifactura.cnfacturapro)";
                            _Ds = _Mtd_DataSets(_Str_Cadena);
                            if (_Ds.Tables[0].Rows.Count > _Int_23)
                            {
                                _Pop_Popup.TitleText = "N.R. por Generar";
                                _Pop_Popup.ContentText = "Existen " + _Ds.Tables[0].Rows.Count.ToString().Trim() + " " + _Pop_Popup.TitleText.Trim() + " Sin ver";
                                barra _Cls_Popup = new barra();
                                _Cls_Popup.cuadro1("Aviso", _Pop_Popup.ContentText);
                                _Int_23 = _Ds.Tables[0].Rows.Count;
                            }
                            break;
                        //---------------------TABS N�MERO 23
                        //---------------------TABS N�MERO 24
                        case 24:
                            _Str_Cadena = "select * from TVENDEDOR where cdelete='0' and c_tipo_vend='1' and ccompany='" + _Str_Compa�ia + "' AND NOT EXISTS(SELECT * FROM  TZONAVENDEDOR WHERE (cdelete='0') AND (TVENDEDOR.ccompany =TZONAVENDEDOR.ccompany) AND (TVENDEDOR.cvendedor = TZONAVENDEDOR.cvendedor))";
                            _Ds = _Mtd_DataSets(_Str_Cadena);
                            if (_Ds.Tables[0].Rows.Count > _Int_24)
                            {
                                _Pop_Popup.TitleText = "Vendedores sin Zona";
                                _Pop_Popup.ContentText = "Existen " + _Ds.Tables[0].Rows.Count.ToString().Trim() + " " + _Pop_Popup.TitleText.Trim() + " Sin ver";
                                barra _Cls_Popup = new barra();
                                _Cls_Popup.cuadro1("Aviso", _Pop_Popup.ContentText);
                                _Int_24 = _Ds.Tables[0].Rows.Count;
                            }
                            break;
                        //---------------------TABS N�MERO 24
                        //---------------------TABS N�MERO 25
                        case 25:
                            _Str_Cadena = "Select * from TZONAVENTA where ccompany='" + _Str_Compa�ia + "' and cdelete='0' AND NOT EXISTS(SELECT * FROM  TRUTAVISITAM WHERE (cdelete='0') AND (TRUTAVISITAM.ccompany =TZONAVENTA.ccompany) AND (TRUTAVISITAM.c_zona = TZONAVENTA.c_zona))";
                            _Ds = _Mtd_DataSets(_Str_Cadena);
                            if (_Ds.Tables[0].Rows.Count > _Int_25)
                            {
                                _Pop_Popup.TitleText = "Zonas sin Ruta";
                                _Pop_Popup.ContentText = "Existen " + _Ds.Tables[0].Rows.Count.ToString().Trim() + " " + _Pop_Popup.TitleText.Trim() + " Sin ver";
                                barra _Cls_Popup = new barra();
                                _Cls_Popup.cuadro1("Aviso", _Pop_Popup.ContentText);
                                _Int_25 = _Ds.Tables[0].Rows.Count;
                            }
                            break;
                        //---------------------TABS N�MERO 25
                        //---------------------TABS N�MERO 26
                        case 26:
                            _Str_Cadena = "Select * from VST_TABCOUNTEVALUACION where cgroupcomp='" + _Str_GrupoComp + "'";
                            _Ds = _Mtd_DataSets(_Str_Cadena);
                            if (_Ds.Tables[0].Rows.Count > _Int_26)
                            {
                                _Pop_Popup.TitleText = "Evaluaciones por Imprimir";
                                _Pop_Popup.ContentText = "Existen " + _Ds.Tables[0].Rows.Count.ToString().Trim() + " " + _Pop_Popup.TitleText.Trim() + " Sin ver";
                                barra _Cls_Popup = new barra();
                                _Cls_Popup.cuadro1("Aviso", _Pop_Popup.ContentText);
                                _Int_26 = _Ds.Tables[0].Rows.Count;
                            }
                            break;
                        //---------------------TABS N�MERO 26
                        //---------------------TABS N�MERO 27
                        case 27:
                            _Str_Cadena = "select * from TCOMPROBANRETC WHERE ccompany='" + _Str_Compa�ia + "' AND cimpreso=0 AND canulado=0";
                            _Ds = _Mtd_DataSets(_Str_Cadena);
                            if (_Ds.Tables[0].Rows.Count > _Int_27)
                            {
                                _Pop_Popup.TitleText = "RETENCIONES DE IMPUESTO";
                                _Pop_Popup.ContentText = "Existen " + _Ds.Tables[0].Rows.Count.ToString().Trim() + " " + _Pop_Popup.TitleText.Trim() + " Sin ver";
                                barra _Cls_Popup = new barra();
                                _Cls_Popup.cuadro1("Aviso", _Pop_Popup.ContentText);
                                _Int_27 = _Ds.Tables[0].Rows.Count;
                            }
                            break;
                        //---------------------TABS N�MERO 27
                        //---------------------TABS N�MERO 28
                        case 28:
                            _Str_Cadena = "Select * from TPROVEEDOR where (cdelete='0' and casignado='0' and cglobal<>'1')";
                            _Ds = _Mtd_DataSets(_Str_Cadena);
                            if (_Ds.Tables[0].Rows.Count > _Int_28)
                            {
                                _Pop_Popup.TitleText = "PROVEEDORES PENDIENTES";
                                _Pop_Popup.ContentText = "Existen " + _Ds.Tables[0].Rows.Count.ToString().Trim() + " " + _Pop_Popup.TitleText.Trim() + " Sin ver";
                                barra _Cls_Popup = new barra();
                                _Cls_Popup.cuadro1("Aviso", _Pop_Popup.ContentText);
                                _Int_28 = _Ds.Tables[0].Rows.Count;
                            }
                            break;
                        //---------------------TABS N�MERO 28
                        //---------------------TABS N�MERO 29
                        case 29:
                            _Str_Cadena = "Select * from TINVFISICOM where ccompany='" + _Str_Compa�ia + "' and cimpreso='1' and cimpvertaremit='1' and ciniciado='0'";
                            _Ds = _Mtd_DataSets(_Str_Cadena);
                            if (_Ds.Tables[0].Rows.Count > _Int_29)
                            {
                                _Pop_Popup.TitleText = "CONTEO POR INICIAR";
                                _Pop_Popup.ContentText = "Existen " + _Ds.Tables[0].Rows.Count.ToString().Trim() + " " + _Pop_Popup.TitleText.Trim() + " Sin ver";
                                barra _Cls_Popup = new barra();
                                _Cls_Popup.cuadro1("Aviso", _Pop_Popup.ContentText);
                                _Int_29 = _Ds.Tables[0].Rows.Count;
                            }
                            break;
                        //---------------------TABS N�MERO 29
                        //---------------------TABS N�MERO 30
                        case 30:
                            _Str_Cadena = "select * from TCOMPROBANISLRC WHERE ccompany='" + _Str_Compa�ia + "' AND cimpreso=0 AND canulado=0";
                            _Ds = _Mtd_DataSets(_Str_Cadena);
                            if (_Ds.Tables[0].Rows.Count > _Int_30)
                            {
                                _Pop_Popup.TitleText = "RETENCIONES DE ISLR";
                                _Pop_Popup.ContentText = "Existen " + _Ds.Tables[0].Rows.Count.ToString().Trim() + " " + _Pop_Popup.TitleText.Trim() + " Sin ver";
                                barra _Cls_Popup = new barra();
                                _Cls_Popup.cuadro1("Aviso", _Pop_Popup.ContentText);
                                _Int_30 = _Ds.Tables[0].Rows.Count;
                            }
                            break;
                        //---------------------TABS N�MERO 30
                        //---------------------TABS N�MERO 31
                        case 31:
                            _Str_Cadena = "Select * from VST_NOTAENTREGM where ccompany='" + _Str_Compa�ia+ "' and cgroupcomp=" +_Str_GrupoComp+ " and cdelete='0' and cimpresa='0'";
                            _Ds = _Mtd_DataSets(_Str_Cadena);
                            if (_Ds.Tables[0].Rows.Count > _Int_31)
                            {
                                _Pop_Popup.TitleText = "N.E. por Imprimir";
                                _Pop_Popup.ContentText = "Existen " + _Ds.Tables[0].Rows.Count.ToString().Trim() + " " + _Pop_Popup.TitleText.Trim() + " Sin ver";
                                barra _Cls_Popup = new barra();
                                _Cls_Popup.cuadro1("Aviso", _Pop_Popup.ContentText);
                                _Int_31 = _Ds.Tables[0].Rows.Count;
                            }
                            break;
                        //---------------------TABS N�MERO 31
                        //---------------------TABS N�MERO 32
                        case 32:
                        _Str_Cadena = "select * from VST_EMICHEQTRANSM WHERE cgroupcomp='" + _Str_GrupoComp + "' AND ccompany='" + _Str_Compa�ia + "' and cfusersolicitante=1 AND cfuserfirmante1=1 AND cfuseraprobador=1 AND centregado=0 AND cimpimiocheq=1";
                        _Ds = _Mtd_DataSets(_Str_Cadena);
                        if (_Ds.Tables[0].Rows.Count > _Int_32)
                        {
                            _Pop_Popup.TitleText = "Cheques por entregar";
                            _Pop_Popup.ContentText = "Existen " + _Ds.Tables[0].Rows.Count.ToString().Trim() + " " + _Pop_Popup.TitleText.Trim() + " Sin ver";
                            barra _Cls_Popup = new barra();
                            _Cls_Popup.cuadro1("Aviso", _Pop_Popup.ContentText);
                            _Int_32 = _Ds.Tables[0].Rows.Count;
                        }
                        break;
                        //---------------------TABS N�MERO 32
                        //---------------------TABS N�MERO 33
                        case 33:
                            if (new CLASES._Cls_Varios_Metodos(true)._Mtd_ObtenerUsuarioFirma(_Str_Usuario) == "1")
                            {
                                if (new CLASES._Cls_Varios_Metodos(true)._Mtd_UsuarioProceso(_Str_Usuario, "F_ENTRASALIDA_AJUSTE"))
                                {
                                    _Str_Cadena = "Select * from TAJUSENTC where ccompany='" + _Str_Compa�ia + "' and cdelete='0' and cejecutada='0'";
                                    _Ds = _Mtd_DataSets(_Str_Cadena);
                                    if (_Ds.Tables[0].Rows.Count > _Int_33)
                                    {
                                        _Pop_Popup.TitleText = "AJUSTE DE ENT. POR APROBAR";
                                        _Pop_Popup.ContentText = "Existen " + _Ds.Tables[0].Rows.Count.ToString().Trim() + " " + _Pop_Popup.TitleText.Trim() + " Sin ver";
                                        barra _Cls_Popup = new barra();
                                        _Cls_Popup.cuadro1("Aviso", _Pop_Popup.ContentText);
                                        _Int_33 = _Ds.Tables[0].Rows.Count;
                                    }
                                }
                            }
                            break;
                        //---------------------TABS N�MERO 33
                        //---------------------TABS N�MERO 34
                        case 34:
                            if (new CLASES._Cls_Varios_Metodos(true)._Mtd_ObtenerUsuarioFirma(_Str_Usuario) == "1")
                            {
                                if (new CLASES._Cls_Varios_Metodos(true)._Mtd_UsuarioProceso(_Str_Usuario, "F_ENTRASALIDA_AJUSTE"))
                                {
                                    _Str_Cadena = "Select * from TAJUSSALC where ccompany='" + _Str_Compa�ia + "' and cdelete='0' and cejecutada='0'";
                                    _Ds = _Mtd_DataSets(_Str_Cadena);
                                    if (_Ds.Tables[0].Rows.Count > _Int_34)
                                    {
                                        _Pop_Popup.TitleText = "AJUSTE DE SAL. POR APROBAR";
                                        _Pop_Popup.ContentText = "Existen " + _Ds.Tables[0].Rows.Count.ToString().Trim() + " " + _Pop_Popup.TitleText.Trim() + " Sin ver";
                                        barra _Cls_Popup = new barra();
                                        _Cls_Popup.cuadro1("Aviso", _Pop_Popup.ContentText);
                                        _Int_34 = _Ds.Tables[0].Rows.Count;
                                    }
                                }
                            }
                            break;
                        //---------------------TABS N�MERO 34
                        //---------------------TABS N�MERO 35
                        case 35:
                            _Str_Cadena = "Select * from VST_TABPROVEEDORMERCMALESTADO  where ccompany='" + _Str_Compa�ia + "'";
                            _Ds = _Mtd_DataSets(_Str_Cadena);
                            if (_Ds.Tables[0].Rows.Count > _Int_35)
                            {
                                _Pop_Popup.TitleText = "Proveedores con Mercanc�a en mal estado";
                                _Pop_Popup.ContentText = "Existen " + _Ds.Tables[0].Rows.Count.ToString().Trim() + " " + _Pop_Popup.TitleText.Trim() + " Sin ver";
                                barra _Cls_Popup = new barra();
                                _Cls_Popup.cuadro1("Aviso", _Pop_Popup.ContentText);
                                _Int_35 = _Ds.Tables[0].Rows.Count;
                            }
                            break;
                        //---------------------TABS N�MERO 35

                    }
                    if (timer1.Interval == 1000)
                    {
                        timer1.Interval = 10000;
                    }
                }
            }
            catch { Application.Exit(); }
        }
    }
}