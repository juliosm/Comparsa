﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comparsa.Data;
using LinqToDB;
using LinqToDB.Data;
using QuanterLibNET;

namespace Comparsa
{
    public partial class frmDetAfectado : Form
    {

        public AFECTADO registro = null;
        public CRUDMode mode = CRUDMode.Create;

        public frmDetAfectado()
        {
            InitializeComponent();
        }

        private void frmDetAfectado_Load(object sender, EventArgs e)
        {

            string titulo = "";

            LoadWindowConfig();

            CargarComboEstatus();
            CargarComboLocalidades();

            CargarListaRequerimientos();

            edEstatus.SelectedIndex = -1;
            edLocalidad.SelectedIndex = -1;

            switch (mode)
            {
                case CRUDMode.Create:
                    registro = new AFECTADO();
                    titulo = "Agregar afectado";
                    edEstatus.SelectedIndex = edEstatus.FindStringExact(
                        AppUtils.GetNombreEstatusAfectado(Consts.ESTATUS_AFECTADO_POR_REVISAR));
                    break;

                case CRUDMode.Update:
                    MapearObjetoAPantalla();
                    titulo = "Modificar afectado";
                    break;

            }

            lbTitulo.Text = titulo;
            this.Text = titulo;

            edCodigo.Focus();

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CancelarCaptura();
        }

        private void CargarComboEstatus()
        {

            try
            {

                edEstatus.BeginUpdate();

                edEstatus.Items.Clear();

                edEstatus.Items.Add(new ListItem("Por revisar", Consts.ESTATUS_AFECTADO_POR_REVISAR));
                edEstatus.Items.Add(new ListItem("Afectación menor", Consts.ESTATUS_AFECTADO_AFECTACION_MENOR));
                edEstatus.Items.Add(new ListItem("Afectación mayor", Consts.ESTATUS_AFECTADO_AFECTACION_MAYOR));
                edEstatus.Items.Add(new ListItem("Sin daños", Consts.ESTATUS_AFECTADO_SIN_DANOS));
                edEstatus.Items.Add(new ListItem("Atendido", Consts.ESTATUS_AFECTADO_ATENDIDO));

            }
            finally
            {
                edEstatus.EndUpdate();
            }

        }

        private void CargarComboLocalidades()
        {
            bindingSourceLocalidad.DataSource = Globals.DataContext.LOCALIDADES;
        }

        private void CargarListaRequerimientos()
        {
            try
            {

                checkListReqs.BeginUpdate();

                checkListReqs.Items.Clear();

                foreach (var tipoInsumo in Globals.DataContext.TIPOSINSUMOS)
                {
                    checkListReqs.Items.Add(tipoInsumo, false);
                }

                checkListReqs.ValueMember = "TIPOINSUMOID";
                checkListReqs.DisplayMember = "NOMBRE";

            }
            finally
            {
                checkListReqs.EndUpdate();
            }

        }

        private void CancelarCaptura()
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ConfirmarCaptura();
        }

        private void ConfirmarCaptura()
        {

            if (ValidarCaptura())
            {

                MapearPantallaAObjeto();

                if (mode == CRUDMode.Create)
                {
                    Globals.DataContext.DataConnection.Insert(registro);
                }
                else if (mode == CRUDMode.Update)
                {
                    Globals.DataContext.DataConnection.Update(registro);
                }

                GuardarRequerimientosAfectado();

                this.DialogResult = DialogResult.OK;

            }

        }

        private bool ValidarCaptura()
        {

            bool result = false;
            string mensaje = "";

            if (edCodigo.Text == "")
            {
                mensaje += "Debe especificar el código.\n";
            }

            if (edNombre.Text == "")
            {
                mensaje += "Debe especificar el nombre.\n";
            }

            if (edEstatus.Text == "")
            {
                mensaje += "Debe especificar el estatus.\n";
            }

            if (edLocalidad.Text == "")
            {
                mensaje += "Debe especificar la localidad.\n";
            }

            if (mensaje != "")
            {
                AppUtils.MsgError(mensaje, "Error");
            }

            result = mensaje == "";

            return result;

        }

        private void MapearPantallaAObjeto()
        {
            registro.CODIGO = edCodigo.Text;
            registro.NOMBRE = edNombre.Text;
            registro.TELEFONO = edTelefono.Text;
            registro.EMAIL = edEmail.Text;
            registro.CALLE = edCalle.Text;
            registro.NUMEXT = edNumExt.Text;
            registro.NUMINT = edNumInt.Text;
            registro.COLONIA = edColonia.Text;
            //registro.MUNICIPIO = edMunicipio.Text;
            //registro.ESTADO = edEstado.Text;
            registro.DICTAMEN = edDictamen.Text;
            registro.NOTAS = edNotas.Text;
            registro.ESTATUS = ((ListItem)(edEstatus.SelectedItem)).Value;
            registro.LOCALIDADID = Convert.ToInt32(edLocalidad.SelectedValue);
        }

