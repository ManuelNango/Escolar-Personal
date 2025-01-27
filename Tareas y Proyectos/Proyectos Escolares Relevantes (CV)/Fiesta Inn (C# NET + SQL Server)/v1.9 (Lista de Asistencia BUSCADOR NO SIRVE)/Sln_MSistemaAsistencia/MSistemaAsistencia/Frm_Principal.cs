using MSistemaAsistencia.Personal;
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
using MicroSisPlani.Msm_Forms; //Para poder usar los mensajes de advertencia
using MSistemaAsistencia.Msm_Forms;
using MSistemaAsistencia.Informes;
using System.IO;

namespace MSistemaAsistencia
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            // Ocultar las pestañas
            elTab1.Appearance = TabAppearance.FlatButtons;
            elTab1.ItemSize = new Size(0, 1);

            // Mostrar la primera pestaña
            elTab1.SelectedIndex = 0;
            ConfiguraListView();
            ConfigurarListView_Asis();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Mostrar el formulario anterior nuevamente
            this.Show();
        }


        //IMAGENES Y FUNCIONES DE BOTONES SALIR Y MINI:
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Salir_MouseEnter(object sender, EventArgs e)
        {
            btn_Salir.BackgroundImage = Image.FromFile(@"C:\Users\Manuel NP\OneDrive\Documentos\C#\Imagenes SisAsistencia\minicloseR.png");
        }

        private void btn_Salir_MouseLeave(object sender, EventArgs e)
        {
            btn_Salir.BackgroundImage = Image.FromFile(@"C:\Users\Manuel NP\OneDrive\Documentos\C#\Imagenes SisAsistencia\minicloseB.png");
        }

        private void btn_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //MINIMIZAR
        }

        private void btn_mini_MouseEnter(object sender, EventArgs e)
        {
            btn_mini.BackgroundImage = Image.FromFile(@"C:\Users\Manuel NP\OneDrive\Documentos\C#\Imagenes SisAsistencia\miniR.png");
        }

        private void btn_mini_MouseLeave(object sender, EventArgs e)
        {
            btn_mini.BackgroundImage = Image.FromFile(@"C:\Users\Manuel NP\OneDrive\Documentos\C#\Imagenes SisAsistencia\miniB.png");
        }



        //BOTÓN DE PRUEBA CAMBIO DE FORMULARIO

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Registro_Personal rep = new Frm_Registro_Personal();

            rep.FormClosed += (senderForm, eForm) => this.Close(); // Cierra Form1 cuando Form2 se cierre

            this.Hide();
            rep.Show();
        }



        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        public void Cargar_Datos_usuario()
        {
            try
            {

                Frm_Filtro xfil = new Frm_Filtro();

                xfil.Show();
                MessageBox.Show("Bienvenido: " + Cls_UsuarioLogin.Apellidos, "Bienvenido al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                xfil.Hide();

                Lbl_NomUsu.Text = Cls_UsuarioLogin.Apellidos;
                lbl_rolNom.Text = Cls_UsuarioLogin.Rol;

                if (Cls_UsuarioLogin.Foto.Trim().Length == 0 | Cls_UsuarioLogin.Foto == null) return;

                if (File.Exists(Cls_UsuarioLogin.Foto) == true)
                {
                    pic_user.Load(Cls_UsuarioLogin.Foto);
                }
                else
                {
                    //pic_user.Load(Cls_UsuarioLogin.Foto);
                    //pic_user.Image = Properties.Resources.user; //My.Resources.user; //MUCHO OJO MUCHO OJO, NOOOOO SIRVEEEEE
                }
            }
            catch (Exception ex)
            {

            }
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


        // REVISAR LOS PROCEDIMIENTOS ALMACENADOS DE AQUI PARA EL HORARIO

        #region "Persona"

        private void ConfiguraListView()
        {
            var lis = lsv_person;
            lis.Columns.Clear();
            lis.Items.Clear();
            lis.View = View.Details;
            lis.GridLines = false;
            lis.FullRowSelect = true;
            lis.Scrollable = true;
            lis.HideSelection = false;

            //configuramos los anchos y nombres de las columnas:
            lis.Columns.Add("Num Trab", 60, HorizontalAlignment.Left);
            lis.Columns.Add("Nombre Completo", 250, HorizontalAlignment.Left);
            lis.Columns.Add("Fecha Nacimiento", 110, HorizontalAlignment.Left);
            lis.Columns.Add("Sexo", 40, HorizontalAlignment.Left);
            lis.Columns.Add("CURP", 140, HorizontalAlignment.Left);
            lis.Columns.Add("RFC", 100, HorizontalAlignment.Left);
            lis.Columns.Add("Correo", 180, HorizontalAlignment.Left);
            lis.Columns.Add("Numero Celular", 100, HorizontalAlignment.Left);
            lis.Columns.Add("Tipo", 35, HorizontalAlignment.Left);
            lis.Columns.Add("Rol", 100, HorizontalAlignment.Left);
            lis.Columns.Add("Estado", 50, HorizontalAlignment.Left);
        }

        private void Cargar_todo_Personal()
        {
            RN_Personal obj = new RN_Personal();
            DataTable dt = new DataTable();

            dt = obj.RN_Leer_todoPersona2();

            if (dt.Rows.Count > 0)
            {
                //Lamar metodo: Llenar Listview:
                LlenarListview(dt);
            }
        }

        /*private void Buscar_Personal_PorValor(string xvalor)
        {
            RN_Personal obj = new RN_Personal();
            DataTable dt = new DataTable();

            dt = obj.RN_Buscar_Personal_xValor(xvalor);
            if (dt.Rows.Count > 0)
            {
                //Llamamos al metodo: llenar listview:
                LlenarListview(dt);
            }
            else //Si escribimos algo que no está en la tabla...
            {
                lsv_person.Items.Clear(); //Limpiar todo, es decir, no mostrar nada
            }
        }*/

        private void Buscar_Personal_PorValor(string xvalor)
        {
            RN_Personal obj = new RN_Personal();
            DataTable dt = new DataTable();

            dt = obj.RN_Buscar_Personal_xValor(xvalor);
            if (dt.Rows.Count > 0)
            {
                //Llamamos al metodo: llenar listview:
                LlenarListview(dt);
            }
        }

        private void LlenarListview(DataTable data)
        {
            lsv_person.Items.Clear(); //Limpiar antes de llenar los datos

            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow dr = data.Rows[i];
                ListViewItem list = new ListViewItem(dr["Id_Pernl"].ToString()); //La cabecera del ListView
                list.SubItems.Add(dr["Nombre_Completo"].ToString());
                list.SubItems.Add(dr["Fec_Naci"].ToString());
                list.SubItems.Add(dr["Sexo"].ToString());
                list.SubItems.Add(dr["DNIPR"].ToString());
                list.SubItems.Add(dr["RFC"].ToString());
                list.SubItems.Add(dr["Correo"].ToString());
                list.SubItems.Add(dr["Celular"].ToString());
                list.SubItems.Add(dr["Tipo"].ToString());
                list.SubItems.Add(dr["NomRol"].ToString());
                list.SubItems.Add(dr["Estado_per"].ToString());


                //Id_Pernl, Nombre_Completo, Fec_Naci, Sexo, RFC, Correo, Celular, Foto, Tipo, id_rol, NomRol, Estado_Per, FinguerPrint

                lsv_person.Items.Add(list); //si no ponemos esto, el listview nunca se llenara
            }
            Lbl_total.Text = Convert.ToString(lsv_person.Items.Count); //Para contar la cantidad de filas que se encontraron
        }



        private void bt_personal_Click(object sender, EventArgs e)
        {
            // Asegúrate de que elTabPage2 esté habilitado y visible
            elTabPage2.Enabled = true;
            elTabPage2.Visible = true;

            // Ahora selecciona la segunda pestaña (Personal)
            elTab1.SelectTab(1); // cambia a la segunda pestaña

            // Carga los datos de la pestaña Personal
            Cargar_todo_Personal();
        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (txt_Buscar.Text.Trim().Length > 2)
            {
                Buscar_Personal_PorValor(txt_Buscar.Text.Trim());
            }
        }

        private void txt_Buscar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Buscar_Personal_PorValor(txt_Buscar.Text.Trim());
            }
        }

        private void bt_mostrarTodoElPersonal_Click(object sender, EventArgs e)
        {
            Cargar_todo_Personal();
        }

        private void bt_copiarNroDNI_Click(object sender, EventArgs e)
        {
            Frm_Advertencia adver = new Frm_Advertencia();
            Frm_Filtro fis = new Frm_Filtro();

            if(lsv_person.SelectedIndices.Count == 0) //Si hace esto no ha seleccionado nada
            {
                fis.Show();
                adver.Lbl_Msm1.Text = "Seleccione el elemento que desea copiar";
                adver.ShowDialog();
                fis.Hide(); return;
            }
            else //si es mayor a 0 si ha seleccionado una fila
            {
                var lsv = lsv_person.SelectedItems[0];
                string xdni = lsv.SubItems[0].Text;

                Clipboard.Clear();
                Clipboard.SetText(xdni.Trim());
            }
        }

        private void bt_nuevoPersonal_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Registro_Personal per = new Frm_Registro_Personal();

            fil.Show();
            per.xedit = false;
            per.ShowDialog();
            fil.Hide();

            if (Convert.ToString(per.Tag) == "") //si el tag del formulario está vacio no hace nada
                return;
            {
                Cargar_todo_Personal(); //de lo contrario si carga el personal
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Registro_Personal per = new Frm_Registro_Personal();

            fil.Show();
            per.xedit = false;
            per.ShowDialog();
            fil.Hide();

            if (Convert.ToString(per.Tag) == "") //si el tag del formulario está vacio no hace nada
                return;
            {
                Cargar_todo_Personal(); //de lo contrario si carga el personal
            }
        }

        private void bt_editarPersonal_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Registro_Personal per = new Frm_Registro_Personal();

            if (lsv_person.SelectedIndices.Count == 0)
            {
                //mostrar mensaje
            }
            else
            {
                var lsv = lsv_person.SelectedItems[0];
                string idpersona = lsv.SubItems[0].Text;

                fil.Show();
                per.Buscar_Personal_ParaEditar(idpersona);
                per.ShowDialog();
                fil.Hide();

                if(Convert.ToString(per.Tag) == "A")
                {
                    Cargar_todo_Personal();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frm_Advertencia adver = new Frm_Advertencia();
            Frm_Filtro fis = new Frm_Filtro();

            if (lsv_person.SelectedIndices.Count == 0) //Si hace esto no ha seleccionado nada
            {
                fis.Show();
                adver.Lbl_Msm1.Text = "Seleccione el elemento que desea copiar";
                adver.ShowDialog();
                fis.Hide(); return;
            }
            else //si es mayor a 0 si ha seleccionado una fila
            {
                var lsv = lsv_person.SelectedItems[0];
                string xdni = lsv.SubItems[0].Text;

                Clipboard.Clear();
                Clipboard.SetText(xdni.Trim());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Cargar_todo_Personal();
        }

        private void elTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Registro_Personal per = new Frm_Registro_Personal();

            if (lsv_person.SelectedIndices.Count == 0)
            {
                //mostrar mensaje
            }
            else
            {
                var lsv = lsv_person.SelectedItems[0];
                string idpersona = lsv.SubItems[0].Text;

                fil.Show();
                per.sevaeditar = true;
                per.Buscar_Personal_ParaEditar(idpersona);
                per.ShowDialog();
                fil.Hide();

                if (Convert.ToString(per.Tag) == "A")
                {
                    Cargar_todo_Personal();
                }
            }
        }

        private void Btn_Cerrar_TabPers_Click(object sender, EventArgs e)
        {
            // Deshabilitar elTabPage2
            elTabPage2.Enabled = false;
            elTabPage2.Visible = false;

            // Ahora selecciona la segunda pestaña (Personal)
            elTab1.SelectTab(0); // cambia a la primera pestaña
        }

        private void btn_cerrarEx_Asis_Click(object sender, EventArgs e)
        {
            // Deshabilitar elTabPage3
            elTabPage3.Enabled = false;
            elTabPage3.Visible = false;

            // Ahora selecciona la segunda pestaña (Personal)
            elTab1.SelectTab(0); // cambia a la primera pestaña
        }

        private void btn_cancel_horio_Click(object sender, EventArgs e)
        {
            // Deshabilitar elTabPage4
            elTabPage4.Enabled = false;
            elTabPage4.Visible = false;

            // Ahora selecciona la segunda pestaña (Personal)
            elTab1.SelectTab(0); // cambia a la primera pestaña
        }

        private void CargarHorarios()
        {
            RN_Horario obj = new RN_Horario();
            DataTable data = new DataTable();

            data = obj.RN_Leer_Horarios();
            if (data.Rows.Count == 0) return;

            lbl_idHorario.Text = Convert.ToString(data.Rows[0]["Id_Hor"]);
            dtp_horaIngre.Value = Convert.ToDateTime(data.Rows[0]["HoEntrada"]);
            dtp_horaSalida.Value = Convert.ToDateTime(data.Rows[0]["HoSalida"]);
            dtp_hora_tolercia.Value = Convert.ToDateTime(data.Rows[0]["MiTolrncia"]);
            Dtp_Hora_Limite.Value = Convert.ToDateTime(data.Rows[0]["HoLimite"]);
        }

        private void bt_Config_Click(object sender, EventArgs e)
        {
            // Habilitar y visibilizar elTabPage4
            elTabPage4.Enabled = true;
            elTabPage4.Visible = true;

            // Ahora selecciona la cuarta pestaña (Personal)
            elTab1.SelectTab(3); // cambia a la cuarta pestaña

            CargarHorarios();

            //string tipo;
            //tipo = RN_Utilitario.RN_Listar_TipoFalta(5);
        }

        private void btn_SaveHorario_Click(object sender, EventArgs e)
        {
            try
            {
                RN_Horario hor = new RN_Horario();
                EN_Horario por = new EN_Horario();

                Frm_Filtro fis = new Frm_Filtro();
                Frm_Msm_Bueno ok = new Frm_Msm_Bueno();
                Frm_Advertencia adv = new Frm_Advertencia();

                por.Idhora = lbl_idHorario.Text;
                por.HoEntrada = dtp_horaIngre.Value;
                por.HoTole = dtp_hora_tolercia.Value;
                por.HoLimite = Dtp_Hora_Limite.Value;
                por.HoSalida = dtp_horaSalida.Value;

                hor.RN_Actualizar_Horario(por);

                if(BD_Horario.saved == true)
                {
                    fis.Show();
                    ok.Lbl_msm1.Text = "El horario fue actualizado";
                    ok.ShowDialog();
                    fis.Hide();

                    // Deshabilitar elTabPage4
                    elTabPage4.Enabled = false;
                    elTabPage4.Visible = false;
                    // Ahora selecciona la segunda pestaña (Personal)
                    elTab1.SelectTab(0); // cambia a la primera pestaña
                }
            }
            catch
            {

            }
        }

        private void Frm_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Sino sino = new Frm_Sino();

            fil.Show();
            sino.Lbl_msm1.Text = "¿Estas seguro de Salir y Abandonar el Sistema?";
            sino.ShowDialog();
            fil.Hide();

            if (Convert.ToString(sino.Tag) == "Si")
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void bt_Explo_Asis_Click(object sender, EventArgs e)
        {
            // Habilitar y visibilizar elTabPage4
            elTabPage3.Enabled = true;
            elTabPage3.Visible = true;

            // Ahora selecciona la cuarta pestaña (Personal)
            elTab1.SelectTab(2); // cambia a la cuarta pestaña


            Cargar_Asistencias_delDia(dtp_fechadeldia.Value);
        }

        #endregion

        #region "asistencia"

        private void ConfigurarListView_Asis()
        {
            var lis = lsv_asis;
            lis.Columns.Clear();
            lis.Items.Clear();
            lis.View = View.Details;
            lis.GridLines = false;
            lis.FullRowSelect = true;
            lis.Scrollable = true;
            lis.HideSelection = false; //obviamente también lo puedo hacer desde sus propiedades todo desde aqui hasta arriba

            //configuramos los anchos y nombres de las columnas:
            lis.Columns.Add("Id Asis", 0,  HorizontalAlignment.Left); //Para que no se vea hay que poner 0
            lis.Columns.Add("Num Trab",     80, HorizontalAlignment.Left);
            lis.Columns.Add("Nombres", 316,HorizontalAlignment.Left);
            lis.Columns.Add("Fecha",   90, HorizontalAlignment.Left);
            lis.Columns.Add("Dia",     80, HorizontalAlignment.Left);
            lis.Columns.Add("Ingreso", 90, HorizontalAlignment.Left);
            lis.Columns.Add("Retraso", 70, HorizontalAlignment.Left);
            lis.Columns.Add("Salida",  90, HorizontalAlignment.Left);
            lis.Columns.Add("Adelanto",90, HorizontalAlignment.Left);
            //lis.Columns.Add("Justificacion", 0, HorizontalAlignment.Left);
            lis.Columns.Add("Estado",  100, HorizontalAlignment.Left);

        }


        private void LlenarListView_Asis(DataTable data)
        {
            lsv_asis.Items.Clear(); //Limpiar antes de llenar

            for(int i = 0; i < data.Rows.Count; i++)
            {
                DataRow dr = data.Rows[i];
                ListViewItem list = new ListViewItem(dr["Id_asis"].ToString()); //la cabecera del listview
                list.SubItems.Add(dr["Id_Pernl"].ToString());
                list.SubItems.Add(dr["Nombre_Completo"].ToString());
                list.SubItems.Add(dr["FechaAsis"].ToString());
                list.SubItems.Add(dr["Nombre_dia"].ToString());
                list.SubItems.Add(dr["HoIngreso"].ToString());
                list.SubItems.Add(dr["Tardanzas"].ToString());
                list.SubItems.Add(dr["HoSalida"].ToString());
                list.SubItems.Add(dr["Adelanto"].ToString());

                //list.SubItems.Add(dr["Justificacion"].ToString());
                list.SubItems.Add(dr["EstadoAsis"].ToString());
                lsv_asis.Items.Add(list); //Si no ponemos esto, el listview nunca se llenará
            }
            Lbl_total.Text = Convert.ToString(lsv_asis.Items.Count);
        }


        private void Cargar_todas_Asistencias()
        {
            RN_Asistencia obj = new RN_Asistencia();
            DataTable dt = new DataTable();

            dt = obj.RN_Ver_Todas_Asistencia();
            if(dt.Rows.Count > 0)
            {
                //Llamamos al metodo llenar listview:
                LlenarListView_Asis(dt);
            }
        }

        private void Cargar_Asistencias_delDia(DateTime fecha)
        {
            RN_Asistencia obj = new RN_Asistencia();
            DataTable dt = new DataTable();

            dt = obj.RN_Ver_Todas_Asistencia_Deldia(fecha);
            if (dt.Rows.Count > 0)
            {
                //Llamamos al metodo llenar listview:
                LlenarListView_Asis(dt);
            }
        }

        private void Cargar_Asistencias_delMes(DateTime fecha)
        {
            RN_Asistencia obj = new RN_Asistencia();
            DataTable dt = new DataTable();

            dt = obj.RN_Ver_Todas_Asistencia_DelMes(fecha);
            if (dt.Rows.Count > 0)
            {
                //Llamamos al metodo llenar listview:
                LlenarListView_Asis(dt);
            }
        }

        private void Cargar_Asistencias_porValor(String xvalor)
        {
            RN_Asistencia obj = new RN_Asistencia();
            DataTable dt = new DataTable();

            dt = obj.RN_Ver_Todas_Asistencia_ParaExplorador(xvalor);
            if (dt.Rows.Count > 0)
            {
                //Llamamos al metodo llenar listview:
                LlenarListView_Asis(dt);
            }
        }

        private void mostrarTodoAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cargar_todas_Asistencias();
        }

        private void txt_buscarAsis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cargar_Asistencias_porValor(txt_Buscar.Text);
            }
            else
            {
                MessageBox.Show("Escribe algo..." + MessageBoxButtons.OK + MessageBoxIcon.Information);
            }
        }

        private void lbl_lupaAsis_Click(object sender, EventArgs e)
        {
            Cargar_todas_Asistencias();
        }

        private void verAsistenciaDelDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Solo_Fecha solo = new Frm_Solo_Fecha();

            fil.Show();
            solo.ShowDialog();
            fil.Hide();

            if (Convert.ToString(solo.Tag) == "") return;

            DateTime xfecha = solo.dtp_fecha.Value;

            Cargar_Asistencias_delDia(xfecha);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Cargar_todas_Asistencias();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Solo_Fecha solo = new Frm_Solo_Fecha();

            fil.Show();
            solo.ShowDialog();
            fil.Hide();

            if (Convert.ToString(solo.Tag) == "") return;

            DateTime xfecha = solo.dtp_fecha.Value;

            Cargar_Asistencias_delDia(xfecha);
        }

        #endregion

        /*private void button5_Click(object sender, EventArgs e)
        {
            Frm_Explorador_Personal pers = new Frm_Explorador_Personal();
            pers.MdiParent = this;
            pers.Show();
        }*/
    }
}
