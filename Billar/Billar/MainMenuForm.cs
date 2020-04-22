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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm myLoginForm = new LoginForm();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            UsuarioForm myUsuarioForm = new UsuarioForm();
            myUsuarioForm.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            TableForm myMesa = new TableForm();
            myMesa.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            InventoryForm myInventario = new InventoryForm();
            myInventario.ShowDialog();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            ClientForm myClientForm = new ClientForm();
            myClientForm.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ProfitsForm myProfitsForm = new ProfitsForm();
            myProfitsForm.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
