namespace WDashboards
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.inboxItem = new DevExpress.XtraNavBar.NavBarItem();
            this.outboxItem = new DevExpress.XtraNavBar.NavBarItem();
            this.draftsItem = new DevExpress.XtraNavBar.NavBarItem();
            this.trashItem = new DevExpress.XtraNavBar.NavBarItem();
            this.calendarItem = new DevExpress.XtraNavBar.NavBarItem();
            this.tasksItem = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarImageCollectionLarge = new DevExpress.Utils.ImageCollection(this.components);
            this.navbarImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.defaultBarAndDockingController1 = new DevExpress.XtraBars.DefaultBarAndDockingController(this.components);
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.DiseñosDB = new DevExpress.XtraNavBar.NavBarGroup();
            this.Diseñador = new DevExpress.XtraNavBar.NavBarItem();
            this.EvaluacionProveedor = new DevExpress.XtraNavBar.NavBarGroup();
            this.EvaluacionPuntaje = new DevExpress.XtraNavBar.NavBarItem();
            this.EvaluacionTipoProveedor = new DevExpress.XtraNavBar.NavBarItem();
            this.EvaluacionNotas = new DevExpress.XtraNavBar.NavBarItem();
            this.EvalucionBase = new DevExpress.XtraNavBar.NavBarItem();
            this.OrdenesCompra = new DevExpress.XtraNavBar.NavBarGroup();
            this.ComprasAutorizadas = new DevExpress.XtraNavBar.NavBarItem();
            this.CuboComprasAutorizadas = new DevExpress.XtraNavBar.NavBarItem();
            this.OrdenesCompraGP = new DevExpress.XtraNavBar.NavBarItem();
            this.CuboComprasGP = new DevExpress.XtraNavBar.NavBarItem();
            this.Requerimientos = new DevExpress.XtraNavBar.NavBarGroup();
            this.RequerimientosDependencia = new DevExpress.XtraNavBar.NavBarItem();
            this.RequermientosArticulos = new DevExpress.XtraNavBar.NavBarItem();
            this.Pagos = new DevExpress.XtraNavBar.NavBarGroup();
            this.PagosI = new DevExpress.XtraNavBar.NavBarItem();
            this.PagosvsCompras = new DevExpress.XtraNavBar.NavBarItem();
            this.CuboPagosvsCompras = new DevExpress.XtraNavBar.NavBarItem();
            this.Recibos = new DevExpress.XtraNavBar.NavBarGroup();
            this.RecibosPeriodo = new DevExpress.XtraNavBar.NavBarItem();
            this.Presupuesto = new DevExpress.XtraNavBar.NavBarGroup();
            this.Ejecutado = new DevExpress.XtraNavBar.NavBarItem();
            this.EjecutadoPresupuestado = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollectionLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDockingController1.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            this.SuspendLayout();
            // 
            // inboxItem
            // 
            this.inboxItem.Name = "inboxItem";
            // 
            // outboxItem
            // 
            this.outboxItem.Name = "outboxItem";
            // 
            // draftsItem
            // 
            this.draftsItem.Caption = "Drafts";
            this.draftsItem.ImageOptions.SmallImageIndex = 2;
            this.draftsItem.Name = "draftsItem";
            // 
            // trashItem
            // 
            this.trashItem.Caption = "Trash";
            this.trashItem.ImageOptions.SmallImageIndex = 3;
            this.trashItem.Name = "trashItem";
            // 
            // calendarItem
            // 
            this.calendarItem.Caption = "Calendar";
            this.calendarItem.ImageOptions.SmallImageIndex = 4;
            this.calendarItem.Name = "calendarItem";
            // 
            // tasksItem
            // 
            this.tasksItem.Caption = "Tasks";
            this.tasksItem.ImageOptions.SmallImageIndex = 5;
            this.tasksItem.Name = "tasksItem";
            // 
            // navbarImageCollectionLarge
            // 
            this.navbarImageCollectionLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("navbarImageCollectionLarge.ImageStream")));
            this.navbarImageCollectionLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.navbarImageCollectionLarge.Images.SetKeyName(0, "Mail_16x16.png");
            this.navbarImageCollectionLarge.Images.SetKeyName(1, "Organizer_16x16.png");
            // 
            // navbarImageCollection
            // 
            this.navbarImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("navbarImageCollection.ImageStream")));
            this.navbarImageCollection.TransparentColor = System.Drawing.Color.Transparent;
            this.navbarImageCollection.Images.SetKeyName(0, "Inbox_16x16.png");
            this.navbarImageCollection.Images.SetKeyName(1, "Outbox_16x16.png");
            this.navbarImageCollection.Images.SetKeyName(2, "Drafts_16x16.png");
            this.navbarImageCollection.Images.SetKeyName(3, "Trash_16x16.png");
            this.navbarImageCollection.Images.SetKeyName(4, "Calendar_16x16.png");
            this.navbarImageCollection.Images.SetKeyName(5, "Tasks_16x16.png");
            // 
            // defaultBarAndDockingController1
            // 
            this.defaultBarAndDockingController1.Controller.PropertiesBar.AllowLinkLighting = false;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.Controller = this.defaultBarAndDockingController1.Controller;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue";
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = this.DiseñosDB;
            this.navBarControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.EvaluacionProveedor,
            this.OrdenesCompra,
            this.Requerimientos,
            this.Pagos,
            this.Recibos,
            this.Presupuesto,
            this.DiseñosDB});
            this.navBarControl.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.ComprasAutorizadas,
            this.CuboComprasAutorizadas,
            this.OrdenesCompraGP,
            this.CuboComprasGP,
            this.RequerimientosDependencia,
            this.RequermientosArticulos,
            this.PagosI,
            this.PagosvsCompras,
            this.CuboPagosvsCompras,
            this.RecibosPeriodo,
            this.Ejecutado,
            this.EjecutadoPresupuestado,
            this.Diseñador,
            this.EvaluacionPuntaje,
            this.EvaluacionTipoProveedor,
            this.EvaluacionNotas,
            this.EvalucionBase});
            this.navBarControl.LargeImages = this.navbarImageCollectionLarge;
            this.navBarControl.Location = new System.Drawing.Point(0, 0);
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.OptionsNavPane.ExpandedWidth = 258;
            this.navBarControl.Size = new System.Drawing.Size(258, 767);
            this.navBarControl.SmallImages = this.navbarImageCollection;
            this.navBarControl.StoreDefaultPaintStyleName = true;
            this.navBarControl.TabIndex = 2;
            this.navBarControl.Text = "navBarControl1";
            // 
            // DiseñosDB
            // 
            this.DiseñosDB.Caption = "Diseños DB";
            this.DiseñosDB.Expanded = true;
            this.DiseñosDB.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.Diseñador)});
            this.DiseñosDB.Name = "DiseñosDB";
            // 
            // Diseñador
            // 
            this.Diseñador.Caption = "Diseñador";
            this.Diseñador.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("Diseñador.ImageOptions.SmallImage")));
            this.Diseñador.Name = "Diseñador";
            this.Diseñador.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.Diseñador_LinkClicked);
            // 
            // EvaluacionProveedor
            // 
            this.EvaluacionProveedor.Caption = "Evaluacion Proveedor";
            this.EvaluacionProveedor.Expanded = true;
            this.EvaluacionProveedor.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.EvaluacionPuntaje),
            new DevExpress.XtraNavBar.NavBarItemLink(this.EvaluacionTipoProveedor),
            new DevExpress.XtraNavBar.NavBarItemLink(this.EvaluacionNotas),
            new DevExpress.XtraNavBar.NavBarItemLink(this.EvalucionBase)});
            this.EvaluacionProveedor.Name = "EvaluacionProveedor";
            // 
            // EvaluacionPuntaje
            // 
            this.EvaluacionPuntaje.Caption = "Puntaje pastel";
            this.EvaluacionPuntaje.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("EvaluacionPuntaje.ImageOptions.SvgImage")));
            this.EvaluacionPuntaje.Name = "EvaluacionPuntaje";
            this.EvaluacionPuntaje.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.EvaluacionPuntaje_LinkClicked);
            // 
            // EvaluacionTipoProveedor
            // 
            this.EvaluacionTipoProveedor.Caption = "Puntaje x TipoProveedor";
            this.EvaluacionTipoProveedor.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("EvaluacionTipoProveedor.ImageOptions.SvgImage")));
            this.EvaluacionTipoProveedor.Name = "EvaluacionTipoProveedor";
            this.EvaluacionTipoProveedor.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.EvaluacionTipoProveedor_LinkClicked);
            // 
            // EvaluacionNotas
            // 
            this.EvaluacionNotas.Caption = "Puntaje x Criterio";
            this.EvaluacionNotas.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("EvaluacionNotas.ImageOptions.SvgImage")));
            this.EvaluacionNotas.Name = "EvaluacionNotas";
            this.EvaluacionNotas.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.EvaluacionNotas_LinkClicked);
            // 
            // EvalucionBase
            // 
            this.EvalucionBase.Caption = "Puntaje Base Evaluación";
            this.EvalucionBase.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("EvalucionBase.ImageOptions.SvgImage")));
            this.EvalucionBase.Name = "EvalucionBase";
            this.EvalucionBase.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.EvalucionBase_LinkClicked);
            // 
            // OrdenesCompra
            // 
            this.OrdenesCompra.Caption = "Ordenes Compra";
            this.OrdenesCompra.Expanded = true;
            this.OrdenesCompra.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.ComprasAutorizadas),
            new DevExpress.XtraNavBar.NavBarItemLink(this.CuboComprasAutorizadas),
            new DevExpress.XtraNavBar.NavBarItemLink(this.OrdenesCompraGP),
            new DevExpress.XtraNavBar.NavBarItemLink(this.CuboComprasGP)});
            this.OrdenesCompra.Name = "OrdenesCompra";
            // 
            // ComprasAutorizadas
            // 
            this.ComprasAutorizadas.Caption = "Gestiones de Compra Autorizadas";
            this.ComprasAutorizadas.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ComprasAutorizadas.ImageOptions.LargeImage")));
            this.ComprasAutorizadas.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("ComprasAutorizadas.ImageOptions.SmallImage")));
            this.ComprasAutorizadas.Name = "ComprasAutorizadas";
            this.ComprasAutorizadas.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ComprasAutorizadas_LinkClicked);
            // 
            // CuboComprasAutorizadas
            // 
            this.CuboComprasAutorizadas.Caption = "Gestiones de Compra Autorizadas";
            this.CuboComprasAutorizadas.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("CuboComprasAutorizadas.ImageOptions.LargeImage")));
            this.CuboComprasAutorizadas.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("CuboComprasAutorizadas.ImageOptions.SmallImage")));
            this.CuboComprasAutorizadas.Name = "CuboComprasAutorizadas";
            this.CuboComprasAutorizadas.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.CuboComprasAutorizadas_LinkClicked);
            // 
            // OrdenesCompraGP
            // 
            this.OrdenesCompraGP.Caption = "Gestiones de Compra";
            this.OrdenesCompraGP.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("OrdenesCompraGP.ImageOptions.SmallImage")));
            this.OrdenesCompraGP.Name = "OrdenesCompraGP";
            this.OrdenesCompraGP.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.OrdenesCompraGP_LinkClicked);
            // 
            // CuboComprasGP
            // 
            this.CuboComprasGP.Caption = "Gestiones de Compra";
            this.CuboComprasGP.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("CuboComprasGP.ImageOptions.SmallImage")));
            this.CuboComprasGP.Name = "CuboComprasGP";
            this.CuboComprasGP.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.CuboComprasGP_LinkClicked);
            // 
            // Requerimientos
            // 
            this.Requerimientos.Caption = "Requerimientos";
            this.Requerimientos.Expanded = true;
            this.Requerimientos.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.RequerimientosDependencia),
            new DevExpress.XtraNavBar.NavBarItemLink(this.RequermientosArticulos)});
            this.Requerimientos.Name = "Requerimientos";
            // 
            // RequerimientosDependencia
            // 
            this.RequerimientosDependencia.Caption = "Requermientos/Dependencia";
            this.RequerimientosDependencia.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("RequerimientosDependencia.ImageOptions.SmallImage")));
            this.RequerimientosDependencia.Name = "RequerimientosDependencia";
            this.RequerimientosDependencia.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.RequerimientosDependencia_LinkClicked);
            // 
            // RequermientosArticulos
            // 
            this.RequermientosArticulos.Caption = "Requerimientos/Articulos";
            this.RequermientosArticulos.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("RequermientosArticulos.ImageOptions.SmallImage")));
            this.RequermientosArticulos.Name = "RequermientosArticulos";
            this.RequermientosArticulos.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.RequermientosArticulos_LinkClicked);
            // 
            // Pagos
            // 
            this.Pagos.Caption = "Pagos";
            this.Pagos.Expanded = true;
            this.Pagos.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.PagosI),
            new DevExpress.XtraNavBar.NavBarItemLink(this.PagosvsCompras),
            new DevExpress.XtraNavBar.NavBarItemLink(this.CuboPagosvsCompras)});
            this.Pagos.Name = "Pagos";
            // 
            // PagosI
            // 
            this.PagosI.Caption = "Pagos ";
            this.PagosI.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("PagosI.ImageOptions.SmallImage")));
            this.PagosI.Name = "PagosI";
            this.PagosI.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.PagosI_LinkClicked);
            // 
            // PagosvsCompras
            // 
            this.PagosvsCompras.Caption = "Pagos vs Compras";
            this.PagosvsCompras.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("PagosvsCompras.ImageOptions.SmallImage")));
            this.PagosvsCompras.Name = "PagosvsCompras";
            this.PagosvsCompras.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.PagosvsCompras_LinkClicked);
            // 
            // CuboPagosvsCompras
            // 
            this.CuboPagosvsCompras.Caption = "Cubo Pagos  vs Compras";
            this.CuboPagosvsCompras.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("CuboPagosvsCompras.ImageOptions.SmallImage")));
            this.CuboPagosvsCompras.Name = "CuboPagosvsCompras";
            this.CuboPagosvsCompras.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.CuboPagosvsCompras_LinkClicked);
            // 
            // Recibos
            // 
            this.Recibos.Caption = "Recibos";
            this.Recibos.Expanded = true;
            this.Recibos.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.RecibosPeriodo)});
            this.Recibos.Name = "Recibos";
            // 
            // RecibosPeriodo
            // 
            this.RecibosPeriodo.Caption = "Recibos/Periodo";
            this.RecibosPeriodo.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("RecibosPeriodo.ImageOptions.SmallImage")));
            this.RecibosPeriodo.Name = "RecibosPeriodo";
            this.RecibosPeriodo.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.RecibosPeriodo_LinkClicked);
            // 
            // Presupuesto
            // 
            this.Presupuesto.Caption = "Presupuesto";
            this.Presupuesto.Expanded = true;
            this.Presupuesto.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.Ejecutado),
            new DevExpress.XtraNavBar.NavBarItemLink(this.EjecutadoPresupuestado)});
            this.Presupuesto.Name = "Presupuesto";
            // 
            // Ejecutado
            // 
            this.Ejecutado.Caption = "Ejecutado";
            this.Ejecutado.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("Ejecutado.ImageOptions.SmallImage")));
            this.Ejecutado.Name = "Ejecutado";
            this.Ejecutado.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.Ejecutado_LinkClicked);
            // 
            // EjecutadoPresupuestado
            // 
            this.EjecutadoPresupuestado.Caption = "Ejecutado/Presupuestado";
            this.EjecutadoPresupuestado.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("EjecutadoPresupuestado.ImageOptions.SmallImage")));
            this.EjecutadoPresupuestado.Name = "EjecutadoPresupuestado";
            this.EjecutadoPresupuestado.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.EjecutadoPresupuestado_LinkClicked);
            // 
            // frmMain
            // 
            this.AllowMdiBar = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 767);
            this.Controls.Add(this.navBarControl);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WDB";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollectionLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDockingController1.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraNavBar.NavBarItem inboxItem;
        private DevExpress.XtraNavBar.NavBarItem outboxItem;
        private DevExpress.XtraNavBar.NavBarItem draftsItem;
        private DevExpress.XtraNavBar.NavBarItem trashItem;
        private DevExpress.XtraNavBar.NavBarItem calendarItem;
        private DevExpress.XtraNavBar.NavBarItem tasksItem;
        private DevExpress.Utils.ImageCollection navbarImageCollection;
        private DevExpress.Utils.ImageCollection navbarImageCollectionLarge;
        private DevExpress.XtraBars.DefaultBarAndDockingController defaultBarAndDockingController1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraNavBar.NavBarGroup OrdenesCompra;
        private DevExpress.XtraNavBar.NavBarGroup Requerimientos;
        private DevExpress.XtraNavBar.NavBarGroup Presupuesto;
        private DevExpress.XtraNavBar.NavBarItem EjecutadoPresupuestado;
        private DevExpress.XtraNavBar.NavBarItem Ejecutado;
        private DevExpress.XtraNavBar.NavBarItem CuboComprasGP;
        private DevExpress.XtraNavBar.NavBarItem OrdenesCompraGP;
        private DevExpress.XtraNavBar.NavBarItem CuboComprasAutorizadas;
        private DevExpress.XtraNavBar.NavBarItem ComprasAutorizadas;
        private DevExpress.XtraNavBar.NavBarItem RequermientosArticulos;
        private DevExpress.XtraNavBar.NavBarItem RequerimientosDependencia;
        private DevExpress.XtraNavBar.NavBarGroup Pagos;
        private DevExpress.XtraNavBar.NavBarItem CuboPagosvsCompras;
        private DevExpress.XtraNavBar.NavBarItem PagosvsCompras;
        private DevExpress.XtraNavBar.NavBarItem PagosI;
        private DevExpress.XtraNavBar.NavBarGroup Recibos;
        private DevExpress.XtraNavBar.NavBarItem RecibosPeriodo;
        private DevExpress.XtraNavBar.NavBarGroup DiseñosDB;
        private DevExpress.XtraNavBar.NavBarItem Diseñador;
        private DevExpress.XtraNavBar.NavBarGroup EvaluacionProveedor;
        private DevExpress.XtraNavBar.NavBarItem EvaluacionPuntaje;
        private DevExpress.XtraNavBar.NavBarItem EvaluacionTipoProveedor;
        private DevExpress.XtraNavBar.NavBarItem EvaluacionNotas;
        private DevExpress.XtraNavBar.NavBarItem EvalucionBase;
    }
}
