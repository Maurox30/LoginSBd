using login2.Entities;
using System;
using System.Windows.Forms;

namespace login2
{
    public partial class login3 : Form
    {
        public login3()
        {
            InitializeComponent();
        }
        Usuario u1 = new Usuario();
        private void login3_Load(object sender, EventArgs e)
        {
            sesion_cartel.Visible = false;
            r_cartel.Visible = false;
            r_error_nombre.Visible = false;
            r_error_apellido.Visible = false;
            r_error_pass.Visible = false;  
            r_error_usuario.Visible = false;
           

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void registrar_btn_Click(object sender, EventArgs e)
        {
            r_error_nombre.Visible = false;
            r_error_apellido.Visible = false;
            r_error_pass.Visible = false;
            r_error_usuario.Visible = false;
            r_btn_pw.Visible = false;

            if (r_nombre.Text == "" || r_apellido.Text=="" || r_user.Text=="" || r_pw.Text=="")
            {
                if (r_nombre.Text == "") { r_error_nombre.Visible = true; }
                if (r_apellido.Text == "") { r_error_apellido.Visible = true; }
                if (r_user.Text == "") { r_error_usuario.Visible = true; }
                if (r_pw.Text == "") {
                    r_error_pass.Visible = true;
                }
                else { r_btn_pw.Visible= true; }

            }
            else
            {
                //r_error_nombre.Visible = false;
                u1.Register(r_nombre.Text, r_apellido.Text, r_user.Text, r_pw.Text);
                r_cartel.Visible = true;
                r_nombre.Clear();
                r_apellido.Clear();
                r_user.Clear();
                r_pw.Clear();
            }
        }

        private void Sesion_btn_Click(object sender, EventArgs e)
        {
            var validate = u1.Log(Sesion_u.Text, Sesion_pw.Text);
            if (validate)
            {
                this.Hide();
                aplication aplicacion = new aplication(u1);
                aplicacion.Show();
                aplicacion.FormClosed += CloseForm;
            }
            else
            {
                sesion_cartel.Visible = true;
            }
        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            this.Show();
            sesion_cartel.Visible = false;
            r_cartel.Visible = false;
            r_error_nombre.Visible = false;
            Sesion_u.Text = "";
            Sesion_pw.Text = "";
            Sesion_u.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            r_pw.UseSystemPasswordChar = false;
        }
    }
}
