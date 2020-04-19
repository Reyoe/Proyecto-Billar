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


    }
}
