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
    public partial class UsuarioForm : Form
    {
        public UsuarioForm()
        {
            InitializeComponent();
           dataGridView1.DataSource = Conexion.query("SELECT * FROM user");
           dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[4].Visible = false;

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string code, username, password, name, metodo, type;
                code = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                username = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                password = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                name = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                type = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                metodo = "Mostrar";
                UsuarioCrudForm myUserCrudForm = new UsuarioCrudForm(code,  username,  password,  name,  type,  metodo);
                myUserCrudForm.ShowDialog();
            }

        private void btnAgregarUs_Click(object sender, EventArgs e)
        {
            UsuarioCrudForm myUserCrudForm = new UsuarioCrudForm();
            myUserCrudForm.ShowDialog();
        }

        private void Titulo_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Conexion.query("SELECT * FROM user");
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string code, username, password, name, metodo, type;
            code = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            username = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            password = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            name = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            type = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            metodo = "Modificar";
            UsuarioCrudForm myUserCrudForm = new UsuarioCrudForm(code, username, password, name, type, metodo);
            myUserCrudForm.ShowDialog();
        }
    }
}
