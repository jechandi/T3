using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Security;
using System.IO;
using System.Net;


namespace T3
{
    public partial class Frm_Inicio : Form
    {
        public static bool _Bol_CrearMenu = true;
        CLASES._Cls_Varios_Metodos _Cls_VariosMetodos = new CLASES._Cls_Varios_Metodos(true);
        public Frm_Inicio()
        {
            InitializeComponent();
            _Lbl_Version.Text = CLASES._Cls_Conexion._G_Str_VersionT3;
        }
        int _Int_FormHeight;
        private void _Mtd_CargarComp()
        {
            //--------------------------------------
            _Cls_VariosMetodos._Mtd_CargarCombo(_Cmb_Companies, "Select ccompany,cname from TCOMPANY where cdelete='0'");
            string _Str_Sql = "Select ccompany from TCOMPANY where cdelete='0' AND cinidefault=1";
            DataSet _Ds = Program._MyClsCnn._mtd_conexion._Mtd_RetornarDataset(_Str_Sql);
            if (_Ds.Tables[0].Rows.Count > 0)
            {
                _Cmb_Companies.SelectedValue = _Ds.Tables[0].Rows[0][0].ToString();
            }
        }
        private void _Mtd_Color_Estandar(Control _P_Ctrl_Control)
        {
            foreach (Control _Ctrl in _P_Ctrl_Control.Controls)
            {
                if (_Ctrl.Controls.Count > 0)
                {
                    _Mtd_Color_Estandar(_Ctrl);
                }
                new CLASES._Cls_Varios_Metodos(new Control[] { _Ctrl })._Mtd_Foco();
            }
        }
        private string _Mtd_ObtenerIP()
        {
            // version antigua
            //return Dns.GetHostEntry(Dns.GetHostName()).AddressList[0].ToString().Trim();

            string _Str_Host = System.Net.Dns.GetHostName();
            string _Str_IP = "";

            for (int i = 0; i <= System.Net.Dns.GetHostEntry(_Str_Host).AddressList.Length - 1; i++)
            {
                _Str_IP = System.Net.Dns.GetHostEntry(_Str_Host).AddressList[i].ToString();

                // primero evalua si existe un IP estandar de la red SODICA
                if (_Str_IP.IndexOf("192.168.0.") != -1) return _Str_IP; // denca
                if (_Str_IP.IndexOf("192.168.1.") != -1) return _Str_IP; // conssa
                if (_Str_IP.IndexOf("192.168.2.") != -1) return _Str_IP; // mcy
                if (_Str_IP.IndexOf("192.168.3.") != -1) return _Str_IP; // mcbo
                if (_Str_IP.IndexOf("192.168.4.") != -1) return _Str_IP; // scb
                if (_Str_IP.IndexOf("192.168.5.") != -1) return _Str_IP; // pzo
                if (_Str_IP.IndexOf("192.168.6.") != -1) return _Str_IP; // bna
                if (_Str_IP.IndexOf("192.168.7.") != -1) return _Str_IP; // val
                if (_Str_IP.IndexOf("192.168.8.") != -1) return _Str_IP; // bqto
                if (_Str_IP.IndexOf("192.168.9.") != -1) return _Str_IP; // ccs
                if (_Str_IP.IndexOf("192.168.10.") != -1) return _Str_IP; // bnas
                if (_Str_IP.IndexOf("192.168.11.") != -1) return _Str_IP; // cup
                if (_Str_IP.IndexOf("192.168.12.") != -1) return _Str_IP; // clz

                if (_Str_IP.IndexOf("192.168.13.") != -1) return _Str_IP; // �futuro?
                if (_Str_IP.IndexOf("192.168.14.") != -1) return _Str_IP; // �futuro?
                if (_Str_IP.IndexOf("192.168.15.") != -1) return _Str_IP; // �futuro?
                if (_Str_IP.IndexOf("192.168.16.") != -1) return _Str_IP; // �futuro?
                if (_Str_IP.IndexOf("192.168.17.") != -1) return _Str_IP; // �futuro?
                if (_Str_IP.IndexOf("192.168.18.") != -1) return _Str_IP; // �futuro?
                if (_Str_IP.IndexOf("192.168.19.") != -1) return _Str_IP; // �futuro?
                if (_Str_IP.IndexOf("192.168.20.") != -1) return _Str_IP; // �futuro?

            }

            // si no encuentra un IP est�ndar, entonces devuelve el primero que no sea IPV6
            for (int i = 0; i <= System.Net.Dns.GetHostEntry(_Str_Host).AddressList.Length - 1; i++)
            {
                if (System.Net.Dns.GetHostEntry(_Str_Host).AddressList[i].IsIPv6LinkLocal == false)
                {
                    _Str_IP = System.Net.Dns.GetHostEntry(_Str_Host).AddressList[i].ToString();
                }
            }

            return _Str_IP;
        }

