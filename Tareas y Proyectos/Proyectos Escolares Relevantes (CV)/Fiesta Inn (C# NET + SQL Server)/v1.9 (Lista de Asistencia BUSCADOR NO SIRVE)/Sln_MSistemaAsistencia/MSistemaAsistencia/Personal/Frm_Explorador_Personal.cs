using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSistemaAsistencia.Personal
{
    public partial class Frm_Explorador_Personal : Form
    {
        public Frm_Explorador_Personal()
        {
            InitializeComponent();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            elTab1.Visible = true;
            elTab1.SelectTab(1); // cambia a la segunda pestaña
        }


        private void Frm_Explorador_Personal_Load(object sender, EventArgs e)
        {

        }

        private void Frm_Explorador_Personal_MouseClick(object sender, MouseEventArgs e)
        {
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip();
        }
    }
}
