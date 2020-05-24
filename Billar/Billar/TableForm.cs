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
    public partial class TableForm : Form
    {
        private List<Table> tables;
        private int indexTables;
        private string userAdmin;
        private DataBase database;
        string name, id, type, password, username;



        private void checkBoxClient_CheckedChanged(object sender, EventArgs e)
        {
            textBoxClient.Enabled = checkBoxClient.Checked ? true : false;
        }

        public TableForm()
        {
            InitializeComponent();
        }
        public TableForm(string name, string id, string type, string password, string username, ref List<Table> _tables)
        {
            InitializeComponent();
            this.name = name;
            this.id = id;
            this.type = type;
            this.password = password;
            this.username = username;

            database = new DataBase();
            tables = _tables;
            indexTables = 0;
            if (this.type == "Administrador") {
                groupBoxModTables.Visible |= true;
            }
            if (this.type == "Empleado")
            {
                groupBoxModTables.Visible |= false;
            }
        }

    }
}