        private void _Mtd_IngresarUsuarioRestrinc(string _Str_User)
        {
            try
            {
                if (!Frm_Padre._Bol_ClaveMaestra)
                {
                    string _Str_LoginRestric = "0";
                    int _Int_LoginRestricPing = 0;
                    string _Str_SQL = "SELECT CLOGINRESTRIC,ISNULL(CLOGINRESTRICPING,0) AS CLOGINRESTRICPING FROM TCONFIGCONSSA WHERE CIDSISTEMA='T3'";
                    DataSet _Ds = Program._MyClsCnn._mtd_conexion._Mtd_RetornarDataset(_Str_SQL);
                    if (_Ds.Tables[0].Rows.Count > 0)
                    {
                        _Str_LoginRestric = _Ds.Tables[0].Rows[0][0].ToString();
                        _Int_LoginRestricPing = Convert.ToInt32(_Ds.Tables[0].Rows[0][1].ToString());
                        if (_Int_LoginRestricPing > 0)
                        {
                            Frm_Padre._Int_UserRestricPing = _Int_LoginRestricPing;
                        }
                    }
                    _Str_SQL = "SELECT CUSER FROM TUSERONLINE WHERE CIP='" + _Mtd_ObtenerIP() + "' AND CUSER='" + _Str_User + "'";
                    _Ds = Program._MyClsCnn._mtd_conexion._Mtd_RetornarDataset(_Str_SQL);
                    if (_Ds.Tables[0].Rows.Count == 0)
                    {
                        _Str_SQL = "INSERT INTO TUSERONLINE(CUSER,CIP,CFECHAHORAPING,CVERSIONT3) VALUES ('" + _Str_User + "','" + _Mtd_ObtenerIP() + "',GETDATE(),'" + T3.CLASES._Cls_Conexion._G_Str_VersionT3 + "')";
                        Program._MyClsCnn._mtd_conexion._Mtd_EjecutarSentencia(_Str_SQL);
                    }
                }
            }
            catch
            {
            }
        }
        bool _Bol_Advertencia;
        private bool _Mtd_VerificarLoginRestric(string _Str_User)
        {
            bool _Bol_Restringido = false;
            _Bol_Advertencia=false;
            try
            {
                if (!Frm_Padre._Bol_ClaveMaestra)
                {
                    string _Str_LoginRestric = "0";
                    string _Str_LoginExecp = "0";
                    string _Str_SQL = "SELECT CLOGINRESTRIC FROM TCONFIGCONSSA WHERE CIDSISTEMA='T3'";
                    DataSet _Ds = Program._MyClsCnn._mtd_conexion._Mtd_RetornarDataset(_Str_SQL);
                    if (_Ds.Tables[0].Rows.Count > 0)
                    {
                        _Str_LoginRestric = _Ds.Tables[0].Rows[0][0].ToString();
                    }
                    _Str_SQL = "SELECT cloginrestricexep FROM TUSER WHERE CUSER='" + _Str_User + "'";
                    _Ds = Program._MyClsCnn._mtd_conexion._Mtd_RetornarDataset(_Str_SQL);
                    if (_Ds.Tables[0].Rows.Count > 0)
                    {
                        _Str_LoginExecp = _Ds.Tables[0].Rows[0][0].ToString();
                    }

                    if (_Str_LoginRestric == "1")
                    {
                        if (_Str_LoginExecp == "0")
                        {
                            _Str_SQL = "SELECT CUSER FROM TUSERONLINE WHERE CUSER='" + _Str_User + "' AND CIP<>'" + _Mtd_ObtenerIP() + "'";
                            _Ds = Program._MyClsCnn._mtd_conexion._Mtd_RetornarDataset(_Str_SQL);
                            if (_Ds.Tables[0].Rows.Count > 0)
                            {
                                _Bol_Restringido = false;
                                _Bol_Advertencia = true;
                            }
                        }
                    }
                    else if (_Str_LoginRestric == "2")
                    {
                        if (_Str_LoginExecp == "0")
                        {
                            _Str_SQL = "SELECT CUSER FROM TUSERONLINE WHERE CUSER='" + _Str_User + "' AND CIP<>'" + _Mtd_ObtenerIP() + "'";
                            _Ds = Program._MyClsCnn._mtd_conexion._Mtd_RetornarDataset(_Str_SQL);
                            if (_Ds.Tables[0].Rows.Count > 0)
                            {
                                _Bol_Restringido = true;
                                _Bol_Advertencia = false;
                            }
                        }
                    }
                    if (!_Bol_Restringido)
                    {
                        _Mtd_IngresarUsuarioRestrinc(_Str_User);
                    }
                }
            }
            catch
            {
            }
            return _Bol_Restringido;
        }
        private void Frm_Inicio_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            //_Cls_VariosMetodos._Mtd_Cerrar_T3_Popup("T3BUGS");
            Cursor = Cursors.Default;
            if (CLASES._Cls_Conexion._Bol_UsuarioRemoto)
            {
                _Cls_VariosMetodos._Mtd_Cerrar_T3_Popup("openvpn");
                _Cls_VariosMetodos._Mtd_Cerrar_T3_Popup("openvpn-gui-1.0.3");
                _Bt_Desconectar.Visible = true;
                this.Enabled = false;
                this.Opacity = 0.5;
                Frm_InicioParam _Frm = new Frm_InicioParam();
                if (_Frm.ShowDialog(this) == DialogResult.OK)
                {
                    this.Opacity = 1;
                    _Mtd_Iniciar();
                    Cursor = Cursors.WaitCursor;
                    if (!_Mtd_VerificarVersionT3(_Cmb_Companies.SelectedValue.ToString()))
                    {
                        _Bol_Mensaje = true;
                        Application.Exit();
                    }
                    else
                    { _Txt_User.Focus(); }
                    Cursor = Cursors.Default;
                }
                else
                { Application.Exit(); }
            }
            else
            { _Mtd_Iniciar(); }
        }
        private void _Mtd_Iniciar()
        {
            Cursor = Cursors.WaitCursor;
            Program._Dat_Tablas = new T3.DataContext._Dat_CntxTablasDataContext(Program._MyClsCnn._mtd_conexion._g_Str_Stringconex);
            Program._Dat_Vistas = new T3.DataContext._Dat_CntxVistasDataContext(Program._MyClsCnn._mtd_conexion._g_Str_Stringconex);
            _Mtd_Color_Estandar(this);
            new CLASES._Cls_Varios_Metodos(true)._Mtd_Inyeccion_Sql(this);
            new CLASES._Cls_Varios_Metodos(true)._Mtd_Cerrar_T3_Popup("T3_Popup");
            _Mtd_CargarComp();
            _Int_FormHeight = this.Height;
            _Txt_Clave.GotFocus += new EventHandler(_Txt_Clave_GotFocus);
            Cursor = Cursors.Default;
            this.Enabled = true;
        }
        void _Txt_Clave_GotFocus(object sender, EventArgs e)
        {
            bool _Bol_Acceso = true;
            if (_Mtd_MensajeVendedor(_Txt_User.Text.Trim(), _Cmb_Companies.SelectedValue.ToString()))
            { MessageBox.Show("Usuario sin acceso otorgado,", "Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); _Bol_Acceso = false; }
            if (_Bol_Acceso)
            {
                string _Str_Sql = "Select  TUSERCOMP.cuser, TUSERCOMP.ccompany, TUSER.cpassw, TUSER.cname, TUSER.cgroup from TUSER INNER JOIN TUSERCOMP ON TUSER.cuser = TUSERCOMP.cuser where TUSERCOMP.cuser='" + _Txt_User.Text.Trim() + "' and TUSERCOMP.ccompany='" + _Cmb_Companies.SelectedValue.ToString() + "'";
                DataSet _Ds = Program._MyClsCnn._mtd_conexion._Mtd_RetornarDataset(_Str_Sql);
                if (_Ds.Tables[0].Rows.Count > 0)
                {
                    if (Convert.ToString(_Ds.Tables[0].Rows[0]["cgroup"]).Trim().Length > 0)
                    {
                        _Str_Sql = "SELECT cgroup FROM TGROUP WHERE cgroup='" + Convert.ToString(_Ds.Tables[0].Rows[0]["cgroup"]).Trim() + "' AND cdelete='0'";
                        if (Program._MyClsCnn._mtd_conexion._Mtd_RetornarDataset(_Str_Sql).Tables[0].Rows.Count > 0)
                        {
                            _Txt_User.Tag = Convert.ToString(_Ds.Tables[0].Rows[0][3]);
                        }
                        else
                        {
                            this.Activated -= new EventHandler(Frm_Inicio_Activated);
                            _Txt_User.Select(0, _Txt_User.Text.Length);
                            _Txt_User.Focus();
                            MessageBox.Show("Usuario no registrado", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            this.Activated += new EventHandler(Frm_Inicio_Activated);
                        }
                    }
                    else
                    {
                        this.Activated -= new EventHandler(Frm_Inicio_Activated);
                        _Txt_User.Select(0, _Txt_User.Text.Length);
                        _Txt_User.Focus();
                        MessageBox.Show("Usuario no registrado", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        this.Activated += new EventHandler(Frm_Inicio_Activated);
                    }
                }
                else
                {
                    this.Activated -= new EventHandler(Frm_Inicio_Activated);
                    _Txt_User.Select(0, _Txt_User.Text.Length);
                    _Txt_User.Focus();
                    MessageBox.Show("Usuario no registrado", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.Activated += new EventHandler(Frm_Inicio_Activated);
                }
            }
        }
        private void _Mtd_Ini()
        {
            _Txt_User.Text = "";
            _Txt_Clave.Text = "";
            _Txt_PwdUsuNew.Text = "";
            _Txt_PwdUsuNewA.Text = "";
            _Txt_PwdUsuNew.Enabled = false;
            _Txt_PwdUsuNewA.Enabled = false;
            _Bt_OkA.Enabled = false;
            _Txt_User.Enabled = false;
            _Txt_Clave.Enabled = false;
            _Bt_Ok.Enabled = false;
            _Cmb_Companies.Enabled = true;
        }
        private void _Bt_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private string _Mtd_RetornarClaveMaestra()
        {
            string _Str_Cadena = "SELECT cclavemaestra FROM TCONFIGCONSSA WHERE cidsistema='T3'";
            DataSet _Ds = Program._MyClsCnn._mtd_conexion._Mtd_RetornarDataset(_Str_Cadena);
            if (_Ds.Tables[0].Rows.Count > 0)
            {
                return _Ds.Tables[0].Rows[0][0].ToString();
            }
            return "";
        }
        private bool _Mtd_VerificarClave(string _P_Str_Clave)
        {
            string _Str_Sql = "Select TUSER.cpassw from TUSER INNER JOIN TUSERCOMP ON TUSER.cuser = TUSERCOMP.cuser where TUSERCOMP.cuser='" + _Txt_User.Text.Trim() + "' and TUSERCOMP.ccompany='" + _Cmb_Companies.SelectedValue.ToString() + "'";
            DataSet _Ds = Program._MyClsCnn._mtd_conexion._Mtd_RetornarDataset(_Str_Sql);
            if (_Ds.Tables[0].Rows.Count > 0)
            {
                if (_P_Str_Clave == _Mtd_RetornarClaveMaestra())
                { Frm_Padre._Bol_ClaveMaestra = true; return true; }
                else
                {
                    string _Str_cod = _Mtd_ConvertToHash(_Txt_Clave.Text);
                    if (_Str_cod == _Ds.Tables[0].Rows[0][0].ToString().Trim())
                    { return true; }
                }
            }
            return false;     
        }
        private string _Mtd_OptenerDireccActT3(string _P_Str_Company)
        {
            string _Str_Cadena = "SELECT c_direccion_Act FROM TCOMPANY WHERE ccompany='" + _P_Str_Company + "'";
            DataSet _Ds = Program._MyClsCnn._mtd_conexion._Mtd_RetornarDataset(_Str_Cadena);
            return _Ds.Tables[0].Rows[0][0].ToString().Trim().ToUpper();
        }
        private string _Mtd_OptenerVersionT3(string _P_Str_Company)
        {
            string _Str_Cadena = "SELECT cversiont3 FROM TCOMPANY WHERE ccompany='" + _P_Str_Company + "'";
            DataSet _Ds = Program._MyClsCnn._mtd_conexion._Mtd_RetornarDataset(_Str_Cadena);
            return _Ds.Tables[0].Rows[0][0].ToString().Trim().ToUpper();
        }
        public bool _Mtd_IsNumeric(object Expression)
        {
            bool isNum;
            double retNum;
            isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }
        private int _Mtd_ConvertNumeric(string _P_Str_Cadena)
        {
            string _Str_Numero = "";
            for (int _Int_I = 0; _Int_I < _P_Str_Cadena.Length; _Int_I++)
            {
                if (_Mtd_IsNumeric(_P_Str_Cadena.Substring(_Int_I, 1)))
                { _Str_Numero += _P_Str_Cadena.Substring(_Int_I, 1); }
            }
            return Convert.ToInt32(_Str_Numero);
        }
        string _Str_Version = "";
        private bool _Mtd_VerificarVersionT3(string _P_Str_Company)
        {
            _Str_Version = _Mtd_OptenerVersionT3(_P_Str_Company);
            int _Int_VersionActual = _Mtd_ConvertNumeric(_Lbl_Version.Text.Trim());
            int _Int_VersionSistema = _Mtd_ConvertNumeric(_Str_Version);
            if (!CLASES._Cls_Conexion._Bol_Rdp || CLASES._Cls_Conexion._Int_RemotoId == 2)
            {
                if (_Int_VersionActual != _Int_VersionSistema)
                { return false; }
                return true;
            }
            else
            {
                return true;
            }
        }
        private bool _Mtd_PausaCambios(string _P_Str_Company)
        {
            string _Str_Cadena = "SELECT cpausacambio FROM TCOMPANY WHERE ccompany='" + _P_Str_Company + "' AND cpausacambio='1'";
            return Program._MyClsCnn._mtd_conexion._Mtd_RetornarDataset(_Str_Cadena).Tables[0].Rows.Count > 0;
        }
        clslibraryconssa._Cls_Formato _G_Cls_Formato = new clslibraryconssa._Cls_Formato("es-VE");
        private void _Bt_Ok_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            this.Enabled = false;
            if (_Mtd_PausaCambios(Convert.ToString(_Cmb_Companies.SelectedValue).Trim()))
            {
                MessageBox.Show("En estos momentos se est�n realizando cambios en el sistema. Por favor intente mas tarde.", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            else
            {
                Frm_Padre._Bol_ClaveMaestra = false;
                if (_Mtd_VerificarClave(_Txt_Clave.Text.Trim()))
                {
                    string _Str_Cadena = "SELECT cgroup from TUSER WHERE cuser= '" + _Txt_User.Text.Trim() + "' and cdelete='0' ";
                    System.Data.DataSet _DsD = Program._MyClsCnn._mtd_conexion._Mtd_RetornarDataset(_Str_Cadena);
                    if (_DsD.Tables[0].Rows.Count > 0)
                    {
                        if (_Mtd_UsuarioNoTieneClaveReseteada(_Txt_User.Text.Trim()))
                        {
                            if (_Mtd_UsuarioNoEstaInactivado(_Txt_User.Text.Trim()))
                            {
                                _Str_Cadena = _DsD.Tables[0].Rows[0][0].ToString();
                                string _Str_GrupoComp = "";
                                ////________________________________
                                //string _Str_Ruta = Application.StartupPath + @"\T3BUGS.exe";
                                //_Str_GrupoComp = "SELECT cgroupcomp FROM TGROUPCOMPANYD where ccompany='" + _Cmb_Companies.SelectedValue.ToString() + "'";
                                //if (Program._MyClsCnn._mtd_conexion._Mtd_RetornarDataset(_Str_GrupoComp).Tables[0].Rows.Count > 0)
                                //{
                                //    _Str_GrupoComp = Program._MyClsCnn._mtd_conexion._Mtd_RetornarDataset(_Str_GrupoComp).Tables[0].Rows[0][0].ToString();
                                //    string _Str_Argumentos = _Str_GrupoComp.Trim() + "," + _Cmb_Companies.SelectedValue.ToString().Trim() + "," + _Txt_User.Text.Trim() + "," + _Lbl_Version.Text.Trim().Replace(" ", "_") + "," + CLASES._Cls_Conexion._Int_Sucursal + "," + Convert.ToInt32(CLASES._Cls_Conexion._Bol_UsuarioRemoto) + "," + Convert.ToInt32(CLASES._Cls_Conexion._Bol_ConexionRemota);
                                //    string[] _Stradssd = _Str_Argumentos.Split(',');
                                //    System.Diagnostics.Process _System_Proceso = System.Diagnostics.Process.Start(_Str_Ruta, _Str_Argumentos);
                                //}
                                ////________________________________
                                Frm_Padre._Str_Comp = _Cmb_Companies.SelectedValue.ToString();
                                Frm_Padre._Str_Use = _Txt_User.Text.Trim();
                                Frm_Padre._Str_GroupComp = _Str_GrupoComp;
                                //if (Clases._Cls_ProcesosCont._Mtd_ContableMes(_G_Cls_Formato._Mtd_fecha(CLASES._Cls_Varios_Metodos._Mtd_SQLGetDate())).Trim() == "0" | Clases._Cls_ProcesosCont._Mtd_ContableMes(_G_Cls_Formato._Mtd_fecha(CLASES._Cls_Varios_Metodos._Mtd_SQLGetDate())).Trim().Length == 0 | Clases._Cls_ProcesosCont._Mtd_ContableAno(_G_Cls_Formato._Mtd_fecha(CLASES._Cls_Varios_Metodos._Mtd_SQLGetDate())).Trim() == "0" | Clases._Cls_ProcesosCont._Mtd_ContableAno(_G_Cls_Formato._Mtd_fecha(CLASES._Cls_Varios_Metodos._Mtd_SQLGetDate())).Trim().Length == 0)
                                if (false)
                                {
                                    //MessageBox.Show("Existe un problema con el calendario de cierre, por lo tanto no podr� trabajar en el sistema, por favor inf�rmelo a la corporativa.", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    //Application.Exit();
                                }
                                else
                                {
                                    if (!_Mtd_VerificarLoginRestric(_Txt_User.Text.Trim()))
                                    {
                                        if (_Bol_Advertencia)
                                        {
                                            string _Str_Mensaje = "Se ha detectado que el USUARIO y la CONTRASE�A que usted acaba de ingresar est�n siendo utilizados en dos o m�s equipos al mismo tiempo. En un futuro cercano T3 no le permitir� ingresar de esta manera, por lo que le recomendamos lo siguiente: \n\n*Si usted es un usuario registrado del sistema, solicite a su supervisor un reseteo de clave. No comparta su clave con ning�n otro usuario. \n*Si usted a�n no est� registrado en el sistema, solicite a su supervisor un USUARIO y CONTRASE�A propios. \nRecuerde que no debe compartir su contrase�a con ning�n otro usuario. Si lo hace, entonces usted est� afectando negativamente los procesos.";
                                            MessageBox.Show(_Str_Mensaje, "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                        //Cursor = Cursors.WaitCursor;
                                        Frm_Padre _Frm = new Frm_Padre(_Cmb_Companies.SelectedValue.ToString(), _Txt_User.Text.Trim(), this);
                                        //Cursor = Cursors.Default;
                                        this.Hide();
                                        this.ShowInTaskbar = false;
                                        _Frm.Show();
                                    }
                                    else
                                    {
                                        string _Str_Mensaje = "Se ha detectado que el USUARIO y la CONTRASE�A que usted acaba de ingresar est�n siendo utilizados en dos o m�s equipos al mismo tiempo.\n\nEn caso de que el sistema haya sido cerrado de manera abrupta en su equipo, por favor espere 5 minutos e intente de nuevo.";
                                        MessageBox.Show(_Str_Mensaje, "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    }
                                }
                            }
                            else
                            {
                                this.Activated -= new EventHandler(Frm_Inicio_Activated);
                                MessageBox.Show("Disculpe, este usuario ha sido inhabilitado. Por favor contacto a su supervisor.", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                _Txt_Clave.Select(0, _Txt_Clave.Text.Length);
                                _Txt_Clave.Focus();
                                this.Activated += new EventHandler(Frm_Inicio_Activated);
                            }
                        }
                        else
                        {
                            _Cmb_Companies.Enabled = false;
                            _Txt_User.Enabled = false;
                            _Txt_Clave.Enabled = false;
                            _Txt_Clave.Text = "";
                            _Bt_Ok.Enabled = false;
                            _Bt_OkA.Enabled = false;
                            this.Height = _Int_FormHeight + _Grb_IniAux.Height;
                            _Txt_PwdUsuNew.Enabled = true;
                            _Txt_PwdUsuNewA.Enabled = true;
                            _Txt_PwdUsuNew.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El usuario ha sido eliminado.", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    this.Activated -= new EventHandler(Frm_Inicio_Activated);
                    MessageBox.Show("La clave es incorrecta", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _Txt_Clave.Select(0, _Txt_Clave.Text.Length);
                    _Txt_Clave.Focus();
                    this.Activated += new EventHandler(Frm_Inicio_Activated);
                }
            }
            this.Enabled = true;
            Cursor = Cursors.Default;
        }
        private void _Mtd_HabilitarGuardarClave()
        {
            if (_Mtd_ConvertToHash(_Txt_PwdUsuNew.Text.Trim()) == _Mtd_ConvertToHash(_Txt_PwdUsuNewA.Text.Trim()) & _Txt_PwdUsuNew.Text.Trim().Length > 0 & _Txt_PwdUsuNewA.Text.Trim().Length > 0)
            { _Bt_OkA.Enabled = true; }
            else
            { _Bt_OkA.Enabled = false; }
        }
        private void _Txt_PwdUsuNew_TextChanged(object sender, EventArgs e)
        {
            _Mtd_HabilitarGuardarClave();
        }

        private void _Txt_PwdUsuNewA_TextChanged(object sender, EventArgs e)
        {
            _Mtd_HabilitarGuardarClave();
        }
        private void _Bt_SalirA_Click(object sender, EventArgs e)
        {
            _Mtd_Ini();
            if (_Cmb_Companies.SelectedIndex > 0)
            {
                _Txt_User.Enabled = true;
                _Txt_User.Focus();
            }
            this.Height = _Int_FormHeight;
        }
        public static Byte[] ConvertStringToByteArray(String s)
        {
            return (new UnicodeEncoding()).GetBytes(s);
        }

        private bool _Mtd_EsIgualClaveAnterior(string _P_Str_Login, string _Str_NuevoPasswordEncriptado)
        {
            string _Str_Cadena = "Select cold_cpassw from TUSERPASSW where cuser='" + _P_Str_Login + "' and cold_cpassw='" + _Str_NuevoPasswordEncriptado + "'";
            DataSet _Ds = Program._MyClsCnn._mtd_conexion._Mtd_RetornarDataset(_Str_Cadena);
            return _Ds.Tables[0].Rows.Count > 0;
        }

        private void _Bt_OkA_Click(object sender, EventArgs e)
        {
            string _Str_NuevoPassword = _Txt_PwdUsuNew.Text.Trim();
            string _Str_NuevoPasswordEncriptado = _Mtd_ConvertToHash(_Str_NuevoPassword);
            string _Str_Login = _Txt_User.Text.Trim();

            if (_Str_NuevoPassword.Length >= 4)
            {
                if (_Mtd_NuevoPasswordEsDiferenteDeProvisional(_Str_Login, _Str_NuevoPassword))
                {
                    if (_Mtd_EsIgualClaveAnterior(_Str_Login, _Str_NuevoPasswordEncriptado))
                    {
                        MessageBox.Show("Su nueva clave no puede ser la misma que clave anterior. Por favor verifique.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _Txt_PwdUsuNewA.Text = "";
                        _Txt_PwdUsuNew.SelectAll();
                        _Txt_PwdUsuNew.Focus();
                        return;
                    }
                    try
                    {
                        string _Str_SQL = "";
                        _Str_SQL += "UPDATE TUSER" + " ";
                        _Str_SQL += "SET c_reseteo_clave = 0, cpassw = '" + _Str_NuevoPasswordEncriptado + "', cuserupd = '" + _Str_Login + "', cdateupd = GETDATE() ";
                        _Str_SQL += "WHERE cuser = '" + _Str_Login + "'";
                        Program._MyClsCnn._mtd_conexion._Mtd_EjecutarSentencia(_Str_SQL);
                        //-----------------------
                        _Str_SQL = "SELECT cuser FROM TUSERPASSW WHERE cuser='" + _Str_Login + "'";
                        DataSet _Ds = Program._MyClsCnn._mtd_conexion._Mtd_RetornarDataset(_Str_SQL);
                        if (_Ds.Tables[0].Rows.Count > 0)
                            _Str_SQL = "UPDATE TUSERPASSW SET cold_cpassw='" + _Str_NuevoPasswordEncriptado + "' WHERE cuser='" + _Str_Login + "'";
                        else
                            _Str_SQL = "INSERT INTO TUSERPASSW (cuser,cold_cpassw) SELECT '" + _Str_Login + "','" + _Str_NuevoPasswordEncriptado + "'";
                        Program._MyClsCnn._mtd_conexion._Mtd_EjecutarSentencia(_Str_SQL);
                        //-----------------------
                        MessageBox.Show("La nueva clave ha sido establecida satisfactoriamente.", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Height = _Int_FormHeight;
                        _Cmb_Companies.Enabled = true;
                        _Txt_User.Enabled = true;
                        _Txt_Clave.Enabled = true;
                        _Txt_Clave.Focus();
                    }
                    catch
                    {
                        MessageBox.Show("Ha ocurrido un error. Por favor contacte al desarrollador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Su nueva clave no puede ser la misma que la provisional. Por favor verifique.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _Txt_PwdUsuNewA.Text = "";
                    _Txt_PwdUsuNew.SelectAll();
                    _Txt_PwdUsuNew.Focus();
                }
            }
            else
            {
                MessageBox.Show("Su nueva clave no puede tener menos de cuatro caracteres. Verifique.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _Txt_PwdUsuNewA.Text = "";
                _Txt_PwdUsuNew.SelectAll();
                _Txt_PwdUsuNew.Focus();
            }
        }
        bool _Bol_Mensaje = false;
        private void Frm_Inicio_Activated(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            _Bol_Mensaje = false;
            if (_Cmb_Companies.SelectedIndex > 0 & _Cmb_Companies.Enabled)
            {
                _Mtd_Ini();
                _Txt_User.Enabled = true;
                _Txt_User.Focus();
                Cursor = Cursors.WaitCursor;
                if (!_Mtd_VerificarVersionT3(_Cmb_Companies.SelectedValue.ToString()))
                {
                    _Bol_Mensaje = true;
                    Application.Exit();
                }
                Cursor = Cursors.Default;
            }
        }
        private bool _Mtd_MensajeVendedor(string _P_Str_User,string _P_Str_Company)
        {
            string _Str_Sql = "Select TUSER.cvendedor from TUSER INNER JOIN TUSERCOMP ON TUSER.cuser = TUSERCOMP.cuser where TUSERCOMP.cuser='" + _P_Str_User + "' and TUSERCOMP.ccompany='" + _P_Str_Company + "'";
            DataSet _Ds = Program._MyClsCnn._mtd_conexion._Mtd_RetornarDataset(_Str_Sql);
            if (_Ds.Tables[0].Rows.Count > 0)
            {
                if (Convert.ToString(_Ds.Tables[0].Rows[0]["cvendedor"]).Trim().Length > 0)
                {
                    _Str_Sql = "SELECT cgroup FROM TUSERGROUP WHERE ccompany='" + _P_Str_Company + "' AND cuser='" + _P_Str_User + "'";
                    if (!Program._MyClsCnn._mtd_conexion._Mtd_ExistenRegistros(_Str_Sql))
                    { return true; }
                }
            }
            return false;
        }
        private void _Txt_User_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (_Txt_User.Text.Trim().Length > 0)
                {
                    bool _Bol_Acceso = true;
                    if (_Mtd_MensajeVendedor(_Txt_User.Text.Trim(), _Cmb_Companies.SelectedValue.ToString()))
                    { MessageBox.Show("Usuario sin acceso otorgado,", "Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); _Bol_Acceso = false; }
                    if (_Bol_Acceso)
                    {
                        string _Str_Sql = "Select  TUSERCOMP.cuser, TUSERCOMP.ccompany, TUSER.cpassw, TUSER.cname, TUSER.cgroup from TUSER INNER JOIN TUSERCOMP ON TUSER.cuser = TUSERCOMP.cuser where TUSERCOMP.cuser='" + _Txt_User.Text.Trim() + "' and TUSERCOMP.ccompany='" + _Cmb_Companies.SelectedValue.ToString() + "'";
                        DataSet _Ds = Program._MyClsCnn._mtd_conexion._Mtd_RetornarDataset(_Str_Sql);
                        if (_Ds.Tables[0].Rows.Count > 0)
                        {
                            if (Convert.ToString(_Ds.Tables[0].Rows[0]["cgroup"]).Trim().Length > 0)
                            {
                                _Str_Sql = "SELECT cgroup FROM TGROUP WHERE cgroup='" + Convert.ToString(_Ds.Tables[0].Rows[0]["cgroup"]).Trim() + "' AND cdelete='0'";
                                if (Program._MyClsCnn._mtd_conexion._Mtd_RetornarDataset(_Str_Sql).Tables[0].Rows.Count > 0)
                                {
                                    _Txt_User.Tag = Convert.ToString(_Ds.Tables[0].Rows[0][3]);
                                    _Txt_Clave.Enabled = true;
                                    _Txt_Clave.Focus();
                                }
                                else
                                {
                                    this.Activated -= new EventHandler(Frm_Inicio_Activated);
                                    MessageBox.Show("Usuario no registrado", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    this.Activated += new EventHandler(Frm_Inicio_Activated);
                                }
                            }
                            else
                            {
                                this.Activated -= new EventHandler(Frm_Inicio_Activated);
                                MessageBox.Show("Usuario no registrado", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                this.Activated += new EventHandler(Frm_Inicio_Activated);
                            }
                        }
                        else
                        {
                            this.Activated -= new EventHandler(Frm_Inicio_Activated);
                            MessageBox.Show("Usuario no registrado", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            this.Activated += new EventHandler(Frm_Inicio_Activated);
                        }
                    }
                }
            }
        }
        
        private void Frm_Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            string _Str_DireccionActT3 = "";
            
            Cursor = Cursors.WaitCursor;
            //_Cls_VariosMetodos._Mtd_Cerrar_T3_Popup("T3BUGS");
            _Cls_VariosMetodos._Mtd_Cerrar_T3_Popup("openvpn");
            _Cls_VariosMetodos._Mtd_Cerrar_T3_Popup("openvpn-gui-1.0.3");
            Cursor = Cursors.Default;

            if (_Bol_Mensaje)
            {
                if (CLASES._Cls_Conexion._Bol_ConexionRemota) // si T3Win est� configurado como 'remoto'...
                {
                    // intenta descargar de un repositorio local
                    _Str_DireccionActT3 = _Mtd_ObtenerDireccionRepositorioLocalActualizaciones();

                    if (_Str_DireccionActT3 != "") // identific� que est� en una red con repositorio, entonces intenta obtener la actualizaci�n..
                    {
                        MessageBox.Show("Se actualizar� localmente a la versi�n " + _Str_Version + " para ingresar al sistema.", "Requerimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        try
                        {
                            System.Diagnostics.Process.Start(_Str_DireccionActT3 + @"\" + _Str_Version.Trim().Replace(" ", "") + ".exe");
                        }
                        catch
                        {
                            // descarga de la p�gina de conssa la actualizaci�n
                            this.Activated -= new EventHandler(Frm_Inicio_Activated);
                            MessageBox.Show("*Debe descargar la versi�n " + _Str_Version + " para ingresar al sistema.", "Requerimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            System.Diagnostics.Process.Start("http://www.conssa.net.ve/t3/" + _Str_Version.Trim().Replace(" ", "") + ".exe");
                        }

                    } // si no hay repositorio local, descarga de internet...
                    else
                    {
                        // descarga de la p�gina de conssa la actualizaci�n
                        this.Activated -= new EventHandler(Frm_Inicio_Activated);
                        MessageBox.Show("Debe descargar la versi�n " + _Str_Version + " para ingresar al sistema.", "Requerimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        System.Diagnostics.Process.Start("http://www.conssa.net.ve/t3/" + _Str_Version.Trim().Replace(" ", "") + ".exe");
                    }
                }
                else
                {
                    MessageBox.Show("Se va actualizar a la versi�n " + _Str_Version + " para ingresar al sistema.", "Requerimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _Str_DireccionActT3 = _Mtd_OptenerDireccActT3(_Cmb_Companies.SelectedValue.ToString());
                    try
                    {
                        System.Diagnostics.Process.Start(_Str_DireccionActT3 + @"\" + _Str_Version.Trim().Replace(" ", "") + ".exe");
                    }
                    catch
                    {
                        string _Str_Ejecutable_T3Dominio = "C://CONSSA//T3//DEBUG//t3_dominio.exe";
                        if (File.Exists(_Str_Ejecutable_T3Dominio))
                        {
                            Cursor = Cursors.WaitCursor;
                            // ejecuta el dominio
                            System.Diagnostics.Process.Start(_Str_Ejecutable_T3Dominio);

                            // pausa durante 3 segundos la ejecucion de t3
                            // para darle 'chance' a t3_dominio que conecte...
                            System.Threading.Thread.Sleep(3000);

                            // intenta nuevamente ejecutar la actualizacion
                            try
                            {
                                System.Diagnostics.Process.Start(_Str_DireccionActT3 + @"\" + _Str_Version.Trim().Replace(" ", "") + ".exe");
                                Cursor = Cursors.Default;
                            }
                            catch
                            {
                                MessageBox.Show("Lo sentimos, la versi�n que debe ser instalada (" + _Str_Version.Trim() + ") no puede ser encontrada. Por favor contacte al administrador del sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Cursor = Cursors.Default;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lo sentimos, la versi�n que debe ser instalada (" + _Str_Version.Trim() + ") no puede ser encontrada. Por favor contacte al administrador del sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
        string _Str_Company = "";
        private void _Cmb_Companies_DropDownClosed(object sender, EventArgs e)
        {
            if (_Cmb_Companies.SelectedIndex > 0)
            {
                if (_Cmb_Companies.SelectedValue.ToString().Trim() != _Str_Company)
                {
                    _Str_Company = _Cmb_Companies.SelectedValue.ToString().Trim();
                    _Txt_User.Enabled = true;
                    _Txt_User.Focus();
                }
            }
            else
            {
                _Mtd_Ini();
            }
        }
        private void _LBox_Companies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_Cmb_Companies.SelectedIndex > 0)
            {
                _Txt_User.Enabled = true;
                _Str_Company = _Cmb_Companies.SelectedValue.ToString().Trim();
            }
            else
            {
                _Mtd_Ini();
            }
        }

        private void _Cmb_Companies_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (_Cmb_Companies.SelectedIndex > 0)
                {
                    _Txt_User.Enabled = true;
                    _Txt_User.Focus();
                }
            }
        }

        private void _Txt_User_TextChanged(object sender, EventArgs e)
        {
            if (_Txt_User.Text.Trim().Length > 0)
            {
                _Txt_Clave.Text = "";
                _Txt_Clave.Enabled = true;
            }
            else
            {
                _Txt_Clave.Text = "";
                _Txt_Clave.Enabled = false;
            }
        }

        private void _Txt_Clave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (_Txt_Clave.Text.Trim().Length > 0)
                {
                    _Bt_Ok.Enabled = true;
                    _Bt_Ok.Focus();
                }
            }
        }

        private void _Txt_PwdUsuNew_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (_Txt_PwdUsuNew.Text.Trim().Length > 0)
                {
                    _Txt_PwdUsuNewA.Focus();
                }
            }
        }

        private void _Txt_PwdUsuNewA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (_Txt_PwdUsuNewA.Text.Trim().Length > 0 & _Bt_OkA.Enabled)
                {
                    _Bt_OkA.Focus();
                }
            }
        }

        private void _Txt_Clave_TextChanged(object sender, EventArgs e)
        {
            if (_Txt_Clave.Text.Trim().Length > 0)
            { _Bt_Ok.Enabled = true; }
            else
            { _Bt_Ok.Enabled = false; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private bool _Mtd_UsuarioNoTieneClaveReseteada(string _Str_Login)
        {
            try
            {
                string _Str_SQL = "SELECT cuser FROM TUSER WHERE cuser = '" + _Str_Login + "' AND c_reseteo_clave = 1";
                DataSet _Ds_DataSet = Program._MyClsCnn._mtd_conexion._Mtd_RetornarDataset(_Str_SQL);
                if (_Ds_DataSet.Tables[0].Rows.Count > 0) return false; else return true;
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error. Por favor contacte al desarrollador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }

        private bool _Mtd_UsuarioNoEstaInactivado(string _Str_Login)
        {
            try
            {
                string _Str_SQL = "SELECT cuser FROM TUSER WHERE cuser = '" + _Str_Login + "' AND clocked = 1";
                DataSet _Ds_DataSet = Program._MyClsCnn._mtd_conexion._Mtd_RetornarDataset(_Str_SQL);
                if (_Ds_DataSet.Tables[0].Rows.Count > 0) return false; else return true;
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error. Por favor contacte al desarrollador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }
        
        private bool _Mtd_NuevoPasswordEsDiferenteDeProvisional(string _Str_Login, string _Str_NuevoPassword)
        {
            string _Str_NuevoPasswordEncriptado = _Mtd_ConvertToHash(_Str_NuevoPassword);

            try
            {
                string _Str_SQL = "";
                _Str_SQL += "SELECT cpassw" + " ";
                _Str_SQL += "FROM TUSER" + " ";
                _Str_SQL += "WHERE cuser = '" + _Str_Login + "'";

                DataSet _Ds_DataSet = Program._MyClsCnn._mtd_conexion._Mtd_RetornarDataset(_Str_SQL);
                if (_Ds_DataSet.Tables[0].Rows.Count > 0)
                {
                    if (_Ds_DataSet.Tables[0].Rows[0]["cpassw"].ToString().Trim() != _Str_NuevoPasswordEncriptado) return true; else return false;
                }
                else return false;
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error. Por favor contacte al desarrollador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private string _Mtd_ConvertToHash(string _Str_Cadena)
        {
            byte[] hash = ConvertStringToByteArray(_Str_Cadena);
            byte[] valorhash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(hash);
            string _Str_cod = BitConverter.ToString(valorhash);
            return _Str_cod.Replace("-", "");
        }
        private string _Mtd_RutaBat(object _P_Ob_Conectarme)
        {
            string _Str_RutaBat = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + @"\OpenVPN\config\";
            switch (Convert.ToInt32(_P_Ob_Conectarme))
            {
                case 4:
                    _Str_RutaBat += @"04-SCB-T3\";
                    break;
                case 9:
                    _Str_RutaBat += @"09-CCS-T3\";
                    break;
                case 2:
                    _Str_RutaBat += @"02-MCY-T3\";
                    break;
                case 5:
                    _Str_RutaBat += @"05-PZO-T3\";
                    break;
                case 8:
                    _Str_RutaBat += @"08-BQTO-T3\";
                    break;
                case 10:
                    _Str_RutaBat += @"10-BNAS-T3\";
                    break;
                case 6:
                    _Str_RutaBat += @"06-BNA-T3\";
                    break;
                case 3:
                    _Str_RutaBat += @"03-MCBO-T3\";
                    break;
                case 11:
                    _Str_RutaBat += @"11-CUP-T3\";
                    break;
                case 12:
                    _Str_RutaBat += @"12-CLZ-T3\";
                    break;
            }
            return _Str_RutaBat + "Desconectar.bat";
        }
        private void _Mtd_CerrarRasDial()
        {
            try
            {
                string _Str_Ruta = _Mtd_RutaBat(CLASES._Cls_Conexion._Int_Sucursal);
                if (System.IO.File.Exists(_Str_Ruta))
                {
                    System.Diagnostics.Process _SysPro = new System.Diagnostics.Process();
                    _SysPro.StartInfo.FileName = _Str_Ruta;
                    _SysPro.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    _SysPro.Start();
                }
            }
            catch
            {
            }
        }
        private void _Bt_Desconectar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            _Bt_Cancelar.PerformClick();
            _Cls_VariosMetodos._Mtd_Cerrar_T3_Popup("openvpn");
            _Cls_VariosMetodos._Mtd_Cerrar_T3_Popup("openvpn-gui-1.0.3");
            _Mtd_CerrarRasDial();
            Cursor = Cursors.Default;
            _Bol_CrearMenu = true;
            _Cmb_Companies.DataSource = null;
            CLASES._Cls_Conexion._Bol_ConexionRemota = false;
            CLASES._Cls_Conexion._Int_Sucursal = 0;
            this.Enabled = false;
            this.Opacity = 0.5;
            Frm_InicioParam _Frm = new Frm_InicioParam();
            if (_Frm.ShowDialog(this) == DialogResult.OK)
            {
                this.Opacity = 1;
                _Mtd_Iniciar();
                Cursor = Cursors.WaitCursor;
                if (!_Mtd_VerificarVersionT3(_Cmb_Companies.SelectedValue.ToString()))
                {
                    _Bol_Mensaje = true;
                    Application.Exit();
                }
                else
                { _Txt_User.Focus(); }
                Cursor = Cursors.Default;
            }
            else
            { Application.Exit(); }
        }

        /// <summary>
        /// Devuelve una cadena de texto con la direcci�n del repositorio local de actualizaciones.
        /// Esta cadena es un valor est�tico, y no se obtiene de la base de datos, debido a que se usa en modo "remoto".
        /// La rutina se podr�a mejorar abriendo una conexion a la base de datos local (en caso de estar disponible),
        /// y verificando si localmente est� dispoible la actualizacion que solicita la BD remota.
        /// </summary>
        /// <returns></returns>
        private string _Mtd_ObtenerDireccionRepositorioLocalActualizaciones()
        {
            string _Str_IPActual = _Mtd_ObtenerIP();
            string _Str_DireccionRepositorioLocalActualizaciones = ""; // no contiene slash al final

            // identifica si est� en una red con conocida con repositorio
            if (_Str_IPActual.IndexOf("192.168.9.")  != -1) _Str_DireccionRepositorioLocalActualizaciones = @"\\192.168.9.3\conssa\_T3_COMPILADO";  // ccs
            if (_Str_IPActual.IndexOf("192.168.6.")  != -1) _Str_DireccionRepositorioLocalActualizaciones = @"\\192.168.6.3\conssa\_T3_COMPILADO";  // bna
            if (_Str_IPActual.IndexOf("192.168.5.")  != -1) _Str_DireccionRepositorioLocalActualizaciones = @"\\192.168.5.3\conssa\_T3_COMPILADO";  // pzo
            if (_Str_IPActual.IndexOf("192.168.4.")  != -1) _Str_DireccionRepositorioLocalActualizaciones = @"\\192.168.4.3\conssa\_T3_COMPILADO";  // scb
            if (_Str_IPActual.IndexOf("192.168.3.")  != -1) _Str_DireccionRepositorioLocalActualizaciones = @"\\192.168.3.3\conssa\_T3_COMPILADO";  // mcbo
            if (_Str_IPActual.IndexOf("192.168.8.")  != -1) _Str_DireccionRepositorioLocalActualizaciones = @"\\192.168.8.3\conssa\_T3_COMPILADO";  // bqto
            if (_Str_IPActual.IndexOf("192.168.10.") != -1) _Str_DireccionRepositorioLocalActualizaciones = @"\\192.168.10.3\conssa\_T3_COMPILADO"; // bnas
            if (_Str_IPActual.IndexOf("192.168.2.")  != -1) _Str_DireccionRepositorioLocalActualizaciones = @"\\192.168.2.3\conssa\_T3_COMPILADO";  // mcy
            if (_Str_IPActual.IndexOf("192.168.11.") != -1) _Str_DireccionRepositorioLocalActualizaciones = @"\\192.168.11.3\conssa\_T3_COMPILADO"; // cup
            if (_Str_IPActual.IndexOf("192.168.12.") != -1) _Str_DireccionRepositorioLocalActualizaciones = @"\\192.168.12.3\conssa\_T3_COMPILADO"; // clz
            if (_Str_IPActual.IndexOf("192.168.1.")  != -1) _Str_DireccionRepositorioLocalActualizaciones = @"\\192.168.1.5\t3_remoto";             // conssa
            if (_Str_IPActual.IndexOf("192.168.0.")  != -1) _Str_DireccionRepositorioLocalActualizaciones = @"\\192.168.0.1\publica\CONSSA\_T3_COMPILADO";  // denca
            
            return _Str_DireccionRepositorioLocalActualizaciones;
        }


    }
}