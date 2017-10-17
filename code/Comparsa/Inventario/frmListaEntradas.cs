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
    public partial class frmListaEntradas : Form
    {

        private static frmListaEntradas Instance = null;

        public frmListaEntradas()
        {
            InitializeComponent();
        }

        public static void ShowAsMDIChild(Form mdiParent)
        {
            if (Instance == null)
            {
                Instance = new frmListaEntradas { MdiParent = mdiParent };
                Instance.Show();
            }
            else
            {
                Instance.Activate();
            }
        }

        private void frmListaEntradas_Load(object sender, EventArgs e)
        {
            LoadWindowConfig();
            LoadGridData();
        }

        private void frmListaEntradas_FormClosed(object sender, FormClosedEventArgs e)
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
                bindingSourceGrid.DataSource = db.GetTable<ENTRADA>().ToList();
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
                RefrescarListaInsumos();
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
                    RefrescarListaInsumos();
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
                ENTRADA registro = null;

                row = gridView.SelectedRows[0];
                registro = (ENTRADA)row.DataBoundItem;

                if (registro != null)
                {

                    if (AppUtils.MsgConfirmation("¿Desea borrar el registro seleccionado?", "Por favor confirme"))
                    {

                        using (var db = Globals.DataContext.CreateDataConnection())
                        {
                            db.Delete(registro);
                        }

                        LoadGridData();
                        RefrescarListaInsumos();

                    }

                }

            }

            return result;

        }

        private void RefrescarListaInsumos()
        {
            if (frmListaInsumo.Instance != null)
            {
                frmListaInsumo.Instance.RefreshGridData();
            }
        }

        private bool InfoRegistro(CRUDMode mode)
        {

            bool result = false;
            DialogResult dr = DialogResult.Cancel;

            DataGridViewRow row = null;
            ENTRADA registro = null;

            if (mode == CRUDMode.Update)
            {
                row = gridView.SelectedRows[0];
                registro = (ENTRADA)row.DataBoundItem;
            }

            frmDetEntrada frmDetEntrada = new frmDetEntrada();
            frmDetEntrada.mode = mode;
            if (mode == CRUDMode.Update)
            {
                frmDetEntrada.registro = registro;
            }
            dr = frmDetEntrada.ShowDialog();
            frmDetEntrada.Dispose();
            frmDetEntrada = null;

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

        private void RefreshGridData()
        {
            LoadGridData();
        }

        private void frmListaEntradas_Resize(object sender, EventArgs e)
        {
            this.MdiParent.Refresh();
        }

    }

}
