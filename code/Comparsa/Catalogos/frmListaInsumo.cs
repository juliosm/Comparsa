﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanterLibNET;
using Comparsa.Data;
using LinqToDB;
using LinqToDB.Data;

namespace Comparsa
{
    public partial class frmListaInsumo : Form
    {

        public static frmListaInsumo Instance = null;

        public frmListaInsumo()
        {
            InitializeComponent();
        }

        public static void ShowAsMDIChild(Form mdiParent)
        {
            if (Instance == null)
            {
                Instance = new frmListaInsumo { MdiParent = mdiParent };
                Instance.Show();
            }
            else
            {
                Instance.Activate();
            }
        }

        private void frmListaInsumo_Load(object sender, EventArgs e)
        {
            LoadWindowConfig();
            LoadGridData();
        }

        private void frmListaInsumo_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveWindowConfig();
            Instance = null;
        }

        private void LoadWindowConfig()
        {
            AppUtils.LoadWindowConfig(Globals.GXmlConfigUser, this, true, true, true);
        }

        private void SaveWindowConfig()
        {
            AppUtils.SaveWindowConfig(Globals.GXmlConfigUser, this, true, true, true);
        }

        private void LoadGridData()
        {

            using (var db = Globals.DataContext.CreateDataConnection())
            {

                var queryInsumos = (
                    from a in db.GetTable<INSUMO>()
                    join ti in db.GetTable<TIPOINSUMO>() on a.TIPOINSUMOID equals ti.TIPOINSUMOID
                    orderby a.CODIGO
                    select new INSUMO_EXT
                    {
                        INSUMOID = a.INSUMOID,
                        CODIGO = a.CODIGO,
                        NOMBRE = a.NOMBRE,
                        TOTALENTRADAS = a.TOTALENTRADAS,
                        TOTALSALIDAS = a.TOTALSALIDAS,
                        EXISTENCIA = a.EXISTENCIA,
                        TIPOINSUMOID = a.TIPOINSUMOID,
                        NOMBRETIPOINSUMO = ti.NOMBRE
                    }).ToList();

                bindingSourceGrid.DataSource = queryInsumos;

            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarRegistro();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarRegistro();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            BorrarRegistro();
        }

        private bool AgregarRegistro()
        {

            bool result = false;

            if (InfoRegistro(CRUDMode.Create))
            {
                LoadGridData();
            }

            return result;

        }

        private bool ModificarRegistro()
        {

            bool result = false;

            if (gridView.SelectedRows.Count > 0)
            {
                if (InfoRegistro(CRUDMode.Update))
                {
                    LoadGridData();
                }
            }

            return result;

        }

        private bool BorrarRegistro()
        {

            bool result = false;

            if (gridView.SelectedRows.Count > 0)
            {

                DataGridViewRow row = null;
                //int id = 0;
                INSUMO registro = null;

                row = gridView.SelectedRows[0];
                //id = Convert.ToInt32(row.Cells["colINSUMOID"].Value);
                //registro = TableExtensions.Find(Globals.DataContext.INSUMOS, id);
                registro = (INSUMO)row.DataBoundItem;

                if (registro != null)
                {

                    if (AppUtils.MsgConfirmation("¿Desea borrar el registro seleccionado?", "Por favor confirme"))
                    {

                        using (var db = Globals.DataContext.CreateDataConnection())
                        {
                            db.Delete(registro);
                        }

                        LoadGridData();

                    }

                }

            }

            return result;

        }

        private bool InfoRegistro(CRUDMode mode)
        {

            bool result = false;
            DialogResult dr = DialogResult.Cancel;

            DataGridViewRow row = null;
            //int id = 0;
            INSUMO registro = null;

            if (mode == CRUDMode.Update)
            {
                row = gridView.SelectedRows[0];
                //id = Convert.ToInt32(row.Cells["colINSUMOID"].Value);
                //registro = TableExtensions.Find(Globals.DataContext.INSUMOS, id);
                registro = (INSUMO)row.DataBoundItem;
            }

            frmDetInsumo frmDetInsumo = new frmDetInsumo();
            frmDetInsumo.mode = mode;
            if (mode == CRUDMode.Update)
            {
                frmDetInsumo.registro = registro;
            }
            dr = frmDetInsumo.ShowDialog();
            frmDetInsumo.Dispose();
            frmDetInsumo = null;

            result = dr == DialogResult.OK;

            return result;

        }

        private void gridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModificarRegistro();
        }

        private void gridView_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {

                case Keys.Insert:

                    if (btnAgregar.Enabled)
                    {
                        AgregarRegistro();
                    }

                    break;

                case Keys.Enter:

                    if (btnModificar.Enabled) 
                    {
                        ModificarRegistro();
                    }

                    break;

                case Keys.Delete:

                    if (btnBorrar.Enabled)
                    {
                        BorrarRegistro();
                    }

                    break;

                case Keys.F5:

                    LoadGridData();

                    break;

                default:
                    break;
            }

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            RefreshGridData();
        }

        public void RefreshGridData()
        {
            LoadGridData();
        }

        private void frmListaInsumo_Resize(object sender, EventArgs e)
        {
            this.MdiParent.Refresh();
        }
    }

}
