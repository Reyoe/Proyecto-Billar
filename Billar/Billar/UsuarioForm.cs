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
        string name, id, type, password, username;
        public UsuarioForm()
        {
            InitializeComponent();
           dataGridView1.DataSource = Conexion.query("SELECT * FROM user");
           dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[4].Visible = false;

        }
        public UsuarioForm(string name, string id, string type, string password, string username)
        {
            InitializeComponent();
            dataGridView1.DataSource = Conexion.query("SELECT * FROM user");
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            this.name = name;
            this.id = id;
            this.type = type;
            this.password = password;
            this.username = username;
            MessageBox.Show(this.id);
            MessageBox.Show(this.username);
            MessageBox.Show(this.password);
            MessageBox.Show(this.name);
            MessageBox.Show(this.type);

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Conexion.query("SELECT * FROM user");
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }

       /* private void btMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }*/

        /*private void pictureBox1_Click(object sender, EventArgs e)
        {

        }*/

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
