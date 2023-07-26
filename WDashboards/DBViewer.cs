using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WDashboards
{
    public partial class DBViewer : DevExpress.XtraEditors.XtraForm
    {
        public DBViewer()
        {
            InitializeComponent();
        }

        private void DBViewer_Load(object sender, EventArgs e)
        {

        }


        public DBViewer(string db)
        {
            try
            {
                InitializeComponent();
                //Enabled modo Relative los datos estan debajo de directorio bin
                //dashboardViewer1.DashboardSource = new System.Uri(db, System.UriKind.Absolute);
                dashboardViewer1.DashboardSource = new System.Uri(db, System.UriKind.Relative);
                dashboardViewer1.Name = "Prueba";

                dashboardViewer1.TabIndex = 0;
                dashboardViewer1.Show();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void dashboardViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}