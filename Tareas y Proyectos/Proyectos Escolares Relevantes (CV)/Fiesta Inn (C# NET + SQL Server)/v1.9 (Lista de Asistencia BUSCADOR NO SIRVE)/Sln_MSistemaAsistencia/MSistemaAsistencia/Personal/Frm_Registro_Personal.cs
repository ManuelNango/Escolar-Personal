using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Prj_Capa_Datos;
using Prj_Capa_Entidad;
using Prj_Capa_Negocio;

using MSistemaAsistencia.Msm_Forms;
using MicroSisPlani.Msm_Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.ConstrainedExecution;

namespace MSistemaAsistencia.Personal
{
    public partial class Frm_Registro_Personal : Form
    {
        public Frm_Registro_Personal()
        {
            InitializeComponent();
        }

        public bool sevaeditar = false;

        private void Cargar_rol()
        {
            RN_Rol obj = new RN_Rol();
            DataTable dt = new DataTable();

            try
            {
                dt = obj.RN_Buscar_Todos_Roles();
                if (dt.Rows.Count>0)
                {
                    var cbo = cbo_rol;
                    cbo.DataSource = dt;
                    cbo.DisplayMember = "NomRol";
                    cbo.ValueMember = "Id_Rol";
                }
                cbo_rol.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

            }
        }

        /*private void Cargar_Cargo()
        {
            RN_Cargo obj = new RN_Cargo();
            DataTable dt = new DataTable();

            try
            {
                dt = obj.RN_Buscar_Todos_Roles();
                if (dt.Rows.Count > 0)
                {
                    var cbo = cbo_rol;
                    cbo.DataSource = dt;
                    cbo.DisplayMember = "NomRol";
                    cbo.ValueMember = "Id_Rol";
                }
                cbo_rol.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

            }
        }*/

        /*private void cargarComboSexo()
        {
            cbo_sexo.ForeColor = Color.DimGray;
            // Agrega el elemento "Seleccione una opción" al principio de la lista.
            cbo_sexo.Items.Insert(0, "Sexo");

            // Selecciona por defecto el primer elemento (el título).
            cbo_sexo.SelectedIndex = 0;

        }*/

        private bool ValidarCajasTexto()
        {
            Frm_Advertencia adv = new Frm_Advertencia();
            Frm_Filtro fil = new Frm_Filtro();

            if (txt_Dni.Text.Trim().Length < 18)
            {
                fil.Show();
                adv.Lbl_Msm1.Text = "La CURP debe tener 18 caracteres";
                adv.ShowDialog();
                fil.Hide();
                txt_Dni.Focus();
                return false;
            }

            if (txtIdPersona.Text == "ID Personal" || txtIdPersona.Text.Trim().Length < 1)
            {
                fil.Show();
                adv.Lbl_Msm1.Text = "Ingresa el Numero de Trabajador";
                adv.ShowDialog();
                fil.Hide();
                txtIdPersona.Focus();
                return false;
            }

            if (txt_nombres.Text == "Nombre Completo" || txt_nombres.Text.Trim().Length < 1)
            {
                fil.Show();
                adv.Lbl_Msm1.Text = "Ingresa el Nombre de Trabajador";
                adv.ShowDialog();
                fil.Hide();
                txt_nombres.Focus();
                return false;
            }

            if (cbo_rol.Text.Trim().Length < 1)
            {
                fil.Show();
                adv.Lbl_Msm1.Text = "Ingresa el Cargo del Trabajador";
                adv.ShowDialog();
                fil.Hide();
                cbo_rol.Focus();
                return false;
            }



            return true;
        }

        private void Guardar_Personal()
        {
            Frm_Msm_Bueno OK = new Frm_Msm_Bueno();
            Frm_Filtro fil = new Frm_Filtro();
            RN_Personal obj = new RN_Personal();
            EN_Persona per = new EN_Persona();

            try
            {
                per.Idpersonal = txtIdPersona.Text;
                per.Dni = txt_Dni.Text.PadRight(18);
                per.Nombres = txt_nombres.Text;
                per.anoNacimiento = dtp_fechaNaci.Value;
                per.Sexo = cbo_sexo.Text;
                per.RFC = txt_direccion.Text;
                per.Correo = txt_correo.Text;
                //per.Celular = Convert.ToInt32 (txt_telefono.Text);
                per.Celular = txt_telefono.Text;
                per.IdRol = Convert.ToString(cbo_rol.SelectedValue);
                per.xImagen = xFotoruta;
                per.tipo = cbo_cargo.Text;


                obj.RN_Registral_Personal2(per);

                if(BD_Personal.saved==true)
                {
                    fil.Show();
                    OK.Lbl_msm1.Text = "los datos del personal se han Guardado de forma correcta";
                    OK.ShowDialog();
                    fil.Hide();

                    this.Tag = "A";
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void Editar_Personal()
        {
            Frm_Msm_Bueno OK = new Frm_Msm_Bueno();
            Frm_Filtro fil = new Frm_Filtro();
            RN_Personal obj = new RN_Personal();
            EN_Persona per = new EN_Persona();

            try
            {
                per.Idpersonal = txtIdPersona.Text;
                per.Dni = txt_Dni.Text.PadRight(18);
                per.Nombres = txt_nombres.Text;
                per.anoNacimiento = dtp_fechaNaci.Value;
                per.Sexo = cbo_sexo.Text;
                per.RFC = txt_direccion.Text;
                per.Correo = txt_correo.Text;
                //per.Celular = Convert.ToInt32 (txt_telefono.Text);
                per.Celular = txt_telefono.Text;
                per.IdRol = Convert.ToString(cbo_rol.SelectedValue);
                per.xImagen = xFotoruta;
                per.tipo = cbo_cargo.Text;


                obj.RN_Editar_Personal(per);

                if (BD_Personal.edited == true)
                {
                    fil.Show();
                    OK.Lbl_msm1.Text = "los datos del personal se han Editado de forma correcta";
                    OK.ShowDialog();
                    fil.Hide();

                    this.Tag = "A";
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void Frm_Registro_Personal_Load(object sender, EventArgs e)
        {
            if (sevaeditar==false)
            {
                Cargar_rol();
            }          
        }


        //CAMBIAR IMAGEN DE BOTÓN PARA DAR EFECTO DE SELECCIÓN

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Tag=""; //AGREGADO PERO NO SE PARA QUE ES
            this.Close();
        }

        private void btn_Salir_MouseEnter(object sender, EventArgs e)
        {
            btn_Salir.BackgroundImage = Image.FromFile(@"C:\Users\Manuel NP\OneDrive\Documentos\C#\Imagenes SisAsistencia\letraXr.png");
        }

        private void btn_Salir_MouseLeave(object sender, EventArgs e)
        {
            btn_Salir.BackgroundImage = Image.FromFile(@"C:\Users\Manuel NP\OneDrive\Documentos\C#\Imagenes SisAsistencia\letraX.png");
        }



        //EFECTO PARA APARECER Y DESAPARECER TITULO DE CADA TEXTBOX

        private void txtIdPersona_Enter(object sender, EventArgs e)
        {
            if (txtIdPersona.Text == "ID Personal")
            {
                txtIdPersona.Text = "";
                txtIdPersona.ForeColor = Color.DimGray;
            }
        }

        private void txtIdPersona_Leave(object sender, EventArgs e)
        {
            if (txtIdPersona.Text == "")
            {
                txtIdPersona.Text = "ID Personal";
                txtIdPersona.ForeColor = Color.Silver;
            }
        }

        private void txt_Dni_Enter(object sender, EventArgs e)
        {
            if (txt_Dni.Text == "CURP")
            {
                txt_Dni.Text = "";
                txt_Dni.ForeColor = Color.DimGray;
            }
        }

        private void txt_Dni_Leave(object sender, EventArgs e)
        {
            if (txt_Dni.Text == "")
            {
                txt_Dni.Text = "CURP";
                txt_Dni.ForeColor = Color.Silver;
            }
        }

        private void txt_nombres_Enter(object sender, EventArgs e)
        {
            if (txt_nombres.Text == "Nombre Completo")
            {
                txt_nombres.Text = "";
                txt_nombres.ForeColor = Color.DimGray;
            }
        }

        private void txt_nombres_Leave(object sender, EventArgs e)
        {
            if (txt_nombres.Text == "")
            {
                txt_nombres.Text = "Nombre Completo";
                txt_nombres.ForeColor = Color.Silver;
            }
        }

        private void txt_direccion_Enter(object sender, EventArgs e)
        {
            if (txt_direccion.Text == "RFC")
            {
                txt_direccion.Text = "";
                txt_direccion.ForeColor = Color.DimGray;
            }
        }

        private void txt_direccion_Leave(object sender, EventArgs e)
        {
            if (txt_direccion.Text == "")
            {
                txt_direccion.Text = "RFC";
                txt_direccion.ForeColor = Color.Silver;
            }
        }

        private void txt_correo_Enter(object sender, EventArgs e)
        {
            if (txt_correo.Text == "Correo electrónico")
            {
                txt_correo.Text = "";
                txt_correo.ForeColor = Color.DimGray;
            }
        }

        private void txt_correo_Leave(object sender, EventArgs e)
        {
            if (txt_correo.Text == "")
            {
                txt_correo.Text = "Correo electrónico";
                txt_correo.ForeColor = Color.Silver;
            }
        }


        private void txt_telefono_Enter(object sender, EventArgs e)
        {
            if (txt_telefono.Text == "Teléfono")
            {
                txt_telefono.Text = "";
                txt_telefono.ForeColor = Color.DimGray;
            }
        }

        private void txt_telefono_Leave(object sender, EventArgs e)
        {
            if (txt_telefono.Text == "")
            {
                txt_telefono.Text = "Teléfono";
                txt_telefono.ForeColor = Color.Silver;
            }
        }


        //ENTER PARA CAMBIAR DE TEXTBOX

        private void txtIdPersona_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Dni.Focus();
            }
        }

        private void txt_Dni_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_nombres.Focus();
            }
        }

        private void txt_nombres_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_direccion.Focus();
            }
        }


        string xFotoruta="sin imagen";

        private void Pic_persona_Click(object sender, EventArgs e)
        {
            var filepath = string.Empty;
            try
            {
                if (openFileDialog1.ShowDialog () == DialogResult.OK )
                {
                    xFotoruta = openFileDialog1.FileName;
                    Pic_persona.Load(xFotoruta);
                }
            }

            catch (Exception ex)
            {
                xFotoruta = Application.StartupPath + @"\user.png";
                Pic_persona.Load(Application.StartupPath + @"\user.png");
            }
        }

        public bool xedit = false;

        public void Buscar_Personal_ParaEditar(string idpersonal)
        {
            try
            {
                RN_Personal obj = new RN_Personal();
                DataTable data = new DataTable();

                Cargar_rol();

                data = obj.RN_Buscar_Personal_xValor(idpersonal);

                if (data.Rows.Count == 0) return;
                {

                    txt_Dni.Text = Convert.ToString(data.Rows[0]["DNIPR"]);
                    txtIdPersona.Text = Convert.ToString(data.Rows[0]["Id_Pernl"]);
                    txt_nombres.Text = Convert.ToString(data.Rows[0]["Nombre_Completo"]);
                    dtp_fechaNaci.Value = Convert.ToDateTime(data.Rows[0]["Fec_Naci"]);
                    cbo_sexo.Text = Convert.ToString(data.Rows[0]["Sexo"]);
                    txt_direccion.Text = Convert.ToString(data.Rows[0]["RFC"]);
                    txt_correo.Text = Convert.ToString(data.Rows[0]["Correo"]);
                    txt_telefono.Text = Convert.ToString(data.Rows[0]["Celular"]);
                    cbo_rol.SelectedValue = data.Rows[0]["Id_rol"];
                    cbo_cargo.Text = Convert.ToString(data.Rows[0]["Tipo"]);
                    xFotoruta = Convert.ToString(data.Rows[0]["Foto"]);

                    //txt_Dni.Text = Convert.ToString(data.Rows[0]["FinguerPrint"]);
                    //txt_Dni.Text = Convert.ToString(data.Rows[0]["Estado_Per"]);
                }

                xedit = true;
                btn_aceptar.Enabled = true;
                Pic_persona.Load(xFotoruta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar los datos: " + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Frm_Msm_Bueno OK = new Frm_Msm_Bueno();
            Frm_Filtro fil = new Frm_Filtro();
            RN_Personal objper = new RN_Personal();

            if (ValidarCajasTexto() == false) return;

            ///Verificar si el numero de trabajador es igual
            if(xedit == false )
            {
                if (objper.RN_Verificar_DniPersonal (txtIdPersona.Text) == true) { MessageBox.Show("El Numero de Trabajador ya existe en la BD", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                
                Guardar_Personal();
            }
            else
            {
                Editar_Personal();
            }

        }


        private void pnl_titu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Utilitarios u = new Utilitarios();
                u.Mover_formulario(this);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Dni_TextChanged(object sender, EventArgs e)
        {
            txt_Dni.Text = txt_Dni.Text.ToUpper();
        }

        private void txt_direccion_TextChanged(object sender, EventArgs e)
        {
            txt_direccion.Text = txt_direccion.Text.ToUpper();
        }

        private void txt_Dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void txt_direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void cbo_sexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_Dni_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
