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
        internal Citas_Menu(Contextobd contextobd)
        {
            InitializeComponent();
            this.contextobd = contextobd;
        }

        private void Citas_Menu_Load(object sender, EventArgs e)
        {

        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Citas_Ver view = new Citas_Ver(contextobd);
            view.Show();
            view.FormClosed += (s, args) => this.Show();
            CitasController<Citas_Ver> citas = new CitasController<Citas_Ver>(view, contextobd);
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            this.Hide();
            Citas_Crear view = new Citas_Crear(contextobd);
            view.Show();
            view.FormClosed += (s, args) => this.Show();
            CitasController<Citas_Crear> citas = new CitasController<Citas_Crear>(view, contextobd);
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Citas_Modificar view = new Citas_Modificar(contextobd);
            view.Show();
            view.FormClosed += (s, args) => this.Show();
            CitasController<Citas_Modificar> citas = new CitasController<Citas_Modificar>(view, contextobd);
        }
    }
}
