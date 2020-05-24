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
    public partial class ClientForm : Form
    {
        string name, id, type, password, username;
        public ClientForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = Conexion.query("SELECT * FROM client");

        }

        public ClientForm(string name, string id, string type, string password, string username)
        {
            InitializeComponent();
            dataGridView1.DataSource = Conexion.query("SELECT * FROM client");
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

        private void btnAgregarCli_Click(object sender, EventArgs e)
        {
            ClientCrudForm myClientCrudForm = new ClientCrudForm ();
            myClientCrudForm.ShowDialog();
        }

        private void btnMostrarCli_Click(object sender, EventArgs e)
        {
            string code, name, hours, metodo;
            code = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            hours = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            metodo = "Mostrar";
            ClientCrudForm myClientCrudForm = new ClientCrudForm(int.Parse(code), name, int.Parse(hours), metodo);
            myClientCrudForm.ShowDialog();
        }

        private void btnModificarCli_Click(object sender, EventArgs e)
        {
            string code, name, hours, metodo;
            code = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            hours = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            metodo = "Modificar";
            ClientCrudForm myClientCrudForm = new ClientCrudForm(int.Parse(code), name, int.Parse(hours), metodo);
            myClientCrudForm.ShowDialog();
        }


        private void pictureBox11_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Conexion.query("SELECT * FROM client");
        }

        /*private void btMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }*/

        /*private void pictureBox11_Click(object sender, EventArgs e)
        {

        }*/

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
