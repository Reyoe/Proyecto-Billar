using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billar
{
    public partial class ClientCrudForm : Form
    {
        string metodo;
        public ClientCrudForm()
        {
            InitializeComponent();
            metodo = "INSERTAR";
            lbTitulo.Text = "AGREGAR CLIENTE";
            tbCode.Enabled = false;
        }
        public ClientCrudForm(int code, string name, int hours,string metodo)
        {
            InitializeComponent();
            this.metodo = metodo;

            if (metodo == "Mostrar")
            {
                lbTitulo.Text = "DETALLES CLIENTE";
                tbCode.Text = code.ToString();
                tbName.Text = name;
                tbHours.Text = hours.ToString();


                tbCode.Enabled = false;
                tbName.Enabled= false;
                tbHours.Enabled = false;
                btAgregar.Enabled = false;
            }
            if (metodo == "Modificar")
            {
                lbTitulo.Text = "MODIFICAR CLIENTE";
                tbCode.Text = code.ToString();
                tbName.Text = name;
                tbHours.Text = hours.ToString();


                tbCode.Enabled = false;
                tbName.Enabled = false;
                tbHours.Enabled = false;
                btAgregar.Enabled = false;
                btAgregar.Text = "Actualizar";
            }
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            Cliente U = new Cliente();
            if (this.metodo == "INSERTAR")
            {
                U.insertCliente(tbName.Text, int.Parse(tbHours.Text));
                /* if (cbTipo.SelectedIndex == 0)
                 {
                     a.insertAdministrador(tbCurp.Text, tbNombre.Text, tbApellido.Text, tbCorreo.Text, tbColonia.Text, tbCalle.Text, tbNoCasa.Text, tbCodigo.Text);
                 }
                 if (cbTipo.SelectedIndex == 1)
                 {
                     o.insertOperador(tbCurp.Text, tbNombre.Text, tbApellido.Text, tbCorreo.Text, tbColonia.Text, tbCalle.Text, tbNoCasa.Text, tbCodigo.Text);
                 }*/
            }
            else if (this.metodo == "modificar")
            {
                U.updateCliente(Int32.Parse(tbCode.Text), tbName.Text, int.Parse(tbHours.Text));
                /*if (cbTipo.SelectedIndex == 0)
                {
                    a.updateAdministrador(tbCurp.Text, tbNombre.Text, tbApellido.Text, tbCorreo.Text, tbColonia.Text, tbCalle.Text, tbNoCasa.Text, tbCodigo.Text);

                }
                if (cbTipo.SelectedIndex == 1)
                {
                    o.updateOperador(tbCurp.Text, tbNombre.Text, tbApellido.Text, tbCorreo.Text, tbColonia.Text, tbCalle.Text, tbNoCasa.Text, tbCodigo.Text);

                }*/
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