        private void MapearObjetoAPantalla()
        {

            var reg = Globals.DataContext.AFECTADOS.LoadWith(a => a.LOCALIDAD).FirstOrDefault(x => x.AFECTADOID == registro.AFECTADOID);

            edCodigo.Text = registro.CODIGO;
            edNombre.Text = registro.NOMBRE;
            edTelefono.Text = registro.TELEFONO;
            edEmail.Text = registro.EMAIL;
            edCalle.Text = registro.CALLE;
            edNumExt.Text = registro.NUMEXT;
            edNumInt.Text = registro.NUMINT;
            edColonia.Text = registro.COLONIA;
            //edMunicipio.Text = registro.MUNICIPIO;
            //edEstado.Text = registro.ESTADO;
            edDictamen.Text = registro.DICTAMEN;
            edNotas.Text = registro.NOTAS;
            edEstatus.SelectedIndex = edEstatus.FindStringExact(AppUtils.GetNombreEstatusAfectado(registro.ESTATUS.Value));
            edLocalidad.SelectedIndex = edLocalidad.FindStringExact(reg.LOCALIDAD.NOMBRE);

            CargarRequerimientosAfectado();

        }

        private void CargarRequerimientosAfectado()
        {

            var reg = Globals.DataContext.AFECTADOS.LoadWith(a => a.AFECTADOREQs).FirstOrDefault(x => x.AFECTADOID == registro.AFECTADOID);

            foreach (var afectadoReq in reg.AFECTADOREQs)
            {

                var tipoInsumo = (
                    from t in Globals.DataContext.TIPOSINSUMOS
                    where t.TIPOINSUMOID == afectadoReq.TIPOINSUMOID
                    select t).FirstOrDefault();

                int itemIndex = checkListReqs.FindStringExact(tipoInsumo.NOMBRE);

                if (itemIndex != -1)
                {
                    checkListReqs.SetItemChecked(itemIndex, true);
                }

            }

        }

        private void GuardarRequerimientosAfectado()
        {

            // Borrar los proyectos relacionados que se hayan desmarcado
            List<object> deleteList = new List<object>();

            var reg = Globals.DataContext.AFECTADOS.LoadWith(a => a.AFECTADOREQs).FirstOrDefault(x => x.AFECTADOID == registro.AFECTADOID);

            foreach (var afectadoReq in reg.AFECTADOREQs)
            {

                var tipoInsumo = (
                    from t in Globals.DataContext.TIPOSINSUMOS
                    where t.TIPOINSUMOID == afectadoReq.TIPOINSUMOID
                    select t).FirstOrDefault();

                int itemIndex = checkListReqs.FindStringExact(tipoInsumo.NOMBRE);

                if (itemIndex != -1)
                {
                    if (checkListReqs.GetItemChecked(itemIndex) == false)
                    {
                        deleteList.Add(afectadoReq);
                    }
                }

            }

            foreach (AFECTADOREQ afectadoReq in deleteList)
            {
                Globals.DataContext.DataConnection.Delete(afectadoReq);
            }

            // Guardar los proyectos relacionados que se hayan marcado
            foreach (object item in checkListReqs.CheckedItems)
            {

                int tipoInsumoId = 0;

                tipoInsumoId = ((TIPOINSUMO)item).TIPOINSUMOID;

                AFECTADOREQ afectadoReq = reg.AFECTADOREQs.FirstOrDefault(
                    x => x.TIPOINSUMOID == tipoInsumoId);

                if (afectadoReq == null)
                {

                    afectadoReq = new AFECTADOREQ();
                    afectadoReq.TIPOINSUMOID = tipoInsumoId;
                    afectadoReq.AFECTADOID = reg.AFECTADOID;

                    Globals.DataContext.DataConnection.Insert(afectadoReq);

                }

            }

        }

        private void LoadWindowConfig()
        {
            AppUtils.LoadWindowConfig(Globals.GXmlConfigUser, this, true, true, true);
        }

        private void SaveWindowConfig()
        {
            AppUtils.SaveWindowConfig(Globals.GXmlConfigUser, this, true, true, true);
        }

        private void frmDetAfectado_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveWindowConfig();
        }

        private void frmDetAfectado_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.Cancel)
            {
                if (!AppUtils.MsgConfirmation("¿Desea cancelar los cambios en el registro?", "Por favor confirme"))
                {
                    e.Cancel = true;
                }
            }
        }

        private void CargarInfoLocalidadSeleccionada()
        {

            if (edLocalidad.Text != "")
            {

                int localidadId = Convert.ToInt32(edLocalidad.SelectedValue);
                LOCALIDAD localidad = TableExtensions.Find(Globals.DataContext.LOCALIDADES, localidadId);

                edMunicipio.Text = localidad.MUNICIPIO;
                edEstado.Text = localidad.ESTADO;

            }
            else
            {
                edMunicipio.Text = "";
                edEstado.Text = "";
            }


        }

        private void edLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarInfoLocalidadSeleccionada();
        }

    }

}