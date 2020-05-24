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
    public partial class SalesForm : Form
    {
        string name, id, type, password, username;
        public SalesForm()
        {
            InitializeComponent();
        }

        public SalesForm(string name, string id, string type, string password, string username)
        {
            InitializeComponent();
            this.name = name;
            this.id = id;
            this.type = type;
            this.password = password;
            this.username = username;
        }
    }
}
