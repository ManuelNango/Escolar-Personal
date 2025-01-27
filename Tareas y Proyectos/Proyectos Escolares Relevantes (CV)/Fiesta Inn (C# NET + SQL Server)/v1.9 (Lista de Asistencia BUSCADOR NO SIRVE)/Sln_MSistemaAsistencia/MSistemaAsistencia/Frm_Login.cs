using MicroSisPlani;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prj_Capa_Negocio;
using Prj_Capa_Datos;

namespace MSistemaAsistencia
{
    public partial class Frm_Login : Form
    {

        public Frm_Login()
        {
            InitializeComponent();
        }

        /*private bool ValidarTextbox()
        {
            if (txt_usu.Text.Trim().Length == 0) { MessageBox.Show("Ingresa tu usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txt_usu.Focus(); return false; }
            if (txt_pass.Text.Trim().Length == 0) { MessageBox.Show("Ingresa tu contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txt_pass.Focus(); return false; }

            return true;    
        }*/

        private bool ValidarTextbox()
        {
            if (string.IsNullOrWhiteSpace(txt_usu.Text))
            {
                MessageBox.Show("Ingresa tu usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_usu.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_pass.Text))
            {
                MessageBox.Show("Ingresa tu contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_pass.Focus();
                return false;
            }

            return true;
        }




        private void AccederAlSistema()
        {
            //Conectar a regla de negocio (porque esta ya se conecta a la BD), para esto copiamos RN_Usuario
            RN_Usuario obj = new RN_Usuario();  //copiar clase RN_Usuario
            DataTable dt = new DataTable();

            //Dar intentos al usuario por si se equivoca
            int veces = 0;

            if (ValidarTextbox() == false) return;

            string usu, pass;
            usu = txt_usu.Text.Trim();
            pass = txt_pass.Text.Trim();

            if (obj.RN_Verificar_Acceso(usu, pass) == true)
            {
                //los datos son correctos:
                //MessageBox.Show("Bienvenido al Sistema", "Fiesta Inn | Manuel 2023", MessageBoxButtons.OK, MessageBoxIcon.Information);



                Cls_UsuarioLogin.Usuario = usu;

                dt = obj.RN_Leer_Datos_Usuario(usu);
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    Cls_UsuarioLogin.IdRol = Convert.ToString(dr["Id_usu"]); //MUCHO OJO MUCHO OJO (C8-36:04)
                    //Nombres = dr ["Nombre_Completo"].ToString();
                    Cls_UsuarioLogin.Apellidos = dr["Nombre_Completo"].ToString();
                    Cls_UsuarioLogin.IdRol = Convert.ToString(dr["Id_Rol"]);
                    Cls_UsuarioLogin.Rol = dr["NomRol"].ToString();
                    Cls_UsuarioLogin.Foto = dr["Avatar"].ToString();
                }

                this.Hide(); //Ocultamos nuestro formulario login
                Frm_Principal xMenuPrincipal = new Frm_Principal();
                xMenuPrincipal.Show();
                xMenuPrincipal.Cargar_Datos_usuario();


                /*  Metodo antiguo
                Frm_Principal prin = new Frm_Principal();

                prin.FormClosed += (sender, e) => this.Close(); // Cierra Form1 cuando Form2 se cierre

                this.Hide();
                prin.Show();
                */

            }
            else
            {
                //los datos NO son correctos
                MessageBox.Show("Usuario o Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_pass.Text = "";
                txt_pass.Focus();
                veces=veces+1;

                if (veces == 5)
                {
                    MessageBox.Show("Superaste el numero máximo de intentos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Application.Exit();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPrueba_MouseEnter(object sender, EventArgs e)
        {
            btnPrueba.BackgroundImage = Image.FromFile(@"C:\Users\Manuel NP\OneDrive\Documentos\C#\Imagenes SisAsistencia\iluminado.jpg");
        }

        private void btnPrueba_MouseLeave(object sender, EventArgs e)
        {
            btnPrueba.BackgroundImage = Image.FromFile(@"C:\Users\Manuel NP\OneDrive\Documentos\C#\Imagenes SisAsistencia\btnlogin.jpg");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación
            Application.Exit();
        }

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            btnCerrar.BackgroundImage = Image.FromFile(@"C:\Users\Manuel NP\OneDrive\Documentos\C#\Imagenes SisAsistencia\closeRed.jpg");
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackgroundImage = Image.FromFile(@"C:\Users\Manuel NP\OneDrive\Documentos\C#\Imagenes SisAsistencia\closeBlack.jpg");
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario
            //Form2 form2 = new Form2();

            //Mostrar el nuevo formulario
            //form2.Show();

            AccederAlSistema();
        
        }

        //Eventos para el Panel Superior (Poder moverlo)
        private void pnl_titu_MouseMove(object sender, MouseEventArgs e)
        {
            //Si el botón es igual a botón izquierdo del mouse
            if (e.Button == MouseButtons.Left)
            {
                Utilitarios u = new Utilitarios();
                u.Mover_formulario(this);
            }
        }

        private void pnl_titu_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pnl_titu_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void txt_usu_TextChanged(object sender, EventArgs e)
        {

        }

        //Para al dar enter cambiar de txt
        private void txt_usu_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txt_pass.Focus();
            }
        }

        //Activar botón inicio de sesión con Enter
        private void txt_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita que se procese la tecla Enter en el TextBox
                btnPrueba.PerformClick(); // Activa el evento clic del botón
            }
        }
    }
}
