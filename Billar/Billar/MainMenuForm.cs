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
    public partial class MainMenuForm : Form
    {
        string name, id, type, password, username;
        public MainMenuForm()
        {
            InitializeComponent();
        }

        public MainMenuForm(string name, string id, string type, string password, string username)
        {
            InitializeComponent();
            this.name = name;
            this.id = id;
            this.type = type;
            this.password = password;
            this.username = username;
    
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
            UsuarioForm myUsuarioForm = new UsuarioForm(this.name, this.id, this.type, this.password, this.username);
            myUsuarioForm.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            TableForm myMesa = new TableForm();
            myMesa.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            InventoryForm myInventario = new InventoryForm(this.name, this.id, this.type, this.password, this.username);
            myInventario.ShowDialog();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            ClientForm myClientForm = new ClientForm(this.name, this.id, this.type, this.password, this.username);
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

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
}
