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
    public partial class UsuarioForm : Form
    {
        public UsuarioForm()
        {
            InitializeComponent();
           dataGridView1.DataSource = Conexion.query("SELECT * FROM user");
           dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[4].Visible = false;

        }


    }
}
