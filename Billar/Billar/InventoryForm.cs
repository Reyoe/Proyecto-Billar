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
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = Conexion.query("SELECT * FROM product");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            InventoryCrudForm myInventoryCrudForm = new InventoryCrudForm();
            myInventoryCrudForm.ShowDialog();

        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            string code, name, price, stock, description ,metodo;
            code = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            price = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            stock = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            description = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            metodo = "Mostrar";
            InventoryCrudForm myInventoryCrudForm = new InventoryCrudForm(code, name, price, stock, description, metodo);
            myInventoryCrudForm.ShowDialog();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            string code, name, price, stock, description, metodo;
            code = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            price = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            stock = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            description = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            metodo = "Modificar";
            InventoryCrudForm myInventoryCrudForm = new InventoryCrudForm(code, name, price, stock, description, metodo);
            myInventoryCrudForm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Conexion.query("SELECT * FROM product");
        }

       /* private void tbMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }*/

        private void btEliminar_Click(object sender, EventArgs e)
        {
            string code, name, price, stock, description, metodo;
            code = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            price = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            stock = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            description = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            metodo = "Eliminar";
            InventoryCrudForm myInventoryCrudForm = new InventoryCrudForm(code, name, price, stock, description, metodo);
            myInventoryCrudForm.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       /* private void pictureBox1_Click(object sender, EventArgs e)
        {

        }*/
    }
}
