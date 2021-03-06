﻿using System;
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
            label2.Visible = false;
            tbCode.Enabled = false;
            tbCode.Visible = false;
            pictureBox1.Text = "Agregar";
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

                tbCode.Visible = true;
                tbCode.Enabled = false;
                tbName.Enabled= false;
                tbHours.Enabled = false;
                pictureBox1.Enabled = false;
            }
            if (metodo == "Modificar")
            {
                lbTitulo.Text = "MODIFICAR CLIENTE";
                tbCode.Text = code.ToString();
                tbName.Text = name;
                tbHours.Text = hours.ToString();

                label2.Visible = true;
                tbCode.Visible = true;
                tbCode.Enabled = false;
                tbName.Enabled = true;
                tbHours.Enabled = true;
                pictureBox1.Enabled = true;
                pictureBox1.Text = "Actualizar";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Cliente U = new Cliente();
            if (this.metodo == "INSERTAR")
            {
                U.insertCliente(tbName.Text, int.Parse(tbHours.Text));
                MessageBox.Show("Cliente insertado con exito!!\nRegresando al a cliente");

                this.Close();
                /* if (cbTipo.SelectedIndex == 0)
                 {
                     a.insertAdministrador(tbCurp.Text, tbNombre.Text, tbApellido.Text, tbCorreo.Text, tbColonia.Text, tbCalle.Text, tbNoCasa.Text, tbCodigo.Text);
                 }
                 if (cbTipo.SelectedIndex == 1)
                 {
                     o.insertOperador(tbCurp.Text, tbNombre.Text, tbApellido.Text, tbCorreo.Text, tbColonia.Text, tbCalle.Text, tbNoCasa.Text, tbCodigo.Text);
                 }*/
            }
            else if (this.metodo == "Modificar")
            {

                U.updateCliente(Int32.Parse(tbCode.Text), tbName.Text, int.Parse(tbHours.Text));
                MessageBox.Show("Cliente modificado con exito!!\nRegresando al a cliente");

                this.Close();
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

        /*private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }*/

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*private void pictureBox1_Click(object sender, EventArgs e)
        {

        }*/
    }
}
