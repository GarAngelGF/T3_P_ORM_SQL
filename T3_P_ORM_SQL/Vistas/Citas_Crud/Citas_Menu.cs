using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T3_P_ORM_SQL.Controladores;
using T3_P_ORM_SQL.Modelos;

namespace T3_P_ORM_SQL.Vistas.Citas_Crud
{
    public partial class Citas_Menu : Form
    {
        private readonly Contextobd contextobd;
        public Citas_Menu()
        {
            InitializeComponent();
        }

        private void Citas_Menu_Load(object sender, EventArgs e)
        {

        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Citas_Ver view = new Citas_Ver();
            view.Show();
            view.FormClosed += (s, args) => this.Show();
            CitasController<Citas_Ver> citas = new CitasController<Citas_Ver>(view, contextobd);
        }
    }
}
