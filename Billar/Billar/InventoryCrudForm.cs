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
    public partial class InventoryCrudForm : Form
    {
        string metodo;
        public InventoryCrudForm()
        {
            InitializeComponent();
            metodo = "INSERTAR";
            pictureBox1.Text = "Agregar";
            tbCode.Enabled = false;
            tbCode.Visible = false;
            lbTitulo.Text = "AGREGAR PRODUCTO";
        }

        public InventoryCrudForm(string code, string name, string price, string stock, string description, string metodo)
        {
            InitializeComponent();
            this.metodo = metodo;

            if (metodo == "Mostrar")
            {
                lbTitulo.Text = "DETALLES PRODUCTO";
                tbCode.Text = code;
                tbName.Text = name;
                tbPrice.Text = price;
                tbStock.Text = stock;
                tbDescription.Text = description;

                tbCode.Enabled = false;
                tbName.Enabled = false;
                tbPrice.Enabled = false;
                tbStock.Enabled = false;
                tbDescription.Enabled = false; ;
                pictureBox1.Enabled = false;
            }
            if (metodo == "Modificar")
            {
                lbTitulo.Text = "MODIFICAR PRODUCTO";
                tbCode.Text = code;
                tbName.Text = name;
                tbPrice.Text = price;
                tbStock.Text = stock;
                tbDescription.Text = description;

                tbCode.Enabled = false;
                tbName.Enabled = true;
                tbPrice.Enabled = true;
                tbStock.Enabled = true;
                tbDescription.Enabled = true; ;
                pictureBox1.Enabled = true;
                pictureBox1.Text = "Actualizar";
            }
            if (metodo == "Eliminar")
            {
                lbTitulo.Text = "DETALLES DEL PRODUCTO A ELIMINAR";
                tbCode.Text = code;
                tbName.Text = name;
                tbPrice.Text = price;
                tbStock.Text = stock;
                tbDescription.Text = description;

                tbCode.Enabled = false;
                tbName.Enabled = false;
                tbPrice.Enabled = false;
                tbStock.Enabled = false;
                tbDescription.Enabled = false; ;
                pictureBox1.Enabled = true;
                pictureBox1.Text = "Eliminar";
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Product U = new Product();
            if (this.metodo == "INSERTAR")
            {
                U.insertProduct(tbName.Text, float.Parse(tbPrice.Text), int.Parse(tbStock.Text), tbDescription.Text);
                MessageBox.Show("Producto Insertado con exito!!\nRegresando al a inventario");
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
                U.updateProduct(int.Parse(tbCode.Text), tbName.Text, float.Parse(tbPrice.Text), int.Parse(tbStock.Text), tbDescription.Text);
                MessageBox.Show("Producto Modificado con exito!!\nRegresando al a inventario");
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
            else if (this.metodo == "Modificar")
            {
                U.deleteProduct(int.Parse(tbCode.Text));
                MessageBox.Show("Producto Eliminado con exito!!\nRegresando al a inventario");
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

        /*private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }*/

        private void InventoryCrudForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*private void pictureBox1_Click(object sender, EventArgs e)
        {

        }*/
    }
}
