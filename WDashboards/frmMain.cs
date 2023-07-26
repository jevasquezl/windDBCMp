using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;


namespace WDashboards
{
    public partial class frmMain : XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
            //modificacion 
        }

        private void CuboComprasGP_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DBViewer fm = new DBViewer(".//DBXML//DBCuboComprasxDep.xml");
            fm.MdiParent = this;
            fm.Text = "CuboComprasGP";
            fm.Location = new Point(200, 100);
            fm.Show();

        }

        private void OrdenesCompraGP_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DBViewer fm = new DBViewer(".//DBXML//DBocCostoTotal.xml");
            fm.MdiParent = this;
            fm.Text = "OrdenesCompraGP";
            fm.Location = new Point(200, 100);
            fm.Show();

        }

        private void ComprasAutorizadas_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DBViewer fm = new DBViewer(".//DBXML//DBComprasAutorizadas.xml");
            fm.MdiParent = this;
            fm.Text = "ComprasAutorizadas";
            fm.Location = new Point(200, 100);
            fm.Show();

        }

        private void CuboComprasAutorizadas_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DBViewer fm = new DBViewer(".//DBXML//DBCuboComprasAutorizadas.xml");
            fm.MdiParent = this;
            fm.Text = "CuboComprasAutorizadas";
            fm.Location = new Point(200, 100);
            fm.Show();

        }

        private void RequermientosArticulos_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DBViewer fm = new DBViewer(".//DBXML//DBReqxArticulo.xml");
            fm.MdiParent = this;
            fm.Text = "Requermientos/Articulos";
            fm.Location = new Point(200, 100);
            fm.Show();

        }

        private void RequerimientosDependencia_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DBViewer fm = new DBViewer(".//DBXML//DBReqxDependencia.xml");
            fm.MdiParent = this;
            fm.Text = "Requermientos/Dep";
            fm.Location = new Point(200, 100);
            fm.Show();

        }

        private void PagosI_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DBViewer fm = new DBViewer(".//DBXML//DBPagos.xml");
            fm.MdiParent = this;
            fm.Text = "Pagos";
            fm.Location = new Point(200, 100);
            fm.Show();

        }

        private void PagosvsCompras_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DBViewer fm = new DBViewer(".//DBXML//DBPagosVsOC.xml");
            fm.MdiParent = this;
            fm.Text = "PagosvsCompras";
            fm.Location = new Point(200, 100);
            fm.Show();

        }

        private void CuboPagosvsCompras_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DBViewer fm = new DBViewer(".//DBXML//DBCuboPagosVsOC.xml");
            fm.MdiParent = this;
            fm.Text = "uboPagosvsCompras";
            fm.Location = new Point(200, 100);
            fm.Show();

        }

        private void RecibosPeriodo_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DBViewer fm = new DBViewer(".//DBXML//DBRecibosxPeriodos.xml");
            fm.MdiParent = this;
            fm.Text = "Recibos/Periodo";
            fm.Location = new Point(200, 100);
            fm.Show();

        }

        private void Ejecutado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DBViewer fm = new DBViewer(".//DBXML//DBEjecutado.xml");
            fm.MdiParent = this;
            fm.Text = "Ejecutado";
            fm.Location = new Point(200, 100);
            fm.Show();

        }

        private void EjecutadoPresupuestado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DBViewer fm = new DBViewer(".//DBXML//DBEjecxPresup.xml");
            fm.MdiParent = this;
            fm.Text = "Ejecutado/Presupuestado";
            fm.Location = new Point(200, 100);
            fm.Show();

        }

        private void Diseñador_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fmDashBoardDesigner fm = new fmDashBoardDesigner();
            fm.Show();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void EvaluacionPuntaje_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DBViewer fm = new DBViewer(".//DBXML//DBEvaluacionxTipoProv.xml");
            fm.MdiParent = this;
            fm.Text = "DBEvaluacion x TipoProveedor";
            fm.Location = new Point(200, 100);
            fm.Show();
        }

        private void EvaluacionTipoProveedor_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DBViewer fm = new DBViewer(".//DBXML//DBEvaluacionPuntaje.xml");
            fm.MdiParent = this;
            fm.Text = "Evaluacion Puntaje";
            fm.Location = new Point(200, 100);
            fm.Show();
        }

        private void EvaluacionNotas_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DBViewer fm = new DBViewer(".//DBXML//DBEvaluacionNotas.xml");
            fm.MdiParent = this;
            fm.Text = "Evaluacion Notas";
            fm.Location = new Point(200, 100);
            fm.Show();
        }

        private void EvalucionBase_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DBViewer fm = new DBViewer(".//DBXML//DBEvaluacionNotasBase.xml");
            fm.MdiParent = this;
            fm.Text = "Evaluacion Notas Base";
            fm.Location = new Point(200, 100);
            fm.Show();
        }
    }
}