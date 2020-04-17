﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Billar
{

    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class Form1 : Form
    {
        Usuario usuario;
        public Form1()
        {
            usuario = new Usuario();
            Conexion.crearConexionLocal();
            
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }
        void TextUserEnter(object sender, EventArgs e)
        {
            if (textUser.Text.Equals("Username"))
            {
                textUser.Clear();
                textUser.ForeColor = Color.DarkSlateBlue;
            }
        }
        void TextUserLeave(object sender, EventArgs e)
        {
            if (textUser.Text.Equals(""))
            {
                textUser.Text = "Username";
                textUser.ForeColor = Color.DimGray;
            }
        }
        void TextPasswordEnter(object sender, EventArgs e)
        {
            if (textPassword.Text.Equals("Password"))
            {
                textPassword.Clear();
                textPassword.ForeColor = Color.DarkSlateBlue;
            }
        }
        void TextPasswordLeave(object sender, EventArgs e)
        {
            if (textPassword.Text.Equals(""))
            {
                textPassword.Text = "Password";
                textPassword.ForeColor = Color.DimGray;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            DataTable selectedUser = usuario.GetUsuario(textUser.Text, textPassword.Text);
            if (selectedUser.Rows.Count > 0)
            {
                Console.WriteLine(usuario.GetUsuario(textUser.Text, textPassword.Text).Rows[0][0].ToString());
                textUser.Clear();
                textPassword.Clear();
                MainMenu menu = new MainMenu();
                menu.ShowDialog();

            }
            else
            {
                MessageBox.Show("No Existe el Usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //usuario.GetUsuario(textUser.Text, textPassword.Text).Rows[0][0].ToString();

            //usuario.GetUsuarioById()
        }

    }
}