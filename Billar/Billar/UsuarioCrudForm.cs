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
    public partial class UsuarioCrudForm : Form
    {
        string metodo;
        public UsuarioCrudForm()
        {
            InitializeComponent();
            metodo = "INSERTAR";
            lbTitulo.Text = "AGREGAR USUARIO";
            cbType.SelectedIndex = 0;
            tbCode.Enabled=false;
            btAgregarU.Text = "Agregar";
        }

        public UsuarioCrudForm(string code, string username, string password, string name, string type, string metodo)
        {
            InitializeComponent();
            this.metodo = metodo;
            if (type == "Empleado") {
                cbType.SelectedIndex = 0;
            }
            else
            {
                cbType.SelectedIndex = 1;
            }

            if (metodo == "Mostrar")
            {
                lbTitulo.Text = "DETALLES USUARIO";
                tbCode.Text = code;
                tbUsername.Text = username;
                tbPassword.Text = password;
                tbName.Text = name;


                tbCode.Enabled = false;
                tbUsername.Enabled = false;
                tbPassword.Enabled = false;
                tbName.Enabled = false;
                cbType.Enabled = false;
                btAgregarU.Enabled = false;
            }
            if (metodo == "Modificar")
            {
                lbTitulo.Text = "MODIFICAR USUARIO";
                tbCode.Text = code;
                tbUsername.Text = username;
                tbPassword.Text = password;
                tbName.Text = name;


                tbCode.Enabled = false;
                tbUsername.Enabled = true;
                tbPassword.Enabled = true;
                tbName.Enabled = true;
                cbType.Enabled = false;
                btAgregarU.Text = "ACTUALIZAR";
            }
        }

        private void btAgregarU_Click(object sender, EventArgs e)
        {
            Usuario U = new Usuario();
            if (this.metodo == "INSERTAR")
            {
                U.insertUsuario(tbUsername.Text, tbPassword.Text, tbName.Text, cbType.Text);
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
                U.updateUsuario(Int32.Parse(tbCode.Text), tbUsername.Text, tbPassword.Text, tbName.Text);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
