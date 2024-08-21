using login2.Entities;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace login2
{
    public partial class aplication : Form
    {
        Usuario u2;
        public aplication(Usuario us)
        {
            u2= us;
            InitializeComponent();
        }

        

        private void aplication_Load(object sender, EventArgs e)
        {
            l_user.Text=$"{u2.Name}";
        }
    }
}
